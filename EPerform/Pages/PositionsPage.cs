using ePerform.Library.Extent_Reports;
using EPerform.Library;
using EPerform.Library.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
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
    class PositionsPage
    {
        IWebDriver driver;

        public PositionsPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Position List')]")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Position List')]")]
        public IWebElement PositionList_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Chart')]")]
        public IWebElement Chart_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Position')]")]
        public IWebElement AddPosition_Button { get; set; }

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

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Show Advanced Search')])[1]")]
        public IWebElement ShowAdvancedSearchButton1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Show Advanced Search')])[2]")]
        public IWebElement ShowAdvancedSearchButton2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Hide Advanced Search')])[1]")]
        public IWebElement HideAdvancedSearchButton1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Hide Advanced Search')])[2]")]
        public IWebElement HideAdvancedSearchButton2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Edit')])[1]")]
        public IWebElement Edit_Button_SearchedPosition { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Delete')])[1]")]
        public IWebElement Delete_Button_SearchedPosition { get; set; }

        #region Manage Positions

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Details')]")]
        public IWebElement Details_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Reporting Positions')]")]
        public IWebElement ReportingPositions_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Associated Users')]")]
        public IWebElement AssociatedUsers_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//li/a[contains(text(),'Competencies')])[2]")]
        public IWebElement Competencies_Tab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li/a[contains(text(),'Associated Goals')]")]
        public IWebElement AssociatedGoals_Tab { get; set; }


        #region Details Tab - Manage Positions

        [FindsBy(How = How.Id, Using = "Dto_StringDtos_0__Value")]
        public IWebElement PositionTitle_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_StringDtos_1__Value")]
        public IWebElement PositionNo_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_StringDtos_2__Value")]
        public IWebElement PositionDescription_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_FileDtos_0__Value")]
        public IWebElement PositionDescriptionCurrent_FileSelectPopup_Button { get; set; }

        [FindsBy(How = How.Id, Using = "//a[contains(text(),'Clear')]")]
        public IWebElement PositionDescriptionCurrent_FileClear_Button { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_MarkerId")]
        public IWebElement Marker_DDL { get; set; }

        //[FindsBy(How = How.Id, Using = "Dto_ParentPositionId")]
        //public IWebElement ReportsTo_DDL { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_Dto_ParentPositionId")]
        public IWebElement ReportsTo_Div { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen1_search")]
        public IWebElement ReportsTo_SearchTextBox { get; set; }

        //[FindsBy(How = How.Id, Using = "//input[@id='s2id_autogen1_search']/../following-sibling::ul/li[1]")]
        //public IWebElement ReportsTo_SearchedItem { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_OrgUnitId")]
        public IWebElement OrganisationalUnit_DDL { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_QuestionnaireFormId")]
        public IWebElement QuestionnaireforReview_DDL { get; set; }

        #endregion

        #region Reporting Positions Tab - Manage Positions

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Select Position')]")]
        public IWebElement SelectPosition_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create Position')]")]
        public IWebElement CreatePosition_Button { get; set; }

        #endregion

        #region Associated Users Tab - Manage Positions

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add User')]")]
        public IWebElement AddUser_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Select')])[1]")]
        public IWebElement Select_Button_SearchedUsers { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_StartDate")]
        public IWebElement StartDate_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_EndDate")]
        public IWebElement EndDate_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_ProbationEndDate")]
        public IWebElement ProbationEndDate_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Salary")]
        public IWebElement Salary_TextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PositionUserTypeId_0")]
        public IWebElement PositionType_Substantive_RadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PositionUserTypeId_1")]
        public IWebElement PositionType_Actual_RadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PositionUserStatusId")]
        public IWebElement Status_DDL { get; set; }

        #endregion

        #region Associated Goals Tab - Manage Positions

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Goal')]")]
        public IWebElement AddGoal_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Remove')])[1]")]
        public IWebElement Remove_Button_SearchedGoals { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Deactivate')])[1]")]
        public IWebElement Deactivate_Button_SearchedGoals { get; set; }

        #endregion

        #endregion


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Confirm')]")]
        public IWebElement Confirm_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Back')]")]
        public IWebElement Back_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Cancel')]")]
        public IWebElement Cancel_Button { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement CloseButton_Popup { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success')]")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "(//tbody//input[@type='checkbox'])[1]")]
        public IWebElement SelectSearchedItem_CheckBox_Popup { get; set; }


        public void CreatePositions(DataRow dr)
        {
            string positionTitle = dr["PositionTitle"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
            string positionNo = dr["PositionNo"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');

            PositionTitle_TextBox.Clear();
            PositionTitle_TextBox.SendKeys(positionTitle);

            PositionNo_TextBox.Clear();
            PositionNo_TextBox.SendKeys(positionNo);

            PositionDescription_TextBox.Clear();
            PositionDescription_TextBox.SendKeys(dr["PositionDescription"].ToString());

            if (dr["Marker"].ToString().Trim() != "")
            {
                BaseMethods.DdlSelectByText(Marker_DDL, dr["Marker"].ToString());
            }
            if (dr["ReportsTo"].ToString().Trim() != "")
            {
                ReportsTo_Div.Click();
                Thread.Sleep(3000);

                ReportsTo_SearchTextBox.SendKeys(dr["ReportsTo"].ToString());
                Thread.Sleep(3000);

                driver.FindElement(By.XPath("//input[@id='s2id_autogen1_search']/../following-sibling::ul/li[1]")).Click();

                Thread.Sleep(2000);
                //BaseMethods.DdlSelectByText(ReportsTo_DDL, dr["ReportsTo"].ToString());
            }
            if (dr["OrganisationalUnit"].ToString().Trim() != "")
            {
                BaseMethods.DdlSelectByText(OrganisationalUnit_DDL, dr["OrganisationalUnit"].ToString());
            }
            if (dr["QuestionnaireforReview"].ToString().Trim() != "")
            {
                BaseMethods.DdlSelectByText(QuestionnaireforReview_DDL, dr["QuestionnaireforReview"].ToString());
            }

            Submit_Button.Click();

            Assert.IsTrue(SuccessMessage.Displayed, positionTitle + " - Position is not created successfully");
            ExtentReport.test.Log(LogStatus.Pass, "Success Message is displayed, " + positionTitle + " - Position is created successfully");

            Thread.Sleep(3000);


            if (dr["AddUser_AsUsr"].ToString().Trim() != "")
            {
                AssociatedUsers_Tab.Click();
                Thread.Sleep(2000);

                AddUser_Button.Click();
                Thread.Sleep(3000);

                Keywords_TextBox2.SendKeys(dr["AddUser_AsUsr"].ToString());

                SearchButton3.Click();
                Thread.Sleep(3000);

                try
                {
                    Select_Button_SearchedUsers.Click();
                }
                catch (Exception)
                {
                    ExtentReport.test.Log(LogStatus.Fatal, dr["AddUser_AsUsr"].ToString() + " - User is not found in the Users List");
                    goto Competency_Comp;
                }

                Thread.Sleep(3000);

                string startDate = dr["StartDate_AsUsr"].ToString().Split(' ')[0];
                string endDate = dr["EndDate_AsUsr"].ToString().Split(' ')[0];
                string probationEndDate = dr["ProbationEndDate_AsUsr"].ToString().Split(' ')[0];

                StartDate_TextBox.Clear();
                StartDate_TextBox.SendKeys(startDate);

                EndDate_TextBox.Clear();
                EndDate_TextBox.SendKeys(endDate);

                ProbationEndDate_TextBox.Clear();
                ProbationEndDate_TextBox.SendKeys(probationEndDate);

                Salary_TextBox.Clear();
                Salary_TextBox.SendKeys(dr["Salary_AsUsr"].ToString());
                Salary_TextBox.Click();

                if (dr["PositionType_AsUsr"].ToString().ToLower() == "substantive")
                {
                    PositionType_Substantive_RadioButton.Click();
                }
                else
                {
                    PositionType_Actual_RadioButton.Click();
                }

                BaseMethods.DdlSelectByText(Status_DDL, dr["Status_AsUsr"].ToString());

                Submit_Button.Click();

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + dr["AddUser_AsUsr"].ToString() + " - User is added successfully",
                                                          dr["AddUser_AsUsr"].ToString() + " - User is not added successfully");

                try
                {
                    CloseButton_Popup.Click();
                }
                catch (Exception) { }
            }

            Competency_Comp:
            if (dr["Competency_Comp"].ToString().Trim() != "")
            {
                Competencies_Tab.Click();

                string activeComp = dr["Competency_Comp"].ToString();
                IWebElement newCompetency = driver.FindElement(By.XPath("(//h3[contains(text(),'" + activeComp + "')])[1]"));
                activeComp = newCompetency.Text;

                IWebElement compLevelDDL = driver.FindElement(By.XPath("(//h3[contains(text(),'" + activeComp + "')])[1]/../following-sibling::div//select"));

                SelectElement select = new SelectElement(compLevelDDL);

                for (int i = 0; i < select.Options.Count; i++)
                {
                    if (select.Options[i].Text.Contains(dr["CompetencyLevel_Comp"].ToString()))
                    {
                        select.SelectByIndex(i);
                    }
                }

                Submit_Button.Click();

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + dr["CompetencyLevel_Comp"].ToString() + " - Competency Level of Competency '" + dr["Competency_Comp"].ToString() + "' is selected successfully",
                                                          dr["CompetencyLevel_Comp"].ToString() + " - Competency Level of Competency '" + dr["Competency_Comp"].ToString() + "' is not selected successfully");

                Thread.Sleep(3000);
            }

            if (dr["AddGoal_AsGoal"].ToString().Trim() != "")
            {
                AssociatedGoals_Tab.Click();
                Thread.Sleep(2000);

                AddGoal_Button.Click();


                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

                Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
                {
                    try
                    {
                        Console.WriteLine(Keywords_TextBox2.GetAttribute("innerHTML"));
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                });
                wait.Until(waitForElement);

                Keywords_TextBox2.SendKeys(dr["AddGoal_AsGoal"].ToString());

                SearchButton2.Click();

                string chk = SearchButton2.GetAttribute("class");

                WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

                Func<IWebDriver, bool> waitForElement1 = new Func<IWebDriver, bool>((IWebDriver Web) =>
                {
                    if (!chk.Contains("buttonActionVisual"))
                        return true;
                    else
                    {
                        chk = SearchButton2.GetAttribute("class");
                        return false;
                    }
                });
                wait1.Until(waitForElement1);

                try
                {
                    SelectSearchedItem_CheckBox_Popup.Click();
                }
                catch (Exception)
                {
                    ExtentReport.test.Log(LogStatus.Fatal, dr["AddGoal_AsGoal"].ToString() + " - Goal is not found in the Goals List");
                    goto ReportingPositions;
                }

                Submit_Button.Click();
                Thread.Sleep(3000);

                BaseMethods.SoftAssert_Display(SuccessMessage, "Success Message is displayed, " + dr["AddGoal_AsGoal"].ToString() + " - Goal is selected successfully",
                                                                dr["AddGoal_AsGoal"].ToString() + " - Goal is not selected successfully");
                try
                {
                    CloseButton_Popup.Click();
                }
                catch (Exception) { }
            }

            ReportingPositions:
            if (dr["SelectPosition_RepPos"].ToString().Trim() != "")
            {
                ReportingPositions_Tab.Click();

                SelectPosition_Button.Click();
                Thread.Sleep(3000);

                Keywords_TextBox2.SendKeys(dr["SelectPosition_RepPos"].ToString());

                SearchButton3.Click();
                Thread.Sleep(3000);

                try
                {
                    SelectSearchedItem_CheckBox_Popup.Click();
                }
                catch (Exception)
                {
                    ExtentReport.test.Log(LogStatus.Fatal, dr["SelectPosition_RepPos"].ToString() + " - Position is not found in the Positions List");
                    goto CreatePosition;
                }

                Submit_Button.Click();
                Thread.Sleep(3000);

                Confirm_Button.Click();

                Thread.Sleep(3000);

                Keywords_TextBox1.SendKeys(dr["SelectPosition_RepPos"].ToString());

                SearchButton1.Click();

                IWebElement checkPosition = driver.FindElement(By.XPath("(//tbody//td[contains(text(),'" + dr["SelectPosition_RepPos"].ToString() + "')])[1]"));

                BaseMethods.SoftAssert_Display(checkPosition, dr["SelectPosition_RepPos"].ToString() + " - Position is selected successfully and listed in the Reporting Position List",
                                                              dr["SelectPosition_RepPos"].ToString() + " - Position is not selected successfully");

            }

            CreatePosition:
            if (dr["CreatePosition_RepPos"].ToString().Trim() != "")
            {
                DataTable dtChild = ExcelData.GetData_DataTable("EP_OrgStructures", "Positions", "ID", Convert.ToInt32(dr["CreatePosition_RepPos"].ToString().Trim()));
                DataRow drChild = dtChild.Rows[0];
                CreatePosition_Button.Click();
                CreatePositions(drChild);
            }

        }

    }
}
