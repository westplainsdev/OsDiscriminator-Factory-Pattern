namespace UnderstandOOP
{
	public sealed class WindowsBox : IBoxSpecifier // Singleton Pattern
	{
		private static readonly WindowsBox Value = new WindowsBox();

		private WindowsBox()
		{
		}

		public string Statement => "This is a Windows box and therefore is a fair choice.";

		public static void Register()
		{
			OsDiscriminator.Register("Windows 7", Value);
			OsDiscriminator.Register("Windows 8.1", Value);
			OsDiscriminator.Register("Windows 10", Value);
		}
	}
}