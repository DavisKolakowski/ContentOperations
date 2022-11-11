namespace ContentOperations.MediaLibrary.Domain.EventHandlers
{
    using ContentOperations.Domain.Core.Bus;
    using ContentOperations.MediaLibrary.Domain.Events;
    using ContentOperations.MediaLibrary.Domain.Interfaces;

    using Serilog;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaStatusEventHandler : IEventHandler<MediaStatusCreatedEvent>
    {
        private readonly IRepositoryWrapper _repo;
        private readonly ILogger _logger;

        public MediaStatusEventHandler(IRepositoryWrapper repo, ILogger logger) 
        {
            this._repo = repo;
            this._logger = logger;
        }
        public Task Handle(MediaStatusCreatedEvent @event)
        {
            var folders = this._repo.StorageFolder.GetFoldersForStorageType(@event.From).Result;
            foreach(var folder in folders )
            {
                var dir = new DirectoryInfo(folder.FolderPath);
                var fileFullPath = Path.Combine(dir.FullName, @event.FileName);
                var found = File.Exists(fileFullPath);

                if (found)
                {
                    this._logger.Information("{0} found in {1}", @event.FileName, dir);
                }
                else
                {
                    this._logger.Information("{0} not found in {1}", @event.FileName, dir);
                }
            }
            return Task.CompletedTask;
        }
    }
}
