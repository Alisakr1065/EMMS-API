using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Maintanance
{
    public class CreateMaintenanceDTO
    {
        public int? FaultID { get; set; }

        [Required]
        public int TechnicianID { get; set; }

        [Required]
        public DateTime ActionTaken { get; set; }

        [Required]
        public DateTime RepairDate { get; set; }

        public string Notes { get; set; }
    }

}
