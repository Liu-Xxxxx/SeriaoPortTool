using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;

namespace SeriaoPortTool
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        //ʵ�������ڶ���
        SerialPort serialPort = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();
        
        public MainForm()
        {
            InitializeComponent();
            AllocConsole(); //����һ������̨����������ʾ��Ϣ
        }

        //��ʼ�����ڽ����������
        private void init_serialport_configs()
        {
            //��鱾�ش���
            string[] str = SerialPort.GetPortNames();
            if (str == null || str.Length == 0)
            {
                MessageBox.Show("����û�д��ڣ�����", "Error");
                return;
            }

            //��Ӵ���ѡ��
            foreach (string str2 in str)
            {
                combPortName.Items.Add(str2);
            }
            combPortName.SelectedIndex = 0;
            combBauRate.SelectedIndex = 0;
            combDataBit.SelectedIndex = 2;
            combStopBit.SelectedIndex = 0;
            combVerifyBit.SelectedIndex = 0;

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

            //׼������
            serialPort.DtrEnable = false;
            serialPort.RtsEnable = false;
            serialPort.ReadTimeout = 1000;
            serialPort.WriteTimeout = 1000;

            timer.Elapsed += Timer_Elapsed;
            serialPort.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            init_serialport_configs();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (combPortName.SelectedItem == null)
                {
                    MessageBox.Show("Error: ��Ч�Ķ˿ڣ�������ѡ��", "Error");
                    return;
                }

                serialPort.PortName = combPortName.Text;
                serialPort.BaudRate = Convert.ToInt32(combBauRate.Text);
                serialPort.DataBits = Convert.ToInt32(combDataBit.Text);

                switch (combStopBit.Text)
                {
                    case "1":
                        serialPort.StopBits = StopBits.One; break;
                    case "1.5":
                        serialPort.StopBits = StopBits.OnePointFive; break;
                    case "2":
                        serialPort.StopBits = StopBits.Two; break;
                    default:
                        MessageBox.Show("Error: ֹͣλ���ô���", "Error"); break;
                }
                switch (combVerifyBit.Text)
                {
                    case "none":
                        serialPort.Parity = Parity.None; break;
                    case "odd":
                        serialPort.Parity = Parity.Odd; break;
                    case "even":
                        serialPort.Parity = Parity.Even; break;
                    default:
                        MessageBox.Show("Error: У��λ���ô���", "Error"); break;
                }
                serialPort.Open();

                //�򿪴��ں��������ô��ڲ���
                combBauRate.Enabled = false;
                combDataBit.Enabled = false;
                combStopBit.Enabled = false;
                combVerifyBit.Enabled = false;
                combPortName.Enabled = false;
                btnConnect.Enabled = false;
                btbDisconnect.Enabled = true;
                btnSend.Enabled = true;
                btnSaveForm.Enabled = true;
                ckbContinuSend.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error");
                return;
            }
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // �Ӵ��ڶ�ȡ����
                string receivedData = serialPort.ReadExisting();

                // �� UI �߳��и��� UI
                Invoke(new Action(() =>
                {
                    // �� TextBox ����ʾ���յ�������
                    if (cboxHex.Checked)//��HEX����ʽ��ʾ�ַ���
                    {
                        byte[] asciiBytes = Encoding.ASCII.GetBytes(receivedData);
                        receivedData = BitConverter.ToString(asciiBytes).Replace("-", " ");
                        receivedData += " ";
                    }
                    if (cboxTimeStamp.Checked)//��ʾʱ���
                    {
                        textBoxRecv.Text += "\r\n[";
                        textBoxRecv.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        textBoxRecv.Text += "]: ";
                    }
                    textBoxRecv.Text += receivedData;
                }));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return;
            }
        }

        private void btbDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            //����������Ч���շ�����ʧЧ
            combPortName.Enabled = true;
            combBauRate.Enabled = true;
            combDataBit.Enabled = true;
            combStopBit.Enabled = true;
            combVerifyBit.Enabled = true;
            btnConnect.Enabled = true;
            btbDisconnect.Enabled = false;
            btnSaveForm.Enabled = false;
            btnSend.Enabled = false;
            ckbContinuSend.Enabled = false;
            timer.Stop();
        }
        private void send_data()
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("���ȴ򿪴���", "Error");
                return;
            }

            try
            {
                string sendStr = textBoxSed.Text;//���͵�����
                if (ckbAddEnd.Checked == true)//����\r\n��β����
                {
                    sendStr += "\r\n";
                }

                if (ckbHexSend.Checked == true)//����16��������
                {
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(sendStr);
                    string hexString = BitConverter.ToString(asciiBytes).Replace("-", " ");
                    serialPort.WriteLine(hexString);
                }
                else
                {
                    serialPort.WriteLine(sendStr);//����һ������
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errof: " + ex.Message, "Error");
                return;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            send_data();
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            textBoxRecv.Text = string.Empty;
        }

        private void ckbContinuSend_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbContinuSend.Checked == true)
            {
                if (int.TryParse(textbSendInterval.Text, out int number))
                {
                    //�ַ����Ϸ���ת���ɹ�
                    timer.Interval = number;
                }
                else
                {
                    MessageBox.Show("������ȷ�ķ��ͼ��ʱ��", "Error");
                    return;
                }

                timer.Start();
                btnSend.Enabled = false;
            }
            else
            {
                timer.Stop();
                btnSend.Enabled = true;
            }
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            send_data();
        }
    }
}