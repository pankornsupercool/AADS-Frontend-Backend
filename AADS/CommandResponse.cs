using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS
{
    public enum CommandResponseCode
    {
        Success, Warning, Error
    }
    public class CommandResponse
    {
        public CommandResponseCode Code;
        public string Message;
    }
}
