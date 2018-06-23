using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstStageReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstStageReflection.descriptor;

		static MstStageReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3Rfc3RhZ2UucHJvdG8SCnVGcmFtZXdvcmsiowEKCU1TVF9TVEFHRRIQ",
				"CghxdWVzdF9pZBgBIAEoBRITCgtxdWVzdF9waGFzZRgCIAEoBRIMCgR3YXZl",
				"GAMgASgFEg4KBnNjcmlwdBgEIAEoDBIUCgxucGNfZGVja19pZHMYBSADKAMS",
				"EgoKZW5lbXlfaW5mbxgGIAEoBRIOCgZiZ21faWQYByABKAUSFwoPc3RhcnRf",
				"ZWZmZWN0X2lkGAggASgFIjcKD01TVF9TVEFHRV9BUlJBWRIkCgVpdGVtcxgB",
				"IAMoCzIVLnVGcmFtZXdvcmsuTVNUX1NUQUdFYgZwcm90bzM="
			}));
			MstStageReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_STAGE), MST_STAGE.Parser, new string[]
				{
					"QuestId",
					"QuestPhase",
					"Wave",
					"Script",
					"NpcDeckIds",
					"EnemyInfo",
					"BgmId",
					"StartEffectId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_STAGE_ARRAY), MST_STAGE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
