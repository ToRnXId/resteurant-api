using ResteurantClientApp.Services.Common.Interfaces;
using RestSharp;

namespace ResteurantClientApp.Services.Common
{
    public class RestClientService : IRestClientService
    {
        private const string baseUrl = "https://localhost:7013";
        private RestClient GetClient()
        {
            return new RestClient(baseUrl);
        }

        public async Task<RestResponse> Get(string resource)
        {
            try
            {
                var client = GetClient();
                var request = new RestRequest(resource, Method.Get);
                return await client.ExecuteAsync(request);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc.InnerException);
            }
        }
    }
}
