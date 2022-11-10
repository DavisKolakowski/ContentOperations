namespace ContentOperations.MediaLibrary.Domain.Commands
{
    using ContentOperations.Domain.Core.Commands;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class FileStatusCommand : Command
    {
        public int From { get; protected set; }

        public string FileName { get; protected set; }
    }
}
