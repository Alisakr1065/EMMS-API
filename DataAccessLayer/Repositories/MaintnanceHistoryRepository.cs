using Data.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MaintnanceHistoryRepository : IMaintenanceHistoryRepository
    {
        private readonly string _connectionString;
        public MaintnanceHistoryRepository(string connectionString) 
        {
            _connectionString = connectionString;
        }
        public Task<int> AddMaintenanceAsync(MaintenanceHistory maintenance)
        {
            throw new NotImplementedException();
        }

        public Task<List<MaintenanceHistory>> GetAllMaintenanceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<MaintenanceHistory>> GetMaintenanceByEquipmentAsync(int equipmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<MaintenanceHistory>> GetMaintenanceByFaultAsync(int faultId)
        {
            throw new NotImplementedException();
        }

        public Task<MaintenanceHistory> GetMaintenanceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
