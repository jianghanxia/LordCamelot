using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstUserExpReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstUserExpReflection.descriptor;

		static MstUserExpReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJtc3RfdXNlcl9leHAucHJvdG8SCnVGcmFtZXdvcmsijAEKDE1TVF9VU0VS",
				"X0VYUBIKCgJsdhgBIAEoBRILCgNleHAYAiABKAUSEwoLYWRkX2FjdF9tYXgY",
				"AyABKAUSFgoOYWRkX2ZyaWVuZF9tYXgYBCABKAUSFAoMYWRkX2Nvc3RfbWF4",
				"GAUgASgFEg8KB2dpZnRfaWQYBiABKAUSDwoHY29tbWVudBgHIAEoDCI9ChJN",
				"U1RfVVNFUl9FWFBfQVJSQVkSJwoFaXRlbXMYASADKAsyGC51RnJhbWV3b3Jr",
				"Lk1TVF9VU0VSX0VYUGIGcHJvdG8z"
			}));
			MstUserExpReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_USER_EXP), MST_USER_EXP.Parser, new string[]
				{
					"Lv",
					"Exp",
					"AddActMax",
					"AddFriendMax",
					"AddCostMax",
					"GiftId",
					"Comment"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_USER_EXP_ARRAY), MST_USER_EXP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
