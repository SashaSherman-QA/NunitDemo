using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitDemo
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "www.facebook.com";
            driver.;
            IWebElement emailTextField = driver.FindElement(By.Id("email"));
            emailTextField.SendKeys("Selenium C#");
            driver.Quit();
            //Assert.Pass();
        }
    }
}