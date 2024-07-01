using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DexscreenerApiManager.Component;
using Newtonsoft.Json;

namespace DexscreenerApiManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ApiManagement _api = new ApiManagement();
            DexscreenerResponse result = _api.GetValues("");
            Console.WriteLine(result);
        }

        
    }
}