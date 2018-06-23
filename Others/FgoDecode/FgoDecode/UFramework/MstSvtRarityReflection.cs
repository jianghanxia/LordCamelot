using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtRarityReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtRarityReflection.descriptor;

		static MstSvtRarityReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3Rfc3Z0X3Jhcml0eS5wcm90bxIKdUZyYW1ld29yayJpCg5NU1RfU1ZU",
				"X1JBUklUWRIOCgZyYXJpdHkYASABKAUSFQoNaHBfYWRqdXN0X21heBgCIAEo",
				"BRIWCg5hdGtfYWRqdXN0X21heBgDIAEoBRIYChBzdnRfYW5vbnltb3VzX2lk",
				"GAQgASgFIkEKFE1TVF9TVlRfUkFSSVRZX0FSUkFZEikKBWl0ZW1zGAEgAygL",
				"MhoudUZyYW1ld29yay5NU1RfU1ZUX1JBUklUWWIGcHJvdG8z"
			}));
			MstSvtRarityReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_RARITY), MST_SVT_RARITY.Parser, new string[]
				{
					"Rarity",
					"HpAdjustMax",
					"AtkAdjustMax",
					"SvtAnonymousId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_RARITY_ARRAY), MST_SVT_RARITY_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
