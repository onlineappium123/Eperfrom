using ePerform.Library.Extent_Reports;
using EPerform.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPerform.Library.Excel;
using System.Collections;
using System.Data;
using System.Threading;

namespace EPerform.Tests
{
    class _06CompetencyTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        #region Competency List Tests

        [Test, Order(1)]
        [TestCase(Description = "To Verify Competency List Page Elements")]
        public void VerifyCompetencyListPageElements()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Competency List Page Elements");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyCompetencyListPageElements();

        }

        [Test, Order(2)]
        [TestCase(Description = "To Verify Actions Button and its functionality in Competency List Page")]
        public void VerifyActionsButton()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Actions Button and its functionality in Competency List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyActionsButton_CompetencyListPage();
        }

        [Test, Order(3)]
        [TestCase(Description = "To Verify Pagination in Competency List Page")]
        public void VerifyPagination()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Pagination in Competency List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyPagination_CompetencyListPage();
        }

        [Test, Order(4)]
        [TestCase(Description = "To Verify 'Add Competency' Popup Elements")]
        public void VerifyAddPopupElements()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify 'Add Competency' Popup Elements");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyAddPopupElements_CompetencyListPage();
        }

        [Test, Order(5)]
        [TestCase(Description = "To Verify Mandatory Fields in Add Competency")]
        public void VerifyMandatoryFields_AddCompetency()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Mandatory Fields in Add Competency");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.VerifyMandatoryFields_AddCompetency();
        }

        [Test, Order(6)]
        [TestCase(Description = "To Create Competency")]
        public void CreateEditCompetency()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "Competency", "Enable", "Yes");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["IsEdit"].ToString().ToLower() == "yes")
                {
                    ExtentReport.test = ExtentReport.extent.StartTest("To Create and Edit Competency");
                    compListPage.EditCompetency(dr);
                    ExtentReport.extent.EndTest(ExtentReport.test);
                }
                else
                {
                    ExtentReport.test = ExtentReport.extent.StartTest("To Create Competency");

                    string status = "InActive";
                    if (dr["Active"].ToString().ToLower() == "yes")
                    {
                        status = "Active";
                    }

                    compListPage.CreateCompetency(dr["Name"].ToString(), dr["Description"].ToString(), status, true);
                    ExtentReport.extent.EndTest(ExtentReport.test);
                }
            }
        }

        //[Test, Order(6)]
        //[TestCase(Description = "To Create InActive Competency")]
        //public void CreateCompetency_InActive()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    CompetencyListPage compListPage = new CompetencyListPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Create InActive Competency");

        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetenciesOption.Click();

        //    compListPage.CreateCompetency("InActive", true);
        //}

        //[Test, Order(7)]
        //[TestCase(Description = "To Create and Edit Competency")]
        //public void EditCompetency()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    CompetencyListPage compListPage = new CompetencyListPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Create and Edit Competency");

        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetenciesOption.Click();

        //    DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "Competency", "KeyName", "Competency_Edit");
        //    DataRow dr = dt.Rows[0];
        //    compListPage.EditCompetency(dr);
        //}

        //[Test, Order(9)]
        //[TestCase(Description = "To Edit a Competency and make it Active")]
        //public void EditCompetency_InActiveToActive()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    CompetencyListPage compListPage = new CompetencyListPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Edit a Competency and make it Active");

        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetenciesOption.Click();

        //    compListPage.EditCompetency("InActive", "Active");
        //}

        [Test, Order(8)]
        [TestCase(Description = "To Create Competency of same Name")]
        public void CreateCompetency_SameName()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Competency of same Name");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "Competency", "Enable", "Yes");
            DataRow dr = dt.Rows[0];

            compListPage.CreateCompetency_SameName(dr);
        }

        [Test, Order(9)]
        [TestCase(Description = "To Make all types of Search in Competency List Page")]
        public void SearchCompetency_AllTypes()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyListPage compListPage = new CompetencyListPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Make all types of Search in Competency List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetenciesOption.Click();

            compListPage.SearchCompetency_AllTypes();
        }


        #endregion

        #region Competency Level List Tests


        [Test, Order(11)]
        [TestCase(Description = "To Verify Competency Level List Page Elements")]
        public void VerifyCompetencyLevelListPageElements()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Competency Level List Page Elements");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyCompetencyLevelListPageElements();

        }

        [Test, Order(12)]
        [TestCase(Description = "To Verify Actions Button and its functionality in Competency Level List Page")]
        public void VerifyActionsButton_CompetencyLevelListPage()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Actions Button and its functionality in Competency Level List Page");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyActionsButton_CompetencyLevelListPage();
        }

        [Test, Order(13)]
        [TestCase(Description = "To Verify Pagination in Competency Level List Page")]
        public void VerifyPagination_CompetencyLevelListPage()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Pagination in Competency Level List Page");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyPagination_CompetencyLevelListPage();
        }

        [Test, Order(14)]
        [TestCase(Description = "To Verify 'Add Competency' Popup Elements in Competency Level List Page")]
        public void VerifyAddPopupElements_CompetencyLevelListPage()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify 'Add Competency' Popup Elements in Competency Level List Page");


            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyAddPopupElements_CompetencyLevelListPage();
        }

        [Test, Order(15)]
        [TestCase(Description = "To Verify Mandatory Fields in Add Competency Level")]
        public void VerifyMandatoryFields_AddCompetencyLevel()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Mandatory Fields in Add Competency Level");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.VerifyMandatoryFields_AddCompetencyLevel();
        }

        [Test, Order(16)]
        [TestCase(Description = "To Create Competency Level")]
        public void CreateEditCompetencyLevel()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();
            DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "CompetencyLevel", "Enable", "Yes");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["IsEdit"].ToString().ToLower() == "yes")
                {
                    ExtentReport.test = ExtentReport.extent.StartTest("To Create and Edit a Competency Level");
                    compLevelPage.EditCompetencyLevel(dr);
                    ExtentReport.extent.EndTest(ExtentReport.test);
                }
                else
                {
                    ExtentReport.test = ExtentReport.extent.StartTest("To Create Competency Level");
                    string status = "InActive";
                    if (dr["Active"].ToString().ToLower() == "yes")
                    {
                        status = "Active";
                    }
                    compLevelPage.CreateCompetencyLevel(dr["Name"].ToString(), status, true);
                    ExtentReport.extent.EndTest(ExtentReport.test);
                }
            }
        }

        //[Test, Order(16)]
        //[TestCase(Description = "To Create InActive Competency Level")]
        //public void CreateCompetencyLevel_InActive()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Create InActive Competency Level");

        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetencyLevelsOption.Click();

        //    compLevelPage.CreateCompetencyLevel("InActive", true);
        //}

        //[Test, Order(17)]
        //[TestCase(Description = "To Create and Edit a Competency Level")]
        //public void EditCompetencyLevel()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Create and Edit a Competency Level");

        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetencyLevelsOption.Click();

        //    DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "CompetencyLevel", "KeyName", "CompLevel_Edit");
        //    DataRow dr = dt.Rows[0];

        //    compLevelPage.EditCompetencyLevel(dr);
        //}

        //[Test, Order(19)]
        //[TestCase(Description = "To Edit a Competency Level and make it Active")]
        //public void EditCompetencyLevel_InActiveToActive()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Edit a Competency Level and make it Active");

        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetencyLevelsOption.Click();

        //    compLevelPage.EditCompetencyLevel("InActive", "Active");
        //}

        [Test, Order(18)]
        [TestCase(Description = "To Create Competency Level of same Name")]
        public void CreateCompetencyLevel_SameName()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create Competency Level of same Name");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "CompetencyLevel", "Enable", "Yes");
            DataRow dr = dt.Rows[0];

            compLevelPage.CreateCompetencyLevel_SameName(dr);
        }

        [Test, Order(19)]
        [TestCase(Description = "To Make all types of Search in Competency Level List Page")]
        public void SearchCompetencyLevel_AllTypes()
        {
            HomePage homePage = new HomePage(_driver);
            CompetencyLevelPage compLevelPage = new CompetencyLevelPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Make all types of Search in Competency Level List Page");

            homePage.EperformCompetencyFrameworkIcon.Click();
            homePage.EperformCompetencyLevelsOption.Click();

            compLevelPage.SearchCompetencyLevel_AllTypes();
        }

        #endregion

        #region Competency Behaviour List Tests

        [Test, Order(23)]
        [TestCase(Description = "To Verify Page Elements in Competency Behaviours List Page")]
        public void VerifyBehavioursListPageElements()
        {
            CompetencyBehavioursPage compBehPage = new CompetencyBehavioursPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Verify Page Elements in Competency Behaviours List Page");
            compBehPage.VerifyBehavioursListPageElements();
        }

        [Test, Order(24)]
        [TestCase(Description = "To Create Behaviour in Competency Behaviours List Page")]
        public void CreateEditBehaviour()
        {
            CompetencyBehavioursPage compBehPage = new CompetencyBehavioursPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Create/Edit Behaviour in Competency Behaviours List Page");

            DataTable dtComp = ExcelData.GetData_DataTable("EP_Competency", "CompetencyBehaviour", "Enable", "Yes");
            foreach (DataRow dr in dtComp.Rows)
            {
                compBehPage.CreateBehaviour(dr);
            }
        }

        //[Test, Order(25)]
        //[TestCase(Description = "To Create and Edit Behaviour in Competency Behaviours List Page")]
        //public void EditBehaviour()
        //{
        //    CompetencyBehavioursPage compBehPage = new CompetencyBehavioursPage(_driver);
        //    ExtentReport.test = ExtentReport.extent.StartTest("To Create and Edit Behaviour in Competency Behaviours List Page");
        //    compBehPage.EditBehaviour();
        //}

        #endregion

        ////THIS CODE IS NEEDED - Dont Delete

        //[Test, Order(124)]
        //[TestCase(Description = "To Make All Competency Inactive")]
        //public void MakingInactiveofAllCompetency()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetenciesOption.Click();

        //    int i = 1;
        //    while (i <= 6)
        //    {
        //        try
        //        {
        //            _driver.FindElement(By.XPath("(//td[contains(text(),'Yes')])[1]/..//a[contains(text(),'Edit')]")).Click();
        //            _driver.FindElement(By.Id("Dto_IsActive_f")).Click();
        //            _driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
        //            Thread.Sleep(2000);
        //            _driver.FindElement(By.XPath("//li/button[contains(text(),'" + i + "')]")).Click();
        //        }
        //        catch (Exception)
        //        {
        //            i++;
        //            _driver.FindElement(By.XPath("//li/button[contains(text(),'" + i + "')]")).Click();
        //        }
        //    }
        //}
        //[Test, Order(125)]
        //[TestCase(Description = "To Make All Competency Level Inactive")]
        //public void MakingInactiveofAllCompetencyLevel()
        //{
        //    HomePage homePage = new HomePage(_driver);
        //    homePage.EperformCompetencyFrameworkIcon.Click();
        //    homePage.EperformCompetencyLevelsOption.Click();

        //    int i = 1;
        //    while (i <= 5)
        //    {
        //        try
        //        {
        //            _driver.FindElement(By.XPath("(//td[contains(text(),'Yes')])[1]/..//a[contains(text(),'Edit')]")).Click();
        //            _driver.FindElement(By.Id("Dto_IsActive_f")).Click();
        //            _driver.FindElement(By.XPath("//button[contains(text(),'Submit')]")).Click();
        //            Thread.Sleep(2000);
        //            _driver.FindElement(By.XPath("//li/button[contains(text(),'" + i + "')]")).Click();
        //        }
        //        catch (Exception)
        //        {
        //            i++;
        //            _driver.FindElement(By.XPath("//li/button[contains(text(),'" + i + "')]")).Click();
        //        }
        //    }
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
