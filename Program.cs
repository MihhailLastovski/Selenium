using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Set the path to the ChromeDriver executable
        var driverPath = "C:/Users/lasto/Downloads/chromedriver_win32";

        // Create a ChromeDriver instance
        IWebDriver driver = new ChromeDriver(driverPath);

        // Navigate to a website (e.g., Google)
        driver.Navigate().GoToUrl("https://www.google.com");

        // Find the search input element and type a query
        IWebElement searchBox = driver.FindElement(By.Name("q"));
        searchBox.SendKeys("Your search query");

        // Submit the search
        searchBox.Submit();

        // Wait for a few seconds (you may need to add proper waits)
        System.Threading.Thread.Sleep(5000);

        // Close the browser
        driver.Quit();
    }
}
