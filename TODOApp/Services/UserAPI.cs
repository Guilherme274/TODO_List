using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace TODOApp.Services
{
    class UserAPI
    {
        private HttpClient _httpClient;

        public UserAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }

        // public async Task RegisterUser(RegisterRequest request)
        // {
        //     await _httpClient.PostAsJsonAsync("register", request);
        // }

        // public async Task LoginUser(LoginRequest request)
        // {
        //     await _httpClient.PostAsJsonAsync("login", request);
        // }
    }
}