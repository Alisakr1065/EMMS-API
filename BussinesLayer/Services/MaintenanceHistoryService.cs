using Business.DTOs.Maintanance;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class MaintenanceHistoryService : IMaintenanceHistoryService
    {
        public Task<MaintenanceListDTO> CreateMaintenanceAsync(CreateMaintenanceDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<MaintenanceListDTO>> GetAllMaintenanceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<MaintenanceListDTO>> GetMaintenanceByEquipmentAsync(int equipmentId)
        {
            throw new NotImplementedException();
        }

        public Task<MaintenanceListDTO> GetMaintenanceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
