namespace StreamingTracker
{
    partial class frmDUDS
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
            this.txtbxDuds = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbxDuds = new System.Windows.Forms.ListBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxDuds
            // 
            this.txtbxDuds.BackColor = System.Drawing.Color.LimeGreen;
            this.txtbxDuds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxDuds.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDuds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtbxDuds.Location = new System.Drawing.Point(94, 248);
            this.txtbxDuds.Name = "txtbxDuds";
            this.txtbxDuds.Size = new System.Drawing.Size(188, 19);
            this.txtbxDuds.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(59, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Select Then Click to Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Location = new System.Drawing.Point(94, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add to the sh!t list";
            this.toolTip1.SetToolTip(this.btnAdd, "Triple Click to Clear ALL");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstbxDuds
            // 
            this.lstbxDuds.BackColor = System.Drawing.Color.LimeGreen;
            this.lstbxDuds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxDuds.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxDuds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstbxDuds.FormattingEnabled = true;
            this.lstbxDuds.ItemHeight = 19;
            this.lstbxDuds.Location = new System.Drawing.Point(59, 59);
            this.lstbxDuds.Name = "lstbxDuds";
            this.lstbxDuds.Size = new System.Drawing.Size(259, 133);
            this.lstbxDuds.TabIndex = 7;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(136, 17);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(106, 40);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "DUDS";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LimeGreen;
            this.toolTip1.ForeColor = System.Drawing.Color.MidnightBlue;
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
            this.mnuHome,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 21);
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
            // frmDUDS
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::StreamingTracker.Properties.Resources.green_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtbxDuds);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstbxDuds);
            this.Name = "frmDUDS";
            this.Text = "DUDS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmDUDS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxDuds;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstbxDuds;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}