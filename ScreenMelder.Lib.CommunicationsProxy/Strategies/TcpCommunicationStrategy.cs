using ScreenMelder.Lib.CommunicationsProxy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private readonly int _threadTimeout = 1000;
        private Socket client { get; set; }
        public string CleanupRegex { get; set; }

        // private readonly ILogger<TcpCommunicationStrategy> _logger;
        public TcpCommunicationStrategy(string serverIp, int serverPort)
        {
            _serverIp = serverIp;
            _serverPort = serverPort;
            CleanupRegex = null;
        }

        public bool Connect()
        {
            if (client != null && client.Connected)
            {
                Disconnect();
            }

            IPAddress ipAddress = null;
            if (!IPAddress.TryParse(_serverIp, out ipAddress))
            {
                var errorMsg = "IP Address is invalid";
                // _logger.LogDebug(errorMsg);
                // OnErrorDetected(errorMsg);
                return false;
            }

            if (_serverPort < 1 || _serverPort > 65535)
            {
                var errorMsg = "Port is out of range (1 to 65535)";
                //_logger.LogDebug(errorMsg);
                //OnErrorDetected(errorMsg);
                return false;
            }

            try
            {
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, _serverPort);
                client = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                client.Blocking = true;
                client.LingerState = new LingerOption(true, 1);
                client.ReceiveTimeout = _threadTimeout;


                // Connect to the remote endpoint.  
                client.Connect(remoteEP);
               // Status = Status.Connected;
                //_logger.LogDebug($"Connection to {address}:{port} successful");
                //OnClientConnected();

                //StartThreads();
            }
            catch (Exception ex)
            {
                //_logger.LogError("Failed to connect to GSPro Connect: Make sure GSPro Connect has been started and is waiting for connection");
                //OnErrorDetected($"Failed to connect to GSPro: {ex.Message}");
                return false;
            }

            return true;
        }

        public bool Disconnect()
        {
            if (client != null && client.Connected)
            {
                client.Close();
                client.Dispose();
            }
            return false;
        }



        public void SendJson(string json)
        {
            try
            {
                if(client != null && client.Connected)
                {
                    string unprettyJson;
                    if(PayloadUtils.IsValidJson(json, out unprettyJson, CleanupRegex))
                    {
                        byte[] jsonBytes = Encoding.UTF8.GetBytes(unprettyJson);
                        client.Send(jsonBytes);
                        Console.WriteLine("JSON payload sent via TCP: " + unprettyJson);
                    }
                    else
                    {
                        Console.WriteLine("JSON payload was not json: " + json);
                    }
                    
                }
                else
                {
                    Console.WriteLine("JSON payload sent via TCP: " + json);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("TCP Communication Error: " + ex.Message);
            }
        }

        public Task SendJsonAsync(string json)
        {
            throw new NotImplementedException();
        }
    }
}
