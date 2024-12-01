using System.Collections;
using System.Linq;
namespace IEnumerator_yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intsss = new Fiveintegers(1, 2, 3, 4, 5);
            foreach (var i in intsss)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        class Fiveintegers : IEnumerable    
        {
            int[] _values;
            public Fiveintegers(int n1,int n2 ,int n3, int n4,int n5)
            {
                _values= new []{ n1,n2, n3,n4,n5};
            }
            public IEnumerator GetEnumerator()
            {
                foreach (var item in _values) 
                {
                    yield return item;
                }
            }
        }
    }
}
