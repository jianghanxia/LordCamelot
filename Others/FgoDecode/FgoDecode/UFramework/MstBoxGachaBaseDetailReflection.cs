using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBoxGachaBaseDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBoxGachaBaseDetailReflection.descriptor;

		static MstBoxGachaBaseDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ch9tc3RfYm94X2dhY2hhX2Jhc2VfZGV0YWlsLnByb3RvEgp1RnJhbWV3b3Jr",
				"ImgKGU1TVF9CT1hfR0FDSEFfQkFTRV9ERVRBSUwSDwoHYmFzZV9pZBgBIAEo",
				"BRISCgpkZXRhaWxfdXJsGAIgASgMEhIKCnVwZGF0ZWRfYXQYAyABKAQSEgoK",
				"Y3JlYXRlZF9hdBgEIAEoBCJXCh9NU1RfQk9YX0dBQ0hBX0JBU0VfREVUQUlM",
				"X0FSUkFZEjQKBWl0ZW1zGAEgAygLMiUudUZyYW1ld29yay5NU1RfQk9YX0dB",
				"Q0hBX0JBU0VfREVUQUlMYgZwcm90bzM="
			}));
			MstBoxGachaBaseDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_BASE_DETAIL), MST_BOX_GACHA_BASE_DETAIL.Parser, new string[]
				{
					"BaseId",
					"DetailUrl",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_BASE_DETAIL_ARRAY), MST_BOX_GACHA_BASE_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
