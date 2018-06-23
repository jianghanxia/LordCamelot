using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestResetReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestResetReflection.descriptor;

		static MstQuestResetReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfcXVlc3RfcmVzZXQucHJvdG8SCnVGcmFtZXdvcmsiUwoPTVNUX1FV",
				"RVNUX1JFU0VUEhAKCHF1ZXN0X2lkGAEgASgFEhcKD3Jlc2V0X3F1ZXN0X2lk",
				"cxgCIAMoBRIVCg1zdGFydF9tZXNzYWdlGAMgASgMIkMKFU1TVF9RVUVTVF9S",
				"RVNFVF9BUlJBWRIqCgVpdGVtcxgBIAMoCzIbLnVGcmFtZXdvcmsuTVNUX1FV",
				"RVNUX1JFU0VUYgZwcm90bzM="
			}));
			MstQuestResetReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_RESET), MST_QUEST_RESET.Parser, new string[]
				{
					"QuestId",
					"ResetQuestIds",
					"StartMessage"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_RESET_ARRAY), MST_QUEST_RESET_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
