using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSkillDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSkillDetailReflection.descriptor;

		static MstSkillDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZtc3Rfc2tpbGxfZGV0YWlsLnByb3RvEgp1RnJhbWV3b3JrImwKEE1TVF9T",
				"S0lMTF9ERVRBSUwSCgoCaWQYASABKAUSDgoGZGV0YWlsGAIgASgMEhQKDGRl",
				"dGFpbF9zaG9ydBgDIAEoDBISCgp1cGRhdGVkX2F0GAQgASgEEhIKCmNyZWF0",
				"ZWRfYXQYBSABKAQiRQoWTVNUX1NLSUxMX0RFVEFJTF9BUlJBWRIrCgVpdGVt",
				"cxgBIAMoCzIcLnVGcmFtZXdvcmsuTVNUX1NLSUxMX0RFVEFJTGIGcHJvdG8z"
			}));
			MstSkillDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SKILL_DETAIL), MST_SKILL_DETAIL.Parser, new string[]
				{
					"Id",
					"Detail",
					"DetailShort",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SKILL_DETAIL_ARRAY), MST_SKILL_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
