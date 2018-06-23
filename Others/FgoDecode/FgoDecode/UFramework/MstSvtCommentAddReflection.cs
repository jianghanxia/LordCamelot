using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtCommentAddReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtCommentAddReflection.descriptor;

		static MstSvtCommentAddReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chltc3Rfc3Z0X2NvbW1lbnRfYWRkLnByb3RvEgp1RnJhbWV3b3JrIn8KE01T",
				"VF9TVlRfQ09NTUVOVF9BREQSDgoGc3Z0X2lkGAEgASgFEgoKAmlkGAIgASgF",
				"EhAKCHByaW9yaXR5GAMgASgFEhEKCWNvbmRfdHlwZRgEIAEoBRISCgpjb25k",
				"X3ZhbHVlGAUgASgFEhMKC2NvbmRfdmFsdWUyGAYgASgFIksKGU1TVF9TVlRf",
				"Q09NTUVOVF9BRERfQVJSQVkSLgoFaXRlbXMYASADKAsyHy51RnJhbWV3b3Jr",
				"Lk1TVF9TVlRfQ09NTUVOVF9BRERiBnByb3RvMw=="
			}));
			MstSvtCommentAddReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_COMMENT_ADD), MST_SVT_COMMENT_ADD.Parser, new string[]
				{
					"SvtId",
					"Id",
					"Priority",
					"CondType",
					"CondValue",
					"CondValue2"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_COMMENT_ADD_ARRAY), MST_SVT_COMMENT_ADD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
