using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ePerfrom.Library;
using System.Data;
using EPerform.Library;
using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using EPerform.Pages;
using System.Collections;
using System.Threading;

namespace ePerform.Pages
{
    class ManageGlobalQuestionPage
    {
        IWebDriver driver;

        public ManageGlobalQuestionPage(IWebDriver pDriver)
        {
            driver = pDriver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// 'Manage Global Question' Page Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Manage Global Question')]")]
        private IWebElement elePageTitle;
        public IWebElement PageTitle
        {
            get
            {
                return elePageTitle;
            }
            set
            {
                elePageTitle = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Single Line Text Box' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Single Line Text Box')]")]
        private IWebElement eleManageGQFormTitle_SingleLineTextBox;
        public IWebElement ManageGQFormTitle_SingleLineTextBox
        {
            get
            {
                return eleManageGQFormTitle_SingleLineTextBox;
            }
            set
            {
                eleManageGQFormTitle_SingleLineTextBox = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Multi Line Text Area' Form Title
        /// </summary> 
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Multi Line Text Area')]")]
        private IWebElement eleManageGQFormTitle_MultiLineTextArea;
        public IWebElement ManageGQFormTitle_MultiLineTextArea
        {
            get
            {
                return eleManageGQFormTitle_MultiLineTextArea;
            }
            set
            {
                eleManageGQFormTitle_MultiLineTextArea = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Select Single Item from a List' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Select Single Item from a List')]")]
        private IWebElement eleManageGQFormTitle_SelectSingleItemList;
        public IWebElement ManageGQFormTitle_SelectSingleItemList
        {
            get
            {
                return eleManageGQFormTitle_SelectSingleItemList;
            }
            set
            {
                eleManageGQFormTitle_SelectSingleItemList = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Select Multiple Items from a List' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Select Multiple Items from a List')]")]
        private IWebElement eleManageGQFormTitle_SelectMultipleItemsList;
        public IWebElement ManageGQFormTitle_SelectMultipleItemsList
        {
            get
            {
                return eleManageGQFormTitle_SelectMultipleItemsList;
            }
            set
            {
                eleManageGQFormTitle_SelectMultipleItemsList = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Numeric' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Numeric')]")]
        private IWebElement eleManageGQFormTitle_Numeric;
        public IWebElement ManageGQFormTitle_Numeric
        {
            get
            {
                return eleManageGQFormTitle_Numeric;
            }
            set
            {
                eleManageGQFormTitle_Numeric = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Yes or No' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Yes or No')]")]
        private IWebElement eleManageGQFormTitle_YesorNo;
        public IWebElement ManageGQFormTitle_YesorNo
        {
            get
            {
                return eleManageGQFormTitle_YesorNo;
            }
            set
            {
                eleManageGQFormTitle_YesorNo = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - Date' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - Date')]")]
        private IWebElement eleManageGQFormTitle_Date;
        public IWebElement ManageGQFormTitle_Date
        {
            get
            {
                return eleManageGQFormTitle_Date;
            }
            set
            {
                eleManageGQFormTitle_Date = value;
            }
        }

        /// <summary>
        /// 'Manage Global Question - File Upload' Form Title
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Manage Global Question - File Upload')]")]
        private IWebElement eleManageGQFormTitle_FileUpload;
        public IWebElement ManageGQFormTitle_FileUpload
        {
            get
            {
                return eleManageGQFormTitle_FileUpload;
            }
            set
            {
                eleManageGQFormTitle_FileUpload = value;
            }
        }

        /// <summary>
        /// 'Denotes a mandatory field' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Denotes a mandatory field')]")]
        private IWebElement eleLblMandatoryField;
        public IWebElement LblMandatoryField
        {
            get
            {
                return eleLblMandatoryField;
            }
            set
            {
                eleLblMandatoryField = value;
            }
        }

        /// <summary>
        /// 'Component Type' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Component Type')]")]
        private IWebElement eleLblComponentType;
        public IWebElement LblComponentType
        {
            get
            {
                return eleLblComponentType;
            }
            set
            {
                eleLblComponentType = value;
            }
        }

        /// <summary>
        /// 'Single Line Text Box' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Single Line Text Box')]")]
        private IWebElement eleLblSingleLineTextBox;
        public IWebElement LblSingleLineTextBox
        {
            get
            {
                return eleLblSingleLineTextBox;
            }
            set
            {
                eleLblSingleLineTextBox = value;
            }
        }

        /// <summary>
        /// 'Reference' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Reference')]")]
        private IWebElement eleLblReference;
        public IWebElement LblReference
        {
            get
            {
                return eleLblReference;
            }
            set
            {
                eleLblReference = value;
            }
        }

        /// <summary>
        /// Reference Textbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_Reference")]
        private IWebElement eleTxtReference;
        public IWebElement TxtReference
        {
            get
            {
                return eleTxtReference;
            }
            set
            {
                eleTxtReference = value;
            }
        }

        /// <summary>
        /// 'Active' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Active')]")]
        private IWebElement eleLblActive;
        public IWebElement LblActive
        {
            get
            {
                return eleLblActive;
            }
            set
            {
                eleLblActive = value;
            }
        }

        /// <summary>
        /// Active Radio button Yes
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        private IWebElement eleRdoActiveYes;
        public IWebElement RdoActiveYes
        {
            get
            {
                return eleRdoActiveYes;
            }
            set
            {
                eleRdoActiveYes = value;
            }
        }

        /// <summary>
        /// Active Radio button No
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        private IWebElement eleRdoActiveNo;
        public IWebElement RdoActiveNo
        {
            get
            {
                return eleRdoActiveNo;
            }
            set
            {
                eleRdoActiveNo = value;
            }
        }

        /// <summary>
        /// 'Label' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Label')]")]
        private IWebElement eleLblLabel;
        public IWebElement LblLabel
        {
            get
            {
                return eleLblLabel;
            }
            set
            {
                eleLblLabel = value;
            }
        }

        [FindsBy(How = How.Id, Using = "Dto_Label_ifr")]
        private IWebElement eleTxtLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='mce-ico mce-i-bold']/..")]
        public IWebElement boldButton_LabelIFrame { get; set; }

        public void TxtLabel(string value)
        {
            boldButton_LabelIFrame.Click();
            boldButton_LabelIFrame.Click();

            driver.SwitchTo().Frame(eleTxtLabel);
            IWebElement body = driver.FindElement(By.CssSelector("body"));
            body.Clear();
            body.SendKeys(value);
            driver.SwitchTo().ParentFrame();
        }

        /// <summary>
        /// 'Required' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Required')]")]
        private IWebElement eleLblRequired;
        public IWebElement LblRequired
        {
            get
            {
                return eleLblRequired;
            }
            set
            {
                eleLblRequired = value;
            }
        }

        /// <summary>
        /// Required Radio button Yes
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsRequired_t")]
        private IWebElement eleRdoRequiredYes;
        public IWebElement RdoRequiredYes
        {
            get
            {
                return eleRdoRequiredYes;
            }
            set
            {
                eleRdoRequiredYes = value;
            }
        }

        /// <summary>
        /// Required Radio button No
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsRequired_f")]
        private IWebElement eleRdoRequiredNo;
        public IWebElement RdoRequiredNo
        {
            get
            {
                return eleRdoRequiredNo;
            }
            set
            {
                eleRdoRequiredNo = value;
            }
        }

        /// <summary>
        /// 'Maximum Length' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Maximum Length')]")]
        private IWebElement eleLblMaximumLength;
        public IWebElement LblMaximumLength
        {
            get
            {
                return eleLblMaximumLength;
            }
            set
            {
                eleLblMaximumLength = value;
            }
        }

        /// <summary>
        /// Maximum Length Textbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_MaxLength")]
        private IWebElement eleTxtMaxLength;
        public IWebElement TxtMaxLength
        {
            get
            {
                return eleTxtMaxLength;
            }
            set
            {
                eleTxtMaxLength = value;
            }
        }

        /// <summary>
        /// 'Maximum Length Type' Label
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Maximum Length Type')]")]
        private IWebElement eleLblMaximumLengthType;
        public IWebElement LblMaximumLengthType
        {
            get
            {
                return eleLblMaximumLengthType;
            }
            set
            {
                eleLblMaximumLengthType = value;
            }
        }

        /// <summary>
        /// Characters Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_MaxLengthType_0")]
        private IWebElement eleRdoCharacters;
        public IWebElement RdoCharacters
        {
            get
            {
                return eleRdoCharacters;
            }
            set
            {
                eleRdoCharacters = value;
            }
        }

        /// <summary>
        /// Words Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_MaxLengthType_1")]
        private IWebElement eleRdoWords;
        public IWebElement RdoWords
        {
            get
            {
                return eleRdoWords;
            }
            set
            {
                eleRdoWords = value;
            }
        }

        /// <summary>
        /// Submit Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        private IWebElement eleBtnSubmit;
        public IWebElement BtnSubmit
        {
            get
            {
                return eleBtnSubmit;
            }
            set
            {
                eleBtnSubmit = value;
            }
        }

        /// <summary>
        /// Cancel Button
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Cancel")]
        private IWebElement eleBtnCancel;
        public IWebElement BtnCancel
        {
            get
            {
                return eleBtnCancel;
            }
            set
            {
                eleBtnCancel = value;
            }
        }

        /// <summary>
        /// Answer Format Drop Down List
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_AnswerFormat")]
        private IWebElement eleDdlAnswerFormat;
        public IWebElement DdlAnswerFormat
        {
            get
            {
                return eleDdlAnswerFormat;
            }
            set
            {
                eleDdlAnswerFormat = value;
            }
        }

        /// <summary>
        /// Select Prompt Textbox
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_SelectPrompt")]
        private IWebElement eleTxtSelectPrompt;
        public IWebElement TxtSelectPrompt
        {
            get
            {
                return eleTxtSelectPrompt;
            }
            set
            {
                eleTxtSelectPrompt = value;
            }
        }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Options']")]
        public IWebElement OptionTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Options')]")]
        public IWebElement AddOptionButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_AnswerOptions")]
        public IWebElement AnswerOptionsTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//button[@name='OnMoveUp'])[1]")]
        public IWebElement AnswerOption_MoveUp { get; set; }

        [FindsBy(How = How.XPath, Using = "(//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//button[@name='OnMoveDown'])[1]")]
        public IWebElement AnswerOption_MoveDown { get; set; }

        [FindsBy(How = How.XPath, Using = "(//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']//a[contains(text(),'Edit')])[1]")]
        public IWebElement AnswerOption_Edit { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr[1]/td[1]")]
        public IWebElement AnswerOption_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable footableConfigurable base-list-table default footable-loaded']/tbody/tr[1]/td[2]")]
        public IWebElement AnswerOption_Active { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_DisplayValue")]
        public IWebElement AnswerOption_NameTxtBx { get; set; }

        string reference = string.Empty;
        string formSubmitType = "created";
        string executeType = string.Empty;

        /// <summary>
        /// To Create Single Line Text Area Global Question
        /// </summary>
        public string CreateGQ_SingleLineTextBox(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                TxtMaxLength.Clear();
                TxtMaxLength.SendKeys(dr[executeType + "MaxLength"].ToString());
                if (dr[executeType + "MaxLenghtType"].ToString().ToLower() == "characters")
                {
                    RdoCharacters.Click();
                }
                else
                {
                    RdoWords.Click();
                }
                BtnSubmit.Click();
                Thread.Sleep(2000);

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Single Line Text Box Global Question " + formSubmitType + " successfully",
                                                                reference + " - Single Line Text Box Global Question is not " + formSubmitType + " successfully");
            }
            return reference;
        }

        /// <summary>
        /// To Create Multi Line Text Area Global Question
        /// </summary>
        public string CreateGQ_MultiLineTextArea(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                TxtMaxLength.Clear();
                TxtMaxLength.SendKeys(dr[executeType + "MaxLength"].ToString());
                if (dr[executeType + "MaxLenghtType"].ToString().ToLower() == "characters")
                {
                    RdoCharacters.Click();
                }
                else
                {
                    RdoWords.Click();
                }
                BtnSubmit.Click();
                Thread.Sleep(2000);
                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Multi Line Text Area Global Question " + formSubmitType + " successfully",
                                                                reference + " - Multi Line Text Area Global Question is not " + formSubmitType + " successfully");
            }
            return reference;
        }

