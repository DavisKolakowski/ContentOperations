namespace ContentOperations.MediaLibrary.Domain.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CreateFileStatusCommand : FileStatusCommand
    {
        public CreateFileStatusCommand(int from, string fileName) 
        { 
            this.From = from;
            this.FileName = fileName;
        }
    }
}
