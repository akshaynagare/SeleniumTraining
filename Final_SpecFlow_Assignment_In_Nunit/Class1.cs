using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace FinalAssignment
{

    public class Class1
    {
        public IWebDriver driver;
        private static DefaultWait<IWebDriver> fluentWait;


        [OneTimeSetUp]
        public void LoginWindow()
        {

            driver = new ChromeDriver(@"C:\Users\akshay.nagare\source\repos\UnitTestProject1\drivers");

            // IWebDriver driver = new ChromeDriver(@"C:\Users\akshay.nagare\source\repos\SpecFlowAssignment\drivers");

            string url = "http://www.idempiere.org/test-sites";

            //string titleoldtab = driver.Title;

            //Console.WriteLine("old page title= " + titleoldtab);

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/section[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[1]/a[1]"));
            element.Click();

            //after navigating second url

            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            //string titlenewtab = driver.Title;

            //Console.WriteLine("New page title= " + titlenewtab);

            Thread.Sleep(5000);



            IWebElement email = driver.FindElement(By.XPath("//*[@autocomplete='username']"));
            email.SendKeys("admin @ gardenworld.com");

            IWebElement password = driver.FindElement(By.XPath("//*[@autocomplete='current-password']"));
            password.SendKeys("GardenAdmin");

            //SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath("//*[@autocomplete='off']")));

            //SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//*[@autocomplete='off']")));
            //oSelect.SelectByIndex(3);

            //click on the chechbox 
            IWebElement checkbox = driver.FindElement(By.XPath("//*[text()='Remember Me']"));
            checkbox.Click();

            //click on the ok button
            IWebElement okbutton = driver.FindElement(By.XPath("//*[@type='button']"));
            okbutton.Click();

            //Thread.Sleep(20000);

        }


        [Test,Order(1)]
        public void Favourate_Business_partner()
        {
            //waiting for processing
            Thread.Sleep(40000);

            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement businesspartner = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            businesspartner.Click();



            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement cancelbutton = fluentWait.Until(x => x.FindElement(By.XPath("//*[@title='Cancel']")));
            cancelbutton.Click();
        }
        [Test,Order(2)]
        public void Again_Navigate_Business_partner_Reset()
        {

            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement againbusinesspartner = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            againbusinesspartner.Click();

            // enter search key
            Thread.Sleep(3000);
            IWebElement searchkey = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));
            searchkey.SendKeys("dummysearch");
            /*
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchkey = fluentWait.Until(x => x.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]")));
            searchkey.SendKeys("dummysearch");
            */

            //enter name
            IWebElement name = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));
            name.SendKeys("akshay");

            // enter name2
            IWebElement name2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/div[1]/div[1]/input[1]"));
            name2.SendKeys("nagare");

            //description 
            IWebElement description = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[2]/div[1]/div[1]/input[1]"));
            description.SendKeys("work on first automation  project");

            // Reset button
            IWebElement reset = driver.FindElement(By.XPath("//*[@title='Reset']"));
            reset.Click();

            Thread.Sleep(3000);
        }

        [Test,Order(3)]
        public void Again_Navigate_Business_Partner_OK()
        {
            //*Again fill blank fields//
            //Thread.Sleep(3000);

            IWebElement searchkey1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));
            searchkey1.SendKeys("dummysearch");

            //enter name
            IWebElement name12 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));
            name12.SendKeys("sairaj");

            // enter name2.2
            IWebElement name22 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/div[1]/div[1]/input[1]"));
            name22.SendKeys("nagare");

            //description 
            IWebElement description2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[2]/div[1]/div[1]/input[1]"));
            description2.SendKeys("successfully completed internship");

            //submit data
            IWebElement submitdata = driver.FindElement(By.XPath("//*[@title='OK']"));
            submitdata.Click();
        }

        [Test,Order(4)]
        public void New_Form_Button_Submit()
        {
            //click on new business partner form
            Thread.Sleep(20000);
            IWebElement newtabdata = driver.FindElement(By.XPath("//a[@title='New    Alt+N']"));
            newtabdata.Click();

            //after click on new button  

            //SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[4]/span[1]/input[1]")));
            //dropdown.SelectByText("Store");
            // name field
            Thread.Sleep(20000);
            IWebElement namefield = driver.FindElement(By.XPath("//input[@instancename='C_BPartner0Name']"));
            namefield.SendKeys("SANJIVANI");



            //Save button
            Thread.Sleep(20000);
            IWebElement datasavebutton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[6]"));
            datasavebutton.Click();

        }
    }
}
