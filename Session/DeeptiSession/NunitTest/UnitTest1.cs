using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver;
            
            String url="https://www.google.com/";

            driver=new ChromeDriver(@"E:\Session\DeeptiSession\NunitTest\drivers");
            driver.Navigate().GoToUrl(url);
            
            string title=driver.Title;
            Console.WriteLine("the page title is::"+title);
            
            int TitleLength=driver.Title.Length;
            Console.WriteLine("length is::"+TitleLength);

            String URL=driver.Url; 
            Console.WriteLine("the URL Is::"+URL);
            
            String Pagesrc=driver.PageSource;
            Console.WriteLine("Page source is::"+Pagesrc);

            driver.Close();
        }

        /* [Test] 
        public void Assign2()
        {
            IWebDriver driver;
            String url="https://www.toolsqa.com/automation-practice-form/";
            driver.FindElement(By.Xpath("//div[@id='main']//div[5]//a[1]//strong[1]"));
            driver=new ChromeDriver(@"E:\Session\DeeptiSession\NunitTest\drivers");
            driver.Navigate().GoToUrl(url);
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
        }*/
    }
}