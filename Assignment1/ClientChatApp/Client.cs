using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatLib
{
    public class Client
    {
        private TcpClient client;
        public NetworkStream stream;
        public Client(string serverIp, int serverPort)
        {
            // Create a new TCP client and connect to the server
            client = new TcpClient();
            client.Connect(serverIp, serverPort);
            // Get the network stream for the client
            stream = client.GetStream(); 
            Console.WriteLine("Connected to server");
        }

        public void SendMessage(string message)
        {// Send the message to the stream
       
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
            
            
        }

        public void Disconnect()
        {
            // Close the network stream and TCP client
            stream.Close();
            client.Close();
            Console.WriteLine("Disconnected");
        }
    }
}
