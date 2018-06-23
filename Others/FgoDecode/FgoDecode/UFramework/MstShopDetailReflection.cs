using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstShopDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstShopDetailReflection.descriptor;

		static MstShopDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3Rfc2hvcF9kZXRhaWwucHJvdG8SCnVGcmFtZXdvcmsiSwoPTVNUX1NI",
				"T1BfREVUQUlMEg8KB3Nob3BfaWQYASABKAUSDwoHbWVzc2FnZRgCIAEoDBIW",
				"Cg5mcmVxdWVuY3lfdHlwZRgDIAEoBSJDChVNU1RfU0hPUF9ERVRBSUxfQVJS",
				"QVkSKgoFaXRlbXMYASADKAsyGy51RnJhbWV3b3JrLk1TVF9TSE9QX0RFVEFJ",
				"TGIGcHJvdG8z"
			}));
			MstShopDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SHOP_DETAIL), MST_SHOP_DETAIL.Parser, new string[]
				{
					"ShopId",
					"Message",
					"FrequencyType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SHOP_DETAIL_ARRAY), MST_SHOP_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
