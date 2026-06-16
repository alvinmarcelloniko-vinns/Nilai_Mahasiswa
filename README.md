# Aplikasi Rekap Nilai Akademik Mahasiswa

Proyek ini adalah aplikasi desktop berbasis Windows Form yang berfungsi untuk menginput, menghitung, dan mengelola rekap nilai akademik mahasiswa secara terstruktur. Aplikasi ini dikembangkan menggunakan bahasa pemrograman **Visual Basic (VB.NET)** pada Visual Studio 2015 dan terintegrasi dengan database **SQL Server**.

## 📊 Fitur Utama Aplikasi
- **Input Data Akademik:** Memasukkan data mahasiswa meliputi NPM, Nama, Kode MK, Nama Mata Kuliah, serta komponen nilai (Kehadiran, Tugas, UTS, dan UAS).
- **Kalkulasi Nilai Otomatis:** Sistem secara otomatis menghitung Nilai Akhir berdasarkan bobot nilai yang telah ditentukan.
- **Penentuan Huruf Mutu (Grade):** Menampilkan nilai huruf (*Grade*) secara *real-time* (seperti Grade A, B, C, D, atau E) berdasarkan hasil Nilai Akhir mahasiswa.
- **Manajemen Data Berbasis CRUD:**
  - **TAMBAH:** Menyimpan rekap data nilai baru ke dalam database SQL Server.
  - **EDIT:** Memperbarui data atau komponen nilai mahasiswa yang sudah tersimpan.
  - **HAPUS:** Menghapus data rekap nilai dari sistem dan database.
- **Tampilan Tabel Interaktif:** Seluruh data yang tersimpan di database langsung dimuat secara rapi pada komponen *DataGridView* di bagian bawah aplikasi.

## 🛠️ Lingkungan Pengembangan & Teknologi
- **Bahasa Pemrograman:** Visual Basic .NET (VB.NET)
- **IDE:** Visual Studio 2015
- **Database:** SQL Server 2012 
- **Koneksi Database:** Menggunakan modul `conn.vb`

## 📂 Berkas Utama Proyek
- `Form1.vb` ➔ Menyimpan seluruh logika kode program (*source code*) utama untuk rumus perhitungan, kontrol input, dan fungsi tombol aksi.
- `Form1.Designer.vb` ➔ Menyimpan struktur desain tata letak antarmuka komponen form aplikasi.
- `conn.vb` ➔ Modul khusus yang mengatur jembatan koneksi antara aplikasi VB.NET dengan SQL Server.
- `Database/` ➔ Folder tempat meletakkan berkas script ekspor `.sql` agar skema tabel nilai mahasiswa bisa direplikasi di perangkat lain.
