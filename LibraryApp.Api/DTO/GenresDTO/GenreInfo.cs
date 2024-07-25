using LibraryApp.Api.Entities;

namespace LibraryApp.Api.DTO.GenresDTO
{
    public  class GenreInfo
    {
        public string GenreName { get; set; }
        public int Id { get; set; }

        public static GenreInfo FromGenre (Genre genre)
        {


            return new GenreInfo() {
                GenreName=genre.GenreName,
                Id = genre.Id,
            };
        }
    }
}
