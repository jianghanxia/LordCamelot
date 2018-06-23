using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstShopReleaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstShopReleaseReflection.descriptor;

		static MstShopReleaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZtc3Rfc2hvcF9yZWxlYXNlLnByb3RvEgp1RnJhbWV3b3JrIqEBChBNU1Rf",
				"U0hPUF9SRUxFQVNFEg8KB3Nob3BfaWQYASABKAUSEQoJY29uZF90eXBlGAIg",
				"ASgFEhIKCmNvbmRfdmFsdWUYAyABKAUSEwoLY29uZF92YWx1ZXMYBCADKAUS",
				"EAoIY29uZF9udW0YBSABKAUSFgoOaXNfY2xvc2VkX2Rpc3AYBiABKAUSFgoO",
				"Y2xvc2VkX21lc3NhZ2UYByABKAwiRQoWTVNUX1NIT1BfUkVMRUFTRV9BUlJB",
				"WRIrCgVpdGVtcxgBIAMoCzIcLnVGcmFtZXdvcmsuTVNUX1NIT1BfUkVMRUFT",
				"RWIGcHJvdG8z"
			}));
			MstShopReleaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SHOP_RELEASE), MST_SHOP_RELEASE.Parser, new string[]
				{
					"ShopId",
					"CondType",
					"CondValue",
					"CondValues",
					"CondNum",
					"IsClosedDisp",
					"ClosedMessage"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SHOP_RELEASE_ARRAY), MST_SHOP_RELEASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
