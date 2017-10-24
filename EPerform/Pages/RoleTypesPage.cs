using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class RoleTypesPage
    {
        IWebDriver driver;

        public RoleTypesPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Manage Role Types')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Role Types')]")]
        public IWebElement TableHeading { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_RoleTypes_0__Name")]
        public IWebElement Reviewee_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleTypes_1__Name")]
        public IWebElement Reviewer_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleTypes_2__Name")]
        public IWebElement Manual_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleTypes_3__Name")]
        public IWebElement SecondLevelReviewer_TextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Cancel')]")]
        public IWebElement Cancel_Button { get; set; }


        public void ManageRoleTypesPageVerification()
        {

        }




    }
}
