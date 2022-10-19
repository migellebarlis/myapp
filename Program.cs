// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver(@"/Users/migellejosebarlis/webdriver");
driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

var title = driver.Title;

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

var textBox = driver.FindElement(By.CssSelector("#my-text-id"));
var submitButton = driver.FindElement(By.TagName("button"));

textBox.SendKeys("Selenium");
submitButton.Click();

var message = driver.FindElement(By.Id("message"));
var value = message.Text;

driver.Quit();