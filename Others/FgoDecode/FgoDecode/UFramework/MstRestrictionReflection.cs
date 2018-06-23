using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstRestrictionReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstRestrictionReflection.descriptor;

		static MstRestrictionReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfcmVzdHJpY3Rpb24ucHJvdG8SCnVGcmFtZXdvcmsiYgoPTVNUX1JF",
				"U1RSSUNUSU9OEgoKAmlkGAEgASgFEgwKBG5hbWUYAiABKAwSDAoEdHlwZRgD",
				"IAEoBRITCgt0YXJnZXRfdmFscxgEIAMoBRISCgpyYW5nZV90eXBlGAUgASgF",
				"IkMKFU1TVF9SRVNUUklDVElPTl9BUlJBWRIqCgVpdGVtcxgBIAMoCzIbLnVG",
				"cmFtZXdvcmsuTVNUX1JFU1RSSUNUSU9OYgZwcm90bzM="
			}));
			MstRestrictionReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_RESTRICTION), MST_RESTRICTION.Parser, new string[]
				{
					"Id",
					"Name",
					"Type",
					"TargetVals",
					"RangeType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_RESTRICTION_ARRAY), MST_RESTRICTION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
