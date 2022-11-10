namespace ContentOperations.MediaLibrary.Data.Repositories
{
    using ContentOperations.MediaLibrary.Domain.Entities;
    using ContentOperations.MediaLibrary.Domain.Interfaces;
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StorageFolderRepository : RepositoryBase<StorageFolder>, IStorageFolderRepository
    {
        public StorageFolderRepository(MediaLibraryContext dbContext)
            : base(dbContext)
        {

        }

        public async Task<IEnumerable<StorageFolder>> GetAllStorageFolders()
        {
            return await FindAll()
                    .OrderBy(sf => sf.Id)
                .ToListAsync();
        }

        public async Task<StorageFolder> GetStorageFolderById(int id)
        {
            return await FindBy(sf => sf.Id == id)
                .FirstAsync();
        }
    }
}
