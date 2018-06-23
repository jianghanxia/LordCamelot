using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstTreasureDeviceDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstTreasureDeviceDetailReflection.descriptor;

		static MstTreasureDeviceDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiBtc3RfdHJlYXN1cmVfZGV2aWNlX2RldGFpbC5wcm90bxIKdUZyYW1ld29y",
				"ayJ2ChpNU1RfVFJFQVNVUkVfREVWSUNFX0RFVEFJTBIKCgJpZBgBIAEoBRIO",
				"CgZkZXRhaWwYAiABKAwSFAoMZGV0YWlsX3Nob3J0GAMgASgMEhIKCnVwZGF0",
				"ZWRfYXQYBCABKAQSEgoKY3JlYXRlZF9hdBgFIAEoBCJZCiBNU1RfVFJFQVNV",
				"UkVfREVWSUNFX0RFVEFJTF9BUlJBWRI1CgVpdGVtcxgBIAMoCzImLnVGcmFt",
				"ZXdvcmsuTVNUX1RSRUFTVVJFX0RFVklDRV9ERVRBSUxiBnByb3RvMw=="
			}));
			MstTreasureDeviceDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_TREASURE_DEVICE_DETAIL), MST_TREASURE_DEVICE_DETAIL.Parser, new string[]
				{
					"Id",
					"Detail",
					"DetailShort",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_TREASURE_DEVICE_DETAIL_ARRAY), MST_TREASURE_DEVICE_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
