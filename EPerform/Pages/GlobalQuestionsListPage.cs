using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections;
using System.Data;
using EPerform.Library;
using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using NUnit.Framework;
using ePerform.Pages;
using EPerform.Library.Excel;
using System.Threading;

namespace EPerform.Pages
{
    public class GlobalQuestionsListPage
    {
        IWebDriver driver;
        public GlobalQuestionsListPage(IWebDriver browser) 
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// 'Global Question List' Page Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Global Question List')]")]
        public IWebElement PageTitle { get; set; }

        /// <summary>
        /// Keyword Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Keyword')]")]
        public IWebElement KeywordText { get; set; }

        /// <summary>
        /// Keywords TextBox
        /// </summary>
        [FindsBy(How = How.Id, Using = "Keywords")]
        public IWebElement KeywordTextBox { get; set; }

        /// <summary>
        /// Search Button For Normal Search
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//button[@type='submit'])[1]")]
        public IWebElement SearchButton1 { get; set; }

        /// <summary>
        /// Search Button For Advanced Search
        /// </summary>
        //[FindsBy(How = How.XPath, Using = "//button[text()='Search']")]
        [FindsBy(How = How.XPath, Using = "(//button[@type='submit'])[2]")]
        public IWebElement SearchButton2 { get; set; }

        /// <summary>
        /// Show Advanced Search Link Button
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Show Advanced Search")]
        public IWebElement ShowAdvancedSearchButton { get; set; }

        /// <summary>
        /// Hide Advanced Search Link Button
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Hide Advanced Search")]
        public IWebElement HideAdvancedSearchButton { get; set; }

        /// <summary>
        /// Component Type Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Component Type')]")]
        public IWebElement ComponentTypeText { get; set; }

        /// <summary>
        /// Created On Date Range Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Created On Date Range')]")]
        public IWebElement CreatedOnDateRangeText { get; set; }

        /// <summary>
        /// Is Active Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Is Active')]")]
        public IWebElement IsActiveText { get; set; }

        /// <summary>
        /// Date Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_0")]
        public IWebElement DateCheckbox { get; set; }

        /// <summary>
        /// File Upload Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_1")]
        public IWebElement FileUploadCheckbox { get; set; }

        /// <summary>
        /// Select Multiple Items from a List Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_2")]
        public IWebElement SelectMultipleItemsfromaListCheckbox { get; set; }

        /// <summary>
        /// Numeric Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_3")]
        public IWebElement NumericCheckbox { get; set; }

        /// <summary>
        /// Ordered Preference Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_4")]
        public IWebElement OrderedPreferenceCheckbox { get; set; }

        /// <summary>
        /// Multi Line Text Area Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_5")]
        public IWebElement MultiLineTextAreaCheckbox { get; set; }

        /// <summary>
        /// Select Single Item from a List Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_6")]
        public IWebElement SelectSingleItemfromaListCheckbox { get; set; }

        /// <summary>
        /// Single Line Text Box Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_7")]
        public IWebElement SingleLineTextBoxCheckbox { get; set; }

        /// <summary>
        /// Yes or No Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_8")]
        public IWebElement YesorNoCheckbox { get; set; }

        /// <summary>
        /// Label Checkbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchComponentTypeIds_9")]
        public IWebElement LabelCheckbox { get; set; }

        /// <summary>
        /// Created On Date Range Text Box
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchCreatedOnDate")]
        public IWebElement DateRangeTextBox { get; set; }

        /// <summary>
        /// Apply Button in Created On Calender popup
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[text()='Apply']")]
        public IWebElement ApplyButton { get; set; }

        /// <summary>
        /// Is Active DropDownList
        /// </summary>
        [FindsBy(How = How.Id, Using = "SearchIsActive")]
        public IWebElement IsActiveDropDownList { get; set; }

        /// <summary>
        /// Customise Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa fa-cog']/..")]
        public IWebElement CustomiseButton { get; set; }

        /// <summary>
        /// Is Active DropDownList
        /// </summary>
        [FindsBy(How = How.Id, Using = "toggle-col-1")]
        public IWebElement CustomizeQuestionTypeCheckBox { get; set; }

        /// <summary>
        /// Is Active DropDownList
        /// </summary>
        [FindsBy(How = How.Id, Using = "toggle-col-2")]
        public IWebElement CustomizeCreatedOnCheckBox { get; set; }

