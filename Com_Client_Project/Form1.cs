using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Com_Client_Project
{
    public partial class Form1 : Form
    {
        String resualt = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void defualt_Click_1(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM2";
            serialPort1.DataBits = 8;
            serialPort1.BaudRate = 9600;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            comboBox1.Text = "COM2";
            comboBox2.Text = "8";
            comboBox3.Text = "9600";
            comboBox4.Text = "One";
            comboBox5.Text = "None";
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Mohmmad Aboduan \n Abd Alqader Alnajjar\n forth year \n Com prject \n");


        }

        private void startCall_Click(object sender, EventArgs e)
        {
            int temp = 0;
            string str;
            if (serialPort1.IsOpen == false)
            {
                // set port name Value
                serialPort1.PortName = (comboBox1.SelectedItem).ToString();

                // set dataBits Value 
                temp = Convert.ToInt32(comboBox2.SelectedItem);
                serialPort1.DataBits = temp;

                //set Buad rate value
                temp = Convert.ToInt32(comboBox3.SelectedItem);
                serialPort1.BaudRate = temp;

                // set stop bit Value
                str = "";
                str = comboBox4.SelectedItem.ToString().ToLower();
                if (str == "one")
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                else
                    if (str == "two")
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                else
                        if (str == "onefivepoint")
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;

                // set parity  Value
                str = comboBox5.SelectedItem.ToString().ToLower();
                if (str == "none")
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                else
                    if (str == "even")
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                else
                        if (str == "odd")
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                else
                            if (str == "mark")
                    serialPort1.Parity = System.IO.Ports.Parity.Mark;
                else
                                if (str == "space")
                    serialPort1.Parity = System.IO.Ports.Parity.Space;

                try
                {
                    serialPort1.Open();
                    status.Text = "متصل ";
                    status.ForeColor = System.Drawing.Color.Green;
                    startCall.Enabled = false;
                    stopCall.Enabled = true;
                    setDisableItems(false);
                }
                catch
                {
                    status.Text = "فشل في الإتصال";
                    status.ForeColor = System.Drawing.Color.Red;
                    startCall.Enabled = true;
                    stopCall.Enabled = false;
                    setDisableItems(true);


                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] port;
            port = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();

            for (int i = 0; i < port.Length; i++)
                comboBox1.Items.Add(port[i]);

            comboBox1.SelectedIndex = 0;

            // dataBits Value 
            comboBox2.SelectedIndex = 3;

            //Buad rate value
            comboBox3.SelectedIndex = 0;

            // stop bit Value
            comboBox4.SelectedIndex = 0;

            // parity  Value
            comboBox5.SelectedIndex = 0;

        }

        private void stopCall_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            status.Text = "غير متصل";
            status.ForeColor = System.Drawing.Color.Red;
            startCall.Enabled = true;
            stopCall.Enabled = false;
            setDisableItems(true);



        }

        private void setDisableItems(Boolean value) {
            groupBox1.Enabled = value;
            defualt.Enabled = value;
            menuStrip1.Enabled = value;
        }



        String resault = "";

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string Recieved = serialPort1.ReadLine();
            MessageBox.Show("Test" + Recieved);
            //          richTextBox2.Text = Recieved;
            /* if(path_b){
                   path = Recieved;
                   richTextBox1.Text = path;

                   path_b = false;
                   return;
               }*/

        

      /*      switch (int.Parse(Recieved))
            {
                case 0: // new folder
                    System.IO.Directory.CreateDirectory(@"C:\Users\abdal\Desktop\tests\as");
                    resault = " sucess add folder";

                    break;
                case 1: // dell file

                    //    path_b = true;
                    try
                    {
                        System.IO.Directory.Delete(@"C:\Users\abdal\Desktop\tests\as");

                    }
                    catch
                    {
                        resault = " sucess del folder ";

                    }



                    break;
                case 2: // change photo name 
                    File.Move(@"C:\Users\abdal\Desktop\tests\a1.jpg", @"C:\Users\abdal\Desktop\tests\a11aa.jpg");
                    resault = " sucess change pic name";

                    break;
                case 3: // file size
                    resault = " info : " + DirectorySize(@"C:\Users\abdal\Desktop\acm");

                    break;
                case 4: // show all printers

                    String s = "";
                    foreach (String strPrinter in PrinterSettings.InstalledPrinters)
                    {
                        s += "printer " + strPrinter + " , ";
                    }
                    resault = s;
                    break;
                case 5: // default printer
                        // افتراضية 
                    PrintDocument prtdoc = new PrintDocument();
                    string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
                    resault = " default printer : " + strDefaultPrinter;

                    break;

                case 6: // show all process

                    string ss = "";
                    ss += String.Format("ID:\tProcess name:");
                    ss += String.Format("--\t------------ \n");
                    foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcesses())
                        ss += String.Format("{0}\t{1}\t,\t", process.Id, process.ProcessName); resault = " sucess add";
                    resault = ss;
                    break;
                case 7: // screen shoot
                    int screenWidth = Screen.GetBounds(new Point(0, 0)).Width;
                    int screenHeight = Screen.GetBounds(new Point(0, 0)).Height;
                    Bitmap bmpScreenShot = new Bitmap(screenWidth, screenHeight);
                    Graphics gfx = Graphics.FromImage((Image)bmpScreenShot);
                    gfx.CopyFromScreen(0, 0, 0, 0, new Size(screenWidth, screenHeight));
                    bmpScreenShot.Save("D:/test1.jpg", ImageFormat.Jpeg);
                    resault = " sucess add";
                    resault = " screan shoot done .. ";
                    break;
                case 8: // read text
                    string s1 = "";
                    System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Users\Admin\Desktop\tests\a\rr.txt");
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        s1 += line;
                    }
                    sr.Close();
                    resault = " text file : " + s1;

                    break;
                case 9: // monitoring
                    FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
                    fileSystemWatcher.Path = @"C:\Users\abdal\Desktop\tests";
                    fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
                    fileSystemWatcher.Filter = "*.*"; //ex: "*.*" watch all file type
                    fileSystemWatcher.Changed += new FileSystemEventHandler(OnChanged);
                    fileSystemWatcher.EnableRaisingEvents = true;
                    Console.Write("Listening for changes in 'directory_path' directory...press any key to exit");
                    Console.Read();


                    resault = res;

                    break;
                case 10: // drives info
                    string s2 = "";
                    System.IO.DriveInfo[] allDrives = System.IO.DriveInfo.GetDrives();
                    foreach (System.IO.DriveInfo driver in allDrives)
                    {
                        Console.WriteLine("Drive {0}", driver.Name);
                        s2 += String.Format(" File type: {0} ", driver.DriveType);
                        if (driver.IsReady == true)
                        {
                            Console.WriteLine(", Volume label: {0}", driver.VolumeLabel);
                            s2 += String.Format(", File system: {0} ", driver.DriveFormat);
                            s2 += String.Format(", Available space to current user:{0, 15} bytes ",
                              driver.AvailableFreeSpace);
                            s2 += String.Format(", Total available space: {0, 15} bytes ", driver.TotalFreeSpace);
                            s2 += String.Format(", Total size of drive: {0, 15} bytes  ", driver.TotalSize);
                        }
                    }
                    resault = " my drivers info : " + s2;

                    break;



                default:
                    richTextBox2.Text = Recieved;

                    break;
            }
            richTextBox1.Text = resault;
            serialPort1.WriteLine(resault);*/







        }

        private static double sizeofDirctory;
        public static double DirectorySize(string directoryPath)
        {
            System.IO.DirectoryInfo dir = new DirectoryInfo(directoryPath);
            foreach (FileInfo files in dir.GetFiles())
            {
                sizeofDirctory += files.Length;
            }
            foreach (DirectoryInfo dirName in dir.GetDirectories())
            {
                DirectorySize(dirName.FullName);
            }
            return sizeofDirctory;
        }
        static string res = "";

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // Console.Write("File: {0} {1} {2}", e.FullPath, e.ChangeType, DateTime.Now);

            res = string.Format("File: {0} {1} {2}", e.FullPath, e.ChangeType, DateTime.Now);
            //   MessageBox.Show(" ");
            serialPort1.WriteLine(res);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
