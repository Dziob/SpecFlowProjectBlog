using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.Runtime;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectBlog.Helpers
{
    internal class DriverFactory
    {
        public static IWebDriver ReturnDriver (DriverType driverType)
        {
            IWebDriver driver;
            switch (driverType)
            {
                case driverType.Chrome:
                    driver=new ChromeDriver();
                    break;

                    case driverType.Firefox:
                    driver=new FirefoxDriver(); 
                    break;

                case driverType.Edge:
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(driverType), driverType, null);
            }

            return driver;

        }
    }

    internal enum DriverType
    {
        Chrome,
        Firefox,
        Edge,
    }
}