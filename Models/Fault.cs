using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fault
    {
        public int FaultId { get; set; }
        public int EquipmentId { get; set; }
        public string FaultDescription { get; set; }
        public DateTime FaultDate { get; set; }
        public int PriorityId { get; set; }
        public int FaultStatusId { get; set; }
        public string FaultStatusName { get; set; }
    }
}
