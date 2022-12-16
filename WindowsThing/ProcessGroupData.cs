using System.Collections.Generic;

namespace WindowsThing
{
    internal class ProcessGroupData
    {
        public string DescriptiveName => $"{Name} ({Processes.Count})";
        public string Name { get; set; }
        public List<ProcessData> Processes { get; set; }
    }
}
