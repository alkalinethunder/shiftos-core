using System;

namespace ShiftOS
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var nucleus = new AlkalineThunder.Nucleus.GameLoop())
                nucleus.Run();
        }
    }
}
