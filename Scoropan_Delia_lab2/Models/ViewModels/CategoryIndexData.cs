namespace Scoropan_Delia_lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
