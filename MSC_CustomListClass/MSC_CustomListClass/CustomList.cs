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
        int _count;
        private int _capacity;

        //Count for the Array 
        public int Count { get => _count; set => _count = value; }
        private int Capacity { get => _capacity; set => _capacity = value; }
        //Idexer declaration 
        public T this[int index] { get => items[index]; set => items[index] = value; }

        public  void Add(T item)
        {
            _count += 1;
            Resize();
            items[_count- 1] = item;
        }
        public static CustomList<T> operator + (CustomList<T> ListOne, CustomList<T> ListTwo)
        {
            CustomList<T> ReturnList = new CustomList<T>();
            
            int i = 0;
            for (; i < ListOne.Count; i++)
            {
                ReturnList.Add(ListOne[i]);
            }
            for (int j = 0; j < ListTwo.Count; j++)
            {
                ReturnList.Add(ListTwo[j]);
            }
            return ReturnList;
        }
        public static CustomList<T> operator -(CustomList<T> ListOne, CustomList<T> ListTwo)
        {
            /*parse ListOne if ListTwo Contains any index of ListOne 
               remove it from ListOne 
            */

            CustomList<T> ReturnList = new CustomList<T>();

            return ReturnList;
        }
        // TODO: Increase efficiency
        public bool Remove(T item)
        {
            
            if (Contains(item) == true)
            {
                int index = IsValueInIndex(item);
                for (int i = index; i < items.Length - 1; i++)
                {
                    items[i] = items[i + 1];
                }
               
            }
            return Contains(item);
        }
        //Resize a array only when the count == capacity
        public void Resize()
        {
            if (Capacity == 0)
            {
                Capacity = 4;
            }
            if (Count >= Capacity)
            {
                Capacity *= 2;
                T[] n_items = new T[Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    n_items[i] = items[i];
                }
                items = n_items;
            }
            else
            {
                T[] n_items = new T[Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    n_items[i] = items[i];
                }
                items = n_items;
            }
        }
        public int IsValueInIndex(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
               if( items[i].Equals(item))
                {
                    return i;
                }
            }
            return 0;
        }
        public  bool Contains(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
