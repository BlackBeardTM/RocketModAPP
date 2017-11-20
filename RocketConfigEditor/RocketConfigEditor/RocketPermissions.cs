using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RocketConfigEditor
{
    [Serializable]
    public class RocketPermissions
    {
        [XmlElement("DefaultGroupId")]
        public string DefaultGroupId;
        [XmlArray("Groups")]
        [XmlArrayItem(ElementName = "Group")]
        public RocketPermissionsGroup[] Groups;
    }
}
