using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCombineSkillReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCombineSkillReflection.descriptor;

		static MstCombineSkillReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3RfY29tYmluZV9za2lsbC5wcm90bxIKdUZyYW1ld29yayKKAQoRTVNU",
				"X0NPTUJJTkVfU0tJTEwSCgoCaWQYASABKAUSEAoIc2tpbGxfbHYYAiABKAUS",
				"CgoCcXAYAyABKAUSEQoJaXRlbV9udW1zGAQgAygFEhAKCGl0ZW1faWRzGAUg",
				"AygFEhIKCnVwZGF0ZWRfYXQYBiABKAQSEgoKY3JlYXRlZF9hdBgHIAEoBCJH",
				"ChdNU1RfQ09NQklORV9TS0lMTF9BUlJBWRIsCgVpdGVtcxgBIAMoCzIdLnVG",
				"cmFtZXdvcmsuTVNUX0NPTUJJTkVfU0tJTExiBnByb3RvMw=="
			}));
			MstCombineSkillReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_SKILL), MST_COMBINE_SKILL.Parser, new string[]
				{
					"Id",
					"SkillLv",
					"Qp",
					"ItemNums",
					"ItemIds",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_SKILL_ARRAY), MST_COMBINE_SKILL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
