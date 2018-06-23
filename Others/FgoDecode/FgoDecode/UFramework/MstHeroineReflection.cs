using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstHeroineReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstHeroineReflection.descriptor;

		static MstHeroineReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChFtc3RfaGVyb2luZS5wcm90bxIKdUZyYW1ld29yayLyAQoLTVNUX0hFUk9J",
				"TkUSEAoIcXVlc3RfaWQYASABKAUSDQoFcGhhc2UYAiABKAUSDgoGc3Z0X2lk",
				"GAMgASgFEhIKCmZyaWVuZHNoaXAYBCABKAUSFwoPZnJpZW5kc2hpcF9yYW5r",
				"GAUgASgFEhMKC2xpbWl0X2NvdW50GAYgASgFEg8KB2lzX2RlYWQYByABKAUS",
				"GwoTdHJlYXN1cmVfZGV2aWNlX251bRgIIAEoBRIaChJ0cmVhc3VyZV9kZXZp",
				"Y2VfbHYYCSABKAUSEgoKdXBkYXRlZF9hdBgKIAEoBBISCgpjcmVhdGVkX2F0",
				"GAsgASgEIjsKEU1TVF9IRVJPSU5FX0FSUkFZEiYKBWl0ZW1zGAEgAygLMhcu",
				"dUZyYW1ld29yay5NU1RfSEVST0lORWIGcHJvdG8z"
			}));
			MstHeroineReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_HEROINE), MST_HEROINE.Parser, new string[]
				{
					"QuestId",
					"Phase",
					"SvtId",
					"Friendship",
					"FriendshipRank",
					"LimitCount",
					"IsDead",
					"TreasureDeviceNum",
					"TreasureDeviceLv",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_HEROINE_ARRAY), MST_HEROINE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
