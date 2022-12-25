using BlazorSpinner;
using Dolly.Client.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Dolly.Client.Pages
{
    public class DollyRequest
    {
        public DollyRequest(Input input)
        {
            Input = input;
        }

        public Input Input { get; set; }

        public List<Result> Results = new();

        public async Task<string?> RequestImage(string ApiKey)
        {
            using var client = new HttpClient();
            // clear the default headers to avoid issues
            client.DefaultRequestHeaders.Clear();

            // add header authorization and use your API KEY
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ApiKey);

            //  call the  api using post method and set the content type to application/json
            var serializeObject = JsonConvert.SerializeObject(Input);
            var stringContent = new StringContent(serializeObject, Encoding.UTF8, "application/json");
            var message = await client.PostAsync("https://api.openai.com/v1/images/generations",
                stringContent);

            // if result OK
            // read the content and deserialize it using the Response Model
            // then return the response object
            if (!message.IsSuccessStatusCode) return message.ReasonPhrase;

            var content = await message.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseModel>(content);

            foreach (var link in resp.data)
            {
                Results.Insert(0, new Result() { Url = link.url, Prompt = Input.prompt });
            }

            return message.ReasonPhrase;
        }
    }
}
