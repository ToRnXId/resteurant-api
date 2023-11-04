using RestSharp;

namespace ResteurantClientApp.Services.Common.Interfaces
{
    public interface IRestClientService
    {
        Task<RestResponse> Get(string resource);
    }
}
