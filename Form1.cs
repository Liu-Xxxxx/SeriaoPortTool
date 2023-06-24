using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;

namespace SeriaoPortTool
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        //实例化串口对象
        SerialPort serialPort = new SerialPort();
        System.Timers.Timer timer = new System.Timers.Timer();
        
        public MainForm()
        {
            InitializeComponent();
            AllocConsole(); //关联一个控制台窗口用于显示信息
        }

        //初始化串口界面参数设置
        private void init_serialport_configs()
        {
            //检查本地串口
            string[] str = SerialPort.GetPortNames();
            if (str == null || str.Length == 0)
            {
                MessageBox.Show("本机没有串口！！！", "Error");
                return;
            }

            //添加串口选项
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

            //准备就绪
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
                    MessageBox.Show("Error: 无效的端口，请重新选择", "Error");
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
                        MessageBox.Show("Error: 停止位设置错误", "Error"); break;
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
                        MessageBox.Show("Error: 校验位设置错误", "Error"); break;
                }
                serialPort.Open();

                //打开串口后不允许设置串口参数
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
                // 从串口读取数据
                string receivedData = serialPort.ReadExisting();

                // 在 UI 线程中更新 UI
                Invoke(new Action(() =>
                {
                    // 在 TextBox 中显示接收到的数据
                    if (cboxHex.Checked)//以HEX的形式显示字符串
                    {
                        byte[] asciiBytes = Encoding.ASCII.GetBytes(receivedData);
                        receivedData = BitConverter.ToString(asciiBytes).Replace("-", " ");
                        receivedData += " ";
                    }
                    if (cboxTimeStamp.Checked)//显示时间戳
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
            //串口设置有效，收发按键失效
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
                MessageBox.Show("请先打开串口", "Error");
                return;
            }

            try
            {
                string sendStr = textBoxSed.Text;//发送的数据
                if (ckbAddEnd.Checked == true)//增加\r\n结尾符号
                {
                    sendStr += "\r\n";
                }

                if (ckbHexSend.Checked == true)//发送16进制数据
                {
                    byte[] asciiBytes = Encoding.ASCII.GetBytes(sendStr);
                    string hexString = BitConverter.ToString(asciiBytes).Replace("-", " ");
                    serialPort.WriteLine(hexString);
                }
                else
                {
                    serialPort.WriteLine(sendStr);//发送一行数据
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
                    //字符串合法，转换成功
                    timer.Interval = number;
                }
                else
                {
                    MessageBox.Show("输入正确的发送间隔时间", "Error");
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