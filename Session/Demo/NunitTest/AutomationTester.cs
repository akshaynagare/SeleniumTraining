using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class AutomationTester
    {
        IWebDriver driver;
        string url="http://shop.demoqa.com/";

       [Test]
        public void SetupChromeLaunch()
        {
            
            driver = new ChromeDriver(@"E:\Session\Demo\NunitTest\drivers");
            driver.Navigate().GoToUrl(url);
            WebDriverWait wait =new WebDriverWait(driver,new TimeSpan(0,0,5));
            wait.Until(ExpectedConditions.ElementExists(By.ClassName("noo-search")));
            //driver.FindElement(By.ClassName("noo-search")).Click();//by class name

            driver.FindElement(By.LinkText("My Wishlist" )).Click();//linktext

            //IWebdriver element=driver.FindElement(By.PartialLinkText("My")).Click();//Partial link

            //IWebElement element=driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/header[1]/div[1]/div[1]/ul[2]/li[2]/a[1]"));/*absolute xpath */
            //element.Click();

            //IWebElement element=driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]"));//Relative path
            //element.Click();

            

            //try
          //{
           /*  IWebElement hlement=driver.FindElement(By.TagName("a"));//by tag name
            hlement.Click();
            }catch( Exception e)
            {
                Console.WriteLine("No such expection"+e.StackTrace);
            }
            */
            //IWebElement element=driver.FindElement(By.Id("yith-wcwl-popup-message"));//by id
            
           // IWebElement element=driver.FindElement(By.XPath("//a[contains(@href,'https://shop.demoqa.com/')]"));//hyperlink xpath
           // element .Click();




            //driver.Quit();



            

        

        //[Test]
        /* public void SetupIeBrowser()
        {
            driver = new InternetExplorerDriver(@"E:\Session\Demo\NunitTest\drivers");
            driver.Navigate().GoToUrl(url);
            driver.Close();
        }*/
        //[Test]
        /* public void SetUpMozillaFireFox()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"E:\Session\Demo\NunitTest\drivers");
           // service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl(url);
            driver.Quit();
        }*/

       /*  [Test]
        public void SetupEdgeLaunch()
        {
            driver=new EdgeDriver(@"E:\Session\Demo\NunitTest\drivers");
            driver.Navigate().GoToUrl(url);
            driver.Quit();
        }
        */
        }
    
    }
}
