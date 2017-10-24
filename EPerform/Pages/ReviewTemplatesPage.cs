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
    class ReviewTemplatesPage
    {

        IWebDriver _driver;
        string nametext = null;


        public ReviewTemplatesPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Add Review Template')]")]
        public IWebElement AddReviewTemplateButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement ReviewTemplateNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }


        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement ActiveYesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement ActiveNoButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ReviewTypeId")]
        public IWebElement ReviewTemplateTypeDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_DisplayWeightingSummary_t")]
        public IWebElement DisplayWeightingSummaryYesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_DisplayWeightingSummary_f")]
        public IWebElement DisplayWeightingSummaryNoButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_EmployeeCanNominateManager_t")]
        public IWebElement NominateManagerforReviewYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_EmployeeCanNominateManager_f")]
        public IWebElement NominateManagerforReviewNoRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How =How.XPath,Using = "(//button[@type='submit'])[2]")]
        public IWebElement SubmitNotificationButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsBandingEnabled")]
        public IWebElement UseBandingCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Configure Banding')]")]
        public IWebElement ConfigureBandingButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_NumberOfBands")]
        public IWebElement NumberOfBandsTextBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[text()='Update']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ReviewBands_0__Name")]
        public IWebElement BrandNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ReviewBands_0__Description")]
        public IWebElement BrandDescriptionTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ReviewBands_0__AdditionalCriteriaId")]
        public IWebElement AdditionalCriteriaDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement BandingCancelButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ScoringType_0")]
        public IWebElement ScoringMethodSumRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ScoringType_1")]
        public IWebElement ScoringMethodAveragesRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='New Notification']")]
        public IWebElement NewNotificationButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Email']")]
        public IWebElement EmailOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Popup']")]
        public IWebElement PopupOption { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_NotificationTriggerTypeId")]
        public IWebElement TriggerDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_EmailTemplateId")]
        public IWebElement EmailTemPlateDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SelectedRecipientReviewRoleIds_0")]
        public IWebElement RevieweeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SelectedRecipientReviewRoleIds_1")]
        public IWebElement ReviewerCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SelectedRecipientReviewRoleIds_2")]
        public IWebElement AgreedCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SelectedTriggerByReviewRoleIds_0")]
        public IWebElement ByRevieweeCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SelectedTriggerByReviewRoleIds_1")]
        public IWebElement ByReviewerCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_SelectedTriggerByReviewRoleIds_2")]
        public IWebElement ByAgreedCheckBox { get; set; }

        //tbody//td[contains(text(),'Appraisal Phase Completed')]/..//td/a[contains(text(),'Edit')]

        [FindsBy(How = How.XPath, Using = "//a[text()=' New Role']")]
        public IWebElement NewRoleButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleId")]
        public IWebElement RoleDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsObserver_t")]
        public IWebElement ObserverYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsObserver_f")]
        public IWebElement ObserverNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PdfReportConfigFileDisplayDto_0__PdfReportDisplayControl")]
        public IWebElement UserReviewSummaryDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "//ul[@class='select2-choices']")]
        public IWebElement ReStartPhasesSelect { get; set; }

        //div[contains(text(),'Goal Setting')]
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'New Step')])[1]")]
        public IWebElement NewStepButton { get; set; }

        //div[contains(text(),'Goal Setting')]
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'New Step')])[2]")]
        public IWebElement AppraisalPhaseNewStepButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Development Plan')]")]
        public IWebElement DevelopmentPlanOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Goal Setting')]")]
        public IWebElement GoalSettingOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Questionnaire')]")]
        public IWebElement QuestionnaireOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Information')]")]
        public IWebElement InformationOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Competency')])[3]")]
        public IWebElement CompetencyOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[text()='Summary'])[1]")]
        public IWebElement SummaryOption { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement NameTextBox { get; set; }

        [FindsBy(How=How.XPath,Using = "(//input[@id='Dto_Name'])[2]")]
        public IWebElement GoalNameTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_TaskFlowId")]
        public IWebElement WorkFlowDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_0")]
        public IWebElement RevieweeObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_1")]
        public IWebElement ReviewerObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleIds_2")]
        public IWebElement AgreedObserverCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PrepopulateBelowTargetAppraisalItems_t")]
        public IWebElement PrepopulateFailedGoalYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PrepopulateBelowTargetAppraisalItems_f")]
        public IWebElement PrepopulateFailedGoalNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PrepopulateFromPositionGoals_t")]
        public IWebElement PopulatePositionGoalsYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PrepopulateFromPositionGoals_f")]
        public IWebElement PopulatePositionGoalsNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanAddGoalsOnEmployeePortal_t")]
        public IWebElement GoalsAddedUserYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanAddGoalsOnEmployeePortal_f")]
        public IWebElement GoalsAddedUserNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanEditLibraryGoals_t")]
        public IWebElement EditGoalsYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CanEditLibraryGoals_f")]
        public IWebElement EditGoalsNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MaxGoalsThatCanBeAdded")]
        public IWebElement GoalLimitTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MinGoalsThatCanBeAdded")]
        public IWebElement MinimumGoalLimitTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsGoalWeightingEnabled_t")]
        public IWebElement GoalWeightingYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsGoalWeightingEnabled_f")]
        public IWebElement GoalWeightingNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_AllowUnratedGoals_t")]
        public IWebElement NonRatedGoalYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_AllowUnratedGoals_f")]
        public IWebElement NonRatedGoalNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_AllowOverridePerformanceBenchmark_t")]
        public IWebElement AllowOverridePerformanceYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_AllowOverridePerformanceBenchmark_f")]
        public IWebElement AllowOverridePerformanceNoRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),' Error!')]")]
        public IWebElement ErrorMessage { get; set; }

     

        [FindsBy(How =How.Id,Using = "Dto_UserInformationOnReview_0")]
        public IWebElement informationReviewAtTimeReviewStart { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_UserInformationOnReview_1")]
        public IWebElement informationReviewAlwaysCurrent { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ReviewBands_0__EndRange")]
        public IWebElement ReviewBandsTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_CanManagerViewEmployeeAssessment_t")]
        public IWebElement ManagerViewEmployeeRadioYesButton { get; set; }

       

       
        [FindsBy(How =How.Id,Using = "Dto_CloseOffset")]
        public IWebElement PriorCloseTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_CloseOffsetTimePeriodTypeId")]
        public IWebElement DaysDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_Message_ifr")]
        public IWebElement MessageContent { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_DisplayContent_ifr")]
        public IWebElement DisplayContentTextBox { get; set; }

        [FindsBy(How =How.XPath,Using = "(//button[text()='Submit'])[2]")]
        public IWebElement GoalSubmitPhase { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[@class='close']")]
        public IWebElement closeButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_IsPositionBasedQuestionnaireEnabled_t")]
        public IWebElement YesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsPositionBasedQuestionnaireEnabled_f")]
        public IWebElement NoButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_FormId")]
        public IWebElement QuestionnarieDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_AppraisalMeasureId")]
        public IWebElement MeasureAppraisalId { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_ChoicesLabel")]
        public IWebElement ChoicesLabelTextBox { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[@class='close']")]
        public IWebElement CloseButton { get; set; }

        public void createReviewTemplate()
        {

            HomePage home = new HomePage(_driver);
            ReviewTemplatesPageAppraisalPhasePage ReviewAppraisalPhase = new ReviewTemplatesPageAppraisalPhasePage(_driver);
            ReviewDevelopmentPhasePage reviewDevelopmentPhasePage = new ReviewDevelopmentPhasePage(_driver);
            ReviewsPage reviewpage = new ReviewsPage(_driver);
            home.EperformReviewsArrowOption.Click();    
            home.EperformReviewTemplatesIcon.Click();
            BaseMethods.webelementverify(AddReviewTemplateButton);
            AddReviewTemplateButton.Click();
            BaseMethods.webelementverify(SubmitButton);
            SubmitButton.Click();
            BaseMethods.webelementverify(ErrorMessage);
            Thread.Sleep(2000);
            DataTable dt = ExcelData.GetData_DataTable("EP_ReviewTemplate", "ReviewTemplate", "Enable", "Yes");
            foreach (DataRow data in dt.Rows)
            {

                // DataRow data = ExcelData.GetData_DataTable("EP_ReviewTemplate", "ReviewTemplate", "KeyName", "ReviewTemplate_01").Rows[0];
                home.EperformReviewsArrowOption.Click();
                home.EperformReviewTemplatesIcon.Click();
                AddReviewTemplateButton.Click();
                nametext = data["Name"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                BaseMethods.verifyWebElement(ReviewTemplateNameTextBox, "ReviewTemplateNameTextBox is not displayed", "ReviewTemplateNameTextBox is displayed");
                ReviewTemplateNameTextBox.SendKeys(nametext);
                if (data["Active"].ToString() == "Yes")
                {
                    BaseMethods.verifyWebElement(ActiveYesButton, "Active Yes Button is not displayed", "Active Yes Button is displayed");
                    ActiveYesButton.Click();
                }
                else
                {
                    BaseMethods.verifyWebElement(ActiveNoButton, "Active No Button is not displayed", "Active No Button is displayed");

                    ActiveNoButton.Click();
                }
                BaseMethods.verifyWebElement(ReviewTemplateTypeDropDown,"ReviewTemplateTypeDropDown List is not displayed", "ReviewTemplateTypeDropDown List is displayed");
                ReviewTemplateTypeDropDown.Click();

                BaseMethods.DdlSelectByText(ReviewTemplateTypeDropDown, data["Type"].ToString());
                if (data["DisplayWeightingSummary"].ToString() == "Yes")
                {
                    BaseMethods.verifyWebElement(DisplayWeightingSummaryYesButton,"DisplayWeightingSummaryYesButton is not displayed", "DisplayWeightingSummaryYesButton is displayed");
                    DisplayWeightingSummaryYesButton.Click();
                }
                else
                {
                    BaseMethods.verifyWebElement(DisplayWeightingSummaryNoButton, "DisplayWeightingSummaryNoButton is Not displayed", "DisplayWeightingSummaryNoButton is displayed");
                    DisplayWeightingSummaryYesButton.Click();
                }
                if (data["ScoringMethod"].ToString() == "Sum")
                {
                    BaseMethods.verifyWebElement(ScoringMethodSumRadioButton,"Sum Radio Button is not displayed", "Sum Radio Button is displayed");
                    ScoringMethodSumRadioButton.Click();
                }
                else
                {
                    BaseMethods.verifyWebElement(ScoringMethodAveragesRadioButton,"Averages Radio Button is not displayed","Averages Radio Button is displayed");
                    ScoringMethodAveragesRadioButton.Click();
                }
                BaseMethods.webelementverify(SubmitButton);
                SubmitButton.Click();
                BaseMethods.webelementverify(EperformSuccessMessage);
                Thread.Sleep(3000);
                BaseMethods.verifyWebElement(UseBandingCheckBox,"UseBandingCheckBox is not displayed", "UseBandingCheckBox is displayed");
                UseBandingCheckBox.Click();
                Thread.Sleep(3000);
                BaseMethods.verifyWebElement(ConfigureBandingButton,"ConfigureBanding Button is not displayed","ConfigureBanding Button is displayed");
                ConfigureBandingButton.Click();
                BaseMethods.verifyWebElement(NumberOfBandsTextBox,"NumberOfBands TextBox is not displayed","NumberIfBands TextBox is displayed");
                NumberOfBandsTextBox.Clear();

                NumberOfBandsTextBox.SendKeys(data["NumberofBands"].ToString());
                BaseMethods.verifyWebElement(UpdateButton,"Update Button is not displayed","Update Button is displayed");
                UpdateButton.Click();
                Thread.Sleep(3000);
                int count = Convert.ToInt32(data["NumberofBands"]);
                for (int i = 0; i < count; i++)
                {
                    int j = 20 + i;
                    string nametext = j.ToString();
                    string Brandnameid = "Dto.ReviewBands[" + i + "].Name";
                    BaseMethods.verifyWebElement(_driver.FindElement(By.Name(Brandnameid)), "BrandNameId is not displayed", "BrandNameId is displayed");
                    _driver.FindElement(By.Name(Brandnameid)).SendKeys(data["BandName"].ToString());
                    string brandDesName = "Dto.ReviewBands[" + i + "].Description";
                    _driver.FindElement(By.Name(brandDesName)).SendKeys(data["BandDescription"].ToString());
                    string name = "Dto.ReviewBands[" + i + "].AdditionalCriteriaId";
                    _driver.FindElement(By.Name(name)).Click();
                    BaseMethods.DdlSelectByText(_driver.FindElement(By.Name(name)), data["AdditionalCriteria"].ToString());
                    string reviewTextBox = "Dto.ReviewBands[" + i + "].EndRange";

                    //ReviewBandsTextBox.Clear();
                    //_driver.FindElement(By.Name(reviewTextBox)).SendKeys(nametext);
                    string valuename = "Dto.ReviewBands[" + i + "].AdditionalCriteriaValue";
                    _driver.FindElement(By.Name(valuename)).SendKeys(data["Value"].ToString());
                }
                BaseMethods.verifyWebElement(ReviewBandsTextBox,"ReviewBandsTextBox is not  displayed","ReviewBandsTetxBox is displayed");
                ReviewBandsTextBox.SendKeys(data["BandValue"].ToString());
                BaseMethods.verifyWebElement(SaveButton,"SaveButton is not displayed","");
                SaveButton.Click();
                Thread.Sleep(3000);
                //CancelButton.Click();
               
                CloseButton.Click();
                Thread.Sleep(2000);
                if (data["UserInformationOnReview"].ToString() == "At Time Review Starts")
                {
                    BaseMethods.verifyWebElement(informationReviewAtTimeReviewStart,"InformationReviewAtTimeReviewStart icon is not displayed", "InformationReviewAtTimeReviewStart Icon is  displayed");
                    informationReviewAtTimeReviewStart.Click();
                }
                else
                {
                    BaseMethods.verifyWebElement(informationReviewAlwaysCurrent, "InformationReviewAlwaysCurrent Icon is not displayed", "InformationReviewAlwaysCurrent Icon is displayed");
                    informationReviewAlwaysCurrent.Click();
                }
                try
                {
                    role();
                    createEmailTemplate();
                    createPopupNotofication();
                    createDevelopmentPhase();
                    createGoalSetting();
                    createQuestionnaireSetting();
                    createInformation();
                    createCompetency();
                    Summary();
                    ReviewAppraisalPhase.createAppraisal();
                    ReviewAppraisalPhase.createDevelopmentPhase();
                    ReviewAppraisalPhase.createQuestionnairePhase();
                    ReviewAppraisalPhase.ResultsSummary();
                    ReviewAppraisalPhase.createInformation();
                    ReviewAppraisalPhase.Summary();
                    reviewDevelopmentPhasePage.createDevelopmentPhase();
                    reviewDevelopmentPhasePage.createQuestionnairePhase();
                    reviewDevelopmentPhasePage.createInformation();
                    SubmitButton.Click();
                    reviewpage.createreview(nametext);
                }
                catch
                {
                    try
                    {
                        closeButton.Click();
                    }
                    catch 
                    {


                        reviewpage.createreview(nametext);
                    }
                }
            }
           
        }
        //Create the Email Template
        public void createEmailTemplate()
        {
            
            DataTable dr = ExcelData.GetData_DataTable("EP_ReviewTemplate", "EmailNotification", "Enable", "Yes");

            foreach (DataRow data in dr.Rows)
            {

                Thread.Sleep(2000);
                BaseMethods.verifyWebElement(NewNotificationButton,"NeW","");
                IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
                ex.ExecuteScript("arguments[0].click();", NewNotificationButton);
             
                EmailOption.Click();
                Thread.Sleep(2000);
                TriggerDropDown.Click();
                if (data["Trigger"].ToString() == "Appraisal Phase Opens")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());

                }
                else if (data["Trigger"].ToString() == "Appraisal Phase Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                }
                else if (data["Trigger"].ToString() == "Appraisal Phase Not Complete")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    PriorCloseTextBox.SendKeys(data["Prior"].ToString());
                    DaysDropDown.Click();
                    BaseMethods.DdlSelectByValue(DaysDropDown, data["Days"].ToString());

                }
                else if (data["Trigger"].ToString() == "Development Phase Opens")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());

                }
                else if (data["Trigger"].ToString() == "Development Phase Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                }
                else if (data["Trigger"].ToString() == "Development Phase Not Complete")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    PriorCloseTextBox.SendKeys(data["Prior"].ToString());
                    DaysDropDown.Click();
                    BaseMethods.DdlSelectByValue(DaysDropDown, data["Days"].ToString());

                }
                else if (data["Trigger"].ToString() == "Employee Nominates Manager")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());

                }
                else if (data["Trigger"].ToString() == "Goal Setting Phase Opens")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());

                }
                else if (data["Trigger"].ToString() == "Goal Setting Phase Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                }
                else if (data["Trigger"].ToString() == "Goal Setting Phase Not Complete")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    PriorCloseTextBox.SendKeys(data["Prior"].ToString());
                    DaysDropDown.Click();
                    BaseMethods.DdlSelectByValue(DaysDropDown, data["Days"].ToString());

                }
                else if (data["Trigger"].ToString() == "Review Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                }
                else if (data["Trigger"].ToString() == "Review Not Complete")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    PriorCloseTextBox.SendKeys(data["Prior"].ToString());
                    DaysDropDown.Click();
                    BaseMethods.DdlSelectByValue(DaysDropDown, data["Days"].ToString());

                }

                DataTable drow = ExcelData.GetData_DataTable("EP_SystemConfigurationTest", "EmailTemplates", "Enable", "Yes");
                foreach (DataRow dt in drow.Rows)
                {
                    EmailTemPlateDropDown.Click();
                    BaseMethods.DdlSelectByText(EmailTemPlateDropDown, dt["Name"].ToString());
                    if (data["Recipient"].ToString() == "Reviewee,Reviewer")
                    {
                        RevieweeCheckBox.Click();
                        ReviewerCheckBox.Click();
                    }
                    else if (data["Recipient"].ToString() == "Reviewee")
                    {
                        RevieweeCheckBox.Click();
                    }
                    else if (data["Recipient"].ToString() == "Reviewer")
                    {
                        ReviewerCheckBox.Click();
                    }
                    Thread.Sleep(2000);
                    SubmitNotificationButton.Click();
                    BaseMethods.webelementverify(EperformSuccessMessage);
                    Thread.Sleep(2000);
                }
            }

        }
        public void TxtLabel(string value)
        {
            _driver.SwitchTo().Frame(MessageContent);
            
            IWebElement body = _driver.FindElement(By.CssSelector("body"));
            body.SendKeys(value);
            _driver.SwitchTo().ParentFrame();
        }

        public void DisplayTxtLabel(string value)
        {
            _driver.SwitchTo().Frame(DisplayContentTextBox);

            IWebElement body = _driver.FindElement(By.CssSelector("body"));
            body.SendKeys(value);
            _driver.SwitchTo().ParentFrame();
        }

        public void createPopupNotofication()
        {
            DataTable dr = ExcelData.GetData_DataTable("EP_ReviewTemplate", "PopupNotofication", "Enable", "Yes");

            foreach (DataRow data in dr.Rows)
            {

                Thread.Sleep(2000);
                IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
                ex.ExecuteScript("arguments[0].click();", NewNotificationButton);
                PopupOption.Click();
                TriggerDropDown.Click();
                if (data["Trigger"].ToString() == "Appraisal Phase Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    TxtLabel(data["Message"].ToString());

                }
                else if (data["Trigger"].ToString() == "Development Phase Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    TxtLabel(data["Message"].ToString());
                }
                else if (data["Trigger"].ToString() == "Goal Setting Phase Completed")
                {
                    BaseMethods.DdlSelectByText(TriggerDropDown, data["Trigger"].ToString());
                    ByRevieweeCheckBox.Click();
                    ByReviewerCheckBox.Click();
                    TxtLabel(data["Message"].ToString());
                }
                Thread.Sleep(2000);
                SubmitNotificationButton.Click();
            }
        }
        public void createDevelopmentPhase()
        {

            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "DevelopmentPlan", "KeyName", "DevelopmentPlan_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", NewStepButton);
            DevelopmentPlanOption.Click();
            Thread.Sleep(1000);
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
            else if(data["Observer"].ToString() == "Agreed")
            {
                AgreedObserverCheckBox.Click();
            }
            GoalSubmitPhase.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            closeButton.Click();
        }

        public void createGoalSetting()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "GoalSetting", "KeyName", "GoalSetting_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", NewStepButton);
            GoalSettingOption.Click();
            Thread.Sleep(5000);
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
            if (data["AutoPopulatePositionGoals"].ToString() == "Yes")
            {
                PopulatePositionGoalsYesRadioButton.Click();
            }
            else
            {
                PopulatePositionGoalsNoRadioButton.Click();
            }
            if (data["Goalscanbeaddedbyuser"].ToString() == "Yes")
            {
                GoalsAddedUserYesRadioButton.Click();
            }
            else
            {
                GoalsAddedUserNoRadioButton.Click();
            }
            if (data["CanEditLibraryGoals"].ToString() == "Yes")
            {
                EditGoalsYesRadioButton.Click();
            }
            else
            {
                EditGoalsNoRadioButton.Click();
            }
            GoalNameTxtBox.SendKeys(data["GoalLimit"].ToString());
            MinimumGoalLimitTextBox.SendKeys(data["MinimumGoalLimit"].ToString());
            if (data["GoalsRequireWeighting"].ToString() == "Yes")
            {
                GoalWeightingYesRadioButton.Click();
            }
            else
            {
                GoalWeightingNoRadioButton.Click();
            }
            if (data["Cancreatenonratedgoals"].ToString() == "Yes")
            {
                NonRatedGoalYesRadioButton.Click();
            }
            else
            {
                NonRatedGoalNoRadioButton.Click();
            }
            if (data["AllowOverridePerformanceBenchmark"].ToString() == "Yes")
            {
                AllowOverridePerformanceYesRadioButton.Click();
            }
            else
            {
                AllowOverridePerformanceNoRadioButton.Click();
            }
            SubmitNotificationButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            closeButton.Click();
        }

        public void createQuestionnaireSetting()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Questionnaire", "KeyName", "Questionnaire _01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", NewStepButton);
            QuestionnaireOption.Click();
            Thread.Sleep(6000);
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
            SubmitNotificationButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
           closeButton.Click();
            
           
        }

        public void createInformation()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Information", "KeyName", "Information_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", NewStepButton);
            InformationOption.Click();
            Thread.Sleep(6000);
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
            SubmitNotificationButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            closeButton.Click();
        }

        public void createCompetency()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Competency", "KeyName", "Competency_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", NewStepButton);
            Thread.Sleep(2000);
            CompetencyOption.Click();
            Thread.Sleep(6000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            DisplayTxtLabel(data["DisplayContent"].ToString());
            WorkFlowDropDown.Click();
            BaseMethods.DdlSelectByText(WorkFlowDropDown, data["Workflow"].ToString());
            MeasureAppraisalId.Click();
            BaseMethods.DdlSelectByText(MeasureAppraisalId, data["Measureforappraisal"].ToString());
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
            SubmitNotificationButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
           
        }

        public void Summary()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewGoalSetting", "Summary", "KeyName", "Summary_01").Rows[0];
            Thread.Sleep(2000);
            IJavaScriptExecutor ex = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", NewStepButton);
            
            IJavaScriptExecutor exe = (IJavaScriptExecutor)_driver;
            ex.ExecuteScript("arguments[0].click();", SummaryOption);

            Thread.Sleep(6000);
            GoalNameTxtBox.SendKeys(data["Name"].ToString());
            DisplayTxtLabel(data["DisplayContent"].ToString());
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
            ChoicesLabelTextBox.SendKeys(data["Choices Label"].ToString());
            SubmitNotificationButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            closeButton.Click();
        }

        public void role()
        {
            DataRow data = ExcelData.GetData_DataTable("EP_ReviewTemplate", "Role", "KeyName", "Role_01").Rows[0];
            BaseMethods.verifyWebElement(NewRoleButton,"NewRole button is not displayed","NewRole Button is displayed");
            IJavaScriptExecutor exe = (IJavaScriptExecutor)_driver;
            exe.ExecuteScript("arguments[0].click();", NewRoleButton);
            BaseMethods.verifyWebElement(RoleDropDown,"RoleDropDown list is not displayed","RoleDropDown List is displayed");
            RoleDropDown.Click();
            Thread.Sleep(2000);
            // DataRow dr = ExcelData.GetData_DataTable("EP_Reviews", "Roles", "KeyName", "Roles_01").Rows[0];
            BaseMethods.DdlSelectByText(RoleDropDown,data["Name"].ToString());
            if (data["Observer"].ToString() == "Yes")
            {
                BaseMethods.verifyWebElement(ObserverYesRadioButton, "ObserverYes Radio Button is not displayed", "ObserverYes Radio Button is displayed");
                ObserverYesRadioButton.Click();
            }
            else
            {
                BaseMethods.verifyWebElement(ObserverNoRadioButton, "ObserverNo Radio Button is not displayed", "ObserverNo Radio Button is displayed");
                ObserverNoRadioButton.Click();
            }
            BaseMethods.verifyWebElement(UserReviewSummaryDropDown,"UserReviewSummaryDropDown list is not displayed", "UserReviewSummaryDropDown list is displayed");
            UserReviewSummaryDropDown.Click();
            BaseMethods.DdlSelectByText(UserReviewSummaryDropDown, data["User Review Summary"].ToString());
            BaseMethods.verifyWebElement(GoalSubmitPhase,"GoalSubmitPhase is not displayed","GoalSubmitPhase is displayed");
            GoalSubmitPhase.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
        }

    }

}
