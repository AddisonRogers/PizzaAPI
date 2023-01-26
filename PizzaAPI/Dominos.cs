using System.Diagnostics;

namespace PizzaAPI;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class Dominos
{
    void Main()
    {
        
        
    }
    ChromeDriver Setup(string url, string postcode, string delColChoice)
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        var driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        void PostCode()
        {
            // This is accepting cookies
            string verbatim = @"//*[@id=""onetrust-accept-btn-handler""]";
            driver?.FindElement(By.XPath(verbatim)).Click();
            
            // This is inputting the post code
            driver?.FindElement(By.Name("addressQuery")).SendKeys(postcode);
            
            // This is clicking the correct button depending on the parameters
            string delOrCol;
            switch (delColChoice)
            {
                case "del":
                    delOrCol = @"//*[@id=""app""]/div/section/div/section[1]/div/div/div[3]/button[1]/div";
                    break;
                case "col":
                    delOrCol = @"//*[@id=""menu-page-container""]/div[9]/section/div[2]/div/section/button[2]/div";
                    break;
                default:
                    return;
            }
            driver?.FindElement(By.XPath(delOrCol)).Click();
        }
        return driver;
    }
    void Delivery(ChromeDriver driver, string? pizzaname)
    {
        string path = "/html/body/div[2]/div/div/div/main/section/section[1]/section[1]/div";
        var elements = driver.FindElements(By.XPath(path));
        if (pizzaname == null)
        {
            foreach (var item in elements)
            {
                if (item.FindElement(By.XPath("/div[1]/div[1]/h3")).Text != pizzaname) continue;
                Console.WriteLine(item);
            }
        }
        foreach (var item in elements)
        {
            Console.WriteLine(item);
        }
    }
}

