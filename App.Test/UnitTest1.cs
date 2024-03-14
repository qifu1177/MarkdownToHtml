using App.Service;

namespace App.Test
{
    public class Tests
    {
        private ConvertService _service;
        [SetUp]
        public void Setup()
        {
            _service = new ConvertService();
        }

        [Test]
        public void Test1()
        {
            string html = _service.MarkdownToHtml("# Kopfzeile");
            Assert.AreEqual("<h1>Kopfzeile</h1>", html);
        }
        [Test]
        public void Test2()
        {
            string html = _service.MarkdownToHtml("###### Kopfzeile");
            Assert.AreEqual("<h6>Kopfzeile</h6>", html);
        }
        [Test]
        public void Test3()
        {
            string html = _service.MarkdownToHtml("  ### Kopfzeile");
            Assert.AreEqual("  <h3>Kopfzeile</h3>", html);
        }
        [Test]
        public void Test4()
        {
            string html = _service.MarkdownToHtml("  ## #Kopfzeile#  ");
            Assert.AreEqual("  <h2>#Kopfzeile#  </h2>", html);
        }
        [Test]
        public void Test5()
        {
            string html = _service.MarkdownToHtml("##  Kopfzeile");
            Assert.AreEqual("##  Kopfzeile", html);
        }
        [Test]
        public void Test6()
        {
            string html = _service.MarkdownToHtml("#. Kopfzeile");
            Assert.AreEqual("#. Kopfzeile", html);
        }
        [Test]
        public void Test7()
        {
            string html = _service.MarkdownToHtml("** Kopfzeile");
            Assert.AreEqual("** Kopfzeile", html);
        }
		[Test]
		public void Test8()
		{
			string html = _service.MarkdownToHtml("# ## Kopfzeile");
			Assert.AreEqual("<h1>## Kopfzeile</h1>", html);
		}
	}
}