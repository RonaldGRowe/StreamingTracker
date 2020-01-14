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
    public partial class frmMovies : Form
    {
        int X;
        public frmMovies(int x)
        {
            InitializeComponent();
            X = x;
            
        }            
        
        string user;        
        private void frmMovies_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(500, 150);
            this.ActiveControl = txtbxMovies;
            

            FileStream infile = new FileStream("UserNames.txt",
                        FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);
            string[] ID = new string[4];
            for (int z = 0; z < 4; ++z)
            {
                ID[z] = reader.ReadLine();
            }
            user = ID[X];
            reader.Close();
            infile.Close(); 

            string FileName = X + "MoviesList.txt";
            if (File.Exists(FileName))
            {
                FileStream listinfile = new FileStream(FileName,
                            FileMode.Open, FileAccess.Read);
                StreamReader listreader = new StreamReader(listinfile);
                int count = Convert.ToInt32(listreader.ReadLine());
                for (int z = 0; z < count; ++z)
                {
                    lstbxMovies.Items.Add(listreader.ReadLine());
                }
                listreader.Close();
                listinfile.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstbxMovies.Items.Remove(lstbxMovies.SelectedItem);

        }


        int y = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbxMovies.Text != "" && txtbxMovies.Text != "Title Already Entered")
            {
                y = 0;
                int count = lstbxMovies.Items.Count;
                for (int z = 0; z < count; ++z)
                {
                    string titlecheck = lstbxMovies.Items[z].ToString();
                    string newtitle = txtbxMovies.Text;
                    if (newtitle == titlecheck)
                    {
                        txtbxMovies.Text = "Title Already Entered";
                        ++y;
                    }
                }
                if (y == 0)
                {
                    lstbxMovies.Items.Add(txtbxMovies.Text);
                    txtbxMovies.Text = "";
                    txtbxMovies.Focus();
                }
            }
            else if (y == 2)
                lstbxMovies.Items.Clear();
            else
            {
                ++y;
            }
        }

        private void WriteList()
        {
            
            string FileName = X + "MoviesList.txt";
            FileStream outFile = new FileStream(FileName,
                        FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            int listLength = lstbxMovies.Items.Count;
            writer.WriteLine(listLength);
            for (int z = 0; z < listLength; ++z)
            {
                writer.WriteLine(lstbxMovies.Items[z].ToString());
            }
            writer.Close();
            outFile.Close();
        }


        private void mnuExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void mnuHome_Click(object sender, EventArgs e)
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
