using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBgmReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBgmReflection.descriptor;

		static MstBgmReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("Cg1tc3RfYmdtLnByb3RvEgp1RnJhbWV3b3JrIigKB01TVF9CR00SCgoCaWQY" + "ASABKAUSEQoJZmlsZV9uYW1lGAIgASgMIjMKDU1TVF9CR01fQVJSQVkSIgoF" + "aXRlbXMYASADKAsyEy51RnJhbWV3b3JrLk1TVF9CR01iBnByb3RvMw==");
			MstBgmReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BGM), MST_BGM.Parser, new string[]
				{
					"Id",
					"FileName"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BGM_ARRAY), MST_BGM_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
