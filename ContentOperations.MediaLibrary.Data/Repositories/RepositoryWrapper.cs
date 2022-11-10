namespace ContentOperations.MediaLibrary.Data.Repositories
{
    using ContentOperations.MediaLibrary.Domain.Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MediaLibraryContext _dbContext;

        private IStorageTypeRepository _storageType;

        private IStorageFolderRepository _storageFolder;

        public RepositoryWrapper(MediaLibraryContext dbContext)
        {
            this._dbContext = dbContext;
            this._storageType = this.StorageType;
            this._storageFolder = this.StorageFolder;
        }

        public IStorageTypeRepository StorageType
        {
            get
            {
                if (this._storageType == null)
                {
                    this._storageType = new StorageTypeRepository(this._dbContext);
                }
                return this._storageType;
            }
        }

        public IStorageFolderRepository StorageFolder
        {
            get
            {
                if (this._storageFolder == null)
                {
                    this._storageFolder = new StorageFolderRepository(this._dbContext);
                }
                return this._storageFolder;
            }
        }

        public async Task SaveAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}
