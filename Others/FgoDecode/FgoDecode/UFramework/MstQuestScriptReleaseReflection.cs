using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestScriptReleaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestScriptReleaseReflection.descriptor;

		static MstQuestScriptReleaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ch5tc3RfcXVlc3Rfc2NyaXB0X3JlbGVhc2UucHJvdG8SCnVGcmFtZXdvcmsi",
				"ggEKGE1TVF9RVUVTVF9TQ1JJUFRfUkVMRUFTRRIRCglzY3JpcHRfaWQYASAB",
				"KAUSCgoCaWQYAiABKAUSDAoEZmxhZxgDIAEoBRIRCgljb25kX3R5cGUYBCAB",
				"KAUSEgoKdGFyZ2V0X2lkcxgFIAMoBRISCgp0YXJnZXRfbnVtGAYgASgFIlUK",
				"Hk1TVF9RVUVTVF9TQ1JJUFRfUkVMRUFTRV9BUlJBWRIzCgVpdGVtcxgBIAMo",
				"CzIkLnVGcmFtZXdvcmsuTVNUX1FVRVNUX1NDUklQVF9SRUxFQVNFYgZwcm90",
				"bzM="
			}));
			MstQuestScriptReleaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_SCRIPT_RELEASE), MST_QUEST_SCRIPT_RELEASE.Parser, new string[]
				{
					"ScriptId",
					"Id",
					"Flag",
					"CondType",
					"TargetIds",
					"TargetNum"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_SCRIPT_RELEASE_ARRAY), MST_QUEST_SCRIPT_RELEASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
