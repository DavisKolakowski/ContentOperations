namespace ContentOperations.MediaLibrary.Domain.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRepositoryWrapper
    {
        IStorageTypeRepository StorageType { get; }

        IStorageFolderRepository StorageFolder { get; }

        Task SaveAsync();
    }
}
