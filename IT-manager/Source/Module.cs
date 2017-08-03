using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Module
    {
        public string Name { get; set; }
        public int CodeLinesNumber { get; set; }
        public bool IsImportant { get; set; }

        public bool IsDeveloped { get; set; }
        public Module MainModule { get; set; }

        public Requirement Requirement
        {
            get
            {
                if (MainModule != null)
                    return MainModule.Requirement;
                else return selfRequirement;
            }
            set
            {
                selfRequirement = value;
            }
        }
        private Requirement selfRequirement { get; set; }

        public List<Module> SubModules { get; set; }

        public List<Test> Tests { get; set; }
        public List<Error> Errors { get; set; }

        public Employee Developer { get; set; }
        public Employee Tester { get; set; }

        public Module(string name, int codeLinesNumber, bool isImportant = true)
        {
            Name = name;
            CodeLinesNumber = codeLinesNumber;
            IsImportant = isImportant;

            IsDeveloped = false;
            Requirement = null;
            
            SubModules = new List<Module>();
            Tests = new List<Test>();
            Errors = new List<Error>();
        }

        public Module AddSubModule(Module module)
        {
            module.MainModule = this;
            SubModules.Add(module);
            return module;
        }
        public Module AddSubModule(string name, int codeLinesNumber, bool isImportant = true)
        {
            Module module = new Module(name, codeLinesNumber, isImportant);
            module.MainModule = this;
            SubModules.Add(module);
            return module;
        }

        public override string ToString()
        {
            return string.Format(Name);
        }
    }
}

