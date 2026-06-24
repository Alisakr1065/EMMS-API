using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Equipments
{
    public class EquipmentListDTO
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentType { get; set; }
        public string Status { get; set; }
    }
}
