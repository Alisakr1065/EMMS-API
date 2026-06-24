using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Equipments
{
    public class EquipmentDetailsDTO
    {
        public int EquipmentId { get; set; }
        public string? EquipmentName { get; set; }
        public string? EquipmentCode { get; set; }

        public string? EquipmentType { get; set; }

        public string? Location { get; set; }
        public DateTime InstallationDate { get; set; }

        public string? Status { get; set; }

        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }

    }
}
