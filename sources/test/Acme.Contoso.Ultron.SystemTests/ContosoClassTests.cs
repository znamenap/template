using NUnit.Framework;

namespace Acme.Contoso.Ultron.SystemTests
{
    [Category("Integration")]
    public class ContosoClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            new ContosoClass();
            Assert.Pass();
        }
    }
}