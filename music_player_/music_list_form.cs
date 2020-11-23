using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Runtime.InteropServices;

namespace music_player_
{
    public partial class music_list_form : Form
    {

        ListBox listBox1 = new ListBox();

        public music_list_form()
        {

            InitializeComponent();


        }

        ChromiumWebBrowser chrom;
        TextBox tc = new TextBox();


        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", (System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance));
            controlProperty.SetValue(control, value, null);
        }

        WMPLib.WindowsMediaPlayer wmpI = new WMPLib.WindowsMediaPlayer();

 
        string p_;

        [DllImport("shell32.dll", EntryPoint = "#261", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void GetUserpicPath(string username, UInt32 hex, StringBuilder picture_path, int maxLength);


        private void music_list_form_Load(object sender, EventArgs e)
        {

           
            SetDoubleBuffering(gunaShadowPanel2, true);
            SetDoubleBuffering(gunaLinePanel1, true);
            SetDoubleBuffering(panel1, true);
            SetDoubleBuffering(panel2, true);
            SetDoubleBuffering(panel3, true);
            SetDoubleBuffering(panel4, true);
            SetDoubleBuffering(panel5, true);
            SetDoubleBuffering(panel6, true);
            SetDoubleBuffering(panel7, true);
            SetDoubleBuffering(panel8, true);
            SetDoubleBuffering(panel9, true);
            SetDoubleBuffering(gunaElipsePanel1, true);
            SetDoubleBuffering(gunaElipsePanel2, true);
            SetDoubleBuffering(gunaElipsePanel3, true);
            SetDoubleBuffering(panel11, true);


            this.CenterToScreen();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);



        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {

                    timer4.Stop();

                }

                if (this.Opacity < 1)
                {

                    this.Opacity += .1;
                }
                else
                {

                    timer1.Start();

                    timer4.Stop();


                }
            }
            catch (Exception)
            {


            }
        }

        private void bunifuImageButton35_Click(object sender, EventArgs e)
        {

        }


        private void play__Tick(object sender, EventArgs e)
        {
            try
            {

         
                GTrackBar1.MaxValue = Convert.ToInt16(wmpI.currentMedia.duration);
                labelEx5.Text = wmpI.controls.currentPositionString + "/" + wmpI.currentMedia.durationString;

                GTrackBar1.Value = Convert.ToInt16(wmpI.controls.currentPosition);
            }
            catch (Exception)
            {


            }
        }

