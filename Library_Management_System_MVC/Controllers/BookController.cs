using Library_Management_System_MVC.Models;
using Library_Management_System_MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace Library_Management_System_MVC.Controllers
{
    public class BookController : Controller
    {

        public static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Title = "Savaş ve Barış", AuthorId = 1, Genre = "Roman", PublishDate = new DateTime(1867, 1, 1), ISBN = "978-975-05-1232-2", CopiesAvailable =1 },
            new Book {Id = 2, Title = "Orlando", AuthorId = 2, Genre = "Roman", PublishDate = new DateTime(1928, 10, 11), ISBN = "978-605-4927-65-4", CopiesAvailable = 1 },
            new Book { Id = 3, Title = "Marx'ın İnsan Anlayışı", AuthorId = 3, Genre = "Felsefe", PublishDate = new DateTime(1961, 1, 1), ISBN = "978-605-02-0366-0", CopiesAvailable = 1}


        };

        //Kitapların listesini gösteren action (Book/List.cshtml'de görüntülenir.
        public IActionResult List()
        {
            //Her kitao için yazar bilgisini AuthorController'dan alır.
            var bookList = Books.Where(b => !b.IsDeleted).Select(b => new BookDetailViewModel
            {
                Book = b,
                Author = AuthorController.Authors.FirstOrDefault(a => a.Id == b.AuthorId)
            }).ToList();

            if (bookList == null)
                bookList = new List<BookDetailViewModel>();
            return View(bookList);
        }

        //Belirli bir kitabın detayını gösteriyor
        public IActionResult Details(int id)
        {
            //Books listesinde id'si verilen kitabı buluyorum
            var book = Books.FirstOrDefault(b => b.Id == id);

            //Bu kitabın yazarını, AuthorController.Authors listesinden buluyorum
            var author = AuthorController.Authors.FirstOrDefault(a => a.Id == book.AuthorId);

            //Hem kitabı hem yazarı BookDetailViewModel adlı bir nesneye doldurduk.
            var viewModel = new BookDetailViewModel
            {
                Book = book,
                Author = author
            };
            return View(viewModel); //Details.cshtml view'ine gönderir.
        }

        //Yeni kitap ekleme formu (GET olacak)
        [HttpGet]
        public IActionResult Create()
        {
            //Yazarları dropdown olarak gösterebilmek için ViewBag ile yazar listesini gönderecek
            ViewBag.Authors = AuthorController.Authors;
            //ViewBag Controller'dan geçici olarak veri göndermek için kullanılır. Controller'da yazar listesini ViewBag ile View'a taşıyoruz.
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            //Id'yi otomaik belirleyecek. b.Id'yi seçtiğimizde eğer Books.Count sıfırdan büyükse Books.Max'ı seçecek ve en büyük Id'ye 1 ekleyecek, Eğer hiç books yoksa 1 olarak atayacak.
            book.Id = Books.Count > 0 ? Books.Max(b => b.Id) + 1 : 1;

            Books.Add(book);
            return RedirectToAction("List");
        }


        //Var olan kitabın düzenleme formunu gösterir. (GET)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            ViewBag.Authors = AuthorController.Authors;
            return View(book);
        }

        //POST
        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            var book = Books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book != null)
            {
                //Alanları yeni değerlerle güncelliyoruz
                book.Title = updatedBook.Title;
                book.AuthorId = updatedBook.AuthorId;
                book.Genre = updatedBook.Genre;
                book.PublishDate = updatedBook.PublishDate;
                book.ISBN = updatedBook.ISBN;
                book.CopiesAvailable = updatedBook.CopiesAvailable;

            }

            return RedirectToAction("List");
        }


        //Kitap silme onay sayfası
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);

            if (book != null)
            {
                book.IsDeleted = true;
            }
            return RedirectToAction("List");
        }

        public IActionResult DeletedList()
        {
            var deletedBooks = Books.Where(b => b.IsDeleted)
                                    .Select(b => new BookDetailViewModel
                                    {
                                        Book = b,
                                        Author = AuthorController.Authors.FirstOrDefault(a => a.Id == b.AuthorId)
                                    }).ToList();
            return View(deletedBooks);

        }

       public IActionResult Restore(int id)
        {
            var book = Books.FirstOrDefault(b=>b.Id == id);
            if (book != null)
                book.IsDeleted = false;
            return RedirectToAction("DeletedList");
        }

    }
}
