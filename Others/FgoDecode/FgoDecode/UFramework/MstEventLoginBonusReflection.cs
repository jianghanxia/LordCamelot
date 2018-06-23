using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventLoginBonusReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventLoginBonusReflection.descriptor;

		static MstEventLoginBonusReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chttc3RfZXZlbnRfbG9naW5fYm9udXMucHJvdG8SCnVGcmFtZXdvcmsidAoV",
				"TVNUX0VWRU5UX0xPR0lOX0JPTlVTEhAKCGV2ZW50X2lkGAEgASgFEgsKA2Rh",
				"eRgCIAEoBRIPCgdnaWZ0X2lkGAMgASgFEg8KB21lc3NhZ2UYBCABKAwSGgoS",
				"cHJlc2VudF9tZXNzYWdlX2lkGAUgASgFIk8KG01TVF9FVkVOVF9MT0dJTl9C",
				"T05VU19BUlJBWRIwCgVpdGVtcxgBIAMoCzIhLnVGcmFtZXdvcmsuTVNUX0VW",
				"RU5UX0xPR0lOX0JPTlVTYgZwcm90bzM="
			}));
			MstEventLoginBonusReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_LOGIN_BONUS), MST_EVENT_LOGIN_BONUS.Parser, new string[]
				{
					"EventId",
					"Day",
					"GiftId",
					"Message",
					"PresentMessageId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_LOGIN_BONUS_ARRAY), MST_EVENT_LOGIN_BONUS_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
