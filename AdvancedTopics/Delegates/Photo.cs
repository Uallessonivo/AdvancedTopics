namespace AdvancedTopics.Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            System.Console.WriteLine("Photo saved.");
        }
    }
}
