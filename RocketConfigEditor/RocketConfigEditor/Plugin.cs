using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RocketConfigEditor
{
    class Plugin
    {
        private string name;
        private string configFile;
        private bool enabled;

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public string ConfigFile
        {
            get { return configFile; }
            set { configFile = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Plugin()
        {

        }
        public Plugin(string name,string configFile,bool enabled)
        {
            this.configFile = configFile;
            this.name = name;
            this.enabled = enabled;
        }
        public override string ToString()
        {
            return string.Format("{0}",name); 
        }

    }
}
