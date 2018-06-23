using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtVoiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtVoiceReflection.descriptor;

		static MstSvtVoiceReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3Rfc3Z0X3ZvaWNlLnByb3RvEgp1RnJhbWV3b3JrIlQKDU1TVF9TVlRf",
				"Vk9JQ0USCgoCaWQYASABKAUSFAoMdm9pY2VfcHJlZml4GAIgASgFEgwKBHR5",
				"cGUYAyABKAUSEwoLc2NyaXB0X2pzb24YBCABKAwiPwoTTVNUX1NWVF9WT0lD",
				"RV9BUlJBWRIoCgVpdGVtcxgBIAMoCzIZLnVGcmFtZXdvcmsuTVNUX1NWVF9W",
				"T0lDRWIGcHJvdG8z"
			}));
			MstSvtVoiceReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_VOICE), MST_SVT_VOICE.Parser, new string[]
				{
					"Id",
					"VoicePrefix",
					"Type",
					"ScriptJson"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_VOICE_ARRAY), MST_SVT_VOICE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
