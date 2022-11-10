namespace ContentOperations.MediaLibrary.Application.Interfaces
{
    using ContentOperations.MediaLibrary.Application.Mapper.DataTransferObjects;
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMediaLibraryConfigurationService
    {
        IEnumerable<StorageTypeDTO> GetStorageTypeFolders();
    }
}
