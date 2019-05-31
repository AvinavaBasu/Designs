using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            ICommand command = invoker.GetCommand("Start");
            command.Execute();

            command = invoker.GetCommand("Stop");
            command.Execute();
            Console.WriteLine("Command Pattern demo");
            Console.Read();
        }
    }
}
