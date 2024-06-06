namespace AdvancedTopics.Generics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            // var obj = new T(); // Error: Cannot create an instance of the variable type 'T'
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
