using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstMasterMissionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstMasterMissionReflection.descriptor;

		static MstMasterMissionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfbWFzdGVyX21pc3Npb24ucHJvdG8SCnVGcmFtZXdvcmsiWQoSTVNU",
				"X01BU1RFUl9NSVNTSU9OEgoKAmlkGAEgASgFEhIKCnN0YXJ0ZWRfYXQYAiAB",
				"KAQSEAoIZW5kZWRfYXQYAyABKAQSEQoJY2xvc2VkX2F0GAQgASgEIkkKGE1T",
				"VF9NQVNURVJfTUlTU0lPTl9BUlJBWRItCgVpdGVtcxgBIAMoCzIeLnVGcmFt",
				"ZXdvcmsuTVNUX01BU1RFUl9NSVNTSU9OYgZwcm90bzM="
			}));
			MstMasterMissionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_MASTER_MISSION), MST_MASTER_MISSION.Parser, new string[]
				{
					"Id",
					"StartedAt",
					"EndedAt",
					"ClosedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_MASTER_MISSION_ARRAY), MST_MASTER_MISSION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
