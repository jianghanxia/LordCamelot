using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventMissionConditionDetReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventMissionConditionDetReflection.descriptor;

		static MstEventMissionConditionDetReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiVtc3RfZXZlbnRfbWlzc2lvbl9jb25kaXRpb25fZGV0LnByb3RvEgp1RnJh",
				"bWV3b3JrIssBCh9NU1RfRVZFTlRfTUlTU0lPTl9DT05ESVRJT05fREVUEgoK",
				"AmlkGAEgASgFEhkKEW1pc3Npb25fY29uZF90eXBlGAIgASgFEhIKCmxvZ2lj",
				"X3R5cGUYAyABKAUSEgoKdGFyZ2V0X2lkcxgEIAMoBRIWCg5hZGRfdGFyZ2V0",
				"X2lkcxgFIAMoBRIkChx0YXJnZXRfcXVlc3RfaW5kaXZpZHVhbGl0aWVzGAYg",
				"AygFEhsKE2NvbmRpdGlvbl9saW5rX3R5cGUYByABKAUiYwolTVNUX0VWRU5U",
				"X01JU1NJT05fQ09ORElUSU9OX0RFVF9BUlJBWRI6CgVpdGVtcxgBIAMoCzIr",
				"LnVGcmFtZXdvcmsuTVNUX0VWRU5UX01JU1NJT05fQ09ORElUSU9OX0RFVGIG",
				"cHJvdG8z"
			}));
			MstEventMissionConditionDetReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_CONDITION_DET), MST_EVENT_MISSION_CONDITION_DET.Parser, new string[]
				{
					"Id",
					"MissionCondType",
					"LogicType",
					"TargetIds",
					"AddTargetIds",
					"TargetQuestIndividualities",
					"ConditionLinkType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_CONDITION_DET_ARRAY), MST_EVENT_MISSION_CONDITION_DET_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
