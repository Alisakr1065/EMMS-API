using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MaintenanceHistory
    {
        public int MaintenanceId { get; set; }
        public int EquipmentId { get; set; }
        public int FaultId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string MaintenanceNotes { get; set; }
        public int MaintenanceStatusId { get; set; }
    }
}
