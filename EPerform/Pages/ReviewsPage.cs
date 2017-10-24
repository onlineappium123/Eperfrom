using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using EPerform.Library.Excel;
using System.Data;
using EPerform.Library;

namespace EPerform.Pages
{
    class ReviewsPage
    {
        IWebDriver _driver;
        public ReviewsPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//a[contains(text(),'Add Review')]")]
        public IWebElement AddReviewButton { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[text()='Associated Users']")]
        public IWebElement AssociatedUsersButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Keywords']")]
        public IWebElement Keywords_TextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Success!')]")]
        public IWebElement EperformSuccessMessage { get; set; }


        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Search')])[1]")]
        public IWebElement SearchButton1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Search')])[2]")]
        public IWebElement SearchButton2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]//button[contains(text(),'Select')]")]
        public IWebElement ReviewTemplateSelect_Button { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement Name_TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        public IWebElement Submit_Button { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Cancel']")]
        public IWebElement Cancel_Button { get; set; }

        [FindsBy(How = How.Id, Using = "Dto_StartDate")]
        public IWebElement StartDate_TextBox { get; set; }

        [FindsBy(How =How.Id,Using = "Dto_StartDate")]
        public IWebElement DateTestBox { get; set; }

      

        public void createreview(string name)
        {
            HomePage home = new HomePage(_driver);
            DataRow data = ExcelData.GetData_DataTable("EP_Reviews", "Review", "KeyName", "Review_01").Rows[0];
            ReviewTemplatesPage reviewTemplate = new ReviewTemplatesPage(_driver);

            home.EperformReviewsArrowOption.Click();
            home.EperformReviewsIcon.Click();
            Thread.Sleep(2000);
            AddReviewButton.Click();
            Keywords_TextBox.SendKeys(name);
            SearchButton1.Click();
            ReviewTemplateSelect_Button.Click();
            DateTestBox.SendKeys("StartDate");
            Submit_Button.Click();
            BaseMethods.webelementverify(EperformSuccessMessage);
            Thread.Sleep(3000);
            reviewTemplate.UseBandingCheckBox.Click();
            Thread.Sleep(3000);
            reviewTemplate.ConfigureBandingButton.Click();
            reviewTemplate.NumberOfBandsTextBox.Clear();
            reviewTemplate.NumberOfBandsTextBox.SendKeys(data["NumberofBands"].ToString());
            reviewTemplate.UpdateButton.Click();
            Thread.Sleep(3000);
            int count = Convert.ToInt32(data["NumberofBands"]);
            for (int i = 0; i < count; i++)
            {
                int j = 20 +20+ i;
                string nametext = j.ToString();
                string Brandnameid = "Dto.ReviewBands[" + i + "].Name";
                _driver.FindElement(By.Name(Brandnameid)).SendKeys(data["BandName"].ToString());
                string brandDesName = "Dto.ReviewBands[" + i + "].Description";
                _driver.FindElement(By.Name(brandDesName)).SendKeys(data["BandDescription"].ToString());
                string reviewBands = "Dto.ReviewBands[" + i + "].AdditionalCriteriaId";
                _driver.FindElement(By.Name(reviewBands)).Click();
                BaseMethods.DdlSelectByText(_driver.FindElement(By.Name(reviewBands)), data["AdditionalCriteria"].ToString());
                string reviewTextBox = "Dto.ReviewBands[" + i + "].EndRange";

                //reviewTemplate.ReviewBandsTextBox.Clear();
                //_driver.FindElement(By.Name(reviewTextBox)).SendKeys(nametext);
                string valuename = "Dto.ReviewBands[" + i + "].AdditionalCriteriaValue";
                _driver.FindElement(By.Name(valuename)).SendKeys(data["Value"].ToString());
            }
            reviewTemplate.ReviewBandsTextBox.SendKeys(data["BandValue"].ToString());
            reviewTemplate.SaveButton.Click();
            Thread.Sleep(3000);
            //CancelButton.Click();
            _driver.FindElement(By.XPath("//button[@class='close']")).Click();
            Thread.Sleep(2000);
            if (data["UserInformationOnReview"].ToString() == "At Time Review Starts")
            {
                reviewTemplate.informationReviewAtTimeReviewStart.Click();
            }
            else
            {
                reviewTemplate.informationReviewAlwaysCurrent.Click();
            }
            reviewTemplate.createEmailTemplate();
            reviewTemplate.createPopupNotofication();
            reviewTemplate.createDevelopmentPhase();
            reviewTemplate.createGoalSetting();
            reviewTemplate.createQuestionnaireSetting();
            reviewTemplate.createCompetency();
            reviewTemplate.createInformation();
            reviewTemplate.Summary();
    }
        public void AssociatedUsers()
        {

        }
    }
}
