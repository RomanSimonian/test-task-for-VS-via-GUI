using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test_task_for_VS_via_GUI
{
    class HomePage : BasePage
    {
        private readonly By _FullNameBar = By.XPath("//input[@id = 'input_comp-jxd8gccb']");
        private readonly By _EmaildBar = By.XPath("//input[@id='input_comp-k5hb1d85']");
        private readonly By _LogInButton = By.XPath("//div[@data-mesh-id='comp-jxd8eo5hinlineContent']//button[@class='_1fbEI']");
       
        public HomePage(IWebDriver driver): base(driver)
        {

        }

        public bool LogIn(string userName, string email)
        {
            var EmailBar = driver.FindElement(_EmaildBar);
            EmailBar.SendKeys(email);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(_FullNameBar));
            
            var nameBar = driver.FindElement(_FullNameBar);
            nameBar.SendKeys(userName);

            driver.FindElement(_LogInButton).Click();
            

            try
            {
                By _Capcha = By.XPath("//div[@class='_1p53U']");
                wait.Until(ExpectedConditions.ElementExists(_Capcha));
                var popUpText = driver.FindElement(_Capcha);
                return IsElementVisible(_Capcha);
            }
            catch
            {
                return false;
            }  
        }
    }
}
