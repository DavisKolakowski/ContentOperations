namespace ContentOperations.MediaLibrary.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StorageType
    {
        public StorageType()
        {
            this.StorageFolders = new HashSet<StorageFolder>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual IEnumerable<StorageFolder> StorageFolders { get; set; }
    }
}
