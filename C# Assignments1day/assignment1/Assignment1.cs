using System;

namespace assignment1
{
    class assignment1
    {
       static void Main(string[] args)
        {
           int i,n,sum=0;
	       double avg;
	        Console.Write("Read 10 numbers from keyboard and calculate sum and average:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
	        Console.Write("Input the 10 numbers : \n");
	        for (i=1;i<=10;i++)
	        {
                Console.Write("Number-{0} :",i);
                n= Convert.ToInt32(Console.ReadLine());		//convert string values intoi integer
		        sum +=n;
	        }
	        avg=sum/10.0;
	        Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n",sum,avg);
    }
}
}


