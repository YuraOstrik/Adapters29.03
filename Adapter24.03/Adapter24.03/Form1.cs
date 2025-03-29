using System.Net.NetworkInformation;
namespace Adapter24._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            label3.Text = adapters.Length.ToString();

            var ipProcs = IPGlobalProperties.GetIPGlobalProperties();
            var topConnection = ipProcs.GetActiveTcpConnections();
            label4.Text = topConnection.Length.ToString();

            timer1.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var ipProcs = IPGlobalProperties.GetIPGlobalProperties();
            var ipStatus = ipProcs.GetIPv4GlobalStatistics();

            long receivedPackets = ipStatus.ReceivedPackets;
            long sentPackets = ipStatus.OutputPacketRequests;
            long droppedReceived = ipStatus.ReceivedPacketsDiscarded;
            long droppedSent = ipStatus.OutputPacketsDiscarded;
            long fragmentErrors = ipStatus.PacketFragmentFailures;
            long reassemblyErrors = ipStatus.PacketReassemblyFailures;

            listBox1.Items.Add($"Входящие пакеты: {receivedPackets}");
            listBox1.Items.Add($"Исходящие пакеты: {sentPackets}");
            listBox1.Items.Add($"Отброшенные входящие: {droppedReceived}");
            listBox1.Items.Add($"Отброшенные исходящие пакеты: {droppedSent}");
            listBox1.Items.Add($"Ошибка фрагментации: {fragmentErrors}");
            listBox1.Items.Add($"Ошибка восстановления пакета: {reassemblyErrors}");
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
