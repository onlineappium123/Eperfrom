using ePerform.Library.Extent_Reports;
using EPerform.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    class MarkerListPage
    {
        IWebDriver driver;

        public MarkerListPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Marker List')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.Id, Using = "Keywords")]
        public IWebElement Keywords_TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Search')]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Marker')]")]
        public IWebElement AddMarkerButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']")]
        public IWebElement MarkerListGrid { get; set; }

        [FindsBy(How = How.Id, Using = "base-modal-dialog")]
        public IWebElement ManageMarkerModalPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Marker')]")]
        public IWebElement ManageMarker_PopupTitle { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement Name_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_BackgroundColour")]
        public IWebElement Colour_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MarkerFontColour")]
        public IWebElement FontColour_TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement Cancel_Button { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement CloseButton_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_Name']/following-sibling::span[@class='field-validation-error']")]
        public IWebElement Name_TextboxValidationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_BackgroundColour']/following-sibling::span[@class='field-validation-error']")]
        public IWebElement Colour_TextBoxValidationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_MarkerFontColour']/following-sibling::span[@class='field-validation-error']")]
        public IWebElement FontColour_TextBoxValidationMessage { get; set; }

        [FindsBy(How = How.Id, Using = "table1_info")]
        public IWebElement MarkerPagination { get; set; }

        [FindsBy(How = How.Id, Using = "NoListRecords")]
        public IWebElement NoListRecordsFound { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa fa-cog']/..")]
        public IWebElement CustomiseButton { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-1")]
        public IWebElement CustomizeColourCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Name']/..")]
        public IWebElement NameButton_Sorting { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Name']/following-sibling::i")]
        public IWebElement NameButton_SortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Colour']/..")]
        public IWebElement ColourButton_Sorting { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Colour']/following-sibling::i")]
        public IWebElement ColourButton_SortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[1]")]
        public IWebElement MarkerName { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[3]/a[contains(text(),'Edit')]")]
        public IWebElement MarkerActionEditButton { get; set; }

        public void MarkerListPageVerification()
        {
            Assert.IsTrue(PageTitle.Displayed, "Marker List page is not displayed on click of Marker Option in the Header Tab");
            ExtentReport.test.Log(LogStatus.Pass, "Marker List page is displayed on click of Marker Option in the Header Tab");

            Assert.IsTrue(MarkerListGrid.Displayed, "The List of Markers is not available under the Marker List Page");
            ExtentReport.test.Log(LogStatus.Pass, "The List of Markers is displayed successfully in the Marker List Page");

            CustomiseButton.Click();
            Thread.Sleep(2000);
            if (!CustomizeColourCheckBox.Selected)
            {
                CustomizeColourCheckBox.Click();
            }

            SortingName();

            SortingColour();

            Assert.IsTrue(Keywords_TextBox.Displayed, "The Search field is not available on the top of the Marker List Page");
            ExtentReport.test.Log(LogStatus.Pass, "The Search field is displayed successfully on the top of the Marker List Page");

            Assert.IsTrue(MarkerPagination.Displayed, "The Pagination is not available at the bottom of the Marker List Page");
            ExtentReport.test.Log(LogStatus.Pass, "The Pagination is displayed successfully at the bottom of the Marker List Page");

            Assert.IsTrue(AddMarkerButton.Displayed, "Add Marker Button is not displayed in the Marker List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Add Marker Button is displayed in the Marker List Page");

            AddMarkerButton.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(ManageMarkerModalPopup.Displayed, "Manage Marker Modal Window is not displayed on click of Add Marker Button in the Marker List Page");
            ExtentReport.test.Log(LogStatus.Pass, "Manage Marker Modal Window is displayed successfully on click of Add Marker Button in the Marker List Page");

            Assert.IsTrue(Name_TextBox.Displayed, "Name field is not displayed in the Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Name field is displayed successfully in the Manage Marker Modal Window");

            Assert.IsTrue(Colour_TextBox.Displayed, "Colour field is not displayed in the Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Colour field is displayed successfully in the Manage Marker Modal Window");

            Assert.IsTrue(FontColour_TextBox.Displayed, "Font Colour field is not displayed in the Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Font Colour field is displayed successfully in the Manage Marker Modal Window");

            Submit_Button.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(ErrorMessage.Displayed, "Error message for validating the Marker Add is not displayed in Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Error message for validating the Marker Add is displayed in Manage Marker Modal Window");

            Assert.IsTrue(Name_TextboxValidationMessage.Displayed, "Error message for validating the Name field is not displayed in Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Error message for validating the Name field is displayed in Manage Marker Modal Window");

            Assert.IsTrue(Colour_TextBoxValidationMessage.Displayed, "Error message for validating the Colour field is not displayed in Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Error message for validating the Colour field is displayed in Manage Marker Modal Window");

            Assert.IsTrue(FontColour_TextBoxValidationMessage.Displayed, "Error message for validating the Font Colour field is not displayed in Manage Marker Modal Window");
            ExtentReport.test.Log(LogStatus.Pass, "Error message for validating the Font Colour field is displayed in Manage Marker Modal Window");
            try
            {
                CloseButton_Popup.Click();
            }
            catch
            {

            }
        }

        public void SortingName()
        {
            int i = 0;
            while (i < 2)
            {
                Thread.Sleep(2000);
                NameButton_Sorting.Click();
                Thread.Sleep(2000);
                if (NameButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-asc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Name Column in Marker List Ascending sorting is successfully");
                }
                else if (NameButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-desc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Name Column in Marker List Descending sorting is successfully");
                }
                else
                {
                    BaseMethods.SoftAssert_IsTrue(false, "", "Sorting of Name Column in Marker List is unsuccessful");
                }
                i++;
            }
        }

        public void SortingColour()
        {
            int i = 0;
            while (i < 2)
            {
                Thread.Sleep(2000);
                ColourButton_Sorting.Click();
                Thread.Sleep(2000);
                if (ColourButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-asc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Colour Column in Marker List Ascending sorting is successfully");
                }
                else if (ColourButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-desc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Colour Column in Marker List Descending sorting is successfully");
                }
                else
                {
                    BaseMethods.SoftAssert_IsTrue(false, "", "Sorting of Colour Column in Marker List is unsuccessful");
                }
                i++;
            }
        }

        public void CreateUpdateMarker(DataRow dr)
        {
            AddMarkerButton.Click();
            string name = dr["Name"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
            Name_TextBox.SendKeys(name);

            Colour_TextBox.SendKeys(dr["Colour"].ToString());

            FontColour_TextBox.SendKeys(dr["FontColour"].ToString());

            Submit_Button.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(SuccessMessage.Displayed, dr["Name"].ToString() + " - Marker is not created successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + dr["Name"].ToString() + " - Marker is created successfully");

            if (dr["IsEdit"].ToString().ToLower() == "yes")
            {
                SearchMarker(dr["Name"].ToString());

                Assert.IsTrue(MarkerActionEditButton.Displayed, dr["Name"].ToString() + " - Marker Edit button is not displayed in the Marker List");
                ExtentReport.test.Log(LogStatus.Pass, dr["Name"].ToString() + " - Marker Edit button is displayed in the Marker List");

                MarkerActionEditButton.Click();
                Thread.Sleep(2000);

                Colour_TextBox.Clear();
                Colour_TextBox.SendKeys(dr["EditColour"].ToString());

                FontColour_TextBox.Clear();
                FontColour_TextBox.SendKeys(dr["EditFontColour"].ToString());

                Submit_Button.Click();
                Thread.Sleep(2000);
                Assert.IsTrue(SuccessMessage.Displayed, dr["Name"].ToString() + " - Marker is not edited and updated successfully");
                ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + dr["Name"].ToString() + " - Marker is edited and updated successfully");
            }

        }

        public void SearchMarker(string markerName)
        {
            Keywords_TextBox.Clear();
            Keywords_TextBox.SendKeys(markerName);
            SearchButton.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(MarkerName.Text.Contains(markerName), markerName + " - Marker search was unsuccessful and is not found in the Marker List");
            ExtentReport.test.Log(LogStatus.Pass, markerName + " - Marker has been successfully searched and is present in the Marker List");
        }
    }
}
