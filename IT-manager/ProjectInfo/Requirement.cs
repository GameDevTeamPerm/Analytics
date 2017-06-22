using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Requirement
    {
        public Requirement(string name, string stakeholderName, bool isImportant = true)
        {
            Name = name;
            StakeholderName = stakeholderName;
            IsImportant = isImportant;

            MinimumSkill = 0;
            DetectionIterationNumber = 1;
            IsFound = false;

            SubRequirements = new List<Requirement>();
            SubModules = new List<Module>();
        }

        public Requirement(string name, string stakeholderName, int minimumSkill, int detectionIterationNumber, bool isImportant = true)
        {
            Name = name;
            StakeholderName = stakeholderName;
            MinimumSkill = minimumSkill;
            DetectionIterationNumber = detectionIterationNumber;
            IsImportant = isImportant;

            IsFound = false;

            SubRequirements = new List<Requirement>();
            SubModules = new List<Module>();
        }

        public Requirement AddSubRequirement(Requirement requirement)
        {
            requirement.MainRequirement = this;
            SubRequirements.Add(requirement);
            return requirement;
        }

        public Requirement AddSubRequirement(string name, string stakeholderName, bool isImportant = true)
        {
            Requirement requirement = new Requirement(name, stakeholderName, isImportant);
            requirement.MainRequirement = this;
            SubRequirements.Add(requirement);
            return requirement;
        }

        public Requirement AddSubRequirement(string name, string stakeholderName, int minimumSkill, int detectionIterationNumber, bool isImportant = true)
        {
            Requirement requirement = new Requirement(name, stakeholderName, minimumSkill, detectionIterationNumber, isImportant);
            requirement.MainRequirement = this;
            SubRequirements.Add(requirement);
            return requirement;
        }

        public Module AddSubModule(Module module)
        {
            module.Requirement = this;
            SubModules.Add(module);
            return module;
        }

        public Module AddSubModule(string name, int codeLinesCount, bool isImportant = true)
        {
            Module module = new Module(name, codeLinesCount, isImportant);
            module.Requirement = this;
            SubModules.Add(module);
            return module;
        }

        private void GetSubmodules(ref HashSet<Module> modules, Module module)
        {
            foreach (Module tempModule in module.SubModules)
            {
                modules.Add(tempModule);
                GetSubmodules(ref modules, tempModule);
            }
        }

        private void GetSubmodules(ref HashSet<Module> modules, Requirement requirement)
        {
            foreach (Module tempModule in requirement.SubModules)
            {
                modules.Add(tempModule);
                GetSubmodules(ref modules, tempModule);
            }

            foreach (Requirement tempRequirement in requirement.SubRequirements)
            {
                GetSubmodules(ref modules, tempRequirement);
            }
        }

        public override string ToString()
        {
            return string.Format(Name);
        }

        public string Name { get; set; }
        public string StakeholderName { get; set; }
        public bool IsImportant { get; set; }

        public int MinimumSkill { get; set; }
        public int DetectionIterationNumber { get; set; }
        public bool IsFound { get; set; }

        public List<Requirement> SubRequirements { get; set; }
        public List<Module> SubModules { get; set; }

        public Employee Employee { get; set; }
        public Requirement MainRequirement { get; set; }
        public List<Requirement> NotFoundSubRequirements
        {
            get
            {
                List<Requirement> reqs = new List<Requirement>();
                foreach (Requirement elem in SubRequirements)
                {
                    if (elem.Name != null && elem.IsFound == false)
                    {
                        reqs.Add(elem);
                    }
                }
                return reqs;
            }
        }
        public HashSet<Module> AllSubModules
        {
            get
            {
                HashSet<Module> modules = new HashSet<Module>();
                GetSubmodules(ref modules, this);
                return modules;
            }
        }
    }
}