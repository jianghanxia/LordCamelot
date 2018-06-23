using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEffectReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEffectReflection.descriptor;

		static MstEffectReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChBtc3RfZWZmZWN0LnByb3RvEgp1RnJhbWV3b3JrIqMBCgpNU1RfRUZGRUNU",
				"EgoKAmlkGAEgASgFEgwKBG5hbWUYAiABKAwSCgoCc2UYAyABKAwSEgoKZGVs",
				"YXlfdGltZRgEIAEoBRITCgtmb2xkZXJfdHlwZRgFIAEoBRILCgNudW0YBiAB",
				"KAUSEQoJbm9kZV9uYW1lGAcgASgMEhIKCnVwZGF0ZWRfYXQYCCABKAQSEgoK",
				"Y3JlYXRlZF9hdBgJIAEoBCI5ChBNU1RfRUZGRUNUX0FSUkFZEiUKBWl0ZW1z",
				"GAEgAygLMhYudUZyYW1ld29yay5NU1RfRUZGRUNUYgZwcm90bzM="
			}));
			MstEffectReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EFFECT), MST_EFFECT.Parser, new string[]
				{
					"Id",
					"Name",
					"Se",
					"DelayTime",
					"FolderType",
					"Num",
					"NodeName",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EFFECT_ARRAY), MST_EFFECT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
