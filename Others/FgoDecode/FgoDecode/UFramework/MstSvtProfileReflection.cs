using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtProfileReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtProfileReflection.descriptor;

		static MstSvtProfileReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3Rfc3Z0X3Byb2ZpbGUucHJvdG8SCnVGcmFtZXdvcmsicgoPTVNUX1NW",
				"VF9QUk9GSUxFEg4KBnN2dF9pZBgBIAEoBRIWCg5zdnRfY29tbWVudF9pZBgC",
				"IAEoBRIQCghwcmlvcml0eRgDIAEoBRIRCgljb25kX3R5cGUYBCABKAUSEgoK",
				"Y29uZF92YWx1ZRgFIAEoBSJDChVNU1RfU1ZUX1BST0ZJTEVfQVJSQVkSKgoF",
				"aXRlbXMYASADKAsyGy51RnJhbWV3b3JrLk1TVF9TVlRfUFJPRklMRWIGcHJv",
				"dG8z"
			}));
			MstSvtProfileReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_PROFILE), MST_SVT_PROFILE.Parser, new string[]
				{
					"SvtId",
					"SvtCommentId",
					"Priority",
					"CondType",
					"CondValue"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_PROFILE_ARRAY), MST_SVT_PROFILE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
