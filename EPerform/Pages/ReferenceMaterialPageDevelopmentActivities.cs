using EPerform.Library;
using EPerform.Library.Excel;
using ePerfrom.Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class ReferenceMaterialPageDevelopmentActivities
    {

        IWebDriver _driver;
        String nametext = string.Empty;
        public ReferenceMaterialPageDevelopmentActivities(IWebDriver _driver)
        {
            this._driver = _driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='linkToModal btn-xs btn btn-darkblue']")]
        public IList<IWebElement> EPerformEditButtonList { get; set; }


        [FindsBy(How=How.XPath,Using = "//button[text()='Submit']")]
        public IWebElement EperformSubmit { get; set; }

        [FindsBy(How=How.XPath,Using = "//div[@class='validation-summary-errors']")]
        public IWebElement EperformErrorMessage { get; set; }

        [FindsBy(How=How.XPath,Using = "//span[@class='field-validation-error']")]
        public IList<IWebElement> EperformRequiredErrorMessage { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_PillarId")]
        public IWebElement EperformPillarDropDownIcon { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PillarId")]
        public IList<IWebElement> EperformPillarDropDownList { get; set; }

        //-- Please Select --
        [FindsBy(How=How.XPath,Using = "//label[@for='Dto_IsActive_t']")]
        public IWebElement EperformDevelopmentActivitiesYesRadioBtn { get; set; }

        [FindsBy(How =How.XPath,Using = "//label[@for='Dto_IsActive_f']")]
        public IWebElement EperformDevelopmentActivitiesNoRadioBtn { get; set; }

        [FindsBy(How =How.XPath,Using = "//option[text()='-- Please Select --']")]
        public IWebElement EperformpillarsSelectText { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_DateDtos_0__Value")]
        public IWebElement EperformDataTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_MultipleGuidDtos_0__Value_0")]
        public IWebElement EpeformSelectMultipleCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_GuidDtos_0__Value_0")]
        public IWebElement EperformSelectSingleRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_GuidDtos_0__Value_1")]
        public IWebElement EperformSelectRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_GuidDtos_1__Value_0")]
        public IWebElement EperformYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_GuidDtos_1__Value_1")]
        public IWebElement EperformNoRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[contains(text(),'Edit')]")]
        public IWebElement EperformEditButton { get; set; }

        [FindsBy(How =How.Id,Using = "Keywords")]
        public IWebElement EperfromSearchTextBox { get; set; }

        [FindsBy(How=How.Name,Using = "OnSearch")]
        public IWebElement EperformSearchButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//td[contains(text(),'Yes')]")]
        public IWebElement EperformYesText { get; set; }

        [FindsBy(How=How.XPath,Using = "//td[contains(text(),'No')]")]
        public IWebElement EperformNoText { get; set; }

        [FindsBy(How=How.XPath,Using = "//td[@class='footable-visible footable-first-column']")]
        public IWebElement NameText { get; set;}

        [FindsBy(How =How.XPath,Using = "(//td[@class='footable-visible'])[1]")]
           public IWebElement DescriptionText { get; set; }

        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible'])[2]")]
        public IWebElement PillarText { get; set; }

        [FindsBy(How =How.Id,Using = "NoListRecords")]
        public IWebElement ErrorText { get; set; }

        [FindsBy(How =How.XPath,Using = "//h3[contains(text(),'Development Activities')]")]
        public IWebElement DeveLopmentActivitiesText { get; set; }

        public void addDevelopmentActivity()
        {
            ReferenceMaterialPage referencematerial = new ReferenceMaterialPage(_driver);
            HomePage home = new HomePage(_driver);
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceDevelopmentActivity", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                nametext = dr["Name"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformDevelopmentActivitiesOption.Click();
                System.Threading.Thread.Sleep(3000);
                referencematerial.EperformAddDevelopmentActivityButton.Click();
                System.Threading.Thread.Sleep(2000);
                referencematerial.EperformNameTextBox.SendKeys(nametext);
                if (dr["Active"].ToString() == "Yes")
                {
                    referencematerial.EperformActiveYesRadioBtn.Click();
                }
                else
                {
                    referencematerial.EperfromActiveNoRadioBtn.Click();
                }
                referencematerial.EperformDescriptionTextBox.SendKeys(dr["Description"].ToString());
                DataTable data = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferencePillar", "Enable", "Yes");
                foreach (DataRow drta in data.Rows)
                {
                    EperformPillarDropDownIcon.Click();
                    BaseMethods.DdlSelectByText(EperformPillarDropDownIcon, drta["NAME"].ToString());
                    System.Threading.Thread.Sleep(2000);
                }
                if (dr["EmergencyContactDetails"].ToString() == "Yes")
                {
                    EperformSelectSingleRadioBtn.Click();

                }
                else
                {
                    EperformSelectRadioBtn.Click();
                }

                if (dr["qualifications"].ToString() == "Yes")
                {
                    EperformYesRadioButton.Click();
                }
                else
                {
                    EperformNoRadioButton.Click();
                }
                //EperformDataTextBox.SendKeys(dr["Data"].ToString());
                ////we will remove the code bug
                //EpeformSelectMultipleCheckBox.Click();

                //EperformSelectSingleRadioBtn.Click();
                //EperformSubmit.Click();
                //System.Threading.Thread.Sleep(2000);
                EperformSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed", "Eperform Success Message is displayed");
                editDevelopmentActivity(nametext);
            }
        }

        public void editDevelopmentActivity(string name)
        {
            ReferenceMaterialPage referencematerial = new ReferenceMaterialPage(_driver);
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceDevelopmentActivity", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                //    addDevelopmentActivity();
                //System.Threading.Thread.Sleep(2000);
                //EperformSearchButton.Click();
                BaseMethods.webelementverify(DeveLopmentActivitiesText);
                search(name);
                Thread.Sleep(2000);
                EperformEditButton.Click();
                referencematerial.EperformNameTextBox.Clear();
                referencematerial.EperformNameTextBox.SendKeys(dr["EditName"].ToString());
                referencematerial.EperfromActiveNoRadioBtn.Click();
                referencematerial.EperformDescriptionTextBox.Clear();
                referencematerial.EperformDescriptionTextBox.SendKeys(dr["EditDescription"].ToString());
                
                EperformSubmit.Click();
                System.Threading.Thread.Sleep(2000);
                search(nametext);
            }
            try
            {
                BaseMethods.webelementverify(NameText);
                BaseMethods.webelementverify(DescriptionText);
                BaseMethods.webelementverify(PillarText);
                BaseMethods.webelementverify(EperformNoText);
            }
            catch
            {
                BaseMethods.webelementverify(ErrorText);
            }

        }

        public void search(String text)
        {
            EperfromSearchTextBox.Clear();
            EperfromSearchTextBox.SendKeys(text);
            EperformSearchButton.Click();
        }
    }
}
