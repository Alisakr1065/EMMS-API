using Business.DTOs.Faults;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class FaultsService : IFaultService
    {
        public Task<FaultDetailsDTO> CreateFaultAsync(CreateUpdateFaultDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<FaultListDTO>> GetAllFaultsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FaultDetailsDTO> GetFaultByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FaultListDTO>> GetFaultsByEquipmentAsync(int equipmentId)
        {
            throw new NotImplementedException();
        }

        public Task<FaultDetailsDTO> UpdateFaultStatusAsync(int faultId, int statusId)
        {
            throw new NotImplementedException();
        }
    }
}
