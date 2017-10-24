using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;

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
    
    public class _02HomeTest
    {

        static IWebDriver _driver;



        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }
        /// <summary>
        /// @Description:To verify the Reviews page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(1)]
        [TestCase(Description = "to verify the Reviews page is displayed or not")]
       
        public void verifyHomeReviewsPage()
        {

            HomePage homepage = new HomePage(_driver);
            homepage.reviewOption();


        }
        /// <summary>
        /// @Description:To verify the Organisation Structure page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(2)]
        [TestCase(Description = "to verify the Organisation Structure page is displayed or not")]
       
        public void verifyHomeOrganisationStructurepage()
        {
            HomePage homepage = new HomePage(_driver);
            homepage.OrganisationStructure();

        }
        /// <summary>
        /// @Description:To verify the Competency Framework page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(3)]
        [TestCase(Description = "to verify the Competency Framework page is displayed or not")]
      
        public void verifyHomeCompetencyFrameworkPage()
        {
            HomePage homepage = new HomePage(_driver);
            homepage.CompetencyFramework();
        }
        /// <summary>
        /// @Description:To verify the Reference Material page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(4)]
        [TestCase(Description = "to verify the Reference Material page is displayed or not")]
      
        public void verifyHomeReferenceMaterialPage()
        {
            HomePage homepage = new HomePage(_driver);
            homepage.ReferenceMaterial();
        }

        /// <summary>
        /// @Description:To verify the System Configuration page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(5)]
        [TestCase(Description = "to verify the System Configuration page is displayed or not")]
      
        public void verifyHomeSystemConfigurationPage()
        {
            HomePage homepage = new HomePage(_driver);
            homepage.SystemConfiguration();
            
        }
        /// <summary>
        /// @Description:To verify the System Administrator page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>
        [Test, Order(6)]
        [TestCase(Description = "to verify the System Administrator page is displayed or not")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Priority(6)]
        public void verifySystemAdministratorpage()
        {
            HomePage homepage = new HomePage(_driver);
            homepage.EperformSystemAdministrator();

        }
        /// <summary>
        /// @Description:To verify the Help page is displayed or not
        /// @Author:RaghuKiran MR
        /// </summary>

        [Test, Order(7)]
        [TestCase(Description = "to verify the Help page is displayed or not")]
       
        public void verifyHelppage()
        {
            HomePage homepage = new HomePage(_driver);
            homepage.help();

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
