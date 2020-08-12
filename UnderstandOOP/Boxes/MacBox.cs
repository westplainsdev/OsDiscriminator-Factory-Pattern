namespace UnderstandOOP.Boxes
{
	public sealed class MacBox : IBoxSpecifier // Singleton Pattern
	{
		private static readonly MacBox Value = new MacBox();

		private MacBox()
		{
		}

		public string Statement => "This is a Macintosh box and therefore is a far superior choice.";

		public static void Register()
		{
			OsDiscriminator.Register("Mac OS", Value);
		}
	}
}