namespace StreamingTracker
{
    partial class frmTVShows
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTVShows));
            this.lblHeading = new System.Windows.Forms.Label();
            this.cmboxTVShow = new System.Windows.Forms.ComboBox();
            this.lblTVShow = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.cmboxSeasons = new System.Windows.Forms.ComboBox();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnDeleteShow = new System.Windows.Forms.Button();
            this.btnAddExtraSeason = new System.Windows.Forms.Button();
            this.btnAddSeason = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chxBoxEpisodes = new System.Windows.Forms.CheckedListBox();
            this.txtNumOfEpisodes = new System.Windows.Forms.TextBox();
            this.btnEnterNumEpisodes = new System.Windows.Forms.Button();
            this.lblEpisodeInstructions = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNumOfSeasons = new System.Windows.Forms.Label();
            this.btnAdditionalEpsd = new System.Windows.Forms.Button();
            this.chxBoxCheckAll = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(110, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(158, 33);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "TV Shows";
            // 
            // cmboxTVShow
            // 
            this.cmboxTVShow.BackColor = System.Drawing.Color.LimeGreen;
            this.cmboxTVShow.DropDownHeight = 100;
            this.cmboxTVShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmboxTVShow.Font = new System.Drawing.Font("Broadway", 10F);
            this.cmboxTVShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmboxTVShow.FormattingEnabled = true;
            this.cmboxTVShow.IntegralHeight = false;
            this.cmboxTVShow.Location = new System.Drawing.Point(21, 109);
            this.cmboxTVShow.Name = "cmboxTVShow";
            this.cmboxTVShow.Size = new System.Drawing.Size(160, 23);
            this.cmboxTVShow.TabIndex = 1;
            this.cmboxTVShow.SelectedIndexChanged += new System.EventHandler(this.cmboxTVShow_SelectedIndexChanged);
            // 
            // lblTVShow
            // 
            this.lblTVShow.AutoSize = true;
            this.lblTVShow.BackColor = System.Drawing.Color.Transparent;
            this.lblTVShow.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTVShow.Location = new System.Drawing.Point(47, 77);
            this.lblTVShow.Name = "lblTVShow";
            this.lblTVShow.Size = new System.Drawing.Size(108, 17);
            this.lblTVShow.TabIndex = 3;
            this.lblTVShow.Text = "Choose Show:";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.BackColor = System.Drawing.Color.Transparent;
            this.lblSeason.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeason.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSeason.Location = new System.Drawing.Point(44, 147);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(115, 17);
            this.lblSeason.TabIndex = 4;
            this.lblSeason.Text = "Choose Season:";
            this.lblSeason.Visible = false;
            // 
            // cmboxSeasons
            // 
            this.cmboxSeasons.BackColor = System.Drawing.Color.LimeGreen;
            this.cmboxSeasons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboxSeasons.Font = new System.Drawing.Font("Broadway", 10F);
            this.cmboxSeasons.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmboxSeasons.FormattingEnabled = true;
            this.cmboxSeasons.Location = new System.Drawing.Point(21, 179);
            this.cmboxSeasons.Name = "cmboxSeasons";
            this.cmboxSeasons.Size = new System.Drawing.Size(160, 23);
            this.cmboxSeasons.TabIndex = 5;
            this.cmboxSeasons.Visible = false;
            this.cmboxSeasons.SelectedIndexChanged += new System.EventHandler(this.cmboxSeasons_SelectedIndexChanged);
            // 
            // btnAddShow
            // 
            this.btnAddShow.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddShow.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddShow.Location = new System.Drawing.Point(208, 88);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(150, 40);
            this.btnAddShow.TabIndex = 8;
            this.btnAddShow.Text = "Enter Title Then\r\nClick To Add Show";
            this.toolTip1.SetToolTip(this.btnAddShow, "Triple Click to Clear ALL");
            this.btnAddShow.UseVisualStyleBackColor = false;
            this.btnAddShow.Click += new System.EventHandler(this.btnAddShow_Click);
            // 
            // btnDeleteShow
            // 
            this.btnDeleteShow.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeleteShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteShow.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteShow.Location = new System.Drawing.Point(208, 134);
            this.btnDeleteShow.Name = "btnDeleteShow";
            this.btnDeleteShow.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteShow.TabIndex = 10;
            this.btnDeleteShow.Text = "Select Title then Click to Delete";
            this.btnDeleteShow.UseVisualStyleBackColor = false;
            this.btnDeleteShow.Visible = false;
            this.btnDeleteShow.Click += new System.EventHandler(this.btnDeleteShow_Click);
            // 
            // btnAddExtraSeason
            // 
            this.btnAddExtraSeason.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddExtraSeason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddExtraSeason.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExtraSeason.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddExtraSeason.Location = new System.Drawing.Point(208, 226);
            this.btnAddExtraSeason.Name = "btnAddExtraSeason";
            this.btnAddExtraSeason.Size = new System.Drawing.Size(150, 40);
            this.btnAddExtraSeason.TabIndex = 13;
            this.btnAddExtraSeason.Text = "Click to Add Additional Season";
            this.btnAddExtraSeason.UseVisualStyleBackColor = false;
            this.btnAddExtraSeason.Visible = false;
            this.btnAddExtraSeason.Click += new System.EventHandler(this.btnAddExtraSeason_Click);
            // 
            // btnAddSeason
            // 
            this.btnAddSeason.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddSeason.Enabled = false;
            this.btnAddSeason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSeason.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeason.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddSeason.Location = new System.Drawing.Point(208, 180);
            this.btnAddSeason.Name = "btnAddSeason";
            this.btnAddSeason.Size = new System.Drawing.Size(150, 40);
            this.btnAddSeason.TabIndex = 11;
            this.btnAddSeason.Text = "Enter # of Seasons Then Click To Add";
            this.toolTip1.SetToolTip(this.btnAddSeason, "Triple Click to Clear ALL");
            this.btnAddSeason.UseVisualStyleBackColor = false;
            this.btnAddSeason.Visible = false;
            this.btnAddSeason.Click += new System.EventHandler(this.btnAddSeason_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.Transparent;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(51, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuHome
            // 
            this.mnuHome.BackColor = System.Drawing.Color.Transparent;
            this.mnuHome.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(114, 22);
            this.mnuHome.Text = "&Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(114, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // chxBoxEpisodes
            // 
            this.chxBoxEpisodes.BackColor = System.Drawing.Color.LimeGreen;
            this.chxBoxEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chxBoxEpisodes.CheckOnClick = true;
            this.chxBoxEpisodes.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxBoxEpisodes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chxBoxEpisodes.FormattingEnabled = true;
            this.chxBoxEpisodes.Location = new System.Drawing.Point(30, 217);
            this.chxBoxEpisodes.Name = "chxBoxEpisodes";
            this.chxBoxEpisodes.Size = new System.Drawing.Size(142, 85);
            this.chxBoxEpisodes.TabIndex = 15;
            this.chxBoxEpisodes.Visible = false;
            this.chxBoxEpisodes.SelectedIndexChanged += new System.EventHandler(this.chxBoxEpisodes_SelectedIndexChanged);
            // 
            // txtNumOfEpisodes
            // 
            this.txtNumOfEpisodes.Font = new System.Drawing.Font("Broadway", 10F);
            this.txtNumOfEpisodes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNumOfEpisodes.Location = new System.Drawing.Point(79, 249);
            this.txtNumOfEpisodes.Name = "txtNumOfEpisodes";
            this.txtNumOfEpisodes.Size = new System.Drawing.Size(45, 23);
            this.txtNumOfEpisodes.TabIndex = 16;
            this.txtNumOfEpisodes.Visible = false;
            // 
            // btnEnterNumEpisodes
            // 
            this.btnEnterNumEpisodes.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnterNumEpisodes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnterNumEpisodes.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterNumEpisodes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnterNumEpisodes.Location = new System.Drawing.Point(208, 272);
            this.btnEnterNumEpisodes.Name = "btnEnterNumEpisodes";
            this.btnEnterNumEpisodes.Size = new System.Drawing.Size(150, 40);
            this.btnEnterNumEpisodes.TabIndex = 17;
            this.btnEnterNumEpisodes.Text = "Enter # of episodes then click";
            this.btnEnterNumEpisodes.UseVisualStyleBackColor = false;
            this.btnEnterNumEpisodes.Visible = false;
            this.btnEnterNumEpisodes.Click += new System.EventHandler(this.btnEnterNumEpisodes_Click);
            // 
            // lblEpisodeInstructions
            // 
            this.lblEpisodeInstructions.AutoSize = true;
            this.lblEpisodeInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblEpisodeInstructions.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisodeInstructions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEpisodeInstructions.Location = new System.Drawing.Point(19, 212);
            this.lblEpisodeInstructions.Name = "lblEpisodeInstructions";
            this.lblEpisodeInstructions.Size = new System.Drawing.Size(162, 34);
            this.lblEpisodeInstructions.TabIndex = 18;
            this.lblEpisodeInstructions.Text = "Enter Number of \r\nEpisodes for Season: 1";
            this.lblEpisodeInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEpisodeInstructions.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 274);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(52, 17);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "error\r\n";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblNumOfSeasons
            // 
            this.lblNumOfSeasons.AutoSize = true;
            this.lblNumOfSeasons.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfSeasons.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfSeasons.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNumOfSeasons.Location = new System.Drawing.Point(36, 138);
            this.lblNumOfSeasons.Name = "lblNumOfSeasons";
            this.lblNumOfSeasons.Size = new System.Drawing.Size(130, 34);
            this.lblNumOfSeasons.TabIndex = 21;
            this.lblNumOfSeasons.Text = "Enter Number of \r\nSeasons";
            this.lblNumOfSeasons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumOfSeasons.Visible = false;
            // 
            // btnAdditionalEpsd
            // 
            this.btnAdditionalEpsd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdditionalEpsd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdditionalEpsd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditionalEpsd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdditionalEpsd.Location = new System.Drawing.Point(208, 272);
            this.btnAdditionalEpsd.Name = "btnAdditionalEpsd";
            this.btnAdditionalEpsd.Size = new System.Drawing.Size(150, 40);
            this.btnAdditionalEpsd.TabIndex = 22;
            this.btnAdditionalEpsd.Text = "click to add additional episode";
            this.btnAdditionalEpsd.UseVisualStyleBackColor = false;
            this.btnAdditionalEpsd.Visible = false;
            this.btnAdditionalEpsd.Click += new System.EventHandler(this.btnAdditionalEpsd_Click);
            // 
            // chxBoxCheckAll
            // 
            this.chxBoxCheckAll.AutoSize = true;
            this.chxBoxCheckAll.BackColor = System.Drawing.Color.Transparent;
            this.chxBoxCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chxBoxCheckAll.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.chxBoxCheckAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chxBoxCheckAll.Location = new System.Drawing.Point(12, 306);
            this.chxBoxCheckAll.Name = "chxBoxCheckAll";
            this.chxBoxCheckAll.Size = new System.Drawing.Size(178, 21);
            this.chxBoxCheckAll.TabIndex = 23;
            this.chxBoxCheckAll.Text = "To Check All Episodes";
            this.chxBoxCheckAll.UseVisualStyleBackColor = false;
            this.chxBoxCheckAll.Visible = false;
            this.chxBoxCheckAll.CheckedChanged += new System.EventHandler(this.chxBoxCheckAll_CheckedChanged);
            // 
            // frmTVShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::StreamingTracker.Properties.Resources.green_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.chxBoxCheckAll);
            this.Controls.Add(this.btnAdditionalEpsd);
            this.Controls.Add(this.lblNumOfSeasons);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEpisodeInstructions);
            this.Controls.Add(this.btnEnterNumEpisodes);
            this.Controls.Add(this.txtNumOfEpisodes);
            this.Controls.Add(this.chxBoxEpisodes);
            this.Controls.Add(this.btnAddExtraSeason);
            this.Controls.Add(this.btnAddSeason);
            this.Controls.Add(this.btnDeleteShow);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.cmboxSeasons);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblTVShow);
            this.Controls.Add(this.cmboxTVShow);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTVShows";
            this.Text = "TVShows";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTVShows_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmboxTVShow;
        private System.Windows.Forms.Label lblTVShow;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.ComboBox cmboxSeasons;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Button btnDeleteShow;
        private System.Windows.Forms.Button btnAddExtraSeason;
        private System.Windows.Forms.Button btnAddSeason;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.CheckedListBox chxBoxEpisodes;
        private System.Windows.Forms.TextBox txtNumOfEpisodes;
        private System.Windows.Forms.Button btnEnterNumEpisodes;
        private System.Windows.Forms.Label lblEpisodeInstructions;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNumOfSeasons;
        private System.Windows.Forms.Button btnAdditionalEpsd;
        private System.Windows.Forms.CheckBox chxBoxCheckAll;


    }
}