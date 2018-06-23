using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstVoiceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstVoiceReflection.descriptor;

		static MstVoiceReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3Rfdm9pY2UucHJvdG8SCnVGcmFtZXdvcmsioQEKCU1TVF9WT0lDRRIK",
				"CgJpZBgBIAEoDBIQCghwcmlvcml0eRgCIAEoBRIWCg5zdnRfdm9pY2VfdHlw",
				"ZRgDIAEoBRIMCgRuYW1lGAQgASgMEhQKDG5hbWVfZGVmYXVsdBgFIAEoDBIR",
				"Cgljb25kX3R5cGUYBiABKAUSEgoKY29uZF92YWx1ZRgHIAEoBRITCgtjbG9z",
				"ZWRfdHlwZRgIIAEoBSI3Cg9NU1RfVk9JQ0VfQVJSQVkSJAoFaXRlbXMYASAD",
				"KAsyFS51RnJhbWV3b3JrLk1TVF9WT0lDRWIGcHJvdG8z"
			}));
			MstVoiceReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_VOICE), MST_VOICE.Parser, new string[]
				{
					"Id",
					"Priority",
					"SvtVoiceType",
					"Name",
					"NameDefault",
					"CondType",
					"CondValue",
					"ClosedType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_VOICE_ARRAY), MST_VOICE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
