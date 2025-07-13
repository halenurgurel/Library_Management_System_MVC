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

- **Ad Soyad:** (Kendi adını ekle)
- **Tarih:** (Teslim tarihi)

---

> Herhangi bir sorunda bana ulaşabilirsin!


