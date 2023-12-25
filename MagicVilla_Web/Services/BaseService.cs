using System.Text;
using System.Text.Json;
using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }
        public BaseService(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
            this.responseModel = new();
        }
        public async Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonSerializer.Serialize(apiRequest.Data),
                    Encoding.UTF8, "application/json");
                }

                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                HttpResponseMessage apiResponse = null;

                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var APIResponse = JsonSerializer.Deserialize<T>(apiContent);
                return APIResponse;
            }
            catch (Exception e)
            {
                var dto = new APIResponse
                {
                    ErrorMesages = new List<string> { Convert.ToString(e.Message) },
                    IsSuccess = false
                };

                var res = JsonSerializer.Serialize(dto);
                var APIResponse = JsonSerializer.Deserialize<T>(res);
                return APIResponse;
            }
        }
    }
}