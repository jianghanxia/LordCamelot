using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCombineReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCombineReflection.descriptor;

		static MstCombineReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChFtc3RfY29tYmluZS5wcm90bxIKdUZyYW1ld29yayInCgtNU1RfQ09NQklO" + "RRIKCgJpZBgBIAEoBRIMCgR0eXBlGAIgASgFIjsKEU1TVF9DT01CSU5FX0FS" + "UkFZEiYKBWl0ZW1zGAEgAygLMhcudUZyYW1ld29yay5NU1RfQ09NQklORWIG" + "cHJvdG8z");
			MstCombineReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMBINE), MST_COMBINE.Parser, new string[]
				{
					"Id",
					"Type"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMBINE_ARRAY), MST_COMBINE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
