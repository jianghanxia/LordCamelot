using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEquipSkillReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEquipSkillReflection.descriptor;

		static MstEquipSkillReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfZXF1aXBfc2tpbGwucHJvdG8SCnVGcmFtZXdvcmsiewoPTVNUX0VR",
				"VUlQX1NLSUxMEhAKCGVxdWlwX2lkGAEgASgFEgsKA251bRgCIAEoBRIQCghz",
				"a2lsbF9pZBgDIAEoBRIPCgdjb25kX2x2GAQgASgFEhIKCnVwZGF0ZWRfYXQY",
				"BSABKAQSEgoKY3JlYXRlZF9hdBgGIAEoBCJDChVNU1RfRVFVSVBfU0tJTExf",
				"QVJSQVkSKgoFaXRlbXMYASADKAsyGy51RnJhbWV3b3JrLk1TVF9FUVVJUF9T",
				"S0lMTGIGcHJvdG8z"
			}));
			MstEquipSkillReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_SKILL), MST_EQUIP_SKILL.Parser, new string[]
				{
					"EquipId",
					"Num",
					"SkillId",
					"CondLv",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_SKILL_ARRAY), MST_EQUIP_SKILL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
