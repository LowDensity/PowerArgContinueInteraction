using PowerArgs;
using System.Runtime.CompilerServices;

namespace PowerArgContinueInteraction.Programs
{
    public class DrawTriangle : IContinousProgram
    {

        public bool Continue() => true;
        public Type NextProg()
        {
            return typeof(Start);
        }

        [ArgRequired]
        [ArgDescription("要用來繪製圖形的符號。")]
        [PromptIfEmpty]
        public char unit { get; set; }
        [ArgRequired]
        [ArgDescription("要繪製多少層。")]
        [ArgRange(1,20)]
        [PromptIfEmpty]
        public int level { get; set; }

        
        public void Main()
        {
            int curLevel = 1;
            while (curLevel <= level)
            {
                Console.Write(curLevel.ToString("0000") + "    ");
                for (int i = 0; i < curLevel; i++) { Console.Write(unit); }
                curLevel++;
                Console.WriteLine();
            }
        }
    }
}
