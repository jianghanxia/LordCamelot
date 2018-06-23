using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstRecoverReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstRecoverReflection.descriptor;

		static MstRecoverReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChFtc3RfcmVjb3Zlci5wcm90bxIKdUZyYW1ld29yayJxCgtNU1RfUkVDT1ZF",
				"UhIKCgJpZBgBIAEoBRIOCgZ0YXJnZXQYAiABKAUSEAoIcHJpb3JpdHkYAyAB",
				"KAUSFAoMcmVjb3Zlcl90eXBlGAQgASgFEhEKCXRhcmdldF9pZBgFIAEoBRIL",
				"CgNudW0YBiABKAUiOwoRTVNUX1JFQ09WRVJfQVJSQVkSJgoFaXRlbXMYASAD",
				"KAsyFy51RnJhbWV3b3JrLk1TVF9SRUNPVkVSYgZwcm90bzM="
			}));
			MstRecoverReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_RECOVER), MST_RECOVER.Parser, new string[]
				{
					"Id",
					"Target",
					"Priority",
					"RecoverType",
					"TargetId",
					"Num"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_RECOVER_ARRAY), MST_RECOVER_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
