using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventSvtReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventSvtReflection.descriptor;

		static MstEventSvtReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3RfZXZlbnRfc3Z0LnByb3RvEgp1RnJhbWV3b3JrIpkBCg1NU1RfRVZF",
				"TlRfU1ZUEhAKCGV2ZW50X2lkGAEgASgFEg4KBnN2dF9pZBgCIAEoBRIUCgxq",
				"b2luX21lc3NhZ2UYAyABKAwSEwoLZ2V0X21lc3NhZ2UYBCABKAwSFQoNbGVh",
				"dmVfbWVzc2FnZRgFIAEoDBISCgpzdGFydGVkX2F0GAYgASgEEhAKCGVuZGVk",
				"X2F0GAcgASgEIj8KE01TVF9FVkVOVF9TVlRfQVJSQVkSKAoFaXRlbXMYASAD",
				"KAsyGS51RnJhbWV3b3JrLk1TVF9FVkVOVF9TVlRiBnByb3RvMw=="
			}));
			MstEventSvtReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_SVT), MST_EVENT_SVT.Parser, new string[]
				{
					"EventId",
					"SvtId",
					"JoinMessage",
					"GetMessage",
					"LeaveMessage",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_SVT_ARRAY), MST_EVENT_SVT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
