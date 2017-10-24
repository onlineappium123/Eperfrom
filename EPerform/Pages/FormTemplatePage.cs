
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using ePerform.Library.Extent_Reports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ePerform.Pages;
using EPerform.Library;
using System.Collections;
using ePerfrom.Library;

using EPerform.Library.Excel;
using System.Data;
using System.Threading;

namespace EPerform.Pages
{
    class FormTemplatePage
    {
        IWebDriver _driver;


        public FormTemplatePage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        //Eperform Keyword Text
        [FindsBy(How = How.XPath, Using = "//label[text()='Keyword']")]
        public IWebElement EperformKeyWordText { get; set; }


        //Eperform FormTemplate search Textbox
        [FindsBy(How = How.Id, Using = "Keywords")]
        public IWebElement EperformFormTemplateSearchTextBox { get; set; }

        //Eperform FormTemplate search button
        [FindsBy(How = How.XPath, Using = "//button[text()='Search']")]
        public IWebElement EperformFormTemplateSearchButton { get; set; }

        //Eperform FormTemplate Add formTemplate button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Form Template')]")]
        public IWebElement EperformAddFormTemplateButton { get; set; }


        //Eperform FormTemplate Name Text
        [FindsBy(How = How.XPath, Using = "//span[text()='Name']")]
        public IWebElement EperformNameText { get; set; }


        //Eperform FormTemplate Active Text
        [FindsBy(How = How.XPath, Using = "//span[text()='Active']")]
        public IWebElement EperformActiveText { get; set; }



        //Eperform FormTemplate Actions Text
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Actions')]")]
        public IWebElement EperormActionsText { get; set; }

        //Eperform FormTemplate Edit Button
        [FindsBy(How = How.XPath, Using = "//a[@class='btn-xs btn btn-darkblue']")]
        public IWebElement EperformEditButton { get; set; }

        //Eperform FormTemplate Edit Button
        [FindsBy(How = How.XPath, Using = "//a[@class='btn-xs btn btn-darkblue']")]
        public IList<IWebElement> EperformEditListButton { get; set; }



        //Eperform FormTemplate Manage Form text
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Form')]")]
        public IWebElement EperformManageFormText { get; set; }


        //Eperform Denotes a mandatory field Text
        [FindsBy(How = How.XPath, Using = "(//label[@class='control-label col-sm-4 col-lg-3'])[1]")]
        public IWebElement EperformDenotesamandatoryfieldText { get; set; }

        //Eperform Manage Form Name Text
        [FindsBy(How = How.XPath, Using = "(//label[@class='control-label col-sm-4 col-lg-3'])[2]")]
        public IWebElement EperformManageFormNameText { get; set; }


        //Eperform Manage Form Is Active Text
        [FindsBy(How = How.XPath, Using = "(//label[@class='control-label col-sm-4 col-lg-3'])[3]")]
        public IWebElement EperformManageFormIsActiveText { get; set; }


        //Eperform Manage Form Form Type Text
        [FindsBy(How = How.XPath, Using = "(//label[@class='control-label col-sm-4 col-lg-3'])[4]")]
        public IWebElement EperformManageFormFormTypeText { get; set; }


        //Eperform Name textbox
        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement EperformNameTextBox { get; set; }

        //Eperform Yes RadioButton
        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement EperformYesRadioButton { get; set; }


        //Eperform No RadioButton
        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement EperformNoRadioButton { get; set; }


        //Eperform Select formtype
        [FindsBy(How = How.Id, Using = "Dto_FormTypeId")]
        public IWebElement EperformSelectformtype { get; set; }

        //Eperform Submit button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement EperformSubmitButton { get; set; }



        //Eperform Cancel button
        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement EperformCancelButton { get; set; }


        //Eperform GobalQuestion SubmitButton
        [FindsBy(How = How.Name, Using = "OnSubmitAction")]
        public IWebElement EperformGobalQuestionSubmitButton { get; set; }



        //Eperform  Yes Text
        [FindsBy(How = How.XPath, Using = "//label[text()='Yes']")]
        public IWebElement EperformYesText { get; set; }


        //Eperform Reference Text
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }




        //Eperform Eperform Success Message
        [FindsBy(How = How.XPath, Using = "//th[text()='Reference']")]
        public IWebElement EperformReferenceText { get; set; }

        //Eperform Question text 
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Question')]")]
        public IWebElement EperformQuestionText { get; set; }


        //Eperform Type text 
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Type')]")]
        public IWebElement EperformTypeText { get; set; }



