using System;
using NUnit.Framework;
using ShoeStore.Pages;
using TechTalk.SpecFlow;

namespace ShoeStore.StepDefinitions
{
    [Binding]
    public class SubmitEmailForReminderSteps
    {
        private readonly ShoeStoreBasePage page = new ShoeStoreBasePage();

        [When(@"I submit (.*)")]
        public void WhenISubmit(string email)
        {
            page.SubmitEmail(email);
        }

        [Then(@"I should see a (.*)"), Scope(Feature = "Submit Email For Reminder")]
        public void ThenIShouldSee(string notice)
        {
            var s = page.GetSubmissionMessage().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(notice, s[0]);
        }
    }
}
