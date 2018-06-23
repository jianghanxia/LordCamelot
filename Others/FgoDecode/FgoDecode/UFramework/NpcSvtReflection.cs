using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class NpcSvtReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => NpcSvtReflection.descriptor;

		static NpcSvtReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg1ucGNfc3Z0LnByb3RvEgp1RnJhbWV3b3JrIpIFCgdOUENfU1ZUEgoKAmlk",
				"GAEgASgFEg4KBnN2dF9pZBgCIAEoBRIMCgRuYW1lGAMgASgMEgoKAmx2GAQg",
				"ASgFEhMKC2xpbWl0X2NvdW50GAUgASgFEgoKAmhwGAYgASgFEgsKA2F0axgH",
				"IAEoBRIVCg1pbmRpdmlkdWFsaXR5GAggAygDEhUKDWNyaXRpY2FsX3JhdGUY",
				"CSABKAUSEQoJc3Rhcl9yYXRlGAogASgFEg8KB3RkX3JhdGUYCyABKAUSFgoO",
				"dGRfYXR0YWNrX3JhdGUYDCABKAUSEgoKZGVhdGhfcmF0ZRgNIAEoBRIQCghk",
				"cm9wX2lkcxgOIAMoAxIaChJ0cmVhc3VyZV9kZXZpY2VfaWQYDyABKAUSGgoS",
				"dHJlYXN1cmVfZGV2aWNlX2x2GBAgASgFEhUKDXBhc3NpdmVfc2tpbGwYESAD",
				"KAMSDQoFYWlfaWQYEiABKAUSEwoLY2hhcmdlX3R1cm4YEyABKAUSFAoMYWN0",
				"X3ByaW9yaXR5GBQgASgFEhMKC21heF9hY3RfbnVtGBUgASgFEhEKCXNraWxs",
				"X2lkMRgWIAEoBRIRCglza2lsbF9pZDIYFyABKAUSEQoJc2tpbGxfaWQzGBgg",
				"ASgFEhEKCXNraWxsX2x2MRgZIAEoBRIRCglza2lsbF9sdjIYGiABKAUSEQoJ",
				"c2tpbGxfbHYzGBsgASgFEhUKDWhwX2dhdWdlX3R5cGUYHCABKAUSFAoMbnBj",
				"X3N2dF90eXBlGB0gASgFEhgKEG5wY19zdnRfY2xhc3NfaWQYHiABKAUSFAoM",
				"ZGlzcGxheV90eXBlGB8gASgFEhIKCnVwZGF0ZWRfYXQYICABKAUSEgoKY3Jl",
				"YXRlZF9hdBghIAEoBSIzCg1OUENfU1ZUX0FSUkFZEiIKBWl0ZW1zGAEgAygL",
				"MhMudUZyYW1ld29yay5OUENfU1ZUYgZwcm90bzM="
			}));
			NpcSvtReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NPC_SVT), NPC_SVT.Parser, new string[]
				{
					"Id",
					"SvtId",
					"Name",
					"Lv",
					"LimitCount",
					"Hp",
					"Atk",
					"Individuality",
					"CriticalRate",
					"StarRate",
					"TdRate",
					"TdAttackRate",
					"DeathRate",
					"DropIds",
					"TreasureDeviceId",
					"TreasureDeviceLv",
					"PassiveSkill",
					"AiId",
					"ChargeTurn",
					"ActPriority",
					"MaxActNum",
					"SkillId1",
					"SkillId2",
					"SkillId3",
					"SkillLv1",
					"SkillLv2",
					"SkillLv3",
					"HpGaugeType",
					"NpcSvtType",
					"NpcSvtClassId",
					"DisplayType",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(NPC_SVT_ARRAY), NPC_SVT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
