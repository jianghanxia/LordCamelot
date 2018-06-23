using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstUserTremReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstUserTremReflection.descriptor;

		static MstUserTremReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChNtc3RfdXNlcl90cmVtLnByb3RvEgp1RnJhbWV3b3JrIisKDU1TVF9VU0VS" + "X1RSRU0SCgoCaWQYASABKAUSDgoGZGV0YWlsGAIgASgMIj8KE01TVF9VU0VS" + "X1RSRU1fQVJSQVkSKAoFaXRlbXMYASADKAsyGS51RnJhbWV3b3JrLk1TVF9V" + "U0VSX1RSRU1iBnByb3RvMw==");
			MstUserTremReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_USER_TREM), MST_USER_TREM.Parser, new string[]
				{
					"Id",
					"Detail"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_USER_TREM_ARRAY), MST_USER_TREM_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
