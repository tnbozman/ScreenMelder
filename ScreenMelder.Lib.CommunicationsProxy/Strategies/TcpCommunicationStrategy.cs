using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ScreenMelder.Lib.CommunicationsProxy.Strategies
{
    public class TcpCommunicationStrategy : ICommunicationStrategy
    {
        private readonly string _serverIp;
        private readonly int _serverPort;
        public TcpCommunicationStrategy(string serverIp, int serverPort)
        {
            _serverIp = serverIp;
            _serverPort = serverPort;
        }

        public bool Connect()
        {
            return true;
        }

        public bool Disconnect()
        {
            return false;
        }

        public async Task SendJsonAsync(string json)
        {
            try
            {
                using (TcpClient client = new TcpClient(_serverIp, _serverPort))
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        // Convert the JSON payload to bytes using UTF-8 encoding.
                        byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

                        // Send the JSON payload over the TCP connection.
                        await stream.WriteAsync(jsonBytes, 0, jsonBytes.Length);

                        Console.WriteLine("JSON payload sent via TCP: " + json);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("TCP Communication Error: " + ex.Message);
            }
        }

    }
}
