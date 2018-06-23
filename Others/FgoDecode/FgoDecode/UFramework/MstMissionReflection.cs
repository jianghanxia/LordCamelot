using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstMissionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstMissionReflection.descriptor;

		static MstMissionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChFtc3RfbWlzc2lvbi5wcm90bxIKdUZyYW1ld29yayKtAQoLTVNUX01JU1NJ",
				"T04SCgoCaWQYASABKAUSDwoHY29tbWVudBgCIAEoDBIMCgR0eXBlGAMgASgF",
				"EhEKCXRhcmdldF9pZBgEIAEoBRINCgV2YWx1ZRgFIAEoBRIPCgdnaWZ0X2lk",
				"GAYgASgFEhoKEnByZXNlbnRfbWVzc2FnZV9pZBgHIAEoBRISCgpzdGFydGVk",
				"X2F0GAggASgEEhAKCGVuZGVkX2F0GAkgASgEIjsKEU1TVF9NSVNTSU9OX0FS",
				"UkFZEiYKBWl0ZW1zGAEgAygLMhcudUZyYW1ld29yay5NU1RfTUlTU0lPTmIG",
				"cHJvdG8z"
			}));
			MstMissionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_MISSION), MST_MISSION.Parser, new string[]
				{
					"Id",
					"Comment",
					"Type",
					"TargetId",
					"Value",
					"GiftId",
					"PresentMessageId",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_MISSION_ARRAY), MST_MISSION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
