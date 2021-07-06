using System;

namespace IntSet
{
    class IntList
    {
        private int[] data;
        private int length;
        public IntSet()
        {
            data = new int[] {};
            length = 0;
        }

        public void Add(int num)
        {
            int [] array = new int [length + 1];
            data.CopyTo(array,0);
            array[length] = num;
            data = array;
            length++;  
        }
        
        public bool Contains(int num)
        {
            foreach(int i in data)
            {
                if (i == num)
                {
                    return true;
                }
            }
            return false;
        }
        
        public int Length()
        {
            return length;
        }
        public int[] All()
        {
            return data;
        }
        public bool isEmpty()
        {
            if (length == 0)
            {
                return true;
            }
            return false;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