        //Eperform Mandatory text 
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Mandatory')]")]
        public IWebElement EperformMandatoryText { get; set; }


        //Eperform Addglobalquestion Button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add global question')]")]
        public IWebElement EperformAddglobalquestionButton { get; set; }


        //Eperform Preview Form Link
        [FindsBy(How = How.XPath, Using = "//a[text()='Preview Form']")]
        public IWebElement EperformPreviewFormLink { get; set; }





        //Eperform  No Text
        [FindsBy(How = How.XPath, Using = "//label[text()='No']")]
        public IWebElement EperformNoText { get; set; }


        //Eperform GlobalQuestionsSearchTextBox

        [FindsBy(How = How.Id, Using = "Keywords")]
        public IWebElement EperformGlobalQuestionsSearchTextBox { get; set; }

        //Eperform GlobalQuestion Text

        [FindsBy(How = How.XPath, Using = "//h3[text()='Global Questions']")]
        public IWebElement EperformGlobalQuestionText { get; set; }

        //Eperform GlobalQuestion Search Button
        [FindsBy(How = How.XPath, Using = "//button[text()='Search']")]
        public IWebElement EperformGlobalQuestionSearchButton { get; set; }


        //Eperform GlobalQuestion CheckBox
        [FindsBy(How = How.Name, Using = "SelectedObjectInstanceIds")]
        public IWebElement EperformGlobalQuestionCheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "SelectedObjectInstanceIds")]
        public IList<IWebElement> EperformGlobalQuestionCheckBoxList{ get; set; }

        //Eperform GlobalQuestion Delete Button
        [FindsBy(How = How.XPath, Using = " //a[contains(text(),'Delete')]")]
        public IWebElement EperformGlobalQuestionDeleteButton { get; set; }


        //Eperform Add question button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add question')]")]
        public IWebElement EperformAddquestionButton { get; set; }

        //Eperform RdoSingleItemSelect
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_0")]
        public IWebElement RdoSingleItemSelect { get; set; }

        //Eperform Add Question Ok Button
        [FindsBy(How = How.XPath, Using = "//button[text()='OK']")]
        public IWebElement EperformAddQuestionOkButton { get; set; }

        //Eperform Gobal Question Cancel Button
        [FindsBy(How = How.XPath, Using = "//button[text()='Cancel']")]
        public IWebElement EperformGobalQuestionCancelButton { get; set; }

        //Eperform Dto_Reference Testbox
        [FindsBy(How = How.Id, Using = "Dto_Reference")]
        public IWebElement EperformReferenceTestbox { get; set; }

        //  
        [FindsBy(How = How.XPath, Using = ".//*[@id='mceu_5']/button")]
        public IWebElement EperformLabelText { get; set; }

        //ePeform Development Activity
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'ePeform Development Activity')]")]
        public IWebElement EPeformDevelopmentActivityText { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement CloseButton_Popup { get; set; }


        /// <summary>
        /// Eperform nameSort in the formtemplate
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//a[@class='linkToModal link'])[1]")]
        public IWebElement EperformNameSortText { get; set; }

        /// <summary>
        /// Eperform ActiveSort in the formtemplate
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible'])[1]")]
        public IWebElement EperformActiveSortText { get; set; }

        /// <summary>
        /// Eperform Preview formas Listverify
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_TaskFlowRoleId")]
        public IList<IWebElement> EperformPreviewFormasList { get; set; }

        /// <summary>
        /// Eperform formType ListVerify
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_FormTypeId")]
        public IList<IWebElement> EperformFormTypeList { get; set; }

        /// <summary>
        /// Eperform PreviewForm Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//div[@class='box-title']")]
        public IWebElement EperformPreviewFormText { get; set; }

        /// <summary>
        /// Eperform Back Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[text()='Back']")]
        public IWebElement EperformBackButton { get; set; }

        /// <summary>
        /// Eperform GobalQuestionAccountNameText
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_StringDtos_0__Value']")]
        public IWebElement EperformGobalQuestionText { get; set; }

        /// <summary>
        /// Eperform PreviewFormAsvDropdown Icon
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_TaskFlowRoleId")]
        public IWebElement EperformPreviewFormAsDropdownIcon { get; set; }

        /// <summary>
        /// Eperform gobalquestionNameDropDown
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_GuidDtos_0__Value")]
        public IList<IWebElement> EperformGobalQuestionNameDropDown { get; set; }

        /// <summary>
        /// Eperform gobalquestionNameDropDown
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_GuidDtos_0__Value")]
        public IWebElement EperformGobalQuestionNameDropDownIcon { get; set; }

        /// <summary>
        /// 'Multi Line Text Area' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_1")]
        public IWebElement EperformRdoMultiLineTextArea;

        /// <summary>
        /// Eperform ReadOnly yes RadioBtn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsReadOnly_t")]
        public IWebElement EperformReadOnlyYesRadioBtn { get; set; }

        /// <summary>
        /// Eperform ReadOnly No RadioBtn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsReadOnly_f")]
        public IWebElement EperformReadOnlyNoRadioBtn { get; set; }

        /// <summary>
        /// Eperform Required Yes radio Btn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsRequired_t")]
        public IWebElement EperformRequiredYesRadioBtn { get; set; }

        /// <summary>
        /// Eperform Required No radio Btn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsRequired_f")]
        public IWebElement EperformReqiredNoRadioBtn { get; set; }

        /// <summary>
        /// Eperfrom Maximum Length textbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_MaxLength")]
        public IWebElement EperformMaximumLengthTextBox { get; set; }

        /// <summary>
        /// Eperform Characters Radio Btn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_MaxLengthType_0")]
        public IWebElement EperformCharactersRadioBtn { get; set; }

        /// <summary>
        ///Eperform Words Radio Btn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_MaxLengthType_1")]
        public IWebElement EperformWordsRadioBtn { get; set; }

       
        /// <summary>
        /// 'Single Line TextBox' Textbox
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_0']/../following-sibling::span/input")]
        public IWebElement EperformTxtSingleLineTextBox { get; set; }

        /// <summary>
        /// 'Submit' Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement eleBtnSubmit { get; set; }

        /// <summary>
        /// 'Multi Line Text Area' Text area
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//input[@id='Dto_SelectedComponentType_1']/../following-sibling::span/textarea")]
        public IWebElement EperformTxtMultiLineTextArea { get; set; }

        /// <summary>
        /// 'Select Single Item from a List' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_2")]
        public IWebElement RdoSelectSingleItem { get; set; }

        /// <summary>
        /// Eperform Options Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Options')]")]
        public IWebElement EperformOptionsIcon { get; set; }

        /// <summary>
        /// Eperform Answerformat DropDown Icon
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_AnswerFormat")]
        public IWebElement EperformAnswerformatDropDownIcon { get; set; }

        /// <summary>
        /// Eperform Answerformat DropDown Text
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_AnswerFormat")]
        public IList<IWebElement> EperformAnswerformatDropDownText { get; set; }

        /// <summary>
        /// Eperform SelectMultipleItemsfromaList Radio Btn
        /// </summary>
        /// <param name="text"></param>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_3")]
        public IWebElement EperformSelectMultipleItemsfromaListRadioBtn { get; set; }

        /// <summary>
        /// 'Numeric' Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_4")]
        public IWebElement RdoNumeric { get; set; }

        /// <summary>
        /// LabelText
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_Label_ifr")]
        public IWebElement eleTxtLabel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_5")]
        public IWebElement EperformYesNoRadioBtn { get; set; }
        /// <summary>
        /// Eperform Component Type Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//div[@class='form-control-static'])[2]")]
        public IWebElement EperformComponentTypeText { get; set; }

        /// <summary>
        /// Eperform Data Radio Btn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_6")]
        public IWebElement EperformDataRadioBtn { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Manage Question']")]
        public IWebElement EpfromManageQuestionButton { get; set; }
        /// <summary>
        /// Eperform FileUpload Radio Btn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectedComponentType_7")]
        public IWebElement EperformFileUploadRadioBtn { get; set; }


        /// <summary>
        /// Eperform FileUpload TextBox
        /// </summary>
        [FindsBy(How = How.XPath, Using = "D//input[@type='file']")]
        public IWebElement EperformFileUploadTextBox { get; set; }

        /// <summary>
        /// Eperfrom Mandatory Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Mandatory')]")]
        public IWebElement EperfromMandatoryText { get; set; }
        /// <summary>
        /// Eperform Completed By Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Completed By')]")]
        public IWebElement EperformCompletedByText { get; set; }

        /// <summary>
        /// Eperfrom Actions Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Actions')]")]
        public IWebElement EperfromActionsText { get; set; }
        /// <summary>
        /// Eperform Down Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Down')]")]
        public IWebElement EperformDownButton { get; set; }
        /// <summary>
        /// Eperform Up Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Up')]")]
        public IWebElement EperformUpButton { get; set; }

        /// <summary>
        /// Eperform Preview Link Textformat
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//span[@class='question-label'])[1]")]
        public IWebElement EperformPreviewLinkTextformat { get; set; }

        /// <summary>
        /// Eperform CheckBox Role Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//div[@class='input-list-container'])[1]//input")]
        public IList<IWebElement> EperformCheckBoxRoleButton { get; set; }

        /// <summary>
        /// Eperform CheckBox RoleTwo Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//div[@class='input-list-container'])[2]//input")]
        public IList<IWebElement> EperformCheckBoxRoleTwoButton { get; set; }


        /// <summary>
        /// Add Global Question Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add global question')]")]
        public IWebElement BtnAddGlobalQuestion { get; set; }

        /// <summary>
        /// EperformGobalQuestionActiveText
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Active')]")]
        public IWebElement EperformGobalQuestionActiveText { get; set; }

        /// <summary>
        /// EperformGlobalQuestionAddedText
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible footable-first-column'])[1]")]
        public IWebElement EperformGlobalQuestionAddedText { get; set; }
        /// <summary>
        /// EperformPreviewNameText
        /// </summary>Dto_StringDtos_0__Value"
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_StringDtos_0__Value']")]
        public IWebElement EperformPreviewNameText { get; set; }

        /// <summary>
        /// Eperform AddOption Button
        /// </summary>

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Options')]")]
        public IWebElement EperformAddOptionButton { get; set; }

        /// <summary>
        /// Eperform OptionTextBox
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_AnswerOptions")]
        public IWebElement EperformOptionTextBox { get; set; }

        /// <summary>
        /// EperformOptionYesText
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//td[@class='footable-visible']")]
        public IWebElement EperformOptionYesText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@class='control-label col-sm-4 col-lg-3']")]
        public IList<IWebElement> EperformGobalQuestionNameTEXT { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='mce-ico mce-i-bullist']")]
        public IWebElement LabelhandleFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Error!')]")]
        public IWebElement EperformErrorMessageText { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='question-label']")]
        public IWebElement EperformPreviewLinkNameText { get; set; }

        string nametext = string.Empty;
        string formSubmitType = "created";

        public void TxtLabel(string value)
        {
            _driver.SwitchTo().Frame(eleTxtLabel);
            //IWebElement body = _driver.FindElement(By.Id("tinymce"));
            IWebElement body = _driver.FindElement(By.CssSelector("body"));
            body.SendKeys(value);
            _driver.SwitchTo().ParentFrame();
        }


        //Eperform Verify the formType
        public void verifyFormType(String text)
        {
            IWebElement page = _driver.FindElement(By.XPath("//div[contains(text(),'" + text + "')]"));
            Assert.IsTrue(page.Displayed, text + "is not displayed ");
            ExtentReport.test.Log(LogStatus.Pass, text + "text is displayed in the manage form page");
        }

        //Eperform To handleLocalQuestionSingleLineTextBox Method
        public void handleLocalQuestionSingleLineTextBox(String refrence, String label, String Requiredption, String ReadOnlyOption)
        {
            try
            {

                SelectQuestionTypePage selectquestion = new SelectQuestionTypePage(_driver);
                EperformAddquestionButton.Click();
                Assert.IsTrue(RdoSingleItemSelect.Displayed, "Radio Single Line TextBox is not displayed Select Question Type");
                ExtentReport.test.Log(LogStatus.Pass, "Radio Single Line TextBox is displayed Select Question Type");
              
                RdoSingleItemSelect.Click();
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                Assert.IsTrue(EperformReferenceTestbox.Displayed, "Eperform Reference Testbox is not displayed Select Question Type");
                ExtentReport.test.Log(LogStatus.Pass, "Eperform Reference Testbox is displayed Select Question Type");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);

                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (Requiredption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                EperformSubmitButton.Click();
                System.Threading.Thread.Sleep(2000);
                try { 
                
                }
                catch
                {
                    EperformCancelButton.Click();
                }
                System.Threading.Thread.Sleep(2000);
                Assert.IsTrue(EperformGlobalQuestionDeleteButton.Displayed, "Eperform GlobalQuestion Delete Button is not displayed in manage form");
                ExtentReport.test.Log(LogStatus.Pass, "Eperform GlobalQuestion Delete Button is displayed in manage form");
            }
            catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }
        }
        //Eperform To handleAddLocalQuestionMultiLineTextArea Method
        public void handleAddLocalQuestionMultiLineTextArea(String refrence, String maxlength, String label, String Requiredption, String ReadOnlyOption)
        {
            try
            {
                SelectQuestionTypePage selectquestion = new SelectQuestionTypePage(_driver);

                EperformAddquestionButton.Click();
                EperformRdoMultiLineTextArea.Click();

                System.Threading.Thread.Sleep(2000);
                eleBtnSubmit.Click();
                System.Threading.Thread.Sleep(2000);

                BaseMethods.webelementverify(EperformComponentTypeText);

                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (Requiredption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                EperformMaximumLengthTextBox.SendKeys(maxlength);
                EperformSubmitButton.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                BaseMethods.verifyWebElement(EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");


            }
            catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }

        }

        //Eperform To handleLocalQuestionSelectSingleItemfromaList Method
        public void handleLocalQuestionSelectSingleItemfromaList(String refrence, String Answerformat, String label, String RequiredOption, String ReadOnlyOption,String Option)
        {
            try {
                EperformAddquestionButton.Click();
                RdoSelectSingleItem.Click();
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                Assert.IsTrue(EperformOptionsIcon.Displayed, "Eperform Options Icon is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, "Eperform Options Icon is displayed");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (RequiredOption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }

                EperformAnswerformatDropDownIcon.Click();
                foreach (IWebElement element in EperformAnswerformatDropDownText)
                {

                    Assert.IsTrue(element.Displayed,
                            element.Text + " is  not dispalyed");
                    ExtentReport.test.Log(LogStatus.Pass, element.Text + "is displayed in manage form");
                }
                BaseMethods.DdlSelectByValue(EperformAnswerformatDropDownIcon, Answerformat);
                System.Threading.Thread.Sleep(2000);
                eleBtnSubmit.Click();

                EperformOptionsIcon.Click();
                EperformAddOptionButton.Click();
                EperformOptionTextBox.SendKeys(Option);
                eleBtnSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                EpfromManageQuestionButton.Click();
               EperformCancelButton.Click();
                System.Threading.Thread.Sleep(2000);
            } catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }




        }
        //Eperform To handleLocalQuestionSelectMultipleItemsfromaList Method
        public void handleLocalQuestionSelectMultipleItemsfromaList(String refrence, String label, String RequiredOption, String ReadOnlyOption)
        {
            try {
                EperformAddquestionButton.Click();
                EperformSelectMultipleItemsfromaListRadioBtn.Click();
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (RequiredOption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                eleBtnSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                EperformCancelButton.Click();
                System.Threading.Thread.Sleep(2000);
            } catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }

        }
        //Eperform To handleNumeric Method
        public void handleNumeric(String refrence, String label, String RequiredOption, String ReadOnlyOption)
        {
            try {
                EperformAddquestionButton.Click();
                RdoNumeric.Click();
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (RequiredOption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                eleBtnSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                System.Threading.Thread.Sleep(2000);
            } catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }
        }

        //Eperform To handleNumeric Method
        public void handleYesNo(String refrence, String label, String RequiredOption, String ReadOnlyOption)
        {
            try {
                EperformAddquestionButton.Click();
                EperformYesNoRadioBtn.Click();
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (RequiredOption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                eleBtnSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
            }
            catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }

        }

        //Eperform To handleNumeric Method
        public void handleData(String refrence, String label, String RequiredOption, String ReadOnlyOption)
        {
            try
            {
                EperformAddquestionButton.Click();
                EperformDataRadioBtn.Click();
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (RequiredOption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                EperformAnswerformatDropDownIcon.Click();
                foreach (IWebElement element in EperformAnswerformatDropDownText)
                {

                    Assert.IsTrue(element.Displayed,
                            element.Text + " is  not dispalyed");
                    ExtentReport.test.Log(LogStatus.Pass, element.Text + "is displayed in manage form");
                }
                eleBtnSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
            }
            catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }

        }

        public void handleAddLocalQuestionFileUpload(String refrence, String label, String RequiredOption, String ReadOnlyOption)
        {
            try {
                EperformAddquestionButton.Click();
                EperformFileUploadRadioBtn.Click();
                //EperformFileUploadTextBox.SendKeys("C:\\Users\\vijay.pandit\\Documents\\Visual Studio 2015\\Projects\\EPerform\\AutoIt\\Sample.txt");
                eleBtnSubmit.Click();
                Assert.IsTrue(EperformComponentTypeText.Displayed, "Component Type is not displayed");
                ExtentReport.test.Log(LogStatus.Pass, EperformComponentTypeText.Text + "is displayed");
                EperformReferenceTestbox.SendKeys(refrence);
                System.Threading.Thread.Sleep(2000);
                LabelhandleFrame.Click();
                TxtLabel(label);
                if (ReadOnlyOption == "Yes")
                {
                    EperformReadOnlyYesRadioBtn.Click();
                }
                if (RequiredOption == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
                eleBtnSubmit.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");

            }
            catch (Exception e)
            {

                ExtentReport.test.Log(LogStatus.Fatal, "Exception Message: " + e.Message);
            }
        }

        public void addformtemplateQuestionnaireForm(String SheetName)
        {


            HomePage homepage = new HomePage(_driver);
            DataTable drt = ExcelData.GetData_DataTable("EP_TESTDATA", SheetName, "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                nametext = data["FormType"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                homepage.EperformSystemConfigurationArrowIcon.Click();
                homepage.EperformFormTemplatesOption.Click();
                System.Threading.Thread.Sleep(2000);
                EperformAddFormTemplateButton.Click();
                BaseMethods.verifyWebElement(EperformNameTextBox, "Eperform Name TextBox is not displayed in manage form", "Eperform Name TextBox is displayed in manage form");
                System.Threading.Thread.Sleep(2000);
                EperformNameTextBox.SendKeys(data["FormName"].ToString());
                if (data["Active"].ToString() == "Yes")
                {
                    EperformYesRadioButton.Click();
                }
                else
                {
                    EperformNoRadioButton.Click();
                }
                EperformSelectformtype.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.DdlSelectByValue(EperformSelectformtype, data["FormType"].ToString());
                EperformSubmitButton.Click();
                System.Threading.Thread.Sleep(2000);
                verifyFormType("ePeform Questionnaire Form");
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");

               createLocalQuestion();
                EperformPreviewFormLink.Click();
                BaseMethods.webelementverify(EperformPreviewLinkNameText);
               EperformBackButton.Click();

                addGlobalQuestion();
                DataTable drt1 = ExcelData.GetData_DataTable("EP_TESTDATA", "Edit", "Enable", "Yes");
                foreach (DataRow data1 in drt1.Rows)
                {
                    edit(data1["EditQuestionName"].ToString());
                }
                BaseMethods.verifyWebElement(EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");
               EperformGlobalQuestionDeleteButton.Click();
                EperformAddQuestionOkButton.Click();
                Thread.Sleep(2000);
                DataTable drt2 = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "Enable", "Yes");
                foreach (DataRow dr in drt2.Rows)
                {

                    handleLocalQuestionSingleLineTextBox(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                }
                EperformPreviewFormLink.Click();
                BaseMethods.webelementverify(EperformPreviewLinkTextformat);
                EperformBackButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.verifyWebElement(EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");
                BaseMethods.verifyWebElement(EperformEditButton, "Eperform Edit Button is not displayed in manage form", "Eperform Edit Button is displayed in manage form");
                BaseMethods.verifyWebElement(EperformDownButton, "Eperform Down Button is not displayed in manage form", "Eperform Down Button is displayed in manage form");
                BaseMethods.verifyWebElement(EperformUpButton, "Eperform Up Button is not displayed in manage form", "Eperform Up Button is displayed in manage form");
               EperformDownButton.Click();
                EperformPreviewFormLink.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformPreviewLinkTextformat);
                EperformBackButton.Click();
                Thread.Sleep(2000);
               EperformPreviewFormLink.Click();
                Thread.Sleep(2000);
                foreach (IWebElement element in EperformGobalQuestionNameTEXT)
                {

                    ExtentReport.test.Log(LogStatus.Pass, element.Text + "is displayed in manage form");
                }
                Thread.Sleep(2000);
               EperformBackButton.Click();
                Thread.Sleep(2000);
            }
        }

        public void addGlobalQuestion()
        {
            HomePage homepage = new HomePage(_driver);

            // DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "FormTemplateTest", "FormType", "QuestionnaireForm").Rows[0];
            //DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", SheetName, "GlobalQuestionType", Keyname).Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EP_GQ", "GlobalQuestionsCreate", "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                if (data["IsEdit"].ToString().ToLower() != "yes")
                {
                    System.Threading.Thread.Sleep(2000);
                    BaseMethods.verifyWebElement(EperformAddglobalquestionButton, "Eperform Addglobalquestion Button is not displayed in manage form", "Eperform Addglobalquestion Button is displayed in manage form");
                    EperformAddglobalquestionButton.Click();
                    System.Threading.Thread.Sleep(2000);
                    BaseMethods.verifyWebElement(EperformGlobalQuestionText, "Eperform GlobalQuestion Text is not displayed in manage form", "Eperform GlobalQuestion Text is displayed in manage form");
                    System.Threading.Thread.Sleep(4000);
                    EperformGlobalQuestionsSearchTextBox.SendKeys(data["Reference"].ToString());
                    System.Threading.Thread.Sleep(2000);
                    EperformGlobalQuestionSearchButton.Click();
                    System.Threading.Thread.Sleep(4000);
                    EperformGlobalQuestionCheckBox.Click();
                    System.Threading.Thread.Sleep(2000);
                    EperformGobalQuestionSubmitButton.Click();
                    System.Threading.Thread.Sleep(2000);
                    BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                }


            }
        }

        public void addFormTemplateDevelopmentActivityForm(string sheetname)
        {
            HomePage homepage = new HomePage(_driver);
            DataTable drt = ExcelData.GetData_DataTable("EP_TESTDATA", sheetname, "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                nametext = data["FormName"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                homepage.EperformSystemConfigurationArrowIcon.Click();
                homepage.EperformFormTemplatesOption.Click();
                System.Threading.Thread.Sleep(2000);
                EperformAddFormTemplateButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.verifyWebElement(EperformNameTextBox, "Eperform Name TextBox is not displayed in manage form", "Eperform Name TextBox is displayed in manage form");
                System.Threading.Thread.Sleep(2000);
                EperformNameTextBox.SendKeys(data["FormType"].ToString());
                if (data["Active"].ToString() == "Yes")
                {
                    EperformYesRadioButton.Click();
                }
                else
                {
                    EperformNoRadioButton.Click();
                }
                EperformSelectformtype.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.DdlSelectByValue(EperformSelectformtype, data["FormType"].ToString());
                EperformSubmitButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                System.Threading.Thread.Sleep(3000);
                EperformPreviewFormLink.Click();
                System.Threading.Thread.Sleep(5000);
                BaseMethods.webelementverify(EperformPreviewFormText);

                EperformBackButton.Click();
                addGlobalQuestion();
                EperformPreviewFormLink.Click();

                BaseMethods.webelementverify(EperformGobalQuestionText);
               EperformBackButton.Click();
                Thread.Sleep(2000);
                DataTable drt1 = ExcelData.GetData_DataTable("EP_TESTDATA", "Edit", "Enable", "Yes");
                foreach (DataRow data1 in drt1.Rows)
                {
                   edit(data1["EditGobalQuestionName"].ToString());
                }
                BaseMethods.verifyWebElement(EperformGlobalQuestionDeleteButton, "Eperform GlobalQuestion Delete Button is not displayed in manage form", "Eperform GlobalQuestion Delete Button is displayed in manage form");
               EperformGlobalQuestionDeleteButton.Click();
                Thread.Sleep(2000);
                EperformAddQuestionOkButton.Click();

            }
        }

        public void edit(string name)
        {
            DataTable drt = ExcelData.GetData_DataTable("EP_TESTDATA", "Edit", "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
               
                _driver.FindElement(By.XPath(" //td[contains(text(),'"+name+ "')]/..//td//a[contains(text(),'Edit')]")).Click();     
                //EperformEditButton.Click();
                EperformReferenceTestbox.Clear();
                EperformReferenceTestbox.SendKeys(data["reference"].ToString());
                TxtLabel(data["label"].ToString());
                if (data["required"].ToString() == "Yes")
                {
                    EperformRequiredYesRadioBtn.Click();

                }
              //  EperformMaximumLengthTextBox.SendKeys(data["maxLength"].ToString());
                EperformSubmitButton.Click();
                Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformGlobalQuestionAddedText);

            }
        }


 
        public void filledByRoles(String roletype)
        {


            int count = EperformCheckBoxRoleButton.Count;
            for (int i = 0; i < count; i++)
            {
                string id = "Dto_Questions_0__SelectedTaskFlowRoleIds_" + i;
                _driver.FindElement(By.Id(id)).Click();


            }
            _driver.FindElement(By.XPath("(//label[contains(text(),'"+ roletype+"')])[1]")).Click();

            int count2 = EperformCheckBoxRoleTwoButton.Count;
           
            for (int i = 0; i < count2; i++)
            {
                string id = "Dto_Questions_1__SelectedTaskFlowRoleIds_" + i;
                _driver.FindElement(By.Id(id)).Click();
            }
            _driver.FindElement(By.XPath("(//label[contains(text(),'" + roletype + "')])[2]")).Click();
            EperformSubmitButton.Click();
        }

        public void questionnaireformEditSearch(String SheetName,String Keyname)
        {

            HomePage homepage = new HomePage(_driver);
            DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", SheetName, "KeyName", Keyname).Rows[0];
            nametext = data["Form Type"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
            homepage.EperformSystemConfigurationArrowIcon.Click();
            homepage.EperformFormTemplatesOption.Click();
            System.Threading.Thread.Sleep(2000);
            EperformAddFormTemplateButton.Click();
            System.Threading.Thread.Sleep(2000);
            BaseMethods.verifyWebElement(EperformNameTextBox, "Eperform Name TextBox is not displayed in manage form", "Eperform Name TextBox is displayed in manage form");
           
            System.Threading.Thread.Sleep(2000);
            EperformNameTextBox.SendKeys(nametext);
            if (data["Active"].ToString() == "Yes")
            {
                EperformYesRadioButton.Click();
            }
            else
            {
                EperformNoRadioButton.Click();
            }
            EperformSelectformtype.Click();
            System.Threading.Thread.Sleep(2000);
            BaseMethods.DdlSelectByValue(EperformSelectformtype, data["Form Type"].ToString());
            EperformSubmitButton.Click();
            System.Threading.Thread.Sleep(8000);
            verifyFormType("ePeform Questionnaire Form");
            BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
            //addGlobalQuestion("FormTemplateTest");
            EperformCancelButton.Click();
            System.Threading.Thread.Sleep(2000);
            EperformFormTemplateSearchTextBox.SendKeys(nametext);
            EperformFormTemplateSearchButton.Click();
            System.Threading.Thread.Sleep(2000);
            EperformEditButton.Click();
            System.Threading.Thread.Sleep(2000);
            EperformEditButton.Click();
        }

        public void developmentActivityEditSearch(String SheetName, String Keyname)
        {
            HomePage homepage = new HomePage(_driver);
            //DataRow data = ExcelData.GetData_DataTable("EP_TESTDATA", SheetName, "KeyName", Keyname).Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EP_TESTDATA", SheetName, "Enable", "Yes");
            foreach (DataRow data in drt.Rows)
            {
                nametext = data["FormName"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                homepage.EperformSystemConfigurationArrowIcon.Click();
                homepage.EperformFormTemplatesOption.Click();
                System.Threading.Thread.Sleep(2000);
                EperformAddFormTemplateButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.verifyWebElement(EperformNameTextBox, "Eperform Name TextBox is not displayed in manage form", "Eperform Name TextBox is displayed in manage form");

                System.Threading.Thread.Sleep(2000);
                EperformNameTextBox.SendKeys(nametext);

                if (data["Active"].ToString() == "Yes")
                {
                    EperformYesRadioButton.Click();
                }
                else
                {
                    EperformNoRadioButton.Click();
                }
                EperformSelectformtype.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.DdlSelectByValue(EperformSelectformtype, data["Form Type"].ToString());
                System.Threading.Thread.Sleep(2000);
                EperformSubmitButton.Click();
                BaseMethods.verifyWebElement(EperformSuccessMessage, "Eperform Success Message is not displayed in manage form", "Eperform Success Message is displayed in manage form");
                //addGlobalQuestion("FormTemplateTest");
                EperformCancelButton.Click();
                System.Threading.Thread.Sleep(2000);
                EperformFormTemplateSearchTextBox.SendKeys(nametext);
                EperformFormTemplateSearchButton.Click();
                System.Threading.Thread.Sleep(2000);
                EperformEditButton.Click();
                System.Threading.Thread.Sleep(2000);
                EperformEditButton.Click();
            }
        }


        public void searchItem(String Text)
        {
            EperformFormTemplateSearchTextBox.SendKeys(Text);
            EperformFormTemplateSearchButton.Click();
        }

        public void createLocalQuestion()
        {
          //  DataRow dr = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "KeyName", "AddQuestionType_01").Rows[0];
            DataTable drt = ExcelData.GetData_DataTable("EP_TESTDATA", "QuestionType", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {

                handleLocalQuestionSingleLineTextBox(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                handleAddLocalQuestionMultiLineTextArea(dr["reference"].ToString(), dr["maxLength"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                handleLocalQuestionSelectSingleItemfromaList(dr["reference"].ToString(), dr["Answer Format"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString(),dr["OptionTextBox"].ToString());
                handleLocalQuestionSelectMultipleItemsfromaList(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                handleNumeric(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                handleYesNo(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                handleData(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
                handleAddLocalQuestionFileUpload(dr["reference"].ToString(), dr["label"].ToString(), dr["required"].ToString(), dr["Readonly"].ToString());
            }
        }

        public void verifyActionscolumnMovingquestionsUpAndDownQuestionnaireForm()
        {

        }

    }

}



