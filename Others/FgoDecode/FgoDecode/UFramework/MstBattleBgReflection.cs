using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBattleBgReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBattleBgReflection.descriptor;

		static MstBattleBgReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3RfYmF0dGxlX2JnLnByb3RvEgp1RnJhbWV3b3JrIk0KDU1TVF9CQVRU",
				"TEVfQkcSCgoCaWQYASABKAUSDAoEdHlwZRgCIAEoBRIQCghpbWFnZV9pZBgD",
				"IAEoBRIQCghwcmlvcml0eRgEIAEoBSI/ChNNU1RfQkFUVExFX0JHX0FSUkFZ",
				"EigKBWl0ZW1zGAEgAygLMhkudUZyYW1ld29yay5NU1RfQkFUVExFX0JHYgZw",
				"cm90bzM="
			}));
			MstBattleBgReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BATTLE_BG), MST_BATTLE_BG.Parser, new string[]
				{
					"Id",
					"Type",
					"ImageId",
					"Priority"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BATTLE_BG_ARRAY), MST_BATTLE_BG_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
