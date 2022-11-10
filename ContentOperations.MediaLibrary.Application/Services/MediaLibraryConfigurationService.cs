namespace ContentOperations.MediaLibrary.Application.Services
{
    using AutoMapper;

    using ContentOperations.MediaLibrary.Application.Interfaces;
    using ContentOperations.MediaLibrary.Application.Mapper.DataTransferObjects;
    using ContentOperations.MediaLibrary.Domain.Entities;
    using ContentOperations.MediaLibrary.Domain.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaLibraryConfigurationService : IMediaLibraryConfigurationService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _wrapper;

        public MediaLibraryConfigurationService(IMapper mapper, IRepositoryWrapper wrapper)
        {
            this._mapper = mapper;
            this._wrapper = wrapper;
        }

        IEnumerable<StorageTypeDTO> IMediaLibraryConfigurationService.GetStorageTypeFolders()
        {
            var data = this._wrapper.StorageType.GetAllStorageTypes().Result;
            var dto = this._mapper.Map<IEnumerable<StorageTypeDTO>>(data);

            return dto;
        }
    }
}
