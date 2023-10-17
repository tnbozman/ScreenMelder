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
        private readonly ICommunicationStrategy _communicationStrategy;

        public CommunicationProxy(Uri targetUri)
        {
            // Determine which communication strategy to use based on the URI scheme.
            if (targetUri.Scheme.Equals("http", StringComparison.OrdinalIgnoreCase))
            {
                _communicationStrategy = new HttpPostCommunicationStrategy(targetUri);
            }
            else if (targetUri.Scheme.Equals("tcp", StringComparison.OrdinalIgnoreCase))
            {
                _communicationStrategy = new TcpCommunicationStrategy(targetUri.Host, targetUri.Port);
            }
            else
            {
                throw new ArgumentException("Unsupported URI scheme: " + targetUri.Scheme);
            }
        }

        public void SendJson(string json)
        {
            // Use the selected strategy to send the JSON payload.
            _communicationStrategy.SendJsonAsync(json);
        }
    }
}
