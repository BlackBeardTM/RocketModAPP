using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RocketConfigEditor
{
    [Serializable]
    public class RocketPermissionsGroup
    {
        [XmlElement("Id")]
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [XmlElement("DisplayName")]
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        [XmlElement("Color")]
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        [XmlArray("Members")]
        [XmlArrayItem(ElementName = "Member")]
        private List<string> members;

        public List<string> Members
        {
            get { return members; }
            set { members = value; }
        }

        [XmlArray("Permissions")]
        [XmlArrayItem(ElementName = "Permission")]
        public List<Permission> permission;
        [XmlArray("ParentGroups")]
        [XmlArrayItem(ElementName = "ParentGroup")]
        public List<string> ParentGroups;

        public RocketPermissionsGroup()
        {
        }

        public RocketPermissionsGroup(string id, string displayName,string color, List<string> parentGroups, List<string> members, List<Permission> permission)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Color = color;
            this.Members = members;
            this.permission = permission;
            this.ParentGroups = parentGroups;
        }
    }
}
//[XmlElement("Id")]
//public string Id;
//[XmlElement("DisplayName")]
//public string DisplayName;
//[XmlElement("Color")]
//public string Color;
//[XmlArray("Members")]
//[XmlArrayItem(ElementName = "Member")]
//public List<string> Members;
//[XmlArray("Permissions")]
//[XmlArrayItem(ElementName = "Permission")]
//public List<Permission> permission;
//[XmlArray("ParentGroups")]
//[XmlArrayItem(ElementName = "ParentGroup")]
//public List<string> ParentGroups;