using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class MyTestService
    {
        public async Task<string> GetCountriesJsonAsync(string name)
        {
            using var client = CreateClient();
            var url = $"https://restcountries.eu/rest/v2/name/{name}";
            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("Unknown Error");
            }

            return await response.Content.ReadAsStringAsync();
        }

        private HttpClient CreateClient()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}