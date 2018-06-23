using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventLoginCampaignReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventLoginCampaignReflection.descriptor;

		static MstEventLoginCampaignReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ch5tc3RfZXZlbnRfbG9naW5fY2FtcGFpZ24ucHJvdG8SCnVGcmFtZXdvcmsi",
				"ZgoYTVNUX0VWRU5UX0xPR0lOX0NBTVBBSUdOEhAKCGV2ZW50X2lkGAEgASgF",
				"EgsKA2RheRgCIAEoBRIPCgdnaWZ0X2lkGAMgASgFEhoKEnByZXNlbnRfbWVz",
				"c2FnZV9pZBgEIAEoBSJVCh5NU1RfRVZFTlRfTE9HSU5fQ0FNUEFJR05fQVJS",
				"QVkSMwoFaXRlbXMYASADKAsyJC51RnJhbWV3b3JrLk1TVF9FVkVOVF9MT0dJ",
				"Tl9DQU1QQUlHTmIGcHJvdG8z"
			}));
			MstEventLoginCampaignReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_LOGIN_CAMPAIGN), MST_EVENT_LOGIN_CAMPAIGN.Parser, new string[]
				{
					"EventId",
					"Day",
					"GiftId",
					"PresentMessageId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_LOGIN_CAMPAIGN_ARRAY), MST_EVENT_LOGIN_CAMPAIGN_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
