using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divorce_Prediction
{
    public static class SVC
    {
        public static async Task<Double> GetResult(string array)
        {
            string remoteServerUrl = "http://127.0.0.1:5000/divorce-svc";
            using (HttpClient httpClient = new HttpClient())
            {
                string pythonCode = "{\"input\": \"" + array + "\"}";

                StringContent content = new StringContent(pythonCode, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(remoteServerUrl, content);

                double result;
                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    dynamic jsonData = JsonConvert.DeserializeObject(jsonContent);
                    result = Convert.ToDouble(jsonData.result) * 100;
                    return result;
                }
                else
                {
                    Console.WriteLine($"HTTP Hatası: {response.StatusCode}");
                    return 0;
                }
            }
        }
    }
}
