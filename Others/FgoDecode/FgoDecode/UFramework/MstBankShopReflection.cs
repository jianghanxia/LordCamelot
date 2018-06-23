using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBankShopReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBankShopReflection.descriptor;

		static MstBankShopReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3RfYmFua19zaG9wLnByb3RvEgp1RnJhbWV3b3JrIocDCg1NU1RfQkFO",
				"S19TSE9QEgoKAmlkGAEgASgFEhUKDWFwcGxlX3Nob3BfaWQYAiABKAwSFgoO",
				"Z29vZ2xlX3Nob3BfaWQYAyABKAwSEwoLYXBwbGVfcHJpY2UYBCABKAUSFAoM",
				"Z29vZ2xlX3ByaWNlGAUgASgFEgwKBG5hbWUYBiABKAwSGAoQY2hhcmdlX3N0",
				"b25lX251bRgHIAEoBRIWCg5mcmVlX3N0b25lX251bRgIIAEoBRISCgpudW1f",
				"ZGV0YWlsGAkgASgMEhQKDHByaWNlX2RldGFpbBgKIAEoDBIRCglvcGVuZWRf",
				"YXQYCyABKAQSEQoJY2xvc2VkX2F0GAwgASgEEhwKFGdldF9jaGFyZ2Vfc3Rv",
				"bmVfbnVtGA0gASgFEhoKEmdldF9mcmVlX3N0b25lX251bRgOIAEoBRIYChBn",
				"ZXRfcHJpY2VfZGV0YWlsGA8gASgMEhYKDmdldF9udW1fZGV0YWlsGBAgASgM",
				"EhQKDGZpcnN0X3BheV9pZBgRIAEoBSI/ChNNU1RfQkFOS19TSE9QX0FSUkFZ",
				"EigKBWl0ZW1zGAEgAygLMhkudUZyYW1ld29yay5NU1RfQkFOS19TSE9QYgZw",
				"cm90bzM="
			}));
			MstBankShopReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BANK_SHOP), MST_BANK_SHOP.Parser, new string[]
				{
					"Id",
					"AppleShopId",
					"GoogleShopId",
					"ApplePrice",
					"GooglePrice",
					"Name",
					"ChargeStoneNum",
					"FreeStoneNum",
					"NumDetail",
					"PriceDetail",
					"OpenedAt",
					"ClosedAt",
					"GetChargeStoneNum",
					"GetFreeStoneNum",
					"GetPriceDetail",
					"GetNumDetail",
					"FirstPayId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BANK_SHOP_ARRAY), MST_BANK_SHOP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
