using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DexscreenerApiManager.Component;
using Newtonsoft.Json;

namespace DexscreenerApiManager
{
    public class ApiManagement
    {
        private const string PairsUrl = "https://api.dexscreener.io/latest/dex/pairs/";
        private async Task<string> CreateResponse(string query)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(PairsUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage response = await client.GetAsync(query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            
            throw new Exception(await response.Content.ReadAsStringAsync());
        }
        
        public DexscreenerResponse GetValues(string query)
        {
            var json = CreateResponse(query).GetAwaiter().GetResult();
            DexscreenerResponse data = JsonConvert.DeserializeObject<DexscreenerResponse>(json);

            return data;
        }
    }
}