using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> intList = new CustomList<int>();
            intList.Add(1);
            intList.Add(2);
            Console.WriteLine(intList.Get(0));

            CustomList<string> stringList = new CustomList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine(stringList.Get(1));
        }
    }
}
