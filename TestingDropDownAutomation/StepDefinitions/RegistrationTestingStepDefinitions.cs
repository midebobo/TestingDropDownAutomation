using System;
using TechTalk.SpecFlow;
using TestingDropDownAutomation.PageObject;

namespace TestingDropDownAutomation.StepDefinitions
{
    [Binding]
    public class RegistrationTestingStepDefinitions
    {
        RegistrationTesting registrationTesting;

        public RegistrationTestingStepDefinitions() 
        { 
        registrationTesting = new RegistrationTesting();
        
        
        }
        
        
        
        
        
        [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            registrationTesting.Navigatetowebsite(url);
        }

        [Given(@"I Enter my first name ""([^""]*)""")]
        public void GivenIEnterMyFirstName(string FirstName)
        {
            registrationTesting.Enterfirstname(FirstName);
        }

        [Given(@"I Enter my last name ""([^""]*)""")]
        public void GivenIEnterMyLastName(string LastName)
        {
            registrationTesting.Enterlastname(LastName);
        }

        [Given(@"I Enter my address ""([^""]*)""")]
        public void GivenIEnterMyAddress(string Address)
        {
            registrationTesting.Enteraddress(Address);
        }

        [Given(@"I Enter my email address ""([^""]*)""")]
        public void GivenIEnterMyEmailAddress(string EmailAddress)
        {
            registrationTesting.Enteremailaddress(EmailAddress);
        }

        [Given(@"I Enter my phone Number ""([^""]*)""")]
        public void GivenIEnterMyPhoneNumber(string PhoneNumber )
        {
          registrationTesting.Enterphonenumber(PhoneNumber);
        }

        [Given(@"I Click on Gender")]
        public void GivenIClickOnGender()
        {
            registrationTesting.ClickonGender();
        }

        [Given(@"I Click on Hobbies")]
        public void GivenIClickOnHobbies()
        {
            registrationTesting.ClickonHobbies();
        }

        [Given(@"I Select Languages")]
        public void GivenISelectLanguages()
        {
            registrationTesting.ClickonLanguages();
        }

        [Given(@"I Select Skills")]
        public void GivenISelectSkills()
        {
            registrationTesting.SelectfromDropdown();
        }

        [Given(@"I select Year of birth")]
        public void GivenISelectYearOfBirth()
        {
            registrationTesting.SelectfromYearofbirth();
        }

        [Given(@"I select Month of birth")]
        public void GivenISelectMonthOfBirth()
        {
            registrationTesting.SelectfromMonthofbirth();
        }

        [Given(@"I select Day of birth")]
        public void GivenISelectDayOfBirth()
        {
            registrationTesting.SelectfromDayofbirth();
        }

        [Given(@"I Enter my password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string Password)
        {
            registrationTesting.Enterpassword(Password);
        }

        [Given(@"I Enter my confirm Password ""([^""]*)""")]
        public void GivenIEnterMyConfirmPassword(string ConfirmPassword)

        {
           registrationTesting.Enterconfirmpassword(ConfirmPassword);
        }

        [When(@"I Click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            throw new PendingStepException();
        }
    }
}
