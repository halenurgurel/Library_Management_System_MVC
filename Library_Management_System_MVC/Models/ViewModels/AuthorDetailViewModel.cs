namespace Library_Management_System_MVC.Models.ViewModels
{
    public class AuthorDetailViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Author Author { get; set; }
        public List<Book> Books { get; set; }
    }
}
