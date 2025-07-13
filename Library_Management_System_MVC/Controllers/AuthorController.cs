using Library_Management_System_MVC.Models;
using Library_Management_System_MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System_MVC.Controllers
{
    public class AuthorController : Controller
    {

        public static List<Author> Authors = new List<Author>
        {
            new Author {Id = 1, FirstName = "Lev", LastName = "Tolstoy", DateOfBirth = new DateTime(1828, 9, 9) },
            new Author {Id = 2, FirstName = "Virginia", LastName = "Woolf", DateOfBirth = new DateTime(1882, 1, 25) },
            new Author {Id = 3, FirstName = "Erich", LastName = "Fromm", DateOfBirth = new DateTime(1900, 3, 23) }
        };
       

        //Tüm yazarların listelendiğii action (Author/list.cshtml'de görüntülenecek)
        public IActionResult List() //Yalnızca yazarların listesini döndürecek
        {
            var authorList = Authors.Where(a=> !a.IsDeleted) //Sadece Silinmemiş yazarlar.
                                    .ToList();      
            return View(authorList); //List.cshtml view'ına yazar listesi gönderiyoruz.
        }

        //Tek bir yazarın detaylarının gösterildiği action
        public IActionResult Details(int id)
        {
            //Parametredeki id'ye sahip yazarları bulacağız
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();

            var books = BookController.Books.Where(b => b.AuthorId == id).ToList();

            var viewModel = new AuthorDetailViewModel
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
                Author = author,
                Books = books
            };
            return View(viewModel);

            //FirstOrDefault listenin içinden ilk uygun elemanı bulur. 
            //a => a.Id == id her bir yazar için Id değeri verilen id'ye eşit mi diye kontrol eder. Bu şarta ilk uyan yarar author değişkenine atanır.
        }

        //Yeni yazar eklemek için formu gösterecek (GET)
        [HttpGet]
        public IActionResult Create()
        {
            return View(); //Create.cshtml view'unu dönecek
        }

        //Yeni yazar ekleme işlemi yapacağız (POST)
        [HttpPost]
        public IActionResult Create(Author author)
        {
            //Yeni yazara otomatik Id atayacak (varsa en yükssek id'nin 1 fazlası)
            author.Id = Authors.Count > 0 ? Authors.Max(a => a.Id) + 1 : 1; // Eğer listede yazar varsa Authors.Count, ?'den sonra koşul doğruysa çalışacak ifade bulunuyor. Bu ifade de Mevcut yazarların en büyük Id'sini buluyor ve 1 ekliyor. Eğer Koşul doğru değilse :'dan sonra çalışacak ifade bulunuyor. yani 1 yazacağız. 
            Authors.Add(author); //Yazarı listeye ekleyeccek
            return RedirectToAction("List"); //Listeye yönlendirecek
        }

        //Var olan yazarın düzenleme formunu gösterir. (GET)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();
            return View(author);
        }

        //Yazar düzenleme işlemini kaydeder (POST)

        [HttpPost]
        public IActionResult Edit(Author updatedAuthor)
        {
            //Düzenlenen yazarı listeden bulur
            var author = Authors.FirstOrDefault(a => a.Id == updatedAuthor.Id);
            if (author != null) //Eğer author null değilse
            {
                //Alanları yeni değerlerle günceller.
                author.FirstName = updatedAuthor.FirstName;
                author.LastName = updatedAuthor.LastName;
                author.DateOfBirth = updatedAuthor.DateOfBirth;
            }

            return RedirectToAction("List"); //Listeye döner
        }

        //Yazar silme onay sayfasını gösterecek (GET)
        //Get veriyi çeker/Gösterir, okur
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            //Silinecek yazarı bulur

            var author = Authors.FirstOrDefault( a => a.Id == id);
            return View(author);
        }

        //Yazar silme işlemi (POST)
        //[HttpPost]: sadece POST isteklerinde çalışıyor.
        //[ActionName("Delete")]: Bu metoda URL ve View'da "Delete" adıyla ulaşmayı sağlıyor.

        [HttpPost, ActionName("Delete")]
        //Bu kısımda yazar gerçekten silinir.
        //POST Veriyi değiştirir (ekleme/silme/güncelleme).
        public IActionResult DeleteConfirmed(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id); //Yine silinecekleri seçiyoruz.
            if (author != null) //Eğer authhor null değilse
            {
                author.IsDeleted = true; //Yazarı listeden çıkarır
            }
            return RedirectToAction("List"); //listeye döner.
        }

        public IActionResult DeletedList()
        {
            var deletedAuthors = Authors.Where(a=> a.IsDeleted).ToList();
            return View(deletedAuthors);
        }

        public IActionResult Restore(int id)
        {
            var author = Authors.FirstOrDefault(a => a.Id == id);
            if (author != null)
                author.IsDeleted = false;
            return RedirectToAction("DeletedList");

        }
    }
}
