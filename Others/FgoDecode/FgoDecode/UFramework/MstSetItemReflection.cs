using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSetItemReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSetItemReflection.descriptor;

		static MstSetItemReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJtc3Rfc2V0X2l0ZW0ucHJvdG8SCnVGcmFtZXdvcmsifQoMTVNUX1NFVF9J",
				"VEVNEgoKAmlkGAEgASgFEhUKDXB1cmNoYXNlX3R5cGUYAiABKAUSEQoJdGFy",
				"Z2V0X2lkGAMgASgFEg8KB3NldF9udW0YBCABKAUSEgoKdXBkYXRlZF9hdBgF",
				"IAEoBBISCgpjcmVhdGVkX2F0GAYgASgEIj0KEk1TVF9TRVRfSVRFTV9BUlJB",
				"WRInCgVpdGVtcxgBIAMoCzIYLnVGcmFtZXdvcmsuTVNUX1NFVF9JVEVNYgZw",
				"cm90bzM="
			}));
			MstSetItemReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SET_ITEM), MST_SET_ITEM.Parser, new string[]
				{
					"Id",
					"PurchaseType",
					"TargetId",
					"SetNum",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SET_ITEM_ARRAY), MST_SET_ITEM_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
