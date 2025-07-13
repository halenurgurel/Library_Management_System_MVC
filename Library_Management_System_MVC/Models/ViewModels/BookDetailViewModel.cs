namespace Library_Management_System_MVC.Models.ViewModels
{
    //ViewModel'ı, Book ile Author bilgisini birlikte View'a taşımak için kullanıyoruz.
    //Bu şekilde view'da hem kitap hem yazar bilgisine erişebiliyoruz.
    public class BookDetailViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
