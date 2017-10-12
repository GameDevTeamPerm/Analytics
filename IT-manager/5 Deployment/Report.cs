using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Report
    {
        public Report()
        {
            Module = null;
            Error = null;
        }

        public Report(Module module, Error error)
        {
            Module = module;
            Error = error;
        }

        public Module Module { get; set; }
        public Error Error { get; set; }
    }
}
