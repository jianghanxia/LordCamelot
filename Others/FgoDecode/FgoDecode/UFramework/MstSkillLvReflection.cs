using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSkillLvReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSkillLvReflection.descriptor;

		static MstSkillLvReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJtc3Rfc2tpbGxfbHYucHJvdG8SCnVGcmFtZXdvcmsiwwEKDE1TVF9TS0lM",
				"TF9MVhIQCghza2lsbF9pZBgBIAEoBRIKCgJsdhgCIAEoBRITCgtjaGFyZ2Vf",
				"dHVybhgDIAEoBRIPCgdmdW5jX2lkGAQgAygFEgwKBHZhbHMYBSADKAwSFwoP",
				"c2tpbGxfZGV0YWlsX2lkGAYgASgFEhAKCHByaW9yaXR5GAcgASgFEg4KBnNj",
				"cmlwdBgIIAEoDBISCgp1cGRhdGVkX2F0GAkgASgEEhIKCmNyZWF0ZWRfYXQY",
				"CiABKAQiPQoSTVNUX1NLSUxMX0xWX0FSUkFZEicKBWl0ZW1zGAEgAygLMhgu",
				"dUZyYW1ld29yay5NU1RfU0tJTExfTFZiBnByb3RvMw=="
			}));
			MstSkillLvReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SKILL_LV), MST_SKILL_LV.Parser, new string[]
				{
					"SkillId",
					"Lv",
					"ChargeTurn",
					"FuncId",
					"Vals",
					"SkillDetailId",
					"Priority",
					"Script",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SKILL_LV_ARRAY), MST_SKILL_LV_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
