using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamingTracker
{
    public partial class frmWelcome : Form
    {
            
            string UserLog;
            string[] ID= new string[4];
            int x;    
            
        frmAddUser addUser = new frmAddUser();
        

        public frmWelcome()
        {

            InitializeComponent();
        }
                
        private void frmWelcome_Load(object sender, EventArgs e)
        {

            this.DesktopLocation = new Point(500, 150);
            if (File.Exists("UserNames.txt"))
            {
                FileStream infile = new FileStream("UserNames.txt",
                            FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);
                for (int z = 0; z < 4; ++z)
                {
                    ID[z] = reader.ReadLine();
                }
                reader.Close();
                infile.Close();
                if (ID[0] != "")
                    btnUser1.Text = ID[0];
                if (ID[1] != "")
                    btnUser2.Text = ID[1];
                if (ID[2] != "")
                    btnUser3.Text = ID[2];
                if (ID[3] != "")
                    btnUser4.Text = ID[3];
            }
        }


        private void UserLoginDecision(string UserID)
        {             
            
            if (UserID == "Click to Add User" || chxBoxEditUser.Checked)
            {
                chxBoxEditUser.Checked = false;
                this.Hide();
                addUser.ShowDialog();
                addUser.TopMost = true;
                if (addUser.DialogResult == DialogResult.OK)
                {
                    this.Show();
                    if (addUser.UserName == "" || addUser.UserName == " ")
                        UserLog = "Click to Add User";
                    if (addUser.UserName != "" && addUser.UserName != " ")
                        UserLog = addUser.UserName;
                    ID[x]=UserLog;                

                    
                    FileStream outFile = new FileStream("UserNames.txt",
                        FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(outFile);
                    for(int y=0; y < 4; ++y)
                    {
                    writer.WriteLine(ID[y]);
                    }
                    writer.Close();
                    outFile.Close();
                }
            }
            else
            {
                
                frmHomePage homePage = new frmHomePage(x);
                this.Hide();
                homePage.Show();
                
            }
        }

               
        private void btnUser1_Click(object sender, EventArgs e)
        {
            
            x = 0;
            string userID;           
            userID = btnUser1.Text;
            UserLoginDecision(userID);
            btnUser1.Text = UserLog;
            
                              
        }

        private void btnUser2_Click(object sender, EventArgs e)
        {
           
            x = 1;
            string userID;
            userID = btnUser2.Text;
            UserLoginDecision(userID);
            btnUser2.Text = UserLog;  
            
        }

        private void btnUser3_Click(object sender, EventArgs e)
        {
            
            x = 2;
            string userID;
            userID = btnUser3.Text;
            UserLoginDecision(userID);
            btnUser3.Text = UserLog;
           
        }

        private void btnUser4_Click(object sender, EventArgs e)
        {
            
            x = 3;
            string userID;
            userID = btnUser4.Text;
            UserLoginDecision(userID);
            btnUser4.Text = UserLog;
            
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

     
        private void mnuExit_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();
        }
    }
}