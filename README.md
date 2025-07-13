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

## Proje Görselleri / Images of the Project
## Ana Sayfa / Home Page
<img width="2514" height="1336" alt="anasayfa" src="https://github.com/user-attachments/assets/9ad86210-b2a9-4f86-b871-61e61a3ad206" />

## Hakkında Sayfası / About Page
<img width="2520" height="1334" alt="hakkında" src="https://github.com/user-attachments/assets/8ec78c30-e7a5-4cc6-b8a5-e1b964f371f6" />

## Kitap Listesi Sayfası / Book List Page
<img width="2520" height="1336" alt="kitaplistesi" src="https://github.com/user-attachments/assets/b6af2f0d-7489-41e2-82e8-37d5ca2fca56" />

## Kitap Detay Sayfası / Book Details Page
<img width="2520" height="1336" alt="kitapdetaysayfası" src="https://github.com/user-attachments/assets/afda101f-fd8a-41c2-94c5-4382f11c2969" />

## Kitap Düzenleme Sayfası / Book Editing Page
<img width="2520" height="1336" alt="kitapdüzenlemesayfası" src="https://github.com/user-attachments/assets/21617d81-a0fb-4f35-a127-28339677bf01" />

## Kitap Silme Sayfası / Deleting Page
<img width="2520" height="1334" alt="kitapsilme" src="https://github.com/user-attachments/assets/c2a2b4fe-bf72-4a59-8cfe-ab5a0b09fb28" />

## Kitap Ekleme Sayfası / Creating Page
<img width="2520" height="1336" alt="kitapekleme" src="https://github.com/user-attachments/assets/a4e16ff9-90bd-4918-891c-666326993bc0" />

## Silinmiş Kitaplar Sayfası / Deleted Books Page
<img width="2520" height="1336" alt="silinenkitaplar" src="https://github.com/user-attachments/assets/8660d3eb-f1d2-4f1f-bf62-ef7c8d08278c" />
<img width="2520" height="1334" alt="silinenkitaplar2" src="https://github.com/user-attachments/assets/373c915c-6082-4bd4-815e-c0d54bb539e9" />

## Yazar Listesi Sayfası / Author List Page
<img width="2520" height="1332" alt="yazarlistesi" src="https://github.com/user-attachments/assets/166cf601-b3b2-41d6-82e6-cb69a795cd51" />

## Yazar Detay Sayfası / Author Details Page
<img width="2520" height="1334" alt="yazardetay" src="https://github.com/user-attachments/assets/bd4e9597-402a-483e-8804-bbb33b554453" />

## Yazar Düzenleme Sayfası / Author Editing Page
<img width="2520" height="1342" alt="yazardüzenleme" src="https://github.com/user-attachments/assets/ff0ac37b-1566-4fba-a322-690f5f8c1c4b" />

## Yazar Silme Sayfası / Deleting Page
<img width="2520" height="1342" alt="yazarsilme" src="https://github.com/user-attachments/assets/666ec1b8-d6d9-411d-8306-43f01817c7a5" />

## Yazar Ekleme Sayfası / Author Creating Page
<img width="2520" height="1340" alt="yeniyazarekleme" src="https://github.com/user-attachments/assets/d5fe3396-8455-4c0f-b0a8-ebec2d109e0a" />

## Silinmiş Yazarlar Sayfası / Deleted Page
<img width="2520" height="1340" alt="silinenyazarlar" src="https://github.com/user-attachments/assets/a3f43243-37fe-4694-8411-3c5c4d90f488" />
<img width="2520" height="1334" alt="silinenyazarlar2" src="https://github.com/user-attachments/assets/99eec235-12ab-4295-bc62-c82ea094b66a" />



