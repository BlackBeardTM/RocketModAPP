using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rceAssets
{
    public interface IRcePlugin
    {
        //plugin configuration File name MyPlugin.Configuration.xml
        string ConfigFileFullname { get; }
        //plugin name MyPlugin
        string Name { get; }
        //leave it on true this is like a failsafe for the FTP connection.
        bool enabled { get; }
        //full path-name to form eg. MyPlugin.Form1
        string FormFullName { get; }

    }
}
