using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtReflection.descriptor;

		static MstSvtReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg1tc3Rfc3Z0LnByb3RvEgp1RnJhbWV3b3JrIpkFCgdNU1RfU1ZUEgoKAmlk",
				"GAEgASgFEhMKC2Jhc2Vfc3Z0X2lkGAIgASgFEgwKBG5hbWUYAyABKAwSDAoE",
				"cnVieRgEIAEoDBITCgtiYXR0bGVfbmFtZRgFIAEoDBIQCghjbGFzc19pZBgG",
				"IAEoBRIMCgR0eXBlGAcgASgFEhEKCWxpbWl0X21heBgIIAEoBRIRCglyZXdh",
				"cmRfbHYYCSABKAUSFQoNZnJpZW5kc2hpcF9pZBgKIAEoBRIbChNtYXhfZnJp",
				"ZW5kc2hpcF9yYW5rGAsgASgFEhMKC2dlbmRlcl90eXBlGAwgASgFEg0KBWF0",
				"dHJpGA0gASgFEhgKEGNvbWJpbmVfc2tpbGxfaWQYDiABKAUSGAoQY29tYmlu",
				"ZV9saW1pdF9pZBgPIAEoBRIPCgdzZWxsX3FwGBAgASgFEhEKCXNlbGxfbWFu",
				"YRgRIAEoBRIVCg1zZWxsX3JhcmVfcHJpGBIgASgFEhAKCGV4cF90eXBlGBMg",
				"ASgFEhsKE2NvbWJpbmVfbWF0ZXJpYWxfaWQYFCABKAUSEAoIY2FyZF9pZHMY",
				"FSADKAUSDAoEY29zdBgWIAEoBRITCgtiYXR0bGVfc2l6ZRgXIAEoBRISCgpo",
				"cF9nYXVnZV95GBggASgFEhUKDWNsYXNzX3Bhc3NpdmUYGSADKAUSFQoNaW5k",
				"aXZpZHVhbGl0eRgaIAMoBRIRCglzdGFyX3JhdGUYGyABKAUSEgoKZGVhdGhf",
				"cmF0ZRgcIAEoBRIUCgxhdHRhY2tfYXR0cmkYHSABKAUSDgoGc2NyaXB0GB4g",
				"ASgMEhYKDmlsbHVzdHJhdG9yX2lkGB8gASgFEg0KBWN2X2lkGCAgASgFEhUK",
				"DWNvbGxlY3Rpb25fbm8YISABKAUiMwoNTVNUX1NWVF9BUlJBWRIiCgVpdGVt",
				"cxgBIAMoCzITLnVGcmFtZXdvcmsuTVNUX1NWVGIGcHJvdG8z"
			}));
			MstSvtReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT), MST_SVT.Parser, new string[]
				{
					"Id",
					"BaseSvtId",
					"Name",
					"Ruby",
					"BattleName",
					"ClassId",
					"Type",
					"LimitMax",
					"RewardLv",
					"FriendshipId",
					"MaxFriendshipRank",
					"GenderType",
					"Attri",
					"CombineSkillId",
					"CombineLimitId",
					"SellQp",
					"SellMana",
					"SellRarePri",
					"ExpType",
					"CombineMaterialId",
					"CardIds",
					"Cost",
					"BattleSize",
					"HpGaugeY",
					"ClassPassive",
					"Individuality",
					"StarRate",
					"DeathRate",
					"AttackAttri",
					"Script",
					"IllustratorId",
					"CvId",
					"CollectionNo"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_ARRAY), MST_SVT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
