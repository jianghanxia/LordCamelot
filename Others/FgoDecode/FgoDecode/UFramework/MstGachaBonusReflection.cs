using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGachaBonusReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGachaBonusReflection.descriptor;

		static MstGachaBonusReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfZ2FjaGFfYm9udXMucHJvdG8SCnVGcmFtZXdvcmsihQIKD01TVF9H",
				"QUNIQV9CT05VUxIQCghnYWNoYV9pZBgBIAEoBRIKCgJpZBgCIAEoBRIMCgR0",
				"eXBlGAMgASgFEhEKCXRhcmdldF9pZBgEIAEoBRIRCglhZGp1c3RfaWQYBSAB",
				"KAUSDQoFdmFsdWUYBiABKAUSFAoMcmVxdWlyZV9kcmF3GAcgASgFEhoKEnBy",
				"ZXNlbnRfbWVzc2FnZV9pZBgIIAEoBRIRCglyYXJpdHlfaWQYCSABKAUSEQoJ",
				"b3BlbmVkX2F0GAogASgEEhEKCWNsb3NlZF9hdBgLIAEoBBISCgp1cGRhdGVk",
				"X2F0GAwgASgEEhIKCmNyZWF0ZWRfYXQYDSABKAQiQwoVTVNUX0dBQ0hBX0JP",
				"TlVTX0FSUkFZEioKBWl0ZW1zGAEgAygLMhsudUZyYW1ld29yay5NU1RfR0FD",
				"SEFfQk9OVVNiBnByb3RvMw=="
			}));
			MstGachaBonusReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GACHA_BONUS), MST_GACHA_BONUS.Parser, new string[]
				{
					"GachaId",
					"Id",
					"Type",
					"TargetId",
					"AdjustId",
					"Value",
					"RequireDraw",
					"PresentMessageId",
					"RarityId",
					"OpenedAt",
					"ClosedAt",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GACHA_BONUS_ARRAY), MST_GACHA_BONUS_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
