using System;

namespace program8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]a=new int[5]{10,20,30,40,50};
            int max=a[0];
            int min=a[0];
		try
		{
            for(int i=0;i<a[i];i++)
            {
                if(a[i]>max)
                {
                    max=a[i];
                }
                else if(a[i]<min)
                {
                    min=a[i];
                }
            }
		}
		catch(Exception e)
		{
			Console.WriteLine("Exception caught");
		}
		finally
		{
           Console.WriteLine("maximum number:{0}",max);
           Console.WriteLine("minimum number:{0}",min);
		}
        }
    }
}
