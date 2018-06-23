using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstTotalLoginReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstTotalLoginReflection.descriptor;

		static MstTotalLoginReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfdG90YWxfbG9naW4ucHJvdG8SCnVGcmFtZXdvcmsiXQoPTVNUX1RP",
				"VEFMX0xPR0lOEhAKCGV2ZW50X2lkGAEgASgFEgsKA2RheRgCIAEoBRIPCgdn",
				"aWZ0X2lkGAMgASgFEhoKEnByZXNlbnRfbWVzc2FnZV9pZBgEIAEoBSJDChVN",
				"U1RfVE9UQUxfTE9HSU5fQVJSQVkSKgoFaXRlbXMYASADKAsyGy51RnJhbWV3",
				"b3JrLk1TVF9UT1RBTF9MT0dJTmIGcHJvdG8z"
			}));
			MstTotalLoginReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_TOTAL_LOGIN), MST_TOTAL_LOGIN.Parser, new string[]
				{
					"EventId",
					"Day",
					"GiftId",
					"PresentMessageId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_TOTAL_LOGIN_ARRAY), MST_TOTAL_LOGIN_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
