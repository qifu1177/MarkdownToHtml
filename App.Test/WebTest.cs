

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace App.Test
{
	public class WebTest
	{
		private const string url = "http://localhost:5070/";
		private IWebDriver _driver;
		[SetUp]
		public void Setup()
		{
			_driver = new ChromeDriver();
			_driver.Url = url;
		}
		[TearDown]
		public void Close()
		{
			// Schließen des Browsers am Ende des Tests
			_driver.Close();
		}
		private void AreEqual(string inputText, string outputText)
		{
			var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(100));
			var input = wait.Until((driver) =>
			{
				var input = driver.FindElement(By.Id("inputText"));
				return input;
			});
			input.SendKeys(inputText);
			var button = _driver.FindElement(By.Id("btSenden"));
			button.Click();
			Thread.Sleep(500);
			wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(100));
			var htmlPre = wait.Until((driver) =>
			{
				var pre = driver.FindElement(By.Id("outputHtml"));
				return pre;
			});
			Assert.AreEqual(outputText, htmlPre.Text);
		}

		[Test]
		public void Test1()
		{
			AreEqual("# Kopfzeile", "<h1>Kopfzeile</h1>");
		}
		[Test]
		public void Test2()
		{
			AreEqual("###### Kopfzeile", "<h6>Kopfzeile</h6>");
		}
		[Test]
		public void Test3()
		{
			AreEqual("  ### Kopfzeile", "  <h3>Kopfzeile</h3>");
		}
		[Test]
		public void Test4()
		{
			AreEqual("  ## #Kopfzeile#  ", "  <h2>#Kopfzeile#  </h2>");
		}
		[Test]
		public void Test5()
		{
			AreEqual("##  Kopfzeile", "##  Kopfzeile");
		}
		[Test]
		public void Test6()
		{
			AreEqual("#. Kopfzeile", "#. Kopfzeile");
		}
		[Test]
		public void Test7()
		{
			AreEqual("** Kopfzeile", "** Kopfzeile");
		}
		[Test]
		public void Test8()
		{			
			AreEqual("# ## Kopfzeile", "<h1>## Kopfzeile</h1>");
		}

	}
}
