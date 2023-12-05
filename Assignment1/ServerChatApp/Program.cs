using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using ChatLib;

namespace ServerChatApp
{
    //Author Drew Villard W0468787
    class Program
    {
        //Constants for IP address and port numbers
        private const String IPADDRESS = "127.0.0.1";
        private const int PORT = 1300;

        //Main method runs program starts by creating appropriate object then connecting them via
        //TCP/IP then waits for an input on either end and displays said input on counterparts display 
        //it should theoretically close both the server and client upon one disconnecting but i cant get the functionality to work 100%
        static void Main(string[] args)
        {
            Client client = null;
            Server server = null;
            if (args.Contains("-server"))
            {
                server = new Server(PORT, IPADDRESS);
                server.Start();
                server.ClientAccept();
            }
            else
            {
                client = new Client(IPADDRESS, PORT);
            }
           
            try
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userKey = Console.ReadKey(true);
                        //enters insertion mode
                        if (userKey.Key == ConsoleKey.I)
                        {
                            Console.Write("Insertion Mode>>>");

                            string message = Console.ReadLine();

                            // Send the message from either the server or client
                            if (args.Contains("-server"))
                            {
                                server.SendMessage(message);
                            }
                            else
                            {
                                client.SendMessage(message);
                            }
                        }
                        //if user presses escape key Disconnect them
                        else if (userKey.Key == ConsoleKey.Escape)
                        {
                            Console.WriteLine("You Hit Escape");
                            if (client != null)
                            {
                                client.Disconnect();
                            }
                            if (server != null)
                            {
                                server.Disconnect();
                            }
                            break;
                        }
                    }
                    //if statement for the server side receiving of messages
                    if (args.Contains("-server") && server != null && server.stream.DataAvailable)
                    {
                        byte[] buffer = new byte[1024];
                        Array.Clear(buffer, 0, buffer.Length);
                        int bytesRead = server.stream.Read(buffer, 0, buffer.Length);

                        if (bytesRead > 0)
                        {
                            string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            Console.WriteLine(receivedMessage);
                        }
                    }
                    //if statement for client received messages
                    else if (client != null && client.stream.DataAvailable)
                    {
                        byte[] buffer = new byte[1024];
                        Array.Clear(buffer, 0, buffer.Length);
                        int bytesRead = client.stream.Read(buffer, 0, buffer.Length);

                        if (bytesRead > 0)
                        {
                            string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            Console.WriteLine(receivedMessage);
                        }
                    }
                    //attempt at testing client socket connection to see if i can get server to close on client disconnection (FAILURE)
                    else if (!client.stream.Socket.Connected&&client!=null) {
                        Console.WriteLine("Client Disconnected");
                        server.Disconnect();
                        break;
                    }

                }
            }
            //IOEXCEPTION catches when server is closed via windows closing of the window, (better exiting message for client when closed server CMD)
            catch (IOException) {
                Console.WriteLine("Socket disconnected");
            }
        }
    }
}

