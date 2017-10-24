using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using System;
using System.Configuration;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using EPerform.Library;
using System.Collections;
using EPerform.Library.Excel;

using System.IO;
using System.Reflection;
using ePerform.Library.Extent_Reports;
using RelevantCodes.ExtentReports;
using System.Threading;
using EPerform.Pages;
using OpenQA.Selenium;
using System.Windows.Forms;
namespace ePerfrom.Library
{

    public class BaseClass
    {
        public static IWebDriver LaunchBrowser()
        {
            string _BrowserType = ConfigurationManager.AppSettings["Browser"];
            string _url = ConfigurationManager.AppSettings["URL"];
            int wait = Convert.ToInt32(ConfigurationManager.AppSettings["Wait"]);

            if (_BrowserType == "IE")
            {
                IWebDriver _Idriver;
                InternetExplorerOptions d = new InternetExplorerOptions();
                d.InitialBrowserUrl = _url;
                _Idriver = new InternetExplorerDriver(d);
               // _Idriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
               // _Idriver.Navigate().GoToUrl("javascript:document.getElementById('overridelink').click()");
                
                //_Idriver.Manage().Window.Maximize();
                return _Idriver;
            }
            else if (_BrowserType == "Firefox")
            {
                IWebDriver _Fdriver = new FirefoxDriver();
                _Fdriver.Navigate().GoToUrl(_url);
                _Fdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
                // _Fdriver.Manage().Window.Maximize();
              
                return _Fdriver;
            }
            else if (_BrowserType == "Chrome")
            {
                Console.WriteLine("Launching Chrome Browser");
                IWebDriver _Cdriver = new ChromeDriver();
                _Cdriver.Navigate().GoToUrl(_url);
                _Cdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
                Console.WriteLine("Loaded URL is: " + _url);
                BaseMethods.IsAlertPresent(_Cdriver, "Accept");
                _Cdriver.Manage().Window.Maximize();
                return _Cdriver;
            }
            else if ((_BrowserType == "Edge"))
            {
                IWebDriver _MEdriver = new EdgeDriver();
                _MEdriver.Navigate().GoToUrl(_url);
                _MEdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
                _MEdriver.Navigate().GoToUrl("javascript:document.getElementById('moreInformationDropdownSpan').click()");
                Thread.Sleep(3000);
                _MEdriver.Navigate().GoToUrl("javascript:document.getElementById('invalidcert_continue').click()");
                return _MEdriver;
            }
            else
            {
                return null;
            }
        }
        public static ArrayList GetData(string Key, string Sheet, string Condition, string Value)
        {
            ArrayList list = ExcelData.GetData(Key, Sheet, Condition, Value);
            return list;
        }


        public static void fileupload(String filepath)
        {
            String file = DirPath() + filepath;


            SendKeys.SendWait(@file);
            SendKeys.SendWait(@"{Enter}");
        }

        public static string DirPath()
        {
            string CurrDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dirPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int binIndex = dirPath.IndexOf("bin");
            dirPath = dirPath.Substring(0, binIndex);
            return dirPath;
        }

       


    }
}