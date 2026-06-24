using Data.Interfaces;
using Models;

namespace Data.Repositories
{
    public class FaultsRepository : IFaultRepository
    {
        private readonly string _connectionString;
        public FaultsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task<int> AddFaultAsync(Fault fault)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fault>> GetAllFaultsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Fault> GetFaultByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fault>> GetFaultsByEquipmentAsync(int equipmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Fault>> GetFaultsByStatusAsync(int statusId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFaultAsync(Fault fault)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFaultStatusAsync(int faultId, int newStatusId)
        {
            throw new NotImplementedException();
        }
    }
}
