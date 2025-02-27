﻿using AutoMapper;
using SmartTestTaskKozitski.BLL.DTOs;
using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.BLL.Mapping
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Contract, GetContractsDto>()
                .ForMember(cdto => cdto.ProductionFacilityName,
                r => r.MapFrom(x => x.ProductionFacility.Specifications.Name))
                .ForMember(cdto => cdto.ProcessEquipmentTypeName,
                r => r.MapFrom(x => x.ProcessEquipmentType.Specifications.Name))
                .ForMember(cdto => cdto.Quantity,
                r => r.MapFrom(x => x.Quantity));

            CreateMap<AddContractDto, Contract>()
                .ForMember(c => c.ProductionFacility,
                r => r.MapFrom(x => new ProductionFacility()
                {
                    Specifications = new Specifications() { Code = x.FacilityCode }
                }))
                .ForMember(c => c.ProcessEquipmentType,
                r => r.MapFrom(x => new ProcessEquipmentType() 
                { 
                    Specifications = new Specifications() { Code = x.ProcessEquipmentTypeCode } 
                }))
                .ForMember(c => c.Quantity,
                r => r.MapFrom(x => x.Quantity));
        }
    }
}
