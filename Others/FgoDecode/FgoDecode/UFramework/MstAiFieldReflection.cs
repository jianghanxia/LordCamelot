using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstAiFieldReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstAiFieldReflection.descriptor;

		static MstAiFieldReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJtc3RfYWlfZmllbGQucHJvdG8SCnVGcmFtZXdvcmsi6AEKDE1TVF9BSV9G",
				"SUVMRBIKCgJpZBgBIAEoBRILCgNpZHgYAiABKAUSDwoHYWN0X251bRgDIAEo",
				"BRIOCgZ0aW1pbmcYBCABKAUSEAoIcHJpb3JpdHkYBSABKAUSEwoLcHJvYmFi",
				"aWxpdHkYBiABKAUSDAoEY29uZBgHIAEoBRIMCgR2YWxzGAggAygDEhEKCWFp",
				"X2FjdF9pZBgJIAEoBRINCgVhdmFscxgKIAMoBRIRCglpbmZvX3RleHQYCyAB",
				"KAwSEgoKdXBkYXRlZF9hdBgMIAEoBBISCgpjcmVhdGVkX2F0GA0gASgEIj0K",
				"Ek1TVF9BSV9GSUVMRF9BUlJBWRInCgVpdGVtcxgBIAMoCzIYLnVGcmFtZXdv",
				"cmsuTVNUX0FJX0ZJRUxEYgZwcm90bzM="
			}));
			MstAiFieldReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_AI_FIELD), MST_AI_FIELD.Parser, new string[]
				{
					"Id",
					"Idx",
					"ActNum",
					"Timing",
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
				new GeneratedClrTypeInfo(typeof(MST_AI_FIELD_ARRAY), MST_AI_FIELD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
