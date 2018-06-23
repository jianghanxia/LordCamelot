using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestPhaseDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestPhaseDetailReflection.descriptor;

		static MstQuestPhaseDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chxtc3RfcXVlc3RfcGhhc2VfZGV0YWlsLnByb3RvEgp1RnJhbWV3b3JrIp4B",
				"ChZNU1RfUVVFU1RfUEhBU0VfREVUQUlMEhAKCHF1ZXN0X2lkGAEgASgFEg0K",
				"BXBoYXNlGAIgASgFEg8KB3Nwb3RfaWQYAyABKAUSFAoMY29uc3VtZV90eXBl",
				"GAQgASgFEhMKC2FjdF9jb25zdW1lGAUgASgFEgwKBGZsYWcYBiABKAUSGQoR",
				"YWZ0ZXJfYWN0aW9uX3ZhbHMYByADKAUiUQocTVNUX1FVRVNUX1BIQVNFX0RF",
				"VEFJTF9BUlJBWRIxCgVpdGVtcxgBIAMoCzIiLnVGcmFtZXdvcmsuTVNUX1FV",
				"RVNUX1BIQVNFX0RFVEFJTGIGcHJvdG8z"
			}));
			MstQuestPhaseDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_PHASE_DETAIL), MST_QUEST_PHASE_DETAIL.Parser, new string[]
				{
					"QuestId",
					"Phase",
					"SpotId",
					"ConsumeType",
					"ActConsume",
					"Flag",
					"AfterActionVals"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_PHASE_DETAIL_ARRAY), MST_QUEST_PHASE_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
