namespace stringArrayOfCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "a", "b", "c" };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}