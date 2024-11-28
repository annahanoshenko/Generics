using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    internal class CustomList<T>
    {
        private T[] items = new T[10];
        private int count = 0;

        public void Add(T item)
        {
            if (count < items.Length)
            {
                items[count++] = item;
            }
        }

        public T Get(int index)
        {
            if(index >= 0 && index < count)
            {
                return items[index];
            }
            throw new IndexOutOfRangeException();
        }
    }
}
