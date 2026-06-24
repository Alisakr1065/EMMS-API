using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DTOs.Faults;

namespace Business.Interfaces
{
    public interface IFaultService
    {
        Task<List<FaultListDTO>> GetAllFaultsAsync();
        Task<FaultDetailsDTO> GetFaultByIdAsync(int id);
        Task<FaultDetailsDTO> CreateFaultAsync(CreateUpdateFaultDTO dto);
        Task<FaultDetailsDTO> UpdateFaultStatusAsync(int faultId, int statusId);
        Task<List<FaultListDTO>> GetFaultsByEquipmentAsync(int equipmentId);
    }

}
