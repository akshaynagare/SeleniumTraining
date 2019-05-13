using NUnit.Framework;
using ServiceProject;
namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            program ob=new program();
            printdelegate ob1=new printdelegate(ob.printnum);
            ob1(1000);
            //Assert.Pass();
        }
    }
}