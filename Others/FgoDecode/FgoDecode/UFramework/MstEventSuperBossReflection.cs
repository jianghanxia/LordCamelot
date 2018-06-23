using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventSuperBossReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventSuperBossReflection.descriptor;

		static MstEventSuperBossReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chptc3RfZXZlbnRfc3VwZXJfYm9zcy5wcm90bxIKdUZyYW1ld29yayK6AQoU",
				"TVNUX0VWRU5UX1NVUEVSX0JPU1MSEAoIZXZlbnRfaWQYASABKAUSCgoCaWQY",
				"AiABKAUSDgoGbWF4X2hwGAMgASgDEhcKD3NwbGl0X3F1ZXN0X2lkcxgEIAMo",
				"BRIQCghzcGxpdF9ocBgFIAMoAxIPCgdpY29uX2lkGAYgASgFEhIKCmJvc3Nf",
				"Y29sb3IYByABKAwSEgoKc3RhcnRlZF9hdBgIIAEoBBIQCghlbmRlZF9hdBgJ",
				"IAEoBCJNChpNU1RfRVZFTlRfU1VQRVJfQk9TU19BUlJBWRIvCgVpdGVtcxgB",
				"IAMoCzIgLnVGcmFtZXdvcmsuTVNUX0VWRU5UX1NVUEVSX0JPU1NiBnByb3Rv",
				"Mw=="
			}));
			MstEventSuperBossReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_SUPER_BOSS), MST_EVENT_SUPER_BOSS.Parser, new string[]
				{
					"EventId",
					"Id",
					"MaxHp",
					"SplitQuestIds",
					"SplitHp",
					"IconId",
					"BossColor",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_SUPER_BOSS_ARRAY), MST_EVENT_SUPER_BOSS_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
