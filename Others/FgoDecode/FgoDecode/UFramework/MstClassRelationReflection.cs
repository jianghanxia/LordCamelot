using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstClassRelationReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstClassRelationReflection.descriptor;

		static MstClassRelationReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfY2xhc3NfcmVsYXRpb24ucHJvdG8SCnVGcmFtZXdvcmsiTwoSTVNU",
				"X0NMQVNTX1JFTEFUSU9OEhEKCWF0a19jbGFzcxgBIAEoBRIRCglkZWZfY2xh",
				"c3MYAiABKAUSEwoLYXR0YWNrX3JhdGUYAyABKAUiSQoYTVNUX0NMQVNTX1JF",
				"TEFUSU9OX0FSUkFZEi0KBWl0ZW1zGAEgAygLMh4udUZyYW1ld29yay5NU1Rf",
				"Q0xBU1NfUkVMQVRJT05iBnByb3RvMw=="
			}));
			MstClassRelationReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CLASS_RELATION), MST_CLASS_RELATION.Parser, new string[]
				{
					"AtkClass",
					"DefClass",
					"AttackRate"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CLASS_RELATION_ARRAY), MST_CLASS_RELATION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
