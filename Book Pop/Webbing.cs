using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Pop
{
    class Webbing:IWebPage
    {
        //current webPage url
        private string _iniWebPage;
        private string _currentWebPage;
        private string _nextWebPage;
        private string _elementName;
        private string _forwardButtonName;
        private IWebDriver driver;
        //------------constructors------------------// 
        #region Constructors
        public Webbing(string webPage)
        {
            _iniWebPage = webPage;
        }
        public Webbing(string webPage, string elementName, string forwardButtonName)
        {
            _iniWebPage = webPage;
            _elementName = elementName;
            _forwardButtonName = forwardButtonName;
        }
#endregion End Constructors
        #region Methods
        //---------------Methods---------------------//
        //create the web driver object to be used and the first webpage
        public void initializeWeb()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(_iniWebPage);
        }
        //close the web driver object
        public void closeWeb()
        {
            driver.Quit();
        }
        //push the next button element
        //args: xpath of button
        public void pushNextButtonByXpath(string button)
        {
            IWebElement buttonElement = driver.FindElement(By.LinkText(button));
            if(buttonElement != null)
            buttonElement.Click();
            
        }
        #endregion End Methods
        #region Interface Implementation
        //-----------Interface Implementation----------//

        public string iniWebPage
        {
            get
            {
                return _iniWebPage;
            }

            set
            {
                _iniWebPage = value;
            }
        }

        public string currentWebPage
        {
            get
            {
                return _currentWebPage;
            }

            set
            {
                _currentWebPage = value;
            }
        }

        public string nextWebPage
        {
            get
            {
                return _nextWebPage;
            }

            set
            {
                _nextWebPage = value;
            }
        }

        public string elementName
        {
            get
            {
                return _elementName;
            }

            set
            {
                _elementName = value;
            }
        }

        public string forwardButtonName
        {
            get
            {
                return _forwardButtonName;
            }

            set
            {
                _forwardButtonName = value;
            }
        }


        #endregion End Interface Implementation
    }//end Webbing class

}//end Book_Pop namespace
