namespace GIFPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.giflist = new System.Windows.Forms.ListBox();
            this.openfile = new System.Windows.Forms.Button();
            this.openfiles = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.isLoop = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // giflist
            // 
            this.giflist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.giflist.FormattingEnabled = true;
            this.giflist.ItemHeight = 12;
            this.giflist.Location = new System.Drawing.Point(0, 0);
            this.giflist.Name = "giflist";
            this.giflist.Size = new System.Drawing.Size(214, 652);
            this.giflist.TabIndex = 1;
            this.giflist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.giflist_MouseDoubleClick);
            // 
            // openfile
            // 
            this.openfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfile.Location = new System.Drawing.Point(57, 688);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(74, 23);
            this.openfile.TabIndex = 2;
            this.openfile.Text = "打开文件";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // openfiles
            // 
            this.openfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openfiles.Location = new System.Drawing.Point(134, 688);
            this.openfiles.Name = "openfiles";
            this.openfiles.Size = new System.Drawing.Size(76, 23);
            this.openfiles.TabIndex = 2;
            this.openfiles.Text = "打开文件夹";
            this.openfiles.UseVisualStyleBackColor = true;
            this.openfiles.Click += new System.EventHandler(this.openfiles_Click);
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Location = new System.Drawing.Point(6, 688);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(48, 23);
            this.play.TabIndex = 3;
            this.play.Text = "播放";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // isLoop
            // 
            this.isLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.isLoop.AutoSize = true;
            this.isLoop.Location = new System.Drawing.Point(16, 666);
            this.isLoop.Name = "isLoop";
            this.isLoop.Size = new System.Drawing.Size(72, 16);
            this.isLoop.TabIndex = 4;
            this.isLoop.Text = "循环目录";
            this.isLoop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.giflist);
            this.panel1.Controls.Add(this.isLoop);
            this.panel1.Controls.Add(this.openfile);
            this.panel1.Controls.Add(this.openfiles);
            this.panel1.Controls.Add(this.play);
            this.panel1.Location = new System.Drawing.Point(984, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 716);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1197, 715);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox giflist;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button openfiles;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.CheckBox isLoop;
        private System.Windows.Forms.Panel panel1;
    }
}

