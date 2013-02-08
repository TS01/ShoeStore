using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ShoeStore.Support
{
    [Binding]
    public class FeatureHelper
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriver.Initialize(Browser.Chrome);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Driver.Quit();
        }
    }
}
