using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstTipsReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstTipsReflection.descriptor;

		static MstTipsReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("Cg5tc3RfdGlwcy5wcm90bxIKdUZyYW1ld29yayInCghNU1RfVElQUxIKCgJp" + "ZBgBIAEoBRIPCgdjb21tZW50GAIgASgMIjUKDk1TVF9USVBTX0FSUkFZEiMK" + "BWl0ZW1zGAEgAygLMhQudUZyYW1ld29yay5NU1RfVElQU2IGcHJvdG8z");
			MstTipsReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_TIPS), MST_TIPS.Parser, new string[]
				{
					"Id",
					"Comment"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_TIPS_ARRAY), MST_TIPS_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
