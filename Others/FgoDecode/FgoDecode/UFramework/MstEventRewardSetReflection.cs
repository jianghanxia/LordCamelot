using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventRewardSetReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventRewardSetReflection.descriptor;

		static MstEventRewardSetReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chptc3RfZXZlbnRfcmV3YXJkX3NldC5wcm90bxIKdUZyYW1ld29yayJ8ChRN",
				"U1RfRVZFTlRfUkVXQVJEX1NFVBIXCg9yZXdhcmRfc2V0X3R5cGUYASABKAUS",
				"EAoIZXZlbnRfaWQYAiABKAUSCgoCaWQYAyABKAUSDwoHaWNvbl9pZBgEIAEo",
				"BRIMCgRuYW1lGAUgASgMEg4KBmRldGFpbBgGIAEoDCJNChpNU1RfRVZFTlRf",
				"UkVXQVJEX1NFVF9BUlJBWRIvCgVpdGVtcxgBIAMoCzIgLnVGcmFtZXdvcmsu",
				"TVNUX0VWRU5UX1JFV0FSRF9TRVRiBnByb3RvMw=="
			}));
			MstEventRewardSetReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_REWARD_SET), MST_EVENT_REWARD_SET.Parser, new string[]
				{
					"RewardSetType",
					"EventId",
					"Id",
					"IconId",
					"Name",
					"Detail"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_REWARD_SET_ARRAY), MST_EVENT_REWARD_SET_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
