using System;

namespace UnderstandOOP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            OsDiscriminator.DetermineType(OperatingSystems.Options["WINDOWS10"]);
            Console.WriteLine(OsDiscriminator.GetBoxSpecifier.Statement);
        }
    }
}