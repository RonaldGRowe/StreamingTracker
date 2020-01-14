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
    public partial class frmDUDS : Form
    {
        int X;
        public frmDUDS(int x)
        {
            InitializeComponent();
            X = x;
        }      
                
        string user;
        private void frmDUDS_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(500, 150);
            this.ActiveControl = txtbxDuds;            
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

            string FileName = X + "DudsList.txt";
            if (File.Exists(FileName))
            {
                FileStream listinfile = new FileStream(FileName,
                            FileMode.Open, FileAccess.Read);
                StreamReader listreader = new StreamReader(listinfile);
                int count = Convert.ToInt32(listreader.ReadLine());
                for (int z = 0; z < count; ++z)
                {
                    lstbxDuds.Items.Add(listreader.ReadLine());
                }
                listreader.Close();
                listinfile.Close();
            }
        }


        int y = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbxDuds.Text != "" && txtbxDuds.Text != "Title Already Entered")
            {
                y = 0;
                int count = lstbxDuds.Items.Count;
                for (int z = 0; z < count; ++z)
                {
                    string titlecheck = lstbxDuds.Items[z].ToString();
                    string newtitle = txtbxDuds.Text;
                    if (newtitle == titlecheck)
                    {
                        txtbxDuds.Text = "Title Already Entered";
                        ++y;
                    }
                }
                if (y == 0)
                {
                    lstbxDuds.Items.Add(txtbxDuds.Text);
                    txtbxDuds.Text = "";
                    txtbxDuds.Focus();
                }
            }
                else if (y == 2)
                    lstbxDuds.Items.Clear();
                else
                {
                    ++y;
                }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstbxDuds.Items.Remove(lstbxDuds.SelectedItem);
        }


        private void WriteList()
        {
            
            string FileName = X + "DudsList.txt";
            FileStream outFile = new FileStream(FileName,
                        FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            int listLength=lstbxDuds.Items.Count;
            writer.WriteLine(listLength);
            for (int z = 0; z < listLength; ++z)
            {
                 writer.WriteLine(lstbxDuds.Items[z].ToString());                    
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
