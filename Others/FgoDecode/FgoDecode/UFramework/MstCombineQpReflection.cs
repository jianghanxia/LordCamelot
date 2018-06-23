using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCombineQpReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCombineQpReflection.descriptor;

		static MstCombineQpReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3RfY29tYmluZV9xcC5wcm90bxIKdUZyYW1ld29yayJgCg5NU1RfQ09N",
				"QklORV9RUBIOCgZyYXJpdHkYASABKAUSCgoCbHYYAiABKAUSCgoCcXAYAyAB",
				"KAUSEgoKdXBkYXRlZF9hdBgEIAEoBBISCgpjcmVhdGVkX2F0GAUgASgEIkEK",
				"FE1TVF9DT01CSU5FX1FQX0FSUkFZEikKBWl0ZW1zGAEgAygLMhoudUZyYW1l",
				"d29yay5NU1RfQ09NQklORV9RUGIGcHJvdG8z"
			}));
			MstCombineQpReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_QP), MST_COMBINE_QP.Parser, new string[]
				{
					"Rarity",
					"Lv",
					"Qp",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_QP_ARRAY), MST_COMBINE_QP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
