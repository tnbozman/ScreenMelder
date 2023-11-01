using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.CommunicationsProxy.Strategies
{
    public class HttpPostCommunicationStrategy: ICommunicationStrategy
    {
        public string CleanupRegex { get; set;  }
        private readonly Uri _targetUri;
        private readonly ILogger _logger;

        public HttpPostCommunicationStrategy(Uri targetUri, ILogger logger)
        {
            _logger = logger;
            _targetUri = targetUri;
            CleanupRegex = null;
        }

        public bool Connect()
        {
            return true;
        }

        public bool Disconnect()
        {
            return false;
        }

        public void SendJson(string json)
        {
            throw new NotImplementedException();
        }

        public async Task SendJsonAsync(string json)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Send the JSON payload via HTTP POST.
                    var response = await httpClient.PostAsync(_targetUri, content);

                    response.EnsureSuccessStatusCode(); // Ensure a successful HTTP response.

                    _logger.LogInformation("JSON payload sent via HTTP POST: " + json);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("HTTP POST Communication Error", ex);
            }
        }
    }
}
