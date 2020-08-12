namespace UnderstandOOP.Boxes
{
	public sealed class UNIXBox : IBoxSpecifier // Singleton Pattern
	{
		private static readonly UNIXBox Value = new UNIXBox();

		private UNIXBox()
		{
		}

		public string Statement => "This is a UNIX or UNIX like box and therefore is a good choice.";

		public static void Register()
		{
			OsDiscriminator.Register("SunOS", Value);
			OsDiscriminator.Register("Ubuntu Linux", Value);
			OsDiscriminator.Register("Fedora Linux", Value);
			OsDiscriminator.Register("Mint Linux", Value);
		}
	}
}