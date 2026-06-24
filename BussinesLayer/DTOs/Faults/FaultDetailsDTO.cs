using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Faults
{
    public class FaultDetailsDTO
    {
        public int FaultID { get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string FaultDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int PriorityID { get; set; }
        public string PriorityName { get; set; }
        public int PriorityLevel { get; set; }
        public int ReportedByUserID { get; set; }
        public string ReportedByUserName { get; set; }
        public int StatusID { get; set; }
        public string Status { get; set; }
        public int? AssignedToTechnicianID { get; set; }
        public string AssignedToTechnicianName { get; set; }
        public string Notes { get; set; }
    }
}
