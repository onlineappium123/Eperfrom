using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using EPerform.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using System.Data;
using EPerform.Library.Excel;

namespace EPerform.Pages
{
    class CompetencyLevelPage
    {
        public IWebDriver driver;

        public CompetencyLevelPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Competency Level List')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Competency Level')]")]
        public IWebElement AddCompetencyLevelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Keyword')]")]
        public IWebElement KeywordLabel { get; set; }

        [FindsBy(How = How.Id, Using = "Keywords")]
        public IWebElement KeywordsTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Search')]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa fa-cog']/..")]
        public IWebElement CustomiseButton { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-1")]
        public IWebElement CustomiseGrid_ActiveCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "changeItemsPerPage")]
        public IWebElement CustomiseGrid_PerPageDropDownList { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-reset")]
        public IWebElement CustomiseGrid_ResetDisplayButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Name')]")]
        public IWebElement NameColumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Active')]")]
        public IWebElement ActiveColumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Actions')]")]
        public IWebElement ActionsColumn { get; set; }

        [FindsBy(How = How.Id, Using = "base-modal-dialog")]
        public IWebElement CompetencyLevelEdit_Popup { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement CloseButton_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[1]")]
        public IWebElement CompetencyLevelName { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[2]")]
        public IWebElement CompetencyLevelActiveStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[3]/a[contains(text(),'Edit')]")]
        public IWebElement CompetencyLevelActionEditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[3]/button[contains(text(),'Down')]")]
        public IWebElement CompetencyLevelActionDownButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[2]/td[3]/button[contains(text(),'Up')]")]
        public IWebElement CompetencyLevelActionUpButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr")]
        public IList<IWebElement> CompetencyLevelList { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='pagination']")]
        public IWebElement PaginationSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Competency Level')]")]
        public IWebElement PopupManageCompetencyLevel_Title { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement PopupName_Textbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_Name']/following-sibling::span[@class='field-validation-error']")]
        public IWebElement PopupName_TextboxValidationMessage { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement PopupActiveYes_RadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement PopupActiveNo_RadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Name']")]
        public IWebElement PopupName_Label { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Name']/span[text()='*']")]
        public IWebElement PopupName_LabelMandatory { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_IsActive']")]
        public IWebElement PopupActive_Label { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement PopupCancel_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement PopupSubmit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.Id, Using = "NoListRecords")]
        public IWebElement NoListRecordsFound { get; set; }

        string formSubmitType = "Created";

        public void VerifyCompetencyLevelListPageElements()
        {
            Assert.IsTrue(PageTitle.Displayed, "Competency Level List Page title is not displayed in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Competency Level List Page title is displayed in the Competencies Level List Page");

            Assert.IsTrue(AddCompetencyLevelButton.Displayed, "Add Competency Level Button is not displayed in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Competency Level Button is displayed in the Competencies Level List Page");

            Assert.IsTrue(KeywordLabel.Displayed, "Keyword Label is not displayed in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Label is displayed in the Competencies Level List Page");

            Assert.IsTrue(KeywordsTextBox.Displayed, "Keyword TextBox is not displayed in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword TextBox is displayed in the Competencies Level List Page");

            Assert.IsTrue(SearchButton.Displayed, "Keyword Search Button is not displayed in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Search Button is displayed in the Competencies Level List Page");

            CustomiseButton.Click();
            if (!CustomiseGrid_ActiveCheckBox.Selected)
            {
                CustomiseGrid_ActiveCheckBox.Click();
            }

            Assert.IsTrue(NameColumn.Displayed, "Name Column is not displayed in the Competencies Levels Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Name Column is displayed in the Competencies Levels Grid");

            Assert.IsTrue(ActiveColumn.Displayed, "Active Column is not displayed in the Competencies Levels Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Active Column is displayed in the Competencies Levels Grid");

            Assert.IsTrue(ActionsColumn.Displayed, "Actions Column is not displayed in the Competencies Levels Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Actions Column is displayed in the Competencies Levels Grid");
        }

        public void VerifyActionsButton_CompetencyLevelListPage()
        {
            if (CompetencyLevelList.Count > 0)
            {
                bool searchResult = true;
                for (int i = 1; i <= CompetencyLevelList.Count; i++)
                {
                    IWebElement editButton = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[3]/a[contains(text(),'Edit')]"));
                    if (!editButton.Displayed)
                    {
                        searchResult = false;
                        break;
                    }
                }
                Assert.IsTrue(searchResult, "Edit buttons has not been displayed appropriately in the Competencies Levels Grid");
                ExtentReport.test.Log(LogStatus.Pass, "Edit buttons has been displayed appropriately in the Competencies Levels Grid");

                string cName = CompetencyLevelName.Text;

                Thread.Sleep(2000);
                CompetencyLevelActionDownButton.Click();
                Thread.Sleep(4000);
                ExtentReport.test.Log(LogStatus.Info, "<b>" + cName + "</b> - Down button clicked and moved the Competency Level down by one row in the Competencies Levels Grid");

                CompetencyLevelActionUpButton.Click();
                Thread.Sleep(4000);
                ExtentReport.test.Log(LogStatus.Info, "<b>" + cName + "</b> - Up button clicked and moved the Competency Level up by one row in the Competencies Levels Grid");

                CompetencyLevelActionEditButton.Click();
                Thread.Sleep(6000);
                Assert.IsTrue(CompetencyLevelEdit_Popup.Displayed, "Edit button click is not opening the Competency Level Edit popup properly in the Competencies Levels Grid");
                ExtentReport.test.Log(LogStatus.Pass, "Edit button click is opening the Competency Level Edit popup properly in the Competencies Levels Grid");

                CloseButton_Popup.Click();
                Thread.Sleep(3000);
            }
        }

        public void VerifyPagination_CompetencyLevelListPage()
        {
            CustomiseButton.Click();
            Thread.Sleep(3000);
            BaseMethods.DdlSelectByText(CustomiseGrid_PerPageDropDownList, "10");
            //CustomiseGrid_ResetDisplayButton.Click();
            Thread.Sleep(4000);
            if (CompetencyLevelList.Count == 10)
            {
                Assert.IsTrue(PaginationSection.Displayed, "Pagination is not present at the bottom of the page in the Competencies Level List Page");
                ExtentReport.test.Log(LogStatus.Pass, "Pagination is present at the bottom of the page in the Competencies Level List Page");
            }
            else if (CompetencyLevelList.Count < 10)
            {
                ExtentReport.test.Log(LogStatus.Info, "Pagination is not displayed as Competency Level count is less then 10 in the Competencies Level List Page");
            }
        }

        public void VerifyAddPopupElements_CompetencyLevelListPage()
        {
            Thread.Sleep(2000);
            AddCompetencyLevelButton.Click();
            Thread.Sleep(6000);

            Assert.IsTrue(PopupManageCompetencyLevel_Title.Displayed, "The title of the Add Competency Level popup – Manage Competency Level is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "The title of the Add popup – Manage Competency Level is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupName_Label.Displayed, "Name field label of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Name field label of the Add Competency Level popup is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupName_Textbox.Displayed, "Name field textbox of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Name field textbox of the Add Competency Level popup is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupActive_Label.Displayed, "Active field label of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field label of the Add Competency Level popup is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupActiveYes_RadioButton.Displayed, "Active field Yes Radio button of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field Yes Radio button of the Add Competency Level popup is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupActiveNo_RadioButton.Displayed, "Active field No Radio button of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field No Radio button of the Add Competency Level popup is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupActiveYes_RadioButton.Selected, "Active field is not defaulted to Yes Radio button of the Add Competency Level popup in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field is defaulted to Yes Radio button of the Add Competency Level popup in the Competencies Level List Page");

            Assert.IsTrue(PopupSubmit_Button.Displayed, "Submit button of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Submit button of the Add Competency Level popup is displaying in the Competencies Level List Page");

            Assert.IsTrue(PopupCancel_Button.Displayed, "Cancel button of the Add Competency Level popup is not displaying in the Competencies Level List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Cancel button of the Add Competency Level popup is displaying in the Competencies Level List Page");

            CloseButton_Popup.Click();
            Thread.Sleep(2000);
        }

        public void VerifyMandatoryFields_AddCompetencyLevel()
        {
            Thread.Sleep(2000);
            AddCompetencyLevelButton.Click();
            Thread.Sleep(6000);

            PopupSubmit_Button.Click();
            Thread.Sleep(2000);

            Assert.IsTrue(ErrorMessage.Displayed, "Error message for validating the Competency Level is not displayed in Add Competency Level popup");
            ExtentReport.test.Log(LogStatus.Pass, "Error message for validating the Competency Level is displayed in Add Competency Level popup");

            try
            {
                Assert.IsTrue(PopupName_LabelMandatory.Displayed);
                ExtentReport.test.Log(LogStatus.Info, "Validation for Name field is enabled in Add Competency Level popup");
                Assert.IsTrue(PopupName_TextboxValidationMessage.Displayed, "Validation message of Name field for validating the Competency Level is not displayed in Add Competency Level popup");
                ExtentReport.test.Log(LogStatus.Pass, "Validation message of Name field for validating the Competency Level is displayed in Add Competency Level popup");
            }
            catch
            {
                ExtentReport.test.Log(LogStatus.Info, "Validation for Name field is not enabled in Add Competency Level popup");
            }

            CloseButton_Popup.Click();
            Thread.Sleep(2000);
        }

        public string CreateCompetencyLevel(string name, string type, bool isCreate)
        {
            Thread.Sleep(2000);
            if (isCreate)
            {
                AddCompetencyLevelButton.Click();
                Thread.Sleep(6000);
            }

            name = name + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            PopupName_Textbox.Clear();
            PopupName_Textbox.SendKeys(name);

            if (type == "Active")
            {
                PopupActiveYes_RadioButton.Click();
            }
            else//type will be InActive
            {
                PopupActiveNo_RadioButton.Click();
            }

            PopupSubmit_Button.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(SuccessMessage.Displayed, name + " - " + type + " Competency Level is not " + formSubmitType + " successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + name + " - " + type + " Competency Level " + formSubmitType + " successfully");

            return name;
        }

        public void EditCompetencyLevel(DataRow dr)
        {
            string status = "InActive";
            if (dr["Active"].ToString().ToLower() == "yes")
            {
                status = "Active";
            }

            string compName = CreateCompetencyLevel(dr["Name"].ToString(), status, true);
            SearchCompetencyLevel(compName);
            CompetencyLevelActionEditButton.Click();
            Thread.Sleep(5000);
            formSubmitType = "Edited and Updated";

            string editstatus = "InActive";
            if (dr["EditActive"].ToString().ToLower() == "yes")
            {
                editstatus = "Active";
            }

            compName = CreateCompetencyLevel(dr["EditName"].ToString(), editstatus, false);
            Thread.Sleep(3000);
            SearchCompetencyLevel(compName);
        }

        public void CreateCompetencyLevel_SameName(DataRow dr)
        {
            int i = 0;
            string name = dr["Name"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            while (i < 2)
            {
                Thread.Sleep(2000);
                AddCompetencyLevelButton.Click();
                Thread.Sleep(6000);

                PopupName_Textbox.Clear();
                PopupName_Textbox.SendKeys(name);

                if (dr["Active"].ToString().ToLower() == "yes")
                {
                    PopupActiveYes_RadioButton.Click();
                }
                else
                {
                    PopupActiveNo_RadioButton.Click();
                }

                PopupSubmit_Button.Click();
                i++;
                Thread.Sleep(3000);
                Assert.IsTrue(SuccessMessage.Displayed, name + " - Active Competency Level is not created successfully");
                ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + name + " - Active Competency Level created successfully");
            }
            SearchCompetencyLevel(name);

            Assert.AreEqual(2, CompetencyLevelList.Count, "Creating of same name '" + name + "' - Competency Level was unsuccessful");
            ExtentReport.test.Log(LogStatus.Pass, name + " - Competency Level of same name has been created successfully and listed properly in the Competencies Level Grid");
        }

        public void SearchCompetencyLevel_AllTypes()
        {
            DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "CompetencyLevel", "Enable", "Yes");
            DataRow dr = dt.Rows[0];

            string compName = dr["Name"].ToString();
            SearchCompetencyLevel(compName);

            KeywordsTextBox.Clear();
            KeywordsTextBox.SendKeys(DateTime.Now.ToString());
            SearchButton.Click();
            Thread.Sleep(3000);

            Assert.IsTrue(NoListRecordsFound.Displayed, "Search for a Non-Existent Competency Level was unsuccessful");
            ExtentReport.test.Log(LogStatus.Pass, "Search for a Non-Existent Competency Level was successful");

            KeywordsTextBox.Clear();
            KeywordsTextBox.SendKeys("");
            SearchButton.Click();
            Thread.Sleep(3000);

            ExtentReport.test.Log(LogStatus.Pass, "Blank Search in the Competency Level List was successful");

        }

        public void SearchCompetencyLevel(string keyword)
        {
            KeywordsTextBox.SendKeys(keyword);
            SearchButton.Click();
            Thread.Sleep(3000);


            Assert.IsTrue(CompetencyLevelName.Text.Contains(keyword), keyword + " - Competency Level search was unsuccessfully and is not found in the Competency Level List");
            ExtentReport.test.Log(LogStatus.Pass, keyword + " - Competency Level has been successfully searched and is present in the Competency Level List");
        }

    }
}
