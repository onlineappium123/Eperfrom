using EPerform.Library;
using EPerform.Library.Excel;
using ePerfrom.Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPerform.Pages
{
    class ReferenceMaterialPage
    {
        IWebDriver _driver;


        public ReferenceMaterialPage(IWebDriver browser)
        {
            this._driver = browser;
            PageFactory.InitElements(_driver, this);
        }

        

        /// <summary>
        ///  Eperform Add Document Button
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Add Document')]")]
        public IWebElement EperformAddDocumentButton { get; set; }


        /// <summary>
        ///  Eperform Add Document Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_Name")]
        public IWebElement EperformNameTextBox { get; set; }



        /// <summary>
        ///  Eperform NameBlankErrorMessage
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'The Name field is required.')]")]
        public IWebElement EperformNameBlankErrorMessage { get; set; }

        /// <summary>
        ///  Eperform FileBlankErrorMessage
        /// </summary>
        [FindsBy(How = How.XPath, Using = " //span[contains(text(),'The File field is required.')]")]
        public IWebElement EperformFileBlankErrorMessage { get; set; }


        /// <summary>
        ///  Eperform CategoryText
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Category')]")]
        public IWebElement EperformCategoryText { get; set; }


        /// <summary>
        ///  Eperform MustReadText
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Must Read')]")]
        public IWebElement EperformMustReadText { get; set; }


        /// <summary>
        ///  Eperform Supporting Document Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Supporting Document')]")]
        public IWebElement EperformSupportingDocumentText { get; set; }

        /// <summary>
        ///  Eperform Name Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Name']")]
        public IWebElement EperformNameText { get; set; }

        /// <summary>
        /// Eperfrom File   Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Value']")]
        public IWebElement EperformFileText { get; set; }

        /// <summary>
        /// Eperfrom Categoty Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_DocumentTypeId']")]
        public IWebElement EperformCategotyText { get; set; }

        /// <summary>
        /// Eperform Description Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_Description']")]
        public IWebElement EperformDescriptionText { get; set; }

        /// <summary>
        /// Eperform Pillar  Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_PillarId']")]
        public IWebElement EperformPillarText { get; set; }

        /// <summary>
        /// Eperform Date Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_DateDtos_0__Value']")]
        public IWebElement EperformDateText { get; set; }

        /// <summary>
        /// Eperform YesNo Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_BoolDtos_0__Value']")]
        public IWebElement EperformYesNoText { get; set; }

        /// <summary>
        /// Eperform Select_Multiple_Items Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_MultipleGuidDtos_0__Value']")]
        public IWebElement EperformSelect_Multiple_ItemsText { get; set; }

        /// <summary>
        /// Eperform Select_Single_Item Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_GuidDtos_0__Value']")]
        public IWebElement EperformSelect_Single_ItemText { get; set; }



        //
        /// <summary>
        /// Eperform IsActive Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//label[@for='Dto_IsActive']")]
        public IWebElement EperformIsActiveText { get; set; }

        /// <summary>
        /// Eperform File TextBox
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//div[@class='form-control']")]
        public IWebElement EperformFileTextBox { get; set; }

        /// <summary>
        /// Eperform MustRead RadioBtn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_DocumentTypeId_0")]
        public IWebElement EperformMustReadRadioBtn { get; set; }

        /// <summary>
        /// Eperform Supporting Document Radio Button
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_DocumentTypeId_1")]
        public IWebElement EperformSupportingDocumentBtn { get; set; }

        /// <summary>
        /// Eperform Description TextBox 
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_Description")]
        public IWebElement EperformDescriptionTextBox { get; set; }

        /// <summary>
        /// Eperform Active Yes RadioBtn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsActive_t")]
        public IWebElement EperformActiveYesRadioBtn { get; set; }

        /// <summary>
        /// Eperfrom Active No RadioBtn
        /// </summary>
        [FindsBy(How = How.Id, Using = "Dto_IsActive_f")]
        public IWebElement EperfromActiveNoRadioBtn { get; set; }


        /// <summary>
        /// Eperform Select File Button
        /// </summary>
        [FindsBy(How =How.XPath,Using = "//span[@class='input-group-addon btn btn-default btn-file']")]
        public IWebElement EperformSelectFileBtn { get; set; }

        [FindsBy(How =How.XPath,Using = "(//span[@class='input-group-addon btn btn-default btn-file'])[2]")]
        public IWebElement EperfromSelectBtn { get; set; }

        /// <summary>
        /// Eperform Document Name Text
        /// </summary>

        [FindsBy(How =How.XPath,Using = "//td[@class='footable-visible footable-first-column']")]
        public IWebElement EperformDocumentNameText { get; set; }


        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible'])[2]")]
        public IList<IWebElement> EperformHomeCategoryText { get; set; }



        /// <summary>
        /// Eperform Document Name Text
        /// </summary>

        [FindsBy(How = How.XPath, Using = "//td[@class='footable-visible footable-first-column']")]
        public IList<IWebElement> EperformDocumentName { get; set; }

        [FindsBy(How =How.XPath,Using = "//a[@class='btn-xs btn btn-darkblue no-spinner']")]
        public IList<IWebElement> EperformFileNameIcon { get; set; }


        /// <summary>
        /// Eperform Document Yes Text
        /// </summary>
        [FindsBy(How =How.XPath,Using = "(//td[@class='footable-visible'])[3]")]
        public IWebElement EperformDocumentActiveText { get; set; }


        /// <summary>
        /// Eperform Edit Button
        /// </summary>
        [FindsBy(How=How.XPath,Using = "//a[@class='linkToModal btn-xs btn btn-darkblue']")]
        public IWebElement EperformEditBtn { get; set; }


        /// <summary>
        /// Eperform DocumentCategory Text
        /// </summary>
        [FindsBy(How =How.XPath,Using = "(//td[@class='footable-visible'])[2]")]
        public IWebElement EperformDocumentCategoryText { get; set; }

        /// <summary>
        /// Eperform FileDownload Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//a[@class='btn-xs btn btn-darkblue no-spinner']")]
        public IWebElement EperformFileDownloadIcon { get; set; }

        /// <summary>
        /// Eperform ReferenceMaterial Name Icon
        /// </summary>
        [FindsBy(How =How.XPath,Using = "(//button[@class='btn-default  btn list-sort-action'])[1]")]
        public IWebElement EperformReferenceMaterialNameIcon { get; set; }

        /// <summary>
        /// Eperform ReferenceMaterialFileName Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//button[@class='btn-default  btn list-sort-action'])[2]")]
        public IWebElement EperformReferenceMaterialFileNameIcon { get; set; }

        /// <summary>
        /// Eperform ReferenceMaterialCategory Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//button[@class='btn-default  btn list-sort-action'])[3]")]
        public IWebElement EperformReferenceMaterialCategoryIcon { get; set; }

        /// <summary>
        /// Eperform ReferenceMaterialActive Icon
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//button[@class='btn-default  btn list-sort-action'])[4]")]
        public IWebElement EperformReferenceMaterialActiveIcon { get; set; }

        /// <summary>
        /// Eperform Document Active
        /// </summary>
        [FindsBy(How = How.XPath, Using = "(//td[@class='footable-visible'])[3]")]
        public  IList<IWebElement> EperformDocumentActive { get; set; }

        /// <summary>
        ///Eperform Page Text
        /// </summary>
        [FindsBy(How =How.Name,Using = "OnPaging")]
        public IList<IWebElement> EperformPage { get; set; }

        /// <summary>
        /// Eperform AddDevelopmentActivity Button
        /// </summary>
        [FindsBy(How =How.XPath,Using = "//a[contains(text(),'Add Development Activity')]")]
        public IWebElement EperformAddDevelopmentActivityButton { get; set; }
        /// <summary>
        ///Eperform DevelopmentActivities Name Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[text()='Name']")]
        public IWebElement EperformDevelopmentActivitiesNameText { get; set; }

        /// <summary>
        ///Eperform DevelopmentActivities Description Text
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//span[text()='Description']")]
        public IWebElement EperformDevelopmentActivitiesDescriptionText { get; set; }

        [FindsBy(How=How.XPath,Using = "//h3[contains(text(),'Manage Development Activity')]")]
        public IWebElement EperformManageDevelopmentActivityText { get; set; }


        public void verifyManageDevelopmentActivityPage(String pageText)
        {

        }



        public void createdocument()
        {

            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
           // ArrayList list = BaseClass.GetData("EReference_TESTDATA", "ReferenceDocument", "KeyName", "ReferenceMaterialPage_01");
           // 
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceDocument", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                String textvaue = dr["NAME"].ToString() + "_" + DateTime.Now.ToString().Replace(' ', '_').Replace(':', '_').Replace('/', '_');
                BaseMethods.verifyWebElement(EperformNameTextBox, "Name Textbox is not displayed in Mange Document Page", "Name TextBox is displayed Mange Document Page");
                EperformNameTextBox.SendKeys(textvaue);
                System.Threading.Thread.Sleep(3000);
                BaseMethods.verifyWebElement(EperformFileTextBox, "File Textbox is not displayed in Mange Document Page", "File TextBox is displayed Mange Document Page");

                EperformSelectFileBtn.Click();
                System.Threading.Thread.Sleep(4000);
                BaseClass.fileupload(dr["File"].ToString());
                EperformActiveYesRadioBtn.Click();

                BaseMethods.verifyWebElement(EperformDescriptionTextBox, "Description Textbox is not displayed in Mange Document Page", "Description TextBox is displayed Mange Document Page");

                EperformDescriptionTextBox.SendKeys(dr["Description"].ToString());
                if (dr["MustReadCategoryType"].ToString() == "Yes")
                {
                    EperformMustReadRadioBtn.Click();
                }
                if (dr["SupportDocumentCategoryType"].ToString() == "Yes")
                {
                    EperformSupportingDocumentBtn.Click();

                }

                System.Threading.Thread.Sleep(2000);
                if (dr["Active"].ToString() == "Yes")
                {
                    EperformActiveYesRadioBtn.Click();
                }
                else
                {
                    EperfromActiveNoRadioBtn.Click();
                }
                formtemplate.EperformSubmitButton.Click();
                System.Threading.Thread.Sleep(2000);
                formtemplate.EperformFormTemplateSearchTextBox.SendKeys(textvaue);
                formtemplate.EperformFormTemplateSearchButton.Click();
                System.Threading.Thread.Sleep(4000);
                BaseMethods.webelementverify(EperformDocumentNameText);
                BaseMethods.webelementverify(EperformDocumentActiveText);
                BaseMethods.webelementverify(EperformDocumentCategoryText);

                editDocument(textvaue);

            }
        }

        public void editDocument(string name)
        {
            FormTemplatePage formtemplate = new FormTemplatePage(_driver);
           // ArrayList list = BaseClass.GetData("EReference_TESTDATA", "ReferenceDocument", "KeyName", "ReferenceMaterialPage_01");
            DataTable drt = ExcelData.GetData_DataTable("EReference_TESTDATA", "ReferenceDocument", "Enable", "Yes");
            foreach (DataRow dr in drt.Rows)
            {
                System.Threading.Thread.Sleep(2000);
                EperformEditBtn.Click();
                System.Threading.Thread.Sleep(2000);
                EperfromSelectBtn.Click();
                System.Threading.Thread.Sleep(2000);
                BaseClass.fileupload(dr["EditFile"].ToString());
                EperformDescriptionTextBox.Clear();
                EperformDescriptionTextBox.SendKeys(dr["EditDescription"].ToString());
                formtemplate.EperformSubmitButton.Click();
                Thread.Sleep(2000);
                formtemplate.EperformFormTemplateSearchTextBox.SendKeys(name);
                formtemplate.EperformFormTemplateSearchButton.Click();
                System.Threading.Thread.Sleep(2000);
                BaseMethods.webelementverify(EperformDocumentActiveText);
            }
        }
       

    }
}
