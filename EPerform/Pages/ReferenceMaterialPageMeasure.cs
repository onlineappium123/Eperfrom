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
    class ReferenceMaterialPageMeasure
    {
        public IWebDriver driver;
        string nametext;
        public ReferenceMaterialPageMeasure(IWebDriver pDriver)
        {
            driver = pDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Measure')]")]
        public IWebElement EperformAddMeasureButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement EperformMeasureNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Description")]
        public IWebElement EperfromDescription { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement EperfromActiveYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement EperfromActiveRadioNoRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MeasureDataTypeId")]
        public IWebElement EperfromDataTypeId { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MeasureDataTypeId")]
        public IList<IWebElement> EperfromDataTypeList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//label[text()='Use Target']/..//input[@id='Dto_IsTargetEnabled']")]
        public IWebElement EperfromTargetCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//label[text()='Use Result']/..//input[@id='Dto_IsResultEnabled']")]
        public IWebElement EperfromUseResulCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//label[text()='Allow N/A Rating']/..//input[@id='Dto_IsNARatingAllowed']")]
        public IWebElement EperfromAllowRatingCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Use Multiplier']")]
        public IWebElement EperfromUseMultiplierCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_NumberOfRanges")]
        public IWebElement EperfromRatingScaleTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "RatingUpdateButton")]
        public IWebElement EperformUpdateButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Ranges_0__Description")]
        public IWebElement EperfromScoreDescriptionTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Ranges_0__Description")]
        public IList<IWebElement> EperfromScoreDescriptionTextBoxList { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Ranges_0__ScoreMultiplier")]
        public IList<IWebElement> EperformScoreMultiplierTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Ranges_0__ScoreMultiplier")]
        public IWebElement EperformScoreMultiplierTextBoxList { get; set; }


        [FindsBy(How = How.Name, Using = "SubmitButton")]
        public IWebElement EperformSubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement EprformCancelButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_TextValue")]
        public IWebElement EperfromDefaultTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Target is Mandatory']")]
        public IWebElement EperformTargetIsMandatoryCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Result is Mandatory']")]
        public IWebElement EperfromResultIsMandatoryCheckBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_CurrencyValue")]
        public IWebElement EperformCurrencyValueTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_DateValue")]
        public IWebElement EperformDataTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PercentValue")]
        public IWebElement EperformPercentValueTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_BoolValue_t")]
        public IWebElement EperfromDefaultYesRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_BoolValue_f")]
        public IWebElement EperformDefaultNoRadioBtn { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_NewOptionName")]
        public IWebElement EperfromOptionsTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add']")]
        public IWebElement EperformAddButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),' Down')]")]
        public IWebElement EperformDownButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),' Up')]")]
        public IWebElement EperformUpButton { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body/div[4]/div/div/div/div[2]/div[2]/div/form/div[7]/div[2]/table/tbody/tr[1]/td[1]")]
        public IWebElement EperformOptionText { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        public IWebElement EperformSaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Delete')])[2]")]
        public IWebElement EperformDeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Edit')]")]
        public IWebElement EPerformEditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),' Error!')]")]
        public IWebElement EperformErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='field-validation-error']")]
        public IWebElement EperformSameTypeErrorMessage { get; set; }

        public void createnewMeasureWithMandatory(string SheetName)
        {
            try
            {
                HomePage home = new HomePage(driver);
                FormTemplatePage formtemplate = new FormTemplatePage(driver);
                DataTable dt = ExcelData.GetData_DataTable("EReference_TESTDATA", SheetName, "Enable", "Yes");
                foreach (DataRow data in dt.Rows)
                {
                    nametext = data["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                    home.EperformReferenceMaterialArrowIcon.Click();
                    home.EperformMeasuresOption.Click();
                    BaseMethods.webelementverify(EperformAddMeasureButton);
                    EperformAddMeasureButton.Click();
                    Thread.Sleep(3000);
                    BaseMethods.webelementverify(EperformSubmitButton);
                    EperformSubmitButton.Click();
                    Thread.Sleep(3000);
                    BaseMethods.webelementverify(EperformErrorMessage);
                    EperformMeasureNameTextbox.SendKeys(nametext);
                    EperfromDescription.SendKeys(data["Description"].ToString());
                    if (data["Active"].ToString() == "Yes")
                    {
                        BaseMethods.verifyWebElement(EperfromActiveYesRadioButton, "Active Yes Button is not displayed", "Active No Button is displayed");
                        EperfromActiveYesRadioButton.Click();
                    }
                    else
                    {
                        BaseMethods.verifyWebElement(EperfromActiveRadioNoRadioButton, "Active No Button is not displayed", "Active No button is displayed");
                        EperfromActiveRadioNoRadioButton.Click();
                    }
                    EperfromDataTypeId.Click();
                    BaseMethods.DdlSelectByText(EperfromDataTypeId, data["Data Type"].ToString());

                    EperfromTargetCheckBox.Click();
                    if (data["Data Type"].ToString() == "Free Text")
                    {
                        EperfromDefaultTextBox.SendKeys(data["Default Target"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Currency")
                    {
                        EperformCurrencyValueTextBox.SendKeys(data["Currency"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Date")
                    {
                        EperformDataTextBox.SendKeys(data["Date"].ToString());

                    }
                    else if (data["Data Type"].ToString() == "Percentage")
                    {
                        EperformPercentValueTextBox.SendKeys(data["Percentage"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Yes/No")
                    {
                        EperfromDefaultYesRadioBtn.Click();
                    }
                    else if (data["Data Type"].ToString() == "Single Select List")
                    {
                        BaseMethods.verifyWebElement(EperformMeasureNameTextbox, "EperformMeasureNameTextbox is not displayed", "EperformMeasureNameTextbox is displayed");
                        EperformMeasureNameTextbox.Clear();
                        EperformMeasureNameTextbox.SendKeys(nametext);
                        EperfromDescription.Clear();
                        BaseMethods.verifyWebElement(EperfromDescription, "EperfromDescription is not displayed", "EperfromDescription is displayed");
                        EperfromDescription.SendKeys(data["Description"].ToString());
                        EperfromActiveYesRadioButton.Click();
                        BaseMethods.verifyWebElement(EperfromScoreDescriptionTextBox, "EperfromScoreDescriptionTextBox is not displayed", "EperfromScoreDescriptionTextBox is displayed");
                        EperfromScoreDescriptionTextBox.SendKeys(data["DescriptionText"].ToString());
                        EperformSubmitButton.Click();
                        Thread.Sleep(2000);
                        BaseMethods.verifyWebElement(EperfromOptionsTextBox, "EperfromOptionsTextBox is not displayed", "EperfromOptionsTextBox is displayed");
                        EperfromOptionsTextBox.SendKeys(data["Single Select List"].ToString());
                        BaseMethods.webelementverify(EperformAddButton);
                        EperformAddButton.Click();
                        Thread.Sleep(2000);
                        EprformCancelButton.Click();
                        Thread.Sleep(2000);
                        formtemplate.searchItem(nametext);
                        Thread.Sleep(2000);
                        singleSelectEditUpDown();
                    }

                    EperformTargetIsMandatoryCheckBox.Click();
                    EperfromUseResulCheckBox.Click();
                    EperfromResultIsMandatoryCheckBox.Click();
                    EperfromAllowRatingCheckBox.Click();
                    EperfromUseMultiplierCheckBox.Click();
                    
                    EperfromRatingScaleTextBox.Clear();
                    EperfromRatingScaleTextBox.SendKeys(data["Ratingscale"].ToString());
                    EperformUpdateButton.Click();
                    Thread.Sleep(3000);

                    int count = Convert.ToInt32(data["Ratingscale"]);
                    for (int i = 0; i < count; i++)
                    {
                        string name = "Dto.Ranges[" + i + "].Description";

                        Thread.Sleep(2000);
                        driver.FindElement(By.Name(name)).SendKeys(data["DescriptionText"].ToString());

                    }
                    int count1 = Convert.ToInt32(data["Ratingscale"]);
                    for (int i = 0; i < count1; i++)
                    {
                        
                         string name = "Dto.Ranges[" + i + "].ScoreMultiplier";
                        driver.FindElement(By.Name(name)).SendKeys(data["MultiplierText"].ToString());

                    }
                    EperformSubmitButton.Click();
                    Thread.Sleep(2000);
                    try
                    {
                        BaseMethods.webelementverify(EperformSuccessMessage);
                    }
                    catch
                    {
                        BaseMethods.webelementverify(EperformSameTypeErrorMessage);

                    }

                }
            }
            catch
            {

                BaseMethods.webelementverify(EperformSuccessMessage);
            }
        }

        public void singleSelectEditUpDown()
        {
            FormTemplatePage formtemplate = new FormTemplatePage(driver);
            //DataRow data = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferencePillar", "KeyName", "ReferncePillar_01").Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferencePillar", "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                EPerformEditButton.Click();
                EperfromOptionsTextBox.SendKeys(data["Description"].ToString());
                EperformAddButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformOptionText);
                EperformDownButton.Click();
                BaseMethods.webelementverify(EperformOptionText);
                EperformUpButton.Click();
                EperformDeleteButton.Click();
                EPerformEditButton.Click();
                EperfromOptionsTextBox.Clear();
                EperfromOptionsTextBox.SendKeys(data["Description"].ToString());
                EperformSaveButton.Click();
                Thread.Sleep(2000);
                EprformCancelButton.Click();
                Thread.Sleep(2000);
            }
        }
        public void createnewMeasureWithoutMandatory(string SheetName)
        {
            try
            {
                HomePage home = new HomePage(driver);
                FormTemplatePage formtemplate = new FormTemplatePage(driver);
                DataTable dt = ExcelData.GetData_DataTable("EReference_TESTDATA", SheetName, "Enable", "Yes");
                foreach (DataRow data in dt.Rows)
                {
                    nametext = data["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                    home.EperformReferenceMaterialArrowIcon.Click();
                    home.EperformMeasuresOption.Click();
                    EperformAddMeasureButton.Click();
                    EperformMeasureNameTextbox.SendKeys(nametext);
                    EperfromDescription.SendKeys(data["Description"].ToString());
                    if (data["Active"].ToString() == "Yes")
                    {
                        EperfromActiveYesRadioButton.Click();
                    }
                    else
                    {
                        EperfromActiveRadioNoRadioButton.Click();
                    }
                    EperfromDataTypeId.Click();
                    BaseMethods.DdlSelectByText(EperfromDataTypeId, data["Data Type"].ToString());

                    EperfromTargetCheckBox.Click();
                    if (data["Data Type"].ToString() == "Free Text")
                    {
                        EperfromDefaultTextBox.SendKeys(data["Default Target"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Currency")
                    {
                        EperformCurrencyValueTextBox.SendKeys(data["Currency"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Date")
                    {
                        EperformDataTextBox.SendKeys(data["Date"].ToString());

                    }
                    else if (data["Data Type"].ToString() == "Percentage")
                    {
                        EperformPercentValueTextBox.SendKeys(data["Percentage"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Yes/No")
                    {
                        EperfromDefaultYesRadioBtn.Click();
                    }
                    else if (data["Data Type"].ToString() == "Single Select List")
                    {
                        EperformMeasureNameTextbox.Clear();
                        EperformMeasureNameTextbox.SendKeys(nametext);
                        EperfromDescription.Clear();
                        EperfromDescription.SendKeys(data["Description"].ToString());
                        EperfromActiveYesRadioButton.Click();
                        EperfromScoreDescriptionTextBox.SendKeys(data["DescriptionText"].ToString());
                        EperformSubmitButton.Click();
                        Thread.Sleep(2000);
                        EperfromOptionsTextBox.SendKeys(data["Single Select List"].ToString());
                        EperformAddButton.Click();
                        Thread.Sleep(2000);
                        EprformCancelButton.Click();


                    }
                    EperfromUseResulCheckBox.Click();
                    EperfromAllowRatingCheckBox.Click();
                    EperfromUseMultiplierCheckBox.Click();
                    
                   
                    EperfromRatingScaleTextBox.Clear();
                    EperfromRatingScaleTextBox.SendKeys(data["Ratingscale"].ToString());
                    EperformUpdateButton.Click();
                    int count = Convert.ToInt32(data["Ratingscale"]);
                    for (int i = 0; i < count; i++)
                    {
                        string name = "Dto.Ranges[" + i + "].Description";
                        driver.FindElement(By.Name(name)).SendKeys(data["DescriptionText"].ToString());

                    }
                    int count1 = Convert.ToInt32(data["Ratingscale"]);
                    for (int i = 0; i < count1; i++)
                    {

                        string name = "Dto.Ranges[" + i + "].ScoreMultiplier";
                        driver.FindElement(By.Name(name)).SendKeys(data["MultiplierText"].ToString());
                      
                    }
                    Thread.Sleep(2000);
                    try
                    {
                        BaseMethods.webelementverify(EperformSuccessMessage);
                    }
                    catch
                    {
                        BaseMethods.webelementverify(EperformSameTypeErrorMessage);
                    }

                }

            }
            catch
            {

                BaseMethods.webelementverify(EperformAddButton);
            }
        }
        public void sameMeasure(string SheetName, string Keyname)
        {
            try
            {
                HomePage home = new HomePage(driver);
                FormTemplatePage formtemplate = new FormTemplatePage(driver);
                DataTable dt = ExcelData.GetData_DataTable("EReference_TESTDATA", SheetName, "Enable", "Yes");
                foreach (DataRow data in dt.Rows)
                {
                    nametext = data["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                    home.EperformReferenceMaterialArrowIcon.Click();
                    home.EperformMeasuresOption.Click();
                    EperformAddMeasureButton.Click();
                    Thread.Sleep(3000);
                    EperformSubmitButton.Click();
                    Thread.Sleep(3000);
                    BaseMethods.webelementverify(EperformErrorMessage);
                    EperformMeasureNameTextbox.SendKeys(nametext);
                    EperfromDescription.SendKeys(data["Description"].ToString());
                    if (data["Active"].ToString() == "Yes")
                    {
                        EperfromActiveYesRadioButton.Click();
                    }
                    else
                    {
                        EperfromActiveRadioNoRadioButton.Click();
                    }
                    EperfromDataTypeId.Click();
                    BaseMethods.DdlSelectByText(EperfromDataTypeId, data["Data Type"].ToString());

                    EperfromTargetCheckBox.Click();
                    if (data["Data Type"].ToString() == "Free Text")
                    {
                        EperfromDefaultTextBox.SendKeys(data["Default Target"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Currency")
                    {
                        EperformCurrencyValueTextBox.SendKeys(data["Currency"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Date")
                    {
                        EperformDataTextBox.SendKeys(data["Date"].ToString());

                    }
                    else if (data["Data Type"].ToString() == "Percentage")
                    {
                        EperformPercentValueTextBox.SendKeys(data["Percentage"].ToString());
                    }
                    else if (data["Data Type"].ToString() == "Yes/No")
                    {
                        EperfromDefaultYesRadioBtn.Click();
                    }
                    else if (data["Data Type"].ToString() == "Single Select List")
                    {
                        EperformMeasureNameTextbox.Clear();
                        EperformMeasureNameTextbox.SendKeys(nametext);
                        EperfromDescription.Clear();
                        EperfromDescription.SendKeys(data["Description"].ToString());
                        EperfromActiveYesRadioButton.Click();
                        EperfromScoreDescriptionTextBox.SendKeys(data["DescriptionText"].ToString());
                        EperformSubmitButton.Click();
                        Thread.Sleep(2000);
                        EperfromOptionsTextBox.SendKeys(data["Single Select List"].ToString());
                        EperformAddButton.Click();
                        Thread.Sleep(2000);
                        EprformCancelButton.Click();
                        Thread.Sleep(2000);
                        formtemplate.searchItem(nametext);
                        Thread.Sleep(2000);
                        singleSelectEditUpDown();
                    }

                    EperformTargetIsMandatoryCheckBox.Click();
                    EperfromUseResulCheckBox.Click();
                    EperfromResultIsMandatoryCheckBox.Click();
                    EperfromAllowRatingCheckBox.Click();
                    EperfromUseMultiplierCheckBox.Click();
                   
                    EperfromRatingScaleTextBox.Clear();
                    EperfromRatingScaleTextBox.SendKeys(data["Ratingscale"].ToString());
                    EperformUpdateButton.Click();
                    int count1 = Convert.ToInt32(data["Ratingscale"]);
                    for (int i = 0; i < count1; i++)
                    {

                        string name = "Dto.Ranges[" + i + "].ScoreMultiplier";
                        driver.FindElement(By.Name(name)).SendKeys(data["MultiplierText"].ToString());

                    }
                    Thread.Sleep(4000);
                    EperfromScoreDescriptionTextBox.SendKeys(data["DescriptionText"].ToString());
                    EperformSubmitButton.Click();
                    Thread.Sleep(2000);
                    try
                    {
                        BaseMethods.webelementverify(EperformSuccessMessage);
                    }
                    catch
                    {
                        BaseMethods.webelementverify(EperformSameTypeErrorMessage);

                    }

                }
            }
            catch
            {

                BaseMethods.webelementverify(EperformSuccessMessage);
            }
        }

    }
}
