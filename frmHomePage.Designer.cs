namespace StreamingTracker
{
    partial class frmHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTVShows = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnDuds = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.linkLblIMDb = new System.Windows.Forms.LinkLabel();
            this.btnTitles = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(64, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(251, 60);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Movie and\r\nTV Show Tracker";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(20, 99);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(338, 23);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to the useful tracker";
            // 
            // btnTVShows
            // 
            this.btnTVShows.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTVShows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTVShows.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVShows.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTVShows.Location = new System.Drawing.Point(129, 135);
            this.btnTVShows.Name = "btnTVShows";
            this.btnTVShows.Size = new System.Drawing.Size(133, 30);
            this.btnTVShows.TabIndex = 3;
            this.btnTVShows.Text = "TV Shows";
            this.btnTVShows.UseVisualStyleBackColor = false;
            this.btnTVShows.Click += new System.EventHandler(this.btnTVShows_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovies.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMovies.Location = new System.Drawing.Point(129, 174);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(133, 30);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnDuds
            // 
            this.btnDuds.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDuds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuds.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDuds.Location = new System.Drawing.Point(129, 252);
            this.btnDuds.Name = "btnDuds";
            this.btnDuds.Size = new System.Drawing.Size(133, 30);
            this.btnDuds.TabIndex = 5;
            this.btnDuds.Text = "DUDS";
            this.btnDuds.UseVisualStyleBackColor = false;
            this.btnDuds.Click += new System.EventHandler(this.btnDuds_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.Transparent;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUser,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 21);
            this.mnuFile.Text = "&File";
            // 
            // mnuUser
            // 
            this.mnuUser.BackColor = System.Drawing.Color.Transparent;
            this.mnuUser.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(163, 22);
            this.mnuUser.Text = "Change User";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(163, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUserName.Location = new System.Drawing.Point(47, 291);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(284, 19);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Visible = false;
            // 
            // linkLblIMDb
            // 
            this.linkLblIMDb.BackColor = System.Drawing.Color.Transparent;
            this.linkLblIMDb.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblIMDb.Image = global::StreamingTracker.Properties.Resources.imdb;
            this.linkLblIMDb.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLblIMDb.LinkColor = System.Drawing.Color.Navy;
            this.linkLblIMDb.Location = new System.Drawing.Point(305, 7);
            this.linkLblIMDb.Name = "linkLblIMDb";
            this.linkLblIMDb.Size = new System.Drawing.Size(62, 48);
            this.linkLblIMDb.TabIndex = 18;
            this.linkLblIMDb.TabStop = true;
            this.linkLblIMDb.Text = "                        ";
            this.linkLblIMDb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblIMDb_LinkClicked);
            // 
            // btnTitles
            // 
            this.btnTitles.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTitles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTitles.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTitles.Location = new System.Drawing.Point(129, 213);
            this.btnTitles.Name = "btnTitles";
            this.btnTitles.Size = new System.Drawing.Size(133, 30);
            this.btnTitles.TabIndex = 19;
            this.btnTitles.Text = "WatchList";
            this.btnTitles.UseVisualStyleBackColor = false;
            this.btnTitles.Click += new System.EventHandler(this.btnTitles_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::StreamingTracker.Properties.Resources.green_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.btnTitles);
            this.Controls.Add(this.linkLblIMDb);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDuds);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnTVShows);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Forte", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHomePage";
            this.Text = "HomePage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTVShows;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnDuds;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel linkLblIMDb;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnTitles;
    }
}