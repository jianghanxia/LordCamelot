using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGuideReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGuideReflection.descriptor;

		static MstGuideReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3RfZ3VpZGUucHJvdG8SCnVGcmFtZXdvcmsilQEKCU1TVF9HVUlERRIS",
				"CgpndWlkZV90eXBlGAEgASgFEhAKCHByaW9yaXR5GAIgASgFEhYKDmd1aWRl",
				"X2ltYWdlX2lkGAMgASgFEhkKEWd1aWRlX2xpbWl0X2NvdW50GAQgASgFEhUK",
				"DWNvbmRfcXVlc3RfaWQYBSABKAUSGAoQY29uZF9xdWVzdF9waGFzZRgGIAEo",
				"BSI3Cg9NU1RfR1VJREVfQVJSQVkSJAoFaXRlbXMYASADKAsyFS51RnJhbWV3",
				"b3JrLk1TVF9HVUlERWIGcHJvdG8z"
			}));
			MstGuideReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GUIDE), MST_GUIDE.Parser, new string[]
				{
					"GuideType",
					"Priority",
					"GuideImageId",
					"GuideLimitCount",
					"CondQuestId",
					"CondQuestPhase"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GUIDE_ARRAY), MST_GUIDE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
