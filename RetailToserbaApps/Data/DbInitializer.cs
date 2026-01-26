using System.IO;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace RetailToserbaApps.Data
{
    public static class DbInitializer
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void InitializeDatabase()
        {
            string dbFile = @"Database\RetailToserba.db";
            string dbFolder = Path.GetDirectoryName(dbFile);

            if (!Directory.Exists(dbFolder))
            {
                Directory.CreateDirectory(dbFolder);
            }

            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();

                // Tabel Users
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nama TEXT NOT NULL,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL CHECK(Role IN ('Admin', 'Gudang', 'Kasir')),
                        NoTelepon TEXT,
                        Status TEXT DEFAULT 'Active' CHECK(Status IN ('Active', 'Inactive')),
                        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                    );
                    -- Insert Admin Default
                    INSERT OR IGNORE INTO Users (UserId, Nama, Username, Password, Role, Status) 
                    VALUES (1, 'Super Admin', 'admin', 'admin123', 'Admin', 'Active');");

                // Tabel Kategori
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS Kategori (
                        KategoriId INTEGER PRIMARY KEY AUTOINCREMENT,
                        NamaKategori TEXT NOT NULL,
                        Deskripsi TEXT
                    );");

                // Tabel Supplier
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS Supplier (
                        SupplierId INTEGER PRIMARY KEY AUTOINCREMENT,
                        NamaSupplier TEXT,
                        NamaPerusahaan TEXT,
                        Alamat TEXT,
                        Email TEXT,
                        NoTelepon TEXT
                    );");

                // Tabel Barang
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS Barang (
                        BarangId INTEGER PRIMARY KEY AUTOINCREMENT,
                        KodeBarang TEXT NOT NULL UNIQUE,
                        NamaBarang TEXT NOT NULL,
                        Satuan TEXT,
                        HargaBarang INTEGER NOT NULL,
                        Expired DATE,
                        StokTersedia INTEGER DEFAULT 0,
                        StokMinimum INTEGER DEFAULT 5,
                        BrgMasukTotal INTEGER DEFAULT 0,
                        BrgKeluarTotal INTEGER DEFAULT 0,
                        Status TEXT DEFAULT 'Active' CHECK(Status IN ('Active', 'Inactive', 'Deleted')),
                        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                        KategoriId INTEGER,
                        SupplierId INTEGER,
                        UserId INTEGER,
                        FOREIGN KEY(KategoriId) REFERENCES Kategori(KategoriId) ON DELETE SET NULL,
                        FOREIGN KEY(SupplierId) REFERENCES Supplier(SupplierId) ON DELETE SET NULL,
                        FOREIGN KEY(UserId) REFERENCES Users(UserId)
                    );");

                // Tabel Transaksi
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS Transaksi (
                        TransaksiId INTEGER PRIMARY KEY AUTOINCREMENT,
                        NoInvoice TEXT NOT NULL UNIQUE,
                        Tanggal DATETIME DEFAULT CURRENT_TIMESTAMP,
                        Total INTEGER NOT NULL,
                        MetodePembayaran TEXT,
                        NamaKasir TEXT,
                        Status TEXT DEFAULT 'Completed' CHECK(Status IN ('Completed', 'Canceled')),
                        UserId INTEGER,
                        FOREIGN KEY(UserId) REFERENCES Users(UserId)
                    );");

                // Tabel DetailTransaksi
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS DetailTransaksi (
                        DetailId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Quantity INTEGER NOT NULL,
                        HargaSatuan INTEGER NOT NULL,
                        Subtotal INTEGER NOT NULL,
                        NamaBarang TEXT,
                        TransaksiId INTEGER NOT NULL,
                        BarangId INTEGER,
                        FOREIGN KEY(TransaksiId) REFERENCES Transaksi(TransaksiId) ON DELETE CASCADE,
                        FOREIGN KEY(BarangId) REFERENCES Barang(BarangId)
                    );");

                // Tabel LogActivity
                cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS LogActivity (
                        ActivityId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT,
                        Aktivitas TEXT,
                        Keterangan TEXT,
                        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                        UserId INTEGER,
                        FOREIGN KEY(UserId) REFERENCES Users(UserId)
                    );");
            }
        }
    }
}