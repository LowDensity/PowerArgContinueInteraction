using PowerArgs;
internal interface IContinousProgram
{
    bool Continue();

    Type NextProg();

    public void Main();
}