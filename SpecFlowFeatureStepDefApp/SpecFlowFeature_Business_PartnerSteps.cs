using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace SpecFlowFeatureStepDef
{
    [Binding]
    public class SpecFlowFeature_Business_PartnerSteps
    {
        public IWebDriver driver;
        private static DefaultWait<IWebDriver> fluentWait;

        [Given(@"Enter valid user email and password")]
        public void GivenEnterValidUserEmailAndPassword()
        {


            driver = new ChromeDriver(@"C:\Users\akshay.nagare\source\repos\UnitTestProject1\drivers");

            // IWebDriver driver = new ChromeDriver(@"C:\Users\akshay.nagare\source\repos\SpecFlowAssignment\drivers");

            string url = "http://www.idempiere.org/test-sites";

            //string titleoldtab = driver.Title;

            //Console.WriteLine("old page title= " + titleoldtab);

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

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

            

        }

        [Given(@"click on Ok button")]
        public void GivenClickOnOkButton()
        {
            //click on the chechbox 
            IWebElement checkbox = driver.FindElement(By.XPath("//*[text()='Remember Me']"));
            checkbox.Click();

            //click on the ok button
            IWebElement okbutton = driver.FindElement(By.XPath("//*[@type='button']"));
            okbutton.Click();

            //Thread.Sleep(20000);
        }

        [Given(@"user selects Business Partner form Favorites")]
        public void GivenUserSelectsBusinessPartnerFormFavorites()
        {
            //waiting for processing
            Thread.Sleep(30000);

            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement businesspartner = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            businesspartner.Click();

        }

        [Given(@"click on close button")]
        public void GivenClickOnCloseButton()
        {
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement cancelbutton = fluentWait.Until(x => x.FindElement(By.XPath("//*[@title='Cancel']")));
            cancelbutton.Click();
        }
        
        [Given(@"Again open business partner form")]
        public void GivenAgainOpenBusinessPartnerForm()
        {
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement againbusinesspartner = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            againbusinesspartner.Click();

            
        }

        [Given(@"Fills The Form And Clicks On Reset Button")]
        public void GivenFillsTheFormAndClicksOnResetButton()
        {
            // enter search key
            Thread.Sleep(3000);
            //IWebElement searchkey = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));
            //searchkey.SendKeys("dummysearch");
            
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchkey = fluentWait.Until(x => x.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]")));
            searchkey.SendKeys("dummysearch");
            

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

        [Given(@"Again fill the form")]
        public void GivenAgainFillTheForm()
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

           
        }

        [Given(@"clik on ok button")]
        public void GivenClikOnOkButton()
        {
            //submit data
            IWebElement submitdata = driver.FindElement(By.XPath("//*[@title='OK']"));
            submitdata.Click();
        }
        
        [Given(@"clicks on new button")]
        public void GivenClicksOnNewButton()
        {
            //click on new business partner form
            /*fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement newtabdata = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='New    Alt+N']")));
            newtabdata.Click();*/


            Thread.Sleep(2000);
            IWebElement newtabdata = driver.FindElement(By.XPath("//a[@title='New    Alt+N']"));
            newtabdata.Click();

        }

        [Given(@"verifies business partner form is opened")]
        public void GivenVerifiesBusinessPartnerFormIsOpened()
        {
           
        }
        
        [When(@"Fill all required details")]
        public void WhenFillAllRequiredDetails()
        {
            //after click on new button  

            //SelectElement dropdown = new SelectElement(driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[4]/span[1]/input[1]")));
            //dropdown.SelectByText("Store");

            // name field
            Thread.Sleep(20000);
            IWebElement namefield = driver.FindElement(By.XPath("//input[@instancename='C_BPartner0Name']"));
            namefield.SendKeys("SANJIVANI");

            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchkeyfield = fluentWait.Until(x => x.FindElement(By.XPath("//input[@title='Search key for the record in the format required - must be unique']")));
            searchkeyfield.SendKeys("4000006");

            //logo window

            //IWebElement logo = driver.FindElement(By.XPath("//img[@instancename='C_BPartner0Logo_ID' and @src='/webui/zkau/web/b13c8796/img/spacer.gif']"));
            //logo.Click();
        }

        [Then(@"user records successfully saved")]
        public void ThenUserRecordsSuccessfullySaved()
        {
            //Save button
            Thread.Sleep(3000);
            IWebElement datasavebutton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[6]"));
            datasavebutton.Click();

        }
    }
}
