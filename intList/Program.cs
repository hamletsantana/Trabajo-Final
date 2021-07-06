using System;

namespace intList
{
    class IntList
    {
        private int[] data;
        private int length;
        public IntList()
        {
            data = new int[] {};
            length = 0;
        }

        public void Add(int num)
        {
            int [] array = new int [length + 1];
            data.CopyTo(array,0);
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
        public bool Remove(int num)
        {
            bool n = false;
            int cont = 0;
            int [] array_2 = new int[length];
            data.CopyTo(array_2, 0);

            foreach(int i in array_2)
            {
                if (i == num)
                {
                    n = true;
                    break;
                }
                cont++;
            }
            if (n == false)
                return n;
            for (int x = cont; x < length-1; x++)
                array_2[x] = array_2[x + 1];
            
            int[] array_3 = new int[length-1];
            Array.ConstrainedCopy(array_2,0, array_3, 0, length - 1);
            length--;
            data = array_3;
            return n;
        }
        public bool RemoveAll(int num)
        {
            if(Contains(num))
            {
                while (Contains(num))
                {
                    Remove(num);
                }
                return true;
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
            IntList lista = new IntList();

            lista.Add(5); 
            lista.Add(6);
            lista.isEmpty();
            lista.RemoveAll(5);
            Console.WriteLine(lista.Remove(5));  
        }
    }
}
