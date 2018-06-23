using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventQuestReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventQuestReflection.descriptor;

		static MstEventQuestReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfZXZlbnRfcXVlc3QucHJvdG8SCnVGcmFtZXdvcmsibAoPTVNUX0VW",
				"RU5UX1FVRVNUEhAKCGV2ZW50X2lkGAEgASgFEhAKCHF1ZXN0X2lkGAIgASgF",
				"Eg0KBXBoYXNlGAMgASgFEhIKCnVwZGF0ZWRfYXQYBCABKAQSEgoKY3JlYXRl",
				"ZF9hdBgFIAEoBCJDChVNU1RfRVZFTlRfUVVFU1RfQVJSQVkSKgoFaXRlbXMY",
				"ASADKAsyGy51RnJhbWV3b3JrLk1TVF9FVkVOVF9RVUVTVGIGcHJvdG8z"
			}));
			MstEventQuestReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_QUEST), MST_EVENT_QUEST.Parser, new string[]
				{
					"EventId",
					"QuestId",
					"Phase",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_QUEST_ARRAY), MST_EVENT_QUEST_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
