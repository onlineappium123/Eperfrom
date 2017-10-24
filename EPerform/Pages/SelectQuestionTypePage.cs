using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ePerform.Library;
using ePerfrom.Library;
using System.Data;
using System.Threading;

namespace ePerform.Pages
{
    public class SelectQuestionTypePage
    {
        IWebDriver driver;

        public SelectQuestionTypePage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// 'Home' Link Button in Breadcrumbs
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//div[@id='breadcrumbs']//a[text()='Home']")]
        private IWebElement eleLnkHome_BreadCrumb;
        public IWebElement LnkHome_BreadCrumb
        {
            get
            {
                return eleLnkHome_BreadCrumb;
            }
            set
            {
                eleLnkHome_BreadCrumb = value;
            }
        }

        /// <summary>
        /// 'Global Question List' Link Button in Breadcrumbs
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//div[@id='breadcrumbs']//a[text()='Global Question List']")]
        private IWebElement eleLnkGQList_BreadCrumb;
        public IWebElement LnkGQList_BreadCrumb
        {
            get
            {
                return eleLnkGQList_BreadCrumb;
            }
            set
            {
                eleLnkGQList_BreadCrumb = value;
            }
        }

        /// <summary>
        /// 'Select Question Type' Text in Breadcrumbs
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//div[@id='breadcrumbs']//li[contains(text(),'Select Question Type')]")]
        private IWebElement elePageTitle_BreadCrumb;
        public IWebElement PageTitle_BreadCrumb
        {
            get
            {
                return elePageTitle_BreadCrumb;
            }
            set
            {
                elePageTitle_BreadCrumb = value;
            }
        }

        /// <summary>
        /// 'Select Question Type' Page Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Select Question Type')]")]
        private IWebElement elePageTitle;
        public IWebElement PageTitle
        {
            get
            {
                return elePageTitle;
            }
            set
            {
                elePageTitle = value;
            }
        }

        /// <summary>
        /// 'Select Question Type' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Select Question Component Type')]")]
        private IWebElement eleSelectQuestionTypeFormTitle;
        public IWebElement SelectQuestionTypeFormTitle
        {
            get
            {
                return eleSelectQuestionTypeFormTitle;
            }
            set
            {
                eleSelectQuestionTypeFormTitle = value;
            }
        }

        /// <summary>
        /// 'Single Line Text Box' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_0")]
        private IWebElement eleRdoSingleLineTextBox;
        public IWebElement RdoSingleLineTextBox
        {
            get
            {
                return eleRdoSingleLineTextBox;
            }
            set
            {
                eleRdoSingleLineTextBox = value;
            }
        }

        /// <summary>
        /// 'Multi Line Text Area' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_1")]
        private IWebElement eleRdoMultiLineTextArea;
        public IWebElement RdoMultiLineTextArea
        {
            get
            {
                return eleRdoMultiLineTextArea;
            }
            set
            {
                eleRdoMultiLineTextArea = value;
            }
        }

        /// <summary>
        /// 'Select Single Item from a List' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_2")]
        private IWebElement eleRdoSelectSingleItem;
        public IWebElement RdoSelectSingleItem
        {
            get
            {
                return eleRdoSelectSingleItem;
            }
            set
            {
                eleRdoSelectSingleItem = value;
            }
        }

        /// <summary>
        /// 'Select Multiple Items from a List' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_3")]
        private IWebElement eleRdoSelectMultipleItems;
        public IWebElement RdoSelectMultipleItems
        {
            get
            {
                return eleRdoSelectMultipleItems;
            }
            set
            {
                eleRdoSelectMultipleItems = value;
            }
        }

        /// <summary>
        /// 'Numeric' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_4")]
        private IWebElement eleRdoNumeric;
        public IWebElement RdoNumeric
        {
            get
            {
                return eleRdoNumeric;
            }
            set
            {
                eleRdoNumeric = value;
            }
        }

        /// <summary>
        /// 'Yes or No' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_5")]
        private IWebElement eleRdoYesorNo;
        public IWebElement RdoYesorNo
        {
            get
            {
                return eleRdoYesorNo;
            }
            set
            {
                eleRdoYesorNo = value;
            }
        }

        /// <summary>
        /// 'Date' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_6")]
        private IWebElement eleRdoDate;
        public IWebElement RdoDate
        {
            get
            {
                return eleRdoDate;
            }
            set
            {
                eleRdoDate = value;
            }
        }

        /// <summary>
        /// 'File Upload' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_7")]
        private IWebElement eleRdoFileUpload;
        public IWebElement RdoFileUpload
        {
            get
            {
                return eleRdoFileUpload;
            }
            set
            {
                eleRdoFileUpload = value;
            }
        }

        /// <summary>
        /// 'Single Line TextBox' Textbox
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_0']/../following-sibling::span/input")]
        private IWebElement eleTxtSingleLineTextBox;
        public IWebElement TxtSingleLineTextBox
        {
            get
            {
                return eleTxtSingleLineTextBox;
            }
            set
            {
                eleTxtSingleLineTextBox = value;
            }
        }

        /// <summary>
        /// 'Multi Line Text Area' Text area
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_1']/../following-sibling::span/textarea")]
        private IWebElement eleTxtMultiLineTextArea;
        public IWebElement TxtMultiLineTextArea
        {
            get
            {
                return eleTxtMultiLineTextArea;
            }
            set
            {
                eleTxtMultiLineTextArea = value;
            }
        }

        /// <summary>
        /// 'Select Single Item' Dropdown List
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_2']/../following-sibling::span/select")]
        private IWebElement eleDdlSelectSingleItem;
        public IWebElement DdlSelectSingleItem
        {
            get
            {
                return eleDdlSelectSingleItem;
            }
            set
            {
                eleDdlSelectSingleItem = value;
            }
        }

