using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IFaultRepository
    {
        Task<List<Fault>> GetAllFaultsAsync();
        Task<Fault> GetFaultByIdAsync(int id);

        Task<int> AddFaultAsync(Fault fault);

        Task<bool> UpdateFaultAsync(Fault fault);

        Task<bool> UpdateFaultStatusAsync(int faultId, int newStatusId);

        Task<List<Fault>> GetFaultsByEquipmentAsync(int equipmentId);
        Task<List<Fault>> GetFaultsByStatusAsync(int statusId);
    }
}
