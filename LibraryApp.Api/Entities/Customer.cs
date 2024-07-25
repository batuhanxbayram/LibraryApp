namespace LibraryApp.Api.Entities
{
    public class Customer: Citizen
    {
        public ICollection<Book> Books { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
