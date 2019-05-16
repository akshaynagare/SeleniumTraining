using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

  /*Alert and wait Demo :handle alert window and wait cmd */  

namespace Tests
{
    public class Test1
    {
        IWebDriver driver;
        string url="http://demo.guru99.com/test/delete_customer.php";

        [Test]
        public void AlertDemoSession()  
        {
        driver = new ChromeDriver(@"E:\Session\seesion154\NunitTest\drivers\");
        driver.Navigate().GoToUrl(url);
        
        //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(45));
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);//implicit wait

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));​

        //driver.FindElement(By.Name("cusid")).SendKeys("53920");
        driver.FindElement(By.Name("submit")).Submit();
        IAlert alert = driver.SwitchTo().Alert();da
        String alertMessage = alert.Text;
        Console.WriteLine("Alert message is " + alertMessage);
        Thread.Sleep(5000);
        alert.Accept();
        //driver.Close();
        }


        /* public void waitDemoSession()
        {
            driver=new ChromeDriver(@"http://demo.guru99.com/test/delete_customer.php");
            driver.Navigate().GoToUrl(url);
            driver.manage().timeouts.implicitlyWait(10,TimeUnit.SECONDS);
           
            driver.FindElement(By.Name("cusid")).SendKeys("53920");
            driver.FindElement(By.Name("submit")).Submit();
        }  */
    }
}