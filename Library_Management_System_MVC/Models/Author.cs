namespace Library_Management_System_MVC.Models
{
    //Yazarlarla ilgili temel bilgileri tutar
    //Bu modeli OOP prensiplerine göre düzenliyoruz.
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsDeleted { get; set; }

        //navigation property - Yazarın kitaplarının listesinin olduğu bir property tanımlıyoruz.
        public List<Book> Books { get; set; }
    }
}