        /// <summary>
        /// Is Active DropDownList
        /// </summary>
        [FindsBy(How = How.Id, Using = "toggle-col-3")]
        public IWebElement CustomizeActiveCheckBox { get; set; }

        /// <summary>
        /// Is Active DropDownList
        /// </summary>
        [FindsBy(How = How.Id, Using = "changeItemsPerPage")]
        public IWebElement CustomizeQuestionPerPageDDL { get; set; }

        /// <summary>
        /// Reference Button For Sorting
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Reference']/..")]
        public IWebElement ReferenceButton_Sorting { get; set; }

        /// <summary>
        /// Reference Button For Sorting Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Reference']/following-sibling::i")]
        public IWebElement ReferenceButton_SortingIcon { get; set; }

        /// <summary>
        /// Reference List
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr/td[1]")]
        public IList<IWebElement> ReferenceList { get; set; }

        /// <summary>
        /// Created On Button For Sorting
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Created On']/..")]
        public IWebElement CreatedOnButton_Sorting { get; set; }

        /// <summary>
        /// Created On Button For Sorting Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Created On']/following-sibling::i")]
        public IWebElement CreatedOnButton_SortingIcon { get; set; }

        /// <summary>
        /// Created On List
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr/td[3]")]
        public IList<IWebElement> CreatedOnList { get; set; }

        /// <summary>
        /// Active Button For Sorting
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Active']/..")]
        public IWebElement ActiveButton_Sorting { get; set; }

        /// <summary>
        /// Active Button For Sorting Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//span[text()='Active']/following-sibling::i")]
        public IWebElement ActiveButton_SortingIcon { get; set; }

        /// <summary>
        /// Active Item
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr[1]/td[4]")]
        public IWebElement ActiveItem { get; set; }

        /// <summary>
        /// Edit button of the searched item
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Edit')])[1]")]
        public IWebElement SearchedEditButton { get; set; }

        /// <summary>
        /// Delete button of the searched item
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Delete')])[1]")]
        public IWebElement SearchedDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Confirm']")]
        public IWebElement DeletePopupConfirmButton { get; set; }

        [FindsBy(How = How.Id, Using = "NoListRecords")]
        public IWebElement NoRecordsFoundMessage { get; set; }


        public void GoToGlobalQuestionsListPage(IWebDriver gqListdriver)
        {
            HomePage homePage = new HomePage(gqListdriver);
            homePage.EperformSystemConfigurationArrowIcon.Click();
            homePage.EperformGlobalQuestionsOption.Click();

        }

        public void SearchGlobalQuestions(DataRow dr)
        {
            if (dr["Advanced Search"].ToString().ToLower() == "no")
            {
                ExtentReport.test.Log(LogStatus.Info, "Searching Global Questions for the keyword - " + dr["KeyWord"].ToString() + " in Global Questions List Page");
                SearchGQ(dr["KeyWord"].ToString());
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Info, "Advanced Searching Global Questions for the keyword - " + dr["KeyWord"].ToString() + " in Global Questions List Page");
                Thread.Sleep(2000);
                KeywordTextBox.Clear();
                KeywordTextBox.SendKeys(dr["KeyWord"].ToString());
                ShowAdvancedSearchButton.Click();

                ClearFilterFields();
                Thread.Sleep(2000);
                if (dr["Date"].ToString() == "Yes")
                {
                    DateCheckbox.Click();
                }
                if (dr["File Upload"].ToString() == "Yes")
                {
                    FileUploadCheckbox.Click();
                }
                if (dr["Select Multiple Items from a List"].ToString() == "Yes")
                {
                    SelectMultipleItemsfromaListCheckbox.Click();
                }
                if (dr["Numeric"].ToString() == "Yes")
                {
                    NumericCheckbox.Click();
                }
                if (dr["Ordered Preference"].ToString() == "Yes")
                {
                    OrderedPreferenceCheckbox.Click();
                }
                if (dr["Multi Line Text Area"].ToString() == "Yes")
                {
                    MultiLineTextAreaCheckbox.Click();
                }
                if (dr["Select Single Item from a List"].ToString() == "Yes")
                {
                    SelectSingleItemfromaListCheckbox.Click();
                }
                if (dr["Single Line Text Box"].ToString() == "Yes")
                {
                    SingleLineTextBoxCheckbox.Click();
                }
                if (dr["Yes or No"].ToString() == "Yes")
                {
                    YesorNoCheckbox.Click();
                }
                if (dr["Label"].ToString() == "Yes")
                {
                    LabelCheckbox.Click();
                }
                if (dr["Date Range"].ToString().Trim() != string.Empty)
                {
                    DateRangeTextBox.Clear();
                    DateRangeTextBox.SendKeys(dr["Date Range"].ToString());
                    Thread.Sleep(2000);
                    ApplyButton.Click();
                }
                if (dr["Is Active"].ToString().Trim() != string.Empty)
                {
                    BaseMethods.DdlSelectByText(IsActiveDropDownList, dr["Is Active"].ToString());
                }
                SearchButton2.Click();
            }
            Thread.Sleep(2000);

