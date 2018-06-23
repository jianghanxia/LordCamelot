using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstShopScriptReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstShopScriptReflection.descriptor;

		static MstShopScriptReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3Rfc2hvcF9zY3JpcHQucHJvdG8SCnVGcmFtZXdvcmsidwoPTVNUX1NI",
				"T1BfU0NSSVBUEg8KB3Nob3BfaWQYASABKAUSEAoIcHJpb3JpdHkYAiABKAUS",
				"DAoEbmFtZRgDIAEoDBIRCglzY3JpcHRfaWQYBCABKAQSEAoIZXZlbnRfaWQY",
				"BSABKAUSDgoGc3Z0X2lkGAYgASgFIkMKFU1TVF9TSE9QX1NDUklQVF9BUlJB",
				"WRIqCgVpdGVtcxgBIAMoCzIbLnVGcmFtZXdvcmsuTVNUX1NIT1BfU0NSSVBU",
				"YgZwcm90bzM="
			}));
			MstShopScriptReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SHOP_SCRIPT), MST_SHOP_SCRIPT.Parser, new string[]
				{
					"ShopId",
					"Priority",
					"Name",
					"ScriptId",
					"EventId",
					"SvtId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SHOP_SCRIPT_ARRAY), MST_SHOP_SCRIPT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
