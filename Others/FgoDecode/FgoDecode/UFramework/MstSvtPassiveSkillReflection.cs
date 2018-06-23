using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtPassiveSkillReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtPassiveSkillReflection.descriptor;

		static MstSvtPassiveSkillReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chttc3Rfc3Z0X3Bhc3NpdmVfc2tpbGwucHJvdG8SCnVGcmFtZXdvcmsi+AEK",
				"FU1TVF9TVlRfUEFTU0lWRV9TS0lMTBIOCgZzdnRfaWQYASABKAUSCwoDbnVt",
				"GAIgASgFEhAKCHByaW9yaXR5GAMgASgFEhAKCHNraWxsX2lkGAQgASgFEhUK",
				"DWNvbmRfcXVlc3RfaWQYBSABKAUSGAoQY29uZF9xdWVzdF9waGFzZRgGIAEo",
				"BRIPCgdjb25kX2x2GAcgASgFEhgKEGNvbmRfbGltaXRfY291bnQYCCABKAUS",
				"HAoUY29uZF9mcmllbmRzaGlwX3JhbmsYCSABKAUSEgoKc3RhcnRlZF9hdBgK",
				"IAEoBBIQCghlbmRlZF9hdBgLIAEoBCJPChtNU1RfU1ZUX1BBU1NJVkVfU0tJ",
				"TExfQVJSQVkSMAoFaXRlbXMYASADKAsyIS51RnJhbWV3b3JrLk1TVF9TVlRf",
				"UEFTU0lWRV9TS0lMTGIGcHJvdG8z"
			}));
			MstSvtPassiveSkillReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_PASSIVE_SKILL), MST_SVT_PASSIVE_SKILL.Parser, new string[]
				{
					"SvtId",
					"Num",
					"Priority",
					"SkillId",
					"CondQuestId",
					"CondQuestPhase",
					"CondLv",
					"CondLimitCount",
					"CondFriendshipRank",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_PASSIVE_SKILL_ARRAY), MST_SVT_PASSIVE_SKILL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
