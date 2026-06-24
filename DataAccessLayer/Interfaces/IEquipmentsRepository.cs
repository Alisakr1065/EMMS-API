using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data.Interfaces
{
    public interface IEquipmentRepository
    {
        // Read
        Task<List<Equipment>> GetAllEquipmentsAsync();
        Task<Equipment> GetEquipmentByIdAsync(int id);

        // Create
        Task<int> AddEquipmentAsync(Equipment equipment);

        // Update
        Task<bool> UpdateEquipmentAsync(Equipment equipment);

        // Delete
        Task<bool> DeleteEquipmentAsync(int id);

        // Special
        Task<List<Equipment>> GetEquipmentByStatusAsync(int statusId);
    }
}
