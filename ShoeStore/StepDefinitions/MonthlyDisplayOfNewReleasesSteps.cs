using System;
using System.Globalization;
using NUnit.Framework;
using ShoeStore.Pages;
using TechTalk.SpecFlow;

namespace ShoeStore.StepDefinitions
{
    [Binding]
    public class MonthlyDisplayOfNewReleasesSteps
    {
        private readonly ShoeStoreHomePage homePage = new ShoeStoreHomePage();

        [Given(@"I am at the Shoe Store site")]
        public void GivenIAmAtTheShoeStoreSite()
        {
            homePage.Navigate();
        }

        [When(@"I choose (.*)")]
        public void WhenIChoose(string month)
        {
            homePage.ChooseMonth(month);
        }
        
        [Then(@"I should see a small Blurb for each shoe")]
        public void ThenIShouldSeeASmallBlurbForEachShoe()
        {
            var shoes = homePage.GetShoeList();

            foreach (var shoe in shoes)
            {
                Assert.AreNotEqual(string.Empty, shoe.Blurb);
            }
        }
        
        [Then(@"I should see an image for each shoe")]
        public void ThenIShouldSeeAnImageForEachShoe()
        {
            var shoes = homePage.GetShoeList();

            foreach (var shoe in shoes)
            {
                Assert.AreNotEqual(string.Empty, shoe.ImageSource);
            }
        }
        
        [Then(@"I should see a suggested retail price for each shoe")]
        public void ThenIShouldSeeASuggestedRetailPriceForEachShoe()
        {
            var shoes = homePage.GetShoeList();

            foreach (var shoe in shoes)
            {
                var price = decimal.Parse(shoe.Price, NumberStyles.Currency);
                Assert.IsNotNull(price);
            }
        }
    }
}
