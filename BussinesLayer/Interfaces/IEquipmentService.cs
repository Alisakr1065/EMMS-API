using Business.DTOs.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEquipmentService
    {
        // Read
        Task<List<EquipmentListDTO>> GetAllEquipmentsAsync();
        Task<EquipmentDetailsDTO> GetEquipmentByIdAsync(int id);

        // Create
        Task<EquipmentDetailsDTO> AddEquipmentAsync(CreateUpdateEquipmentDTO dto);

        // Update
        Task<EquipmentDetailsDTO> UpdateEquipmentAsync(int id, CreateUpdateEquipmentDTO dto);

        // Delete
        Task<bool> DeleteEquipmentAsync(int id);

        // Special
        Task<List<EquipmentListDTO>> GetEquipmentByStatusAsync(int statusId);
    }
}
