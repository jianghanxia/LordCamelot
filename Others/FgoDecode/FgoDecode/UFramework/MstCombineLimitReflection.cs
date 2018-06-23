using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCombineLimitReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCombineLimitReflection.descriptor;

		static MstCombineLimitReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3RfY29tYmluZV9saW1pdC5wcm90bxIKdUZyYW1ld29yayKLAQoRTVNU",
				"X0NPTUJJTkVfTElNSVQSCgoCaWQYASABKAUSEQoJc3Z0X2xpbWl0GAIgASgF",
				"EgoKAnFwGAMgASgFEhEKCWl0ZW1fbnVtcxgEIAMoBRIQCghpdGVtX2lkcxgF",
				"IAMoBRISCgp1cGRhdGVkX2F0GAYgASgEEhIKCmNyZWF0ZWRfYXQYByABKAQi",
				"RwoXTVNUX0NPTUJJTkVfTElNSVRfQVJSQVkSLAoFaXRlbXMYASADKAsyHS51",
				"RnJhbWV3b3JrLk1TVF9DT01CSU5FX0xJTUlUYgZwcm90bzM="
			}));
			MstCombineLimitReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_LIMIT), MST_COMBINE_LIMIT.Parser, new string[]
				{
					"Id",
					"SvtLimit",
					"Qp",
					"ItemNums",
					"ItemIds",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_LIMIT_ARRAY), MST_COMBINE_LIMIT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
