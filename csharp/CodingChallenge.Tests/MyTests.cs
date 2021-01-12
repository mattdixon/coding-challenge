using System;
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

        /// <summary>
        /// Ensure we're getting JSON data back from the service.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AsyncTest()
        {
            var json = await ItemUnderTest.GetCountriesJsonAsync(SearchString);
            Console.WriteLine(json);
            Assert.IsNotEmpty(json);
        }

        /// <summary>
        /// Verify that the <c>ItemUnderTest</c> property is instantiated.
        /// </summary>
        [Test]
        public void Constructor()
        {
            // Assert.IsNotNull(ItemUnderTest);
        }

        /// <summary>
        /// This test will make sure that countries returned have the following fields:
        /// Name, Region, and Lat / Lon
        /// Note: This is a subset of the fields coming back from the API.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetCountries()
        {
            // var countries = await ItemUnderTest.GetCountriesAsync(SearchString);
            // Assert.IsNotNull(countries);
            // Assert.Greater(countries.Count, 0);
            // var country = countries.First();
            // Console.WriteLine($"name:{country.Name} region:{country.Region} lat/lon:({country.Latlng?.First()}, {country.Latlng?.Last()})");
            // Console.WriteLine(JsonConvert.SerializeObject(countries));
        }

        /// <summary>
        /// Ensures that countries are returned in ascending order and contain the following properties:
        /// Name, Region, Latitude, Longitude
        /// Note: This takes the object from the API and transforms it. The lat and lon are separated into their own properties instead of an array.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetCountriesAssertData()
        {
            // var countries = await ItemUnderTest.GetCountriesTransformedAsync(SearchString);
            // Assert.IsNotNull(countries);
            // Assert.Greater(countries.Count, 0);

            // var country = countries.First();
            // Console.WriteLine($"name:{country.Name} region:{country.Region} lat/lon:({country.Latitude}, {country.Longitude})");

            // foreach (var c in countries)
            // {
            //     Assert.IsFalse(string.IsNullOrWhiteSpace(c.Name));
            // }
        }

        /// <summary>
        /// Ensures that countries are returned in descending order and contain the following properties:
        /// Name, Region, Latitude, Longitude
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetCountriesAssertDescendingName()
        {
            // var countries = await ItemUnderTest.GetCountriesDescendingAsync(SearchString);
            // Assert.IsNotNull(countries);
            // Assert.Greater(countries.Count, 0);

            // var expected = countries.OrderByDescending(c => c.Name).ToList();
            // var country = expected.First();
            // Console.WriteLine($"name:{country.Name} region:{country.Region} lat/lon:({country.Latitude}, {country.Longitude})");

            // Assert.IsNotNull(expected);
            // Assert.AreEqual(countries.Count, expected.Count());
            // for (var i = 0; i < expected.Count; i++)
            // {
            //     var c = countries[i];
            //     var e = expected[i];

            //     Assert.AreEqual(e.Name, c.Name);
            // }
        }

        /// <summary>
        /// Groups countries by region sorted alphabetically.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetGroupedCountriesAsync()
        {
            // var groups = await ItemUnderTest.GetGroupedCountriesAsync(SearchString);
            // foreach (var g in groups)
            // {
            //     Console.WriteLine(g.Region);
            //     foreach (var country in g.Countries)
            //     {
            //         Console.WriteLine($"\t{country.Name}");
            //     }
            // }
        }
    }
}