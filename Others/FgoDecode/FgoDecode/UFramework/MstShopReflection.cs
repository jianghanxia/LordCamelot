using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstShopReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstShopReflection.descriptor;

		static MstShopReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3Rfc2hvcC5wcm90bxIKdUZyYW1ld29yayLlAgoITVNUX1NIT1ASCgoC",
				"aWQYASABKAUSFAoMYmFzZV9zaG9wX2lkGAIgASgFEhAKCGV2ZW50X2lkGAMg",
				"ASgFEgwKBGZsYWcYBCABKAUSEAoIcHJpb3JpdHkYBSABKAUSFQoNcHVyY2hh",
				"c2VfdHlwZRgGIAEoBRISCgp0YXJnZXRfaWRzGAcgAygFEg8KB3NldF9udW0Y",
				"CCABKAUSEAoIcGF5X3R5cGUYCSABKAUSEAoIaXRlbV9pZHMYCiADKAUSDgoG",
				"cHJpY2VzGAsgAygFEhEKCWxpbWl0X251bRgMIAEoBRIMCgRuYW1lGA0gASgM",
				"Eg4KBmRldGFpbBgOIAEoDBIXCg93YXJuaW5nX21lc3NhZ2UYDyABKAwSEAoI",
				"aW1hZ2VfaWQYECABKAUSEwoLYmdfaW1hZ2VfaWQYESABKAUSEQoJb3BlbmVk",
				"X2F0GBIgASgEEhEKCWNsb3NlZF9hdBgTIAEoBCI1Cg5NU1RfU0hPUF9BUlJB",
				"WRIjCgVpdGVtcxgBIAMoCzIULnVGcmFtZXdvcmsuTVNUX1NIT1BiBnByb3Rv",
				"Mw=="
			}));
			MstShopReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SHOP), MST_SHOP.Parser, new string[]
				{
					"Id",
					"BaseShopId",
					"EventId",
					"Flag",
					"Priority",
					"PurchaseType",
					"TargetIds",
					"SetNum",
					"PayType",
					"ItemIds",
					"Prices",
					"LimitNum",
					"Name",
					"Detail",
					"WarningMessage",
					"ImageId",
					"BgImageId",
					"OpenedAt",
					"ClosedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SHOP_ARRAY), MST_SHOP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
