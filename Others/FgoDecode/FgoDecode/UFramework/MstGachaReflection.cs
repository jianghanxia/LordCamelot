using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGachaReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGachaReflection.descriptor;

		static MstGachaReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3RfZ2FjaGEucHJvdG8SCnVGcmFtZXdvcmsiuQUKCU1TVF9HQUNIQRIK",
				"CgJpZBgBIAEoBRIMCgRuYW1lGAIgASgMEhAKCGltYWdlX2lkGAMgASgFEhAK",
				"CHByaW9yaXR5GAQgASgFEg4KBndhcl9pZBgFIAEoBRISCgpnYWNoYV9zbG90",
				"GAYgASgFEgwKBHR5cGUYByABKAUSEAoIc2hvcF9pZDEYCCABKAUSEAoIc2hv",
				"cF9pZDIYCSABKAUSEQoJcmFyaXR5X2lkGAogASgFEg8KB2Jhc2VfaWQYCyAB",
				"KAUSEQoJYWRqdXN0X2lkGAwgASgFEhEKCXBpY2t1cF9pZBgNIAEoBRIWCg50",
				"aWNrZXRfaXRlbV9pZBgOIAEoBRIWCg5nYWNoYV9ncm91cF9pZBgPIAEoBRIR",
				"CglkcmF3X251bTEYECABKAUSEQoJZHJhd19udW0yGBEgASgFEhwKFGdhY2hh",
				"X3Byb2JhYmlsaXR5X2lkGBIgASgFEhYKDmZyZWVfZHJhd19mbGFnGBMgASgF",
				"EhQKDG1heF9kcmF3X251bRgUIAEoBRIXCg9iZWZvcmVfZ2FjaGFfaWQYFSAB",
				"KAUSFwoPYmVmb3JlX2RyYXdfbnVtGBYgASgFEhgKEHBpY2t1cF9vcGVuZWRf",
				"YXQYFyABKAQSGAoQcGlja3VwX2Nsb3NlZF9hdBgYIAEoBBIRCglvcGVuZWRf",
				"YXQYGSABKAQSEQoJY2xvc2VkX2F0GBogASgEEhUKDWNvbmRfcXVlc3RfaWQY",
				"GyABKAUSGAoQY29uZF9xdWVzdF9waGFzZRgcIAEoBRISCgpkZXRhaWxfdXJs",
				"GB0gASgMEhcKD2Jhbm5lcl9xdWVzdF9pZBgeIAEoBRIaChJiYW5uZXJfcXVl",
				"c3RfcGhhc2UYHyABKAUSEgoKdXBkYXRlZF9hdBggIAEoBBISCgpjcmVhdGVk",
				"X2F0GCEgASgEIjcKD01TVF9HQUNIQV9BUlJBWRIkCgVpdGVtcxgBIAMoCzIV",
				"LnVGcmFtZXdvcmsuTVNUX0dBQ0hBYgZwcm90bzM="
			}));
			MstGachaReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GACHA), MST_GACHA.Parser, new string[]
				{
					"Id",
					"Name",
					"ImageId",
					"Priority",
					"WarId",
					"GachaSlot",
					"Type",
					"ShopId1",
					"ShopId2",
					"RarityId",
					"BaseId",
					"AdjustId",
					"PickupId",
					"TicketItemId",
					"GachaGroupId",
					"DrawNum1",
					"DrawNum2",
					"GachaProbabilityId",
					"FreeDrawFlag",
					"MaxDrawNum",
					"BeforeGachaId",
					"BeforeDrawNum",
					"PickupOpenedAt",
					"PickupClosedAt",
					"OpenedAt",
					"ClosedAt",
					"CondQuestId",
					"CondQuestPhase",
					"DetailUrl",
					"BannerQuestId",
					"BannerQuestPhase",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GACHA_ARRAY), MST_GACHA_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
