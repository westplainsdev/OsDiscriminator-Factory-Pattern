namespace UnderstandOOP
{

	public sealed class DefaultBox : IBoxSpecifier // Singleton Pattern
	{
		public static readonly DefaultBox Value = new DefaultBox();

		private DefaultBox()
		{
		}

		public string Statement => "This is a bare metal box. No OS exists here.";
	}
}