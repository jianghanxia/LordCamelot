using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSpotImageReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSpotImageReflection.descriptor;

		static MstSpotImageReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3Rfc3BvdF9pbWFnZS5wcm90bxIKdUZyYW1ld29yayKQAQoOTVNUX1NQ",
				"T1RfSU1BR0USDwoHc3BvdF9pZBgBIAEoBRIQCghwcmlvcml0eRgCIAEoBRIQ",
				"CghpbWFnZV9pZBgDIAEoBRIWCg5kaXNwX2NvbmRfdHlwZRgEIAEoBRIWCg5k",
				"aXNwX3RhcmdldF9pZBgFIAEoBRIZChFkaXNwX3RhcmdldF92YWx1ZRgGIAEo",
				"BSJBChRNU1RfU1BPVF9JTUFHRV9BUlJBWRIpCgVpdGVtcxgBIAMoCzIaLnVG",
				"cmFtZXdvcmsuTVNUX1NQT1RfSU1BR0ViBnByb3RvMw=="
			}));
			MstSpotImageReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SPOT_IMAGE), MST_SPOT_IMAGE.Parser, new string[]
				{
					"SpotId",
					"Priority",
					"ImageId",
					"DispCondType",
					"DispTargetId",
					"DispTargetValue"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SPOT_IMAGE_ARRAY), MST_SPOT_IMAGE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
