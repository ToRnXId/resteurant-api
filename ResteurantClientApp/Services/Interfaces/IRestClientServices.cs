using RestSharp;

namespace ResteurantClientApp.Services.Interfaces
{
    public interface IRestClientServices
    {
        RestClient? GetClient();
    }
}
