using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
namespace SelenuimTests;

public class UnitTest1
{
    private ChromeDriver driver;
    public UnitTest1()
    {
         driver = new ChromeDriver(@".\bin\debug\net6.0\");
    }


    [Fact]
    public void Test1()
    {
        driver.Navigate().GoToUrl("https://www.google.com");
        driver.FindElement(By.Name("q")).SendKeys("Fleek It solutions"+ Keys.Return);
        Thread.Sleep(2000);
        driver.Quit();
    }
}

