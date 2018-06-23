using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCvReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCvReflection.descriptor;

		static MstCvReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("Cgxtc3RfY3YucHJvdG8SCnVGcmFtZXdvcmsiMwoGTVNUX0NWEgoKAmlkGAEg" + "ASgFEgwKBG5hbWUYAiABKAwSDwoHY29tbWVudBgDIAEoDCIxCgxNU1RfQ1Zf" + "QVJSQVkSIQoFaXRlbXMYASADKAsyEi51RnJhbWV3b3JrLk1TVF9DVmIGcHJv" + "dG8z");
			MstCvReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CV), MST_CV.Parser, new string[]
				{
					"Id",
					"Name",
					"Comment"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CV_ARRAY), MST_CV_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
