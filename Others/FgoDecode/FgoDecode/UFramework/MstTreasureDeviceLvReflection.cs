using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstTreasureDeviceLvReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstTreasureDeviceLvReflection.descriptor;

		static MstTreasureDeviceLvReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chxtc3RfdHJlYXN1cmVfZGV2aWNlX2x2LnByb3RvEgp1RnJhbWV3b3JrIu8C",
				"ChZNU1RfVFJFQVNVUkVfREVWSUNFX0xWEhkKEXRyZWF1cmVfZGV2aWNlX2lk",
				"GAEgASgFEgoKAmx2GAIgASgFEhMKC2dhdWdlX2NvdW50GAMgASgFEg8KB2Z1",
				"bmNfaWQYBCADKAUSDAoEdmFscxgFIAMoDBINCgV2YWxzMhgGIAMoDBINCgV2",
				"YWxzMxgHIAMoDBINCgV2YWxzNBgIIAMoDBINCgV2YWxzNRgJIAMoDBIRCglk",
				"ZXRhaWxfaWQYCiABKAUSEAoIdGRfcG9pbnQYCyABKAUSEgoKdGRfcG9pbnRf",
				"cRgMIAEoBRISCgp0ZF9wb2ludF9hGA0gASgFEhIKCnRkX3BvaW50X2IYDiAB",
				"KAUSEwoLdGRfcG9pbnRfZXgYDyABKAUSFAoMdGRfcG9pbnRfZGVmGBAgASgF",
				"EgoKAnFwGBEgASgFEhIKCnVwZGF0ZWRfYXQYEiABKAQSEgoKY3JlYXRlZF9h",
				"dBgTIAEoBCJRChxNU1RfVFJFQVNVUkVfREVWSUNFX0xWX0FSUkFZEjEKBWl0",
				"ZW1zGAEgAygLMiIudUZyYW1ld29yay5NU1RfVFJFQVNVUkVfREVWSUNFX0xW",
				"YgZwcm90bzM="
			}));
			MstTreasureDeviceLvReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_TREASURE_DEVICE_LV), MST_TREASURE_DEVICE_LV.Parser, new string[]
				{
					"TreaureDeviceId",
					"Lv",
					"GaugeCount",
					"FuncId",
					"Vals",
					"Vals2",
					"Vals3",
					"Vals4",
					"Vals5",
					"DetailId",
					"TdPoint",
					"TdPointQ",
					"TdPointA",
					"TdPointB",
					"TdPointEx",
					"TdPointDef",
					"Qp",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_TREASURE_DEVICE_LV_ARRAY), MST_TREASURE_DEVICE_LV_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
