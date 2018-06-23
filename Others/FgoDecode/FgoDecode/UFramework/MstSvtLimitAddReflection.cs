using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtLimitAddReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtLimitAddReflection.descriptor;

		static MstSvtLimitAddReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3Rfc3Z0X2xpbWl0X2FkZC5wcm90bxIKdUZyYW1ld29yayLdAQoRTVNU",
				"X1NWVF9MSU1JVF9BREQSDgoGc3Z0X2lkGAEgASgFEhMKC2xpbWl0X2NvdW50",
				"GAIgASgFEhcKD2JhdHRsZV9jaGFyYV9pZBgDIAEoBRIgChhiYXR0bGVfY2hh",
				"cmFfbGltaXRfY291bnQYBCABKAUSHQoVYmF0dGxlX2NoYXJhX29mZnNldF94",
				"GAUgASgFEh0KFWJhdHRsZV9jaGFyYV9vZmZzZXRfeRgGIAEoBRIUCgxzdnRf",
				"dm9pY2VfaWQYByABKAUSFAoMdm9pY2VfcHJlZml4GAggASgFIkcKF01TVF9T",
				"VlRfTElNSVRfQUREX0FSUkFZEiwKBWl0ZW1zGAEgAygLMh0udUZyYW1ld29y",
				"ay5NU1RfU1ZUX0xJTUlUX0FERGIGcHJvdG8z"
			}));
			MstSvtLimitAddReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_LIMIT_ADD), MST_SVT_LIMIT_ADD.Parser, new string[]
				{
					"SvtId",
					"LimitCount",
					"BattleCharaId",
					"BattleCharaLimitCount",
					"BattleCharaOffsetX",
					"BattleCharaOffsetY",
					"SvtVoiceId",
					"VoicePrefix"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_LIMIT_ADD_ARRAY), MST_SVT_LIMIT_ADD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
