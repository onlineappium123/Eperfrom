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
    class ReviewDevelopmentPhasePage
    {
        public IWebDriver driver;
        string nametext;
        public ReviewDevelopmentPhasePage(IWebDriver pDriver)
        {
            driver = pDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'New Step')])[3]")]
        public IWebElement DevelopmentPhaseNewStepButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Development Plan')])[3]")]
        public IWebElement DevelopmentPlanOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Questionnaire')])[3]")]
        public IWebElement QuestionnaireOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Information')])[3]")]
        public IWebElement InformationOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@id='Dto_Name'])[2]")]
        public IWebElement GoalNameTxtBox { get; set; }


        [FindsBy(How = How.Id, Using = "Dto_DisplayContent_ifr")]
        public IWebElement DisplayContentTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_TaskFlowId")]
        public IWebElement WorkFlowDropDown { get; set; }


        [FindsBy(How = How.Id, Using = "Dto_RoleIds_0")]
        public IWebElement RevieweeObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_1")]
        public IWebElement ReviewerObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_2")]
        public IWebElement AgreedObserverCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Submit'])[2]")]
        public IWebElement submitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='close']")]
        public IWebElement closeButton { get; set; }


        [FindsBy(How = How.Id, Using = "Dto_IsPositionBasedQuestionnaireEnabled_t")]
        public IWebElement YesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsPositionBasedQuestionnaireEnabled_f")]
        public IWebElement NoButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_FormId")]
        public IWebElement QuestionnarieDropDown { get; set; }

        public void DisplayTxtLabel(string value)
        {
            driver.SwitchTo().Frame(DisplayContentTextBox);

            IWebElement body = driver.FindElement(By.CssSelector("body"));
            body.SendKeys(value);
            driver.SwitchTo().ParentFrame();
        }


        public void createInformation()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Information", "KeyName", "Information_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", DevelopmentPhaseNewStepButton);
            InformationOption.Click();
            Thread.Sleep(2000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            DisplayTxtLabel(data["DisplayContent"].ToString());
            WorkFlowDropDown.Click();
            BaseMethods.DdlSelectByText(WorkFlowDropDown, data["Workflow"].ToString());
            if (data["Observer"].ToString() == "Reviewee")
            {
                RevieweeObserverCheckBox.Click();
            }
            else if (data["Observer"].ToString() == "Reviewer")
            {
                ReviewerObserverCheckBox.Click();
            }
            else if (data["Observer"].ToString() == "Agreed")
            {
                AgreedObserverCheckBox.Click();
            }
            submitButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            try
            {
                closeButton.Click();
            }
            catch
            {

            }

        }

        public void createDevelopmentPhase()
        {

            DataRow data = ExcelData.GetData_DataTable("EP_AppraisalPhase", "DevelopmentPlan", "KeyName", "DevelopmentPlan_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", DevelopmentPhaseNewStepButton);
            DevelopmentPlanOption.Click();
            Thread.Sleep(2000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            DisplayTxtLabel(data["DisplayContent"].ToString());
            WorkFlowDropDown.Click();
            BaseMethods.DdlSelectByText(WorkFlowDropDown, data["Workflow"].ToString());
            if (data["Observer"].ToString() == "Reviewee")
            {
                RevieweeObserverCheckBox.Click();
            }
            else if (data["Observer"].ToString() == "Reviewer")
            {
                ReviewerObserverCheckBox.Click();
            }
            else if (data["Observer"].ToString() == "Agreed")
            {
                AgreedObserverCheckBox.Click();
            }
            submitButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            try
            {
                closeButton.Click();
            }
            catch
            {

            }
        }

        public void createQuestionnairePhase()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Questionnaire", "KeyName", "Questionnaire _01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", DevelopmentPhaseNewStepButton);
            QuestionnaireOption.Click();
            Thread.Sleep(2000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            DisplayTxtLabel(data["DisplayContent"].ToString());
            WorkFlowDropDown.Click();
            BaseMethods.DdlSelectByText(WorkFlowDropDown, data["Workflow"].ToString());
            if (data["Observer"].ToString() == "Reviewee")
            {
                RevieweeObserverCheckBox.Click();
            }
            else if (data["Observer"].ToString() == "Reviewer")
            {
                ReviewerObserverCheckBox.Click();
            }
            else if (data["Observer"].ToString() == "Agreed")
            {
                AgreedObserverCheckBox.Click();
            }
            if (data["Questionnaireifavailable"].ToString() == "Yes")
            {
                YesButton.Click();
            }
            else
            {
                NoButton.Click();
            }
            QuestionnarieDropDown.Click();
            DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "KeyName", "FormType1").Rows[0];
            BaseMethods.DdlSelectByText(QuestionnarieDropDown, dr["Form Type"].ToString());
            submitButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            try
            {

            }
            catch
            {

            }

        }
    }
}
