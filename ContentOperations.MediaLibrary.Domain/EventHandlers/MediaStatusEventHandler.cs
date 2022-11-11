namespace ContentOperations.MediaLibrary.Domain.EventHandlers
{
    using ContentOperations.Domain.Core.Bus;
    using ContentOperations.MediaLibrary.Domain.Events;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaStatusEventHandler : IEventHandler<MediaStatusCreatedEvent>
    {
        public MediaStatusEventHandler() 
        {

        }
        public Task Handle(MediaStatusCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
