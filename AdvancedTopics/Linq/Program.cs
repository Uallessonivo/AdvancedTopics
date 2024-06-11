namespace AdvancedTopics.Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b;

            // LINQ Extension Methods
            var cheapBook = books
                .Where(book => book.Price < 10)
                .OrderBy(book => book.Title)
                .Select(book => book.Title);

            // LINQ Extension Methods
            var selectedBook = books.SingleOrDefault(book => book.Title == "Title 2");

            foreach (var book in cheapBook)
                Console.WriteLine(book);
        }
    }
}
