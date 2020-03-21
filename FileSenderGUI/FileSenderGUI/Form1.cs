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
        Socket client;

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

        public void ProgramStart()
        {
            if (!string.IsNullOrEmpty(IP.Text) && !string.IsNullOrEmpty(Port.Text))
            {
                try
                {
                    client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ipEndPoint = new IPEndPoint(System.Net.IPAddress.Parse(IP.Text), int.Parse(Port.Text));
                    client.Connect(ipEndPoint);
                    Messages.Text += "Connected to " + IP.Text + ":" + Port.Text + "\n";
                    SelectFile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please insert IP & Port");
            }
        }

        public void SelectFile()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string FilePath = OFD.FileName;
                    client.Send(Encoding.ASCII.GetBytes(FilePath));
                    SendFileData(FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void SendFileData(string FilePath)
        {
            Messages.Text += "Sending file...\n";
            client.SendFile(FilePath);
            Messages.Text += "File sent\n";
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            Messages.Text += "Connection Closed!\n";
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            ProgramStart();
        }
    }
}
