using AutoMapper;
using Business.DTOs.Equipments;
using Business.Interfaces;
using Data.Interfaces;
namespace Business.Services
{
    public class EquipmentsService : IEquipmentService
    {

        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IMapper _mapper;
        public EquipmentsService(IEquipmentRepository equipmentRepository, IMapper mapper)
        {
            _equipmentRepository = equipmentRepository;
            _mapper = mapper;
        }

        public async Task<EquipmentDetailsDTO> AddEquipmentAsync(CreateUpdateEquipmentDTO dto)
        {
            var equipmentEntity = _mapper.Map<Models.Equipment>(dto);

            int newEquipmentId = await _equipmentRepository.AddEquipmentAsync(equipmentEntity);

            if(newEquipmentId <= 0)
            {
                throw new InvalidOperationException("Failed to create equipment.");
            }

            return await GetEquipmentByIdAsync(newEquipmentId);
        }

        public async Task<bool> DeleteEquipmentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EquipmentListDTO>> GetAllEquipmentsAsync()
        {
            var result = await _equipmentRepository.GetAllEquipmentsAsync();
            
            if(result.Count  > 0)
            {
                return _mapper.Map<List<EquipmentListDTO>>(result);
            }

            throw new NotImplementedException();
        }

        public async Task<EquipmentDetailsDTO> GetEquipmentByIdAsync(int id)
        {
            var result = await _equipmentRepository.GetEquipmentByIdAsync(id);

            if(result != null)
                return _mapper.Map<EquipmentDetailsDTO>(result);

            throw new NotImplementedException();
        }

        public async Task<List<EquipmentListDTO>> GetEquipmentByStatusAsync(int statusId)
        {
            throw new NotImplementedException();
        }

        public async Task<EquipmentDetailsDTO> UpdateEquipmentAsync(int id, CreateUpdateEquipmentDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
