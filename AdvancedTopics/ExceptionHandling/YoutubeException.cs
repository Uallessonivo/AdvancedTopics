namespace AdvancedTopics.ExceptionHandling
{
    public partial class YoutubeApi
    {
        public class YoutubeException : Exception
        {
            public YoutubeException(string message, Exception innerException) : base(message, innerException)
            {

            }
        }
    }
}
