using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingTracker
{
        
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(500, 150);
            txtUserName.Text = "";
            this.ActiveControl = txtUserName;
        }           
        public string UserName 
        { 
            get
            {
                return txtUserName.Text;
            } 
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {   
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }


    }
}
