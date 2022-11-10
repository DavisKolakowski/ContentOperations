namespace ContentOperations.MediaLibrary.Application.Mapper
{
    using AutoMapper;
    using ContentOperations.MediaLibrary.Application.DataTransferObjects;
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StorageType, StorageTypeDTO>()
                .ForMember(dto => dto.StorageFolderIds, opt =>
                    opt.MapFrom(src => src.StorageFolders.Select(src => src.Id)));

            CreateMap<StorageFolder, StorageFolderDTO>();
        }
    }
}
