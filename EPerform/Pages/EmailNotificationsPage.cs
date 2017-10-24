using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Data;
using EPerform.Library.Excel;
using EPerform.Library;
using System.Threading;

namespace EPerform.Pages
{
    class EmailNotificationsPage
    {

        IWebDriver driver;

        public EmailNotificationsPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How =How.XPath,Using = "//a[contains(text(),' Edit')]")]
        public IList<IWebElement> EditButton { get; set; }
        
        [FindsBy(How =How.Id,Using = "Dto_EmailNotificationTypeId")]
        public IWebElement EmailNotificationsTypeDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_IsEnabled_t")]
        public IWebElement NotificationEnabledYesRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_IsEnabled_f")]
        public IWebElement NotificationEnabledNoRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_EmailTemplateId")]
        public IWebElement EmailTemplateNameDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_PeriodDuration")]
        public IWebElement periodDurationTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_DurationTimePeriodTypeId")]
        public IWebElement PeriodTypeDropDown { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[text()='Submit']")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }


        public void EditEmailNotificationsManager()
        {
            HomePage home = new HomePage(driver);
            //DataRow dr = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailNotifications", "KeyName", "EmailNotifications_01").Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailNotifications", "EditEnable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                home.EperformSystemConfigurationArrowIcon.Click();
                home.EperformEmailNotificationsOption.Click();
                BaseMethods.webelementverify(EditButton.ElementAt(1));
                EditButton.ElementAt(1).Click();

                EmailNotificationsTypeDropDown.Click();
                BaseMethods.DdlSelectByText(EmailNotificationsTypeDropDown, dr["Email Notification Type"].ToString());
                if (dr["NotificationEnabled"].ToString() == "Yes")
                {
                    BaseMethods.verifyWebElement(NotificationEnabledYesRadioButton, "NotificationEnabledYesRadioButton is not displayed", "NotificationEnabledYesRadioButton is  displayed");
                    NotificationEnabledYesRadioButton.Click();
                }
                else
                {
                    BaseMethods.verifyWebElement(NotificationEnabledNoRadioButton, "NotificationEnabledNoRadioButton is not displayed", "NotificationEnabledNoRadioButton is  displayed");
                    NotificationEnabledNoRadioButton.Click();
                }

                DataTable data = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailTemplates", "Enable", "Yes");
                foreach (DataRow dr1 in data.Rows)
                {
                    EmailTemplateNameDropDown.Click();
                    BaseMethods.DdlSelectByText(EmailTemplateNameDropDown, dr1["Name"].ToString());
                    BaseMethods.verifyWebElement(periodDurationTextBox, "periodDurationTextBox is not displayed", "periodDurationTextBox is displayed");
                    periodDurationTextBox.Clear();
                    periodDurationTextBox.SendKeys(dr["PeriodDuration"].ToString());
                    PeriodTypeDropDown.Click();
                    BaseMethods.DdlSelectByText(PeriodTypeDropDown, dr["PeriodType"].ToString());
                    BaseMethods.verifyWebElement(SubmitButton, "SubmitButton is not displayed", "SubmitButton is displayed");
                    SubmitButton.Click();
                    Thread.Sleep(2000);
                    BaseMethods.webelementverify(EperformSuccessMessage);
                }
            }
               

        }
    }
}
