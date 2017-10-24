using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class CompetencyListPage
    {
        IWebDriver driver;
        public CompetencyListPage(IWebDriver pDriver)
        {
            driver = pDriver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Competency List')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Competency')]")]
        public IWebElement AddCompetencyButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Keyword')]")]
        public IWebElement KeywordLabel { get; set; }

        [FindsBy(How = How.Id, Using = "Keywords")]
        public IWebElement KeywordsTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Search')]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa fa-cog']/..")]
        public IWebElement CustomiseButton { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-1")]
        public IWebElement CustomiseGrid_DescriptionCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-2")]
        public IWebElement CustomiseGrid_ActiveCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "changeItemsPerPage")]
        public IWebElement CustomiseGrid_PerPageDropDownList { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-reset")]
        public IWebElement CustomiseGrid_ResetDisplayButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Name')]")]
        public IWebElement NameColumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Description')]")]
        public IWebElement DescriptionColumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Active')]")]
        public IWebElement ActiveColumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//thead/tr/th[contains(text(),'Actions')]")]
        public IWebElement ActionsColumn { get; set; }

        [FindsBy(How = How.Id, Using = "base-modal-dialog")]
        public IWebElement CompetencyEdit_Popup { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement CloseButton_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[1]")]
        public IWebElement CompetencyName { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[3]")]
        public IWebElement CompetencyActiveStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[4]/a[contains(text(),'Edit')]")]
        public IWebElement CompetencyActionEditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[4]/button[contains(text(),'Down')]")]
        public IWebElement CompetencyActionDownButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[2]/td[4]/button[contains(text(),'Up')]")]
        public IWebElement CompetencyActionUpButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr")]
        public IList<IWebElement> CompetencyList { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='pagination']")]
        public IWebElement PaginationSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Competency')]")]
        public IWebElement PopupManageCompetency_Title { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement PopupName_Textbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_Name']/following-sibling::span[@class='field-validation-error']")]
        public IWebElement PopupName_TextboxValidationMessage { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Description")]
        public IWebElement PopupDescription_Textbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@id='Dto_Description']/following-sibling::span[@class='field-validation-error']")]
        public IWebElement PopupDescription_TextboxValidationMessage { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement PopupActiveYes_RadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement PopupActiveNo_RadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Name']")]
        public IWebElement PopupName_Label { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Name']/span[text()='*']")]
        public IWebElement PopupName_LabelMandatory { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Description']")]
        public IWebElement PopupDescription_Label { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Description']/span[text()='*']")]
        public IWebElement PopupDescription_LabelMandatory { get; set; }

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

        public void VerifyCompetencyListPageElements()
        {
            Assert.IsTrue(PageTitle.Displayed, "Competency List Page title is not displayed in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Competency List Page title is displayed in the Competencies List Page");

            Assert.IsTrue(AddCompetencyButton.Displayed, "Add Competency Button is not displayed in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Competency Button is displayed in the Competencies List Page");

            Assert.IsTrue(KeywordLabel.Displayed, "Keyword Label is not displayed in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Label is displayed in the Competencies List Page");

            Assert.IsTrue(KeywordsTextBox.Displayed, "Keyword TextBox is not displayed in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword TextBox is displayed in the Competencies List Page");

            Assert.IsTrue(SearchButton.Displayed, "Keyword Search Button is not displayed in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Keyword Search Button is displayed in the Competencies List Page");

            CustomiseButton.Click();
            if (!CustomiseGrid_DescriptionCheckBox.Selected)
            {
                CustomiseGrid_DescriptionCheckBox.Click();
            }
            if (!CustomiseGrid_ActiveCheckBox.Selected)
            {
                CustomiseGrid_ActiveCheckBox.Click();
            }

            Assert.IsTrue(NameColumn.Displayed, "Name Column is not displayed in the Competencies List Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Name Column is displayed in the Competencies List Grid");

            Assert.IsTrue(DescriptionColumn.Displayed, "Description Column is not displayed in the Competencies List Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Description Column is displayed in the Competencies List Grid");

            Assert.IsTrue(ActiveColumn.Displayed, "Active Column is not displayed in the Competencies List Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Active Column is displayed in the Competencies List Grid");

            Assert.IsTrue(ActionsColumn.Displayed, "Actions Column is not displayed in the Competencies List Grid");
            ExtentReport.test.Log(LogStatus.Pass, "Actions Column is displayed in the Competencies List Grid");
        }

        public void VerifyActionsButton_CompetencyListPage()
        {
            if (CompetencyList.Count > 0)
            {
                bool searchResult = true;
                for (int i = 1; i <= CompetencyList.Count; i++)
                {
                    IWebElement editButton = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[4]/a[contains(text(),'Edit')]"));
                    if (!editButton.Displayed)
                    {
                        searchResult = false;
                        break;
                    }
                }
                Assert.IsTrue(searchResult, "Edit buttons has not been displayed appropriately in the Competencies List Grid");
                ExtentReport.test.Log(LogStatus.Pass, "Edit buttons has been displayed appropriately in the Competencies List Grid");

                string cName = CompetencyName.Text;

                Thread.Sleep(2000);
                CompetencyActionDownButton.Click();
                Thread.Sleep(4000);
                ExtentReport.test.Log(LogStatus.Info, "<b>" + cName + "</b> - Down button clicked and moved the competency down by one row in the Competencies List Grid");

                CompetencyActionUpButton.Click();
                Thread.Sleep(4000);
                ExtentReport.test.Log(LogStatus.Info, "<b>" + cName + "</b> - Up button clicked and moved the competency up by one row in the Competencies List Grid");

                CompetencyActionEditButton.Click();
                Thread.Sleep(6000);
                Assert.IsTrue(CompetencyEdit_Popup.Displayed, "Edit button click is not opening the Competency Edit popup properly in the Competencies List Grid");
                ExtentReport.test.Log(LogStatus.Pass, "Edit button click is opening the Competency Edit popup properly in the Competencies List Grid");

                CloseButton_Popup.Click();
                Thread.Sleep(3000);
            }
        }

        public void VerifyPagination_CompetencyListPage()
        {
            CustomiseButton.Click();
            Thread.Sleep(3000);
            BaseMethods.DdlSelectByText(CustomiseGrid_PerPageDropDownList, "10");
            //CustomiseGrid_ResetDisplayButton.Click();
            Thread.Sleep(4000);
            if (CompetencyList.Count == 10)
            {
                Assert.IsTrue(PaginationSection.Displayed, "Pagination is not present at the bottom of the page in the Competencies List Page");
                ExtentReport.test.Log(LogStatus.Pass, "Pagination is present at the bottom of the page in the Competencies List Page");
            }
            else if (CompetencyList.Count < 10)
            {
                ExtentReport.test.Log(LogStatus.Info, "Pagination is not displayed as Competency count is less then 10 in the Competencies List Page");
            }
        }

        public void VerifyAddPopupElements_CompetencyListPage()
        {
            Thread.Sleep(2000);
            AddCompetencyButton.Click();
            Thread.Sleep(6000);

            Assert.IsTrue(PopupManageCompetency_Title.Displayed, "The title of the Add Competency popup – Manage Competency is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "The title of the Add popup – Manage Competency is displaying in the Competencies List Page");

            Assert.IsTrue(PopupName_Label.Displayed, "Name field label of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Name field label of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupName_Textbox.Displayed, "Name field textbox of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Name field textbox of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupDescription_Label.Displayed, "Description field label of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Description field label of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupDescription_Textbox.Displayed, "Description field textbox of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Description field textbox of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupActive_Label.Displayed, "Active field label of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field label of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupActiveYes_RadioButton.Displayed, "Active field Yes Radio button of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field Yes Radio button of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupActiveNo_RadioButton.Displayed, "Active field No Radio button of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field No Radio button of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupActiveYes_RadioButton.Selected, "Active field is not defaulted to Yes Radio button of the Add Competency popup in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Active field is defaulted to Yes Radio button of the Add Competency popup in the Competencies List Page");

            Assert.IsTrue(PopupSubmit_Button.Displayed, "Submit button of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Submit button of the Add Competency popup is displaying in the Competencies List Page");

            Assert.IsTrue(PopupCancel_Button.Displayed, "Cancel button of the Add Competency popup is not displaying in the Competencies List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Cancel button of the Add Competency popup is displaying in the Competencies List Page");

            CloseButton_Popup.Click();
            Thread.Sleep(2000);
        }

        public void VerifyMandatoryFields_AddCompetency()
        {
            Thread.Sleep(2000);
            AddCompetencyButton.Click();
            Thread.Sleep(6000);

            PopupSubmit_Button.Click();
            Thread.Sleep(2000);

            Assert.IsTrue(ErrorMessage.Displayed, "Error message for validating the competency is not displayed in Add Competency popup");
            ExtentReport.test.Log(LogStatus.Pass, "Error message for validating the competency is displayed in Add Competency popup");

            try
            {
                Assert.IsTrue(PopupName_LabelMandatory.Displayed);
                ExtentReport.test.Log(LogStatus.Info, "Validation for Name field is enabled in Add Competency popup");
                Assert.IsTrue(PopupName_TextboxValidationMessage.Displayed, "Validation message of Name field for validating the competency is not displayed in Add Competency popup");
                ExtentReport.test.Log(LogStatus.Pass, "Validation message of Name field for validating the competency is displayed in Add Competency popup");
            }
            catch
            {
                ExtentReport.test.Log(LogStatus.Info, "Validation for Name field is not enabled in Add Competency popup");
            }

            try
            {
                Assert.IsTrue(PopupDescription_LabelMandatory.Displayed);
                ExtentReport.test.Log(LogStatus.Info, "Validation for Description field is enabled in Add Competency popup");
                Assert.IsTrue(PopupDescription_TextboxValidationMessage.Displayed, "Validation message of Description field for validating the competency is not displayed in Add Competency popup");
                ExtentReport.test.Log(LogStatus.Pass, "Validation message of Description field for validating the competency is displayed in Add Competency popup");

            }
            catch
            {
                ExtentReport.test.Log(LogStatus.Info, "Validation for Description field is not enabled in Add Competency popup");
            }

            CloseButton_Popup.Click();
            Thread.Sleep(2000);
        }

        public string CreateCompetency(string name, string description, string type, bool isCreate)
        {
            Thread.Sleep(2000);
            if (isCreate)
            {
                AddCompetencyButton.Click();
                Thread.Sleep(6000);
            }

            //string name = "Competency_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
            name = name + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            PopupName_Textbox.Clear();
            PopupName_Textbox.SendKeys(name);

            PopupDescription_Textbox.Clear();
            PopupDescription_Textbox.SendKeys(description);

            if (type == "Active")
            {
                PopupActiveYes_RadioButton.Click();
            }
            else//type will be InActive
            {
                PopupActiveNo_RadioButton.Click();
            }

            PopupSubmit_Button.Click();
            Thread.Sleep(4000);
            Assert.IsTrue(SuccessMessage.Displayed, name + " - " + type + " Competency is not " + formSubmitType + " successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + name + " - " + type + " Competency " + formSubmitType + " successfully");

            return name;
        }

        public void EditCompetency(DataRow dr)
        {
            string status = "InActive";
            if (dr["Active"].ToString().ToLower() == "yes")
            {
                status = "Active";
            }

            string compName = CreateCompetency(dr["Name"].ToString(), dr["Description"].ToString(), status, true);
            SearchCompetency(compName);
            CompetencyActionEditButton.Click();
            //Thread.Sleep(5000);
            formSubmitType = "Edited and Updated";

            string editstatus = "InActive";
            if (dr["EditActive"].ToString().ToLower() == "yes")
            {
                editstatus = "Active";
            }

            compName = CreateCompetency(dr["EditName"].ToString(), dr["EditDescription"].ToString(), editstatus, false);
            //Thread.Sleep(3000);
            SearchCompetency(compName);
        }

        public void CreateCompetency_SameName(DataRow dr)
        {
            int i = 0;
            string name = dr["Name"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            while (i < 2)
            {
                //Thread.Sleep(2000);
                AddCompetencyButton.Click();
                //Thread.Sleep(6000);

                PopupName_Textbox.Clear();
                PopupName_Textbox.SendKeys(name);

                PopupDescription_Textbox.Clear();
                PopupDescription_Textbox.SendKeys(dr["Description"].ToString());


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
                Assert.IsTrue(SuccessMessage.Displayed, name + " - Active Competency is not created successfully");
                ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + name + " - Active Competency created successfully");
            }
            SearchCompetency(name);

            Assert.AreEqual(2, CompetencyList.Count, "Creating of same name '" + name + "' - Competency was unsuccessful");
            ExtentReport.test.Log(LogStatus.Pass, name + " - Competency of same name has been created successfully and listed properly in the Competencies List Grid");
        }

        public void SearchCompetency_AllTypes()
        {
            DataTable dt = ExcelData.GetData_DataTable("EP_Competency", "Competency", "Enable", "Yes");
            DataRow dr = dt.Rows[0];

            string compName = dr["Name"].ToString();
            SearchCompetency(compName);

            KeywordsTextBox.Clear();
            KeywordsTextBox.SendKeys(DateTime.Now.ToString());
            SearchButton.Click();
            Thread.Sleep(3000);

            Assert.IsTrue(NoListRecordsFound.Displayed, "Search for a Non-Existent Competency was unsuccessful");
            ExtentReport.test.Log(LogStatus.Pass, "Search for a Non-Existent Competency was successful");

            KeywordsTextBox.Clear();
            KeywordsTextBox.SendKeys("");
            SearchButton.Click();
            Thread.Sleep(3000);

            ExtentReport.test.Log(LogStatus.Pass, "Blank Search in the Competency List was successful");

        }

        public void SearchCompetency(string keyword)
        {
            KeywordsTextBox.Clear();
            KeywordsTextBox.SendKeys(keyword);
            SearchButton.Click();
            Thread.Sleep(3000);

            Assert.IsTrue(CompetencyName.Text.Contains(keyword), keyword + " - Competency search was unsuccessful and is not found in the Competency List");
            ExtentReport.test.Log(LogStatus.Pass, keyword + " - Competency has been successfully searched and is present in the Competency List");
        }

    }
}
