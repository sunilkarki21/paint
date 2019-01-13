

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Paint
{
    class Git
    {
        public Git()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://github.com/login";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("login_field")).SendKeys("sunilkarki2k16@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("!!github@2018!!");
            driver.FindElement(By.Name("commit")).Click();
            driver.FindElement(By.XPath("//span[@title='paint']")).Click();
        }



    }
}
