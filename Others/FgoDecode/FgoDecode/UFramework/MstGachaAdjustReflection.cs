using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGachaAdjustReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGachaAdjustReflection.descriptor;

		static MstGachaAdjustReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChZtc3RfZ2FjaGFfYWRqdXN0LnByb3RvEgp1RnJhbWV3b3JrIj0KEE1TVF9H" + "QUNIQV9BREpVU1QSCgoCaWQYASABKAUSDAoEdHlwZRgCIAEoBRIPCgdnaWZ0" + "X2lkGAMgASgFIkUKFk1TVF9HQUNIQV9BREpVU1RfQVJSQVkSKwoFaXRlbXMY" + "ASADKAsyHC51RnJhbWV3b3JrLk1TVF9HQUNIQV9BREpVU1RiBnByb3RvMw==");
			MstGachaAdjustReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GACHA_ADJUST), MST_GACHA_ADJUST.Parser, new string[]
				{
					"Id",
					"Type",
					"GiftId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GACHA_ADJUST_ARRAY), MST_GACHA_ADJUST_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
