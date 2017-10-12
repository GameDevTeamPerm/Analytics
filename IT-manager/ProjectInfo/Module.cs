using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Module
    {
        public Module(string name, int codeLinesNumber, bool isImportant = true)
        {
            Name = name;
            CodeLinesNumber = codeLinesNumber;
            IsImportant = isImportant;

            IsDeveloped = false;
            Requirement = null;

            Errors = new List<Error>();
            SubModules = new List<Module>();
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

        public string Name { get; set; }
        public int CodeLinesNumber { get; set; }
        public bool IsImportant { get; set; }

        public bool IsDeveloped { get; set; }
        public bool IsFound
        {
            get
            {
                if (Requirement != null)
                    return Requirement.IsFound;
                else return false;
            }
        }

        public Employee Employee
        {
            get
            {
                if (Requirement != null)
                    return Requirement.Employee;
                else return null;
            }
        }
        public Module MainModule { get; set; } 
        // TODO: Непонятно зачем здесь два требования (Requirement, requirement). requirement вообще не используется
        public Requirement Requirement
        {
            get
            {
                if (MainModule != null)
                    return MainModule.Requirement;
                else return requirement;
            }
            set
            {
                requirement = value;
            }
        }
        private Requirement requirement { get; set; }

        public List<Module> SubModules { get; set; }
        public List<Error> Errors { get; set; }
    }
}

