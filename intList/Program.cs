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
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntList lista = new IntList();

            lista.Add(5);   
        }
    }
}
