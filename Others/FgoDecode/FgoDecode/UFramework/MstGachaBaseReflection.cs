using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGachaBaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGachaBaseReflection.descriptor;

		static MstGachaBaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChRtc3RfZ2FjaGFfYmFzZS5wcm90bxIKdUZyYW1ld29yayI7Cg5NU1RfR0FD" + "SEFfQkFTRRIKCgJpZBgBIAEoBRIMCgR0eXBlGAIgASgFEg8KB2dpZnRfaWQY" + "AyABKAUiQQoUTVNUX0dBQ0hBX0JBU0VfQVJSQVkSKQoFaXRlbXMYASADKAsy" + "Gi51RnJhbWV3b3JrLk1TVF9HQUNIQV9CQVNFYgZwcm90bzM=");
			MstGachaBaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GACHA_BASE), MST_GACHA_BASE.Parser, new string[]
				{
					"Id",
					"Type",
					"GiftId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GACHA_BASE_ARRAY), MST_GACHA_BASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
