using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtCommentReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtCommentReflection.descriptor;

		static MstSvtCommentReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3Rfc3Z0X2NvbW1lbnQucHJvdG8SCnVGcmFtZXdvcmsiogEKD01TVF9T",
				"VlRfQ09NTUVOVBIOCgZzdnRfaWQYASABKAUSCgoCaWQYAiABKAUSEAoIcHJp",
				"b3JpdHkYAyABKAUSFAoMY29uZF9tZXNzYWdlGAQgASgMEg8KB2NvbW1lbnQY",
				"BSABKAwSEQoJY29uZF90eXBlGAYgASgFEhIKCmNvbmRfdmFsdWUYByABKAUS",
				"EwoLY29uZF92YWx1ZTIYCCABKAUiQwoVTVNUX1NWVF9DT01NRU5UX0FSUkFZ",
				"EioKBWl0ZW1zGAEgAygLMhsudUZyYW1ld29yay5NU1RfU1ZUX0NPTU1FTlRi",
				"BnByb3RvMw=="
			}));
			MstSvtCommentReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_COMMENT), MST_SVT_COMMENT.Parser, new string[]
				{
					"SvtId",
					"Id",
					"Priority",
					"CondMessage",
					"Comment",
					"CondType",
					"CondValue",
					"CondValue2"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_COMMENT_ARRAY), MST_SVT_COMMENT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
