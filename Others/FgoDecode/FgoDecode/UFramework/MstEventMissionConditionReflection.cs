using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventMissionConditionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventMissionConditionReflection.descriptor;

		static MstEventMissionConditionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiFtc3RfZXZlbnRfbWlzc2lvbl9jb25kaXRpb24ucHJvdG8SCnVGcmFtZXdv",
				"cmsi7QEKG01TVF9FVkVOVF9NSVNTSU9OX0NPTkRJVElPThISCgptaXNzaW9u",
				"X2lkGAEgASgFEh0KFW1pc3Npb25fcHJvZ3Jlc3NfdHlwZRgCIAEoBRIKCgJp",
				"ZBgDIAEoBRIZChFtaXNzaW9uX3RhcmdldF9pZBgEIAEoBRIRCgljb25kX3R5",
				"cGUYBSABKAUSEgoKdGFyZ2V0X2lkcxgGIAMoBRISCgp0YXJnZXRfbnVtGAcg",
				"ASgFEhkKEWNvbmRpdGlvbl9tZXNzYWdlGAggASgMEgwKBGZsYWcYCSABKAUS",
				"EAoIZXZlbnRfaWQYCiABKAUiWwohTVNUX0VWRU5UX01JU1NJT05fQ09ORElU",
				"SU9OX0FSUkFZEjYKBWl0ZW1zGAEgAygLMicudUZyYW1ld29yay5NU1RfRVZF",
				"TlRfTUlTU0lPTl9DT05ESVRJT05iBnByb3RvMw=="
			}));
			MstEventMissionConditionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_CONDITION), MST_EVENT_MISSION_CONDITION.Parser, new string[]
				{
					"MissionId",
					"MissionProgressType",
					"Id",
					"MissionTargetId",
					"CondType",
					"TargetIds",
					"TargetNum",
					"ConditionMessage",
					"Flag",
					"EventId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_CONDITION_ARRAY), MST_EVENT_MISSION_CONDITION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
