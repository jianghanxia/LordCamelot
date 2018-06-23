using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstConstantStrReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstConstantStrReflection.descriptor;

		static MstConstantStrReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZtc3RfY29uc3RhbnRfc3RyLnByb3RvEgp1RnJhbWV3b3JrIlcKEE1TVF9D",
				"T05TVEFOVF9TVFISDAoEbmFtZRgBIAEoDBINCgV2YWx1ZRgCIAEoDBISCgp1",
				"cGRhdGVkX2F0GAMgASgEEhIKCmNyZWF0ZWRfYXQYBCABKAQiRQoWTVNUX0NP",
				"TlNUQU5UX1NUUl9BUlJBWRIrCgVpdGVtcxgBIAMoCzIcLnVGcmFtZXdvcmsu",
				"TVNUX0NPTlNUQU5UX1NUUmIGcHJvdG8z"
			}));
			MstConstantStrReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CONSTANT_STR), MST_CONSTANT_STR.Parser, new string[]
				{
					"Name",
					"Value",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CONSTANT_STR_ARRAY), MST_CONSTANT_STR_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
