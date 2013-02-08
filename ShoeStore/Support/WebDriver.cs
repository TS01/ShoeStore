using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace ShoeStore.Support
{
    public static class WebDriver
    {        
        public static IWebDriver Driver { get; set; }
        public static Browser Browser { get; set; }

        /// <summary>
        /// Initalizes a new instance of a browser driver
        /// </summary>
        /// <param name="browser">The browser driver to initialize</param>
        public static void Initialize(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case Browser.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case Browser.IE:
                    Driver = new InternetExplorerDriver();
                    break;
            }
        }
    }

    public enum Browser { Chrome, Firefox, IE };
}
