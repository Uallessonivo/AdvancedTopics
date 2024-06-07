namespace AdvancedTopics.Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;

            processor.Process("photo.jpg", filterHandler);
        }
    }
}
