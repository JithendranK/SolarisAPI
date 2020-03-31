using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Int16 Phase { get; set; }
        public string ProtocolID { get; set; }
        public Program Program { get; set; }
        public Status Status { get; set; }
        public Indication Indication { get; set; }
        public ProjectTimeUnit ProjectTimeUnit {get; set; }
        public Currency Currency { get; set; }

    }
}
