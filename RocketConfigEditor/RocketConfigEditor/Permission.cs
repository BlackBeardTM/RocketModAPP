using System;
using System.Xml.Serialization;

namespace RocketConfigEditor
{
    [Serializable]
    public class Permission
    {
        [XmlText]
        public string Name = string.Empty;
        [XmlAttribute]
        public uint Cooldown;
        public Permission()
        {
        }

        public Permission(string name, uint cooldown = 0U)
        {
            this.Name = name;
            this.Cooldown = cooldown;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
