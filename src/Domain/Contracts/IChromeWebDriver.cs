using OpenQA.Selenium;

namespace Domain.Contracts;

public interface IChromeWebDriver : IWebDriverBase
{
    public IWebDriver ChromeDriver { get;}
}