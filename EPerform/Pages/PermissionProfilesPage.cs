using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;
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
    public class PermissionProfilesPage
    {
        IWebDriver _driver;


        public PermissionProfilesPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }
        #region  WebElement Organisation Structure

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Add New Profile')]")]
        public IWebElement AddNewProfileButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement ProfileNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ProfilePermissionDtos_0__AccessTypeId")]
        public IWebElement EperformOrganisationalStructureList { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ProfilePermissionDtos_1__AccessTypeId")]
        public IWebElement EperformMarkers { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ProfilePermissionDtos_2__AccessTypeId")]
        public IWebElement EperformPositionDetails { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ProfilePermissionDtos_3__AccessTypeId")]
        public IWebElement EperformReportingPostions { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_4__AccessTypeId")]
        public IWebElement EperformAssociatedOrganisationalUnits { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_5__AccessTypeId")]
        public IWebElement EeprformAssociatedUsers { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_ProfilePermissionDtos_6__AccessTypeId")]
        public IWebElement EperformCompetencies { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_7__AccessTypeId")]
        public IWebElement EperformAssociatedGoals { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_8__AccessTypeId")]
        public IWebElement EperformPositionChart { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_9__AccessTypeId")]
        public IWebElement EpeformOrganisationGoalIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_10__AccessTypeId")]
        public IWebElement EperformPositionGoalIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_11__AccessTypeId")]
        public IWebElement EperformMeasuresIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_12__AccessTypeId")]
        public IWebElement EperformPillarsIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_13__AccessTypeId")]
        public IWebElement EperformDevelopmentActivities { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_14__AccessTypeId")]
        public IWebElement EpeformDocuments { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_26__AccessTypeId")]
        public IWebElement EpeformCompetencyFrameworkIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_27__AccessTypeId")]
        public IWebElement EperformReviewTemplatesIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_28__AccessTypeId")]
        public IWebElement EperformReviewIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_32__AccessTypeId")]
        public IWebElement EperformReviewWorkflows { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_16__AccessTypeId")]
        public IWebElement EprformMessagesIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_17__AccessTypeId")]
        public IWebElement EperformEmailTemplates { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_ProfilePermissionDtos_18__AccessTypeId")]
        public IWebElement EperformEmailNotifications { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_19__AccessTypeId")]
        public IWebElement EperforGlobalQuestions { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_20__AccessTypeId")]
        public IWebElement EperformFormTemplatesIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_21__AccessTypeId")]
        public IWebElement EperformSystemFormsIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_22__AccessTypeId")]
        public IWebElement EperformCaptionsIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_23__AccessTypeId")]
        public IWebElement EperformPermissionsProfile { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_24__AccessTypeId")]
        public IWebElement EperformBulkDataImportAndExport { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_25__AccessTypeId")]
        public IWebElement EperformEmailQueue { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_15__AccessTypeId")]
        public IWebElement EPerformUsersIcon { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ManageAllUsers")]
        public IWebElement EperformManageAllUsersCheckBox { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_ImpersonateUsers")]
        public IWebElement EperformImpersomateUsersCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_29__AccessTypeId")]
        public IWebElement EperformReviewDumpAccess { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_ProfilePermissionDtos_30__AccessTypeId")]
        public IWebElement EperformUserAccessPermissions { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfilePermissionDtos_31__AccessTypeId")]
        public IWebElement EpeformAnalyticsIcon { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[text()='Submit']")]
        public IWebElement EperformSubmitButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Cancel']")]
        public IWebElement EperformCancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        #endregion

        public void createpermissionProfileList()
        {
            HomePage home = new HomePage(_driver);
            home.EperformSystemConfigurationArrowIcon.Click();
            home.EperformPermissionProfilesOption.Click();
            AddNewProfileButton.Click();
            DataRow dr = ExcelData.GetData_DataTable("Ep_Permission", "Organisation Structure", "KeyName", "Organisation Structure_01").Rows[0];
            ProfileNameTextBox.SendKeys(dr["Name"].ToString());
            EperformOrganisationalStructureList.Click();
            BaseMethods.DdlSelectByText(EperformOrganisationalStructureList, dr["Organisation Structure"].ToString());
            EperformMarkers.Click();
            BaseMethods.DdlSelectByText(EperformMarkers, dr["Markers"].ToString());
            EperformPositionDetails.Click();
            BaseMethods.DdlSelectByText(EperformPositionDetails, dr["Position Details"].ToString());
            EperformReportingPostions.Click();
            BaseMethods.DdlSelectByText(EperformReportingPostions, dr["Reporting Positions"].ToString());
            EperformAssociatedOrganisationalUnits.Click();
            BaseMethods.DdlSelectByText(EperformAssociatedOrganisationalUnits, dr["Associated Organisational Units"].ToString());
            EeprformAssociatedUsers.Click();
            BaseMethods.DdlSelectByText(EeprformAssociatedUsers, dr["Associated Users"].ToString());
            EperformCompetencies.Click();
            BaseMethods.DdlSelectByText(EperformCompetencies, dr["Competencies"].ToString());
            EperformAssociatedGoals.Click();
            BaseMethods.DdlSelectByText(EperformAssociatedGoals, dr["Associated Goals"].ToString());
            EperformPositionChart.Click();
            BaseMethods.DdlSelectByText(EperformPositionChart, dr["Position Chart"].ToString());
            referenceMaterial();
            createSystemReviews();
            createUsersAnalytics();
            EperformSubmitButton.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);

        }
        public void referenceMaterial()
        {
            DataRow data = ExcelData.GetData_DataTable("Ep_Permission", "ReferenceMaterial", "KeyName", "Reference Material _01").Rows[0];
            EpeformOrganisationGoalIcon.Click();
            BaseMethods.DdlSelectByText(EpeformOrganisationGoalIcon, data["Organisation Goals"].ToString());
            EperformPositionGoalIcon.Click();
            BaseMethods.DdlSelectByText(EperformPositionGoalIcon,data["Position Goals"].ToString());
            EperformMeasuresIcon.Click();
            BaseMethods.DdlSelectByText(EperformMeasuresIcon, data["Measures"].ToString());
            EperformPillarsIcon.Click();
            BaseMethods.DdlSelectByText(EperformPillarsIcon,data["Pillars"].ToString());
            EperformDevelopmentActivities.Click();
            BaseMethods.DdlSelectByText(EperformDevelopmentActivities, data["Development Activities"].ToString());
            EpeformDocuments.Click();
            BaseMethods.DdlSelectByText(EpeformDocuments, data["Documents"].ToString());
            EpeformCompetencyFrameworkIcon.Click();
            BaseMethods.DdlSelectByText(EpeformCompetencyFrameworkIcon, data["Competency Framework"].ToString());
            
        }

        public void createSystemReviews()
        {
            DataRow data = ExcelData.GetData_DataTable("Ep_Permission", "Reviews", "KeyName", "Reviews_01").Rows[0];
            EperformReviewTemplatesIcon.Click();
            BaseMethods.DdlSelectByText(EperformReviewTemplatesIcon, data["Review Templates"].ToString());
            EperformReviewIcon.Click();
            BaseMethods.DdlSelectByText(EperformReviewIcon, data["Reviews"].ToString());
            EperformReviewWorkflows.Click();
            BaseMethods.DdlSelectByText(EperformReviewWorkflows, data["Review Workflows"].ToString());
            DataRow dr = ExcelData.GetData_DataTable("Ep_Permission", "System", "KeyName", "System_01").Rows[0];
            EprformMessagesIcon.Click();
            BaseMethods.DdlSelectByText(EprformMessagesIcon, dr["Messages"].ToString());
            EperformEmailTemplates.Click();
            BaseMethods.DdlSelectByText(EperformEmailTemplates, dr["Email Templates"].ToString());
            EperformEmailNotifications.Click();
            BaseMethods.DdlSelectByText(EperformEmailNotifications, dr["Email Notifications"].ToString());
            EperforGlobalQuestions.Click();
            BaseMethods.DdlSelectByText(EperforGlobalQuestions,dr["Global Questions"].ToString());
            EperformFormTemplatesIcon.Click();
            BaseMethods.DdlSelectByText(EperformFormTemplatesIcon, dr["Form Templates"].ToString());
            EperformSystemFormsIcon.Click();
            BaseMethods.DdlSelectByText(EperformSystemFormsIcon, dr["System Forms"].ToString());
            EperformCaptionsIcon.Click();
            BaseMethods.DdlSelectByText(EperformCaptionsIcon, dr["Captions"].ToString());
            EperformPermissionsProfile.Click();
            BaseMethods.DdlSelectByText(EperformPermissionsProfile, dr["Captions"].ToString());
            EperformBulkDataImportAndExport.Click();
            BaseMethods.DdlSelectByText(EperformBulkDataImportAndExport, dr["Bulk Data Import And Export"].ToString());
            EperformEmailQueue.Click();
            BaseMethods.DdlSelectByText(EperformEmailQueue, dr["EmailQueue"].ToString());
           
        }

        public void createUsersAnalytics()
        {
            DataRow dr = ExcelData.GetData_DataTable("Ep_Permission", "Users", "KeyName", "Users_01").Rows[0];
            EPerformUsersIcon.Click();
            BaseMethods.DdlSelectByText(EPerformUsersIcon, dr["Users"].ToString());
            if (dr["Manage All Users"].ToString() == "Yes")
            {
                EperformManageAllUsersCheckBox.Click();
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass,"The ManageAllUsersCheckBox is not displayed");
            }
            if (dr["Impersonate Users"].ToString() == "Yes")
            {
                EperformImpersomateUsersCheckBox.Click();

            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The ImpersomateUsersCheckBox is not displayed");
            }
            EperformReviewDumpAccess.Click();
            BaseMethods.DdlSelectByText(EperformReviewDumpAccess, dr["Review Dump Access"].ToString());
            EperformUserAccessPermissions.Click();
            BaseMethods.DdlSelectByText(EperformUserAccessPermissions, dr["Users"].ToString());
            EpeformAnalyticsIcon.Click();
            BaseMethods.DdlSelectByText(EpeformAnalyticsIcon, dr["Review Dump Access"].ToString());
        }

    }
    }
