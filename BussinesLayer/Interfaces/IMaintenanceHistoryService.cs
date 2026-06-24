using Business.DTOs.Maintanance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IMaintenanceHistoryService
    {
        Task<List<MaintenanceListDTO>> GetAllMaintenanceAsync();
        Task<MaintenanceListDTO> GetMaintenanceByIdAsync(int id);
        Task<MaintenanceListDTO> CreateMaintenanceAsync(CreateMaintenanceDTO dto);
        Task<List<MaintenanceListDTO>> GetMaintenanceByEquipmentAsync(int equipmentId);
    }
}
