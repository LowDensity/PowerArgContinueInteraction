using PowerArgContinueInteraction;
using PowerArgs;

Type prog = typeof(Start);


for (IContinousProgram x = null!;
    x is null || x.Continue();
    prog = x!.NextProg()) 
{
    x = (IContinousProgram)Args.InvokeMain(prog ,args).Value;
}

