using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtSkillReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtSkillReflection.descriptor;

		static MstSvtSkillReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3Rfc3Z0X3NraWxsLnByb3RvEgp1RnJhbWV3b3JrIroBCg1NU1RfU1ZU",
				"X1NLSUxMEg4KBnN2dF9pZBgBIAEoBRILCgNudW0YAiABKAUSEAoIcHJpb3Jp",
				"dHkYAyABKAUSEAoIc2tpbGxfaWQYBCABKAUSFQoNY29uZF9xdWVzdF9pZBgF",
				"IAEoBRIPCgdjb25kX2x2GAYgASgFEhgKEGNvbmRfbGltaXRfY291bnQYByAB",
				"KAUSEgoKdXBkYXRlZF9hdBgIIAEoBBISCgpjcmVhdGVkX2F0GAkgASgEIj8K",
				"E01TVF9TVlRfU0tJTExfQVJSQVkSKAoFaXRlbXMYASADKAsyGS51RnJhbWV3",
				"b3JrLk1TVF9TVlRfU0tJTExiBnByb3RvMw=="
			}));
			MstSvtSkillReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_SKILL), MST_SVT_SKILL.Parser, new string[]
				{
					"SvtId",
					"Num",
					"Priority",
					"SkillId",
					"CondQuestId",
					"CondLv",
					"CondLimitCount",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_SKILL_ARRAY), MST_SVT_SKILL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
