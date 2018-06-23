using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventItemDisplayReleaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventItemDisplayReleaseReflection.descriptor;

		static MstEventItemDisplayReleaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiRtc3RfZXZlbnRfaXRlbV9kaXNwbGF5X3JlbGVhc2UucHJvdG8SCnVGcmFt",
				"ZXdvcmsiUgoeTVNUX0VWRU5UX0lURU1fRElTUExBWV9SRUxFQVNFEgoKAmlk",
				"GAEgASgFEhEKCWNvbmRfdHlwZRgCIAEoBRIRCgl0YXJnZXRfaWQYAyABKAUi",
				"YQokTVNUX0VWRU5UX0lURU1fRElTUExBWV9SRUxFQVNFX0FSUkFZEjkKBWl0",
				"ZW1zGAEgAygLMioudUZyYW1ld29yay5NU1RfRVZFTlRfSVRFTV9ESVNQTEFZ",
				"X1JFTEVBU0ViBnByb3RvMw=="
			}));
			MstEventItemDisplayReleaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ITEM_DISPLAY_RELEASE), MST_EVENT_ITEM_DISPLAY_RELEASE.Parser, new string[]
				{
					"Id",
					"CondType",
					"TargetId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ITEM_DISPLAY_RELEASE_ARRAY), MST_EVENT_ITEM_DISPLAY_RELEASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
