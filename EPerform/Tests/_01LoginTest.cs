using ePerform.Library.Extent_Reports;
using EPerform.Library;

using EPerform.Pages;
using ePerfrom.Library;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Tests
{
   [TestFixture]
   public  class _01LoginTest 
   {


      static IWebDriver _driver;


        [OneTimeSetUp]
        public void OneTimeIntialize()
        {
            ExtentReport.CExtentReport();
        }

        [SetUp]
        public void Initialize()
        {
            _driver = BaseClass.LaunchBrowser();
        }

        /// <summary>
        /// @Description:Verify the Login Page
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(1)]
        [TestCase(Description = "Verify the Login Page")]
        
        public void verifyLoginpage()
        {
            ExtentReport.CExtentReport();
            ExtentReport.test = ExtentReport.extent.StartTest("Verify the Login Page");
            LoginPage login = new LoginPage(_driver);
            BaseMethods.verifyWebElement(login.EperformUserNameText, "Eperform UserName Text is not displayed in login page", "Eperform UserName Text is displayed in login page");
            BaseMethods.verifyWebElement(login.EperformPasswordText, "Eperform Password Text is not displayed in login page", "Eperform Password Text  is  displayed in login page");
            BaseMethods.verifyWebElement(login.EperformSubmitButton, "Eperform Submit Button is not displayed in login page", "Eperform Submit Button is  displayed in login page");
            BaseMethods.verifyWebElement(login.EperformForgotPasswordLink, "Eperform ForgotPassword Link is not displayed in login page", "Eperform ForgotPassword Link  is  displayed in login page");
        }

        /// <summary>
        /// @Description:Login to the Eperform Application
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(2)]
        [TestCase(Description = "Login to the Eperform Application")]
       
        public void loginEperformApplicaton()
        {
            ExtentReport.CExtentReport();
            ExtentReport.test = ExtentReport.extent.StartTest("Login to the Application");
            LoginPage login = new LoginPage(_driver);
            ArrayList list = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "Admin");
            string username = list[1].ToString();
            string pwd = list[2].ToString();
            login.Login(username, pwd);
            login.EperformSystemAdministratorArrowDropDownIcon.Click();
            BaseMethods.verifyWebElement(login.EperformLogoutOption, "The Logout option is not displayed in the home page", "Logout option is displayed in the Home page");
           
            login.EperformLogoutOption.Click();

        }
        /// <summary>
        ///  @Description:Verify the Uername,Password invalid and blank error message text
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(3)]
        [TestCase(Description = "Verify the Uername,Password invalid and blank error message text")]
      
        public void verifyUsernamePasswordInvalidBlankErrorMessage()
        {
            ExtentReport.CExtentReport();
            ExtentReport.test = ExtentReport.extent.StartTest("Verify the Login Page");
            LoginPage login = new LoginPage(_driver);
            ArrayList list = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "User3");
            login.EperformSubmitButton.Click();
            BaseMethods.verifyWebElement(login.EperfromUserNameBlankErrorMessageText, "The Username field is required. is not displayed in login page", "The Username field is required. is displayed in login page");
            BaseMethods.verifyWebElement(login.EperfromPasswordBlankErrorMessageText, "The Password field is required. is not displayed in login page", "he Password field is required. is displayed in login page");
            login.EPerformUserNameTextBox.SendKeys(list[1].ToString());
            login.EperformPasswordTextBox.SendKeys(list[2].ToString());
            login.EperformSubmitButton.Click();
            BaseMethods.verifyWebElement(login.EperfromUserNamePasswordInvalidText, "The username or password you entered is incorrect. Please check your details and try again. is not displayed in login page", "The username or password you entered is incorrect. Please check your details and try again. is displayed in login page");
           
        }


        ///// <summary>
        /////  @Description:Verify Change Password Option
        ///// @Author:RaghuKiran MR
        ///// </summary>
        //[Test, Order(4)]
        //[TestCase(Description = "Verify Change Password Option")]
       
        //public void verifyChangePasswordOption()
        //{
        //    ExtentReport.CExtentReport();
        //    ExtentReport.test = ExtentReport.extent.StartTest("Verify the Login Page");
        //    LoginPage login = new LoginPage(_driver);
        //    HomePage home = new HomePage(_driver);
        //    FormTemplatePage formtemplate = new FormTemplatePage(_driver);
        //    ArrayList list = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "User3");
        //    string username = list[1].ToString();
        //    string pwd = list[2].ToString();
        //    login.Login(username, pwd);
        //    login.EperformSystemAdministratorArrowDropDownIcon.Click();
        //    home.EperformChangePasswordOption.Click();
        //    System.Threading.Thread.Sleep(2000);
        //    login.EperformSubmitButton.Click();
        //    System.Threading.Thread.Sleep(2000);
        //    BaseMethods.verifyWebElement(home.EperformNewPasswordErrorText, "The New Password field is required. is not displayed in change password page", "The New Password field is required. is displayed in change password page");
        //    BaseMethods.verifyWebElement(home.EperformConfirmNewPasswordErrorText, "The Confirm New Password field is required is not displayed in change password page", "The Confirm New Password field is required is displayed in change password page");
        //    BaseMethods.verifyWebElement(home.EperformCurrentPasswordErrorText, "The Current Password field is required is not displayed in change password page", "The Current Password field is required is displayed in change password page");
        //    ArrayList list2 = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "ChangePassword");
        //    System.Threading.Thread.Sleep(2000);
        //    home.EperformCurrentPasswordTextBox.SendKeys(list[2].ToString());
        //    home.EperformNewPasswordTextBox.SendKeys(list2[1].ToString());
        //    home.EperformConfirmNewPassword.SendKeys(list2[2].ToString());
        //    login.EperformSubmitButton.Click();
        //    System.Threading.Thread.Sleep(4000);
        //    login.EperformSystemAdministratorArrowDropDownIcon.Click();
        //    login.EperformLogoutOption.Click();
        //    System.Threading.Thread.Sleep(2000);
        //    ArrayList list3 = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "User2");
        //    login.EPerformUserNameTextBox.SendKeys(list3[1].ToString());
        //    login.EperformPasswordTextBox.SendKeys(list3[2].ToString());
        //    login.EperformSubmitButton.Click();
        //    BaseMethods.verifyWebElement(login.EperfromUserNamePasswordInvalidText, "The username or password you entered is incorrect. Please check your details and try again. is not displayed in login page", "The username or password you entered is incorrect. Please check your details and try again. is displayed in login page");
        //    login.EperformPasswordTextBox.Clear();
        //    System.Threading.Thread.Sleep(2000);
        //    login.EperformPasswordTextBox.SendKeys(list2[2].ToString());
        //    login.EperformSubmitButton.Click();
        //    //clean up code.
        //    login.EperformSystemAdministratorArrowDropDownIcon.Click();
        //    home.EperformChangePasswordOption.Click();
        //    home.EperformCurrentPasswordTextBox.SendKeys(list2[2].ToString());
        //    home.EperformNewPasswordTextBox.SendKeys(list[2].ToString());
        //    home.EperformConfirmNewPassword.SendKeys(list[2].ToString());
        //    login.EperformSubmitButton.Click();
        //}

        ///// <summary>
        /////  @Description:Verify the Forgot Password Link 
        ///// @Author:RaghuKiran MR
        ///// </summary>
        //[Test, Order(5)]
        //[TestCase(Description = "Verify the Forgot Password Link")]
      
        //public void verifyforgotpasswordLink()
        //{

        //    ExtentReport.CExtentReport();
        //    ExtentReport.test = ExtentReport.extent.StartTest("Verify the Login Page");
        //    LoginPage login = new LoginPage(_driver);
        //    HomePage home = new HomePage(_driver);
        //    FormTemplatePage formtemplate = new FormTemplatePage(_driver);
        //    ArrayList list = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "User");

        //    login.EperformForgotPasswordLink.Click();
        //    login.EperformSubmitButton.Click();
        //    BaseMethods.verifyWebElement(login.EperfromUserNameBlankErrorMessageText, "The Username field is required. is not displayed in login page", "The Username field is required. is displayed in login page");
        //    BaseMethods.verifyWebElement(login.EperfromCancelBtn, "The Cancel button is not displayed in forgot page", "The Cancel button is displayed in forgot page");
           
        //    login.EPerformUserNameTextBox.SendKeys(list[1].ToString());
        //    login.EperformSubmitButton.Click();
        //    ArrayList list1 = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "Admin");
        //    login.EperfromReturnLoginPage.Click();
        //    login.EPerformUserNameTextBox.SendKeys(list1[1].ToString());
        //    login.EperformPasswordTextBox.SendKeys(list1[2].ToString());
        //    login.EperformSubmitButton.Click();
        //    home.EperformSystemConfigurationIcon.Click();
        //    home.EperformUsersOption.Click();
        //    formtemplate.EperformGlobalQuestionsSearchTextBox.SendKeys(list1[3].ToString());
        //    formtemplate.EperformGlobalQuestionSearchButton.Click();
        //    formtemplate.EperformEditButton.Click();
        //    BaseMethods.verifyWebElement(login.EperfromEmailHistory, "Eperfrom Email History is not displayed", "Eperfrom Email History is  displayed");
        //    login.EperfromEmailHistory.Click();
        //    BaseMethods.verifyWebElement(login.EperfromPasswordResetRequestLink, "Eperfrom Password Reset Request Link is not displayed", "Eperfrom Password Reset Request Link  is  displayed");
        //    login.EperfromPasswordResetRequestLink.Click();
        //    _driver.FindElement(By.XPath("//a[contains(text(),'Reset Password')]")).Click();
        //    login.EperformSubmitButton.Click();
        //    BaseMethods.verifyWebElement(login.EperfromPasswordBlankErrorMessageText, "The Password field is required. is not displayed", "The Password field is required.  is  displayed");
        //    BaseMethods.verifyWebElement(login.EperfromConfirmPasswordBlankErrorMessageText, "he Confirm Password field is required. is not displayed", "The Confirm Password field is required.  is  displayed"); 
        //    ArrayList list2 = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "ChangePassword");
        //    login.EperformPasswordTextBox.SendKeys(list2[1].ToString());
        //    login.EperformConfirmPasswordTextBox.SendKeys(list2[2].ToString());
        //    login.EperformSubmitButton.Click();
        //    BaseMethods.verifyWebElement(login.EperformResetPasswordSuccessfulText, "Eperform Reset Password Successful Text is not displayed", "Eperform Reset Password Successful Text is  displayed");
          
        //}




        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                string screenShotPath = ExtentReport.Capture(_driver);
                ExtentReport.test.Log(LogStatus.Fail, stackTrace + errorMessage);
                ExtentReport.test.Log(LogStatus.Fail, "Please find the Screenshot below: " + ExtentReport.test.AddScreenCapture(screenShotPath));
            }
            ExtentReport.extent.EndTest(ExtentReport.test);
            _driver.Quit();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {

            ExtentReport.extent.Flush();
            ExtentReport.extent.Close();
        }


        /// <summary>
        /// @Description:Login to the Application
        /// @Author:RaghuKiran MR
        /// </summary>
        public void loginApplicationDriver()
    {

        LoginPage login = new LoginPage(_driver);
            HomePage home = new HomePage(_driver);
        ArrayList list = BaseClass.GetData("ER_TESTDATA", "LoginTest", "KeyName", "Super Admin");
        string username = list[1].ToString();
        string pwd = list[2].ToString();
        login.EPerformUserNameTextBox.SendKeys(username);
        login.EperformPasswordTextBox.SendKeys(pwd);
        login.EperformSubmitButton.Click();
       
        
        

    }


    public static IWebDriver LoginPageDriver()
    {
        _01LoginTest LPT = new _01LoginTest();
        LPT.OneTimeIntialize();
        LPT.Initialize();
        LPT.loginApplicationDriver();
        //  ExtentReport.extent.EndTest(ExtentReport.test);
        return _driver;
    }

    }


}

  


