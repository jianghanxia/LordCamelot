using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventMissionActionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventMissionActionReflection.descriptor;

		static MstEventMissionActionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ch5tc3RfZXZlbnRfbWlzc2lvbl9hY3Rpb24ucHJvdG8SCnVGcmFtZXdvcmsi",
				"hAEKGE1TVF9FVkVOVF9NSVNTSU9OX0FDVElPThISCgptaXNzaW9uX2lkGAEg",
				"ASgFEh0KFW1pc3Npb25fcHJvZ3Jlc3NfdHlwZRgCIAEoBRIKCgJpZBgDIAEo",
				"BRIbChNtaXNzaW9uX2FjdGlvbl90eXBlGAQgASgFEgwKBHZhbHMYBSADKAwi",
				"VQoeTVNUX0VWRU5UX01JU1NJT05fQUNUSU9OX0FSUkFZEjMKBWl0ZW1zGAEg",
				"AygLMiQudUZyYW1ld29yay5NU1RfRVZFTlRfTUlTU0lPTl9BQ1RJT05iBnBy",
				"b3RvMw=="
			}));
			MstEventMissionActionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_ACTION), MST_EVENT_MISSION_ACTION.Parser, new string[]
				{
					"MissionId",
					"MissionProgressType",
					"Id",
					"MissionActionType",
					"Vals"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_ACTION_ARRAY), MST_EVENT_MISSION_ACTION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
