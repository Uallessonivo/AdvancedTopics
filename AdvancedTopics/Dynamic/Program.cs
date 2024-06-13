namespace AdvancedTopics.Dynamic
{
    public class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            obj.GetHashCode();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            dynamic excelObject = "mosh";
            excelObject.Optimize();
        }
    }
}
