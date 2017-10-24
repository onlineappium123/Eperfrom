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
    class UserListPage
    {

        IWebDriver _driver;
        string nametext;

        public UserListPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How =How.XPath,Using = "//a[contains(text(),' Add User')]")]
        public IWebElement AddUserButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_UserName")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_UserReference")]
        public IWebElement ReferenceTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_Password")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ConfirmPassword")]
        public IWebElement ConfirmPasswordTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ExpiryDate")]
        public IWebElement ExpiryDateTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_Status")]
        public IWebElement StatusDropDownList { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_StringDtos_0__Value")]
        public IWebElement EmployeeNumberTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_1__Value")]
         public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_2__Value")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_3__Value")]
        public IWebElement MiddleNameTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_4__Value")]
        public IWebElement PreferredFirstNameTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_GuidDtos_0__Value")]
        public IWebElement TitleDropdown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_5__Value")]
        public IWebElement EmailAddressTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_6__Value")]
        public IWebElement FacultyDepartmentTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_7__Value")]
        public IWebElement EmploymentStatusTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_8__Value")]
        public IWebElement WorkFunctionTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_9__Value")]
        public IWebElement ActiveReportTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_10__Value")]
        public IWebElement PerformanceDiaryTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_11__Value")]
        public IWebElement WebSelfServiceTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_DateDtos_0__Value")]
        public IWebElement DataFormTemplateTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_BoolDtos_0__Value_t")]
        public IWebElement YesRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_BoolDtos_0__Value_f")]
        public IWebElement NoRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StringDtos_12__Value")]
        public IWebElement LocalQuestUserTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_GuidDtos_1__Value")]
        public IWebElement TestDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_GuidDtos_2__Value")]
        public IWebElement AutoRefreshDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_DateDtos_1__Value")]
        public IWebElement AutomationTestingTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_DateDtos_2__Value")]
        public IWebElement AutomationTestingTextBox1 { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_BoolDtos_1__Value_t")]
        public IWebElement AutomationTestingYesButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_BoolDtos_1__Value_f")]
        public IWebElement AutomationTestingNoButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_BoolDtos_2__Value_t")]
        public IWebElement AutomationTesting2YesRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_BoolDtos_2__Value_f")]
        public IWebElement AutomationTesting2NoRadioButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[text()='Submit']")]
        public IWebElement SubmitButton { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='User Access Permissions']")]
        public IWebElement UserAcessPermissionsTab { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ProfileId")]
        public IWebElement PermissionProfileDropDown { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_HasEPerformAPAccess")]
        public IWebElement AdminPortalCheckBox { get; set; }

        public void createuser()
        {

            DataTable drt = ExcelData.GetData_DataTable("EP_Users", "Users", "KeyName", "User_01");
            foreach (DataRow data in drt.Rows)
            {
                nametext = data["Automation Testing"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                HomePage home = new HomePage(_driver);
                home.EperformSystemConfigurationArrowIcon.Click();
                home.EperformUsersOption.Click();
                BaseMethods.webelementverify(AddUserButton);
                AddUserButton.Click();
                BaseMethods.verifyWebElement(UserNameTextBox, "The usernameTextBox is not displayed", "the usernametextbox is displayed");
                UserNameTextBox.SendKeys(data["Username"].ToString());
                BaseMethods.verifyWebElement(ReferenceTextBox, "The ReferenceTextBox is not displayed", "The ReferenceTextBox is displayed");
                ReferenceTextBox.SendKeys(data["Reference"].ToString());
                BaseMethods.verifyWebElement(PasswordTextBox, "PasswordTextBox is not displayed", "PasswordTextBox is displayed");
                PasswordTextBox.SendKeys(data["Password"].ToString());
                BaseMethods.verifyWebElement(ConfirmPasswordTextBox, "The ConfirmPasswordTextBox is not displayed", "The ConfirmPasswordTextBox is Displayed");
                ConfirmPasswordTextBox.SendKeys(data["Confirm Password"].ToString());
                BaseMethods.verifyWebElement(ExpiryDateTextBox, "The ExpiryDateTextBox is not displayed", "The ExpiryDateTextBox is Displayed");
                ExpiryDateTextBox.SendKeys(data["Expiry Date"].ToString());
                StatusDropDownList.Click();
                BaseMethods.DdlSelectByText(StatusDropDownList, data["Status"].ToString());
                BaseMethods.verifyWebElement(EmployeeNumberTextBox, "The EmployeeNumberTextBox is not displayed", "The EmployeeNumberTextBox is Displayed");
                EmployeeNumberTextBox.SendKeys(data["Employee number"].ToString());
                BaseMethods.verifyWebElement(LastNameTextBox, "The LastNameTextBox is not displayed", "The LastNameTextBox is Displayed");
                LastNameTextBox.SendKeys(data["Last Name"].ToString());
                BaseMethods.verifyWebElement(FirstNameTextBox, "The FirstNameTextBox is not displayed", "The FirstNameTextBox is Displayed");
                FirstNameTextBox.SendKeys(data["First Name"].ToString());
                BaseMethods.verifyWebElement(MiddleNameTextBox, "The FirstNameTextBox is not displayed", "The FirstNameTextBox is Displayed");
                MiddleNameTextBox.SendKeys(data["Middle Name"].ToString());
                BaseMethods.verifyWebElement(PreferredFirstNameTextBox, "The PreferredFirstNameTextBox is not displayed", "The PreferredFirstNameTextBox is Displayed");
                PreferredFirstNameTextBox.SendKeys(data["PreferredFirstName"].ToString());

                TitleDropdown.Click();
                BaseMethods.DdlSelectByText(TitleDropdown, data["Title"].ToString());
                BaseMethods.verifyWebElement(PreferredFirstNameTextBox, "The EmailAddressTextBox is not displayed", "The EmailAddressTextBox is Displayed");
                EmailAddressTextBox.SendKeys(data["Email address"].ToString());
                BaseMethods.verifyWebElement(FacultyDepartmentTextBox, "The FacultyDepartmentTextBox is not displayed", "The FacultyDepartmentTextBox is Displayed");
                FacultyDepartmentTextBox.SendKeys(data["Faculty/Department"].ToString());
                BaseMethods.verifyWebElement(EmploymentStatusTextBox, "The EmploymentStatusTextBox is not displayed", "The EmploymentStatusTextBox is Displayed");
                EmploymentStatusTextBox.SendKeys(data["EmploymentStatus"].ToString());
                BaseMethods.verifyWebElement(WorkFunctionTextBox, "The WorkFunctionTextBox is not displayed", "The WorkFunctionTextBox is Displayed");
                WorkFunctionTextBox.SendKeys(data["Work Function"].ToString());
                BaseMethods.verifyWebElement(ActiveReportTextBox, "The ActiveReportTextBox is not displayed", "The ActiveReportTextBox is Displayed");
                ActiveReportTextBox.SendKeys(data["ResearchActiveStatus"].ToString());
                BaseMethods.verifyWebElement(PerformanceDiaryTextBox, "The PerformanceDiaryTextBox is not displayed", "The PerformanceDiaryTextBox is Displayed");
                PerformanceDiaryTextBox.SendKeys(data["AverageTEVALscore"].ToString());
                BaseMethods.verifyWebElement(WebSelfServiceTextBox, "The WebSelfServiceTextBox is not displayed", "The WebSelfServiceTextBox is Displayed");
                WebSelfServiceTextBox.SendKeys(data["AnnualLeaveBalance"].ToString());
                Thread.Sleep(2000);
                SubmitButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformSuccessMessage);
                BaseMethods.verifyWebElement(UserAcessPermissionsTab, "The UserAcessPermissionsTab is not displayed", "The UserAcessPermissionsTab is Displayed");
                UserAcessPermissionsTab.Click();
                BaseMethods.verifyWebElement(AdminPortalCheckBox, "The AdminPortalCheckBox is not displayed", "The AdminPortalCheckBox is Displayed");
                AdminPortalCheckBox.Click();
                PermissionProfileDropDown.Click();
                DataRow data1 = ExcelData.GetData_DataTable("Ep_Permission", "Organisation Structure", "KeyName", "Organisation Structure_01").Rows[0];
                BaseMethods.DdlSelectByText(PermissionProfileDropDown, data1["Name"].ToString());
                SubmitButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformSuccessMessage);

            }

        }
    }
}
