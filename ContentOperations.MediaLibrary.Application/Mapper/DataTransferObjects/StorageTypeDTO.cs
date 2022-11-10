namespace ContentOperations.MediaLibrary.Application.Mapper.DataTransferObjects
{
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StorageTypeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public string? Description { get; set; }

        public List<string> StorageFolderPaths { get; set; }
    }
}
