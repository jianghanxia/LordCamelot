using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventMissionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventMissionReflection.descriptor;

		static MstEventMissionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3RfZXZlbnRfbWlzc2lvbi5wcm90bxIKdUZyYW1ld29yayKqAgoRTVNU",
				"X0VWRU5UX01JU1NJT04SCgoCaWQYASABKAUSDAoEZmxhZxgCIAEoBRIMCgR0",
				"eXBlGAMgASgFEhkKEW1pc3Npb25fdGFyZ2V0X2lkGAQgASgFEg8KB2Rpc3Bf",
				"bm8YBSABKAUSFgoObm90ZnlfcHJpb3JpdHkYBiABKAUSDAoEbmFtZRgHIAEo",
				"DBIOCgZkZXRhaWwYCCABKAwSEgoKc3RhcnRlZF9hdBgJIAEoBBIQCghlbmRl",
				"ZF9hdBgKIAEoBBIRCgljbG9zZWRfYXQYCyABKAQSEwoLcmV3YXJkX3R5cGUY",
				"DCABKAUSGgoScHJlc2VudF9tZXNzYWdlX2lkGA0gASgFEg8KB2dpZnRfaWQY",
				"DiABKAUSEAoIZXZlbnRfaWQYDyABKAUiRwoXTVNUX0VWRU5UX01JU1NJT05f",
				"QVJSQVkSLAoFaXRlbXMYASADKAsyHS51RnJhbWV3b3JrLk1TVF9FVkVOVF9N",
				"SVNTSU9OYgZwcm90bzM="
			}));
			MstEventMissionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION), MST_EVENT_MISSION.Parser, new string[]
				{
					"Id",
					"Flag",
					"Type",
					"MissionTargetId",
					"DispNo",
					"NotfyPriority",
					"Name",
					"Detail",
					"StartedAt",
					"EndedAt",
					"ClosedAt",
					"RewardType",
					"PresentMessageId",
					"GiftId",
					"EventId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_MISSION_ARRAY), MST_EVENT_MISSION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
