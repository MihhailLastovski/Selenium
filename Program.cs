using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


class Program
{
    static void Main()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--disable-notifications");

        IWebDriver driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("https://www.google.com");

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        IWebElement consentButton = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("L2AGLb")));

        if (consentButton != null && consentButton.Displayed)
        {
            consentButton.Click(); 
        }
        IWebElement searchBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("q")));
        System.Threading.Thread.Sleep(5000);

        searchBox.SendKeys("tthk");

        searchBox.Submit();

        System.Threading.Thread.Sleep(5000);

        driver.Quit();
    }
}
