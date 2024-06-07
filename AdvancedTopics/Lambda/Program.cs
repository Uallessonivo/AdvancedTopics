namespace AdvancedTopics.Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));
            Console.WriteLine(Square(5));


            const int factor = 5;
            Func<int, int> multiplier = number => number * factor;
            Console.WriteLine(multiplier(10));


            var books = new BookRepository().GetBooks();
            var cheaBooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheaBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static int Square(int number) => number * number;

        static bool IsCheaperThan10Dollars(Book book) => book.Price < 10;
    }
}
