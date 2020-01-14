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
    public partial class frmTitlesToCheckOut : Form
    {
        int X;
        public frmTitlesToCheckOut(int x)
        {
            InitializeComponent();
            X = x;
        }


        string user;
        private void frmTitlesToCheckOut_Load_1(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(500, 150);
            this.ActiveControl = txtbxTitles;
            string[] ID = new string[4];

            FileStream infile = new FileStream("UserNames.txt",
                        FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);
            for (int z = 0; z < 4; ++z)
            {
                ID[z] = reader.ReadLine();
            }
            user = ID[X];
            reader.Close();
            infile.Close();

            string FileName = X + "WatchList.txt";
            if (File.Exists(FileName))
            {
                FileStream listinfile = new FileStream(FileName,
                            FileMode.Open, FileAccess.Read);
                StreamReader listreader = new StreamReader(listinfile);
                int count = Convert.ToInt32(listreader.ReadLine());
                for (int z = 0; z < count; ++z)
                {
                    lstbxTitles.Items.Add(listreader.ReadLine());
                }
                listreader.Close();
                listinfile.Close();
            }
        }


        int y = 0;
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtbxTitles.Text != "" && txtbxTitles.Text != "Title Already Entered")
            {
                y = 0;
                int count = lstbxTitles.Items.Count;
                for (int z = 0; z < count; ++z)
                {
                    string titlecheck = lstbxTitles.Items[z].ToString();
                    string newtitle = txtbxTitles.Text;
                    if (newtitle == titlecheck)
                    {
                        txtbxTitles.Text = "Title Already Entered";
                        ++y;
                    }
                }
                if (y == 0)
                {
                    lstbxTitles.Items.Add(txtbxTitles.Text);
                    txtbxTitles.Text = "";
                    txtbxTitles.Focus();
                }
            }
            else if (y == 2)
                lstbxTitles.Items.Clear();
            else
            {
                ++y;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstbxTitles.Items.Remove(lstbxTitles.SelectedItem);
        }


        private void WriteList()
        {

            string FileName = X + "WatchList.txt";
            FileStream outFile = new FileStream(FileName,
                        FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            int listLength = lstbxTitles.Items.Count;
            writer.WriteLine(listLength);
            for (int z = 0; z < listLength; ++z)
            {
                writer.WriteLine(lstbxTitles.Items[z].ToString());
            }
            writer.Close();
            outFile.Close();
        }


        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mnuHome_Click_1(object sender, EventArgs e)
        {
            WriteList();

            frmHomePage homePage = new frmHomePage(X);
            this.Dispose();
            homePage.Show();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            WriteList();
            System.Windows.Forms.Application.Exit();
        }



    }
}
