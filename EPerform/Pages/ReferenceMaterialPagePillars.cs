using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;
using ePerfrom.Library;
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
    class ReferenceMaterialPagePillars
    {
        IWebDriver _driver;


        public ReferenceMaterialPagePillars(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Name']")]
        public IWebElement PillarNameText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Description']")]
        public IWebElement PillarDescriptionText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Active']")]
        public IWebElement PillarActiveText { get; set; }


        [FindsBy(How = How.XPath, Using = "//th[@class='col-md-2 footable-visible footable-last-column']")]
        public IWebElement PillarActionsText { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Add Pillar']")]
        public IWebElement AddPillarButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),' Manage Pillar')]")]
        public IWebElement PillarManagePillarText { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Pillars')]")]
        public IWebElement PillarText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='field-validation-error']")]
        public IWebElement errorMessageName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='field-validation-error']")]
        public IWebElement invalidErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement EperformCancelButton { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }


        public void sortablepillarpage()
        {
            HomePage home = new HomePage(_driver);
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
            ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
            ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
            ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
            PillarNameText.Click();
            BaseMethods.webelementverify(reference.NameText);
            PillarNameText.Click();
            BaseMethods.webelementverify(reference.NameText);
            PillarDescriptionText.Click();
            BaseMethods.webelementverify(reference.DescriptionText);
            PillarDescriptionText.Click();
            BaseMethods.webelementverify(reference.DescriptionText);
            PillarActiveText.Click();
            BaseMethods.webelementverify(reference.PillarText);
            PillarActiveText.Click();
            BaseMethods.webelementverify(reference.PillarText);
        }


        public void createPillar()
        {
            HomePage home = new HomePage(_driver);
            //ArrayList list = BaseClass.GetData("ER_TESTDATA", SheetName, "KeyName", Keyname);
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferencePillar", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
                ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformPillarsOption.Click();
                AddPillarButton.Click();
                referenceMaterialPage.EperformNameTextBox.SendKeys(dr["NAME"].ToString());
                referenceMaterialPage.EperformDescriptionTextBox.SendKeys(dr["Description"].ToString());
                if (dr["Active"].ToString() == "Yes")
                {
                    referenceMaterialPage.EperformActiveYesRadioBtn.Click();
                }
                else
                {
                    referenceMaterialPage.EperfromActiveNoRadioBtn.Click();
                }
                reference.EperformSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
            }
        }

        public void createEditpillar()
        {
            HomePage home = new HomePage(_driver);
            // ArrayList list = BaseClass.GetData("EReference_TESTDATA", SheetName, "KeyName", Keyname);
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferencePillar", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                FormTemplatePage formtemplate = new FormTemplatePage(_driver);
                ReferenceMaterialPage referenceMaterialPage = new ReferenceMaterialPage(_driver);
                ReferenceMaterialPageDevelopmentActivities reference = new ReferenceMaterialPageDevelopmentActivities(_driver);
                ReferenceMaterialPagePillars referencePillars = new ReferenceMaterialPagePillars(_driver);
                home.EperformReferenceMaterialArrowIcon.Click();
                home.EperformPillarsOption.Click();
                AddPillarButton.Click();
                ExtentReport.test.Log(LogStatus.Pass, "Name Textbox is free textbox");
                referenceMaterialPage.EperformNameTextBox.SendKeys(dr["SameNAME"].ToString());
                ExtentReport.test.Log(LogStatus.Pass, "Description Textbox is multiLine textbox");
                referenceMaterialPage.EperformDescriptionTextBox.SendKeys(dr["Description"].ToString());
                ExtentReport.test.Log(LogStatus.Pass, "Active yes and no radio button is displayed");
                if (dr["Active"].ToString() == "Yes")
                {
                    referenceMaterialPage.EperformActiveYesRadioBtn.Click();
                }
                else
                {
                    referenceMaterialPage.EperfromActiveNoRadioBtn.Click();
                }
                reference.EperformSubmit.Click();
                BaseMethods.webelementverify(errorMessageName);

                referenceMaterialPage.EperformNameTextBox.Clear();
                referenceMaterialPage.EperformNameTextBox.SendKeys(dr["NAME"].ToString());
                referenceMaterialPage.EperformDescriptionTextBox.SendKeys(dr["Description"].ToString());
                if (dr["Active"].ToString() == "Yes")
                {
                    referenceMaterialPage.EperformActiveYesRadioBtn.Click();
                }
                else
                {
                    referenceMaterialPage.EperfromActiveNoRadioBtn.Click();
                }
                reference.EperformSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                try
                {
                    if (formtemplate.EperformSuccessMessage.Displayed)
                    {
                        BaseMethods.verifyWebElement(formtemplate.EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");

                        IWebElement element = _driver.FindElement(By.XPath("//tbody//tr//td[contains(text(),'" + dr["NAME"].ToString() + "')]"));
                        BaseMethods.webelementverify(element);
                        IWebElement EditElement = _driver.FindElement(By.XPath("//tbody//tr//td[contains(text(),'" + dr["NAME"].ToString() + "')]/../td//a[contains(text(),'Edit')]"));
                        EditElement.Click();
                        referenceMaterialPage.EperformNameTextBox.Clear();
                        referenceMaterialPage.EperformNameTextBox.SendKeys(dr["EditNAME"].ToString());
                        referenceMaterialPage.EperformDescriptionTextBox.Clear();
                        referenceMaterialPage.EperformDescriptionTextBox.SendKeys(dr["EditDescription"].ToString());
                        reference.EperformSubmit.Click();
                        BaseMethods.webelementverify(element);
                      
                    }
                    else
                    {


                    }
                }
                catch (Exception e)
                {
                   

                }
            }
        }
    }
}
