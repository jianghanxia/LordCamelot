using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventRewardBgReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventRewardBgReflection.descriptor;

		static MstEventRewardBgReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chltc3RfZXZlbnRfcmV3YXJkX2JnLnByb3RvEgp1RnJhbWV3b3JrIo8BChNN",
				"U1RfRVZFTlRfUkVXQVJEX0JHEhAKCGV2ZW50X2lkGAEgASgFEh4KFmV2ZW50",
				"X2JnX2Rpc3BsYXlfcGxhY2UYAiABKAUSEAoIcHJpb3JpdHkYAyABKAUSEQoJ",
				"Y29uZF90eXBlGAQgASgFEhIKCmNvbmRfdmFsdWUYBSABKAUSDQoFYmdfaWQY",
				"BiABKAUiSwoZTVNUX0VWRU5UX1JFV0FSRF9CR19BUlJBWRIuCgVpdGVtcxgB",
				"IAMoCzIfLnVGcmFtZXdvcmsuTVNUX0VWRU5UX1JFV0FSRF9CR2IGcHJvdG8z"
			}));
			MstEventRewardBgReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_REWARD_BG), MST_EVENT_REWARD_BG.Parser, new string[]
				{
					"EventId",
					"EventBgDisplayPlace",
					"Priority",
					"CondType",
					"CondValue",
					"BgId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_REWARD_BG_ARRAY), MST_EVENT_REWARD_BG_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
