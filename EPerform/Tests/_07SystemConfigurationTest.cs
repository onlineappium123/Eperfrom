using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using EPerform.Pages;
using ePerform.Library.Extent_Reports;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;

namespace EPerform.Tests
{
    class _07SystemConfigurationTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        [Test, Order(1)]
        [TestCase(Description = "Create the PermissionProfile")]

        public void createPermissionProfile()
        {
            
            ExtentReport.test = ExtentReport.extent.StartTest("Create the PermissionProfile");
            PermissionProfilesPage permissionProfile = new PermissionProfilesPage(_driver);
            permissionProfile.createpermissionProfileList();
        }

        [Test, Order(2)]
        [TestCase(Description = "Create the UserList")]

        public void UserList()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("Create the UserList");
            UserListPage user = new UserListPage(_driver);
            user.createuser();

        }
        [Test, Order(3)]
        [TestCase(Description = "createEmailTemplate")]

        public void createEmailTemplate()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("createEmailTemplate");
            EmailTemplatesPage email = new EmailTemplatesPage(_driver);
            email.createEmailTemplate("EmailTemplates");
            

        }

        [Test, Order(4)]
        [TestCase(Description = "EditEmailNotification")]

        public void EditEmailNotification()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("EditEmailNotification");
            EmailNotificationsPage emailnotification = new EmailNotificationsPage(_driver);
            emailnotification.EditEmailNotificationsManager();


        }


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

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _driver.Quit();
            ExtentReport.extent.Flush();
            ExtentReport.extent.Close();
           
        }



    }
}
