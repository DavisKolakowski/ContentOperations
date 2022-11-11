namespace ContentOperations.MediaLibrary.Application.Interfaces
{
    using ContentOperations.MediaLibrary.Application.DataTransferObjects;
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMediaStatusService
    {
        IEnumerable<StorageFolderDTO> GetStorageFoldersForLibrary(int storageTypeId);
    }
}
