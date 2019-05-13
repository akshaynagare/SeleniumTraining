using System;

namespace assignment5
{
    class twodmatrix
    {
    int m, n;
        int[,] aarr;
        int[] barr;
        twodmatrix(int x, int y)
        {
            m = x;
            n = y;
            aarr = new int[m, n];
            barr = new int[m * n];
        }
        public void readmatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    aarr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void printd()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", aarr[i, j]);
 
                }
                Console.Write("\n");
            }
        }
        public void convert()
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    barr[k++] = aarr[i, j];
                }
            }
        }
        public void printoned()
        {
            for (int i = 0; i < m * n; i++)
            {
                Console.WriteLine("{0}\t", barr[i]);
            }
        }
 
 
        public static void Main(string[] args)
        {
            twodmatrix obj = new twodmatrix(2,3);
            Console.WriteLine("Enter the Elements : ");
            obj.readmatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.printd();
            obj.convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.printoned();
            Console.ReadLine();
        }
    }
}