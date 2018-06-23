using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestConsumeItemReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestConsumeItemReflection.descriptor;

		static MstQuestConsumeItemReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chxtc3RfcXVlc3RfY29uc3VtZV9pdGVtLnByb3RvEgp1RnJhbWV3b3JrIkoK",
				"Fk1TVF9RVUVTVF9DT05TVU1FX0lURU0SEAoIcXVlc3RfaWQYASABKAUSEAoI",
				"aXRlbV9pZHMYAiADKAUSDAoEbnVtcxgDIAMoBSJRChxNU1RfUVVFU1RfQ09O",
				"U1VNRV9JVEVNX0FSUkFZEjEKBWl0ZW1zGAEgAygLMiIudUZyYW1ld29yay5N",
				"U1RfUVVFU1RfQ09OU1VNRV9JVEVNYgZwcm90bzM="
			}));
			MstQuestConsumeItemReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_CONSUME_ITEM), MST_QUEST_CONSUME_ITEM.Parser, new string[]
				{
					"QuestId",
					"ItemIds",
					"Nums"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_CONSUME_ITEM_ARRAY), MST_QUEST_CONSUME_ITEM_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
