﻿namespace LibraryApp.Api.Entities
{
    public class Genre: BaseEntity
    {
        public string GenreName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}