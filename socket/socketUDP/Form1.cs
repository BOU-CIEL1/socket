using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socketUDP
{
    public partial class Form1 : Form
    {
        private
            Socket SSocketUDP;
            Button buttonSocket;
            Button buttonClose;
            Button buttonSendTo;
            Button ReceiveFrom;
            Button CLS;
            TextBox textboxRecp;
            TextBox textboxDest;
            TextBox textboxIPeR;
            TextBox textboxIPeD;
            TextBox textboxEnvoi;
            TextBox textboxRecpBig;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SSocketUDP = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //connection sur le serveur127.0.0.1 port 80 
            IPEndPoint iped = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);

            SSocketUDP.Connect(iped);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SSocketUDP.Shutdown(SocketShutdown.Both);
            SSocketUDP.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // envoie la demande de page au serveur web 

            SSocketUDP.SetSocketOption(SocketOptionLevel.Socket,
            SocketOptionName.ReceiveTimeout, 5000);
            var messageEnvoi = Encoding.ASCII.GetBytes("GET /\r\n\r\n");

            SSocketUDP.Send(messageEnvoi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var messageRecu = new byte[1024];
            int nbcarrecu = SSocketUDP.Receive(messageRecu);
            this.textboxRecpBig.Text = "nbcarecu " + nbcarrecu + "\n" +
                         Encoding.ASCII.GetString(messageRecu, 0, nbcarrecu);
        }
    }
}
