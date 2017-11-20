using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketConfigEditor
{
    class Item
    {
        private string iD;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Item(string id,string name)
        {
            this.iD = id;
            this.name = name;
        }
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
