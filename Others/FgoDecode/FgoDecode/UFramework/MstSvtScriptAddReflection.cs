using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtScriptAddReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtScriptAddReflection.descriptor;

		static MstSvtScriptAddReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3Rfc3Z0X3NjcmlwdF9hZGQucHJvdG8SCnVGcmFtZXdvcmsinAEKEk1T",
				"VF9TVlRfU0NSSVBUX0FERBIOCgZzdnRfaWQYASABKAUSHQoVb2Zmc2V0X3hf",
				"ZXZlbnRfcmV3YXJkGAIgASgFEh0KFW9mZnNldF95X2V2ZW50X3Jld2FyZBgD",
				"IAEoBRIbChNvZmZzZXRfeF9ldmVudF9zaG9wGAQgASgFEhsKE29mZnNldF95",
				"X2V2ZW50X3Nob3AYBSABKAUiSQoYTVNUX1NWVF9TQ1JJUFRfQUREX0FSUkFZ",
				"Ei0KBWl0ZW1zGAEgAygLMh4udUZyYW1ld29yay5NU1RfU1ZUX1NDUklQVF9B",
				"RERiBnByb3RvMw=="
			}));
			MstSvtScriptAddReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_SCRIPT_ADD), MST_SVT_SCRIPT_ADD.Parser, new string[]
				{
					"SvtId",
					"OffsetXEventReward",
					"OffsetYEventReward",
					"OffsetXEventShop",
					"OffsetYEventShop"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_SCRIPT_ADD_ARRAY), MST_SVT_SCRIPT_ADD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
