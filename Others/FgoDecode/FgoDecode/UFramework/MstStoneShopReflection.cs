using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstStoneShopReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstStoneShopReflection.descriptor;

		static MstStoneShopReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3Rfc3RvbmVfc2hvcC5wcm90bxIKdUZyYW1ld29yayJhCg5NU1RfU1RP",
				"TkVfU0hPUBIKCgJpZBgBIAEoBRIOCgZlZmZlY3QYAiABKAUSDQoFcHJpY2UY",
				"AyABKAUSEQoJb3BlbmVkX2F0GAQgASgEEhEKCWNsb3NlZF9hdBgFIAEoBCJB",
				"ChRNU1RfU1RPTkVfU0hPUF9BUlJBWRIpCgVpdGVtcxgBIAMoCzIaLnVGcmFt",
				"ZXdvcmsuTVNUX1NUT05FX1NIT1BiBnByb3RvMw=="
			}));
			MstStoneShopReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_STONE_SHOP), MST_STONE_SHOP.Parser, new string[]
				{
					"Id",
					"Effect",
					"Price",
					"OpenedAt",
					"ClosedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_STONE_SHOP_ARRAY), MST_STONE_SHOP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
