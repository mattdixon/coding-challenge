using System.Threading.Tasks;
using NUnit.Framework;

namespace CodingChallenge.Tests
{
    public class MyTests
    {
        // the country search string
        private string SearchString => "u";
        private MyTestService ItemUnderTest { get; set; }

        [SetUp]
        public void Setup() { }

        [Test]
        public async Task AsyncTest()
        {
            var json = await ItemUnderTest.GetCountriesJsonAsync(SearchString);
            Assert.IsNotEmpty(json);
        }
    }
}