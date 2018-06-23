using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventCampaignReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventCampaignReflection.descriptor;

		static MstEventCampaignReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfZXZlbnRfY2FtcGFpZ24ucHJvdG8SCnVGcmFtZXdvcmsiogEKEk1T",
				"VF9FVkVOVF9DQU1QQUlHThIQCghldmVudF9pZBgBIAEoBRIOCgZ0YXJnZXQY",
				"AiABKAUSDwoHdGFyZ2V0MhgDIAEoBRINCgV2YWx1ZRgEIAEoBRIRCgljYWxj",
				"X3R5cGUYBSABKAUSDwoHd2FyX2lkcxgGIAMoBRISCgp1cGRhdGVkX2F0GAcg",
				"ASgEEhIKCmNyZWF0ZWRfYXQYCCABKAQiSQoYTVNUX0VWRU5UX0NBTVBBSUdO",
				"X0FSUkFZEi0KBWl0ZW1zGAEgAygLMh4udUZyYW1ld29yay5NU1RfRVZFTlRf",
				"Q0FNUEFJR05iBnByb3RvMw=="
			}));
			MstEventCampaignReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_CAMPAIGN), MST_EVENT_CAMPAIGN.Parser, new string[]
				{
					"EventId",
					"Target",
					"Target2",
					"Value",
					"CalcType",
					"WarIds",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_CAMPAIGN_ARRAY), MST_EVENT_CAMPAIGN_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
