using ePerform.Library.Extent_Reports;
using EPerform.Library.Excel;
using EPerform.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Tests
{
    class _08OrganisationalStructuresTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        #region Organisational Structure

        [Test, Order(1)]
        [TestCase(Description = "To Verify Page Elements in Manage Organisational Structure Page")]
        public void ManageOrgStructurePageVerification()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Page Elements in Manage Organisational Structure Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformOrganisationStructureOption.Click();
            ManageOrgStructurePage manageOrgStrPage = new ManageOrgStructurePage(_driver);
            manageOrgStrPage.ManageOrgStructurePageVerification();
        }

        [Test, Order(2)]
        [TestCase(Description = "To Verify Mandatory Fields in Add Organisational Unit of Manage Organisational Structure Page")]
        public void VerifyMandatoryFields_AddOrgUnit()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Mandatory Fields in Add Organisational Unit of Manage Organisational Structure Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformOrganisationStructureOption.Click();
            ManageOrgStructurePage manageOrgStrPage = new ManageOrgStructurePage(_driver);
            manageOrgStrPage.VerifyMandatoryFields_AddOrgUnit();
        }

        [Test, Order(3)]
        [TestCase(Description = "To Create Organisational Unit")]
        public void CreateOrgUnit()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Organisational Unit");
            HomePage homePage = new HomePage(_driver);
            DataTable dt = ExcelData.GetData_DataTable("EP_OrgStructures", "OrganisationalUnit", "Enable", "Yes");

            foreach (DataRow dr in dt.Rows)
            {
                homePage.EperformOrganisationStructureArrowOption.Click();
                homePage.EperformOrganisationStructureOption.Click();

                ManageOrgStructurePage manageOrgStrPage = new ManageOrgStructurePage(_driver);
                manageOrgStrPage.OrganisationalUnitList_Tab.Click();
                manageOrgStrPage.AddOrgUnit_Button.Click();
                Thread.Sleep(2000);
                manageOrgStrPage.CreateOrgUnit(dr);
            }
        }

        #endregion

        #region Marker

        [Test, Order(10)]
        [TestCase(Description = "To Create and Update Marker in Marker List Page")]
        public void CreateUpdateMarker()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformMarkersOption.Click();

            MarkerListPage markerListPage = new MarkerListPage(_driver);

            DataTable dt = ExcelData.GetData_DataTable("EP_OrgStructures", "Marker", "Enable", "Yes");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["IsEdit"].ToString().ToLower() == "yes")
                {
                    ExtentReport.test = ExtentReport.extent.StartTest("To Create and Update Marker in Marker List Page");
                }
                else
                {
                    ExtentReport.test = ExtentReport.extent.StartTest("To Create Marker in Marker List Page");
                }

                markerListPage.CreateUpdateMarker(dr);

                ExtentReport.extent.EndTest(ExtentReport.test);
            }
        }

        [Test, Order(11)]
        [TestCase(Description = "To Verify Page in Marker List Page")]
        public void MarkerListPageVerification()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Page in Marker List Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformMarkersOption.Click();
            MarkerListPage markerListPage = new MarkerListPage(_driver);
            markerListPage.MarkerListPageVerification();
        }

        #endregion

        #region Positions

        [Test, Order(20)]
        [TestCase(Description = "To Create Position in Position List Page")]
        public void CreatePosition()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Position in Position List Page");
            HomePage homePage = new HomePage(_driver);
            homePage.EperformOrganisationStructureArrowOption.Click();
            homePage.EperformPositionsOption.Click();

            DataTable dt = ExcelData.GetData_DataTable("EP_OrgStructures", "Positions", "Enable", "Yes");

            PositionsPage positionsPage = new PositionsPage(_driver);



            foreach (DataRow dr in dt.Rows)
            {
                positionsPage.AddPosition_Button.Click();
                positionsPage.CreatePositions(dr);
            }

        }

        #endregion

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
