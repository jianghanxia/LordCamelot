using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtLimitReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtLimitReflection.descriptor;

		static MstSvtLimitReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3Rfc3Z0X2xpbWl0LnByb3RvEgp1RnJhbWV3b3JrItIDCg1NU1RfU1ZU",
				"X0xJTUlUEg4KBnN2dF9pZBgBIAEoBRITCgtsaW1pdF9jb3VudBgCIAEoBRIO",
				"CgZyYXJpdHkYAyABKAUSDgoGbHZfbWF4GAQgASgFEhQKDHdlYXBvbl9ncm91",
				"cBgFIAEoBRIUCgx3ZWFwb25fc2NhbGUYBiABKAUSFAoMd2VhcG9uX2NvbG9y",
				"GAcgASgMEhUKDWVmZmVjdF9mb2xkZXIYCCABKAUSDwoHaHBfYmFzZRgJIAEo",
				"BRIOCgZocF9tYXgYCiABKAUSEAoIYXRrX2Jhc2UYCyABKAUSDwoHYXRrX21h",
				"eBgMIAEoBRIXCg9jcml0aWNhbF93ZWlnaHQYDSABKAUSDQoFcG93ZXIYDiAB",
				"KAUSDwoHZGVmZW5zZRgPIAEoBRIPCgdhZ2lsaXR5GBAgASgFEg0KBW1hZ2lj",
				"GBEgASgFEgwKBGx1Y2sYEiABKAUSFwoPdHJlYXN1cmVfZGV2aWNlGBMgASgF",
				"Eg4KBnBvbGljeRgUIAEoBRITCgtwZXJzb25hbGl0eRgVIAEoBRINCgVkZWl0",
				"eRgWIAEoBRIYChBzdGVwX3Byb2JhYmlsaXR5GBcgASgFEhEKCXN0cl9wYXJh",
				"bRgYIAEoDCI/ChNNU1RfU1ZUX0xJTUlUX0FSUkFZEigKBWl0ZW1zGAEgAygL",
				"MhkudUZyYW1ld29yay5NU1RfU1ZUX0xJTUlUYgZwcm90bzM="
			}));
			MstSvtLimitReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_LIMIT), MST_SVT_LIMIT.Parser, new string[]
				{
					"SvtId",
					"LimitCount",
					"Rarity",
					"LvMax",
					"WeaponGroup",
					"WeaponScale",
					"WeaponColor",
					"EffectFolder",
					"HpBase",
					"HpMax",
					"AtkBase",
					"AtkMax",
					"CriticalWeight",
					"Power",
					"Defense",
					"Agility",
					"Magic",
					"Luck",
					"TreasureDevice",
					"Policy",
					"Personality",
					"Deity",
					"StepProbability",
					"StrParam"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_LIMIT_ARRAY), MST_SVT_LIMIT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
