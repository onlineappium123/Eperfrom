using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using NUnit.Framework;
using System.Collections;
using EPerform.Library;
using EPerform.Library.Excel;

using ePerfrom.Library;

namespace EPerform.Pages
{

    class LoginPage
    {
        IWebDriver _driver;

        public LoginPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        //Eperform usernameTestbox 
        [FindsBy(How = How.Id, Using = "Dto_UserName")]
        public IWebElement EPerformUserNameTextBox { get; set; }

        //Eperform PasswordTextBox
        [FindsBy(How = How.Id, Using = "Dto_Password")]
        public IWebElement EperformPasswordTextBox { get; set; }


        //Eperform ConfirmTextBox
        [FindsBy(How = How.Id, Using = "Dto_ConfirmPassword")]
        public IWebElement EperformConfirmPasswordTextBox { get; set; }


        //Eperform ConfirmTextBox
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Reset Password Successful')]")]
        public IWebElement EperformResetPasswordSuccessfulText { get; set; }


        //Eperform Submit button
        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement EperformSubmitButton { get; set; }


        //Eperform Username Text
        [FindsBy(How = How.XPath, Using = "//label[text()='Username']")]
        public IWebElement EperformUserNameText { get; set; }


        //Eperform Password text
        [FindsBy(How = How.XPath, Using = "//label[text()='Password']")]
        public IWebElement EperformPasswordText { get; set; }

        //Eperform ForgotPassword link
        [FindsBy(How = How.XPath, Using = "//a[text()='Forgot Password']")]
        public IWebElement EperformForgotPasswordLink { get; set; }


        //Eperform Welcome text 

        [FindsBy(How = How.XPath, Using = "//div//h3[contains(text(),'Welcome')]")]
        public IWebElement EperformWelcomeText { get; set; }

        //Eperform System AdministarArrowDropDownIcon
        [FindsBy(How = How.XPath, Using = "(//b[@class='fa fa-caret-down'])[1]")]
        public IWebElement EperformSystemAdministratorArrowDropDownIcon { get; set; }


        //Eperfrom Logout option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        public IWebElement EperformLogoutOption { get; set; }


        /// <summary>
        /// Eperform UserName BlankErrorMessage Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Username field is required.')]")]
        public IWebElement EperfromUserNameBlankErrorMessageText { get; set; }

        /// <summary>
        /// Eperform Password BlankErrorMessage Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Password field is required.')]")]
        public IWebElement EperfromPasswordBlankErrorMessageText { get; set; }



        /// <summary>
        /// Eperform Confirm Password BlankErrorMessage Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Confirm Password field is required.')]")]
        public IWebElement EperfromConfirmPasswordBlankErrorMessageText { get; set; }


        /// <summary>
        /// Eperform username,Password InvalidErrorMessage Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The username or password you entered is incorrect. Please check your details and try again.')]")]
        public IWebElement EperfromUserNamePasswordInvalidText { get; set; }

        ///<summary>
        ///Eperform cancel button
        ///</summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Cancel')]")]
        public IWebElement EperfromCancelBtn { get; set; }


        ///<summary>
        ///Eperform Return to the Login Page
        ///</summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Click here to return to the Login page')]")]
        public IWebElement EperfromReturnLoginPage { get; set; }

        //

        ///<summary>
        ///Eperform Return to the Login Page
        ///</summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email History')]")]
        public IWebElement EperfromEmailHistory { get; set; }



        ///<summary>
        ///Eperform Return to the Password Reset Request Link
        ///</summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Password Reset Request')]")]
        public IWebElement EperfromPasswordResetRequestLink { get; set; }

        /// <summary>
        /// Resuable method for the login
        /// </summary>

        public void Login(String username, String password)
        {



            System.Threading.Thread.Sleep(5000);

            BaseMethods.verifyWebElement(EperformUserNameText, "The usernametext is not displayed in the login page", "Username text is displayed in the login page");
            BaseMethods.verifyWebElement(EperformPasswordText, "The password text is not displayed in the login page", "password text is displayed in the login page");
            BaseMethods.verifyWebElement(EPerformUserNameTextBox, "The usernametextbox is not displayed in the login page", "Username textbox is displayed in the login page");
            EPerformUserNameTextBox.SendKeys(username);
            ExtentReport.test.Log(LogStatus.Info, username + "Entered value in the Username Text Field");
            BaseMethods.verifyWebElement(EperformPasswordTextBox, "The password textbox is not displayed in the login page", "PasswordTextbox is displayed in the login page");
            EperformPasswordTextBox.SendKeys(password);
            ExtentReport.test.Log(LogStatus.Info, password + "Entered value in the Password Text Field");
            BaseMethods.verifyWebElement(EperformSubmitButton, "Submit button is not displayed in the login page", "Submit Button is displayed in the login page");
            EperformSubmitButton.Click();
            System.Threading.Thread.Sleep(2000);
            BaseMethods.verifyWebElement(EperformWelcomeText, "Welcome Text is not displayed in the home page", "Welcome Text is displayed in the home page");

        }

        public ArrayList GetLoginDetails(string Key, string Sheet, string Condition, string Value)
        {
            ArrayList list = ExcelData.GetData(Key, Sheet, Condition, Value);
            return list;
        }

       

    }
}