using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventFilterReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventFilterReflection.descriptor;

		static MstEventFilterReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZtc3RfZXZlbnRfZmlsdGVyLnByb3RvEgp1RnJhbWV3b3JrImgKEE1TVF9F",
				"VkVOVF9GSUxURVISEAoIZXZlbnRfaWQYASABKAUSFQoNb3Blbl9xdWVzdF9p",
				"ZBgCIAEoBRIWCg5jbG9zZV9xdWVzdF9pZBgDIAEoBRITCgtidXR0b25fdGV4",
				"dBgEIAEoDCJFChZNU1RfRVZFTlRfRklMVEVSX0FSUkFZEisKBWl0ZW1zGAEg",
				"AygLMhwudUZyYW1ld29yay5NU1RfRVZFTlRfRklMVEVSYgZwcm90bzM="
			}));
			MstEventFilterReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_FILTER), MST_EVENT_FILTER.Parser, new string[]
				{
					"EventId",
					"OpenQuestId",
					"CloseQuestId",
					"ButtonText"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_FILTER_ARRAY), MST_EVENT_FILTER_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
