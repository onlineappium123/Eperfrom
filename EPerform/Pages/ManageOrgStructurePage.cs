using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    class ManageOrgStructurePage
    {
        IWebDriver driver;

        public ManageOrgStructurePage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Manage Organisational Structure')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Details')]")]
        public IWebElement Details_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Organisational Unit List')]")]
        public IWebElement OrganisationalUnitList_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Chart')]")]
        public IWebElement Chart_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Reporting Organisational Units')]")]
        public IWebElement ReportingOrganisationalUnits_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Associated Positions')]")]
        public IWebElement AssociatedPositions_Tab { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Add Org Unit")]
        public IWebElement AddOrgUnit_Button { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Add Organisational Unit")]
        public IWebElement AddOrganisationalUnit_Button { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Add Position")]
        public IWebElement AddPosition_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Name field is required.')]")]
        public IWebElement NameField_MandatoryField { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Reference field is required.')]")]
        public IWebElement ReferenceField_MandatoryField { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cancel")]
        public IWebElement Cancel_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement Name_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_OrgUnitReference")]
        public IWebElement Reference_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ParentOrgUnitId")]
        public IWebElement Parent_DDL { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Description")]
        public IWebElement Description_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MarkerId")]
        public IWebElement Marker_DDL { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@id='Keywords'])[1]")]
        public IWebElement Keywords_TextBox1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@id='Keywords'])[2]")]
        public IWebElement Keywords_TextBox2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Search')])[1]")]
        public IWebElement SearchButton1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Search')])[2]")]
        public IWebElement SearchButton2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Search')])[3]")]
        public IWebElement SearchButton3 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Search')])[4]")]
        public IWebElement SearchButton4 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//tbody//input[@type='checkbox'])[1]")]
        public IWebElement SelectSearchedItem_CheckBox_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Confirm')]")]
        public IWebElement Confirm_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        public void ManageOrgStructurePageVerification()
        {
            Assert.IsTrue(PageTitle.Displayed, "Manage Organisational Structure page is not displayed on click of Organisational Structure Option in the Header Tab");
            ExtentReport.test.Log(LogStatus.Pass, "Manage Organisational Structure page is displayed on click of Organisational Structure Option in the Header Tab");

            Assert.IsTrue(Details_Tab.Displayed, "Details Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Details Tab is displayed successfully in the Manage Organisational Structure Page");

            Assert.IsTrue(OrganisationalUnitList_Tab.Displayed, "Organisational Unit List Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Organisational Unit List Tab is displayed successfully in the Manage Organisational Structure Page");

            Assert.IsTrue(Chart_Tab.Displayed, "Chart Tab is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "Chart Tab is displayed successfully in the Manage Organisational Structure Page");
        }

        public void VerifyMandatoryFields_AddOrgUnit()
        {
            OrganisationalUnitList_Tab.Click();
            AddOrgUnit_Button.Click();

            Submit_Button.Click();

            Assert.IsTrue(ErrorMessage.Displayed, "The Error Message for incomplete form fill is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "The Error Message for incomplete form fill is displayed in the Manage Organisational Structure Page");

            Assert.IsTrue(NameField_MandatoryField.Displayed, "The Validation Message for Name field is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "The Validation Message for Name field is displayed in the Manage Organisational Structure Page");

            Assert.IsTrue(ReferenceField_MandatoryField.Displayed, "The Validation Message for Reference field is not displayed in the Manage Organisational Structure Page");
            ExtentReport.test.Log(LogStatus.Pass, "The Validation Message for Reference field is displayed in the Manage Organisational Structure Page");
        }

        public void CreateOrgUnit(DataRow dr)
        {
            string orgUnitName = dr["Name"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
            string orgUnitReference = dr["Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            Name_TextBox.Clear();
            Name_TextBox.SendKeys(orgUnitName);

            Reference_TextBox.Clear();
            Reference_TextBox.SendKeys(orgUnitReference);

            BaseMethods.DdlSelectByText(Parent_DDL, dr["Parent"].ToString());

            Description_TextBox.Clear();
            Description_TextBox.SendKeys(dr["Description"].ToString());

            string marker = dr["Marker"].ToString() == "" ? "None" : dr["Marker"].ToString();

            BaseMethods.DdlSelectByText(Marker_DDL, marker);

            Submit_Button.Click();

            Assert.IsTrue(SuccessMessage.Displayed, orgUnitName + " - Organisational Unit is not created successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + orgUnitName + " - Organisational Unit is created successfully");

            Thread.Sleep(3000);

            if (dr["AddPosition_AsPos"].ToString().Trim() != "")
            {
                AssociatedPositions_Tab.Click();
                Thread.Sleep(2000);

                AddPosition_Button.Click();

                Keywords_TextBox2.Clear();
                Keywords_TextBox2.SendKeys(dr["AddPosition_AsPos"].ToString());

                SearchButton3.Click();
                Thread.Sleep(2000);
                try
                {
                    SelectSearchedItem_CheckBox_Popup.Click();
                }
                catch (Exception)
                {
                    ExtentReport.test.Log(LogStatus.Fatal, dr["AddPosition_AsPos"].ToString() + " - Position is not found in the Positions List");
                    goto RepOrgUnit;
                }

                Submit_Button.Click();
                Thread.Sleep(2000);
                try
                {
                    Confirm_Button.Click();
                    Thread.Sleep(2000);
                }
                catch { }

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + dr["AddPosition_AsPos"].ToString() + " - Position is selected successfully and listed in the Associated Position List",
                                                              dr["AddPosition_AsPos"].ToString() + " - Position is not selected successfully");

            }

            RepOrgUnit:
            if (dr["AddOrganisationalUnit_RepOrgUnit"].ToString().Trim() != "")
            {
                ReportingOrganisationalUnits_Tab.Click();
                AddOrganisationalUnit_Button.Click();
                DataTable dtChild = ExcelData.GetData_DataTable("EP_OrgStructures", "OrganisationalUnit", "ID", Convert.ToInt32(dr["AddOrganisationalUnit_RepOrgUnit"]));
                DataRow drChild = dtChild.Rows[0];
                CreateOrgUnit(drChild);
            }

        }

    }
}
