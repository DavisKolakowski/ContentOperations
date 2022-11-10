namespace ContentOperations.MediaLibrary.Domain.Interfaces
{
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IStorageTypeRepository : IRepositoryBase<StorageType>
    {
        Task<IEnumerable<StorageType>> GetAllStorageTypes();

        Task<StorageType> GetStorageTypeById(int id);

        Task<IEnumerable<StorageFolder>> GetFoldersForStorageType(StorageType storageType);

        void CreateStorageType(StorageType storageType);

        void UpdateStorageType(StorageType storageType);

        void DeleteStorageType(StorageType storageType);
    }
}