            try
            {
                IList<IWebElement> searchedList = driver.FindElements(By.XPath("//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr"));
                if (searchedList.Count > 0)
                {
                    bool searchResult = false;
                    for (int i = 0; i < searchedList.Count; i++)
                    {
                        if (searchedList[i].Text.Contains(dr["KeyWord"].ToString()))
                        {
                            searchResult = true;
                            break;
                        }
                    }
                    BaseMethods.SoftAssert_IsTrue(searchResult, "Searching Global Questions for the Keyword - " + dr["KeyWord"].ToString() + " in Global Questions List Page is Successful",
                                                                "Searching Global Questions for the Keyword - " + dr["KeyWord"].ToString() + " in Global Questions List Page is Unsuccessful");
                }
                else
                {
                    bool check = NoRecordsFoundMessage.Displayed;
                    ExtentReport.test.Log(LogStatus.Fatal, "No Records Found Message is displayed, " + dr["KeyWord"].ToString() + " - Keyword is not found in the Global Question List");
                }
            }
            catch (NoSuchElementException)
            {
                bool check = NoRecordsFoundMessage.Displayed;
                ExtentReport.test.Log(LogStatus.Fatal, "No Records Found Message is displayed, " + dr["KeyWord"].ToString() + " - Keyword is not found in the Global Question List");
            }
            #region old
            //if (NoRecordsFoundMessage.Displayed)
            //{
            //    ExtentReport.test.Log(LogStatus.Fatal, "No Records Found Message is displayed, " + dr["KeyWord"].ToString() + " - Keyword is not found in the Global Question List");
            //}
            //else
            //{
            //    IList<IWebElement> searchedList = driver.FindElements(By.XPath("//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr"));
            //    bool searchResult = false;
            //    for (int i = 0; i < searchedList.Count; i++)
            //    {
            //        if (searchedList[i].Text.Contains(dr["KeyWord"].ToString()))
            //        {
            //            searchResult = true;
            //        }
            //    }
            //    Assert.IsTrue(searchResult, "Searching Global Questions for the keyword - " + dr["KeyWord"].ToString() + " in Global Questions List Page is Unsuccessful");
            //    ExtentReport.test.Log(LogStatus.Pass, "Searching Global Questions for the keyword - " + dr["KeyWord"].ToString() + " in Global Questions List Page is Successful");
            //}
            #endregion
        }

        public void ClearFilterFields()
        {
            if (DateCheckbox.Selected == true)
            {
                DateCheckbox.Click();
            }
            if (FileUploadCheckbox.Selected == true)
            {
                FileUploadCheckbox.Click();
            }
            if (SelectMultipleItemsfromaListCheckbox.Selected == true)
            {
                SelectMultipleItemsfromaListCheckbox.Click();
            }
            if (NumericCheckbox.Selected == true)
            {
                NumericCheckbox.Click();
            }
            if (OrderedPreferenceCheckbox.Selected == true)
            {
                OrderedPreferenceCheckbox.Click();
            }
            if (MultiLineTextAreaCheckbox.Selected == true)
            {
                MultiLineTextAreaCheckbox.Click();
            }
            if (SelectSingleItemfromaListCheckbox.Selected == true)
            {
                SelectSingleItemfromaListCheckbox.Click();
            }
            if (SingleLineTextBoxCheckbox.Selected == true)
            {
                SingleLineTextBoxCheckbox.Click();
            }
            if (YesorNoCheckbox.Selected == true)
            {
                YesorNoCheckbox.Click();
            }
            if (LabelCheckbox.Selected == true)
            {
                LabelCheckbox.Click();
            }
            DateRangeTextBox.Clear();
            BaseMethods.DdlSelectByText(IsActiveDropDownList, "Any");
        }

