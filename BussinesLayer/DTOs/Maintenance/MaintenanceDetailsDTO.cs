using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Maintanance
{
    public class MaintenanceDetailsDTO
    {
        public int HistoryID { get; set; }
        public int? FaultID { get; set; }
        public string FaultDescription { get; set; }
        public int TechnicianID { get; set; }
        public string TechnicianName { get; set; }
        public DateTime ActionTaken { get; set; }
        public DateTime RepairDate { get; set; }
        public string Notes { get; set; }
        public int StatusID { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
