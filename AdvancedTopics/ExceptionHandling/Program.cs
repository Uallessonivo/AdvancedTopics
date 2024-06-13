namespace AdvancedTopics.ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