        /// <summary>
        /// To Create Select Single Item from a List Global Question
        /// </summary>
        public string CreateGQ_SelectSingleItem(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                BaseMethods.DdlSelectByText(DdlAnswerFormat, dr[executeType + "AnswerFormat"].ToString());

                if (dr[executeType + "AnswerFormat"].ToString() == "Drop Down")
                {
                    TxtSelectPrompt.Clear();
                    TxtSelectPrompt.SendKeys(dr[executeType + "SelectPrompt"].ToString());
                }
                BtnSubmit.Click();
                Thread.Sleep(2000);
                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Select Single Item from a List Global Question " + formSubmitType + " successfully",
                                                                reference + " - Select Single Item from a List Global Question is not " + formSubmitType + " successfully");

                if (dr[executeType + "Options"].ToString().Trim() != string.Empty)
                {
                    OptionTab.Click();
                    if (formSubmitType == "created")
                    {
                        AddOptionButton.Click();

                        string[] OptionsList = dr[executeType + "Options"].ToString().Trim().Split(',');
                        for (int i = 0; i < OptionsList.Length; i++)
                        {
                            AnswerOptionsTextBox.SendKeys(OptionsList[i].Trim() + "\r\n");
                        }
                        BtnSubmit.Click();
                        Thread.Sleep(2000);
                        BaseMethods.SoftAssert_Display(SuccessMessage, "Answer Options for the Global Question " + reference + " is created successfully",
                                                                "Answer Options for the Global Question " + reference + " is not created successfully");
                    }
                    else
                    {
                        string optionNameBefore = AnswerOption_Name.Text;
                        Thread.Sleep(2000);
                        AnswerOption_Edit.Click();
                        AnswerOption_NameTxtBx.Clear();
                        AnswerOption_NameTxtBx.SendKeys(dr[executeType + "Options"].ToString());

                        RdoActiveNo.Click();
                        BtnSubmit.Click();

                        BaseMethods.SoftAssert_Equal(dr[executeType + "Options"].ToString(), AnswerOption_Name.Text, optionNameBefore + " has been successfully edited to " + AnswerOption_Name.Text + " and made InActive",
                                                                "Answer Options for the Global Question is not edited successfully");
                    }
                }
            }
            return reference;
        }

        /// <summary>
        /// To Create Select Multiple Items from a List Global Question
        /// </summary>
        public string CreateGQ_SelectMultipleitems(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                BaseMethods.DdlSelectByText(DdlAnswerFormat, dr[executeType + "AnswerFormat"].ToString());

                BtnSubmit.Click();
                Thread.Sleep(2000);
                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Select Multiple Items from a List Global Question " + formSubmitType + " successfully",
                                                               reference + " - Select Multiple Items from a List Global Question is not " + formSubmitType + " successfully");

                if (dr[executeType + "Options"].ToString().Trim() != string.Empty)
                {
                    OptionTab.Click();
                    if (formSubmitType == "created")
                    {
                        #region Adding Answer Options

                        AddOptionButton.Click();

                        string[] OptionsList = dr[executeType + "Options"].ToString().Trim().Split(',');
                        for (int i = 0; i < OptionsList.Length; i++)
                        {
                            AnswerOptionsTextBox.SendKeys(OptionsList[i].Trim() + "\r\n");
                        }
                        BtnSubmit.Click();
                        Thread.Sleep(2000);

                        BaseMethods.SoftAssert_Display(SuccessMessage, "Answer Options for the Global Question " + reference + " is created successfully",
                                                                       "Answer Options for the Global Question " + reference + " is not created successfully");

                        #endregion

                        #region Answer Options Moving Up and Down

                        if (OptionsList.Length > 1)
                        {
                            AnswerOption_MoveUp.Click();
                            ExtentReport.test.Log(LogStatus.Pass, "Answer Options for the Global Question " + reference + " has been moved up successfully");
                            Thread.Sleep(2000);
                            AnswerOption_MoveDown.Click();
                            ExtentReport.test.Log(LogStatus.Pass, "Answer Options for the Global Question " + reference + " has been moved down successfully");
                        }

                        #endregion

                        #region Making Answer Option InActive
                        Thread.Sleep(2000);
                        AnswerOption_Edit.Click();
                        RdoActiveNo.Click();
                        BtnSubmit.Click();
                        Thread.Sleep(2000);

                        BaseMethods.SoftAssert_Display(SuccessMessage, OptionsList[0].Trim() + " - Answer Option has been made InActive successfully",
                                                                       "Making " + OptionsList[0].Trim() + " - Answer Option InActive was unsuccessfully");

                        #endregion
                    }
                    else
                    {
                        string optionNameBefore = AnswerOption_Name.Text;
                        Thread.Sleep(2000);
                        AnswerOption_Edit.Click();
                        AnswerOption_NameTxtBx.Clear();
                        AnswerOption_NameTxtBx.SendKeys(dr[executeType + "Options"].ToString());

                        RdoActiveNo.Click();
                        BtnSubmit.Click();

                        BaseMethods.SoftAssert_Equal(dr[executeType + "Options"].ToString(), AnswerOption_Name.Text, optionNameBefore + " has been successfully edited to " + AnswerOption_Name.Text + " and made InActive",
                                                                       "Answer Options for the Global Question is not edited successfully");
                    }
                }
            }
            return reference;
        }

        /// <summary>
        /// To Create Numeric Global Question
        /// </summary>
        public string CreateGQ_Numeric(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                BtnSubmit.Click();
                Thread.Sleep(2000);

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Numeric Global Question " + formSubmitType + " successfully",
                                                                reference + " - Numeric Global Question is not " + formSubmitType + " successfully");
            }
            return reference;
        }

        /// <summary>
        /// To Create Yes Or No Global Question
        /// </summary>
        public string CreateGQ_YesorNo(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                BtnSubmit.Click();
                Thread.Sleep(2000);

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Yes Or No Global Question " + formSubmitType + " successfully",
                                                                reference + " - Yes Or No Global Question is not " + formSubmitType + " successfully");
            }
            return reference;
        }

        /// <summary>
        /// To Create Select Multiple Items from a List Global Question
        /// </summary>
        public string CreateGQ_Date(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                BaseMethods.DdlSelectByText(DdlAnswerFormat, dr[executeType + "AnswerFormat"].ToString());

                BtnSubmit.Click();
                Thread.Sleep(2000);

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - Date Global Question " + formSubmitType + " successfully",
                                                                reference + " - Date Global Question is not " + formSubmitType + " successfully");
            }
            return reference;
        }

        /// <summary>
        /// To Create Yes Or No Global Question
        /// </summary>
        public string CreateGQ_FileUpload(DataRow dr)
        {
            if (dr != null)
            {
                //if (formSubmitType == "created")
                //{
                reference = dr[executeType + "Reference"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                TxtReference.Clear();
                TxtReference.SendKeys(reference);
                //}

                if (dr[executeType + "Active"].ToString().ToLower() == "yes")
                {
                    RdoActiveYes.Click();
                }
                else
                {
                    RdoActiveNo.Click();
                }

                TxtLabel(dr[executeType + "Label"].ToString());
                if (dr[executeType + "Required"].ToString().ToLower() == "yes")
                {
                    RdoRequiredYes.Click();
                }
                else
                {
                    RdoRequiredNo.Click();
                }
                BtnSubmit.Click();
                Thread.Sleep(2000);

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + reference + " - File Upload Global Question " + formSubmitType + " successfully",
                                                                reference + " - File Upload Global Question is not " + formSubmitType + " successfully");
            }
            return reference;
        }

        public void EditGQ_SingleLineTextBox(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_SingleLineTextBox(drEdit);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Single Line Text Box Global Question was edited successfully",
                                                            "Single Line Text Box Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Single Line Text Box Global Question was deleted successfully",
                                                                      reference + " - Single Line Text Box Global Question was not deleted successfully");
        }

        public void EditGQ_MultiLineTextArea(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_MultiLineTextArea(drEdit);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Multi Line Text Area Global Question was edited successfully",
                                                            "Multi Line Text Area Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Multi Line Text Area Global Question was deleted successfully",
                                                                      reference + " - Multi Line Text Area Global Question was not deleted successfully");
        }

        public void EditGQ_SelectSingleItem(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            Thread.Sleep(2000);
            gqListPage.GoToGlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_SelectSingleItem(drEdit);
            Thread.Sleep(2000);
            gqListPage.GoToGlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Select Single Item from a List Global Question was edited successfully",
                                                            "Select Single Item from a List Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Select Single Item from a List Global Question was deleted successfully",
                                                                      reference + " - Select Single Item from a List Global Question was not deleted successfully");
        }

        public void EditGQ_SelectMultipleitems(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            Thread.Sleep(2000);
            gqListPage.GoToGlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_SelectMultipleitems(drEdit);
            Thread.Sleep(2000);
            gqListPage.GoToGlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Select Multiple Items from a List Global Question was edited successfully",
                                                            "Select Multiple Items from a List Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Select Multiple Items from a List Global Question was deleted successfully",
                                                                      reference + " - Select Multiple Items from a List Global Question was not deleted successfully");
        }

        public void EditGQ_Numeric(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_Numeric(drEdit);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Numeric Global Question was edited successfully",
                                                            "Numeric Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Numeric Global Question was deleted successfully",
                                                                      reference + " - Numeric Global Question was not deleted successfully");
        }

        public void EditGQ_YesorNo(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_YesorNo(drEdit);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Yes Or No Global Question was edited successfully",
                                                            "Yes Or No Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Yes Or No Global Question was deleted successfully",
                                                                      reference + " - Yes Or No Global Question was not deleted successfully");
        }

        public void EditGQ_Date(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_Date(drEdit);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "Date Global Question was edited successfully",
                                                           "Date Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - Date Global Question was deleted successfully",
                                                                      reference + " - Date Global Question was not deleted successfully");
        }

        public void EditGQ_FileUpload(string refr, DataRow drEdit)
        {
            reference = refr;
            executeType = "Edit";
            GlobalQuestionsListPage gqListPage = new GlobalQuestionsListPage(driver);
            gqListPage.SearchGQ(reference);
            formSubmitType = "edited";
            Thread.Sleep(2000);
            gqListPage.SearchedEditButton.Click();
            CreateGQ_FileUpload(drEdit);
            gqListPage.SearchGQ(reference);
            Thread.Sleep(2000);
            IList<IWebElement> searchedItem = gqListPage.ReferenceList.ToList();
            executeType = string.Empty;
            BaseMethods.SoftAssert_Equal(reference, searchedItem[0].Text, "File Upload Global Question was edited successfully",
                                                           "File Upload Global Question was not edited successfully");
            Thread.Sleep(2000);

            gqListPage.SearchedDeleteButton.Click();
            gqListPage.DeletePopupConfirmButton.Click();

            BaseMethods.SoftAssert_Display(gqListPage.SuccessMessage, "Success Message is displayed, " + reference + " - File Upload Global Question was deleted successfully",
                                                                      reference + " - File Upload Global Question was not deleted successfully");
        }


    }
}
