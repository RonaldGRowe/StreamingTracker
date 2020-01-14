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
    public partial class frmTVShows : Form
    {
        int X;
        public frmTVShows(int x)
        {
            InitializeComponent();
            X = x;
        }
        
          
    
        string tvShow;
        int T = 0;
        int z;
        int p;
        int numOfEpisodes;
        int numOfSeasons;
        Int32[] episodes = new Int32[100];


        private void frmTVShows_Load(object sender, EventArgs e)
        {
            this.DesktopLocation = new Point(500, 150);
            

            
            string FileName = X + "tvshow.txt";
            if (File.Exists(FileName))
            {
                FileStream tvshowinfile = new FileStream(FileName,
                            FileMode.Open, FileAccess.Read);
                StreamReader tvshowreader = new StreamReader(tvshowinfile);
                int count = Convert.ToInt32(tvshowreader.ReadLine());
                for (int z = 0; z < count; ++z)
                {
                    cmboxTVShow.Items.Add(tvshowreader.ReadLine());
                }
                tvshowreader.Close();
                tvshowinfile.Close();
            }
        }



        private void cmboxTVShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvShow = cmboxTVShow.Text;
            ReadSeasonsList();
            chxBoxEpisodes.Visible = false;
            chxBoxCheckAll.Visible = false;
            cmboxSeasons.Visible = true;
            btnAddSeason.Visible = true;
            btnAddExtraSeason.Visible = true;
            btnAddExtraSeason.Enabled = true;
            btnAdditionalEpsd.Visible = true;
            btnAdditionalEpsd.Enabled = false;
            lblSeason.Visible = true;
            btnDeleteShow.Visible = true;
            lblError.Visible = false;
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            chxBoxEpisodes.Visible = false;
            chxBoxCheckAll.Visible = false;
            lblError.Visible = false;
            lblError.Text = "";
            btnAddExtraSeason.Enabled = false;
            btnAdditionalEpsd.Enabled = false;
            if (cmboxTVShow.Text != "")
            {
                int count = cmboxTVShow.Items.Count;
                for (int z = 0; z < count; ++z)
                {
                    string titlecheck=cmboxTVShow.Items[z].ToString();
                    string newtitle = cmboxTVShow.Text;
                    if (newtitle == titlecheck)
                    {
                        lblError.Text = "Title Already Entered";
                        lblError.Visible = true;
                        cmboxTVShow.Text="";
                        ++T;
                    }
                }
                if (lblError.Text != "Title Already Entered")
                {
                    cmboxTVShow.Items.Add(cmboxTVShow.Text);
                    tvShow = cmboxTVShow.Text;
                    WriteTVShowList();
                    cmboxSeasons.Visible = true;

                    btnAddSeason.Enabled = true;
                    btnAddShow.Enabled = false;
                    btnAddExtraSeason.Visible = false;
                    btnAdditionalEpsd.Visible = false;
                    btnDeleteShow.Visible = false;
                    lblSeason.Visible = false;
                    cmboxTVShow.Enabled = false;
                    chxBoxEpisodes.Visible = false;
                    chxBoxCheckAll.Visible = false;
                    cmboxSeasons.Focus();
                    cmboxSeasons.Items.Clear();
                    cmboxSeasons.Text = "";
                    btnAddSeason.Visible = true;
                    lblNumOfSeasons.Visible = true;

                    T = 0;
                }
            }
            else if (T == 2)
            {
                cmboxTVShow.Items.Clear();
                cmboxTVShow.Text = "";
                WriteTVShowList();
            }
            else
            {
                ++T;
            }
            
        }

        private void btnDeleteShow_Click(object sender, EventArgs e)
        {
            btnAddExtraSeason.Enabled = false;
            btnAdditionalEpsd.Enabled = false;
            chxBoxEpisodes.Visible = false;
            chxBoxCheckAll.Visible = false;
            cmboxSeasons.Items.Clear();
            cmboxSeasons.Text = "";
            cmboxTVShow.Items.Remove(cmboxTVShow.SelectedItem);
            cmboxTVShow.Text = "";
            WriteTVShowList();
            cmboxTVShow.Focus();
        }


        private void cmboxSeasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdditionalEpsd.Enabled = true;
            p = cmboxSeasons.SelectedIndex;
            chxBoxEpisodes.Items.Clear();
            chxBoxEpisodes.Visible = true;
            chxBoxCheckAll.Visible = true;
            for (int q = 1; q <= episodes[p]; ++q)
            {
                chxBoxEpisodes.Items.Add("Episode: "+q);
            }
            string FileName = X + tvShow + p + "watchedEpisodes.txt";
            if (File.Exists(FileName))
            {
                FileStream watchedepisodeinfile = new FileStream(FileName,
                            FileMode.Open, FileAccess.Read);
                StreamReader watchedepisodereader = new StreamReader(watchedepisodeinfile);
                for (int u = 0; u < episodes[p]; ++u)
                {
                    if (watchedepisodereader.ReadLine() == "1")
                        chxBoxEpisodes.SetItemChecked(u, true);
                    else
                        chxBoxEpisodes.SetItemCheckState(u, CheckState.Unchecked);
                }
                watchedepisodereader.Close();
                watchedepisodeinfile.Close();
            }
        }

        private void btnAddSeason_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;            
            if (Int32.TryParse(cmboxSeasons.Text.Trim(), out numOfSeasons))
            {
                
                if (numOfSeasons > 0)
                {
                    btnAddSeason.Visible = false;
                    btnEnterNumEpisodes.Visible = true;
                    cmboxSeasons.Enabled = false;
                    btnAddSeason.Enabled = false;
                    lblNumOfSeasons.Visible = false;
                    z = 1;
                    lblEpisodeInstructions.Visible = true;
                    lblEpisodeInstructions.Text = "Enter Number of" + '\n' + "Episodes for Season: " + z;
                    txtNumOfEpisodes.Visible = true;
                    txtNumOfEpisodes.Focus();
                }
                else
                {
                    lblError.Text = "Enter a Positive Number";
                    lblError.Visible = true;
                    cmboxSeasons.Focus();
                }
            }
            else
            {
                lblError.Text = "Enter a Positive Number";
                lblError.Visible = true;
                cmboxSeasons.Focus();
            }
                                
            cmboxSeasons.Text = "";
            
        }

        private void btnAddExtraSeason_Click(object sender, EventArgs e)
        {
            numOfSeasons= cmboxSeasons.Items.Count + 1;
            tvShow = cmboxTVShow.Text;
            cmboxSeasons.Enabled = false;
            cmboxTVShow.Enabled = false;
            chxBoxEpisodes.Visible = false;
            chxBoxCheckAll.Visible = false;
            btnAddShow.Enabled = false;
            btnAddSeason.Enabled = false;
            btnDeleteShow.Visible = false;
            btnEnterNumEpisodes.Visible = true;
            btnAddExtraSeason.Enabled = false;
            btnAdditionalEpsd.Visible = false;
            z = numOfSeasons;
            lblEpisodeInstructions.Visible = true;
            lblEpisodeInstructions.Text = "Enter Number of" + '\n' + "Episodes for Season: " + z;
            txtNumOfEpisodes.Visible = true;
            txtNumOfEpisodes.Focus();

        }



        private void btnEnterNumEpisodes_Click(object sender, EventArgs e)
        {
         
            lblError.Visible = false;
            if (Int32.TryParse(txtNumOfEpisodes.Text.Trim(), out numOfEpisodes))
            {
                if (numOfEpisodes > 0)
                {
                    if (z <= numOfSeasons && z > 0)
                    {                        
                        episodes[(z - 1)] = numOfEpisodes;
                        ++z;
                        lblEpisodeInstructions.Visible = true;
                        lblEpisodeInstructions.Text = "Enter Number of" + '\n' + "Episodes for Season: " + z;
                        txtNumOfEpisodes.Focus();
                    }
                }
                else
                {
                    lblError.Text = "Enter a Positive Number";
                    lblError.Visible = true;
                    txtNumOfEpisodes.Focus();
                }
            }
            else
            {
                lblError.Text = "Enter a Positive Number";
                lblError.Visible = true;
                txtNumOfEpisodes.Focus();
            }
            if (z == numOfSeasons + 1)
            {
                WriteEpisodesList(episodes);
                txtNumOfEpisodes.Visible = false;
                lblEpisodeInstructions.Visible = false;
                btnEnterNumEpisodes.Visible = false;
                cmboxSeasons.Enabled = true;
                cmboxTVShow.Enabled = true;
                btnAddShow.Enabled = true;
                ReadSeasonsList();
                cmboxSeasons.Focus();
                btnAddSeason.Visible = true;
                btnAddExtraSeason.Visible = true;
                btnAddExtraSeason.Enabled = true;
                btnAdditionalEpsd.Visible = true;
                btnAdditionalEpsd.Enabled = false;
                btnDeleteShow.Visible = true;
            }
        }

        private void btnAdditionalEpsd_Click(object sender, EventArgs e)
        {
            episodes[p] = episodes[p] + 1;
            chxBoxEpisodes.Items.Add("Episode: " + episodes[p]);
            WriteWatchedEpisodeList();
        }


        
        private void chxBoxEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteWatchedEpisodeList();
        }

        private void chxBoxCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int u = 0; u < chxBoxEpisodes.Items.Count; ++u)
            {
                if (chxBoxCheckAll.CheckState==CheckState.Checked)
                    chxBoxEpisodes.SetItemChecked(u, true);
                else
                    chxBoxEpisodes.SetItemCheckState(u, CheckState.Unchecked);
            }
            WriteWatchedEpisodeList();
        }


        
        private void ReadSeasonsList()
        {
            string season;            
            string FileName = X + tvShow + "Episodes.txt";
            FileStream episodeinfile = new FileStream(FileName,
                        FileMode.Open, FileAccess.Read);
            StreamReader episodereader = new StreamReader(episodeinfile);
            int count = Convert.ToInt32(episodereader.ReadLine());
            cmboxSeasons.Items.Clear();
            cmboxSeasons.Text = "";
            for (int l = 0; l < count; ++l)
            {
                season = "Season: " + (l + 1);
                cmboxSeasons.Items.Add(season);
                episodes[l] = Convert.ToInt32(episodereader.ReadLine());
            }
            episodereader.Close();
            episodeinfile.Close();
        }

        
        private void WriteTVShowList()
        {
            
            string FileName = X + "tvshow.txt";
            FileStream tvshowoutFile = new FileStream(FileName,
                        FileMode.Create, FileAccess.Write);
            StreamWriter tvshowwriter = new StreamWriter(tvshowoutFile);
            int cmboxLength = cmboxTVShow.Items.Count;
            tvshowwriter.WriteLine(cmboxLength);
            for (int z = 0; z < cmboxLength; ++z)
            {
                tvshowwriter.WriteLine(cmboxTVShow.Items[z].ToString());
            }
            tvshowwriter.Close();
            tvshowoutFile.Close();
        }

        private void WriteEpisodesList(int[] Episodes)
        {
            string FileName = X + tvShow + "Episodes.txt";
            FileStream episodeoutFile = new FileStream(FileName,
                        FileMode.Create, FileAccess.Write);
            StreamWriter episodewriter = new StreamWriter(episodeoutFile);
            episodewriter.WriteLine(numOfSeasons);
            for (int z = 0; z < numOfSeasons; ++z)
            {
                episodewriter.WriteLine(Episodes[z]);
            }
            episodewriter.Close();
            episodeoutFile.Close();
        }

        private void WriteWatchedEpisodeList()
        {
            string FileName = X + tvShow + p + "watchedEpisodes.txt";
            FileStream watchedepisodeoutFile = new FileStream(FileName,
                        FileMode.Create, FileAccess.Write);
            StreamWriter watchedepisodewriter = new StreamWriter(watchedepisodeoutFile);
            for(int u=0; u< episodes[p]; ++u)
            {
                if (chxBoxEpisodes.GetItemCheckState(u) == CheckState.Checked)
                    watchedepisodewriter.WriteLine(1);
                else
                    watchedepisodewriter.WriteLine(0);
            }
            watchedepisodewriter.Close();
            watchedepisodeoutFile.Close();
        }

        

        private void mnuHome_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            frmHomePage homePage = new frmHomePage(X);
            homePage.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
           
            System.Windows.Forms.Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            System.Windows.Forms.Application.Exit();
        }






    }
}
