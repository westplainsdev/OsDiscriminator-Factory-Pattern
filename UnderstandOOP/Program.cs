using System;

namespace UnderstandOOP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            OsDiscriminator.DetermineType("Windows 8.1");
            Console.WriteLine(OsDiscriminator.BoxSpecifier.Statement);
        }
    }
}
