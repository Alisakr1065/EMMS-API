using AutoMapper;
using Business.DTOs.Equipments;
using Business.DTOs.Faults;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Equipment Mappings
            CreateMap<Equipment, EquipmentListDTO>().ReverseMap();

            CreateMap<Equipment, EquipmentDetailsDTO>().ReverseMap();

            CreateMap<CreateUpdateEquipmentDTO, Equipment>().ReverseMap();

            // Fault Mappings
            CreateMap<Fault, FaultListDTO>()
                .ForMember(dest => dest.Status, opt =>
                    opt.MapFrom(src => src.FaultStatusName)).ReverseMap();

            CreateMap<Fault, FaultDetailsDTO>()
                .ForMember(dest => dest.Status, opt =>
                    opt.MapFrom(src => src.FaultStatusName)).ReverseMap();

            CreateMap<CreateUpdateFaultDTO, Fault>().ReverseMap();
        }
    }
}
