using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBoxGachaBaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBoxGachaBaseReflection.descriptor;

		static MstBoxGachaBaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfYm94X2dhY2hhX2Jhc2UucHJvdG8SCnVGcmFtZXdvcmsi3QEKEk1T",
				"VF9CT1hfR0FDSEFfQkFTRRIKCgJpZBgBIAEoBRIKCgJubxgCIAEoBRIMCgR0",
				"eXBlGAMgASgFEhEKCXRhcmdldF9pZBgEIAEoBRIPCgdpc19yYXJlGAUgASgF",
				"Eg8KB2ljb25faWQYBiABKAUSEQoJYmFubmVyX2lkGAcgASgFEhAKCHByaW9y",
				"aXR5GAggASgFEg8KB21heF9udW0YCSABKAUSDgoGZGV0YWlsGAogASgMEhIK",
				"CnVwZGF0ZWRfYXQYCyABKAQSEgoKY3JlYXRlZF9hdBgMIAEoBCJJChhNU1Rf",
				"Qk9YX0dBQ0hBX0JBU0VfQVJSQVkSLQoFaXRlbXMYASADKAsyHi51RnJhbWV3",
				"b3JrLk1TVF9CT1hfR0FDSEFfQkFTRWIGcHJvdG8z"
			}));
			MstBoxGachaBaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_BASE), MST_BOX_GACHA_BASE.Parser, new string[]
				{
					"Id",
					"No",
					"Type",
					"TargetId",
					"IsRare",
					"IconId",
					"BannerId",
					"Priority",
					"MaxNum",
					"Detail",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_BASE_ARRAY), MST_BOX_GACHA_BASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
