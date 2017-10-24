using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Data;
using EPerform.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using System.Threading;

namespace EPerform.Pages
{
    class RolesPage
    {

        IWebDriver _driver;


        public RolesPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = " //a[contains(text(),'Add Role')]")]
        public IWebElement AddRole_Button { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement Name_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleTypeId")]
        public IWebElement Type_DDL { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_TaskFlowFunctionTypeId")]
        public IWebElement Function_DDL { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement Cancel_Button { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement CloseButton_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Keywords']")]
        public IWebElement Keywords_TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Search')]")]
        public IWebElement Search_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]//a[contains(text(),'Edit')]")]
        public IWebElement SearchedRoleEdit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[1]")]
        public IWebElement SearchedRole { get; set; }

        public void CreateRole(DataRow dr)
        {
            AddRole_Button.Click();
            Thread.Sleep(2500);
            fillForm(dr["Name"].ToString(), dr["Type"].ToString(), dr["Function"].ToString(), "created");

            if (dr["IsEdit"].ToString().ToLower() == "yes")
            {
                SearchRole(dr["Name"].ToString());
                Thread.Sleep(2000);
                SearchedRoleEdit_Button.Click();

                fillForm(dr["EditName"].ToString(), dr["EditType"].ToString(), dr["EditFunction"].ToString(), "edited and updated");
            }
        }

        public void fillForm(string roleName, string type, string function, string formSubmitType)
        {
            Name_TextBox.Clear();
            Name_TextBox.SendKeys(roleName);

            BaseMethods.DdlSelectByText(Type_DDL, type);

            if (type == "Reviewer")
            {
                BaseMethods.DdlSelectByText(Function_DDL, function);
            }

            Submit_Button.Click();
            Thread.Sleep(3000);
            Assert.IsTrue(SuccessMessage.Displayed, roleName + " - Role is not " + formSubmitType + " successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + roleName + " - Role is " + formSubmitType + " successfully");
        }

        public void SearchRole(string keyword)
        {
            Keywords_TextBox.Clear();

            Keywords_TextBox.SendKeys(keyword);

            Search_Button.Click();

            Assert.IsTrue(SearchedRole.Text.Contains(keyword), keyword + " - Role search was unsuccessful and is not found in the Roles List");
            ExtentReport.test.Log(LogStatus.Pass, keyword + " - Role has been successfully searched and is present in the Roles List");
        }


    }
}
