using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestReleaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestReleaseReflection.descriptor;

		static MstQuestReleaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3RfcXVlc3RfcmVsZWFzZS5wcm90bxIKdUZyYW1ld29yayKcAQoRTVNU",
				"X1FVRVNUX1JFTEVBU0USEAoIcXVlc3RfaWQYASABKAUSDAoEdHlwZRgCIAEo",
				"BRIRCgl0YXJnZXRfaWQYAyABKAUSDQoFdmFsdWUYBCABKAUSEgoKb3Blbl9s",
				"aW1pdBgFIAEoBRIZChFjbG9zZWRfbWVzc2FnZV9pZBgGIAEoBRIWCg5pbWFn",
				"ZV9wcmlvcml0eRgHIAEoBSJHChdNU1RfUVVFU1RfUkVMRUFTRV9BUlJBWRIs",
				"CgVpdGVtcxgBIAMoCzIdLnVGcmFtZXdvcmsuTVNUX1FVRVNUX1JFTEVBU0Vi",
				"BnByb3RvMw=="
			}));
			MstQuestReleaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_RELEASE), MST_QUEST_RELEASE.Parser, new string[]
				{
					"QuestId",
					"Type",
					"TargetId",
					"Value",
					"OpenLimit",
					"ClosedMessageId",
					"ImagePriority"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_RELEASE_ARRAY), MST_QUEST_RELEASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
