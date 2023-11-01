using Microsoft.Extensions.Logging;
using ScreenMelder.Lib.CommunicationsProxy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.CommunicationsProxy
{
    public class CommunicationProxy
    {
        private readonly ILogger<CommunicationProxy> _logger;
        public string CleanupRegex => _communicationStrategy.CleanupRegex;
        public void SetCleanupRegex(string regex)
        {
            _communicationStrategy.CleanupRegex
                = regex;
        }
        private readonly ICommunicationStrategy _communicationStrategy;

        public bool IsConnected { get; private set; }
        public CommunicationProxy(Uri targetUri, ILogger<CommunicationProxy> logger)
        {
            _logger = logger;
            // Determine which communication strategy to use based on the URI scheme.
            if (targetUri.Scheme.Equals("http", StringComparison.OrdinalIgnoreCase))
            {
                // add
                _communicationStrategy = new HttpPostCommunicationStrategy(targetUri, _logger);
            }
            else if (targetUri.Scheme.Equals("tcp", StringComparison.OrdinalIgnoreCase))
            {
                _communicationStrategy = new TcpCommunicationStrategy(targetUri.Host, targetUri.Port, _logger);
            }
            else
            {
                throw new ArgumentException("Unsupported URI scheme: " + targetUri.Scheme);
            }
        }

        public void Connect()
        {
            IsConnected = _communicationStrategy.Connect();
        }

        public void Disconnect()
        {
            IsConnected = _communicationStrategy.Disconnect();
        }

        public void SendJson(string json)
        {
            // Use the selected strategy to send the JSON payload.
            _communicationStrategy.SendJson(json);
        }
    }
}
