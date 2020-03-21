using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FileSender
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the server IPv4 address
            Console.WriteLine("Write the server IPv4 address:");
            IPAddress ipAddress = System.Net.IPAddress.Parse(Console.ReadLine());

            //Set the port number
            Console.WriteLine("Write the Port number:");
            int Port = int.Parse(Console.ReadLine());

            // Establish the local endpoint for the socket.
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, Port);

            // Create a TCP socket.
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Connect the socket to the remote endpoint.
            client.Connect(ipEndPoint);

            //Insert the full file path and send
            Console.WriteLine("Enter the file path you want to send:");
            string fileName = Console.ReadLine();

            //Encode the file path and send it to the server
            client.Send(Encoding.ASCII.GetBytes(fileName));

            //Send file fileName with buffers and default flags to the remote device.
            Console.WriteLine("Sending {0} with buffers to the host.{1}", fileName, Environment.NewLine);
            client.SendFile(fileName);


            // Release the socket.
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
    }
}
