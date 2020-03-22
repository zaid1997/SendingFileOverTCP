using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace FileSenderGUI
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Messages_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Connect to the server
        public void ConnectToServer(Socket Server, string IP, int Port)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(System.Net.IPAddress.Parse(IP), Port);
            Server.Connect(ipEndPoint);
        }

        // Open file dialog and select file then return a string of its path
        public string SelectFile()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return OFD.FileName;
            else
                throw new FileLoadException("No file selected");
        }

        // Send the file name to the server.
        public void SendMetaData(Socket Client, string FileName)
        {
            Client.Send(Encoding.ASCII.GetBytes(FileName));
        }

        // Send the file data to the server
        public void SendFileData(Socket Client,string FilePath)
        {
            Client.SendFile(FilePath);
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(IP.Text) && !string.IsNullOrEmpty(Port.Text))
            {
                try
                {
                    // Create a socket
                    Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    // Connect to The server
                    ConnectToServer(Client, IP.Text, int.Parse(Port.Text));
                    Messages.Text += "Connected to server " + IP.Text + ":" + Port.Text + "\n";

                    // Select file and get its path
                    string FilePath = SelectFile();

                    // Get the file name
                    string[] PathArray = FilePath.Split('\\');
                    string FileName = PathArray[PathArray.Length - 1];

                    // Send the file name to the server
                    Messages.Text += "Sending File...\n";
                    SendMetaData(Client, FileName);

                    // Send the file to the server
                    SendFileData(Client, FilePath);
                    Messages.Text += "File Sent.\n";

                    // Close the coonection and dispose the socket
                    Client.Shutdown(SocketShutdown.Both);
                    Client.Close();
                    Messages.Text += "Connection Closed!\n";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
