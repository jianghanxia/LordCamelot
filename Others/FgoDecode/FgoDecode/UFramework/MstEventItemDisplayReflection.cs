using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventItemDisplayReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventItemDisplayReflection.descriptor;

		static MstEventItemDisplayReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chxtc3RfZXZlbnRfaXRlbV9kaXNwbGF5LnByb3RvEgp1RnJhbWV3b3JrIscB",
				"ChZNU1RfRVZFTlRfSVRFTV9ESVNQTEFZEgoKAmlkGAEgASgFEhAKCGV2ZW50",
				"X2lkGAIgASgFEhMKC3NjcmVlbl9mbGFnGAMgASgFEg8KB2l0ZW1faWQYBCAB",
				"KAUSEwoLZ3JvdXBfaW5kZXgYBSABKAUSEAoIcHJpb3JpdHkYBiABKAUSHAoU",
				"Y29uZGl0aW9uX2RldGFpbF9pZHMYByADKAUSEQoJb3BlbmVkX2F0GAggASgE",
				"EhEKCWNsb3NlZF9hdBgJIAEoBCJRChxNU1RfRVZFTlRfSVRFTV9ESVNQTEFZ",
				"X0FSUkFZEjEKBWl0ZW1zGAEgAygLMiIudUZyYW1ld29yay5NU1RfRVZFTlRf",
				"SVRFTV9ESVNQTEFZYgZwcm90bzM="
			}));
			MstEventItemDisplayReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ITEM_DISPLAY), MST_EVENT_ITEM_DISPLAY.Parser, new string[]
				{
					"Id",
					"EventId",
					"ScreenFlag",
					"ItemId",
					"GroupIndex",
					"Priority",
					"ConditionDetailIds",
					"OpenedAt",
					"ClosedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ITEM_DISPLAY_ARRAY), MST_EVENT_ITEM_DISPLAY_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
