using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Walkingemulator.GPX;

namespace Walkingemulator
{
    public partial class frmMain : Form
    {

        GPXClass gpx;
        TelnetConnection tc;
        Ini infile;
        const string Conffile = "config.ini";
        const string port = "port";
        const string genpath = "genpath";
        const string usegenmotion = "usegenmotion";
        const string pausesec = "pausesec";
        const string replacedotwithcommas = "replacedotswithcomas";
        
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "- " + Application.ProductVersion;
            string conffile= Path.Combine(Application.StartupPath,frmMain.Conffile);
            if (File.Exists(conffile) == true)
            {
                infile = new Ini(conffile);
                infile.Load();
                this.txtgenPath.Text = this.infile.GetValue(genpath);
                this.txtPort.Text = this.infile.GetValue(port);
                this.chbxUseGenMotion.Checked = Boolean.Parse(this.infile.GetValue(usegenmotion));
                this.nudPauseTime.Value = int.Parse(infile.GetValue(pausesec));
                this.chkReplaceDotsWithCommas.Checked = Boolean.Parse(infile.GetValue(replacedotwithcommas));            

            }
            else
            {
                this.SaveConfig();
            }
        }
        public void SaveConfig()
        {
            string conffile = Path.Combine(Application.StartupPath, frmMain.Conffile);
            if (File.Exists(conffile) != true)
            {

                File.Create(conffile).Close();
            }
                infile = new Ini(conffile);
                infile.WriteValue(genpath, this.txtgenPath.Text);
                infile.WriteValue(port, this.txtPort.Text);
                infile.WriteValue(usegenmotion, this.chbxUseGenMotion.Checked.ToString());
            this.infile.WriteValue(pausesec, Convert.ToString(nudPauseTime.Value));
            infile.WriteValue(replacedotwithcommas, this.chkReplaceDotsWithCommas.Checked.ToString());
                      
                infile.Save();
            
        }
        private void btnGPXBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogGPX.ShowDialog() == DialogResult.OK)
            {
                this.txtGpxFilePath.Text = this.openFileDialogGPX.FileName;
            }

        }

        private void btnBrowseGnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialogGEn.ShowDialog() == DialogResult.OK)
            {
                this.txtgenPath.Text = this.openFileDialogGEn.FileName;
            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.SaveConfig();

            if (this.txtGpxFilePath.Text != String.Empty)
            {
                if (File.Exists(this.txtGpxFilePath.Text))
                {
                    XmlDocument doc = new XmlDocument();
                    StreamReader rdr = new StreamReader(this.txtGpxFilePath.Text);
                    if (rdr != null)
                    {
                        string xml = rdr.ReadToEnd();

                        if (xml != String.Empty)
                        {
                            this.gpx = new GPXClass(xml);
                            if (gpx != null)
                            {
                                List<GPXClass.trk> wpts = this.gpx.Tracks;
                                if (this.chbxUseGenMotion.Checked == false)
                                {
                                    if (this.txtPort.Text != String.Empty)
                                    { 
                                        tc = new TelnetConnection("127.0.0.1", Int32.Parse(this.txtPort.Text));

                                        if (wpts != null && tc != null && tc.IsConnected == true)
                                        {
                                            string cmnds = "geo fix ";

                                            foreach (GPXClass.trk wpt in wpts)
                                            { 
                                                foreach (GPXClass.trkseg trk in wpt.Segments )
                                                {
                                                    foreach (GPXClass.trkpt trkpnt in trk.TrackPoints)
                                                    {
                                                        tc.WriteLine(cmnds + trkpnt.Lat + " " + trkpnt.Lon);
                                                    }
                                                }
                                            }


                                        }
                                    }
                                }
                                else
                                {
                                    string gerncmds = Path.Combine(Application.StartupPath, "gencmnds.txt");
                                   
                                    if (this.txtgenPath.Text != string.Empty)
                                    {
                                        StreamWriter strm = new StreamWriter(gerncmds);
                                        if (wpts != null)
                                        {


                                            foreach (GPXClass.trk wpt in wpts)
                                            {
                                                foreach (GPXClass.trkseg trk in wpt.Segments)
                                                {
                                                    foreach (GPXClass.trkpt trkpnt in trk.TrackPoints)
                                                    {
                                                        double lat;
                                                        double lon;
                                                        double ele;
                                                        if (this.chkReplaceDotsWithCommas.Checked == true)
                                                        {
                                                            lat = Double.Parse(trkpnt.Lat.Replace(".", ","));
                                                            lon = Double.Parse(trkpnt.Lon.Replace(".", ","));
                                                            ele = Double.Parse(trkpnt.Ele.Replace(".", ","));
                                                        }
                                                        else
                                                        {
                                                            lat = Double.Parse(trkpnt.Lat);
                                                            lon = Double.Parse(trkpnt.Lon);
                                                            ele = Double.Parse(trkpnt.Ele);
                                                        }
                                                     
                                                        strm.WriteLine("gps setlatitude " + lat );
 
                                                         strm.WriteLine("gps setlongitude " + lon);
                                                        strm.WriteLine("gps setaltitude " + ele);
                                                        int pausesec = (int)this.nudPauseTime.Value;
                                                        if (pausesec > 0)
                                                        {
                                                            strm.WriteLine("pause "+ Convert.ToString(pausesec));
                                                        }
                                                    }
                                                }
                                            }
                                            
                                            

                                        }
                                        strm.Flush();
                                        strm.Close();
                                        Process p = new Process();
                                        p.StartInfo.Arguments = " -f " + " \"" + gerncmds + "\"";
                                        p.StartInfo.FileName = this.txtgenPath.Text;
                                        p.Start();


                                    }
                                }



                            }
                        }
                    }
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
             if ( tc!=null &&  tc.IsConnected==true)
            {
                tc.WriteLine("exit");
            }
        }
    }
}
