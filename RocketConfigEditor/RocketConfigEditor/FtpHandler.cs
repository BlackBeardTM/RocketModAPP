using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace RocketConfigEditor
{
    class FtpHandler
    {

        private Uri serverUri;
        private string path;
        private AppConfig appCon;
        private string inPath;

        public string InPath
        {
            get { return inPath; }
            set { inPath = value; }
        }

        public AppConfig AppCon
        {
            get { return appCon; }
            set { appCon = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public Uri ServerUri
        {
            get { return serverUri; }
            set { serverUri = value; }
        }
        //server file lookup configurator.
        public FtpHandler(Uri serverUri, string path, AppConfig appCon, string inFullPath)
        {
            this.serverUri = serverUri;
            this.path = path;
            this.appCon = appCon;
            this.inPath = inFullPath;
        }
        //FTP Download from server
        public void DownloadFilesFromServer()
        {
            
            MainForm obj = new MainForm();
            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Failed to resolve Host Name.");
                return;
            }
            string[] input = new string[2];
            input[0] = appCon.User;
            input[1] = appCon.Password;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri.ToString() + path);
            if (appCon.User == "" && appCon.Password == "")
            {
                ShowInputDialog(ref input);
                appCon.User = input[0];
                appCon.Password = input[1];
                request.Credentials = new NetworkCredential(appCon.User, appCon.Password);

            }
            else
            {
                request.Credentials = new NetworkCredential(appCon.User, appCon.Password);

            }

            try
            {
                request.Proxy = FtpWebRequest.DefaultWebProxy;
               
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                FileStream file = new FileStream(inPath, FileMode.Create, FileAccess.Write);
                StreamWriter write = new StreamWriter(file);
                obj.lblStatus.Text = "Complete.";
                write.WriteLine(reader.ReadToEnd());
                write.Flush();
                write.Close();
                file.Dispose();
                file.Close();
                

                reader.Close();
                response.Close();


            }
            catch (WebException ex)
            {
                FtpWebResponse respExp = (FtpWebResponse)ex.Response;
                if (respExp.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {

                    MessageBox.Show("File Does Not Exist : " + serverUri.ToString() + path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        //FTP server upload.
        public void UploadFilesToServer()
        {

            MainForm obj = new MainForm();
            if (serverUri.Scheme != Uri.UriSchemeFtp)
            {
                MessageBox.Show("Failed to resolve Host Name.");
                return;
            }

            string[] input = new string[2];
            input[0] = appCon.User;
            input[1] = appCon.Password;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri.ToString() + path);
            if (appCon.User == "" && appCon.Password == "")
            {
                ShowInputDialog(ref input);
                appCon.User = input[0];
                appCon.Password = input[1];
                request.Credentials = new NetworkCredential(appCon.User, appCon.Password);

            }
            else
            {
                request.Credentials = new NetworkCredential(appCon.User, appCon.Password);

            }

            //Rename FTP File
            FtpWebRequest requestRename = (FtpWebRequest)WebRequest.Create(serverUri.ToString() + path);
            requestRename.Credentials = new NetworkCredential(appCon.User, appCon.Password);
            requestRename.Proxy = FtpWebRequest.DefaultWebProxy;
            //Upload new FTP File
            FtpWebRequest requestUpload = (FtpWebRequest)WebRequest.Create(serverUri.ToString() + path);
            requestUpload.Credentials = new NetworkCredential(appCon.User, appCon.Password);
            requestUpload.Proxy = FtpWebRequest.DefaultWebProxy;
            //Ftp Request Delete
            FtpWebRequest requestDelete = (FtpWebRequest)WebRequest.Create(serverUri.ToString() + path + ".bac");
            requestDelete.Credentials = new NetworkCredential(appCon.User, appCon.Password);
            requestDelete.Proxy = FtpWebRequest.DefaultWebProxy;
            try
            {
                
                //Ftp Renaming
                requestRename.Method = WebRequestMethods.Ftp.Rename;
                requestRename.RenameTo = path.Substring(path.LastIndexOf('/') + 1) + ".bac";
                FtpWebResponse responseRename = (FtpWebResponse)requestRename.GetResponse();//submits request
                //end of renaming
                //Ftp Uploading
                requestUpload.Method = WebRequestMethods.Ftp.UploadFile;
                FtpWebResponse responseUpload = (FtpWebResponse)requestUpload.GetResponse();
                Stream RequestStream = requestUpload.GetRequestStream();
                StreamWriter write = new StreamWriter(RequestStream);
                FileStream LocalFile = new FileStream(InPath,FileMode.Open,FileAccess.Read);
                StreamReader read = new StreamReader(LocalFile);
                write.WriteLine(read.ReadToEnd());
                write.Flush();
                RequestStream.Flush();
                write.Close();
                RequestStream.Dispose();
                RequestStream.Close();
                read.Close();
                LocalFile.Dispose();
                LocalFile.Close();
                //end of uploading
                requestDelete.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse responseDelete = (FtpWebResponse)requestDelete.GetResponse();


            }
            catch (WebException ex)
            {
                FtpWebResponse respExp = (FtpWebResponse)ex.Response;
                if (respExp.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {

                    MessageBox.Show("File Does Not Exist : " + serverUri.ToString() + path);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private static DialogResult ShowInputDialog(ref string[] input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 140);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Login to FTP";

            //username
            System.Windows.Forms.Label lblUser = new Label();
            lblUser.Size = new System.Drawing.Size(size.Width - 10, 12);
            lblUser.Location = new System.Drawing.Point(5,5);
            lblUser.Text = "username:";
            inputBox.Controls.Add(lblUser);

            System.Windows.Forms.TextBox txtUser = new TextBox();
            txtUser.Size = new System.Drawing.Size(size.Width - 10, 23);
            txtUser.Location = new System.Drawing.Point(5, 25);
            txtUser.Text = input[0];
            inputBox.Controls.Add(txtUser);
            //password
            System.Windows.Forms.Label lblpass = new Label();
            lblpass.Size = new System.Drawing.Size(size.Width - 10, 12);
            lblpass.Location = new System.Drawing.Point(5, 55);
            lblpass.Text = "Password:";
            inputBox.Controls.Add(lblpass);

            System.Windows.Forms.TextBox txtPassw = new TextBox();
            txtPassw.Size = new System.Drawing.Size(size.Width - 10, 23);
            txtPassw.Location = new System.Drawing.Point(5, 70);
            txtPassw.UseSystemPasswordChar = true;
            txtPassw.Text = input[1];
            inputBox.Controls.Add(txtPassw);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 95);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 95);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input[0] = txtUser.Text;
            input[1] = txtPassw.Text;
            return result;
        }
    }
}
