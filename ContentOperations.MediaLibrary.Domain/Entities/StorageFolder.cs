namespace ContentOperations.MediaLibrary.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StorageFolder
    {
        public StorageFolder()
        {
            this.StorageType = new StorageType();
        }

        public int Id { get; set; }

        public int StorageTypeId { get; set; }

        public virtual StorageType StorageType { get; set; }

        public string? FolderTag { get; set; }

        public string FolderPath { get; set; }
    }
}
