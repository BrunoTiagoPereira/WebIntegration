
using Domain.Contracts;
using OpenQA.Selenium;
using Domain.Entities.WebDrivers;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();


            serviceProvider.GetService<IChromeWebDriver>();
        }

        private static ServiceProvider ConfigureServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IChromeWebDriver, ChromeWebDriver>()
                .BuildServiceProvider();
                

            return serviceProvider;
        }
    }
}