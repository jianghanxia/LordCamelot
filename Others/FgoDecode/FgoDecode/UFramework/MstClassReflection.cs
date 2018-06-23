using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstClassReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstClassReflection.descriptor;

		static MstClassReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3RfY2xhc3MucHJvdG8SCnVGcmFtZXdvcmsimAEKCU1TVF9DTEFTUxIK",
				"CgJpZBgBIAEoBRINCgVhdHRyaRgCIAEoBRIMCgRuYW1lGAMgASgMEhMKC2F0",
				"dGFja19yYXRlGAQgASgFEhAKCGltYWdlX2lkGAUgASgFEhUKDWljb25faW1h",
				"Z2VfaWQYBiABKAUSEgoKZ3JvdXBfdHlwZRgHIAEoBRIQCghwcmlvcml0eRgI",
				"IAEoBSI3Cg9NU1RfQ0xBU1NfQVJSQVkSJAoFaXRlbXMYASADKAsyFS51RnJh",
				"bWV3b3JrLk1TVF9DTEFTU2IGcHJvdG8z"
			}));
			MstClassReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CLASS), MST_CLASS.Parser, new string[]
				{
					"Id",
					"Attri",
					"Name",
					"AttackRate",
					"ImageId",
					"IconImageId",
					"GroupType",
					"Priority"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CLASS_ARRAY), MST_CLASS_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
