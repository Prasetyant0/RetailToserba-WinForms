using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RetailToserbaApps.Data;
using RetailToserbaApps.Models;

namespace RetailToserbaApps.Controllers
{
    public class CashierController
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public List<Barang> GetAllBarang()
        {
            try
            {
                string sql = "SELECT * FROM Barang ORDER BY BarangId DESC";
                return SqliteDataAccess.LoadData<Barang>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load products: {ex.Message}");
            }
        }
        public void SimpanTransaksi(Transaksi header, List<DetailTransaksi> details, string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                IDbTransaction transaction = cnn.BeginTransaction();

                try
                {
                    string sqlHeader = @"INSERT INTO Transaksi (NoInvoice, Tanggal, Total, UserId) 
                                        VALUES (@NoInvoice, @Tanggal, @Total, @UserId);
                                        SELECT last_insert_rowid();";

                    var headerParams = new
                    {
                        header.NoInvoice,
                        header.Tanggal,
                        header.Total,
                        header.UserId
                    };

                    var command = cnn.CreateCommand();
                    command.CommandText = sqlHeader;
                    command.Transaction = transaction;

                    AddParameter(command, "@NoInvoice", header.NoInvoice);
                    AddParameter(command, "@Tanggal", header.Tanggal);
                    AddParameter(command, "@Total", header.Total);
                    AddParameter(command, "@UserId", header.UserId);

                    int newTransaksiId = Convert.ToInt32(command.ExecuteScalar());

                    foreach (var detail in details)
                    {
                        string sqlDetail = @"INSERT INTO DetailTransaksi (TransaksiId, BarangId, Quantity, HargaSatuan, Subtotal) 
                                            VALUES (@TransaksiId, @BarangId, @Quantity, @HargaSatuan, @Subtotal)";

                        var detailCommand = cnn.CreateCommand();
                        detailCommand.CommandText = sqlDetail;
                        detailCommand.Transaction = transaction;

                        AddParameter(detailCommand, "@TransaksiId", newTransaksiId);
                        AddParameter(detailCommand, "@BarangId", detail.BarangId);
                        AddParameter(detailCommand, "@Quantity", detail.Quantity);
                        AddParameter(detailCommand, @"HargaSatuan", detail.HargaSatuan);
                        AddParameter(detailCommand, "@Subtotal", detail.Subtotal);

                        detailCommand.ExecuteNonQuery();

                        string sqlUpdateStok = @"UPDATE Barang SET StokTersedia = StokTersedia - @Quantity, 
                                                BrgKeluarTotal = BrgKeluarTotal + @Quantity 
                                                WHERE BarangId = @BarangId";

                        var updateStokCommand = cnn.CreateCommand();
                        updateStokCommand.CommandText = sqlUpdateStok;
                        updateStokCommand.Transaction = transaction;

                        AddParameter(updateStokCommand, "@Quantity", detail.Quantity);
                        AddParameter(updateStokCommand, "@BarangId", detail.BarangId);

                        updateStokCommand.ExecuteNonQuery();
                    }

                    string sqlLog = @"INSERT INTO LogActivity (Username, Aktivitas, Keterangan, CreatedAt, UserId) 
                                     VALUES (@Username, @Aktivitas, @Keterangan, @CreatedAt, @UserId)";

                    var logCommand = cnn.CreateCommand();
                    logCommand.CommandText = sqlLog;
                    logCommand.Transaction = transaction;

                    AddParameter(logCommand, "@Username", username);
                    AddParameter(logCommand, "@Aktivitas", "Transaksi Penjualan");
                    AddParameter(logCommand, "@Keterangan", $"Invoice {header.NoInvoice} - Total: Rp {header.Total:N0}");
                    AddParameter(logCommand, "@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    AddParameter(logCommand, "@UserId", header.UserId);

                    logCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Failed to save transaction: {ex.Message}");
                }
            }
        }

        private void AddParameter(IDbCommand command, string paramName, object value)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = paramName;
            parameter.Value = value ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }

        public string GenerateInvoiceNumber()
        {
            try
            {
                string prefix = "INV";
                string date = DateTime.Now.ToString("yyyyMMdd");

                string sql = "SELECT COUNT(*) FROM Transaksi WHERE DATE(Tanggal) = DATE('now')";
                var count = SqliteDataAccess.LoadData<int>(sql).FirstOrDefault();

                int nextNumber = count + 1;
                string invoiceNumber = $"{prefix}{date}{nextNumber:D4}";

                return invoiceNumber;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to generate invoice number: {ex.Message}");
            }
        }

        public List<Transaksi> GetTransaksiByKasir(int userId)
        {
            try
            {
                string sql = "SELECT * FROM Transaksi WHERE UserId = @UserId ORDER BY TransaksiId DESC";
                var parameters = new { UserId = userId };
                return SqliteDataAccess.LoadData<Transaksi>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load transactions: {ex.Message}");
            }
        }

        public List<DetailTransaksi> GetDetailTransaksi(int transaksiId)
        {
            try
            {
                string sql = "SELECT * FROM DetailTransaksi WHERE TransaksiId = @TransaksiId";
                var parameters = new { TransaksiId = transaksiId };
                return SqliteDataAccess.LoadData<DetailTransaksi>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load transaction details: {ex.Message}");
            }
        }

        public List<Barang> GetAvailableBarang()
        {
            try
            {
                string sql = "SELECT * FROM Barang WHERE Status = 'Active' AND StokTersedia > 0 ORDER BY NamaBarang";
                return SqliteDataAccess.LoadData<Barang>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load available products: {ex.Message}");
            }
        }

        public Barang SearchBarangByCode(string kodeBarang)
        {
            try
            {
                string sql = "SELECT * FROM Barang WHERE KodeBarang = @KodeBarang AND Status = 'Active' AND StokTersedia > 0";
                var parameters = new { KodeBarang = kodeBarang };
                List<Barang> result = SqliteDataAccess.LoadData<Barang>(sql, parameters);
                return result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to search product by code: {ex.Message}");
            }
        }
        public List<Kategori> GetAllKategori()
        {
            try
            {
                string sql = "SELECT * FROM Kategori ORDER BY NamaKategori";
                return SqliteDataAccess.LoadData<Kategori>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load categories: {ex.Message}");
            }
        }
        public List<Supplier> GetAllSupplier()
        {
            try
            {
                string sql = "SELECT * FROM Supplier ORDER BY NamaSupplier";
                return SqliteDataAccess.LoadData<Supplier>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load suppliers: {ex.Message}");
            }
        }
    }
}
