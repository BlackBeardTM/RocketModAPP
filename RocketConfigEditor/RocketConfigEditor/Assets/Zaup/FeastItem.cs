using System.Collections.Generic;
using System.Xml.Serialization;

namespace RocketConfigEditor.Plugins.Zaup
{
    public class FeastItem
    {
        public ushort Id;
        public string Name;
        public byte Chance;
        [XmlArray(ElementName = "Locations")]
        public List<string> Location;

        public FeastItem(ushort id, string name, byte chance, List<string> locs)
        {
            this.Id = id;
            this.Name = name;
            this.Chance = chance;
            this.Location = locs;
        }

        public FeastItem()
        {
        }
    }
}
