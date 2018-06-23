using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestScriptReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestScriptReflection.descriptor;

		static MstQuestScriptReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChZtc3RfcXVlc3Rfc2NyaXB0LnByb3RvEgp1RnJhbWV3b3JrIiwKEE1TVF9R" + "VUVTVF9TQ1JJUFQSCgoCaWQYASABKAUSDAoEbmFtZRgCIAEoDCJFChZNU1Rf" + "UVVFU1RfU0NSSVBUX0FSUkFZEisKBWl0ZW1zGAEgAygLMhwudUZyYW1ld29y" + "ay5NU1RfUVVFU1RfU0NSSVBUYgZwcm90bzM=");
			MstQuestScriptReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_SCRIPT), MST_QUEST_SCRIPT.Parser, new string[]
				{
					"Id",
					"Name"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_SCRIPT_ARRAY), MST_QUEST_SCRIPT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
