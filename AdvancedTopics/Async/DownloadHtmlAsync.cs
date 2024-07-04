using System.Net;

namespace AdvancedTopics.Async
{
    public static class DownloadHtmlAsync
    {
        public static async Task Download(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter("result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
    }
}
