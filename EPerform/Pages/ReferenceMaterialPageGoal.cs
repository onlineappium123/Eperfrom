using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;
using ePerfrom.Library;
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
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class ReferenceMaterialPageGoal
    {
        public IWebDriver _driver;
        String nametext = null;
        public ReferenceMaterialPageGoal(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How =How.XPath,Using = "//h3[text()='Goals']")]
        public IWebElement EperformGoalsText { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Goal')]")]
        public IWebElement EperformAddGoalButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//td[@class='footable-visible footable-first-column']//a")]
        public IList<IWebElement> EperformNameTextValue { get; set; }


       
        [FindsBy(How =How.XPath,Using = "//a[contains(text(),'Show Advanced Search')]")]
        public IWebElement EperformShowAdvancedSearchButton { get; set; }


        [FindsBy(How =How.XPath,Using = "//label[text()='Keyword']")]
        public IWebElement EperformKeywordText { get; set; }

        [FindsBy(How =How.XPath,Using = "//i[contains(@class,'fa fa-caret-down')]")]
        public IWebElement EperformCustomiseText { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@class='linkToModal link'])[1]")]
        public IWebElement EperformNameText { get; set; }

        [FindsBy(How =How.XPath,Using = "//h3[contains(text(),'Preview Goal')]")]
        public IWebElement EperformPreviewGoalText { get; set; }

        [FindsBy(How=How.ClassName,Using = "close")]
        public IWebElement EperformGoalClose { get; set; }

        [FindsBy(How =How.XPath,Using = "(//div[@class='form-control-static'])[1]")]
        public IWebElement EperformPerviewGoalText { get; set; }

        [FindsBy(How=How.XPath,Using = "(//td[@class='footable-visible'])[1]")]
        public IWebElement EperformTypeValueText { get; set; }

        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible'])[2]")]
        public IWebElement EperformTypePillarText { get; set; }

        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible'])[2]")]
        public IWebElement EperformTypeActiveText { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='View Hierarchy']")]
        public IList<IWebElement> EperformViewHierarachyText { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[contains(text(),' Edit')]")]
        public IList<IWebElement> EperformEditButton { get; set; }

        [FindsBy(How =How.XPath,Using = "(//label[contains(text(),'Type')])[2]")]
        public IWebElement EperformTypeText { get; set; }


        [FindsBy(How = How.XPath, Using = "(//label[contains(text(),'Pillar')])[2]")]
        public IWebElement EperformPillarText { get; set; }


        [FindsBy(How = How.XPath, Using = "(//label[contains(text(),'Active')])[2]")]
        public IWebElement EperformActiveText { get; set; }

        [FindsBy(How =How.XPath,Using = "//span[text()='Type']")]
        public IList<IWebElement> EperformHomeTypeText { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[text()='Pillar']")]
        public IList<IWebElement> EperformHomePillarText { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[text()='Active']")]
        public IList<IWebElement> EperformHomeActiveText { get; set; }

        [FindsBy(How = How.Id, Using = "toggle-col-1")]
        public IWebElement EperformFirstCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "toggle-col-2")]
        public IWebElement EperformSecondCheckBox { get; set; }

        [FindsBy(How =How.Id,Using = "toggle-col-3")]
        public IWebElement EperformThirdCheckBox { get; set; }

        [FindsBy(How =How.XPath,Using = "//label[@for='Dto_Name']")]
        public IWebElement EperformGoalNameText { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Description']")]
        public IWebElement EperformGoalDescriptionText { get; set; }

        [FindsBy(How=How.XPath,Using = "//label[@for='Dto_PillarId']")]
        public IWebElement EperformGoalPillarText { get; set; }

        [FindsBy(How =How.XPath,Using = "//label[@for='Dto_IsRated']")]
        public IWebElement EperformGoalRatedText { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_PillarId")]
        public IWebElement EperformPillarId { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PillarId")]
        public IList<IWebElement> EperformPillarList { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_PillarId")]
        public IWebElement EperformPillarFirstList { get; set; }

        [FindsBy(How=How.XPath,Using = "//label[@for='Dto_MeasureId']")]
        public IWebElement EperformMeasureIdText { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_MeasureId")]
        public IWebElement EperformMeasureId { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MeasureId")]
        public IList<IWebElement> EperformMeasureList { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_ParentGoalId']")]
        public IWebElement EperformParentGoalText { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_ParentGoalId")]
        public IWebElement EperformParentGoalId { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ParentGoalId")]
        public IList<IWebElement> EperformParentGoalList { get; set; }

        [FindsBy(How=How.XPath,Using = "//label[@for='Dto_GoalTypeId']")]
        public IWebElement EperformGoalTypeText { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_GoalTypeId")]
        public IWebElement EperformGoalTypeId { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_GoalTypeId")]
        public IList<IWebElement> EperformGoalTypeList { get; set; }

        [FindsBy(How=How.XPath,Using = "//label[@for='Dto_IsActive']")]
        public IWebElement EperformActivetext { get; set; }

        [FindsBy(How=How.XPath,Using = "//option[@value='94b8f8b2-40a5-4a6f-b314-a58e00995825']")]
        public IWebElement EperformMeasureFirstList { get; set; }

        [FindsBy(How =How.XPath,Using = "(//label[contains(text(),'Yes')])[2]")]
        public IWebElement EperformActiveYesText { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[text()='Submit']")]
        public IWebElement EperformSubmitButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Cancel']")]
        public IWebElement EperformCancelButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_Name")]
        public IWebElement EperformGoalNameTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_Description")]
        public IWebElement EperformDescriptionTextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_IsRated_t")]
        public IWebElement EperformRatedYesRadioButton { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_IsRated_f")]
         public IWebElement EperformRatedNoRadioButton { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_IsActive_t")]
        public IWebElement EperformActiveYesRadioButton { get; set; }

        [FindsBy(How=How.Id,Using = "Dto_IsActive_f")]
        public IWebElement EperformActiveNoRadioButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessageText { get; set; }

        [FindsBy(How =How.XPath,Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement EperformErrorMessageText { get; set; }

        [FindsBy(How =How.XPath,Using = "//span[text()='The Goal Name field is required.']")]
        public IWebElement EperformNameTextFiledErrorMessage { get; set; }

        [FindsBy(How =How.XPath,Using = "//span[text()='The Description field is required.']")]
        public IWebElement EperformDescriptionTextFieldErrorMessage { get; set; }

        [FindsBy(How =How.Id,Using = "Keywords")]
        public IWebElement EperformSearchTextBox { get; set; }

        [FindsBy(How =How.Name,Using = "OnSearch")]
        public IWebElement EperformSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Edit')]")]
        public IWebElement EperformEditBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='View Hierarchy']")]
        public IWebElement EperformViewHierarachyLink { get; set; }

        [FindsBy(How =How.XPath,Using = "//button[@class='close']")]
        public IWebElement EperformCloseButton { get; set; }
   

        [FindsBy(How =How.XPath,Using = "//div//h3[contains(text(),'Goal Hierarchy')]")]
        public IWebElement EperfromGoalHirarchyMessage { get; set; }

        [FindsBy(How =How.XPath,Using = "(//td[@class='footable-visible footable-first-column'])[1]")]
        public IWebElement EperformName { get; set; }

        public void goalHomeVerifySortableText(String text)
        {

                switch (text)
                {
                    case "Name":
                        IWebElement Nameelement = _driver.FindElement(By.XPath("//span[contains(text(),'" + text + "')]"));
                        BaseMethods.webelementverify(Nameelement);
                        BaseMethods.webelementverify(EperformNameText);
                        Nameelement.Click();
                        System.Threading.Thread.Sleep(2000);
                        BaseMethods.webelementverify(EperformNameText);
                        int count = EperformNameTextValue.Count;
                        for (int i = 1; i < count; i++)
                        {
                            System.Threading.Thread.Sleep(2000);

                            _driver.FindElement(By.XPath("(//td[@class='footable-visible footable-first-column'])[" + i + "]//a")).Click();
                            System.Threading.Thread.Sleep(3000);
                            BaseMethods.webelementverify(EperformPreviewGoalText);
                            BaseMethods.webelementverify(EperformPerviewGoalText);
                            EperformGoalClose.Click();
                        }
                        break;
                    case "Type":
                        IWebElement Typeelement = _driver.FindElement(By.XPath("//span[contains(text(),'" + text + "')]"));
                        BaseMethods.webelementverify(Typeelement);
                        BaseMethods.webelementverify(EperformTypeValueText);
                        Typeelement.Click();
                        BaseMethods.webelementverify(EperformTypeValueText);

                        break;
                    case "Pillar":
                        IWebElement Pillarelement = _driver.FindElement(By.XPath("//span[contains(text(),'" + text + "')]"));
                        BaseMethods.webelementverify(Pillarelement);
                        BaseMethods.webelementverify(EperformTypePillarText);
                        Pillarelement.Click();
                        BaseMethods.webelementverify(EperformTypePillarText);

                        break;
                    case "Active":
                        IWebElement Activeelement = _driver.FindElement(By.XPath("//span[contains(text(),'" + text + "')]"));
                        BaseMethods.webelementverify(Activeelement);
                        BaseMethods.webelementverify(EperformTypeActiveText);
                        Activeelement.Click();
                        BaseMethods.webelementverify(EperformTypeActiveText);

                        break;
                    case "Actions":
                        IWebElement Actionelement = _driver.FindElement(By.XPath("//th[contains(text(),'" + text + "')]"));
                        BaseMethods.webelementverify(Actionelement);
                        foreach (IWebElement element in EperformViewHierarachyText)
                        {
                            BaseMethods.webelementverify(element);
                        }
                        foreach (IWebElement EditElement in EperformEditButton)
                        {
                            BaseMethods.webelementverify(EditElement);
                        }
                        break;
                    default:
                        break;
    
            }
        }

        public void sortableGoal(String text)
        {
            IWebElement element = _driver.FindElement(By.XPath("//span[contains(text(),'" + text + "')]"));
            element.Click();


        }

        public void customiseoption()
        {
            EperformCustomiseText.Click();
            System.Threading.Thread.Sleep(2000);
            BaseMethods.webelementverify(EperformTypeText);
            BaseMethods.webelementverify(EperformTypePillarText);
            BaseMethods.webelementverify(EperformTypeActiveText);
            foreach(IWebElement element in EperformHomeTypeText)
            {
                BaseMethods.webelementverify(element);
            }
            EperformFirstCheckBox.Click();
            if (EperformHomeTypeText.Count!= 0)
            {

                ExtentReport.test.Log(LogStatus.Pass, "The type text is displayed in the home page");
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The type text is  not displayed in the home page");
            }

            foreach (IWebElement element in EperformHomePillarText)
            {
                BaseMethods.webelementverify(element);
            }
            EperformSecondCheckBox.Click();
            if (EperformHomeTypeText.Count != 0)
            {

                ExtentReport.test.Log(LogStatus.Pass, "The Pillar text is displayed in the home page ");
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Pillar text is not displayed in the home page");
            }
            foreach (IWebElement element in EperformHomeActiveText)
            {
                BaseMethods.webelementverify(element);
            }
            EperformThirdCheckBox.Click();
            if (EperformHomeTypeText.Count != 0)
            {

                ExtentReport.test.Log(LogStatus.Pass, "The Active text is displayed in home page");
            }
            else
            {
                ExtentReport.test.Log(LogStatus.Pass, "The Active text is not displayed in homepage");
            }
            for(int i = 1; i <= 3; i++)
            {
                _driver.FindElement(By.Id("toggle-col-" + i + "")).Click();

            }

        }


        public void verifyAddGoalPage(String text)
        {
            IWebElement element=_driver.FindElement(By.XPath("//label[contains(@for,'"+text+"')]"));
            BaseMethods.webelementverify(element);
          
        }

        public void gotoGoalPage()
        {
            HomePage home = new HomePage(_driver);
            home.EperformReferenceMaterialArrowIcon.Click();
            home.EperformGoalsOption.Click();
              }

        public void manageGoalPage()
        {
            BaseMethods.webelementverify(EperformGoalNameText);
            BaseMethods.webelementverify(EperformGoalDescriptionText);
            BaseMethods.webelementverify(EperformTypePillarText);
            BaseMethods.webelementverify(EperformPillarId);
            EperformPillarId.Click();
            BaseMethods.webelementverify(EperformPillarFirstList);
            foreach (IWebElement element in EperformPillarList)
            {
                BaseMethods.webelementverify(element);
            }
            BaseMethods.webelementverify(EperformGoalRatedText);
            BaseMethods.webelementverify(EperformMeasureIdText);
            BaseMethods.webelementverify(EperformMeasureId);
            EperformMeasureId.Click();
            BaseMethods.webelementverify(EperformMeasureFirstList);
            foreach(IWebElement MeasureList in EperformMeasureList)
            {
                BaseMethods.webelementverify(MeasureList);
            }
            BaseMethods.webelementverify(EperformParentGoalText);
            BaseMethods.webelementverify(EperformParentGoalId);
            EperformParentGoalId.Click();
            foreach(IWebElement ParentGoalList in EperformParentGoalList)
            {
                BaseMethods.webelementverify(ParentGoalList);
            }
            BaseMethods.webelementverify(EperformGoalTypeText);
            BaseMethods.webelementverify(EperformGoalTypeId);
            EperformGoalTypeId.Click();
            foreach (IWebElement GoalTypeList in EperformGoalTypeList)
            {
                BaseMethods.webelementverify(GoalTypeList);
            }
            BaseMethods.webelementverify(EperformActivetext);
            BaseMethods.webelementverify(EperformActiveYesText);
            BaseMethods.verifyWebElement(EperformSubmitButton, "The Submit button is not displayed in manage goal", "The Submit button is  displayed in manage goal");
            BaseMethods.verifyWebElement(EperformCancelButton, "The cancel button is not displayed in manage goal", "The cancel button is displayed in manage goal");
        }
        public void createGoal()
        {

            FormTemplatePage formTemplatePage = new FormTemplatePage(_driver);
          //  DataRow data = ExcelData.GetData_DataTable("EReference_TESTDATA", SheetName, "KeyName", keyword).Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceGoals", "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                nametext = data["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                EperformSubmitButton.Click();
                BaseMethods.webelementverify(EperformErrorMessageText);
                BaseMethods.webelementverify(EperformNameTextFiledErrorMessage);
                BaseMethods.webelementverify(EperformDescriptionTextFieldErrorMessage);
                EperformGoalNameTextBox.SendKeys(nametext);
                EperformDescriptionTextBox.SendKeys(data["Description"].ToString());
                EperformPillarId.Click();
                BaseMethods.DdlSelectByText(EperformPillarId, data["Pillar"].ToString());
                if (data["IsRated"].ToString() == "Yes")
                {
                    EperformRatedYesRadioButton.Click();
                }
                else
                {
                    EperformRatedNoRadioButton.Click();
                }
                EperformMeasureId.Click();
                BaseMethods.DdlSelectByText(EperformMeasureId, data["Measure"].ToString());
                EperformParentGoalId.Click();
                BaseMethods.DdlSelectByText(EperformParentGoalId, data["ParentGoal"].ToString());
                IWebElement element = _driver.FindElement(By.XPath("//option[text()='" + data["ParentGoal"].ToString() + "']"));
               // BaseMethods.webelementverify(element);
                //Select the Goal Type
                if (data["Goal Type"].ToString() == "Organisation Goal")
                {
                    EperformGoalTypeId.Click();
                    BaseMethods.DdlSelectByText(EperformGoalTypeId, data["Goal Type"].ToString());
                }
                else
                {
                    EperformGoalTypeId.Click();
                    BaseMethods.DdlSelectByText(EperformGoalTypeId, data["Goal Type"].ToString());
                    _driver.FindElement(By.XPath("//label[contains(text(),'" + data["Position Goal"].ToString() + "')]")).Click();
                }
                if (data["IsActive"].ToString() == "Yes")
                {
                    EperformActiveYesRadioButton.Click();
                }
                else
                {
                    EperformActiveNoRadioButton.Click();
                }
                EperformSubmitButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformSuccessMessageText);
                formTemplatePage.searchItem(nametext);
                EperformViewHierarachyLink.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperfromGoalHirarchyMessage);
                EperformCloseButton.Click();
                Thread.Sleep(2000);
                if (data["samenamecreateactiveinactive"].ToString() == "yes")
                {
                   
                    samenamecreateactiveinactive();
                    Thread.Sleep(2000);
                    formTemplatePage.searchItem(nametext);
                    BaseMethods.webelementverify(EperformName);

                }
                else
                {

                }
            }
          
            
        }

        public void samenamecreateactiveinactive()
        {
            FormTemplatePage formTemplatePage = new FormTemplatePage(_driver);
            //  DataRow data = ExcelData.GetData_DataTable("EReference_TESTDATA", SheetName, "KeyName", keyword).Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceGoals", "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                EperformAddGoalButton.Click();
                nametext = data["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

                EperformGoalNameTextBox.SendKeys(nametext);
                EperformDescriptionTextBox.SendKeys(data["Description"].ToString());
                EperformPillarId.Click();
                BaseMethods.DdlSelectByText(EperformPillarId, data["Pillar"].ToString());
                if (data["IsRated"].ToString() == "Yes")
                {
                    EperformRatedYesRadioButton.Click();
                }
                else
                {
                    EperformRatedNoRadioButton.Click();
                }
                EperformMeasureId.Click();
                BaseMethods.DdlSelectByText(EperformMeasureId, data["Measure"].ToString());
                EperformParentGoalId.Click();
                BaseMethods.DdlSelectByText(EperformParentGoalId, data["ParentGoal"].ToString());
                IWebElement element = _driver.FindElement(By.XPath("//option[text()='" + data["ParentGoal"].ToString() + "']"));
               // ExtentReport.test.Log(LogStatus.Pass, element.Text+ " is displayed");
                //Select the Goal Type
                if (data["Goal Type"].ToString() == "Organisation Goal")
                {
                    EperformGoalTypeId.Click();
                    BaseMethods.DdlSelectByText(EperformGoalTypeId, data["Goal Type"].ToString());
                }
                else
                {
                    EperformGoalTypeId.Click();
                    BaseMethods.DdlSelectByText(EperformGoalTypeId, data["Goal Type"].ToString());
                    _driver.FindElement(By.XPath("//label[contains(text(),'" + data["Position Goal"].ToString() + "')]")).Click();
                }
                if (data["IsActive"].ToString() == "Yes")
                {
                    EperformActiveYesRadioButton.Click();
                }
                else
                {
                    EperformActiveNoRadioButton.Click();
                }
                EperformSubmitButton.Click();
            }
            
        }

        public void parentgoalcreation()
        {
            FormTemplatePage formTemplatePage = new FormTemplatePage(_driver);
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceGoals", "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                nametext = data["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                EperformAddGoalButton.Click();
                EperformGoalNameTextBox.SendKeys(nametext);
                EperformDescriptionTextBox.SendKeys(data["Description"].ToString());
                EperformPillarId.Click();
                BaseMethods.DdlSelectByText(EperformPillarId, data["Pillar"].ToString());
                if (data["IsRated"].ToString() == "Yes")
                {
                    EperformRatedYesRadioButton.Click();
                }
                else
                {
                    EperformRatedNoRadioButton.Click();
                }
                EperformMeasureId.Click();
                BaseMethods.DdlSelectByText(EperformMeasureId, data["Measure"].ToString());
                //Select the Goal Type
                if (data["Goal Type"].ToString() == "Organisation Goal")
                {
                    EperformGoalTypeId.Click();
                    BaseMethods.DdlSelectByText(EperformGoalTypeId, data["Goal Type"].ToString());
                }
                else
                {
                    EperformGoalTypeId.Click();
                    BaseMethods.DdlSelectByText(EperformGoalTypeId, data["Goal Type"].ToString());
                    _driver.FindElement(By.XPath("//label[contains(text(),'" + data["Position Goal"].ToString() + "')]")).Click();
                }
                if (data["IsActive"].ToString() == "Yes")
                {
                    EperformActiveYesRadioButton.Click();
                }
                else
                {
                    EperformActiveNoRadioButton.Click();
                }
                EperformSubmitButton.Click();
                Thread.Sleep(2000);
                formTemplatePage.searchItem(nametext);
                EperformEditBtn.Click();
                EperformParentGoalId.Click();
                IList<IWebElement> element = _driver.FindElements(By.XPath("//option[text()='" + nametext + "']"));

                if (element.Count != 0)
                {
                    ExtentReport.test.Log(LogStatus.Pass, nametext + " is displayed in parent goal dropdown");
                }
                else
                {
                    ExtentReport.test.Log(LogStatus.Pass, nametext + " is not displayed in parent goal dropdown");
                }

                EperformCancelButton.Click();
                Thread.Sleep(3000);
            }
        }
    }




        }

