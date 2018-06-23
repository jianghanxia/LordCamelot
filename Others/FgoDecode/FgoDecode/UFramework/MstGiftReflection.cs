using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstGiftReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstGiftReflection.descriptor;

		static MstGiftReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3RfZ2lmdC5wcm90bxIKdUZyYW1ld29yayJ3CghNU1RfR0lGVBIKCgJp",
				"ZBgBIAEoBRIMCgR0eXBlGAIgASgFEhEKCW9iamVjdF9pZBgDIAEoBRIQCghw",
				"cmlvcml0eRgEIAEoBRILCgNudW0YBSABKAUSEwoLbGltaXRfY291bnQYBiAB",
				"KAUSCgoCbHYYByABKAUiNQoOTVNUX0dJRlRfQVJSQVkSIwoFaXRlbXMYASAD",
				"KAsyFC51RnJhbWV3b3JrLk1TVF9HSUZUYgZwcm90bzM="
			}));
			MstGiftReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_GIFT), MST_GIFT.Parser, new string[]
				{
					"Id",
					"Type",
					"ObjectId",
					"Priority",
					"Num",
					"LimitCount",
					"Lv"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_GIFT_ARRAY), MST_GIFT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
