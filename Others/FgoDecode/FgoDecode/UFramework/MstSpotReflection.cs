using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSpotReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSpotReflection.descriptor;

		static MstSpotReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3Rfc3BvdC5wcm90bxIKdUZyYW1ld29yayLFAwoITVNUX1NQT1QSCgoC",
				"aWQYASABKAUSDgoGd2FyX2lkGAIgASgFEgwKBG5hbWUYAyABKAwSEAoIaW1h",
				"Z2VfaWQYBCABKAUSCQoBeBgFIAEoBRIJCgF5GAYgASgFEhMKC2ltYWdlX29m",
				"c194GAcgASgFEhMKC2ltYWdlX29mc195GAggASgFEhIKCm5hbWVfb2ZzX3gY",
				"CSABKAUSEgoKbmFtZV9vZnNfeRgKIAEoBRITCgtxdWVzdF9vZnNfeBgLIAEo",
				"BRITCgtxdWVzdF9vZnNfeRgMIAEoBRIXCg9kaXNwX2NvbmRfdHlwZTEYDSAB",
				"KAUSFwoPZGlzcF90YXJnZXRfaWQxGA4gASgFEhoKEmRpc3BfdGFyZ2V0X3Zh",
				"bHVlMRgPIAEoBRIXCg9kaXNwX2NvbmRfdHlwZTIYECABKAUSFwoPZGlzcF90",
				"YXJnZXRfaWQyGBEgASgFEhoKEmRpc3BfdGFyZ2V0X3ZhbHVlMhgSIAEoBRIY",
				"ChBhY3RpdmVfY29uZF90eXBlGBMgASgFEhgKEGFjdGl2ZV90YXJnZXRfaWQY",
				"FCABKAUSGwoTYWN0aXZlX3RhcmdldF92YWx1ZRgVIAEoBSI1Cg5NU1RfU1BP",
				"VF9BUlJBWRIjCgVpdGVtcxgBIAMoCzIULnVGcmFtZXdvcmsuTVNUX1NQT1Ri",
				"BnByb3RvMw=="
			}));
			MstSpotReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SPOT), MST_SPOT.Parser, new string[]
				{
					"Id",
					"WarId",
					"Name",
					"ImageId",
					"X",
					"Y",
					"ImageOfsX",
					"ImageOfsY",
					"NameOfsX",
					"NameOfsY",
					"QuestOfsX",
					"QuestOfsY",
					"DispCondType1",
					"DispTargetId1",
					"DispTargetValue1",
					"DispCondType2",
					"DispTargetId2",
					"DispTargetValue2",
					"ActiveCondType",
					"ActiveTargetId",
					"ActiveTargetValue"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SPOT_ARRAY), MST_SPOT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
