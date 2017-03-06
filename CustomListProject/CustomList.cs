using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        public T[] data;
        //public int item;
        private int count;
       
        

        public int Count { get { return count; } }

        

        public CustomList()
        {
            count = 0;
            data = new T[0];
        }
        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public void Add(T value)
        {
            
            T[] myList = new T[count + 1];
            
            for (int i = 0; i < count; i++)
            {
                myList[i] = data[i];
            }
            data = myList;
            data[count] = value;
            count++;
        }
      
        public bool Remove(T removedItem)
        {
            bool itemFound = false;
         
            for (int i = 0; i < count; i++)             
            {                                           
                if (data[i].Equals(removedItem))
                {
                    int indexFirstInstance = i;


                    for (int k = indexFirstInstance; k < Count - 1; k++)
                    {
                        data[k] = data[k + 1];
                        count -= 1;
                        if (data[k].Equals(removedItem))
                        {
                            return itemFound = true;
                        }
                        
                    }
                }
            }
            return itemFound;
        }
       
        public override string ToString()
        {
            string result = "";
            
            foreach (T value in data)
            {
                result += data[count].ToString() + ", ";
                
            }
            return result;
           
            
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> listResult = new CustomList<T>();

            foreach (T data in listOne)
            {
                listResult.Add(data);                
            }
            foreach (T data in listTwo)
            {
                listResult.Add(data);
            }
            return listResult;
            //ListOne + ListTwo
        }
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            foreach(T data in listTwo)
            {
                listOne.Remove(data);

            }
            return listOne;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return i;
            }
        }
        public CustomList<T> ZipList(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> zipList = new CustomList<T>();
            int list = 0;

            if (listOne.count == listTwo.count || listOne.count < listTwo.count)
            {
                list = listOne.count;
            }
            else if (listOne.count > listTwo.count)
            {
                list = listTwo.count;
            }
            for (int i = 0; i < list; i++)
            {
               
                if (i % 2 == 0)
                {
                    zipList[i] = listOne[i / 2];
                }
                else
                {
                    zipList[i] = listTwo[(i + 1) / 2];
                }
            }
            return zipList;

           
        }

    }
}
