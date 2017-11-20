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
using System.Threading;
using RocketConfigEditor.Plugins.Zaup;
using System.Reflection;
using rceAssets;
using System.Diagnostics;

namespace RocketConfigEditor
{
    public partial class MainForm : Form
    {
        List<Plugin> plugins;
        List<Item> items;
        List<string> groupIds = new List<string>();
        ICollection<Type> pluginTypes = new List<Type>();
        AppConfig AppCon;
        RocketPermissions rocketPermissions;
        ICollection<IRcePlugin> iplugins;
        private static readonly string Dir = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp";
        ICollection<Assembly> assemblies;
        public MainForm()
        {
            InitializeComponent();
        }
        string inFullPath;
        private void cbPermConAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPermConAdd.SelectedIndex != -1)
            {
                if (cbPermConAdd.SelectedItem.ToString() == "Command")
                {
                    txtcmdAdd.Text = "";
                    if (txtcmdAdd.ReadOnly)
                    {
                        txtcmdAdd.ReadOnly = false;
                    }
                }
                else if (cbPermConAdd.SelectedItem.ToString() == "Color")
                {
                    if (!txtcmdAdd.ReadOnly)
                    {
                        txtcmdAdd.ReadOnly = true;
                    }
                    cdColorCommand.ShowDialog();
                    txtcmdAdd.Text = "#" + ChangeColorToHex(cdColorCommand.Color);
                }
                else if (cbPermConAdd.SelectedItem.ToString() == "Member")
                {//not added yet.
                    txtcmdAdd.Text = "";
                    if (txtcmdAdd.ReadOnly)
                    {
                        txtcmdAdd.ReadOnly = false;
                    }
                }
            }
            
        }
        private string ChangeColorToHex(System.Drawing.Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileHandler.scanFileDirectory();
            ConfigHandler.checkLocalFiles();
            AppCon = ConfigHandler.getConfig();
            plugins = ConfigHandler.GetPluginList();
            items = ConfigHandler.GetItemIndex();
            
            //load plugin Dll files
            assemblies =  XmlFileHandler.LoadPlugins();
            PluginManifest();
        }
        
        private void btnOptions_Click(object sender, EventArgs e)
        {
            
            Options opt = new Options();
            opt.Show();
            
        }
        BindingSource source ;
        private void MainForm_Activated(object sender, EventArgs e)
        {
            FileHandler.scanFileDirectory();
            AppCon = ConfigHandler.getConfig();
            plugins = ConfigHandler.GetPluginList();
            

        }
        private void PluginManifest()
        {
            Type pluginType = typeof(IRcePlugin);
            foreach (Assembly assembly in assemblies)
            {
                if (assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                        {
                            continue;
                        }
                        else
                        {
                            if (type.GetInterface(pluginType.FullName) != null)
                            {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }
            }//end
            
            iplugins = new List<IRcePlugin>(pluginTypes.Count);
            foreach (Type type in pluginTypes)
            {
                IRcePlugin plugin = (IRcePlugin)Activator.CreateInstance(type);
                iplugins.Add(plugin);
            }

            foreach (var plugincomp in iplugins)
            {
                plugins.Add(new Plugin(plugincomp.Name, plugincomp.ConfigFileFullname, true));
            }
            foreach (IRcePlugin rcplug in iplugins)
            {

                cbPlugins.Items.Add(rcplug.Name);
                plugins.Add(new Plugin(rcplug.Name,rcplug.ConfigFileFullname,true));
            }
            

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            Uri ftp = new Uri("ftp://"+AppCon.HostName);
            //TODO : create a list to handle the Documents paths.
            string doc = "Permissions.config.xml";//get from list;

            inFullPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp\\";

            string path = AppCon.DirPath + "/";

            FtpHandler ftpHandler = new FtpHandler(ftp,path+doc,AppCon,inFullPath + doc);
            //Thread reamains un-touched.
            Thread downloadFilesThread = new Thread(new ThreadStart(ftpHandler.DownloadFilesFromServer));

            lblStatus.Text = "Downloading files!";
            //inisiate download.
            downloadFilesThread.Start();
            downloadFilesThread.Join();
            //download completed.
            lblStatus.Text = "Complete!";
           // downloadFilesThread.Abort();
            FtpHandler ftpHandlerp = new FtpHandler(ftp, "", AppCon, "");
            downloadFilesThread.Abort();
            foreach (Plugin item in plugins)
            {
                if (!Directory.Exists(inFullPath+"Plugins\\"+item.Name))
                {
                    Directory.CreateDirectory(inFullPath + "Plugins\\" + item.Name);
                }
                ftpHandlerp.Path = path + "Plugins/"+ item.Name + "/" + item.ConfigFile;
                ftpHandlerp.InPath = inFullPath + "Plugins\\" + item.Name + "\\" + item.ConfigFile;

                if (item.Enabled)
                {
                    downloadFilesThread = new Thread(new ThreadStart(ftpHandlerp.DownloadFilesFromServer));
                    lblStatus.Text = "Downloading files!";
                    //inisiate download.
                    downloadFilesThread.Start();
                    downloadFilesThread.Join();
                    //download completed.
                    lblStatus.Text = "Complete!";
                    downloadFilesThread.Abort();
                }
            }
            cbPlugins.Enabled = true;
        }
        //Use Update Data to update the lists in the memory and display required data.
        private void updateData()
        {
            txtcmdAdd.Text = "";
            cbGroup.SelectedIndex = -1;
            cbPermConAdd.SelectedIndex = -1;
            //cbGroup.Items.Clear();
            rocketPermissions = XmlFileHandler.GetRocketPerm();
            
            cbGroup.DataSource = rocketPermissions.Groups;
            cbGroup.DisplayMember = "DisplayName";
            
            //if (rocketPermissions.Groups != null)
            //{
            //    foreach (var item in rocketPermissions.Groups)
            //    {
            //        cbGroup.Items.Add(item.DisplayName.ToString());
            //    }
            //}


        }

        private void btnRpermAdd_Click(object sender, EventArgs e)
        {
            RocketPermissions perms = XmlFileHandler.GetRocketPerm();
            string grp = cbGroup.SelectedItem.ToString();
            string elementType = cbPermConAdd.SelectedItem.ToString();
            string element = txtcmdAdd.Text;
            uint CoolDown = Convert.ToUInt32(nudCooldown.Value);
            
            if (elementType == "Color"|| elementType == "color")
            {
                for(int i = 0; i < perms.Groups.Length;i++)
                {
                    if (perms.Groups[i] == (RocketPermissionsGroup)cbGroup.SelectedItem)
                    {
                        perms.Groups[i].Color = element;
                    }
                }
            }
            else
            {
                for(int i = 0; i < perms.Groups.Length; i++)
                {
                    if (perms.Groups[i].DisplayName == cbGroup.DisplayMember)
                    {
                        perms.Groups[i].permission.Add(new Permission(element,CoolDown));
                    }
                }
            }
            //XmlFileHandler.UpdateRocketPerm(rocketPermissions, @lelementType, element, grp,CoolDown);
            
            DefaultSerialization.serialize(perms, Dir + "\\Permissions.config.xml");
            updateData();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            updateData();
            updateData();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            Uri ftp = new Uri("ftp://" + AppCon.HostName);
            //TODO : create a list to handle the Documents paths.
            string doc = "Permissions.config.xml";//get from list;

            inFullPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp\\" + doc;

            string path = "/" + AppCon.DirPath + "/" + doc;

            FtpHandler ftpHandler = new FtpHandler(ftp, path, AppCon, inFullPath);
            //Thread reamains un touched.
            Thread UploadFilesThread = new Thread(new ThreadStart(ftpHandler.UploadFilesToServer));

            lblStatus.Text = "Uploading files!";
            //inisiate Upload.
            UploadFilesThread.Start();
            UploadFilesThread.Join();
            //Upload completed.
            lblStatus.Text = "Complete!";

            foreach (Plugin item in plugins)
            {
                ftpHandler.Path = path + "Plugins/" + item.Name + "/" + item.ConfigFile;
                ftpHandler.InPath = inFullPath + "Plugins\\" + item.Name + "\\" + item.ConfigFile;
                if (item.Enabled)
                {
                    UploadFilesThread = new Thread(new ThreadStart(ftpHandler.DownloadFilesFromServer));
                    lblStatus.Text = "Downloading files!";
                    //inisiate download.
                    UploadFilesThread.Start();
                    UploadFilesThread.Join();
                    //download completed.
                    lblStatus.Text = "Complete!";
                    UploadFilesThread.Abort();
                }
            }
        }

        private void btnAddPermGroup_Click(object sender, EventArgs e)
        {
            string groupID, groupName,color;
            groupID = txtGrpId.Text;
            groupName = txtGrpName.Text;
            List<RocketPermissionsGroup> tempGroupList = new List<RocketPermissionsGroup>();
            List<string> perantGroups = new List<string>();
            List<string> members = new List<string>();
            List<Permission> commands = new List<Permission>();
            List<string> tempComs = new List<string>();
            members = rtxtAddMembers.Lines.ToList();
            tempComs = rtxtCommands.Lines.ToList();
            int cooldown = (int)nudCooldown.Value;
            foreach (string item in tempComs)
            {
                commands.Add(new Permission(item,(uint)cooldown));
            }
            perantGroups = rtxtParentGroups.Lines.ToList();

            tempGroupList = rocketPermissions.Groups.ToList();
            color = btnColorChange.Text == "Color" ? "#ffffff" : btnColorChange.Text;
            tempGroupList.Add(new RocketPermissionsGroup(groupID,color, groupName, perantGroups, members, commands));
            rocketPermissions.Groups = tempGroupList.ToArray();
            DefaultSerialization.serialize(rocketPermissions, Dir + "\\Permissions.config.xml");
            updateData();
            txtcmdAdd.Clear();
            txtGrpId.Clear();
            rtxtParentGroups.Clear();
            rtxtCommands.Clear();
            rtxtAddMembers.Clear();
        }

        private void tcUniversal_SelectedIndexChanged(object sender, EventArgs e)
        {
            plugins = ConfigHandler.GetPluginList();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Uri ftp = new Uri("ftp://" + AppCon.HostName);
            //TODO : create a list to handle the Documents paths.
            string doc = "Permissions.config.xml";//get from list;

            inFullPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp\\" ;

            string path = AppCon.DirPath + "/";

            FtpHandler ftpHandler = new FtpHandler(ftp, path + doc, AppCon, inFullPath + doc);
            //Thread reamains un touched.
            Thread UploadFilesThread = new Thread(new ThreadStart(ftpHandler.UploadFilesToServer));

            lblStatus.Text = "Uploading files!";
            //inisiate Upload.
            UploadFilesThread.Start();
            UploadFilesThread.Join();
            //Upload completed.
            lblStatus.Text = "Complete!";
            UploadFilesThread.Abort();
            foreach (Plugin item in plugins)
            {
                ftpHandler.Path = path + "Plugins/" + item.Name + "/" + item.ConfigFile;
                ftpHandler.InPath = inFullPath + "Plugins\\" + item.Name + "\\" + item.ConfigFile;
                if (item.Enabled)
                {
                    UploadFilesThread = new Thread(new ThreadStart(ftpHandler.UploadFilesToServer));
                    lblStatus.Text = "Uploading files!";
                    //inisiate download.
                    UploadFilesThread.Start();
                    UploadFilesThread.Join();
                    //download completed.
                    lblStatus.Text = "Complete!";
                    UploadFilesThread.Abort();
                }
            }
        }

        private void btnEditPluginsConfig_Click(object sender, EventArgs e)
        {

            if (cbPlugins.SelectedIndex != -1)
            {
                foreach (Assembly assembly in assemblies)
                {
                    
                    
                    if (assembly.ManifestModule.ToString().Substring(0, assembly.ManifestModule.ToString().LastIndexOf('.')) == cbPlugins.SelectedItem.ToString())
                    {//trial and error
                        foreach (IRcePlugin item in iplugins)
                        {
                            if (item.Name == cbPlugins.SelectedItem.ToString())
                            {
                                Type type = assembly.GetType(item.FormFullName.ToString());
                                Form form = (Form)Activator.CreateInstance(type);
                                form.ShowDialog();
                            }
                        }
                        
                    }
                }
            }
            
        }

        private void btnloacalDirectory_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Dir);
        }

        private void btnColorChange_Click(object sender, EventArgs e)
        {
            cdColorCommand.ShowDialog();
            Color c = cdColorCommand.Color;
            btnColorChange.Text = "#"+ChangeColorToHex(c);
            btnColorChange.BackColor = c;
        }
    }
}
