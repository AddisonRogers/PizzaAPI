
/*
new DriverManager().SetUpDriver(new ChromeConfig());
var driver = new ChromeDriver();

driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
var textBox = driver.FindElement(By.Name("my-text"));
var submitButton = driver.FindElement(By.TagName("button"));
textBox.SendKeys("Selenium");
submitButton.Click();

var message = driver.FindElement(By.Id("message"));
var value = message.Text;
Console.WriteLine(value);



driver = new ChromeDriver();
driver.Url = "https://www.google.com/ncr";
driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);

WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(1));
IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//a/h3")));

Console.WriteLine(firstResult.Text);


driver.Quit();


// Cookies
// //*[@id="onetrust-accept-btn-handler"]
// Postcode box
// //*[@id="formulate---1"]/input

// Delivery button
// //*[@id="app"]/div/section/div/section[1]/div/div/div[3]/button[1]/div
// Menu Button
// //*[@id="menu-page-container"]/div[9]/section/div[2]/div/section/button[2]/div
// Section //*[@id="pizza"]/section[1]
// Each pizza /div[x]







// Collection button
// //*[@id="app"]/div/section/div/section[1]/div/div/div[3]/button[2]/div
// The first option for delivery
// //*[@id="app"]/div/main/div/section/div[1]/div[2]/div[1]/div[3]/button/div
// TODO Logic here for multiple different options and also to say if it cant deliver etc
*/