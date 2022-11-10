namespace ContentOperations.Domain.Core.Events
{
    using MediatR;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message() 
        { 
            this.MessageType = GetType().Name;
        }
    }
}
