using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstClosedMessageReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstClosedMessageReflection.descriptor;

		static MstClosedMessageReflection()
		{
			byte[] descriptorData = Convert.FromBase64String("Chhtc3RfY2xvc2VkX21lc3NhZ2UucHJvdG8SCnVGcmFtZXdvcmsiMQoSTVNU" + "X0NMT1NFRF9NRVNTQUdFEgoKAmlkGAEgASgFEg8KB21lc3NhZ2UYAiABKAwi" + "SQoYTVNUX0NMT1NFRF9NRVNTQUdFX0FSUkFZEi0KBWl0ZW1zGAEgAygLMh4u" + "dUZyYW1ld29yay5NU1RfQ0xPU0VEX01FU1NBR0ViBnByb3RvMw==");
			MstClosedMessageReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CLOSED_MESSAGE), MST_CLOSED_MESSAGE.Parser, new string[]
				{
					"Id",
					"Message"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CLOSED_MESSAGE_ARRAY), MST_CLOSED_MESSAGE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
