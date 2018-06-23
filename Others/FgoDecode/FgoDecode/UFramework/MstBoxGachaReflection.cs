using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBoxGachaReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBoxGachaReflection.descriptor;

		static MstBoxGachaReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3RfYm94X2dhY2hhLnByb3RvEgp1RnJhbWV3b3JrIrACCg1NU1RfQk9Y",
				"X0dBQ0hBEgoKAmlkGAEgASgFEhAKCGV2ZW50X2lkGAIgASgFEhAKCGJhc2Vf",
				"aWRzGAMgAygFEhIKCnBpY2t1cF9pZHMYBCABKAUSEAoIdGFsa19pZHMYBSAD",
				"KAUSEAoIcGF5X3R5cGUYBiABKAUSFQoNcGF5X3RhcmdldF9pZBgHIAEoBRIR",
				"CglwYXlfdmFsdWUYCCABKAUSEgoKZGV0YWlsX3VybBgJIAEoDBIWCg5ndWlk",
				"ZV9pbWFnZV9pZBgKIAEoBRIZChFndWlkZV9saW1pdF9jb3VudBgLIAEoBRIQ",
				"Cghwcmlvcml0eRgMIAEoBRIMCgRmbGFnGA0gASgFEhIKCnVwZGF0ZWRfYXQY",
				"DiABKAQSEgoKY3JlYXRlZF9hdBgPIAEoBCI/ChNNU1RfQk9YX0dBQ0hBX0FS",
				"UkFZEigKBWl0ZW1zGAEgAygLMhkudUZyYW1ld29yay5NU1RfQk9YX0dBQ0hB",
				"YgZwcm90bzM="
			}));
			MstBoxGachaReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA), MST_BOX_GACHA.Parser, new string[]
				{
					"Id",
					"EventId",
					"BaseIds",
					"PickupIds",
					"TalkIds",
					"PayType",
					"PayTargetId",
					"PayValue",
					"DetailUrl",
					"GuideImageId",
					"GuideLimitCount",
					"Priority",
					"Flag",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_ARRAY), MST_BOX_GACHA_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
