namespace ContentOperations.MediaLibrary.Data.Repositories
{
    using ContentOperations.MediaLibrary.Data;
    using ContentOperations.MediaLibrary.Domain.Entities;
    using ContentOperations.MediaLibrary.Domain.Interfaces;

    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StorageTypeRepository : RepositoryBase<StorageType>, IStorageTypeRepository
    {
        public StorageTypeRepository(MediaLibraryContext dbContext)
            : base(dbContext)
        {

        }

        public async Task<IEnumerable<StorageType>> GetAllStorageTypes()
        {
            return await FindAll()
                .Include(st => st.StorageFolders)
                    .OrderBy(st => st.Id)
                .ToListAsync();
        }

        public async Task<StorageType> GetStorageTypeById(int id)
        {
            return await FindBy(st => st.Id == id)
                .FirstAsync();
        }
        public async Task<IEnumerable<StorageFolder>> GetFoldersForStorageType(StorageType storageType)
        {
            return await FindBy(st => st == storageType)
                .Include(st => st.StorageFolders)
                    .SelectMany(st => st.StorageFolders)
                .ToListAsync();
        }

        public void CreateStorageType(StorageType storageType)
        {
            Create(storageType);
        }

        public void UpdateStorageType(StorageType storageType)
        {
            Update(storageType);
        }

        public void DeleteStorageType(StorageType storageType)
        {
            Delete(storageType);
        }
    }
}
