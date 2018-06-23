using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCombineMaterialReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCombineMaterialReflection.descriptor;

		static MstCombineMaterialReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chptc3RfY29tYmluZV9tYXRlcmlhbC5wcm90bxIKdUZyYW1ld29yayJlChRN",
				"U1RfQ09NQklORV9NQVRFUklBTBIKCgJpZBgBIAEoBRIKCgJsdhgCIAEoBRIN",
				"CgV2YWx1ZRgDIAEoBRISCgp1cGRhdGVkX2F0GAQgASgEEhIKCmNyZWF0ZWRf",
				"YXQYBSABKAQiTQoaTVNUX0NPTUJJTkVfTUFURVJJQUxfQVJSQVkSLwoFaXRl",
				"bXMYASADKAsyIC51RnJhbWV3b3JrLk1TVF9DT01CSU5FX01BVEVSSUFMYgZw",
				"cm90bzM="
			}));
			MstCombineMaterialReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_MATERIAL), MST_COMBINE_MATERIAL.Parser, new string[]
				{
					"Id",
					"Lv",
					"Value",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_MATERIAL_ARRAY), MST_COMBINE_MATERIAL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
