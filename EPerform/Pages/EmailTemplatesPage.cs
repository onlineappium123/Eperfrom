using EPerform.Library;
using EPerform.Library.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    public class EmailTemplatesPage
    {
        IWebDriver _driver;


        public EmailTemplatesPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'New Email Template')]")]
        public IWebElement NewEmailTemplateButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_TemplateName")]
        public IWebElement EmailNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_EmailTypeId")]
        public IWebElement EmailTypeDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement ActiveYesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SenderEmail")]
        public IWebElement ReplyToTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Merge Fields ')]")]
        public IWebElement MergefieldsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Reviewee First Name')]")]
        public IWebElement ReviewFirtNameOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Reviewee Last Name')]")]
        public IWebElement ReviewLastNameOption { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement ActiveNoButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Reviewer First Name')]")]
        public IWebElement ReviewerFirstNameOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Reviewer Last Name')]")]
        public IWebElement ReviewerLastNameOption { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Review Name')]")]
        public IWebElement ReviewNameOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Review End Date')]")]
        public IWebElement ReviewEndDateOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Review Step')]")]
        public IWebElement ReviewStepOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Review Phase')]")]
        public IWebElement ReviewPhaseOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Review Phase End Date')]")]
        public IWebElement ReviewPhaseEndDateOption { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Content_ifr")]
        public IWebElement handleframetext { get; set; }


        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='SubjectEmailTypeDropDown']//a")]
        public IList<IWebElement> SubjectEmailList { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Subject")]
        public IWebElement SubjectTextBox { get; set; }


        public void TxtContext(string value)
        {
            _driver.SwitchTo().Frame(handleframetext);
            //IWebElement body = _driver.FindElement(By.Id("tinymce"));
            IWebElement body = _driver.FindElement(By.CssSelector("body"));
            body.SendKeys(value);
            _driver.SwitchTo().ParentFrame();
        }


        public void createEmailTemplate(string SheetName)
        {
            HomePage home = new HomePage(_driver);
            //  DataRow dr = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailTemplates", "KeyName", "EmailTemplates_01").Rows[0];
            DataTable dt = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", SheetName, "Enable", "Yes");
            foreach (DataRow dr in dt.Rows)
            {
                home.EperformSystemConfigurationArrowIcon.Click();
                home.EperformEmailTemplatesOption.Click();
                BaseMethods.webelementverify(NewEmailTemplateButton);
                NewEmailTemplateButton.Click();
                BaseMethods.verifyWebElement(EmailNameTextBox, "EmailNameTextBox is not displayed", "EmailTextBox is displayed");
                EmailNameTextBox.SendKeys(dr["Name"].ToString());
                EmailTypeDropdown.Click();
                BaseMethods.DdlSelectByText(EmailTypeDropdown, "Notification");
                if (dr["Is Active"].ToString() == "Yes")
                {
                    BaseMethods.verifyWebElement(ActiveYesButton, "ActiveYesButton is not displayed", "ActiveYesButton is displayed");
                    ActiveYesButton.Click();
                }
                else
                {
                    BaseMethods.verifyWebElement(ActiveYesButton, "ActiveNoButton is not displayed", "ActiveNoButton is displayed");
                    ActiveNoButton.Click();
                }
                BaseMethods.verifyWebElement(ReplyToTextBox, "ReplyTextBox is not displayed", "ReplyTextBox is displayed");
                ReplyToTextBox.SendKeys(dr["Reply To"].ToString());
                BaseMethods.verifyWebElement(SubjectTextBox, "SubjectTextBox is not displayed", "SubjectTextBox is displayed");
                SubjectTextBox.SendKeys(dr["NotificationSubject"].ToString());
               
                TxtContext(dr["Content"].ToString());
                BaseMethods.verifyWebElement(SubmitButton, "Submitbutton is not displayed", "SubmitButton is displayed");
                SubmitButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformSuccessMessage);
                if (dr["ProbationNotification"].ToString() == "Yes")
                {
                    createProbationNotification();
                }
                else
                {

                }
                if (dr["AdHocReview"].ToString() == "Yes")
                {


                    createAdHocReview();
                }
                else
                {

                }
            }
        }

        public void createProbationNotification()
        {
            HomePage home = new HomePage(_driver);
            DataTable data = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailTemplates", "ProbationNotification", "Yes");
            foreach (DataRow dr in data.Rows)
            {


                home.EperformSystemConfigurationArrowIcon.Click();
                home.EperformEmailTemplatesOption.Click();
                NewEmailTemplateButton.Click();
                EmailNameTextBox.SendKeys(dr["Name"].ToString());
                EmailTypeDropdown.Click();
                BaseMethods.DdlSelectByText(EmailTypeDropdown, "Probation Notification");
                if (dr["Is Active"].ToString() == "Yes")
                {
                    ActiveYesButton.Click();
                }
                else
                {
                    ActiveNoButton.Click();
                }
                ReplyToTextBox.SendKeys(dr["Reply To"].ToString());
                SubjectTextBox.SendKeys(dr["ProbationSubject"].ToString());
                TxtContext(dr["Content"].ToString());
                SubmitButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformSuccessMessage);
            }
        }

        public void createAdHocReview()
        {
            HomePage home = new HomePage(_driver);
            DataTable data = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailTemplates", "AdHocReview", "Yes");
            foreach (DataRow dr in data.Rows)
            {


                home.EperformSystemConfigurationArrowIcon.Click();
                home.EperformEmailTemplatesOption.Click();
                NewEmailTemplateButton.Click();
                EmailNameTextBox.SendKeys(dr["Name"].ToString());
                EmailTypeDropdown.Click();
                BaseMethods.DdlSelectByText(EmailTypeDropdown, "Ad Hoc Review");
                if (dr["Is Active"].ToString() == "Yes")
                {
                    ActiveYesButton.Click();
                }
                else
                {
                    ActiveNoButton.Click();
                }
                ReplyToTextBox.SendKeys(dr["Reply To"].ToString());
                SubjectTextBox.SendKeys(dr["AdHocReviewSubject"].ToString());
                TxtContext(dr["Content"].ToString());
                SubmitButton.Click();
                Thread.Sleep(3000);
                BaseMethods.webelementverify(EperformSuccessMessage);
            }


        }
    }




}
