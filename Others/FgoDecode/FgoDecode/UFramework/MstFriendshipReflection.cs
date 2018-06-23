using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstFriendshipReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstFriendshipReflection.descriptor;

		static MstFriendshipReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("ChRtc3RfZnJpZW5kc2hpcC5wcm90bxIKdUZyYW1ld29yayI+Cg5NU1RfRlJJ" + "RU5EU0hJUBIKCgJpZBgBIAEoBRIMCgRyYW5rGAIgASgFEhIKCmZyaWVuZHNo" + "aXAYAyABKAUiQQoUTVNUX0ZSSUVORFNISVBfQVJSQVkSKQoFaXRlbXMYASAD" + "KAsyGi51RnJhbWV3b3JrLk1TVF9GUklFTkRTSElQYgZwcm90bzM=");
			MstFriendshipReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_FRIENDSHIP), MST_FRIENDSHIP.Parser, new string[]
				{
					"Id",
					"Rank",
					"Friendship"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_FRIENDSHIP_ARRAY), MST_FRIENDSHIP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
