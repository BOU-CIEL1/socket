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
        private Socket SSocketUDP;
        private IPEndPoint ipEndPointReceive;
        private IPEndPoint ipEndPointDest;
        private EndPoint remoteEndPoint;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 500; // tester toutes les 500 ms
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (SSocketUDP != null)
            {
                try
                {
                    // Teste si des données sont disponibles à la lecture
                    if (SSocketUDP.Available > 0)
                    {
                        var buffer = new byte[SSocketUDP.Available];
                        EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                        int received = SSocketUDP.ReceiveFrom(buffer, ref remoteEP);

                        string receivedMessage = Encoding.ASCII.GetString(buffer, 0, received);
                        textBoxRecpBig.Text += $"Message reçu de {remoteEP}: {receivedMessage}\r\n";
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Erreur socket dans le timer: " + ex.Message);
                    timer1.Stop();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SSocketUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                ipEndPointReceive = new IPEndPoint(IPAddress.Parse(this.textBoxRecp.Text), int.Parse(textBoxIPeR.Text));
                SSocketUDP.Bind(ipEndPointReceive);
                ipEndPointDest = new IPEndPoint(IPAddress.Parse(textBoxDest.Text), int.Parse(textBoxIPeD.Text));
                remoteEndPoint = (EndPoint)ipEndPointDest;
                SSocketUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);


            }
            catch (System.Net.Sockets.SocketException se)
            {
                this.textBoxRecpBig.Text += "Message d’erreur : " + se.ToString();
            }

            MessageBox.Show("Socket créé et lié avec succès! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SSocketUDP.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SSocketUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);
            var messageEnvoi = Encoding.ASCII.GetBytes("GET / HTTP/1.1\r\nHost: 127.0.0.1\r\n\r\n");

            // Destination IP et port (exemple 127.0.0.1:80)
            IPEndPoint iped = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);

            // Envoi du message avec SendTo
            SSocketUDP.SendTo(messageEnvoi, iped);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var messageRecu = new byte[1024];
            EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0); // pour récupérer l'adresse de l'expéditeur

            int nbcarrecu = SSocketUDP.ReceiveFrom(messageRecu, ref remoteEP);
            this.textBoxRecpBig.Text = "nbcarecu " + nbcarrecu + "\n" + Encoding.ASCII.GetString(messageRecu, 0, nbcarrecu);
        }
    }
}
