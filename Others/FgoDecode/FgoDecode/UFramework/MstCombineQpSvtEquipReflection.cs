using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCombineQpSvtEquipReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCombineQpSvtEquipReflection.descriptor;

		static MstCombineQpSvtEquipReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ch5tc3RfY29tYmluZV9xcF9zdnRfZXF1aXAucHJvdG8SCnVGcmFtZXdvcmsi",
				"agoYTVNUX0NPTUJJTkVfUVBfU1ZUX0VRVUlQEg4KBnJhcml0eRgBIAEoBRIK",
				"CgJsdhgCIAEoBRIKCgJxcBgDIAEoBRISCgp1cGRhdGVkX2F0GAQgASgEEhIK",
				"CmNyZWF0ZWRfYXQYBSABKAQiVQoeTVNUX0NPTUJJTkVfUVBfU1ZUX0VRVUlQ",
				"X0FSUkFZEjMKBWl0ZW1zGAEgAygLMiQudUZyYW1ld29yay5NU1RfQ09NQklO",
				"RV9RUF9TVlRfRVFVSVBiBnByb3RvMw=="
			}));
			MstCombineQpSvtEquipReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_QP_SVT_EQUIP), MST_COMBINE_QP_SVT_EQUIP.Parser, new string[]
				{
					"Rarity",
					"Lv",
					"Qp",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_QP_SVT_EQUIP_ARRAY), MST_COMBINE_QP_SVT_EQUIP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
