using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_31._10_
{
    public class CustomList<T>
    {
        int capacity;
        public T[] arr;
        List<T> list;
        int count;

        public CustomList()
        {

            capacity = 4;
            arr = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] newArr = new T[capacity];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                arr = newArr;
            }
            arr[count] = item;
            count++;
        }

        public T Find(Predicate<T> method)
        {
            T foundedItem = default;
            for (int i = 0; i < arr.Length; i++)
            {
                if (method(arr[i]))
                {
                    foundedItem = arr[i];
                    return foundedItem;
                }
            }
            return foundedItem;
        }

        public T[] FindAll(Predicate<T> method)
        {
            T[] newArr = new T[capacity];
            for (int i = 0; i < arr.Length; i++)
            {
                if (method(arr[i]))
                {
                    if (arr.Length > capacity)
                    {
                        capacity *= 2;

                        newArr = new T[arr.Length + 1];

                        for (int j = 0; j < arr.Length; j++)
                        {
                            newArr[i] = arr[i];
                        }

                        newArr[arr.Length - 1] = arr[i];

                    }
                }
            }
            return newArr;
        }

        public T FirstOrDefault(Predicate<T> method)
        {
            T FirstItem = default;

            for (int i = 0; i < arr.Length; i++)
            {
                if (method(arr[i]))
                {
                    FirstItem = arr[i];
                    break;
                }
            }

            return FirstItem;
        }

        public T FirstIndex()
        {
            T firstIndexItem = default;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    firstIndexItem = arr[i];
                }
            }

            return firstIndexItem;
        }

        public T LastIndex()
        {
            T lastIndexItem = default;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    lastIndexItem = arr[i];
                }
            }
            return lastIndexItem;
        }


        public bool Contains(Predicate<T> method)
        {
            bool condition = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (method(arr[i]))
                {
                    condition = true;
                }
            }
            return condition;
        }
    }
}
