using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RetailToserbaApps.Models;

namespace RetailToserbaApps.Data
{
    public class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql, object parameters = null)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<T>(sql, parameters).ToList();
            }
        }

        public static async Task<List<T>> LoadDataAsync<T>(string sql, object parameters = null)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var result = await cnn.QueryAsync<T>(sql, parameters);
                return result.ToList();
            }
        }

        public static void SaveData(string sql, object parameters)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(sql, parameters);
            }
        }
        public static async Task SaveDataAsync(string sql, object parameters)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync(sql, parameters);
            }
        }
        public static List<BarangView> LoadBarangView()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = @"
            SELECT 
                b.BarangId,
                b.KodeBarang, 
                b.NamaBarang, 
                s.NamaSupplier, 
                b.BrgMasukTotal, 
                b.StokTersedia, 
                b.CreatedAt, 
                u.Nama AS NamaUser
            FROM Barang b
            JOIN Supplier s ON b.SupplierId = s.SupplierId
            JOIN Users u ON b.UserId = u.UserId";

                var output = cnn.Query<BarangView>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
