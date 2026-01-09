# 🛒 Sistem Informasi Retail Toserba (Desktop App)

![Status](https://img.shields.io/badge/Status-In%20Development-yellow)
![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-blue)
![Language](https://img.shields.io/badge/Language-C%23-green)

> **⚠️ PERHATIAN: Project ini sedang dalam tahap pengembangan aktif (Under Development).**
> Fitur mungkin belum lengkap dan struktur database masih bisa berubah sewaktu-waktu.

## 📖 Tentang Aplikasi
Aplikasi desktop berbasis Windows untuk manajemen toko serba ada (Toserba). Aplikasi ini dirancang untuk menangani transaksi penjualan, stok gudang, dan manajemen pengguna dengan antarmuka modern menggunakan **Material Design**.

Aplikasi ini mendukung multi-role:
1. **Admin**: Mengelola user dan melihat laporan.
2. **Kasir**: Melakukan transaksi penjualan (POS).
3. **Gudang**: Mengelola stok barang masuk dan keluar.

## 🛠️ Teknologi yang Digunakan
Project ini dibangun menggunakan:

* **Framework**: .NET Framework 4.8 (Windows Forms)
* **Bahasa**: C#
* **Database**: SQLite (Embedded Database)
* **ORM**: Dapper (Micro-ORM untuk akses data cepat)
* **UI Library**: [MaterialSkin.2](https://github.com/leocasti/MaterialSkin) (Theme Manager)

## 📂 Struktur Project
Aplikasi ini menggunakan pendekatan arsitektur MVC-like agar kode rapi dan mudah dikelola:

* `Views/`: Berisi Form antarmuka (UI).
* `Models/`: Representasi data (User, Barang, Transaksi).
* `Controllers/`: Logika bisnis aplikasi.
* `Data/`: Konfigurasi koneksi SQLite dan Dapper.
* `Database/`: Folder penyimpanan file fisik database (`.db`).

## 👥 Kontributor
* **Backend & Database**: Prasetyanto
* **Frontend & UI Design**: Fathan Nova


