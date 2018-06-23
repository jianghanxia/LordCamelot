using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSkillReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSkillReflection.descriptor;

		static MstSkillReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3Rfc2tpbGwucHJvdG8SCnVGcmFtZXdvcmsi2gEKCU1TVF9TS0lMTBIK",
				"CgJpZBgBIAEoBRIMCgR0eXBlGAIgASgFEgwKBG5hbWUYAyABKAwSDAoEcnVi",
				"eRgEIAEoDBIOCgZtYXhfbHYYBSABKAUSDwoHaWNvbl9pZBgGIAEoBRIOCgZt",
				"b3Rpb24YByABKAUSEwoLZWZmZWN0X2xpc3QYCCADKAUSGQoRYWN0X2luZGl2",
				"aWR1YWxpdHkYCSADKAUSDgoGc2NyaXB0GAogASgMEhIKCnVwZGF0ZWRfYXQY",
				"CyABKAQSEgoKY3JlYXRlZF9hdBgMIAEoBCI3Cg9NU1RfU0tJTExfQVJSQVkS",
				"JAoFaXRlbXMYASADKAsyFS51RnJhbWV3b3JrLk1TVF9TS0lMTGIGcHJvdG8z"
			}));
			MstSkillReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SKILL), MST_SKILL.Parser, new string[]
				{
					"Id",
					"Type",
					"Name",
					"Ruby",
					"MaxLv",
					"IconId",
					"Motion",
					"EffectList",
					"ActIndividuality",
					"Script",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SKILL_ARRAY), MST_SKILL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
