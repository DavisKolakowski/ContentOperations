namespace ContentOperations.MediaLibrary.Data
{
    using ContentOperations.MediaLibrary.Domain.Entities;

    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaLibraryContext : DbContext
    {
        public MediaLibraryContext()
            : base()
        {

        }

        public MediaLibraryContext(DbContextOptions<MediaLibraryContext> options)
            : base(options)
        {

        }

        public DbSet<StorageType> StorageTypes { get; set; }

        public DbSet<StorageFolder> StorageFolders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
        
        }
    }
}
