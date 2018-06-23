using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstItemReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstItemReflection.descriptor;

		static MstItemReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3RfaXRlbS5wcm90bxIKdUZyYW1ld29yayKOAgoITVNUX0lURU0SCgoC",
				"aWQYASABKAUSDAoEbmFtZRgCIAEoDBIOCgZkZXRhaWwYAyABKAwSEAoIaW1h",
				"Z2VfaWQYBCABKAUSEwoLYmdfaW1hZ2VfaWQYBSABKAUSDAoEdHlwZRgGIAEo",
				"BRIMCgR1bml0GAcgASgMEg0KBXZhbHVlGAggASgFEg8KB3NlbGxfcXAYCSAB",
				"KAUSDwoHaXNfc2VsbBgKIAEoBRIQCghwcmlvcml0eRgLIAEoBRIVCg1kcm9w",
				"X3ByaW9yaXR5GAwgASgFEhUKDWluZGl2aWR1YWxpdHkYDSADKAUSEgoKc3Rh",
				"cnRlZF9hdBgOIAEoBBIQCghlbmRlZF9hdBgPIAEoBCI1Cg5NU1RfSVRFTV9B",
				"UlJBWRIjCgVpdGVtcxgBIAMoCzIULnVGcmFtZXdvcmsuTVNUX0lURU1iBnBy",
				"b3RvMw=="
			}));
			MstItemReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_ITEM), MST_ITEM.Parser, new string[]
				{
					"Id",
					"Name",
					"Detail",
					"ImageId",
					"BgImageId",
					"Type",
					"Unit",
					"Value",
					"SellQp",
					"IsSell",
					"Priority",
					"DropPriority",
					"Individuality",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_ITEM_ARRAY), MST_ITEM_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
