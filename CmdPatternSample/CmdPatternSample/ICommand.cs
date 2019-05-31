using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdPatternSample
{
   public interface ICommand
    {
        string Name { get; }
        void Execute();
    }
}
