using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestReflection.descriptor;

		static MstQuestReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3RfcXVlc3QucHJvdG8SCnVGcmFtZXdvcmsiyQQKCU1TVF9RVUVTVBIK",
				"CgJpZBgBIAEoBRIMCgRuYW1lGAIgASgMEhEKCW5hbWVfcnVieRgDIAEoDBIM",
				"CgR0eXBlGAQgASgFEhQKDGNvbnN1bWVfdHlwZRgFIAEoBRITCgthY3RfY29u",
				"c3VtZRgGIAEoBRIdChVjaGFsZGVhX2dhdGVfY2F0ZWdvcnkYByABKAUSDwoH",
				"c3BvdF9pZBgIIAEoBRIPCgdnaWZ0X2lkGAkgASgFEhAKCHByaW9yaXR5GAog",
				"ASgFEhEKCWJhbm5lcl9pZBgLIAEoBRIPCgdpY29uX2lkGAwgASgFEhUKDWNo",
				"YXJhX2ljb25faWQYDSABKAUSFAoMZ2lmdF9pY29uX2lkGA4gASgFEhcKD2Zv",
				"cmNlX29wZXJhdGlvbhgPIAEoBRITCgthZnRlcl9jbGVhchgQIAEoBRIZChFh",
				"ZnRlcl9hY3Rpb25fdmFscxgRIAMoDBIVCg1kaXNwbGF5X2hvdXJzGBIgASgF",
				"EhYKDmludGVydmFsX2hvdXJzGBMgASgFEhIKCmNoYXB0ZXJfaWQYFCABKAUS",
				"FgoOY2hhcHRlcl9zdWJfaWQYFSABKAUSFAoMcmVjb21tZW5kX2x2GBYgASgF",
				"EhgKEGhhc19zdGFydF9hY3Rpb24YFyABKAUSDAoEZmxhZxgYIAEoBRIXCg9z",
				"Y3JpcHRfcXVlc3RfaWQYGSABKAUSEQoJbm90aWNlX2F0GBogASgEEhEKCW9w",
				"ZW5lZF9hdBgbIAEoBBIRCgljbG9zZWRfYXQYHCABKAQiNwoPTVNUX1FVRVNU",
				"X0FSUkFZEiQKBWl0ZW1zGAEgAygLMhUudUZyYW1ld29yay5NU1RfUVVFU1Ri",
				"BnByb3RvMw=="
			}));
			MstQuestReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST), MST_QUEST.Parser, new string[]
				{
					"Id",
					"Name",
					"NameRuby",
					"Type",
					"ConsumeType",
					"ActConsume",
					"ChaldeaGateCategory",
					"SpotId",
					"GiftId",
					"Priority",
					"BannerId",
					"IconId",
					"CharaIconId",
					"GiftIconId",
					"ForceOperation",
					"AfterClear",
					"AfterActionVals",
					"DisplayHours",
					"IntervalHours",
					"ChapterId",
					"ChapterSubId",
					"RecommendLv",
					"HasStartAction",
					"Flag",
					"ScriptQuestId",
					"NoticeAt",
					"OpenedAt",
					"ClosedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_ARRAY), MST_QUEST_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
