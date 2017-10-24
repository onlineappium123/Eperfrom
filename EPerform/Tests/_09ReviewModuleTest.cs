using ePerform.Library.Extent_Reports;
using EPerform.Library.Excel;
using EPerform.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Tests
{
    class _09ReviewModuleTest
    {

        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }


        [Test, Order(3)]
        [TestCase(Description = "CreateReviewTemplate")]
        public void CreateReviewTemplate()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("CreateReviewTemplate");
            ReviewTemplatesPage review = new ReviewTemplatesPage(_driver);
            //ReviewTemplatesPageAppraisalPhasePage reviewAppraisalPhase = new ReviewTemplatesPageAppraisalPhasePage(_driver);
            review.createReviewTemplate();
            //reviewAppraisalPhase.createAppraisal();
        }

        [Test, Order(2)]
        [TestCase(Description = "CreateWorkFlow")]
        public void CreateWorkFlow()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("CreateWorkFlow");
            ReviewWorkflowsPage reviewWorkFlow = new ReviewWorkflowsPage(_driver);
            reviewWorkFlow.CreateWorkFlow();
        }



        #region Roles


        [Test, Order(1)]
        [TestCase(Description = "To Create Role in Roles List Page")]
        public void CreateRole()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Role in Roles List Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformReviewsArrowOption.Click();
            homePage.EperformWorkflowRolesIcon.Click();

            DataTable dt = ExcelData.GetData_DataTable("EP_Reviews", "Roles", "Enable", "Yes");

            RolesPage roles = new RolesPage(_driver);

            foreach (DataRow dr in dt.Rows)
            {
                roles.CreateRole(dr);
            }
        }


        #endregion


        [TearDown]
        public void GetResult()
        { 
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
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
            string _EmailKey = ConfigurationManager.AppSettings["EmailTrigger"];
            if (_EmailKey == "ReviewModuleTest")
            {
                ExtentReport.SendEmail();
            }

        }


    }
}
