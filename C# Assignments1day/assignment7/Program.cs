using System;

namespace assignment7
{
    class Program
    {
        public void getdata()
        {
            int size;
            string []s=new string[100];
            Console.WriteLine("\n enter the size of array");
            size = Convert.Int32(Console.ReadLine());
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("array",size);
            }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
