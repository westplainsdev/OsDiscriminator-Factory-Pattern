using System;

namespace UnderstandOOP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            OsDiscriminator.DetermineType(Options.OperatingSystem["MINT"]);
            Console.WriteLine(OsDiscriminator.GetBoxSpecifier.Statement);
        }
    }
}