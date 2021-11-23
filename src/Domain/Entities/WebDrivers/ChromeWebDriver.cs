using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Domain.Entities.WebDrivers
{
    public class ChromeWebDriver : IChromeWebDriver
    {
        public IWebDriver ChromeDriver { get; private set; }

        public ChromeWebDriver()
        {
            ChromeDriver = new ChromeDriver();
        }


        public void NavigateTo(string url)
        {
            ChromeDriver.Navigate().GoToUrl(url);
        }

        public void OpenTab(string url)
        {
            ((IJavaScriptExecutor)ChromeDriver).ExecuteScript("window.open();");
            ChromeDriver.SwitchTo().Window(ChromeDriver.WindowHandles.Last());
        }
    }
}
