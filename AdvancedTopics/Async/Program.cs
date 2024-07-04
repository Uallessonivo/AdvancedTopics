namespace AdvancedTopics.Async
{
    public class Program
    {
        static async void Main(string[] args)
        {
            DownloadHtml.Download("http://www.google.com");
            await DownloadHtmlAsync.Download("http://www.google.com");
        }
    }
}
