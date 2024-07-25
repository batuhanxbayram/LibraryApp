using LibraryApp.Api.Entities;

namespace LibraryApp.Api.DTO.GenresDTO
{
    public class NewGenreDTO
    {
        public string GenreName { get; set; }

        public Genre ToGenre()
        {
            return new Genre()
            {
                Id = 0,
                GenreName = this.GenreName,
            };
        }

    }
}
