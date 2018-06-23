using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstWarBgmReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstWarBgmReflection.descriptor;

		static MstWarBgmReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChFtc3Rfd2FyX2JnbS5wcm90bxIKdUZyYW1ld29yayJlCgtNU1RfV0FSX0JH",
				"TRIOCgZ3YXJfaWQYASABKAUSEAoIcHJpb3JpdHkYAiABKAUSEQoJY29uZF90",
				"eXBlGAMgASgFEhEKCXRhcmdldF9pZBgEIAEoBRIOCgZiZ21faWQYBSABKAUi",
				"OwoRTVNUX1dBUl9CR01fQVJSQVkSJgoFaXRlbXMYASADKAsyFy51RnJhbWV3",
				"b3JrLk1TVF9XQVJfQkdNYgZwcm90bzM="
			}));
			MstWarBgmReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_WAR_BGM), MST_WAR_BGM.Parser, new string[]
				{
					"WarId",
					"Priority",
					"CondType",
					"TargetId",
					"BgmId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_WAR_BGM_ARRAY), MST_WAR_BGM_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
