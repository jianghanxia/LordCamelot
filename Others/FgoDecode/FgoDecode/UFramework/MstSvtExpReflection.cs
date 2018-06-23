using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtExpReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtExpReflection.descriptor;

		static MstSvtExpReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChFtc3Rfc3Z0X2V4cC5wcm90bxIKdUZyYW1ld29yayJrCgtNU1RfU1ZUX0VY",
				"UBIMCgR0eXBlGAEgASgFEgoKAmx2GAIgASgFEgsKA2V4cBgDIAEoBRINCgVj",
				"dXJ2ZRgEIAEoBRISCgp1cGRhdGVkX2F0GAUgASgEEhIKCmNyZWF0ZWRfYXQY",
				"BiABKAQiOwoRTVNUX1NWVF9FWFBfQVJSQVkSJgoFaXRlbXMYASADKAsyFy51",
				"RnJhbWV3b3JrLk1TVF9TVlRfRVhQYgZwcm90bzM="
			}));
			MstSvtExpReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_EXP), MST_SVT_EXP.Parser, new string[]
				{
					"Type",
					"Lv",
					"Exp",
					"Curve",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_EXP_ARRAY), MST_SVT_EXP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
