using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ShoeStore.Support;

namespace ShoeStore.Pages
{
    public class ShoeStoreHomePage : ShoeStoreBasePage
    {
        public static string url = @"http://manheim-shoe-store-uchagani.herokuapp.com/";

        private IReadOnlyCollection<IWebElement> Months
        {
            get { return base.Navigation; }
        }

        private IReadOnlyCollection<IWebElement> Shoes
        {
            get { return WebDriver.Driver.FindElement(By.Id("shoe_list")).FindElements(By.TagName("li")); }
        }

        public void Navigate()
        {
            WebDriver.Driver.Navigate().GoToUrl(url);
        }

        public void ChooseMonth(string month)
        {
            var element =
                from x in Months
                where x.Text == month
                select x;

            var link = element.FirstOrDefault();

            link.Click();
        }

        public List<Shoe> GetShoeList()
        {
            var qry = from s in Shoes
                      select new Shoe
                      {
                          Price = s.FindElement(By.ClassName("shoe_price")).Text,
                          Blurb = s.FindElement(By.ClassName("shoe_description")).Text,
                          ImageSource = s.FindElement(By.ClassName("shoe_image")).FindElement(By.TagName("img")).GetAttribute("src")
                      };
            
            return qry.ToList();
        }
    }

    public class Shoe
    {
        public string Price { get; set; }
        public string Blurb { get; set; }
        public string ImageSource { get; set; }
    }
}
