using OpenQA.Selenium;
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
            var paswordBar = driver.FindElement(_EmaildBar);
            paswordBar.SendKeys(email);
            Thread.Sleep(1500);//TODO replase by normal waiting

            var nameBar = driver.FindElement(_FullNameBar);
            nameBar.SendKeys(userName);

            driver.FindElement(_LogInButton).Click();
            Thread.Sleep(1500);//TODO replase by normal waiting

            try
            {
                By _PopUpText = By.XPath("//div[@class='_1p53U']");
                var popUpText = driver.FindElement(_PopUpText);
                return IsElementVisible(_PopUpText);
            }
            catch
            {
                return false;
            }  
        }
    }
}
