using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining
{
    public class BaseTest
    {
        public string elementId;

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://ansntest.wordpress.com/wp-admin/");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public BaseTest IsAtPage(string elementId)
        {
            this.elementId = elementId;
            return this;
        }
    }
}
