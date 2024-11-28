using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            Console.WriteLine(numbers[0]);

            // ArrayList

            ArrayList number = new ArrayList();
            number.Add(1); //boxing
            number.Add(2);
            int value = (int)number[0];
            Console.WriteLine($"ArrayList value: {value}");

            // List<int>
            List<int> list = new List<int>();
            list.Add(1);
            int genericValue = list[0];
            Console.WriteLine($"List<int> value: {genericValue}");

            //collections

            List<string> names = new List<string> { "Alice", "Bob", "Charlie"}; //List<T>

            Dictionary<int, string> employees = new Dictionary<int, string>(); //Dictionary<TKey, TValue>
            employees.Add(1, "Alice");

            HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3 }; //HashSet<T>

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            Console.WriteLine(queue.Dequeue()); //Queue<T> і Stack<T>


        }
    }
}