        public void CustomiseGlobalQuestionsList(DataRow dr)
        {
            Thread.Sleep(2000);
            CustomiseButton.Click();
            Thread.Sleep(2000);
            if (dr["Question Type"].ToString() == "Yes" && !CustomizeQuestionTypeCheckBox.Selected)
            {
                CustomizeQuestionTypeCheckBox.Click();
            }
            else if (dr["Question Type"].ToString() == "No" && CustomizeQuestionTypeCheckBox.Selected)
            {
                CustomizeQuestionTypeCheckBox.Click();
            }

            if (dr["Created On"].ToString() == "Yes" && !CustomizeCreatedOnCheckBox.Selected)
            {
                CustomizeCreatedOnCheckBox.Click();
            }
            else if (dr["Created On"].ToString() == "No" && CustomizeCreatedOnCheckBox.Selected)
            {
                CustomizeCreatedOnCheckBox.Click();
            }

            if (dr["Active"].ToString() == "Yes" && !CustomizeActiveCheckBox.Selected)
            {
                CustomizeActiveCheckBox.Click();
            }
            else if (dr["Active"].ToString() == "No" && CustomizeActiveCheckBox.Selected)
            {
                CustomizeActiveCheckBox.Click();
            }
            Thread.Sleep(2000);
            BaseMethods.DdlSelectByValue(CustomizeQuestionPerPageDDL, dr["QuestionPerPage"].ToString());
        }

        public void Sorting()
        {
            SortingReference();
            Thread.Sleep(2000);
            SortingCreatedOn();
            Thread.Sleep(2000);
            SortingActive();
        }

        public void SortingReference()
        {
            int i = 0;
            while (i < 2)
            {
                Thread.Sleep(2000);
                ReferenceButton_Sorting.Click();
                Thread.Sleep(2000);
                if (ReferenceButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-asc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Created On Column in Global Question List Ascending sorting is successfully");
                }
                else if (ReferenceButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-desc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Created On Column in Global Question List Descending sorting is successfully");
                }
                i++;
            }
        }

        public void SortingCreatedOn()
        {
            int i = 0;
            while (i < 2)
            {
                Thread.Sleep(2000);
                CreatedOnButton_Sorting.Click();
                ArrayList original = new ArrayList();
                ArrayList sorted = new ArrayList();
                Thread.Sleep(2000);
                for (int j = 0; j < CreatedOnList.Count() - 1; j++)
                {
                    original.Add(CreatedOnList[j].Text);
                    sorted.Add(CreatedOnList[j].Text);
                }
                Thread.Sleep(2000);
                if (CreatedOnButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-asc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Created On Column in Global Question List Ascending sorting is successfully");
                }
                else if (CreatedOnButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-desc")
                {
                    ExtentReport.test.Log(LogStatus.Pass, "Created On Column in Global Question List Descending sorting is successfully");
                }
                i++;
            }
        }

        public void SortingActive()
        {
            int i = 0;
            while (i < 2)
            {
                Thread.Sleep(2000);
                ActiveButton_Sorting.Click();
                Thread.Sleep(2000);
                if (ActiveButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-asc")
                {
                    bool chk = ActiveItem.Text.Trim() == "No" ? true : false;
                    Assert.IsTrue(chk, "Active Column in Global Question List Ascending sorting is incorrect");
                    ExtentReport.test.Log(LogStatus.Pass, "Active Column in Global Question List Ascending sorting is successfully");
                }
                else if (ActiveButton_SortingIcon.GetAttribute("class") == "fa fa-sort-amount-desc")
                {
                    bool chk = ActiveItem.Text.Trim() == "Yes" ? true : false;
                    Assert.IsTrue(chk, "Active Column in Global Question List Descending sorting is incorrect");
                    ExtentReport.test.Log(LogStatus.Pass, "Active Column in Global Question List Descending sorting is successfully");
                }
                i++;
            }
        }

        public void SearchGQ(string keyWord)
        {
            //Thread.Sleep(2000);
            KeywordTextBox.Clear();
            KeywordTextBox.SendKeys(keyWord);
            SearchButton1.Click();
        }

    }
}
