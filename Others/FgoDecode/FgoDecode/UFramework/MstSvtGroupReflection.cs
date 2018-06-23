using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtGroupReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtGroupReflection.descriptor;

		static MstSvtGroupReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChNtc3Rfc3Z0X2dyb3VwLnByb3RvEgp1RnJhbWV3b3JrIisKDU1TVF9TVlRf" + "R1JPVVASCgoCaWQYASABKAUSDgoGc3Z0X2lkGAIgASgFIj8KE01TVF9TVlRf" + "R1JPVVBfQVJSQVkSKAoFaXRlbXMYASADKAsyGS51RnJhbWV3b3JrLk1TVF9T" + "VlRfR1JPVVBiBnByb3RvMw==");
			MstSvtGroupReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_GROUP), MST_SVT_GROUP.Parser, new string[]
				{
					"Id",
					"SvtId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_GROUP_ARRAY), MST_SVT_GROUP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
