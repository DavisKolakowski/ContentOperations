namespace ContentOperations.MediaLibrary.Application.Services
{
    using AutoMapper;

    using ContentOperations.Domain.Core.Bus;
    using ContentOperations.MediaLibrary.Application.DataTransferObjects;
    using ContentOperations.MediaLibrary.Application.Interfaces;
    using ContentOperations.MediaLibrary.Domain.Commands;
    using ContentOperations.MediaLibrary.Domain.Entities;
    using ContentOperations.MediaLibrary.Domain.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaStatusService : IMediaStatusService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _wrapper;
        private readonly IEventBus _bus;

        public MediaStatusService(IMapper mapper, IRepositoryWrapper wrapper, IEventBus bus)
        {
            this._mapper = mapper;
            this._wrapper = wrapper;
            this._bus = bus;
        }

        public IEnumerable<StorageFolderDTO> GetStorageFoldersForLibrary(int storageTypeId)
        {
            var data = this._wrapper.StorageFolder.GetFoldersForStorageType(storageTypeId).Result;
            var dto = this._mapper.Map<IEnumerable<StorageFolderDTO>>(data);

            return dto;
        }
    }
}
