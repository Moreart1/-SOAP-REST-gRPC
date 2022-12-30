using RootServiceNamespace;

namespace SampleService.Services.Impl
{
    public class RootServiceClient : IRootServiceClient
    {
        #region Services

        private readonly ILogger<RootServiceClient> _logger;
        private RootServiceNamespace.RootServiceClient _httpClient;

        #endregion

        public RootServiceClient(HttpClient httpClient,
            ILogger<RootServiceClient> logger)
        {
            _logger = logger;
            _httpClient = new RootServiceNamespace.RootServiceClient("http://localhost:5006/", httpClient);
        }

        public RootServiceNamespace.RootServiceClient Client => _httpClient;

        public async Task<ICollection<WeatherForecast>> Get()
        {
            return await _httpClient.GetWeatherForecastAsync();
        }
    }
}
