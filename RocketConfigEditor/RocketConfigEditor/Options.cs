using System;
using System.Windows.Forms;

namespace RocketConfigEditor
{
    public partial class Options : Form
    {
        
        public Options()
        {
            InitializeComponent();
        }
        AppConfig curCon;

        private void Options_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            curCon = ConfigHandler.getConfig();
            
            txtDirPath.Text = curCon.DirPath;
            txtHostName.Text = curCon.HostName;
            txtPass.Text = curCon.Password;
            txtPort.Text = curCon._Port;
            txtUserName.Text = curCon.User;
            cbLocal.Checked = curCon.IsLocal;
        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            string host, path, usr, pass, _port;
            bool isLocal;
            host = txtHostName.Text;
            pass = txtPass.Text;
            path = txtDirPath.Text;
            usr = txtUserName.Text;
            _port = txtPort.Text;
            isLocal = cbLocal.Checked;
            if (isLocal)
            {
                host = "127.0.0.1";
            }
            if (host == ""||path==""||_port=="")
            {
                MessageBox.Show("Please make sure you fill in all fields", "ERROR");
            }
            else
            {
                curCon = new AppConfig(host, path, isLocal, _port, usr, pass, radESSL.Checked);
                ConfigHandler.setConfig(curCon);
                this.Close();
            }
            
            

        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
