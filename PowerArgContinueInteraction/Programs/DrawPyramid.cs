using PowerArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerArgContinueInteraction.Programs
{
    
    public class DrawPyramid : IContinousProgram
    {
        public bool Continue() => true;
        public Type NextProg()
        {
            return typeof(Start);
        }
        [PromptIfEmpty]
        [ArgRequired]
        [ArgDescription("要用來繪製圖形的符號。")]
        public char unit { get; set; }
        [PromptIfEmpty]
        [ArgRequired]
        [ArgDescription("要繪製多少層。")]
        [ArgRange(1, 20)]
        public int level { get; set; }

        bool hasNext =true;

        public DrawPyramid() {
            Console.WriteLine("繪製金字塔，參數： ");
            Console.WriteLine("unit : 要繪製的符號");
            Console.WriteLine("level : 1~20 ，要繪製多少層。");
        }

        public void Main()
        {
            int curLevel = 1;
            while (curLevel <= level)
            {
                Console.Write(curLevel.ToString("0000"));
                int startPos = level - curLevel;
                for (int wsCount = 0; wsCount <= startPos; wsCount++) Console.Write(" ");
                for (int pos = 0, starCount = 0; starCount < curLevel; pos++)
                {
                    if (pos % 2 != 0)
                    {
                        starCount++;
                        Console.Write(unit);
                    }
                    else { Console.Write(" "); }
                }
                Console.WriteLine();
                curLevel++;
            }
        }
    }
}
