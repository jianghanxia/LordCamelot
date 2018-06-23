using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstIllustratorReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstIllustratorReflection.descriptor;

		static MstIllustratorReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChVtc3RfaWxsdXN0cmF0b3IucHJvdG8SCnVGcmFtZXdvcmsiPAoPTVNUX0lM" + "TFVTVFJBVE9SEgoKAmlkGAEgASgFEgwKBG5hbWUYAiABKAwSDwoHY29tbWVu" + "dBgDIAEoBSJDChVNU1RfSUxMVVNUUkFUT1JfQVJSQVkSKgoFaXRlbXMYASAD" + "KAsyGy51RnJhbWV3b3JrLk1TVF9JTExVU1RSQVRPUmIGcHJvdG8z");
			MstIllustratorReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_ILLUSTRATOR), MST_ILLUSTRATOR.Parser, new string[]
				{
					"Id",
					"Name",
					"Comment"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_ILLUSTRATOR_ARRAY), MST_ILLUSTRATOR_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
