using System;

namespace UnderstandOOP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            OsDiscriminator.DetermineType("MS Dos");
            Console.WriteLine(OsDiscriminator.BoxSpecifier.Statement);
        }
    }
}
