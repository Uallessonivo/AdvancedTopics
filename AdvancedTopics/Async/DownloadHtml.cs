using System.Net;

namespace AdvancedTopics.Async
{
    public static class DownloadHtml
    {
        public static void Download(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter("result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
