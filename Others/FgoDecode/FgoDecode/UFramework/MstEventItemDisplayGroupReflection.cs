using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventItemDisplayGroupReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventItemDisplayGroupReflection.descriptor;

		static MstEventItemDisplayGroupReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiJtc3RfZXZlbnRfaXRlbV9kaXNwbGF5X2dyb3VwLnByb3RvEgp1RnJhbWV3",
				"b3JrIl0KHE1TVF9FVkVOVF9JVEVNX0RJU1BMQVlfR1JPVVASEAoIZXZlbnRf",
				"aWQYASABKAUSEwoLZ3JvdXBfaW5kZXgYAiABKAUSFgoOdGl0bGVfaW1hZ2Vf",
				"aWQYAyABKAUiXQoiTVNUX0VWRU5UX0lURU1fRElTUExBWV9HUk9VUF9BUlJB",
				"WRI3CgVpdGVtcxgBIAMoCzIoLnVGcmFtZXdvcmsuTVNUX0VWRU5UX0lURU1f",
				"RElTUExBWV9HUk9VUGIGcHJvdG8z"
			}));
			MstEventItemDisplayGroupReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ITEM_DISPLAY_GROUP), MST_EVENT_ITEM_DISPLAY_GROUP.Parser, new string[]
				{
					"EventId",
					"GroupIndex",
					"TitleImageId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ITEM_DISPLAY_GROUP_ARRAY), MST_EVENT_ITEM_DISPLAY_GROUP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
