using OpenQA.Selenium.Appium.Windows;
using SeleniumTests.Tests;
using System.Threading;
using Xunit;

namespace CleanCodeSeries.Workshop.Lesson8.Tests.Desktop
{
    public class CalculatorTests:IClassFixture<ApiumDriverFixture>
    {
        private WindowsDriver<WindowsElement> _driver;

        public CalculatorTests(ApiumDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }
             
        [Fact]
        public void TwoNumbers_Addition_Ok()
        {
            // Finds element by text rendered.
            _driver.FindElementByName("1").Click();
            _driver.FindElementByName("+").Click();
            _driver.FindElementByName("2").Click();
            _driver.FindElementByName("=").Click();

            // Finds element by control id.
            var result = _driver.FindElementByAccessibilityId("TextBoxResult");

            Assert.Equal("3", result.Text);

            _driver.FindElementByName("C").Click();
            Assert.Equal("", result.Text);
        }
    }
}
