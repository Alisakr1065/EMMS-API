using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IMaintenanceHistoryRepository
    {
        Task<List<MaintenanceHistory>> GetAllMaintenanceAsync();
        Task<MaintenanceHistory> GetMaintenanceByIdAsync(int id);
        Task<int> AddMaintenanceAsync(MaintenanceHistory maintenance);
        Task<List<MaintenanceHistory>> GetMaintenanceByEquipmentAsync(int equipmentId);
        Task<List<MaintenanceHistory>> GetMaintenanceByFaultAsync(int faultId);
    }
}
