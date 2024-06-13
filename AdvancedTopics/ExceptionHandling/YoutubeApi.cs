namespace AdvancedTopics.ExceptionHandling
{
    public partial class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access web service
                // Read the data
                // Create a list of video objects
                var api = new YoutubeApi();
                var videos = api.GetVideos(user);
            }
            catch (Exception ex)
            {
                // Log
                throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
            }

            return new List<Video>();
        }
    }
}
