using System;

namespace ServiceProject
{
    public class program
    {
        public int SimpleIntrest, RateOfIntrest=2;
        public int Period=2, amount=2000;
        /* public void getdata()
        {
            Console.WriteLine("\n Enter the Loan Amount");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter the No of year");
            Period = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Intrest");
            RateOfIntrest = Convert.ToInt32(Console.ReadLine());
        }*/



        /* public void display()
        {
            Console.WriteLine("Entered Amount are:");
            Console.WriteLine(amount);
            Console.WriteLine("Entered Period are:");
            Console.WriteLine(Period);
            Console.WriteLine("Entered Interest are:");
            Console.WriteLine(RateOfIntrest);
        }*/

        public void Calculate()
        {
            int Interest = amount * Period * RateOfIntrest / 100;
            int TotalAmt = amount + Interest;
            Console.WriteLine("Total Amount : {0}", TotalAmt);
            Console.ReadLine();
        }

       /*  static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest calculation Application");
            Program obj = new Program();
            obj.getdata();
            obj.display();
            obj.Calculate();
        }*/

    }
}
