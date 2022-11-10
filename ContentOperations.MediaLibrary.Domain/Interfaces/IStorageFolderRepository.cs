namespace ContentOperations.MediaLibrary.Domain.Interfaces
{
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IStorageFolderRepository : IRepositoryBase<StorageFolder>
    {
        Task<IEnumerable<StorageFolder>> GetAllStorageFolders();

        Task<StorageFolder> GetStorageFolderById(int id);
    }
}
