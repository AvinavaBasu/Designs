using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdPatternSample
{
    public class StopCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("I am executing StopCommand");
        }

        public string Name
        {
            get { return "Stop"; }
        }
    }
}
