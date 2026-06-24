using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Faults
{
    public class CreateUpdateFaultDTO
    {
        [Required]
        public int EquipmentID { get; set; }

        [Required]
        public string FaultDescription { get; set; }

        [Required]
        public int PriorityID { get; set; }

        [Required]
        public int ReportedByUserID { get; set; }

        public int? AssignedToTechnicianID { get; set; }

        public string Notes { get; set; }
    }
}