        /// <summary>
        /// 'Select Multiple Items' Dropdown List
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_3']/../following-sibling::span/select")]
        private IWebElement eleDdlSelectMultipleItems;
        public IWebElement DdlSelectMultipleItems
        {
            get
            {
                return eleDdlSelectMultipleItems;
            }
            set
            {
                eleDdlSelectMultipleItems = value;
            }
        }
        //public void DdlSelectMultipleItems(string items)
        //{
        //    string[] itemsList = items.Split(',');
        //    //BaseClass.controlButtonKeyDown(driver);
        //    for (int i = 0; i < itemsList.Length; i++)
        //    {
        //      //  BaseClass.ddlSelectByText(eleDdlSelectMultipleItems, itemsList[i]);
        //    }
        //}

        /// <summary>
        /// 'Numeric' Textbox
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_4']/../following-sibling::span/input")]
        private IWebElement eleTxtNumeric;
        public IWebElement TxtNumeric
        {
            get
            {
                return eleTxtNumeric;
            }
            set
            {
                eleTxtNumeric = value;
            }
        }

        /// <summary>
        /// 'Yes' Radio Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_5']/../following-sibling::span/label[@class='radio']/input[1]")]
        private IWebElement eleRdoYes;
        public IWebElement RdoYes
        {
            get
            {
                return eleRdoYes;
            }
            set
            {
                eleRdoYes = value;
            }
        }

        /// <summary>
        /// 'No' Radio Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_5']/../following-sibling::span/label[@class='radio']/input[2]")]
        private IWebElement eleRdoNo;
        public IWebElement RdoNo
        {
            get
            {
                return eleRdoNo;
            }
            set
            {
                eleRdoNo = value;
            }
        }
        
        /// <summary>
        /// 'File Upload' Uploader
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_7']/../following-sibling::span/input")]
        private IWebElement eleFileUpload;
        public IWebElement FileUpload
        {
            get
            {
                return eleFileUpload;
            }
            set
            {
                eleFileUpload = value;
            }
        }

        /// <summary>
        /// 'Submit' Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        private IWebElement eleBtnSubmit;
        public IWebElement BtnSubmit
        {
            get
            {
                return eleBtnSubmit;
            }
            set
            {
                eleBtnSubmit = value;
            }
        }

        /// <summary>
        /// 'Cancel' Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        private IWebElement eleBtnCancel;
        public IWebElement BtnCancel
        {
            get
            {
                return eleBtnCancel;
            }
            set
            {
                eleBtnCancel = value;
            }
        }

        /// <summary>
        /// Success message
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        private IWebElement eleSuccessMessage;
        public IWebElement SuccessMessage
        {
            get
            {
                return eleSuccessMessage;
            }
            set
            {
                eleSuccessMessage = value;
            }
        }

        /// <summary>
        /// Error message
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error')]")]
        private IWebElement eleErrorMessage;
        public IWebElement ErrorMessage
        {
            get
            {
                return eleErrorMessage;
            }
            set
            {
                eleErrorMessage = value;
            }
        }

        /// <summary>
        /// Add Global Question Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add global question')]")]        
        public IWebElement BtnAddGlobalQuestion { get; set; }

        public string CreateGQ_SingleLineTextBox(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoSingleLineTextBox.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_SingleLineTextBox(dr);
        }

        public string CreateGQ_MultiLineTextArea(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoMultiLineTextArea.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_MultiLineTextArea(dr);
        }

        public string CreateGQ_SelectSingleItem(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoSelectSingleItem.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_SelectSingleItem(dr);
        }

        public string CreateGQ_SelectMultipleitems(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoSelectMultipleItems.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_SelectMultipleitems(dr);
        }

        public string CreateGQ_Numeric(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoNumeric.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_Numeric(dr);
        }

        public string CreateGQ_YesorNo(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoYesorNo.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_YesorNo(dr);
        }

        public string CreateGQ_Date(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoDate.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_Date(dr);
        }

        public string CreateGQ_FileUpload(DataRow dr)
        {
            Thread.Sleep(2000);
            BtnAddGlobalQuestion.Click();
            RdoFileUpload.Click();
            BtnSubmit.Click();
            ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
            return mGQPage.CreateGQ_FileUpload(dr);
        }

        //public void EditGQ_SingleLineTextBox(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoSingleLineTextBox.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_SingleLineTextBox(drAdd, drEdit);
        //}

        //public void EditGQ_MultiLineTextArea(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoMultiLineTextArea.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_MultiLineTextArea(drAdd, drEdit);
        //}

        //public void EditGQ_SelectSingleItem(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoSelectSingleItem.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_SelectSingleItem(drAdd, drEdit);
        //}

        //public void EditGQ_SelectMultipleitems(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoSelectMultipleItems.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_SelectMultipleitems(drAdd, drEdit);
        //}

        //public void EditGQ_Numeric(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoNumeric.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_Numeric(drAdd, drEdit);
        //}

        //public void EditGQ_YesorNo(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoYesorNo.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_YesorNo(drAdd, drEdit);
        //}

        //public void EditGQ_Date(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoDate.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_Date(drAdd, drEdit);
        //}

        //public void EditGQ_FileUpload(DataRow drAdd, DataRow drEdit)
        //{
        //    Thread.Sleep(2000);
        //    BtnAddGlobalQuestion.Click();
        //    RdoFileUpload.Click();
        //    BtnSubmit.Click();
        //    ManageGlobalQuestionPage mGQPage = new ManageGlobalQuestionPage(driver);
        //    mGQPage.EditGQ_FileUpload(drAdd, drEdit);
        //}

    }
}
