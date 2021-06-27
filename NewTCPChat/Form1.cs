using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NewTCPChat
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //get user IP
            TextLocalIp.Text = GetLocalIP();
            TextRemoteIp.Text = GetLocalIP();
            
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }                
            }
            return "127.0.0.1";
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            
            //binding socket
            IPAddress addressLocal = IPAddress.Parse(TextLocalIp.Text);
            int portLocal = Int32.Parse(TextLocalPort.Text);
            Console.WriteLine(addressLocal);
            Console.WriteLine(portLocal);

            epLocal = new IPEndPoint(addressLocal, portLocal);                        
            sck.Bind(epLocal);
            
            //connecting remote ip
            IPAddress addressRemote = IPAddress.Parse(TextRemoteIp.Text);
            int portRemote = Int32.Parse(TextRemotePort.Text);
            Console.WriteLine(addressRemote);
            Console.WriteLine(portRemote);
            
            epRemote = new IPEndPoint(addressRemote, portRemote);
            sck.Connect(epRemote);

            //listening to spesific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            
        }

        private void MessageCallBack(IAsyncResult aResult) 
        {
            try
            {

                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;

                //convert byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //adding message to listbox
                ListMessage.Items.Add("Friend: " + receivedMessage);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            //convert message into byte[]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendMessage = new byte[1500];
            sendMessage = aEncoding.GetBytes(TextMessage.Text);

            //sending the encoded message
            sck.Send(sendMessage);

            //add to list box
            ListMessage.Items.Add("Me: " + TextMessage.Text);
            TextMessage.Text = "";
        }       
    }
}
