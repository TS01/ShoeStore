using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ShoeStore.Support;

namespace ShoeStore.Pages
{
    public class ShoeStoreBasePage
    {
        public IReadOnlyCollection<IWebElement> Navigation
        {
            get { return WebDriver.Driver.FindElement(By.TagName("nav")).FindElements(By.TagName("a")); }
        }

        private IWebElement ReminderEmailInput
        {
            get { return WebDriver.Driver.FindElement(By.Id("remind_email_input")); }
        }

        private IWebElement Notice
        {
            get { return WebDriver.Driver.FindElement(By.ClassName("notice")); }
        }

        public void SubmitEmail(string email)
        {
            ReminderEmailInput.SendKeys(email);
            ReminderEmailInput.Submit();
        }

        public string GetSubmissionMessage()
        {
            return Notice.Text;
        }
    }
}
