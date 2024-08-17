// Models/Book.cs
namespace Bibliotek.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Info { get; set; }

        public Author Author { get; set; }
    }
}
