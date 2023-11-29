using NAudio.Wave;
using System.Net.Sockets;
using System.Net;

namespace VoiceChat
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private IPEndPoint serverEP;
        private WaveIn waveIn;
        private WaveOut waveOut;
        private BufferedWaveProvider waveProvider;

        public Form1()
        {
            InitializeComponent();

            udpClient = new UdpClient();
            waveProvider = new BufferedWaveProvider(new WaveFormat(8000, 1));
            serverEP = new IPEndPoint(IPAddress.Parse("192.168.1.12"), 12345); // Địa chỉ IP và cổng của server

            waveOut = new WaveOut();
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            waveOut.Init(waveProvider);
            waveOut.Play();
            Thread listenThread = new Thread(new ThreadStart(ListenForAudio));
            listenThread.Start();
        }
        private void ListenForAudio()
        {
            try
            {
                while (true)
                {
                    byte[] data = udpClient.Receive(ref serverEP);
                    waveProvider.AddSamples(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Dừng xử lý âm thanh khi phát dừng
            waveOut.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            udpClient.Send(new byte[0], 0, serverEP); // Gửi một gói tin trống để thông báo server bắt đầu gửi âm thanh
        }

        private void btnStopCall_Click(object sender, EventArgs e)
        {
            waveOut.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpClient.Close();
            waveOut.Dispose();
        }
    }
}
