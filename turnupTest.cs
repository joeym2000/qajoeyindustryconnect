
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//TEST - Verify is user can successfully log in
// Open Browser using chrome
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Open turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
// Identify Username textbox and enter valid username
IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");

// Identify Password textbox and enter valid password
IWebElement password = driver.FindElement(By.Id("Password"));
password.SendKeys("123123");

// Click log in button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// Validate if user is logged in
IWebElement loggedInText = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (loggedInText.Text == "Hello hari!")
{
    Console.WriteLine("User is logged in");
}
else
{
    Console.WriteLine("User is not logged in");
}

// Create new time record

// Navigate to time and material page
IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();

IWebElement timeAndMaterialButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterialButton.Click();

// Click create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
createNewButton.Click();

// Select Time code on typecode drop down
IWebElement dropDownButton = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[2]/span"));
dropDownButton.Click();
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
timeOption.Click();

// Input Code
IWebElement codeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
codeTextBox.SendKeys("google");

// Input Description
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.SendKeys("August");

// Input Price per unit
IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
priceTextBox.SendKeys("30000");

// Price save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

// Assert if record is created
IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]/span"));
lastPageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "google")
{

    Console.WriteLine("Time Record Created Successfully");
}
else
{
    Console.WriteLine("Time Record Not Found");
}

// Edit last item 
Thread.Sleep(3000);
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[last()]/a[1]"));
editButton.Click();

// Input new code
IWebElement editCodeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
editCodeTextBox.Click();
editCodeTextBox.Clear();
editCodeTextBox.SendKeys("july");

// Input new description
IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
editDescriptionTextBox.Clear();
editDescriptionTextBox.SendKeys("new test");
Thread.Sleep(1000);

// Input new price per unit
IWebElement editPriceTextBox = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
editPriceTextBox.SendKeys("234");

// Save edited items
IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
editSaveButton.Click();
