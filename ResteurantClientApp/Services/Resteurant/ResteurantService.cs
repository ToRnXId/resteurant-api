using ResteurantClientApp.Services.Common.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ResteurantClientApp.Services.Resteurant
{
    public interface IResteurantService
    {
        Task<List<Contracts.Resteurant>> GetAllResteraunts();
    }
    public class ResteurantService : IResteurantService
    {
        private readonly IRestClientService _restClientService;

        public ResteurantService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<List<Contracts.Resteurant>> GetAllResteraunts()
        {
            var resteurants = new List<Contracts.Resteurant>();

            var response = await _restClientService.Get("/Resteurant"); 
            if (response != null && response.IsSuccessful)
            {
                resteurants = JsonConvert.DeserializeObject<List<Contracts.Resteurant>>(response.Content!);

                return resteurants ?? new List<Contracts.Resteurant>();
            }
            return resteurants;
        }
    }
}
