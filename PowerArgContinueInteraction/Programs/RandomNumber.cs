using PowerArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerArgContinueInteraction.Programs
{
    public class RandomNumber : IContinousProgram
    {

        public bool Continue() => true;
        public Type NextProg (){
            return typeof(Start); 
        }


        [ArgRequired]
        [ArgRange(1,int.MaxValue)]
        [ArgDescription("隨機數字範圍的上限。")]
        [PromptIfEmpty]
        public int upper { get; set; }

        public RandomNumber() {
            Console.WriteLine("顯示0~輸入的數字範圍中隨機一個數字。 參數：upper=範圍的最大值");
        
        }   


        public void Main()
        {
            Console.WriteLine("隨機數字："+Random.Shared.Next(upper).ToString());

        }
    }
}
