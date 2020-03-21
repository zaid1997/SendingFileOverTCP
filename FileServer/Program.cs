using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

class FileServer
{
    class Program
    {
        static void Main()
        {
            //Get the current machine IPv4 address
            IPAddress[] Address = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            IPAddress IPv4 = Address[^1];

            //Set port number manually
            Console.WriteLine("Enter Port Number:");
            int Port = int.Parse(Console.ReadLine());

            while (true)
            {
                //Create TCP connection
                var Server = new TcpListener(IPv4, Port);
                Server.Start();
                Console.WriteLine("Server established on {0}:{1}", IPv4, Port);

                Console.WriteLine("Waiting for connection to receive file...");
                using (var client = Server.AcceptTcpClient())
                using (var stream = client.GetStream())
                {
                    /*
                     * Receive a message with the real file path on client machine
                     * then split the path to take the file name with its extension
                     * only then create a file on server side with the same old file
                     * name and extension.
                     */

                    string FilePath = null;
                    byte[] bytes = null;
                    bytes = new byte[1024];
                    int bytesRec = stream.Read(bytes, 0, bytes.Length);
                    FilePath += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    string[] PathArray = FilePath.Split('\\');

                    /*
                     * File name with extension --> PathArray[PathArray.Length - 1]
                     */

                    using (var output = File.Create(PathArray[^1]))
                    {
                        Console.WriteLine("Client connected.\nreceiving file...");

                        // read the file in chunks of 1KB
                        var buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, bytesRead);
                        }
                        Console.WriteLine("File Received!");
                        Server.Stop();
                    }
                }
            }

        }
    }
}