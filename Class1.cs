﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class First5TestsTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    string baseURL = "http://localhost/prog2070a03";

    [Test]
    public void prog2070a03_Age25_DrivingExperience3_Accidents0_Verify3500()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(1693, 1015);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.CssSelector(".card-body")).Click();
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$3500"));
        }
    }
    [Test]
    public void prog2070a03_Age25_DrivingExperience3_Accidents4_VerifyNoInsurance()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void prog2070a03_Age35_DrivingExperience10_Accidents2_Verify1600()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.CssSelector(".col-md-2")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$1600"));
        }
    }
    [Test]
    public void prog2070a03_InvalidPhoneNumber_Age27_DrivingExperience3_Accidents0_VerifyPhoneNumberError()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("2269719207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("16");
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
    
    }
    [Test]
    public void prog2070a03_InvalidEmailAddress_Age28_DrivingExperience3_Accidents0_VerifyErrorEmailAddressError()
    {
        //Arrange
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);

        //Act
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucas");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }

        //Assert
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }

    [Test]
    public void prog2070a03_InvalidPostalCode_Age35_DrivingExperience17_Accidents1_VerifyPostalCodeError()
    {
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
    }
    [Test]
    public void prog2070a03_AgeOmmited_DrivingExperience5_Accidents0_VerifyAgeError()
    {
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
    }
    [Test]
    public void prog2070a03_Age37_DrivingExperience8_AccidentsOmmited_VerifyAccidentsError()
    {
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }
    [Test]
    public void prog2070a03_Age45_DrivingExperienceOmitted_Accidents0_VerifyDrivingExperienceError()
    {
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.CssSelector("option:nth-child(1)")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
    }
    [Test]
    public void prog2070a03_Age50_DrivingExperience30_AccidentsNegative2_VerifyAccidentsError()
    {
        driver.Navigate().GoToUrl(baseURL);
        driver.Manage().Window.Size = new System.Drawing.Size(850, 808);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Lucas");
        driver.FindElement(By.Id("lastName")).SendKeys("Arndt");
        driver.FindElement(By.Id("address")).SendKeys("43 Hume Road");
        driver.FindElement(By.Id("city")).SendKeys("Puslinch");
        driver.FindElement(By.Id("postalCode")).SendKeys("N0B 2J0");
        driver.FindElement(By.Id("phone")).SendKeys("226-971-9207");
        driver.FindElement(By.Id("email")).SendKeys("lucasarndt7@gmail.com");
        driver.FindElement(By.Id("age")).SendKeys("50");
        driver.FindElement(By.Id("experience")).SendKeys("30");
        driver.FindElement(By.Id("accidents")).SendKeys("-2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 0."));
    }
}
