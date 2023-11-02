using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Lan_trial
{
    class Server
    {
        static void Main()
        {
            IPAddress ipAddress = IPAddress.Parse("10.8.14.88");
            int port = 12345; // Choose a port number

            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();
            Console.WriteLine($"Server is listening on {ipAddress}:{port}");

            TcpClient client = listener.AcceptTcpClient();
            Console.WriteLine("Client connected.");

            NetworkStream stream = client.GetStream();

            while (true)
            {
                byte[] data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesRead);
                Console.WriteLine($"Client: {message}");

                Console.Write("Server: ");
                string response = Console.ReadLine();
                byte[] responseBytes = Encoding.ASCII.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);
            }

            client.Close();
            listener.Stop();
        }
    }
}