        private void GTrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            play_.Stop();
            play_.Enabled = false;
        }

        private void GTrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            wmpI.controls.currentPosition = GTrackBar1.Value;
            play_.Start();
            play_.Enabled = true;
        }

        private void gTrackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            wmpI.settings.volume = gTrackBar2.Value;
        }

        int t = 0;

        private void labelEx6_Click(object sender, EventArgs e)
        {

            t += 1;


            if (t == 1)
            {

                wmpI.settings.volume = 0;
                labelEx6.Text = "";
                gTrackBar2.Value = 0;

            }

            if (t == 2)
            {


              wmpI.settings.volume = 10;
                labelEx6.Text = "";
                gTrackBar2.Value = 10;
                t = 0;

            }

        }

     

        private void label23_Click(object sender, EventArgs e)
        {


            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }
            else
            {

 
                wmpI.controls.pause();
                play_.Stop();
                play_.Enabled = false;

            }

        }

   

        private void label22_Click(object sender, EventArgs e)
        {



            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }
            else
            {

 

                    wmpI.controls.play();
                    play_.Start();
                    play_.Enabled = true;

                

            }

        }

        #region m_e_l

    
        private void label24_Click(object sender, EventArgs e)
        {

            if (panel4.Visible == true)
            {

                if (gunaElipsePanel1.Visible == true)
                {

                    SendKeys.SendWait("+{RIGHT}");

                }

                if (gunaElipsePanel2.Visible == true)
                {


                    SendKeys.SendWait("{j}");

                }

            }
            else
            {

                wmpI.controls.fastForward();


            }
        }

        private void label25_Click(object sender, EventArgs e)
        {


            if (panel4.Visible == true)
            {

                if (gunaElipsePanel1.Visible == true)
                {

                    SendKeys.SendWait("+{LEFT}");

                }

                if (gunaElipsePanel2.Visible == true)
                {


                    SendKeys.SendWait("{k}");

                }



            }
            else
            {
                wmpI.controls.fastReverse();

            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label18_MouseEnter(object sender, EventArgs e)
        {
            p_4.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            p_4.BaseColor = Color.Transparent;
        }
        private void label22_MouseEnter(object sender, EventArgs e)
        {
            p_6.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            p_6.BaseColor = Color.Transparent;
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            p_7.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            p_7.BaseColor = Color.Transparent;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            p_8.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            p_8.BaseColor = Color.Transparent;
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            p_9.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            p_9.BaseColor = Color.Transparent;
        }

        private void labelEx6_MouseEnter(object sender, EventArgs e)
        {
            p_10.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void labelEx6_MouseLeave(object sender, EventArgs e)
        {
            p_10.BaseColor = Color.Transparent;
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            p_11.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            p_11.BaseColor = Color.Transparent;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            p_12.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            p_12.BaseColor = Color.Transparent;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            p_c.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            p_c.BaseColor = Color.Transparent;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            p_m.BaseColor = Color.FromArgb(58, 58, 58);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            p_m.BaseColor = Color.Transparent;
        }

        #endregion


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        

                    chrom.Reload();

            


                wmpI.controls.pause();
                play_.Stop();
                play_.Enabled = false;

                this.Close();

        


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


                chrom.Reload();


            gunaElipsePanel4.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            wmpI.controls.pause();
            play_.Stop();
            play_.Enabled = false;



     
            pictureBox1.Image = Properties.Resources.icons8_soundcloud_25px_1;
            pictureBox2.Image = Properties.Resources.icons8_youtube_30px;
            label18.ForeColor = Color.Silver;
            gunaElipsePanel2.Visible = false;
            gunaElipsePanel1.Visible = true;
            gunaElipsePanel3.Visible = false;

            if (Cef.IsInitialized == true)
            {

                tc.Text = "https://soundcloud.com/";

                chrom = new ChromiumWebBrowser(tc.Text);
                panel4.BackColor = Color.FromArgb(21, 21, 21);
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel4.Visible = true;
                panel2.Visible = true;
                panel4.Controls.Clear();
                panel4.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

      

                chrom.Reload();

            

            panel8.Visible = false;
            panel9.Visible = false;
            wmpI.controls.pause();
            play_.Stop();
            play_.Enabled = false;

            pictureBox1.Image = Properties.Resources.icons8_soundcloud_20px_2;
            pictureBox2.Image = Properties.Resources.icons8_youtube_30px_1;
            label18.ForeColor = Color.Silver;
            gunaElipsePanel2.Visible = true;
            gunaElipsePanel1.Visible = false;
            gunaElipsePanel3.Visible = false;

            if (Cef.IsInitialized == true)
            {

                tc.Text = "https://music.youtube.com/";

                chrom = new ChromiumWebBrowser(tc.Text);
                panel4.BackColor = Color.FromArgb(21, 21, 21);
                panel5.Visible = true;
                panel6.Visible = true;
                panel7.Visible = true;
                panel4.Visible = true;
                panel2.Visible = true;
                gunaElipsePanel4.Visible = true;
                panel4.Controls.Clear();
                panel4.Controls.Add(chrom);
                chrom.Dock = DockStyle.Fill;

            }

        }

        private void label16_Click(object sender, EventArgs e)
        {


                chrom.Reload();

            

            panel8.Visible = false;

            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }
            else
            {

                wmpI.controls.pause();
                play_.Stop();
                play_.Enabled = false;

            }


            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }

            panel9.Visible = true;
            play_.Start();

            gunaShadowPanel2.ShadowColor = Color.Black;
            panel9.BackColor = Color.Transparent;

            pictureBox1.Image = Properties.Resources.icons8_soundcloud_20px_2;
            pictureBox2.Image = Properties.Resources.icons8_youtube_30px;
            label18.ForeColor = Color.Silver;
            gunaElipsePanel2.Visible = false;
            gunaElipsePanel1.Visible = false;
            gunaElipsePanel3.Visible = false;

            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel2.Visible = false;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            try
            {
                chrom.Back();

            }
            catch (Exception)
            {


            }
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

            try
            {
                chrom.Forward();
            }
            catch (Exception)
            {
            }


        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

            try
            {
                chrom.Reload();
            }
            catch (Exception)
            {
            }


        }

        private void label18_Click(object sender, EventArgs e)
        {

          
            pictureBox1.Image = Properties.Resources.icons8_soundcloud_20px_2;
            pictureBox2.Image = Properties.Resources.icons8_youtube_30px;
            label18.ForeColor = Color.White;
            gunaElipsePanel2.Visible = false;
            gunaElipsePanel1.Visible = false;
            gunaElipsePanel3.Visible = true;


            openFileDialog1.Title = "Music";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "mp3 (*.mp3)|*.mp3|WAV (*.WAV)|*.wav|AAC (*.AAC)|*.AAC|AIFF (*.AIFF)|*.AIFF|FLAC (*.FLAC)|*.FLAC|M4A (*.M4A)|*.M4A|M4R (*.M4R)|*.MR|MMF (*.MMF)|*.MMF|OGG (*.OGG)|*.OGG|OPUS (*.OPUS)|*.OPUS|WMA (*.WMA)|*.WMA";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {

                   

                        chrom.Reload();

                    

                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                    panel7.Visible = false;
                    panel2.Visible = false;
                    gunaElipsePanel4.Visible = false;

                    if (panel4.Visible == true)
                    {

                        SendKeys.SendWait(" ");

                    }
                    else
                    {

                        wmpI.controls.pause();
                        play_.Stop();
                        play_.Enabled = false;

                    }


                    panel9.Visible = true;
                    play_.Start();



                    panel8.Visible = true;
                    gunaShadowPanel2.ShadowColor = Color.FromArgb(10, 10, 10);
                    panel9.BackColor = Color.FromArgb(10, 10, 10);
                    this.BackgroundImage = null;

                    label17.Visible = true;
                    wmpI.settings.autoStart = true;
                    wmpI.URL = openFileDialog1.FileName;

                    label3.Text = openFileDialog1.FileName;

                    string s = openFileDialog1.FileName;

                    label19.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);

                }
                catch (Exception)
                {


                }



            }

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }


        private void music_list_form_FormClosing(object sender, FormClosingEventArgs e)
        {

            chrom.Reload();

            Application.Exit();
        }

        int sm = 0;

        private void show__Tick(object sender, EventArgs e)
        {

            sm += 1;

         
            if (sm == 17)
            {



                gunaLinePanel1.Visible = true;

                gunaShadowPanel2.Visible = true;

            }



        }

        private void label16_MouseClick(object sender, MouseEventArgs e)
        {
            panel8.Visible = false;

            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }
            else
            {

                wmpI.controls.pause();
                play_.Stop();
                play_.Enabled = false;

            }


            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            if (panel4.Visible == true)
            {

                SendKeys.SendWait(" ");

            }
            else
            {

                wmpI.controls.pause();
                play_.Stop();
                play_.Enabled = false;

            }
        }

        int bs = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            bs += 1;

            if (bs == 3)
            {

                if (Cef.IsInitialized) { }
                else
                {

                    CefSettings settings = new CefSettings();
                    settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763";
                    settings.CachePath = @"C:\Windows\music_browser\Default\Cache";
                    settings.CefCommandLineArgs.Add("disable-gpu", "1");
                    Cef.Initialize(settings);

                }


                    panel8.Visible = false;
                    panel9.Visible = false;
                    wmpI.controls.pause();
                    play_.Stop();
                    play_.Enabled = false;

                    pictureBox1.Image = Properties.Resources.icons8_soundcloud_20px_2;
                    pictureBox2.Image = Properties.Resources.icons8_youtube_30px_1;
                    gunaElipsePanel2.Visible = true;
                    gunaElipsePanel1.Visible = false;
                    gunaElipsePanel3.Visible = false;

                    if (Cef.IsInitialized == true)
                    {

                        tc.Text = "https://music.youtube.com/";

                        chrom = new ChromiumWebBrowser(tc.Text);
                        panel4.BackColor = Color.FromArgb(21, 21, 21);
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel4.Visible = true;
                        panel2.Visible = true;
                        panel4.Controls.Clear();
                        panel4.Controls.Add(chrom);
                        chrom.Dock = DockStyle.Fill;

                    }

                
               

            }
            if (bs == 4)
            {

                timer1.Stop();

            }

        }

        string  the_url;
        string s;

        private void label1_Click(object sender, EventArgs e)
        {

            the_url = chrom.Address.Replace("https://music.youtube.com", "https://www.youtube.com");

            s = the_url.Substring(32, 11);

  
            System.IO.StreamWriter w1 = new System.IO.StreamWriter(@"C:\Users\" + SystemInformation.UserName + @"\Desktop\playList\url" + DateTime.Now.Second+ ".txt");
            w1.Write("https://www.youtube.com/watch?v=" + s);
            w1.Close();

            add_ add_ = new add_();

            add_.Show();
 

        }
    }
}
