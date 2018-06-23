using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstPresentMessageReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstPresentMessageReflection.descriptor;

		static MstPresentMessageReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chltc3RfcHJlc2VudF9tZXNzYWdlLnByb3RvEgp1RnJhbWV3b3JrIloKE01T",
				"VF9QUkVTRU5UX01FU1NBR0USCgoCaWQYASABKAUSDwoHbWVzc2FnZRgCIAEo",
				"DBISCgp1cGRhdGVkX2F0GAMgASgEEhIKCmNyZWF0ZWRfYXQYBCABKAQiSwoZ",
				"TVNUX1BSRVNFTlRfTUVTU0FHRV9BUlJBWRIuCgVpdGVtcxgBIAMoCzIfLnVG",
				"cmFtZXdvcmsuTVNUX1BSRVNFTlRfTUVTU0FHRWIGcHJvdG8z"
			}));
			MstPresentMessageReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_PRESENT_MESSAGE), MST_PRESENT_MESSAGE.Parser, new string[]
				{
					"Id",
					"Message",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_PRESENT_MESSAGE_ARRAY), MST_PRESENT_MESSAGE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
