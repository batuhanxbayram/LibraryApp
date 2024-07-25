namespace LibraryApp.Api.Entities
{
    public class Publisher: BaseEntity
    {
        public string PublisherName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
