using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task_for_VS_via_GUI
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsElementVisible(By element)
        {
            try
            {
                var iv = driver.FindElement(element).Displayed;

                return iv == true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
