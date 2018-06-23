using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class NpcSvtFollowerReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => NpcSvtFollowerReflection.descriptor;

		static NpcSvtFollowerReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZucGNfc3Z0X2ZvbGxvd2VyLnByb3RvEgp1RnJhbWV3b3JrIu0CChBOUENf",
				"U1ZUX0ZPTExPV0VSEgoKAmlkGAEgASgFEg4KBnN2dF9pZBgCIAEoBRIMCgRu",
				"YW1lGAMgASgMEgoKAmx2GAQgASgFEhMKC2xpbWl0X2NvdW50GAUgASgFEgoK",
				"AmhwGAYgASgFEgsKA2F0axgHIAEoBRIVCg1wYXNzaXZlX3NraWxsGAggAygF",
				"EhoKEnRyZWFzdXJlX2RldmljZV9pZBgJIAEoBRIaChJ0cmVhc3VyZV9kZXZp",
				"Y2VfbHYYCiABKAUSEQoJc2tpbGxfaWQxGAsgASgFEhEKCXNraWxsX2lkMhgM",
				"IAEoBRIRCglza2lsbF9pZDMYDSABKAUSEQoJc2tpbGxfbHYxGA4gASgFEhEK",
				"CXNraWxsX2x2MhgPIAEoBRIRCglza2lsbF9sdjMYECABKAUSDAoEZmxhZxgR",
				"IAEoBRISCgp1cGRhdGVkX2F0GBIgASgEEhIKCmNyZWF0ZWRfYXQYEyABKAQi",
				"RQoWTlBDX1NWVF9GT0xMT1dFUl9BUlJBWRIrCgVpdGVtcxgBIAMoCzIcLnVG",
				"cmFtZXdvcmsuTlBDX1NWVF9GT0xMT1dFUmIGcHJvdG8z"
			}));
			NpcSvtFollowerReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NPC_SVT_FOLLOWER), NPC_SVT_FOLLOWER.Parser, new string[]
				{
					"Id",
					"SvtId",
					"Name",
					"Lv",
					"LimitCount",
					"Hp",
					"Atk",
					"PassiveSkill",
					"TreasureDeviceId",
					"TreasureDeviceLv",
					"SkillId1",
					"SkillId2",
					"SkillId3",
					"SkillLv1",
					"SkillLv2",
					"SkillLv3",
					"Flag",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(NPC_SVT_FOLLOWER_ARRAY), NPC_SVT_FOLLOWER_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
