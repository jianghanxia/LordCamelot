using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtExceedReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtExceedReflection.descriptor;

		static MstSvtExceedReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3Rfc3Z0X2V4Y2VlZC5wcm90bxIKdUZyYW1ld29yayJqCg5NU1RfU1ZU",
				"X0VYQ0VFRBIOCgZyYXJpdHkYASABKAUSFAoMZXhjZWVkX2NvdW50GAIgASgF",
				"EgoKAnFwGAMgASgFEhIKCmFkZF9sdl9tYXgYBCABKAUSEgoKZnJhbWVfdHlw",
				"ZRgFIAEoBSJBChRNU1RfU1ZUX0VYQ0VFRF9BUlJBWRIpCgVpdGVtcxgBIAMo",
				"CzIaLnVGcmFtZXdvcmsuTVNUX1NWVF9FWENFRURiBnByb3RvMw=="
			}));
			MstSvtExceedReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_EXCEED), MST_SVT_EXCEED.Parser, new string[]
				{
					"Rarity",
					"ExceedCount",
					"Qp",
					"AddLvMax",
					"FrameType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_EXCEED_ARRAY), MST_SVT_EXCEED_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
