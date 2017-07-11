using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace UDPTool
{
    public delegate void DelegateVoid();

    public partial class MainForm : Form
    {
        public UdpClient _udpClient = null;
        public IPEndPoint _endPt = null;
        private Queue<Byte[]> _receptionList;
        private Thread _queueThread;
        private EventWaitHandle _queueThreadStop;

        // toutes ces variables seront sauvées grace à la sérialisation
        [Serializable]
        public class ProjectData
        {
            public string _udpPort = "1234";
            public string _waitForFrame = "toto";
            public string _executablePath = "C:\\Windows\\notepad.exe";
            public bool _autoStart = true;
        }
        public ProjectData _projectData = new ProjectData();

        // sauvegarde dans le répertoire de l'application
        string _projectDataPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\ProjectData.xml";

        public MainForm()
        {
            InitializeComponent();  
            _receptionList = new Queue<byte[]>();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoadProjectData();
            if (_projectData._autoStart)
                buttonStart_Click(null, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoStop();
            SaveProjectData();
        }

        // chargement des data
        void LoadProjectData()
        { 
            if (File.Exists(_projectDataPath))
            {
                XmlSerializer SerializerObj = new XmlSerializer(typeof(ProjectData));
                try
                {
                    FileStream ReadFileStream = new FileStream(_projectDataPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    _projectData = (ProjectData)SerializerObj.Deserialize(ReadFileStream);
                    ReadFileStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBoxListenPort.Text = _projectData._udpPort;
            textBoxWaitFor.Text = _projectData._waitForFrame;
            textBoxProgram.Text = _projectData._executablePath;
            checkBoxAuto.Checked = _projectData._autoStart;
        }

        // sauvegarde des data
        void SaveProjectData()
        {
            _projectData._udpPort = textBoxListenPort.Text;
            _projectData._waitForFrame = textBoxWaitFor.Text;
            _projectData._executablePath = textBoxProgram.Text;
            _projectData._autoStart = checkBoxAuto.Checked;

            XmlSerializer SerializerObj = new XmlSerializer(typeof(ProjectData));
            TextWriter WriteFileStream = new StreamWriter(_projectDataPath);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            SerializerObj.Serialize(WriteFileStream, _projectData, ns);
            WriteFileStream.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxReception.Text = "";
            IPAddress ipAddrBind = null;
            int udpPort = 0;

            lock (_receptionList)
            {
                _receptionList.Clear();
            }

            if (_udpClient != null)
            {
                try
                {
                    _udpClient.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            bool okToCreate = true;
            try
            {
                if (textBoxAdapterAddress.Text.Length == 0)
                    ipAddrBind = IPAddress.Any; //any adapter
                else
                    ipAddrBind = IPAddress.Parse(textBoxAdapterAddress.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
                okToCreate = false;
            }
            try
            {
                udpPort = Convert.ToInt32(textBoxListenPort.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
                okToCreate = false;
            }
            if (okToCreate)
            {
                try
                {
                    _endPt = new IPEndPoint(ipAddrBind, udpPort);
                }
                catch (Exception eee)
                {
                    MessageBox.Show(eee.Message);
                    okToCreate = false;
                }
            }

            if (okToCreate)
            {
                try
                {
                    _udpClient = new UdpClient(_endPt);
                }
                catch (Exception eeee)
                {
                    MessageBox.Show(eeee.Message);
                    okToCreate = false;
                }
                if (okToCreate)
                {
                    _queueThreadStop = new EventWaitHandle(false, EventResetMode.AutoReset);
                    _queueThread = new Thread(QueueProc);
                    _queueThread.Start();
                    buttonStop.Enabled = true;
                    buttonStart.Enabled = false;
                }
            }
        }

        public void QueueProc()
        {
            while (_queueThreadStop.WaitOne(100, false) != true)
            {
                try
                {
                    Byte[] receiveBytes = _udpClient.Receive(ref _endPt);
                    if (receiveBytes != null && receiveBytes.Length > 0)
                    {
                        lock (_receptionList)
                        {
                            _receptionList.Enqueue(receiveBytes);
                        }
                        DisplayData();
                    }
                }
                catch
                {
                    break;
                }
            }

            try
            {
                _udpClient.Close();
                _udpClient = null;
            }
            catch
            {
            }

            DoStop();
        }

        public void DoStop()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new DelegateVoid(DoStop));
                return;
            }
            buttonStop_Click(null, null);
            textBoxReception.Text += "\r\nThread stopped\r\n";
        }

        public void DisplayData()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new DelegateVoid(DisplayData));
                return;
            }

            lock (_receptionList)
            {
                byte[] datagram = null;
                try
                {
                    datagram = _receptionList.Dequeue();
                }
                catch 
                {
                    datagram = null;
                }
                while (datagram != null && datagram.Length > 0)
                {
                    string displayData = Encoding.ASCII.GetString(datagram);
                    textBoxReception.Text += displayData;
                    
                    if (textBoxReception.Text.Contains(textBoxWaitFor.Text))
                    {
                        textBoxReception.Text = "";
                        try
                        {
                            Process processToRun = new Process();
                            processToRun.StartInfo.FileName = textBoxProgram.Text;
                            processToRun.Start();                        
                        }
                        catch
                        {
                            
                        }
                    }

                    try
                    {
                        datagram = _receptionList.Dequeue();
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_queueThreadStop != null)
            {
                _queueThreadStop.Set();
                try
                {
                    _udpClient.Close();
                }
                catch
                {
                }
                _queueThreadStop = null;
                _queueThread = null;
            }
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxReception.Clear();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            try
            {
                udpClient.Connect(textBoxDestAddress.Text, Convert.ToInt32(textBoxDestPort.Text));
                Byte[] sendBytes = Encoding.ASCII.GetBytes(textBoxFrame.Text);
                udpClient.Send(sendBytes, sendBytes.Length);
                udpClient.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }
    }
}
