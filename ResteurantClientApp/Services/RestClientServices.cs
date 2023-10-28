using ResteurantClientApp.Services.Interfaces;
using RestSharp;

namespace ResteurantClientApp.Services
{
    public class RestClientServices : IRestClientServices
    {
        public RestClient? GetClient()
        {
            return new RestClient("https://localhost:7013");
        }
    }
}
