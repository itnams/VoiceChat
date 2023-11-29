using System.Net.Sockets;
using System.Net;
using NAudio.Wave;

namespace Server
{
    public partial class Form1 : Form
    {
        private UdpClient udpServer;
        private WaveIn waveIn;
        private IPEndPoint clientEP;
        private List<string> connectedClients;
        public Form1()
        {
            InitializeComponent();
            udpServer = new UdpClient(12345); // Chọn một cổng (ở đây là 12345)
            clientEP = new IPEndPoint(IPAddress.Any, 0);

            waveIn = new WaveIn();
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.WaveFormat = new WaveFormat(8000, 1); 

            connectedClients = new List<string>();

            Thread udpThread = new Thread(new ThreadStart(ListenForMessages));
            udpThread.Start();
        }
        private void ListenForMessages()
        {
            try
            {
                while (true)
                {
                    byte[] data = udpServer.Receive(ref clientEP);
                    if (!connectedClients.Contains(clientEP.Address.ToString()))
                    {
                        connectedClients.Add(clientEP.Address.ToString());
                        UpdateConnectedClients();
                    }
                    SendAudioToOtherClients(data, clientEP.Address.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SendAudioToOtherClients(byte[] data, string senderAddress)
        {
            foreach (string clientAddress in connectedClients)
            {
                if (clientAddress != senderAddress)
                {
                    IPEndPoint clientEndpoint = new IPEndPoint(IPAddress.Parse(clientAddress), 12345);
                    udpServer.Send(data, data.Length, clientEndpoint);
                }
            }
        }
        private void UpdateConnectedClients()
        {
            Invoke(new Action(() =>
            {
                listBoxClients.Items.Clear();
                foreach (string client in connectedClients)
                {
                    listBoxClients.Items.Add(client);
                }
            }));
        }
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            SendAudioToOtherClients(e.Buffer, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            waveIn.StartRecording();
        }

        private void btnStopCall_Click(object sender, EventArgs e)
        {
            waveIn.StopRecording();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpServer.Close();
            waveIn.Dispose();
        }
    }
}
