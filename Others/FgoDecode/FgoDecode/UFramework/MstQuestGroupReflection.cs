using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestGroupReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestGroupReflection.descriptor;

		static MstQuestGroupReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfcXVlc3RfZ3JvdXAucHJvdG8SCnVGcmFtZXdvcmsiQwoPTVNUX1FV",
				"RVNUX0dST1VQEhAKCHF1ZXN0X2lkGAEgASgFEgwKBHR5cGUYAiABKAUSEAoI",
				"Z3JvdXBfaWQYAyABKAUiQwoVTVNUX1FVRVNUX0dST1VQX0FSUkFZEioKBWl0",
				"ZW1zGAEgAygLMhsudUZyYW1ld29yay5NU1RfUVVFU1RfR1JPVVBiBnByb3Rv",
				"Mw=="
			}));
			MstQuestGroupReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_GROUP), MST_QUEST_GROUP.Parser, new string[]
				{
					"QuestId",
					"Type",
					"GroupId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_GROUP_ARRAY), MST_QUEST_GROUP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
