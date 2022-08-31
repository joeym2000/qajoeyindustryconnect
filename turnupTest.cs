
using Joey_Selenium_TurnUP.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open Browser using chrome
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

// Home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.goToTMpage(driver);

// Time and material page object initialization and definition
TMPage tmPageObj = new TMPage();
tmPageObj.createTM(driver);

// Edit time and material
tmPageObj.editTM(driver);








