using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGameIllustrationReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGameIllustrationReflection.descriptor;

		static MstGameIllustrationReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chttc3RfZ2FtZV9pbGx1c3RyYXRpb24ucHJvdG8SCnVGcmFtZXdvcmsiagoV",
				"TVNUX0dBTUVfSUxMVVNUUkFUSU9OEhIKCnRpdGxlX25hbWUYASABKAwSDAoE",
				"dHlwZRgCIAEoBRILCgNudW0YAyABKAUSEgoKbGFiZWxfbmFtZRgEIAEoDBIO",
				"CgZkZXRpYWwYBSABKAwiTwobTVNUX0dBTUVfSUxMVVNUUkFUSU9OX0FSUkFZ",
				"EjAKBWl0ZW1zGAEgAygLMiEudUZyYW1ld29yay5NU1RfR0FNRV9JTExVU1RS",
				"QVRJT05iBnByb3RvMw=="
			}));
			MstGameIllustrationReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GAME_ILLUSTRATION), MST_GAME_ILLUSTRATION.Parser, new string[]
				{
					"TitleName",
					"Type",
					"Num",
					"LabelName",
					"Detial"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GAME_ILLUSTRATION_ARRAY), MST_GAME_ILLUSTRATION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
