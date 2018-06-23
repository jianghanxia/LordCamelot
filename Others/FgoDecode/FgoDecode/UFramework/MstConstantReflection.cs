using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstConstantReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstConstantReflection.descriptor;

		static MstConstantReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJtc3RfY29uc3RhbnQucHJvdG8SCnVGcmFtZXdvcmsiUwoMTVNUX0NPTlNU",
				"QU5UEgwKBG5hbWUYASABKAwSDQoFdmFsdWUYAiABKAUSEgoKdXBkYXRlZF9h",
				"dBgDIAEoBBISCgpjcmVhdGVkX2F0GAQgASgEIj0KEk1TVF9DT05TVEFOVF9B",
				"UlJBWRInCgVpdGVtcxgBIAMoCzIYLnVGcmFtZXdvcmsuTVNUX0NPTlNUQU5U",
				"YgZwcm90bzM="
			}));
			MstConstantReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CONSTANT), MST_CONSTANT.Parser, new string[]
				{
					"Name",
					"Value",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CONSTANT_ARRAY), MST_CONSTANT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
