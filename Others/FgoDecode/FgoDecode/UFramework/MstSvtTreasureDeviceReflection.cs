using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtTreasureDeviceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtTreasureDeviceReflection.descriptor;

		static MstSvtTreasureDeviceReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ch1tc3Rfc3Z0X3RyZWFzdXJlX2RldmljZS5wcm90bxIKdUZyYW1ld29yayKy",
				"AgoXTVNUX1NWVF9UUkVBU1VSRV9ERVZJQ0USDgoGc3Z0X2lkGAEgASgFEgsK",
				"A251bRgCIAEoBRIQCghwcmlvcml0eRgDIAEoBRITCgtpbWFnZV9pbmRleBgE",
				"IAEoBRIaChJ0cmVhc3VyZV9kZXZpY2VfaWQYBSABKAUSFQoNY29uZF9xdWVz",
				"dF9pZBgGIAEoBRIYChBjb25kX3F1ZXN0X3BoYXNlGAcgASgFEg8KB2NvbmRf",
				"bHYYCCABKAUSHAoUY29uZF9mcmllbmRzaGlwX3JhbmsYCSABKAUSDgoGbW90",
				"aW9uGAogASgFEg4KBmRhbWFnZRgLIAMoBRIPCgdjYXJkX2lkGAwgASgFEhIK",
				"CnVwZGF0ZWRfYXQYDSABKAQSEgoKY3JlYXRlZF9hdBgOIAEoBCJTCh1NU1Rf",
				"U1ZUX1RSRUFTVVJFX0RFVklDRV9BUlJBWRIyCgVpdGVtcxgBIAMoCzIjLnVG",
				"cmFtZXdvcmsuTVNUX1NWVF9UUkVBU1VSRV9ERVZJQ0ViBnByb3RvMw=="
			}));
			MstSvtTreasureDeviceReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_TREASURE_DEVICE), MST_SVT_TREASURE_DEVICE.Parser, new string[]
				{
					"SvtId",
					"Num",
					"Priority",
					"ImageIndex",
					"TreasureDeviceId",
					"CondQuestId",
					"CondQuestPhase",
					"CondLv",
					"CondFriendshipRank",
					"Motion",
					"Damage",
					"CardId",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_TREASURE_DEVICE_ARRAY), MST_SVT_TREASURE_DEVICE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
