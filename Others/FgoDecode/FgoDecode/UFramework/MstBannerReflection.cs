using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBannerReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBannerReflection.descriptor;

		static MstBannerReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChBtc3RfYmFubmVyLnByb3RvEgp1RnJhbWV3b3JrIvEBCgpNU1RfQkFOTkVS",
				"EgoKAmlkGAEgASgFEhEKCWJhbm5lcl9pZBgCIAEoBRIXCg9iYW5uZXJfcHJp",
				"b3JpdHkYAyABKAUSIAoYdGVybWluYWxfYmFubmVyX3ByaW9yaXR5GAQgASgF",
				"EhEKCW5vdGljZV9hdBgFIAEoBBITCgtmaW5pc2hlZF9hdBgGIAEoBBIRCgls",
				"aW5rX3R5cGUYByABKAUSEQoJbGlua19ib2R5GAggASgMEhMKC2RldmljZV90",
				"eXBlGAkgASgFEhIKCnVwZGF0ZWRfYXQYCiABKAQSEgoKY3JlYXRlZF9hdBgL",
				"IAEoBCI5ChBNU1RfQkFOTkVSX0FSUkFZEiUKBWl0ZW1zGAEgAygLMhYudUZy",
				"YW1ld29yay5NU1RfQkFOTkVSYgZwcm90bzM="
			}));
			MstBannerReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BANNER), MST_BANNER.Parser, new string[]
				{
					"Id",
					"BannerId",
					"BannerPriority",
					"TerminalBannerPriority",
					"NoticeAt",
					"FinishedAt",
					"LinkType",
					"LinkBody",
					"DeviceType",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BANNER_ARRAY), MST_BANNER_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
