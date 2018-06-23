using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEquipImageReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEquipImageReflection.descriptor;

		static MstEquipImageReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfZXF1aXBfaW1hZ2UucHJvdG8SCnVGcmFtZXdvcmsimwEKD01TVF9F",
				"UVVJUF9JTUFHRRIKCgJpZBgBIAEoBRIQCghvZmZzZXRfeBgCIAEoBRIQCghv",
				"ZmZzZXRfeRgDIAEoBRIXCg9vZmZzZXRfeF9teXJvb20YBCABKAUSFwoPb2Zm",
				"c2V0X3lfbXlyb29tGAUgASgFEhIKCnVwZGF0ZWRfYXQYBiABKAQSEgoKY3Jl",
				"YXRlZF9hdBgHIAEoBCJDChVNU1RfRVFVSVBfSU1BR0VfQVJSQVkSKgoFaXRl",
				"bXMYASADKAsyGy51RnJhbWV3b3JrLk1TVF9FUVVJUF9JTUFHRWIGcHJvdG8z"
			}));
			MstEquipImageReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_IMAGE), MST_EQUIP_IMAGE.Parser, new string[]
				{
					"Id",
					"OffsetX",
					"OffsetY",
					"OffsetXMyroom",
					"OffsetYMyroom",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_IMAGE_ARRAY), MST_EQUIP_IMAGE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
