using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDropDownAutomation.Utilities;

namespace TestingDropDownAutomation.PageObject
{
    class RegistrationTesting
    {
     public RegistrationTesting() 
        {

            driver = Hooks1.driver;
        
        
        
        }
          IWebDriver driver;

        IWebElement firstname => driver.FindElement(By.XPath("(//input[@type='text'])[1]"));
        IWebElement lastname => driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
        IWebElement address => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[2]/div/textarea"));
        IWebElement emailaddress => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement phonenumber => driver.FindElement(By.XPath("//input[@type='tel']"));
        IWebElement Gender => driver.FindElement(By.XPath("(//input[@type='radio'])[1]"));
        IWebElement Hobbies => driver.FindElement(By.XPath("(//input[@type='checkbox'])[1]"));
        IWebElement Languages => driver.FindElement(By.XPath("//*[@id=\"msdd\"]"));
      
        IWebElement skills => driver.FindElement(By.XPath("(//select[@type='text'])[1]"));
        IWebElement Yearofbirth => driver.FindElement(By.XPath("(//select[@type='text'])[3]"));
        IWebElement Monthofbirth => driver.FindElement(By.XPath("(//select[@type='text'])[4]"));
        IWebElement Dayofbirth => driver.FindElement(By.XPath("(//select[@type='text'])[5]"));
        IWebElement password => driver.FindElement(By.XPath("(//input[@type='password'])[1]"));
        IWebElement confirmpassword => driver.FindElement(By.XPath("(//input[@type='password'])[2]"));
        IWebElement submit => driver.FindElement(By.XPath(""));




        public void Navigatetowebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Enterfirstname(string FirstName)
        {
            firstname.SendKeys(FirstName);
        }

        public void Enterlastname(string LastName)
        {
            lastname.SendKeys(LastName);
        }

        public void Enteraddress(string Address)
        {
            address.SendKeys(Address);
        }

        public void Enteremailaddress(string EmailAddress)
        {
            emailaddress.SendKeys(EmailAddress);
        }

        public void Enterphonenumber(string Phonenumber)
        {
            phonenumber.SendKeys(Phonenumber);
        }

        public void ClickonGender() 
        { 
        
        Gender.Click();
        
        }

       public void ClickonHobbies() 
        { 
        Hobbies.Click();
        }


        public void ClickonLanguages() 
        { 
        Languages.Click();
          
        
        }
        






        public void SelectfromDropdown() 
        {
            SelectElement select = new SelectElement(skills);
            select.SelectByValue("Adobe Photoshop");

        }
         
        public void SelectfromYearofbirth() 
        {
            SelectElement select = new SelectElement(Yearofbirth);
            select.SelectByValue("1995");
        }

        public void SelectfromMonthofbirth() 
        { 
        SelectElement select =  new SelectElement(Monthofbirth);
            select.SelectByValue("April");
        }

        public void SelectfromDayofbirth() 
        {
            SelectElement select = new SelectElement(Dayofbirth);
            select.SelectByValue("27");
        }

        public void Enterpassword(string Password) 
        { 
        password.SendKeys(Password);
        }

        public void Enterconfirmpassword(string ConfirmPassword) 
        { 
        confirmpassword.SendKeys(ConfirmPassword);
        }









































    }
}
