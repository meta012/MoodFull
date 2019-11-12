using MoodFull.Interfaces;
using MoodFull.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MoodFull.MoodDetectors
{
    public class AzureMoodDetector : IMoodDetector
    {
        private const string subscriptionKey = "850a4b31e6d546b3938f994074acad6f";
        private const string uriBase = "https://faceapieservice.cognitiveservices.azure.com/face/v1.0/detect";

        public async Task<MoodModel> GetEmotions(byte[] byteArray)
        {
            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

                //parameters of what data should be returned about the face
                string requestParameters = "returnFaceId=false&returnFaceLandmarks=false" +
                    "&returnFaceAttributes=emotion";

                // Assemble the URI for the REST API Call.               
                string uri = uriBase + "?" + requestParameters;                

                HttpResponseMessage response;

                using (ByteArrayContent content = new ByteArrayContent(byteArray))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    // Execute the REST API call.
                    response = client.PostAsync(uri, content).GetAwaiter().GetResult();

                    // Get the JSON response.
                    string contentString = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON string
                    MoodModel moodModel = JsonConvert.DeserializeObject<MoodModel>(contentString.Substring(1, contentString.Length - 2));

                    return moodModel;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message + "\nPress Enter to exit...\n");
                return new MoodModel();
            }
        }
    }
}
