// Models/Author.cs
namespace Bibliotek.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        
        public string Name { get; set; } = string.Empty; // Ge ett default-värde för att undvika null-värden
        public ICollection<Book> Books { get; set; } = new List<Book>(); // Initialisera som en tom lista
    }
}
