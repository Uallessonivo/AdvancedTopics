namespace AdvancedTopics.Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Title 1", Price = 5 },
                new Book() { Title = "Title 2", Price = 7 },
                new Book() { Title = "Title 3", Price = 17 }
            };
        }
    }
}
