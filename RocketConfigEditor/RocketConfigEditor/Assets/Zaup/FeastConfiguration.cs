using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RocketConfigEditor.Plugins.Zaup
{
    [Serializable]
    public class FeastConfiguration
    {

        public bool Enabled;
        public int MinDropTime;
        public int MaxDropTime;
        public byte DropRadius;
        public byte MinItemsDrop;
        public byte MaxItemsDrop;
        public bool SkyDrop;
        public ushort PlaneEffectId;
        public ushort SkydropEffectId;
        public string MessageColor;
        [XmlArray("Items")]
        [XmlArrayItem(ElementName = "FeastItem")]
        public List<FeastItem> Items;
        public FeastConfiguration()
        {

        }
    }
}
