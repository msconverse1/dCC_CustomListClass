using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSC_CustomListClass
{
    public class CustomList<T>
    {

        T[] items = new T[0];
        private int _count;
        //Count for the Arrays current size
       public int Count { get => _count; set => _count = value; }
        //Idexer declaration 
        public T this[int index] { get => items[index]; set => items[index] = value; }
        public void Add(T item)
        {
            Count = items.Length + 1;
            Array.Resize(ref items, Count);
            items[items.Length - 1] = item;  
        }

    }
}
