using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestRestrictionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestRestrictionReflection.descriptor;

		static MstQuestRestrictionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chttc3RfcXVlc3RfcmVzdHJpY3Rpb24ucHJvdG8SCnVGcmFtZXdvcmsiQQoV",
				"TVNUX1FVRVNUX1JFU1RSSUNUSU9OEhAKCHF1ZXN0X2lkGAEgASgFEhYKDnJl",
				"c3RyaWN0aW9uX2lkGAIgASgFIk8KG01TVF9RVUVTVF9SRVNUUklDVElPTl9B",
				"UlJBWRIwCgVpdGVtcxgBIAMoCzIhLnVGcmFtZXdvcmsuTVNUX1FVRVNUX1JF",
				"U1RSSUNUSU9OYgZwcm90bzM="
			}));
			MstQuestRestrictionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_RESTRICTION), MST_QUEST_RESTRICTION.Parser, new string[]
				{
					"QuestId",
					"RestrictionId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_RESTRICTION_ARRAY), MST_QUEST_RESTRICTION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
