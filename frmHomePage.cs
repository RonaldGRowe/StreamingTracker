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
    public partial class frmHomePage : Form
    {
        int x;
        public frmHomePage(int X)
        {
            InitializeComponent();
            x = X;
        }
                
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(500, 150);
                        

            FileStream infile = new FileStream("UserNames.txt",
                        FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);
            string[] ID = new string[4];
            for (int z = 0; z < 4; ++z)
            {
                ID[z] = reader.ReadLine();
            }
            reader.Close();
            infile.Close();
            if (ID[x] != "")
            {
                lblUserName.Text = "User: " + ID[x];
                lblUserName.Visible = true;
            }

        }

        
        private void btnTVShows_Click(object sender, EventArgs e)
        {
            frmTVShows TV = new frmTVShows(x);
            this.Hide();
            TV.Show();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            frmMovies Movies = new frmMovies(x);
            this.Hide();
            Movies.Show();
        }

        private void btnTitles_Click(object sender, EventArgs e)
        {
            frmTitlesToCheckOut Watchlist = new frmTitlesToCheckOut(x);
            this.Hide();
            Watchlist.Show();
        }
        
        private void btnDuds_Click(object sender, EventArgs e)
        {
            frmDUDS Duds = new frmDUDS(x);
            this.Hide();
            Duds.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            frmWelcome welcome=new frmWelcome();
            this.Dispose();
            welcome.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLblIMDb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.imdb.com");
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
