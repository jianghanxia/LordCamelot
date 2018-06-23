using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstVoiceReleaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstVoiceReleaseReflection.descriptor;

		static MstVoiceReleaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3Rfdm9pY2VfcmVsZWFzZS5wcm90bxIKdUZyYW1ld29yayJMChFNU1Rf",
				"Vk9JQ0VfUkVMRUFTRRIQCgh2b2ljZV9pZBgBIAEoDBIRCgljb25kX3R5cGUY",
				"AiABKAUSEgoKY29uZF92YWx1ZRgDIAEoBSJHChdNU1RfVk9JQ0VfUkVMRUFT",
				"RV9BUlJBWRIsCgVpdGVtcxgBIAMoCzIdLnVGcmFtZXdvcmsuTVNUX1ZPSUNF",
				"X1JFTEVBU0ViBnByb3RvMw=="
			}));
			MstVoiceReleaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_VOICE_RELEASE), MST_VOICE_RELEASE.Parser, new string[]
				{
					"VoiceId",
					"CondType",
					"CondValue"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_VOICE_RELEASE_ARRAY), MST_VOICE_RELEASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
