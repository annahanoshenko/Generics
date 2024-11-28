using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Generic classes

    public class GenericClass<T>
    {
        private T data;

        public GenericClass(T value)
        {
            data = value;
        }
    
    public T GetData()
    {
        return data;
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> intObj = new GenericClass<int>(42);
            Console.WriteLine(intObj.GetData()); //42

            GenericClass<string> stringObj = new GenericClass<string>("Hello");
            Console.WriteLine(stringObj.GetData());

            int a = 5, b = 10;
            GenericMethods.Swap(ref a, ref b);
            Console.WriteLine($"{a}, {b}");

        }
    }
}
