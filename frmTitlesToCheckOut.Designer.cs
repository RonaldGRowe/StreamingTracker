namespace StreamingTracker
{
    partial class frmTitlesToCheckOut
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtbxTitles = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbxTitles = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(33, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(312, 33);
            this.lblHeading.TabIndex = 20;
            this.lblHeading.Text = "Titles To Check Out";
            // 
            // txtbxTitles
            // 
            this.txtbxTitles.BackColor = System.Drawing.Color.LimeGreen;
            this.txtbxTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxTitles.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTitles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtbxTitles.Location = new System.Drawing.Point(95, 253);
            this.txtbxTitles.Name = "txtbxTitles";
            this.txtbxTitles.Size = new System.Drawing.Size(188, 19);
            this.txtbxTitles.TabIndex = 16;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(60, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 30);
            this.btnDelete.TabIndex = 19;
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
            this.btnAdd.Location = new System.Drawing.Point(95, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add to the sh!t list";
            this.toolTip1.SetToolTip(this.btnAdd, "Triple Click to Clear ALL");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lstbxTitles
            // 
            this.lstbxTitles.BackColor = System.Drawing.Color.LimeGreen;
            this.lstbxTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxTitles.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxTitles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lstbxTitles.FormattingEnabled = true;
            this.lstbxTitles.ItemHeight = 19;
            this.lstbxTitles.Location = new System.Drawing.Point(60, 64);
            this.lstbxTitles.Name = "lstbxTitles";
            this.lstbxTitles.Size = new System.Drawing.Size(259, 133);
            this.lstbxTitles.TabIndex = 17;
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
            this.menuStrip1.TabIndex = 21;
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
            this.mnuHome.Size = new System.Drawing.Size(152, 22);
            this.mnuHome.Text = "&Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click_1);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // frmTitlesToCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StreamingTracker.Properties.Resources.green_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtbxTitles);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstbxTitles);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmTitlesToCheckOut";
            this.Text = "Titles To Check Out";
            this.Load += new System.EventHandler(this.frmTitlesToCheckOut_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtbxTitles;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lstbxTitles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}