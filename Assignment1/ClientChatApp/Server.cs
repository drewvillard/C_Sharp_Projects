using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatLib
{
    public class Server
    {
        private TcpListener listener;
        private TcpClient client;
        public NetworkStream stream;
      
        //constructor uses arguments portNum and ipAddr which will be the constants (IPADDRESS and PORT) from the server chat app main
        //then creates a tcp listener to interact with client later
        public Server(int portNum, string ipAddr) {
            IPAddress localAddress = IPAddress.Parse(ipAddr);
            try
            {
                listener = new TcpListener(localAddress, portNum);
            }
            catch (ArgumentNullException) { 
            }
            
            
        }
        //starts the listener and displays message for better UX
        public void Start()
        {
            Console.WriteLine("Server Started Waiting For Client Connection:");
            listener.Start();

        }
        //Accepts tcp client and connects them via socket
        public void ClientAccept() {

            client = listener.AcceptTcpClient();
            stream = client.GetStream();
            Console.WriteLine("Connection established with client");
        }
        public void SendMessage(string message)
        {
            // Send a message to the client
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
       
        }
        public void Disconnect()
        {
            // Close the network stream and TCP client
            client.Close();
            listener.Stop();
            
            Console.WriteLine("Disconnected from client");
        }
    }
}
