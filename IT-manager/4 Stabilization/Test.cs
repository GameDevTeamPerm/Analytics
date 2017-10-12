using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Test
    {
        public Test(string name, bool isImportant = true)
        {
            Name = name;
            IsImportatnt = isImportant; 
        }

        public string Name { get; set; }
        public bool IsImportatnt { get; set; }
    }
}
