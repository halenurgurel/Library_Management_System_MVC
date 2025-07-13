# 📚 Kütüphane Yönetim Sistemi MVC – Dokümantasyon

## Proje Amacı

Bu proje, bir kütüphanedeki kitap ve yazar işlemlerini yönetmek için ASP.NET Core MVC teknolojisiyle geliştirilmiştir. Kullanıcılar kitap ve yazar ekleyebilir, düzenleyebilir, silebilir (soft delete), detay görüntüleyebilir ve silinen kayıtları geri alabilirler.

---

## Kurulum ve Çalıştırma

1. **Projeyi İndir/Yükle:**
   - Proje dosyalarını bilgisayarınıza indirin veya kopyalayın.
   - Görselleri (ör: `library.png`) `wwwroot/images` klasörüne ekleyin.

2. **Açmak için:**
   - Visual Studio ile `.sln` dosyasını açın.
   - Gerekirse bağımlılıkları yüklemek için **Restore** (sağ tık > Restore NuGet Packages) yapın.

3. **Çalıştırmak için:**
   - F5 tuşuna basın veya üstteki “Başlat” butonuna tıklayın.
   - Proje açıldığında varsayılan olarak ana sayfa açılır.

---

## Proje Yapısı

- **Controllers/**  
  - `BookController.cs` – Kitap işlemleri (listele, detay, ekle, düzenle, sil, silinenler)
  - `AuthorController.cs` – Yazar işlemleri (listele, detay, ekle, düzenle, sil, silinenler)

- **Models/**  
  - `Book.cs` – Kitap modeli
  - `Author.cs` – Yazar modeli

- **Models/ViewModels/**  
  - `BookDetailViewModel.cs` – Kitap ve yazar bilgilerini view’a taşımak için kullanılır
  - `AuthorDetailViewModel.cs` – Yazar ve kitap bilgilerini view’a taşımak için kullanılır

- **Views/**  
  - `Book/` – Kitaplara ait tüm view’lar (List, Details, Create, Edit, Delete, DeletedList)
  - `Author/` – Yazarlara ait tüm view’lar (List, Details, Create, Edit, Delete, DeletedList)
  - `Shared/_Layout.cshtml` – Tüm sayfalarda ortak kullanılan şablon ve navbar
  - `Shared/_FooterPartial.cshtml` – Footer alanı

- **wwwroot/**  
  - Statik dosyalar: görseller, css, js dosyaları

---

## Temel Özellikler

- **Kitap ve Yazar İşlemleri:**  
  - Ekleme, listeleme, detay, düzenleme, silme (soft delete)
- **Silinenler Listesi:**  
  - Silinen kitap ve yazarlar ayrı bir sayfada listelenir, istenirse geri alınabilir (Restore)
- **Ana Sayfa ve Hakkında:**  
  - Projenin amacı ve tanıtımı
- **Duyarlı (Responsive) Tasarım:**  
  - Bootstrap ile masaüstü ve mobil uyumlu arayüz
- **Partial View ve Layout Kullanımı:**  
  - Footer ve navbar ortak şablon olarak kullanılmıştır

---

## Nasıl Kullanılır?

1. **Kitaplar/Yazarlar menüsünden** kitap ve yazar listesine erişilir.
2. “Yeni Ekle” butonu ile yeni kayıt eklenir.
3. Liste üzerinden “Detay”, “Düzenle”, “Sil” işlemleri yapılabilir.
4. “Silinenler” menüsünden, silinen kitap veya yazarlar listelenir ve gerekirse “Geri Al” ile aktif hale getirilir.

---

## Yapılandırma

- **Statik veri kullanımı:**  
  - Bu proje eğitim amaçlı olduğundan, kitaplar ve yazarlar bellekte (List ile) tutulmaktadır. Gerçek ortamda veritabanı kullanılması önerilir.
- **Soft Delete:**  
  - Silinen kitap veya yazarlar aslında veri kaybı olmadan `IsDeleted` özelliği ile işaretlenir.
- **Bootstrap:**  
  - Modern ve responsive tasarım için kullanılır.

---

## Test Etme

- Uygulama açıldıktan sonra:
  - Tüm ekle/düzenle/sil işlemlerini deneyin.
  - Silinen bir kaydı “Silinenler” menüsünde görün ve “Geri Al” ile geri getirin.
  - Kitap ve yazar ekleyip, ilişkili şekilde birbirlerini görebildiklerini kontrol edin.
  - Responsive tasarımın mobilde düzgün çalıştığından emin olun.

---

## Bilinen Kısıtlar

- Veriler **geçici olarak RAM’de** tutulduğu için, proje kapanınca eklenen kayıtlar silinir.
- Gerçek veri kalıcılığı için Entity Framework ve bir veritabanı kullanılması gerekir.

---

## Geliştirme Fikirleri

- Veritabanı entegrasyonu (Entity Framework)
- Kullanıcı giriş/çıkış (authentication)
- Kütüphane yönetiminde ödünç alma/teslim gibi ek modüller
- Kayıt arama ve filtreleme
- PDF/Excel rapor alma

---

## Geliştirici

- **Ad Soyad:** Halenur Gurel
- **Tarih:** 13.07.2025

---

> Herhangi bir sorunda bana ulaşabilirsin!

# 📚 Library Management System MVC – Documentation

## Project Purpose

This project is a web application built with ASP.NET Core MVC for managing book and author operations in a library. Users can add, edit, delete (soft delete), view details of books and authors, and restore deleted records.

---

## Setup and Running

1. **Download or Clone the Project:**
   - Download or clone all project files to your computer.
   - Add images (e.g., `library.png`) to the `wwwroot/images` folder.

2. **Open the Project:**
   - Open the `.sln` file in Visual Studio.
   - If necessary, right-click on the solution and select **Restore NuGet Packages**.

3. **Run the Project:**
   - Press the F5 key or click the "Start" button at the top.
   - The project will launch and the home page will open by default.

---

## Project Structure

- **Controllers/**  
  - `BookController.cs` – Book operations (list, details, add, edit, delete, deleted items)
  - `AuthorController.cs` – Author operations (list, details, add, edit, delete, deleted items)

- **Models/**  
  - `Book.cs` – Book model
  - `Author.cs` – Author model

- **Models/ViewModels/**  
  - `BookDetailViewModel.cs` – Transfers book and author info to the view
  - `AuthorDetailViewModel.cs` – Transfers author and book info to the view

- **Views/**  
  - `Book/` – Views for books (List, Details, Create, Edit, Delete, DeletedList)
  - `Author/` – Views for authors (List, Details, Create, Edit, Delete, DeletedList)
  - `Shared/_Layout.cshtml` – Common layout and navbar for all pages
  - `Shared/_FooterPartial.cshtml` – Footer partial

- **wwwroot/**  
  - Static files: images, css, js files

---

## Main Features

- **Book and Author Operations:**  
  - Add, list, view details, edit, delete (soft delete)
- **Deleted Items List:**  
  - Deleted books and authors are listed on a separate page and can be restored if desired
- **Home and About Pages:**  
  - Introduction and description of the project
- **Responsive Design:**  
  - Modern and mobile-friendly UI using Bootstrap
- **Partial View and Layout Usage:**  
  - Common footer and navbar with partial views

---

## How to Use

1. **Access the Books/Authors menu** to see the lists.
2. Use the "Add New" button to add new records.
3. You can view details, edit, or delete any item from the list.
4. View the "Deleted Items" menu to see deleted books or authors, and restore them if necessary.

---

## Configuration

- **Static Data Usage:**  
  - For educational purposes, data is kept in memory using lists. For real-life usage, a database should be used.
- **Soft Delete:**  
  - Deleted books or authors are not lost; they are flagged with the `IsDeleted` property.
- **Bootstrap:**  
  - For modern, responsive design.

---

## Testing

- After launching the application:
  - Try all add/edit/delete operations.
  - After deleting a record, check if it appears in the "Deleted Items" list and can be restored.
  - Add books and authors and verify their relationship is correctly shown.
  - Check the responsive design on mobile devices.

---

## Known Limitations

- Since data is stored **temporarily in memory (RAM)**, all records will be lost when the project is closed.
- For persistent data storage, integration with Entity Framework and a real database is recommended.

---

## Suggestions for Improvement

- Database integration (Entity Framework)
- User authentication (login/logout)
- Additional modules for library management (borrowing/returning books)
- Search and filtering features
- Exporting reports (PDF/Excel)

---

## Developer

- **Name:** Halenur Gurel
- **Date:** 13.07.2025

---

> Feel free to contact me if you have any questions!

