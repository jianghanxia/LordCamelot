using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstTreasureDeviceReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstTreasureDeviceReflection.descriptor;

		static MstTreasureDeviceReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chltc3RfdHJlYXN1cmVfZGV2aWNlLnByb3RvEgp1RnJhbWV3b3JrItMBChNN",
				"U1RfVFJFQVNVUkVfREVWSUNFEgoKAmlkGAEgASgFEg4KBnNlcV9pZBgCIAEo",
				"BRIMCgRuYW1lGAMgASgMEgwKBHJ1YnkYBCABKAwSDAoEcmFuaxgFIAEoDBIO",
				"CgZtYXhfbHYYBiABKAUSEQoJdHlwZV90ZXh0GAcgASgMEhUKDWluZGl2aWR1",
				"YWxpdHkYCCADKAUSFAoMYXR0YWNrX2F0dHJpGAkgASgFEhIKCnVwZGF0ZWRf",
				"YXQYCiABKAQSEgoKY3JlYXRlZF9hdBgLIAEoBCJLChlNU1RfVFJFQVNVUkVf",
				"REVWSUNFX0FSUkFZEi4KBWl0ZW1zGAEgAygLMh8udUZyYW1ld29yay5NU1Rf",
				"VFJFQVNVUkVfREVWSUNFYgZwcm90bzM="
			}));
			MstTreasureDeviceReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_TREASURE_DEVICE), MST_TREASURE_DEVICE.Parser, new string[]
				{
					"Id",
					"SeqId",
					"Name",
					"Ruby",
					"Rank",
					"MaxLv",
					"TypeText",
					"Individuality",
					"AttackAttri",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_TREASURE_DEVICE_ARRAY), MST_TREASURE_DEVICE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
