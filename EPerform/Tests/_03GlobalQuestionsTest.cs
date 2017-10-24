using ePerform.Library;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ePerform.Pages;
using System.Threading;
using EPerform.Tests;
using EPerform.Pages;
using ePerform.Library.Extent_Reports;
using System.Collections;

using RelevantCodes.ExtentReports;
using EPerform.Library.Excel;
using System.Data;
using NUnit.Framework.Interfaces;
using EPerform.Library;
using System.Configuration;

namespace ePerform.Tests
{
    class _03GlobalQuestionsTest
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            _driver = _01LoginTest.LoginPageDriver();
        }

        [Test, Order(1)]
        [TestCase(Description = "To Create Global Questions")]
        public void CreateGlobalQuestions()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ManageGlobalQuestionPage manageGQPage = new ManageGlobalQuestionPage(_driver);

            DataTable dt = ExcelData.GetData_DataTable("EP_GQ", "GlobalQuestionsCreate", "Enable", "Yes");
            string reference = string.Empty;

            foreach (DataRow dr in dt.Rows)
            {
                //if (dr["Enable"].ToString().ToLower() == "yes")
                //{
                homePage.EperformSystemConfigurationArrowIcon.Click();
                homePage.EperformGlobalQuestionsOption.Click();

                ExtentReport.test = ExtentReport.extent.StartTest("To Create Global Question of '" + dr["GQType"].ToString() + "' Type");

                Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
                ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");

                switch (dr["GQType"].ToString())
                {
                    case "Single Line Text Box":
                        reference = selectQuestionTypePage.CreateGQ_SingleLineTextBox(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_SingleLineTextBox(reference, dr);
                        }

                        break;
                    case "Multi Line Text Area":
                        reference = selectQuestionTypePage.CreateGQ_MultiLineTextArea(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_MultiLineTextArea(reference, dr);
                        }

                        break;
                    case "Select Single Item from a List":
                        reference = selectQuestionTypePage.CreateGQ_SelectSingleItem(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_SelectSingleItem(reference, dr);
                        }

                        break;
                    case "Select Multiple Items from a List":
                        reference = selectQuestionTypePage.CreateGQ_SelectMultipleitems(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_SelectMultipleitems(reference, dr);
                        }

                        break;
                    case "Numeric":
                        reference = selectQuestionTypePage.CreateGQ_Numeric(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_Numeric(reference, dr);
                        }

                        break;
                    case "Yes or No":
                        reference = selectQuestionTypePage.CreateGQ_YesorNo(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_YesorNo(reference, dr);
                        }

                        break;
                    case "Date":
                        reference = selectQuestionTypePage.CreateGQ_Date(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_Date(reference, dr);
                        }

                        break;
                    case "File Upload":
                        reference = selectQuestionTypePage.CreateGQ_FileUpload(dr);

                        if (dr["IsEdit"].ToString().ToLower().Trim() == "yes")
                        {
                            manageGQPage.EditGQ_FileUpload(reference, dr);
                        }

                        break;
                    default:
                        break;
                }
                //}
                ExtentReport.extent.EndTest(ExtentReport.test);
            }
        }

        //[Test, Order(2)]
        //[TestCase(Description = "To Edit Global Questions")]
        public void EditGlobalQuestions()
        {
            HomePage homePage = new HomePage(_driver);
            ManageGlobalQuestionPage manageGQPage = new ManageGlobalQuestionPage(_driver);

            DataTable dt = ExcelData.GetData_DataTable("EP_GQ", "GlobalQuestionsEdit");

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Enable"].ToString().ToLower() == "yes")
                {
                    homePage.EperformSystemConfigurationArrowIcon.Click();
                    homePage.EperformGlobalQuestionsOption.Click();

                    ExtentReport.test = ExtentReport.extent.StartTest("To Edit Global Question of '" + dr["GQType"].ToString() + "' Type");

                    switch (dr["GQType"].ToString())
                    {
                        case "Single Line Text Box":
                            //manageGQPage.EditGQ_SingleLineTextBox(dr);
                            break;
                        case "Multi Line Text Area":
                            //manageGQPage.EditGQ_MultiLineTextArea(dr);
                            break;
                        case "Select Single Item from a List":
                            //manageGQPage.EditGQ_SelectSingleItem(dr);
                            break;
                        case "Select Multiple Items from a List":
                            //manageGQPage.EditGQ_SelectMultipleitems(dr);
                            break;
                        case "Numeric":
                            //manageGQPage.EditGQ_Numeric(dr);
                            break;
                        case "Yes or No":
                            //manageGQPage.EditGQ_YesorNo(dr);
                            break;
                        case "Date":
                            //manageGQPage.EditGQ_Date(dr);
                            break;
                        case "File Upload":
                            //manageGQPage.EditGQ_FileUpload(dr);
                            break;
                        default:
                            break;
                    }
                }
                ExtentReport.extent.EndTest(ExtentReport.test);
            }
        }

        [Test, Order(3)]
        [TestCase(Description = "To Search Global Questions")]
        public void SearchGlobalQuestions()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Search Global Questions");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Info, "Keyword Text is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("EP_GQ", "GlobalQuestionsSearch");
            foreach (DataRow dr in dt.Rows)
            {
                globalQuestionsListPage.SearchGlobalQuestions(dr);
            }
        }

        //[Test, Order(4)]
        //[TestCase(Description = "To Delete Global Questions")]
        public void DeleteGlobalQuestions()
        {
            HomePage homePage = new HomePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("To Delete Global Questions");

            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(_driver);

            Assert.IsTrue(gqListPage.PageTitle.Displayed, gqListPage.PageTitle.Text + " Page title is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, gqListPage.PageTitle.Text + " Page title is displayed in the Global Question List Page");

            DataTable dtDelete = ExcelData.GetData_DataTable("EP_GQ", "GlobalQuestionsDelete");

            foreach (DataRow dr in dtDelete.Rows)
            {
                if (dr["KeyWord"].ToString().Trim() != "")
                {
                    gqListPage.SearchGQ(dr["KeyWord"].ToString());
                    try
                    {
                        gqListPage.SearchedDeleteButton.Click();
                        gqListPage.DeletePopupConfirmButton.Click();

                        BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + dr["KeyWord"].ToString() + " - Keyword containing record has been deleted successfully",
                                                                                  dr["KeyWord"].ToString() + " - Keyword containing record is not deleted successfully");
                    }
                    catch (NoSuchElementException e)
                    {
                        if (e.Message != "Could not find element by: By.XPath: (//a[contains(text(),'Delete')])[1]")
                        {
                            bool chk = gqListPage.DeletePopupConfirmButton.Displayed;
                        }
                        bool check = gqListPage.NoRecordsFoundMessage.Displayed;
                        ExtentReport.test.Log(LogStatus.Fatal, "No Records Found Message is displayed, " + dr["KeyWord"].ToString() + " - Keyword is not found in the Global Question List");
                    }
                }
            }
        }

        [Test, Order(5)]
        [TestCase(Description = "To Customise Global Questions List")]
        public void CustomiseGlobalQuestionsList()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Customise Global Questions List");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

            DataTable dt = ExcelData.GetData_DataTable("EP_GQ", "GlobalQuestionsListCustomise", "KeyName", "Default");

            globalQuestionsListPage.CustomiseGlobalQuestionsList(dt.Rows[0]);
        }

        [Test, Order(6)]
        [TestCase(Description = "To Sort All Columns in Global Questions List")]
        public void Sorting()
        {
            HomePage homePage = new HomePage(_driver);
            GlobalQuestionsListPage globalQuestionsListPage = new GlobalQuestionsListPage(_driver);

            ExtentReport.test = ExtentReport.extent.StartTest("To Sort All Columns in Global Questions List");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

            Assert.IsTrue(globalQuestionsListPage.KeywordText.Displayed, "Keyword Text is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Text is displayed in the Global Question List Page");

            globalQuestionsListPage.Sorting();
        }

        [Test, Order(7)]
        [TestCase(Description = "To Verify Question Component Type Form page")]
        public void VerifyQuestionTypeForm()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Verify Question Type Form Page");
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");
            Thread.Sleep(2000);
            selectQuestionTypePage.BtnAddGlobalQuestion.Click();

            Assert.IsTrue(selectQuestionTypePage.PageTitle.Displayed, "Select Question Type Page Title is not displayed in Question Component Type page");
            ExtentReport.test.Log(LogStatus.Pass, "'" + selectQuestionTypePage.PageTitle.Text + "' Page Title is displayed in Question Component Type page");

            Assert.IsTrue(selectQuestionTypePage.SelectQuestionTypeFormTitle.Displayed, "Select Question Component Type form Title is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "'" + selectQuestionTypePage.SelectQuestionTypeFormTitle.Text + "' Question Type form name is displayed in Question Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoSingleLineTextBox.Displayed, "Single Line Text Box Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Single Line Text Box Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoMultiLineTextArea.Displayed, "Multi Line Text Area Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Multi Line Text Area Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoSelectSingleItem.Displayed, "Select Single Item from a List Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Select Single Item from a List Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoSelectMultipleItems.Displayed, "Select Multiple Items from a List Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Select Multiple Items from a List Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoNumeric.Displayed, "Numeric Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Numeric Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoYesorNo.Displayed, "Yes or No Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Yes or No Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoDate.Displayed, "Date Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Date Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.RdoFileUpload.Displayed, "File Upload Radiobutton is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "File Upload Radiobutton is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.BtnSubmit.Displayed, "Submit button is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Submit button is displayed in Question Component Type form");

            Assert.IsTrue(selectQuestionTypePage.BtnCancel.Displayed, "Cancel button is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Cancel button is displayed in Question Component Type form");
        }

        [Test, Order(8)]
        public void VerifyManageGQForm_SingleLineTextBox()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Verify Question Type Form Page");

            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");
            Thread.Sleep(2000);
            selectQuestionTypePage.BtnAddGlobalQuestion.Click();

            selectQuestionTypePage.RdoSingleLineTextBox.Click();
            selectQuestionTypePage.BtnSubmit.Click();

            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(_driver);
            Thread.Sleep(2000);
            Assert.IsTrue(mGQPage.PageTitle.Displayed, "Manage Global Question Page Title is not displayed in Manage Global Question page");
            ExtentReport.test.Log(LogStatus.Pass, "Manage Global Question Page Title is displayed in Manage Global Question page");

            Assert.IsTrue(mGQPage.ManageGQFormTitle_SingleLineTextBox.Displayed, "Manage Global Question - Single Line Text Box form Title is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Manage Global Question - Single Line Text Box form Title is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblMandatoryField.Displayed, "Mandatory Message text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Mandatory Message text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblComponentType.Displayed, "Component Type text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Component Type text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblSingleLineTextBox.Displayed, "Single Line Text Box text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Single Line Text Box text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblReference.Displayed, "Reference text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Reference text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblActive.Displayed, "Active text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Active text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblLabel.Displayed, "'Label' text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "'Label' text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblRequired.Displayed, "Required text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Required text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblMaximumLength.Displayed, "Maximum Length text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Maximum Length text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.LblMaximumLengthType.Displayed, "Maximum Length Type text is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Maximum Length Type text is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.BtnSubmit.Displayed, "Submit button is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Submit button is displayed in Manage Global Question form");

            Assert.IsTrue(mGQPage.BtnCancel.Displayed, "Cancel button is not displayed in Manage Global Question form");
            ExtentReport.test.Log(LogStatus.Pass, "Cancel button is displayed in Manage Global Question form");

        }

        [Test, Order(9)]
        public void VerifyValidation_SelectQuestionTypePage()
        {
            HomePage homePage = new HomePage(_driver);
            SelectQuestionTypePage selectQuestionTypePage = new SelectQuestionTypePage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("Verify Question Type Form Page");

            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();
            Assert.IsTrue(selectQuestionTypePage.BtnAddGlobalQuestion.Displayed, "Add Global Questions Button is not displayed in the Global Question List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Global Questions Button is displayed in the Global Question List Page");
            Thread.Sleep(2000);
            selectQuestionTypePage.BtnAddGlobalQuestion.Click();

            selectQuestionTypePage.BtnSubmit.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(selectQuestionTypePage.ErrorMessage.Displayed, "Error Message is not displayed in Question Component Type form");
            ExtentReport.test.Log(LogStatus.Pass, "Error Message is displayed in Question Component Type form, Validation successful");
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
