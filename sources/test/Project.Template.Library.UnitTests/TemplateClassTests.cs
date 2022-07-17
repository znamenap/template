using NUnit.Framework;

namespace Project.Template.Library.UnitTests
{
    public class TemplateClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            new TemplateClass();
            Assert.Pass();
        }
    }
}