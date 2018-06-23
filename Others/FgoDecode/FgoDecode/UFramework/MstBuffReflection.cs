using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBuffReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBuffReflection.descriptor;

		static MstBuffReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3RfYnVmZi5wcm90bxIKdUZyYW1ld29yayL4AQoITVNUX0JVRkYSCgoC",
				"aWQYASABKAUSEgoKYnVmZl9ncm91cBgCIAEoBRIMCgR0eXBlGAMgASgFEgwK",
				"BHZhbHMYBCADKAUSDQoFdHZhbHMYBSADKAUSFAoMY2tfc2VsZl9pbmR2GAYg",
				"AygFEhIKCmNrX29wX2luZHYYByADKAUSDAoEbmFtZRgIIAEoDBIOCgZkZXRh",
				"aWwYCSABKAwSDwoHaWNvbl9pZBgKIAEoBRIQCghtYXhfcmF0ZRgLIAEoBRIO",
				"CgZzY3JpcHQYDCABKAwSEgoKdXBkYXRlZF9hdBgNIAEoBBISCgpjcmVhdGVk",
				"X2F0GA4gASgEIjUKDk1TVF9CVUZGX0FSUkFZEiMKBWl0ZW1zGAEgAygLMhQu",
				"dUZyYW1ld29yay5NU1RfQlVGRmIGcHJvdG8z"
			}));
			MstBuffReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BUFF), MST_BUFF.Parser, new string[]
				{
					"Id",
					"BuffGroup",
					"Type",
					"Vals",
					"Tvals",
					"CkSelfIndv",
					"CkOpIndv",
					"Name",
					"Detail",
					"IconId",
					"MaxRate",
					"Script",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BUFF_ARRAY), MST_BUFF_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
