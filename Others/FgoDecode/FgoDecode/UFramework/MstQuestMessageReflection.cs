using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestMessageReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestMessageReflection.descriptor;

		static MstQuestMessageReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3RfcXVlc3RfbWVzc2FnZS5wcm90bxIKdUZyYW1ld29yayKXAQoRTVNU",
				"X1FVRVNUX01FU1NBR0USEAoIcXVlc3RfaWQYASABKAUSDQoFcGhhc2UYAiAB",
				"KAUSDwoHbWVzc2FnZRgDIAEoDBIRCgljb25kX3R5cGUYBCABKAUSEQoJdGFy",
				"Z2V0X2lkGAUgASgFEhIKCnRhcmdldF9udW0YBiABKAUSFgoOZnJlcXVlbmN5",
				"X3R5cGUYByABKAUiRwoXTVNUX1FVRVNUX01FU1NBR0VfQVJSQVkSLAoFaXRl",
				"bXMYASADKAsyHS51RnJhbWV3b3JrLk1TVF9RVUVTVF9NRVNTQUdFYgZwcm90",
				"bzM="
			}));
			MstQuestMessageReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_MESSAGE), MST_QUEST_MESSAGE.Parser, new string[]
				{
					"QuestId",
					"Phase",
					"Message",
					"CondType",
					"TargetId",
					"TargetNum",
					"FrequencyType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_MESSAGE_ARRAY), MST_QUEST_MESSAGE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
