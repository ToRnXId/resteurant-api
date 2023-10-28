using ResteurantClientApp.Services.Interfaces;

namespace ResteurantClientApp.Containers
{
    public class MainFormServicesContainer
    {
        private readonly IRestClientServices _restClientService;

        public IRestClientServices RestClientService { get { return _restClientService; } }

        public MainFormServicesContainer(IRestClientServices test)
        {
            _restClientService = RestClientService;
        }
    }
}
