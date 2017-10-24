using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using EPerform.Library.Excel;
using System.Data;
using System.Threading;
using EPerform.Library;

namespace EPerform.Pages
{
    class ReviewWorkflowsPage
    {
        IWebDriver _driver;


        public ReviewWorkflowsPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this); 
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),' Add Review Workflow')]")]
        public IWebElement AddReviewWorkFlowButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement ReviewWorkFlowNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Description")]
        public IWebElement ReviewWorkFlowDescription { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement ActiveYesRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement ActiveNoRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),' Add Step')]")]
        public IWebElement AddStepButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Steps_0__TaskFlowRoleId")]
        public IWebElement WorkflowRoleDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='Dto.SelectedSegmentTypeSegmentStepTypeIds']")]
        public IList<IWebElement> PhaseCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='close']")]
        public IWebElement closeButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//table[@class='table table-nga footable  tablet breakpoint footable-loaded']//span[@class='footable-toggle']")]
        public IWebElement roledropdown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Steps_0__IsFinalForScoring")]
        public IWebElement finalscorecheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Steps_0__RoleId")]
        public IWebElement RoleDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Steps_0__RoleId")]
        public IList<IWebElement> RoleDropDownList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'New Role')]")]
        public IWebElement NewRoleButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_RoleId")]
        public IWebElement roleDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsObserver_t")]
        public IWebElement ObserverYesButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_IsObserver_f")]
        public IWebElement ObserverNoButton { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_PdfReportConfigFileDisplayDto_0__PdfReportDisplayControl")]
        public IWebElement UserReviewSummaryDropDown { get; set; }

        public void CreateWorkFlow()
        {
            HomePage home = new HomePage(_driver);

            DataTable workflow = ExcelData.GetData_DataTable("EP_ReviewsWorkFlow", "WorkFlow", "Enable", "Yes");
            foreach (DataRow data in workflow.Rows)
            {
                home.EperformReviewsArrowOption.Click();
                home.EperformWorkFlowsIcon.Click();
                AddReviewWorkFlowButton.Click();
                ReviewWorkFlowNameTextBox.SendKeys(data["Name"].ToString());
                ReviewWorkFlowDescription.SendKeys(data["Description"].ToString());
                if (data["IsActive"].ToString().ToLower().Trim() == "yes")
                {
                    ActiveYesRadioButton.Click();
                }
                else
                {
                    ActiveNoRadioButton.Click();
                }
                Thread.Sleep(2000);
                int i = 0;
                DataTable dt = ExcelData.GetData_DataTable("EP_ReviewsWorkFlow", "AddStep", "WorkflowName", data["Name"].ToString());
                foreach (DataRow addsetp in dt.Rows)
                {
                    IWebElement rolesDDL = _driver.FindElement(By.Id("Dto_Steps_" + i + "__RoleId"));
                    IWebElement finalScoreChkBox = _driver.FindElement(By.Id("Dto_Steps_" + i + "__IsFinalForScoring"));

                    BaseMethods.DdlSelectByText(rolesDDL, addsetp["Role"].ToString());
                    if (addsetp["IsFinalScore"].ToString().ToLower().Trim() == "yes")
                    {
                        finalScoreChkBox.Click();
                    }

                    if (dt.Rows.Count > (i + 1))
                    {
                        AddStepButton.Click();
                        BaseMethods.verifyWebElement(EperformSuccessMessage, "New Step is not added", "New Step is added");
                        i++;
                    }
                }
                //if (data["IsConcurrency"].ToString() == "Yes")
                //{
                //    _driver.FindElement(By.XPath("//button[contains(text(),' Concurrent with Above')]")).Click();
                //}
                //else
                //{
                //}

                int count = PhaseCheckBox.Count;
                for (int j = 0; j < count; j++)
                {
                    string id = "Dto_SelectedSegmentTypeSegmentStepTypeIds_" + j + "";
                    _driver.FindElement(By.Id(id)).Click();
                }

                SubmitButton.Click();
                BaseMethods.webelementverify(EperformSuccessMessage);
                closeButton.Click();
            }
        }
    }
}
