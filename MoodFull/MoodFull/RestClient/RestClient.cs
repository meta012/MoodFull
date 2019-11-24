using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MoodFull.RestClient
{
    public class RestClient<T>
    {
        // KEISTI IP adresa, pagal ta, kuris nurodytas SharpProxy. 
        // External port SharpProxy nustatyti 5000
        private const string url = "http://192.168.1.131:5000/api/Users";
        public async Task<List<T>> GetAsync()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(url);
            var taskModels = JsonConvert.DeserializeObject<List<T>>(json);
            return taskModels;
        }

        //Insertina naujus. Nauja entity
        public async Task<bool> PostAsync(T t)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PostAsync(url, httpContent);
            return result.IsSuccessStatusCode;
        }

        //Updatina duomenis
        public async Task<bool> PutAsync(long id, T t)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(t);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await httpClient.PutAsync(url + id, httpContent);
            return result.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteAsync(long id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync(url + id);
            return response.IsSuccessStatusCode;
        }
    }
}
