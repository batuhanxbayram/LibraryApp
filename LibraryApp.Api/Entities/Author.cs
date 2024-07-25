namespace LibraryApp.Api.Entities
{
    public class Author: Citizen
    {

      public ICollection<Book> Books { get; set; }

    }
}
