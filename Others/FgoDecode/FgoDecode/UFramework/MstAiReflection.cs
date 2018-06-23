using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstAiReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstAiReflection.descriptor;

		static MstAiReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cgxtc3RfYWkucHJvdG8SCnVGcmFtZXdvcmsi0gEKBk1TVF9BSRIKCgJpZBgB",
				"IAEoBRILCgNpZHgYAiABKAUSDwoHYWN0X251bRgDIAEoBRIQCghwcmlvcml0",
				"eRgEIAEoBRITCgtwcm9iYWJpbGl0eRgFIAEoBRIMCgRjb25kGAYgASgFEgwK",
				"BHZhbHMYByADKAMSEQoJYWlfYWN0X2lkGAggASgFEg0KBWF2YWxzGAkgAygF",
				"EhEKCWluZm9fdGV4dBgKIAEoDBISCgp1cGRhdGVkX2F0GAsgASgEEhIKCmNy",
				"ZWF0ZWRfYXQYDCABKAQiMQoMTVNUX0FJX0FSUkFZEiEKBWl0ZW1zGAEgAygL",
				"MhIudUZyYW1ld29yay5NU1RfQUliBnByb3RvMw=="
			}));
			MstAiReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_AI), MST_AI.Parser, new string[]
				{
					"Id",
					"Idx",
					"ActNum",
					"Priority",
					"Probability",
					"Cond",
					"Vals",
					"AiActId",
					"Avals",
					"InfoText",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_AI_ARRAY), MST_AI_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
