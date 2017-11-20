using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketConfigEditor
{
    class AppConfig
    {
        private string dirPath;
        private string hostName;
        private bool encrType;
        private bool isLocal;
        private string user;
        private string password;
        private string _port;

        public string _Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public bool IsLocal
        {
            get { return isLocal; }
            set { isLocal = value; }
        }

        public bool EncrType
        {
            get { return encrType; }
            set { encrType = value; }
        }

        public string HostName
        {
            get { return hostName; }
            set { hostName = value; }
        }

        public string DirPath
        {
            get { return dirPath; }
            set { dirPath = value; }
        }
        public AppConfig(string hostName,string path,bool isLocal,string _port,string user,string password,bool encrType)
        {
            this.hostName = hostName;
            this.dirPath = path;
            this.password = password;
            this.user = user;
            this._port = _port;
            this.isLocal = isLocal;
            this.encrType = encrType;
        }
    }
}
