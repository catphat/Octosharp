using System;
using System.Threading.Tasks;

namespace Octosharp
{
    public class OctoService
    {
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public OctoService(string baseUrl, string apiKey)
        {
            if (baseUrl == null) throw new NullReferenceException("baseUrl");
            if (apiKey == null) throw new NullReferenceException("apiKey");

            _baseUrl = baseUrl;
            _apiKey = apiKey;
        }

        public async Task<string> GetStringAsync()
        {
            throw new NotImplementedException();
        }
    }
}


