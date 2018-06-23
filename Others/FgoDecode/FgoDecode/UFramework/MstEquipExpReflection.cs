using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEquipExpReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEquipExpReflection.descriptor;

		static MstEquipExpReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3RfZXF1aXBfZXhwLnByb3RvEgp1RnJhbWV3b3JrIpsBCg1NU1RfRVFV",
				"SVBfRVhQEhAKCGVxdWlwX2lkGAEgASgFEgoKAmx2GAIgASgFEgsKA2V4cBgD",
				"IAEoBRIRCglza2lsbF9sdjEYBCABKAUSEQoJc2tpbGxfbHYyGAUgASgFEhEK",
				"CXNraWxsX2x2MxgGIAEoBRISCgp1cGRhdGVkX2F0GAcgASgEEhIKCmNyZWF0",
				"ZWRfYXQYCCABKAQiPwoTTVNUX0VRVUlQX0VYUF9BUlJBWRIoCgVpdGVtcxgB",
				"IAMoCzIZLnVGcmFtZXdvcmsuTVNUX0VRVUlQX0VYUGIGcHJvdG8z"
			}));
			MstEquipExpReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_EXP), MST_EQUIP_EXP.Parser, new string[]
				{
					"EquipId",
					"Lv",
					"Exp",
					"SkillLv1",
					"SkillLv2",
					"SkillLv3",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EQUIP_EXP_ARRAY), MST_EQUIP_EXP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
