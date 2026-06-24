using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Equipments
{
    public class CreateUpdateEquipmentDTO
    {
        [Required(ErrorMessage = "Equipment name is required")]
        public string EquipmentName { get; set; }

        public string EquipmentCode { get; set; }

        [Required]
        public int EquipmentTypeId { get; set; }



        [Required]
        public int EquipmentStatusId { get; set; }
        public string Location { get; set; }

        public DateTime InstallationDate { get; set; }
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string SerialNumber { get; set; }
    }
}
