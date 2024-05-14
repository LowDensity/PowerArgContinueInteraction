using PowerArgContinueInteraction.Programs;
using PowerArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerArgContinueInteraction
{
    [TabCompletion]
    public class Start : IContinousProgram
    {
        public bool Continue() => true;

        public Type NextProg()
        {
                switch (ProgramToRun) {
                    case "DrawPyramid":
                        return typeof(DrawPyramid);
                    case "DrawTriangle":
                        return typeof(DrawTriangle);
                    case "RandomNumber":
                        return typeof(RandomNumber);
                    case "End":
                        return typeof(End);
                    default:
                        throw new ArgumentException($"未知的程式：{ProgramToRun}");

            }
        }

        public Start() {
            Console.WriteLine("請輸入要執行的指令 -ProgramToRun ");
            Console.WriteLine("有以下選項：DrawPyramid,DrawTriangle,RandomNumber ");
        }


        [ArgRequired]
        [ArgDescription("要執行哪些程式，有以下選項：DrawPyramid,DrawTriangle,RandomNumber，或輸入End不執行任何動作並離開程式。")]
        [ArgRegex("DrawPyramid|DrawTriangle|RandomNumber|End")]
        public string ProgramToRun { get; set; } = "";

        
        public void Main()
        {
            Console.WriteLine($"指定={ProgramToRun}");
            
        }
    }
}
