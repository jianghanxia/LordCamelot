using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventRewardReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventRewardReflection.descriptor;

		static MstEventRewardReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZtc3RfZXZlbnRfcmV3YXJkLnByb3RvEgp1RnJhbWV3b3JrIpYBChBNU1Rf",
				"RVZFTlRfUkVXQVJEEhAKCGV2ZW50X2lkGAEgASgFEg0KBXBvaW50GAIgASgF",
				"EgwKBHR5cGUYAyABKAUSDwoHZ2lmdF9pZBgEIAEoBRIaChJwcmVzZW50X21l",
				"c3NhZ2VfaWQYBSABKAUSEgoKdXBkYXRlZF9hdBgGIAEoBBISCgpjcmVhdGVk",
				"X2F0GAcgASgEIkUKFk1TVF9FVkVOVF9SRVdBUkRfQVJSQVkSKwoFaXRlbXMY",
				"ASADKAsyHC51RnJhbWV3b3JrLk1TVF9FVkVOVF9SRVdBUkRiBnByb3RvMw=="
			}));
			MstEventRewardReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_REWARD), MST_EVENT_REWARD.Parser, new string[]
				{
					"EventId",
					"Point",
					"Type",
					"GiftId",
					"PresentMessageId",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_REWARD_ARRAY), MST_EVENT_REWARD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
