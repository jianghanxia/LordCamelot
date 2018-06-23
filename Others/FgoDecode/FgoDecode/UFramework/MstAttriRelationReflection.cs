using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstAttriRelationReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstAttriRelationReflection.descriptor;

		static MstAttriRelationReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfYXR0cmlfcmVsYXRpb24ucHJvdG8SCnVGcmFtZXdvcmsiTwoSTVNU",
				"X0FUVFJJX1JFTEFUSU9OEhEKCWF0a19hdHRyaRgBIAEoBRIRCglkZWZfYXR0",
				"cmkYAiABKAUSEwoLYXR0YWNrX3JhdGUYAyABKAUiSQoYTVNUX0FUVFJJX1JF",
				"TEFUSU9OX0FSUkFZEi0KBWl0ZW1zGAEgAygLMh4udUZyYW1ld29yay5NU1Rf",
				"QVRUUklfUkVMQVRJT05iBnByb3RvMw=="
			}));
			MstAttriRelationReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_ATTRI_RELATION), MST_ATTRI_RELATION.Parser, new string[]
				{
					"AtkAttri",
					"DefAttri",
					"AttackRate"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_ATTRI_RELATION_ARRAY), MST_ATTRI_RELATION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
