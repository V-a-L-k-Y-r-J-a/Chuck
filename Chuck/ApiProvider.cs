using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chuck
{
    public class ApiProvider
    {
        HttpClient httpClient;
        public ApiProvider()
        {
            httpClient = new HttpClient();
        }
        public async Task<Rootobject> GetJokesAsyncs(string query)
        {
            string request = $"https://api.chucknorris.io/jokes/search?query={query}";
            HttpResponseMessage response =
                (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(responseBody);
            Rootobject rootobject = jObject.ToObject<Rootobject>();
            return rootobject;
        }        
        
        public async Task<string[]> GetCategoriesAsyncs()
        {
            string request = $"https://api.chucknorris.io/jokes/categories";
            HttpResponseMessage response =
                (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JArray jar = JArray.Parse(responseBody);
            return jar.ToObject<string[]>();
        }

        public async Task<Rootobject> GetRanAsyncs()
        {
            string request = $"https://api.chucknorris.io/jokes/random";
            HttpResponseMessage response =
                (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(responseBody);
            Rootobject? rootobject = jObject.ToObject<Rootobject>();
            return rootobject;
        }

    }
}
