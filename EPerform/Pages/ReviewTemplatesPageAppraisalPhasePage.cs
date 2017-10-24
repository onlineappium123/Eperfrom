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
    class ReviewTemplatesPageAppraisalPhasePage
    {
        IWebDriver _driver;
        string nametext = null;


        public ReviewTemplatesPageAppraisalPhasePage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'New Step')])[2]")]
        public IWebElement AppraisalPhaseNewStepButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Appraisal']")]
        public IWebElement AppraisalOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Development Plan')])[2]")]
        public IWebElement DevelopmentPlanOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Questionnaire')])[2]")]
        public IWebElement QuestionnaireOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@id='Dto_Name'])[2]")]
        public IWebElement GoalNameTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanManagerViewEmployeeAssessment_t")]
        public IWebElement ManagerViewEmployeeRadioYesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanManagerViewEmployeeAssessment_f")]
        public IWebElement MangerViewEmployeeRadioNoButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanEmployeeViewManagerAssessment_t")]
        public IWebElement EmployeeViewManagerYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanEmployeeViewManagerAssessment_f")]
        public IWebElement EmployeeViewManagerNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanAddOverallComment_t")]
        public IWebElement AddOverallCommentYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanAddOverallComment_f")]
        public IWebElement AddOverallCommentNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanSetOverallScore_t")]
        public IWebElement SetOverallScoreYesRadioButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "Dto_CanSetOverallScore_f")]
        public IWebElement SetOverallScoreNoRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_MeasureId")]
        public IWebElement MesaureOverallScoreDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_TaskFlowId")]
        public IWebElement WorkFlowDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_0")]
        public IWebElement RevieweeObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_1")]
        public IWebElement ReviewerObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_2")]
        public IWebElement AgreedObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_DisplayContent_ifr")]
        public IWebElement DisplayContentTextBox { get; set; }

        [FindsBy(How =How.XPath,Using = "(//button[text()='Submit'])[2]")]
        public IWebElement submitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How =How.XPath,Using = "(//a[contains(text(),'Development Plan')])[2]")]
        public IWebElement DevelopmentPlanPhase { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HideAllScores")]
        public IWebElement HideAllScoresCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HideRawScoresOfGoalsAndCompetencies")]
        public IWebElement HideRawScoresOfGoalsCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HideOverallScores")]
        public IWebElement HideOverallScoresCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HideGraphicalScores")]
        public IWebElement HideGraphicalScoresCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HideWeightings")]
        public IWebElement HideWeightingsCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HideFinalScoresOfGoalsAndCompetencies")]
        public IWebElement HideFinalScoresCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HidePdfReport")]
        public IWebElement HidePdfReportCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HidePdfPerformanceDiaryComments")]
        public IWebElement HidePDFPerformanceCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HidePdfSummarySection")]
        public IWebElement HidePDFSummarySectionCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HidePdfGraphicalScores")]
        public IWebElement HidePDFGraphicalScoresCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HidePdfComments")]
        public IWebElement HidePdfGraphicalScoresCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HidePdfOverallScores")]
        public IWebElement HidePdfOverallScoresCheckBox { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Results Summary']")]
        public IWebElement ResultsSummaryOption { get; set; }


        [FindsBy(How = How.Id, Using = "Dto_IsPositionBasedQuestionnaireEnabled_t")]
        public IWebElement YesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsPositionBasedQuestionnaireEnabled_f")]
        public IWebElement NoButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_FormId")]
        public IWebElement QuestionnarieDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_AppraisalMeasureId")]
        public IWebElement MeasureAppraisalId { get; set; }

        [FindsBy(How =How.XPath,Using = "(//a[contains(text(),'Information')])[2]")]
        public IWebElement InformationOption { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_FinalScoreOverride_t")]
        public IWebElement FinalScoreOverrideYesRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_FinalScoreOverride_f")]
        public IWebElement FinalScoreOverrideNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ChoicesLabel")]
        public IWebElement ChoicesLabelTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[text()='Summary'])[2]")]
        public IWebElement SummaryOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='close']")]
        public IWebElement closeButton { get; set; }


        public void TxtLabel(string value)
        {
            _driver.SwitchTo().Frame(DisplayContentTextBox);

            IWebElement body = _driver.FindElement(By.CssSelector("body"));
            body.SendKeys(value);
            _driver.SwitchTo().ParentFrame();
        }

        public void createAppraisal()
        {
           
            DataRow data = ExcelData.GetData_DataTable("EP_AppraisalPhase", "Appraisal", "KeyName", "Appraisal_01").Rows[0];
           
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", AppraisalPhaseNewStepButton);
            AppraisalOption.Click();
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            TxtLabel(data["Display Content"].ToString());
            if (data["Managerviewemployeeassessment"].ToString() == "Yes")
            {
                ManagerViewEmployeeRadioYesButton.Click();
            }
            else
            {
                MangerViewEmployeeRadioNoButton.Click();
            }
            if (data["Employeeviewmanagerassessment"].ToString() == "Yes")
            {
                EmployeeViewManagerYesRadioButton.Click();
            }
            else
            {
                EmployeeViewManagerNoRadioButton.Click();
            }
            if (data["Canaddoverallcomment"].ToString() == "Yes")
            {
                AddOverallCommentYesRadioButton.Click();
            }
            else
            {
                AddOverallCommentNoRadioButton.Click();
            }
            if (data["Cansetoverallscore"].ToString() == "Yes")
            {
                SetOverallScoreYesRadioButton.Click();
            }
            else
            {
                SetOverallScoreNoRadioButton.Click();
            }
            MesaureOverallScoreDropDown.Click();
            BaseMethods.DdlSelectByText(MesaureOverallScoreDropDown, data["Measureforoverallscore"].ToString());
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
        }

        public void createDevelopmentPhase()
        {

            DataRow data = ExcelData.GetData_DataTable("EP_AppraisalPhase", "DevelopmentPlan", "KeyName", "DevelopmentPlan_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", AppraisalPhaseNewStepButton);
            DevelopmentPlanOption.Click();
            Thread.Sleep(5000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            TxtLabel(data["DisplayContent"].ToString());
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
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", AppraisalPhaseNewStepButton);
            QuestionnaireOption.Click();
            Thread.Sleep(5000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            TxtLabel(data["DisplayContent"].ToString());
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
                closeButton.Click();
            }
            catch
            {

            }

        }

        public void ResultsSummary()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_AppraisalPhase", "ResultsSummary", "KeyName", "ResultsSummary_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", AppraisalPhaseNewStepButton);
            ResultsSummaryOption.Click();
            Thread.Sleep(5000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            TxtLabel(data["DisplayContent"].ToString());
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
            DataTable dt = ExcelData.GetData_DataTable("EP_AppraisalPhase", "ResultsSummaryCheckBox", "Enable", "Yes");
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["DisplayOptions"].ToString() == "Hide All Scores")
                {
                    HideAllScoresCheckBox.Click();
                }
                else if (dr["DisplayOptions"].ToString() == "Hide Raw Scores of Goals and Competencies")
                {
                    HideRawScoresOfGoalsCheckBox.Click();
                }
                else if (dr["DisplayOptions"].ToString() == "Hide Overall Scores")
                {
                    HideOverallScoresCheckBox.Click();
                }
                else if (dr["DisplayOptions"].ToString() == "Hide Graphical Scores")
                {
                    HideGraphicalScoresCheckBox.Click();
                }
                else if (dr["DisplayOptions"].ToString() == "Hide Weightings")
                {
                    HideWeightingsCheckBox.Click();
                }
                else if (dr["DisplayOptions"].ToString() == "Hide Adjusted Scores Of Goals And Competencies")
                {
                    HideFinalScoresCheckBox.Click();
                }
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

        public void createInformation()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Information", "KeyName", "Information_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", AppraisalPhaseNewStepButton);
            Thread.Sleep(2000);
            InformationOption.Click();
            Thread.Sleep(5000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            TxtLabel(data["DisplayContent"].ToString());
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
        public void Summary()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_AppraisalPhase", "Summary", "KeyName", "Summary_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", AppraisalPhaseNewStepButton);

            IJavaScriptExecutor exe = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", SummaryOption);
            Thread.Sleep(5000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            TxtLabel(data["DisplayContent"].ToString());
            WorkFlowDropDown.Click();
            BaseMethods.DdlSelectByText(WorkFlowDropDown, data["Workflow"].ToString());
            //MeasureAppraisalId.Click();
            //BaseMethods.DdlSelectByText(MeasureAppraisalId, data["Measureforappraisal"].ToString());
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
            if (data["Supportfinalscoreoverride"].ToString() == "Yes")
            {
                FinalScoreOverrideYesRadioButton.Click();
            }
            else
            {
                FinalScoreOverrideNoRadioButton.Click();
            }
            ChoicesLabelTextBox.SendKeys(data["Choices Label"].ToString());
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






    }


}
