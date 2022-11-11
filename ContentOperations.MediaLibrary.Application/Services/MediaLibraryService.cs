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

    public class MediaLibraryService : IMediaLibraryService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _wrapper;
        private readonly IEventBus _bus;

        public MediaLibraryService(IMapper mapper, IRepositoryWrapper wrapper, IEventBus bus)
        {
            this._mapper = mapper;
            this._wrapper = wrapper;
            this._bus = bus;
        }

        public IEnumerable<StorageTypeDTO> GetStorageTypes()
        {
            var data = this._wrapper.StorageType.GetAllStorageTypes().Result;
            var dto = this._mapper.Map<IEnumerable<StorageTypeDTO>>(data);

            return dto;
        }

        public void GetMediaFileStatus(MediaStatusDTO fileStatus)
        {
            var createMediaStatusCommand = new CreateMediaStatusCommand(
                    fileStatus.FromStorage,
                fileStatus.FileName
                );

            _bus.SendCommand(createMediaStatusCommand);
        }
    }
}
