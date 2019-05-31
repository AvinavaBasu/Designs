using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdPatternSample
{
  public  class StartCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("I am executing StartCommand");
        }

        public string Name
        {
            get { return "Start"; }
        }
    }
}
