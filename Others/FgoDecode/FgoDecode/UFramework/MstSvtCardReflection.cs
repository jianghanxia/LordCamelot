using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtCardReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtCardReflection.descriptor;

		static MstSvtCardReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJtc3Rfc3Z0X2NhcmQucHJvdG8SCnVGcmFtZXdvcmsi5QEKDE1TVF9TVlRf",
				"Q0FSRBIOCgZzdnRfaWQYASABKAUSDwoHY2FyZF9pZBgCIAEoBRIOCgZtb3Rp",
				"b24YAyABKAUSFQoNbm9ybWFsX2RhbWFnZRgEIAMoBRIVCg1zaW5nbGVfZGFt",
				"YWdlGAUgAygFEhYKDnRyaW5pdHlfZGFtYWdlGAYgAygFEhUKDXVuaXNvbl9k",
				"YW1hZ2UYByADKAUSFAoMZ3JhbmRfZGFtYWdlGAggAygFEhMKC2F0dGFja190",
				"eXBlGAkgASgFEhwKFGF0dGFja19pbmRpdmlkdWFsaXR5GAogAygFIj0KEk1T",
				"VF9TVlRfQ0FSRF9BUlJBWRInCgVpdGVtcxgBIAMoCzIYLnVGcmFtZXdvcmsu",
				"TVNUX1NWVF9DQVJEYgZwcm90bzM="
			}));
			MstSvtCardReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_CARD), MST_SVT_CARD.Parser, new string[]
				{
					"SvtId",
					"CardId",
					"Motion",
					"NormalDamage",
					"SingleDamage",
					"TrinityDamage",
					"UnisonDamage",
					"GrandDamage",
					"AttackType",
					"AttackIndividuality"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_CARD_ARRAY), MST_SVT_CARD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
