namespace ContentOperations.MediaLibrary.Domain.CommandHandlers
{
    using ContentOperations.Domain.Core.Bus;
    using ContentOperations.MediaLibrary.Domain.Commands;
    using ContentOperations.MediaLibrary.Domain.Events;

    using MediatR;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class MediaStatusCommandHandler : IRequestHandler<CreateMediaStatusCommand, bool>
    {
        private readonly IEventBus _bus;

        public MediaStatusCommandHandler(IEventBus bus)
        {
            this._bus = bus;
        }

        public Task<bool> Handle(CreateMediaStatusCommand request, CancellationToken cancellationToken)
        {
            //Publish event to RabbitMQ
            this._bus.Publish(new MediaStatusCreatedEvent(request.From, request.FileName));
            return Task.FromResult(true);
        }
    }
}
