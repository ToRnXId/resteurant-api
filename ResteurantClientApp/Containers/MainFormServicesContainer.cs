using ResteurantClientApp.Services.Common.Interfaces;
using ResteurantClientApp.Services.Resteurant;

namespace ResteurantClientApp.Containers
{
    public class MainFormServicesContainer
    {
        private readonly IRestClientService _restClientService;
        private readonly IResteurantService _resteurantService;

        public IRestClientService RestClientService { get { return _restClientService; } }
        public IResteurantService ResteurantService { get { return _resteurantService; } }

        public MainFormServicesContainer(IRestClientService restClientService, IResteurantService resteurantService)
        {
            _restClientService = restClientService;
            _resteurantService = resteurantService;
        }
    }
}
