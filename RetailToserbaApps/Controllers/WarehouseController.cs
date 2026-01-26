using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailToserbaApps.Data;
using RetailToserbaApps.Models;

namespace RetailToserbaApps.Controllers
{
    public class WarehouseController
    {
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

        public List<Barang> SearchBarang(string searchTerm)
        {
            try
            {
                string sql = "SELECT * FROM Barang WHERE NamaBarang LIKE @Search OR KodeBarang LIKE @Search ORDER BY BarangId DESC";
                var parameters = new { Search = $"%{searchTerm}%" };
                return SqliteDataAccess.LoadData<Barang>(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to search products: {ex.Message}");
            }
        }

        public Barang GetBarangById(int barangId)
        {
            try
            {
                string sql = "SELECT * FROM Barang WHERE BarangId = @BarangId";
                var parameters = new { BarangId = barangId };
                List<Barang> result = SqliteDataAccess.LoadData<Barang>(sql, parameters);
                return result.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load product: {ex.Message}");
            }
        }

        public void InsertBarang(Barang barang)
        {
            try
            {
                string sql = @"INSERT INTO Barang (KodeBarang, NamaBarang, Satuan, HargaBarang, Expired, StokTersedia, StokMinimum, 
                              BrgMasukTotal, BrgKeluarTotal, Status, CreatedAt, KategoriId, SupplierId, UserId) 
                              VALUES (@KodeBarang, @NamaBarang, @Satuan, @HargaBarang, @Expired, @StokTersedia, @StokMinimum, 
                              @BrgMasukTotal, @BrgKeluarTotal, @Status, @CreatedAt, @KategoriId, @SupplierId, @UserId)";

                var parameters = new
                {
                    barang.KodeBarang,
                    barang.NamaBarang,
                    barang.Satuan,
                    barang.HargaBarang,
                    barang.Expired,
                    StokTersedia = barang.StokTersedia,
                    barang.StokMinimum,
                    BrgMasukTotal = barang.StokTersedia,
                    BrgKeluarTotal = 0,
                    Status = "Available",
                    CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    barang.KategoriId,
                    barang.SupplierId,
                    barang.UserId
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to insert product: {ex.Message}");
            }
        }

        public void UpdateBarang(Barang barang)
        {
            try
            {
                string sql = @"UPDATE Barang SET KodeBarang = @KodeBarang, NamaBarang = @NamaBarang, Satuan = @Satuan, 
                              HargaBarang = @HargaBarang, Expired = @Expired, StokTersedia = @StokTersedia, 
                              StokMinimum = @StokMinimum, Status = @Status, KategoriId = @KategoriId, SupplierId = @SupplierId 
                              WHERE BarangId = @BarangId";

                var parameters = new
                {
                    barang.BarangId,
                    barang.KodeBarang,
                    barang.NamaBarang,
                    barang.Satuan,
                    barang.HargaBarang,
                    barang.Expired,
                    barang.StokTersedia,
                    barang.StokMinimum,
                    barang.Status,
                    barang.KategoriId,
                    barang.SupplierId
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update product: {ex.Message}");
            }
        }

        public void DeleteBarang(int barangId)
        {
            try
            {
                string sql = "DELETE FROM Barang WHERE BarangId = @BarangId";
                var parameters = new { BarangId = barangId };
                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete product: {ex.Message}");
            }
        }

        public void AddStock(int barangId, int quantity)
        {
            try
            {
                string sql = @"UPDATE Barang SET StokTersedia = StokTersedia + @Quantity, 
                              BrgMasukTotal = BrgMasukTotal + @Quantity WHERE BarangId = @BarangId";

                var parameters = new
                {
                    BarangId = barangId,
                    Quantity = quantity
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to add stock: {ex.Message}");
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

        public void InsertKategori(Kategori kategori)
        {
            try
            {
                string sql = "INSERT INTO Kategori (NamaKategori, Deskripsi) VALUES (@NamaKategori, @Deskripsi)";

                var parameters = new
                {
                    kategori.NamaKategori,
                    kategori.Deskripsi
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to insert category: {ex.Message}");
            }
        }

        public void UpdateKategori(Kategori kategori)
        {
            try
            {
                string sql = "UPDATE Kategori SET NamaKategori = @NamaKategori, Deskripsi = @Deskripsi WHERE KategoriId = @KategoriId";

                var parameters = new
                {
                    kategori.KategoriId,
                    kategori.NamaKategori,
                    kategori.Deskripsi
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update category: {ex.Message}");
            }
        }

        public void DeleteKategori(int kategoriId)
        {
            try
            {
                string sql = "DELETE FROM Kategori WHERE KategoriId = @KategoriId";
                var parameters = new { KategoriId = kategoriId };
                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete category: {ex.Message}");
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

        public void InsertSupplier(Supplier supplier)
        {
            try
            {
                string sql = @"INSERT INTO Supplier (NamaSupplier, NamaPerusahaan, Alamat, Email, NoTelepon) 
                              VALUES (@NamaSupplier, @NamaPerusahaan, @Alamat, @Email, @NoTelepon)";

                var parameters = new
                {
                    supplier.NamaSupplier,
                    supplier.NamaPerusahaan,
                    supplier.Alamat,
                    supplier.Email,
                    supplier.NoTelepon
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to insert supplier: {ex.Message}");
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            try
            {
                string sql = @"UPDATE Supplier SET NamaSupplier = @NamaSupplier, NamaPerusahaan = @NamaPerusahaan, 
                              Alamat = @Alamat, Email = @Email, NoTelepon = @NoTelepon WHERE SupplierId = @SupplierId";

                var parameters = new
                {
                    supplier.SupplierId,
                    supplier.NamaSupplier,
                    supplier.NamaPerusahaan,
                    supplier.Alamat,
                    supplier.Email,
                    supplier.NoTelepon
                };

                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update supplier: {ex.Message}");
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            try
            {
                string sql = "DELETE FROM Supplier WHERE SupplierId = @SupplierId";
                var parameters = new { SupplierId = supplierId };
                SqliteDataAccess.SaveData(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete supplier: {ex.Message}");
            }
        }
    }
}
