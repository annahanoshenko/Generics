using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDataStorage
{
    internal class DataStorage<T>
    {
        private List<T> items = new List<T> (); 

        public void Add(T item)
        {
            items.Add (item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void DisplayAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
