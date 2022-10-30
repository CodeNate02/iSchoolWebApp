using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//these we had to include!
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace iSchoolWebApp.Services
{
    public class GetAll //Modified get scripts to get a model or list of models from API.
    {
        public String apiSource { get; set; } //What is the API's URL
        private async Task<String> grab(String src)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiSource);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(src, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException hre) //Catch any HTTP errors
                {
                    var msg = hre.Message;
                    Console.WriteLine(hre.Message);
                    return "";
                }
            }
        }
        public async Task<List<T>> GetList<T>(String src) //Retrieves a list of objects
        {
            try
            {
                //different/new code here...
                //make json out of data
                String data = await grab(src);
                var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<T>>>(data);

                //now that I have the dictionary of 'faculty':List<Faculty>
                //first, create a LIst to put it into
                List<T> returnList = new List<T>();

                //iterate through the data in rtnResults
                foreach (KeyValuePair<string, List<T>> kvp in rtnResults)
                {
                    foreach (var item in kvp.Value)
                    {
                        returnList.Add(item);
                    }
                }
                return returnList;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return new List<T>();
            }
        }
        public async Task<T> GoGet<T>(String src, Boolean inner)
        {
            try
            {
                var data = await grab(src);
                Console.WriteLine(src+':');
                T rtnResults = default(T);
                //turn it into JSON and cast into <About>
                if (inner) //Inner = true if there's an outer layer to strip off
                {
                    var dictionary = JsonConvert.DeserializeObject<Dictionary<string, T>>(data);
                    foreach (KeyValuePair<string, T> kvp in dictionary)
                    {
                        rtnResults = kvp.Value;
                    }
                }
                else
                {
                    rtnResults = JsonConvert.DeserializeObject<T>(data);
                }
                return rtnResults;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                T ab = default(T);
                return ab;
            }
        }

    }
}
