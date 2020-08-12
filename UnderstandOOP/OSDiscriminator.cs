using System.Collections;
using UnderstandOOP.Boxes;

namespace UnderstandOOP
{
	public static class OsDiscriminator // Factory Pattern
	{
		private static readonly Hashtable Storage = new Hashtable();

		public static IBoxSpecifier GetBoxSpecifier
		{
			get
			{
				var value = (IBoxSpecifier) Storage[OsType];
				return value ?? DefaultBox.Value;
			}
		}

		private static string OsType { get; set; }

		public static void DetermineType(string type)
		{
			OsType = type;
		}

		public static void Register(string key, IBoxSpecifier value)
		{
			Storage[key] = value; // Should guard against null keys, actually.
		}

		static OsDiscriminator()
		{
			WindowsBox.Register();
			UNIXBox.Register();
			MacBox.Register();
		}
	}
}