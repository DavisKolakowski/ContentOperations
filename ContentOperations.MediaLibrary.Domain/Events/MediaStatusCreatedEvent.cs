namespace ContentOperations.MediaLibrary.Domain.Events
{
    using ContentOperations.Domain.Core.Events;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MediaStatusCreatedEvent : Event
    {
        public int From { get; private set; }

        public string FileName { get; private set; }

        public MediaStatusCreatedEvent(int from, string fileName)
        {
            this.From = from;
            this.FileName = fileName;
        }
    }
}
