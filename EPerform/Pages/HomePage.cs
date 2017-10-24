using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPerform.Pages
{


    class HomePage
    {
        IWebDriver _driver;


        public HomePage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }


        //Eperform HomeOption
        [FindsBy(How = How.XPath, Using = "//span[text()='Home']")]
        public IWebElement EperformHomeOption { get; set; }


        //Eperform Reviews option

        [FindsBy(How = How.XPath, Using = "//span[text()='Reviews']")]
        public IWebElement EperformReviewsOption { get; set; }

        //Eperform Review Arrow drop down
        [FindsBy(How = How.XPath, Using = "//b[@class='arrow fa fa-caret-down']")]
        public IWebElement EperformReviewsArrowOption { get; set; }


        //Eperform OrganisationStructureArrowOption
        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[2]")]
        public IWebElement EperformOrganisationStructureArrowOption { get; set; }

        //Eperform Competency framework text
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Competency Framework')]")]
        public IWebElement EperformCompetencyFrameworkIcon { get; set; }

        //Eperform Reference Material icon
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Reference Material')]")]
        public IWebElement EperformReferenceMaterialIcon { get; set; }

        //Eperform Reference Material arrow icon

        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[4]")]
        public IWebElement EperformReferenceMaterialArrowIcon { get; set; }



        //Eperform Competency framework arrow icon

        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[3]")]
        public IWebElement EperformCompetencyFrameworkArrowIcon { get; set; }
       


        //Eperform Competencies option

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Competencies')]")]
        public IWebElement eleEperformCompetenciesOption { get; set; }
        public IWebElement EperformCompetenciesOption
        {
            get
            {
                return eleEperformCompetenciesOption;
            }
            set
            {
                eleEperformCompetenciesOption = value;
            }
        }

        // Eperform Competency Levels option

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Competency Levels')]")]
        public IWebElement EperformCompetencyLevelsOption { get; set; }
       

        //Eperform Competency Behaviours option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Competency Behaviours')]")]
        public IWebElement EperformCompetencyBehavioursOption { get; set; }
      

        //Eperform Goals option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Goals')]")]
        public IWebElement EperformGoalsOption { get; set; }
     

        //Eperform Measures option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Measures')]")]
        public IWebElement EperformMeasuresOption { get; set; }
      
        //Eperform Pillars option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Pillars')]")]
        public IWebElement EperformPillarsOption { get; set; }
      
        //Eperform Development Activities option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Development Activities')]")]
        public IWebElement EperformDevelopmentActivitiesOption { get; set; }
       
        //Eperform Documents option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Documents')]")]
        public IWebElement EperformDocumentsOption { get; set; }
       

        //Eperform Welcome text 

        [FindsBy(How = How.XPath, Using = "//div//h3[contains(text(),'Welcome')]")]
        public IWebElement EperformWelcomeText { get; set; }
       

        //Eperform Reviews Icon 
        [FindsBy(How = How.XPath, Using = "//a[text()='Reviews']")]
        public IWebElement EperformReviewsIcon { get; set; }
       

        //
        //Eperform Natural Talent Home text
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Natural Talent Home')]")]
        public IWebElement EperformNaturalTalentHomeText { get; set; }
       

        //Eperform Review Templates icon

        [FindsBy(How = How.XPath, Using = "//a[text()='Review Templates']")]
        public IWebElement EperformReviewTemplatesIcon { get; set; }
       
        //Eperform Workflows icon

        [FindsBy(How = How.XPath, Using = "//a[text()='Workflows']")]
        public IWebElement EperformWorkFlowsIcon { get; set; }
        
        // Eperform Workflows roles icon
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Roles')]")]
        public IWebElement EperformWorkflowRolesIcon { get; set; }
       

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Role Types')]")]
        public IWebElement EperformRoleTypes { get; set; }
       

        //Eperform Organisation Structure
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Organisation Structure')]")]
        public IWebElement EperformOrganisationStructureIcon { get; set; }
       

        //Eperform Organisational Structure Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Organisational Structure')]")]
        public IWebElement EperformOrganisationStructureOption { get; set; }
       

        //Eperform Positions Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Positions')]")]
        public IWebElement EperformPositionsOption { get; set; }
     

        //Eperform Markers Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Markers')]")]
        public IWebElement EperformMarkersOption { get; set; }
        

        // Eperform System Configuration
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'System Configuration')]")]
        public IWebElement EperformSystemConfigurationIcon { get; set; }
       
        //Eperform EperformSystemConfigurationArrow Icon
        [FindsBy(How = How.XPath, Using = "(//b[@class='arrow fa fa-caret-down'])[5]")]
        public IWebElement EperformSystemConfigurationArrowIcon { get; set; }
       
        //Eperform Users option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Users')]")]
        public IWebElement EperformUsersOption { get; set; }
        

        //Eperform EperformPermissionProfiles Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Permission Profiles')]")]
        public IWebElement EperformPermissionProfilesOption { get; set; }
        

        //Eperform EperformMessages Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Messages')]")]
        public IWebElement EperformMessagesOption { get; set; }
       

        //Eperform EperformEmailTemplates Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email Templates')]")]
        public IWebElement EperformEmailTemplatesOption { get; set; }
       

        //Eperform EperformEmailNotifications Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email Notifications')]")]
        public IWebElement EperformEmailNotificationsOption { get; set; }
       

        //Eperform EperformEmailQueue Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Email Queue')]")]
        public IWebElement EperformEmailQueueOption { get; set; }
        

        //Eperform EperformGlobalQuestions Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Global Questions')]")]
        public IWebElement EperformGlobalQuestionsOption { get; set; }
       

        //Eperform EperformFormTemplates Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Form Templates')]")]
        public IWebElement EperformFormTemplatesOption { get; set; }
        

        //Eperform EperformSystemForms Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'System Forms')]")]
        public IWebElement EperformSystemFormsOption { get; set; }
       
        //Eperform EperformCaptions Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Captions')]")]
        public IWebElement EperformCaptionsOption { get; set; }
       

        //Eperform EperformBulkImportandExport Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Bulk Import and Export')]")]
        public IWebElement EperformBulkImportandExportOption { get; set; }
       
        //Eperform EperformSystemSettings Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'System Settings')]")]
        public IWebElement EperformSystemSettingsOption { get; set; }
        

        //Eperform EperformCustomerConfiguration Option 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Customer Configuration')]")]
        public IWebElement EperformCustomerConfiguration { get; set; }
       

        //Eperform System Administrator Icon
        [FindsBy(How = How.XPath, Using = "(//span[@id='user_info'])[1]")]
        public IWebElement EperformSystemAdministratorIcon { get; set; }
       

        // Eperform Employee Portal option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Employee Portal')]")]
        public IWebElement EperformEmployeePortalOption { get; set; }
       

        //Eperform Talent Acquisition Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Talent Acquisition')]")]
        public IWebElement EperformTalentAcquisitionOption { get; set; }
        

        //Eperform Change Password Option
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Change Password')]")]
        public IWebElement EperformChangePasswordOption { get; set; }
       
        //Eperform Help Icon
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Help')]")]
        public IWebElement EperformHelpIcon { get; set; }
    

        //Eperform HelpArrowIcon
        [FindsBy(How = How.XPath, Using = "(//b[@class='fa fa-caret-down'])[2]")]
        public IWebElement EperformHelpArrowIcon { get; set; }
     

        //Eperform Toggle Caption Names Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Toggle Caption Names')]")]
        public IWebElement EperformToggleCationNamesText { get; set; }
       

        //Eperform Automated Testing text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Automated Testing')]")]
        public IWebElement EperformAutomatedTestingText { get; set; }
        

        //Eperform User Community Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'User Community')]")]
        public IWebElement EperformUserCommunityText { get; set; }
       

        //Eperform Contact Administrator Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Contact Administrator')]")]
        public IWebElement EperformContactAdmistratorText { get; set; }
       

        //Eperform Give Feedback Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Give Feedback')]")]
        public IWebElement EperformGiveFeedbackText { get; set; }

        //Eperform Self Help Text
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Self Help')]")]
        public IWebElement EperformSelfHelpText;
      

        //EPerform Build Text
        [FindsBy(How = How.XPath, Using = "//a//b[contains(text(),'Build:')]")]
        public IWebElement EperformBuildText { get; set; }
       

        //EPerform Date Text
        [FindsBy(How = How.XPath, Using = "//a//b[contains(text(),'Date:')]")]
        public IWebElement EperformDateText { get; set; }
       

        //EPerform newPasswordErrorText
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The New Password field is required.')]")]
        public IWebElement EperformNewPasswordErrorText { get; set; }
        

        //EPerform ConfirmnewPasswordErrorText
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Confirm New Password field is required.')]")]
        public IWebElement EperformConfirmNewPasswordErrorText { get; set; }
      


        //Eperform CurrentPasswordErrorText
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Current Password field is required')]")]
        public IWebElement EperformCurrentPasswordErrorText { get; set; }
       

        //Eperform CurrentPassword TextBox
        [FindsBy(How = How.Id, Using = "Dto_CurrentPassword")]
        public IWebElement EperformCurrentPasswordTextBox { get; set; }
       

        //Eperform newPassword TextBox
        [FindsBy(How = How.Id, Using = "Dto_NewPassword")]
        public IWebElement EperformNewPasswordTextBox { get; set; }
        
        //Eperform ConfirmNewPassword textbox
        [FindsBy(How = How.Id, Using = "Dto_ConfirmNewPassword")]
        public IWebElement EperformConfirmNewPassword { get; set; }


        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement EperformErrorMessageText { get; set; }

        //Useable Method for the verify the reviewpage
        public void pageverify(String page)
        {
           
            IWebElement pages = _driver.FindElement(By.XPath("//div//h1[contains(text(),'" + page + "')]"));
            Assert.IsTrue(pages.Displayed, page + "is not displayed ");
            
            ExtentReport.test.Log(LogStatus.Pass, page + "text is displayed in the Reviews page");

        }

       //verify the review option is displayed
       public void reviewOption()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("Home Review page verification");
            DataRow data = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
            BaseMethods.verifyWebElement(EperformWelcomeText, "Welcome Text is not displayed in the home page", "Welcome Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformReviewsOption, "Reviews option is not displayed in the home page", "Reviews option is displayed in the home page");
            EperformReviewsArrowOption.Click();
            BaseMethods.verifyWebElement(EperformReviewsIcon, "Reviews icon is not displayed", "Reviews icon is displayed");
            EperformReviewsIcon.Click();
            pageverify(data["HomeReviewsPage"].ToString());
            EperformReviewsArrowOption.Click();
            BaseMethods.verifyWebElement(EperformReviewTemplatesIcon, "ReviewsTemplates icon is not displayed", "ReviewsTemplates icon is not displayed");
            EperformReviewTemplatesIcon.Click();
            DataRow data1 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            pageverify(data1["HomeReviewsPage"].ToString());
            EperformReviewsArrowOption.Click();
            BaseMethods.verifyWebElement(EperformWorkFlowsIcon, "Workflows icon is not displayed", "Workflows icon is displayed");
            EperformWorkFlowsIcon.Click();
            DataRow data2 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            pageverify(data2["HomeReviewsPage"].ToString());
            EperformReviewsArrowOption.Click();
            BaseMethods.verifyWebElement(EperformWorkflowRolesIcon, "Workflows roles icon is not displayed", "Workflows roles icon is displayed");
            EperformWorkflowRolesIcon.Click();
            DataRow data3 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04").Rows[0];
            pageverify(data3["HomeReviewsPage"].ToString());
            EperformReviewsArrowOption.Click();
            BaseMethods.verifyWebElement(EperformRoleTypes, "Eperform Role Type icon is not displayed", "Eperform Role Type icon is displayed");
            EperformRoleTypes.Click();
            DataRow data4 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05").Rows[0];
            pageverify(data4["HomeReviewsPage"].ToString());
        }

        //verify the OrganisationStructure option
        public void OrganisationStructure()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("Home  Organisation Structure  page verification");
            DataRow data = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
            BaseMethods.verifyWebElement(EperformOrganisationStructureIcon, "Orgranisation Structure Icon is not displayed in the home page", "Orgranisation Structure Icon is displayed in the home page");
             EperformOrganisationStructureArrowOption.Click();
            BaseMethods.verifyWebElement(EperformOrganisationStructureOption, "Orgranisation Structure option is not displayed in the home page", "Orgranisation Structure option is displayed in the home page");
            EperformOrganisationStructureOption.Click();
            pageverify(data["HomeOrganisationStructurepage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            EperformOrganisationStructureArrowOption.Click();
            BaseMethods.verifyWebElement(EperformPositionsOption, "Postions option is not displayed in the home page", "Postions option is displayed in the home page");
            EperformPositionsOption.Click();
            pageverify(data1["HomeOrganisationStructurepage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            EperformOrganisationStructureArrowOption.Click();
            BaseMethods.verifyWebElement(EperformMarkersOption, "Markers option is not displayed in the home page", "Markers option is displayed in the home page");
            EperformMarkersOption.Click();
            pageverify(data2["HomeOrganisationStructurepage"].ToString());
        }
        //verify the Competency Framework
        public void CompetencyFramework()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("Home Competency Framework  page verification");
            DataRow data = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
            BaseMethods.verifyWebElement(EperformCompetencyFrameworkIcon, "Competency Framework Icon is not displayed in the home page", "Competency Framework Icon is displayed in the home page");
            EperformCompetencyFrameworkArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformCompetenciesOption, "Competencies option is not displayed in the home page", "Competencies option is displayed in the home page");
            EperformCompetenciesOption.Click();
            pageverify(data["HomeCompetencyFrameworkPage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            EperformCompetencyFrameworkArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformCompetencyLevelsOption, "Eperform CompetencyLevels is not displayed in the home page", "Eperform CompetencyLevels is displayed in the home page");
            EperformCompetencyLevelsOption.Click();
            pageverify(data1["HomeCompetencyFrameworkPage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            EperformCompetencyFrameworkArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformCompetencyBehavioursOption, "Eperform CompetencyBehaviours Option is not displayed in the home page", "Eperform CompetencyBehaviours Option is displayed in the home page");
            EperformCompetencyBehavioursOption.Click();
            pageverify(data2["HomeCompetencyFrameworkPage"].ToString());
        }
        //verify the refrenceMaterial Page
        public void ReferenceMaterial()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("Home Reference Material  page verification");
            DataRow data = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
            BaseMethods.verifyWebElement(EperformReferenceMaterialIcon, "Eperform ReferenceMaterial Icon is not displayed in the home page", "Eperform ReferenceMaterial Icon is displayed in the home page");
            EperformReferenceMaterialArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformGoalsOption, "Eperform Goals Option is not displayed in the home page", "Eperform Goals Option is displayed in the home page");

            EperformGoalsOption.Click();
            pageverify(data["HomeReferenceMaterialPage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            EperformReferenceMaterialArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformMeasuresOption, "Eperform Measures Option is not displayed in the home page", "Eperform Measures Option is displayed in the home page");

            EperformMeasuresOption.Click();
            pageverify(data1["HomeReferenceMaterialPage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            EperformReferenceMaterialArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformPillarsOption, "Eperform Pillars Option is not displayed in the home page", "Eperform Pillars Option is displayed in the home page");

            EperformPillarsOption.Click();
            pageverify(data2["HomeReferenceMaterialPage"].ToString());
            DataRow data3 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04").Rows[0];

            EperformReferenceMaterialArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformDevelopmentActivitiesOption, "Eperform DevelopmentActivities Option is not displayed in the home page", "Eperform DevelopmentActivities Option is displayed in the home page");
            EperformDevelopmentActivitiesOption.Click();
            pageverify(data3["HomeReferenceMaterialPage"].ToString());
            DataRow data4 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05").Rows[0];
            EperformReferenceMaterialArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformDocumentsOption, "Eperform Documents Option is not displayed in the home page", "Eperform Documents Option is displayed in the home page");

            EperformDocumentsOption.Click();
            pageverify(data4["HomeReferenceMaterialPage"].ToString());
        }
        //verify the SystemConfiguration page
        public void SystemConfiguration()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("Home SystemConfiguration  page verification");
            DataRow data = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_01").Rows[0];
            BaseMethods.verifyWebElement(EperformSystemConfigurationIcon, "Eperform SystemConfiguration Icon  is not displayed in the home page", "Eperform SystemConfiguration Icon  is displayed in the home page");
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformUsersOption, "Eperform Users Option  is not displayed in the home page", "Eperform Users Option is displayed in the home page");
            EperformUsersOption.Click();
            pageverify(data["HomeSystemConfigurationPage"].ToString());
            DataRow data1 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_02").Rows[0];
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformPermissionProfilesOption, "Eperform PermissionProfiles Option  is not displayed in the home page", "Eperform PermissionProfiles Option is displayed in the home page");
            EperformPermissionProfilesOption.Click();
            pageverify(data1["HomeSystemConfigurationPage"].ToString());
            DataRow data2 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_03").Rows[0];
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformMessagesOption, "Eperform Messages Option  is not displayed in the home page", "Eperform Messages Option is displayed in the home page");
            EperformMessagesOption.Click();
            pageverify(data2["HomeSystemConfigurationPage"].ToString());
            DataRow data4 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_04").Rows[0];
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformEmailTemplatesOption, "Eperform Email Templates Option  is not displayed in the home page", "Eperform Email Templates Option is displayed in the home page");
            EperformEmailTemplatesOption.Click();
            pageverify(data4["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformEmailQueueOption, "Eperform Email Queue Option is not displayed in the home page", "Eperform Email Queue Option is displayed in the home page");
            EperformEmailQueueOption.Click();
            DataRow data5 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_05").Rows[0];
            pageverify(data5["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformEmailNotificationsOption, "Eperform EmailNotifications Option is not displayed in the home page", "Eperform EmailNotifications Option is displayed in the home page");
            EperformEmailNotificationsOption.Click();
            DataRow data6 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_06").Rows[0];
            pageverify(data6["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformGlobalQuestionsOption, "Eperform GlobalQuestions Option is not displayed in the home page", "Eperform GlobalQuestions Option is displayed in the home page");
            EperformGlobalQuestionsOption.Click();
            DataRow data7 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_07").Rows[0];
            pageverify(data7["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformFormTemplatesOption, "Eperform FormTemplates Option is not displayed in the home page", "Eperform FormTemplates Option is displayed in the home page");
            EperformFormTemplatesOption.Click();
            DataRow data8 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_08").Rows[0];
            pageverify(data8["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformSystemFormsOption, "Eperform SystemForms Option is not displayed in the home page", "Eperform SystemForms Option is displayed in the home page");
            EperformSystemFormsOption.Click();
            DataRow data9 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_09").Rows[0];
            pageverify(data9["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformCaptionsOption, "Eperform Captions Option is not displayed in the home page", "Eperform Captions Option is displayed in the home page");
            EperformCaptionsOption.Click();
            DataRow data10 = ExcelData.GetData_DataTable("EHome_TESTDATA", "HomePagesVerify", "KeyName", "Homepage_10").Rows[0];
            pageverify(data10["HomeSystemConfigurationPage"].ToString());
            EperformSystemConfigurationArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformBulkImportandExportOption, "Eperform BulkImportandExport Option is not displayed in the home page", "Eperform BulkImportandExport Option is displayed in the home page");
            EperformBulkImportandExportOption.Click();
 
        }

        //verify the EperformSystemAdministrator
        public void EperformSystemAdministrator()
        {
            LoginPage loginpage = new LoginPage(_driver);
            ExtentReport.test = ExtentReport.extent.StartTest("verifySystemAdministratorpage");

            BaseMethods.webelementverify(EperformSystemAdministratorIcon);
            loginpage.EperformSystemAdministratorArrowDropDownIcon.Click();
            BaseMethods.verifyWebElement(EperformEmployeePortalOption, "Eperform EmployeePortal Option is not displayed in the home page", "Eperform EmployeePortal Option is displayed in the home page");
            BaseMethods.verifyWebElement(EperformTalentAcquisitionOption, "Eperform TalentAcquisition Option is not displayed in the home page", "Eperform TalentAcquisition Option is displayed in the home page");
            BaseMethods.verifyWebElement(EperformChangePasswordOption, "Eperform ChangePassword Option is not displayed in the home page", "Eperform ChangePassword Option is displayed in the home page");

        }
        //verify the Help page
        public void help()
        {
            ExtentReport.test = ExtentReport.extent.StartTest("verifyHelppage");
            BaseMethods.verifyWebElement(EperformHelpIcon, "Eperform Help Icon  is not displayed in the home page", "Eperform Help Icon is displayed in the home page");
            EperformHelpArrowIcon.Click();
            BaseMethods.verifyWebElement(EperformToggleCationNamesText, "Eperform ToggleCation Names Text  is not displayed in the home page", "Eperform ToggleCation Names Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformAutomatedTestingText, "Eperform AutomatedTesting Text  is not displayed in the home page", "Eperform AutomatedTesting Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformBuildText, "Eperform Build Text is not displayed in the home page", "Eperform Build Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformDateText, "Eperform Date Text is not displayed in the home page", "Eperform Date Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformUserCommunityText, "Eperform User Community Text is not displayed in the home page", "Eperform User Community Text  is displayed in the home page");
            BaseMethods.verifyWebElement(EperformContactAdmistratorText, "Eperform Contact Admistrator Text  is not displayed in the home page", "Eperform Contact Admistrator Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformGiveFeedbackText, "Eperform Give Feedback Text is not displayed in the home page", "Eperform Give Feedback Text is displayed in the home page");
            BaseMethods.verifyWebElement(EperformSelfHelpText, "Eperform SelfHelp Text is not displayed in the home page", "Eperform SelfHelp Text  is displayed in the home page");
        }

    }
}
