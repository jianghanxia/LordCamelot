using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtScriptReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtScriptReflection.descriptor;

		static MstSvtScriptReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3Rfc3Z0X3NjcmlwdC5wcm90bxIKdUZyYW1ld29yayLPAQoOTVNUX1NW",
				"VF9TQ1JJUFQSDgoGc3Z0X2lkGAEgASgFEhMKC2xpbWl0X2NvdW50GAIgASgF",
				"Eg4KBmZhY2VfeBgDIAEoBRIOCgZmYWNlX3kYBCABKAUSEwoLYmdfaW1hZ2Vf",
				"aWQYBSABKAUSDQoFc2NhbGUYBiABKAISEAoIb2Zmc2V0X3gYByABKAUSEAoI",
				"b2Zmc2V0X3kYCCABKAUSFwoPb2Zmc2V0X3hfbXlyb29tGAkgASgFEhcKD29m",
				"ZnNldF95X215cm9vbRgKIAEoBSJBChRNU1RfU1ZUX1NDUklQVF9BUlJBWRIp",
				"CgVpdGVtcxgBIAMoCzIaLnVGcmFtZXdvcmsuTVNUX1NWVF9TQ1JJUFRiBnBy",
				"b3RvMw=="
			}));
			MstSvtScriptReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_SCRIPT), MST_SVT_SCRIPT.Parser, new string[]
				{
					"SvtId",
					"LimitCount",
					"FaceX",
					"FaceY",
					"BgImageId",
					"Scale",
					"OffsetX",
					"OffsetY",
					"OffsetXMyroom",
					"OffsetYMyroom"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_SCRIPT_ARRAY), MST_SVT_SCRIPT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
