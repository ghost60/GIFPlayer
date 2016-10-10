using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;

namespace GIFPlayer
{
    public partial class Form1 : Form
    {
        private Image nowgif = null;
        private EventHandler m_evthdlAnimator = null;
        private int count = 0;
        private int nowcount = 0;
        private int playno = 0;
        private List<Image> playerlist = null;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            m_evthdlAnimator = new EventHandler(OnImageAnimate);
            Debug.Assert(m_evthdlAnimator != null);
        }
         protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (nowgif != null)
            {
                UpdateImage();
                int x = 0,y=0;
                int height = this.Height;
                int width =(int)( (nowgif.Width / (double)nowgif.Height) * height);
                //if (nowgif.Width < this.Width / 2 && nowgif.Height < this.Height / 2)
                //{
                //    width = 2 * nowgif.Width;
                //    height = 2 * nowgif.Height;
                //}
                x = (this.Width - width) / 2;
                //y = (this.Height - 20 - height) / 2;
                e.Graphics.DrawImage(nowgif, new Rectangle(x, y, width, height));
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nowgif != null)
            {
                StopAnimate();
                nowgif = null;
            }
        }
        private void BeginAnimate()
        {
            if (nowgif == null)
                return;

            if (ImageAnimator.CanAnimate(nowgif))
               {
                   ImageAnimator.Animate(nowgif, m_evthdlAnimator);
               }     
        }

        private void StopAnimate()
        {
            if (nowgif == null)
                return;

            if (ImageAnimator.CanAnimate(nowgif))
            {
                ImageAnimator.StopAnimate(nowgif, m_evthdlAnimator);
            }
        }

        private void UpdateImage()
        {
            if (nowgif == null)
                return;

            FrameDimension fd = new FrameDimension(nowgif.FrameDimensionsList[0]);
            count = nowgif.GetFrameCount(fd);

            if (ImageAnimator.CanAnimate(nowgif))
            {
                ImageAnimator.UpdateFrames(nowgif);
            }
            if (isLoop.Checked)
            {
                nowcount++;
                if (nowcount >= count)
                {
                    nowcount = 0;
                    playno++;
                    if (playno >= playerlist.Count)
                    {
                        playno = 0;
                    }
                    StopAnimate();
                    nowgif = playerlist[playno];
                    BeginAnimate();
                }
            }
        }
        private void OnImageAnimate(Object sender,EventArgs e)
        {
            this.Invalidate(); 
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "GIF文件(*.gif)|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = dialog.FileName;
                giflist.Items.Add(FileName);
            }
        }

        private void openfiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo TheFolder = new DirectoryInfo(folderDlg.SelectedPath);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    if (NextFile.Extension==".gif")
                    {
                        giflist.Items.Add(NextFile.FullName);
                    }
                }                   
            }
        }

        private void giflist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (giflist.SelectedItems.Count>0)
            {
                playerlist = new List<Image>();
                playerlist.Add(Image.FromFile(giflist.SelectedItems[0].ToString()));
                nowgif = playerlist[0];
                BeginAnimate();
                Button btn = (Button)sender;
                btn.Text = "暂停";
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "播放")
            {
                playerlist = new List<Image>();
                if (giflist.Items.Count > 0)
                {
                    foreach (var item in giflist.Items)
                    {
                        Image gif = Image.FromFile(item.ToString());
                        playerlist.Add(gif);
                    }
                }
                nowgif = playerlist[0];
                playno = 0;
                BeginAnimate();
                btn.Text = "暂停";
            }
            else
            {
                StopAnimate();
                btn.Text = "播放";
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.panel1.Visible)
            {
                this.panel1.Visible = false;
            }
            else
            {
                this.panel1.Visible = true;
            }
        }
    }
}
