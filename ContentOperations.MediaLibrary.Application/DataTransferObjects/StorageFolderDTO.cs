namespace ContentOperations.MediaLibrary.Application.DataTransferObjects
{
    using ContentOperations.MediaLibrary.Domain.Entities;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StorageFolderDTO
    {
        public int Id { get; set; }

        public string FolderPath { get; set; }
    }
}
