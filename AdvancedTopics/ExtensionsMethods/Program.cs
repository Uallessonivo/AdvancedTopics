namespace AdvancedTopics.ExtensionsMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post...";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 4, 10, 24, 6 };
            var max = numbers.Max();

            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }
}
