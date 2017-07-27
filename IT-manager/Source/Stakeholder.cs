using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Stakeholder
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsMain { get; set; }

        public Stakeholder(string name, string type, bool isMain = true)
        {
            Name = name;
            Type = type;
            IsMain = isMain;
        }

        public override string ToString()
        {
            return string.Format(Name);
        }
    }
}
