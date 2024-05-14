using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerArgContinueInteraction
{
    internal class End : IContinousProgram
    {
        public bool Continue() => false;

        public Type NextProg()
        {
            return null!;
        }

        public void Main()
        {
            Console.WriteLine("Nothing To do , press enter to quit");
            Console.ReadLine();
        }
    }
}
