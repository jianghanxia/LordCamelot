using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEquipReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEquipReflection.descriptor;

		static MstEquipReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3RfZXF1aXAucHJvdG8SCnVGcmFtZXdvcmsi9QEKCU1TVF9FUVVJUBIK",
				"CgJpZBgBIAEoBRIMCgRuYW1lGAIgASgMEg4KBmRldGFpbBgDIAEoDBIUCgxj",
				"b25kX3VzZXJfbHYYBCABKAUSDgoGbWF4X2x2GAUgASgFEhUKDW1hbGVfaW1h",
				"Z2VfaWQYBiABKAUSFwoPZmVtYWxlX2ltYWdlX2lkGAcgASgFEhAKCGltYWdl",
				"X2lkGAggASgFEhUKDW1hbGVfc3BlbGxfaWQYCSABKAUSFwoPZmVtYWxlX3Nw",
				"ZWxsX2lkGAogASgFEhIKCnVwZGF0ZWRfYXQYCyABKAQSEgoKY3JlYXRlZF9h",
				"dBgMIAEoBCI3Cg9NU1RfRVFVSVBfQVJSQVkSJAoFaXRlbXMYASADKAsyFS51",
				"RnJhbWV3b3JrLk1TVF9FUVVJUGIGcHJvdG8z"
			}));
			MstEquipReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EQUIP), MST_EQUIP.Parser, new string[]
				{
					"Id",
					"Name",
					"Detail",
					"CondUserLv",
					"MaxLv",
					"MaleImageId",
					"FemaleImageId",
					"ImageId",
					"MaleSpellId",
					"FemaleSpellId",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_ARRAY), MST_EQUIP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
