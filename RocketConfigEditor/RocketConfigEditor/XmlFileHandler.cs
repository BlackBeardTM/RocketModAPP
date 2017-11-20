using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using RocketConfigEditor.Plugins.Zaup;
using System.Reflection;

namespace RocketConfigEditor
{
    class XmlFileHandler
    {
        private static readonly string Dir = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp";
        private static readonly string pluginsDir = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp\\Plugins\\";
        private static List<Plugin> Plugins = ConfigHandler.GetPluginList();
        public static RocketPermissions GetRocketPerm()
        {
            RocketPermissions perm = DefaultSerialization.deserialize(new RocketPermissions(), Dir + "\\Permissions.config.xml");
            return perm;
        }
        
        public static void UpdateRocketPerm(RocketPermissions rocketPermissions, string elementType, string element, string grp,uint cool)
        {
            bool testElement = false;
            if (elementType == "Permission" || elementType == "Color")
            {
                foreach (var item in rocketPermissions.Groups)
                {
                    if (grp == item.DisplayName.ToString())
                    {
                        if (elementType == "Color")
                        {
                            foreach (Permission com in item.permission)
                            {
                                
                                    if (com.Name.IndexOf('.') > 0)
                                    {
                                        if (com.Name.Substring(0, com.Name.IndexOf('.')) == "color")
                                        {
                                            item.permission.Add(new Permission(element,(UInt32)0));
                                            item.permission.Remove(com);
                                            testElement = true;
                                        }
                                        if (testElement)
                                        {
                                            break;
                                        }
                                    
                                }
                                
                            }
                        }
                        else if (elementType == "Permission")
                        {
                            foreach (Permission com in item.permission)
                            {
                                if (com.Name == element)
                                {
                                    item.permission.Add(new Permission(element,(uint)cool));
                                    item.permission.Remove(com);
                                    testElement = true;

                                }
                                if (testElement)
                                {
                                    break;
                                }

                            }
                            if (!testElement)
                            {
                                item.permission.Add(new Permission(element,(uint)cool));
                            }
                        }
                    }
                }
            }
            else if(true)//memeber
            {

            }
        }

        public static ICollection<Assembly> LoadPlugins()
        {
            string[] dllFileNames = null;
            if (Directory.Exists(pluginsDir))
            {
                dllFileNames = Directory.GetFiles(pluginsDir, "*.dll");
            }

            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }
            return assemblies;
        }
    }
}


