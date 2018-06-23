using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventTutorialReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventTutorialReflection.descriptor;

		static MstEventTutorialReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfZXZlbnRfdHV0b3JpYWwucHJvdG8SCnVGcmFtZXdvcmsi6QEKEk1T",
				"VF9FVkVOVF9UVVRPUklBTBIQCghldmVudF9pZBgBIAEoBRIRCglmbGFnX3R5",
				"cGUYAiABKAUSEQoJb3Blbl90eXBlGAMgASgFEhIKCnRhcmdldF9pZHMYBCAD",
				"KAwSEQoJY29uZF90eXBlGAUgASgFEhAKCGNvbmRfaWRzGAYgAygFEhIKCmNv",
				"bmRfdmFsdWUYByABKAUSEwoLY29uZF92YWx1ZTIYCCABKAUSEwoLY29uZF92",
				"YWx1ZTMYCSABKAUSEQoJaW1hZ2VfaWRzGAogAygFEhEKCXRleHRfanNvbhgL",
				"IAEoDCJJChhNU1RfRVZFTlRfVFVUT1JJQUxfQVJSQVkSLQoFaXRlbXMYASAD",
				"KAsyHi51RnJhbWV3b3JrLk1TVF9FVkVOVF9UVVRPUklBTGIGcHJvdG8z"
			}));
			MstEventTutorialReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_TUTORIAL), MST_EVENT_TUTORIAL.Parser, new string[]
				{
					"EventId",
					"FlagType",
					"OpenType",
					"TargetIds",
					"CondType",
					"CondIds",
					"CondValue",
					"CondValue2",
					"CondValue3",
					"ImageIds",
					"TextJson"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_TUTORIAL_ARRAY), MST_EVENT_TUTORIAL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
