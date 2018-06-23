using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstBoxGachaTalkReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstBoxGachaTalkReflection.descriptor;

		static MstBoxGachaTalkReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chhtc3RfYm94X2dhY2hhX3RhbGsucHJvdG8SCnVGcmFtZXdvcmsiuwEKEk1T",
				"VF9CT1hfR0FDSEFfVEFMSxIKCgJpZBgBIAEoBRIKCgJubxgCIAEoBRIPCgdp",
				"c19yYXJlGAMgASgFEhUKDWJlZm9yZV9kZXRhaWwYBCABKAwSFAoMYWZ0ZXJf",
				"ZGV0YWlsGAUgASgMEhMKC2JlZm9yZV9mYWNlGAYgASgFEhIKCmFmdGVyX2Zh",
				"Y2UYByABKAUSEgoKdXBkYXRlZF9hdBgIIAEoBBISCgpjcmVhdGVkX2F0GAkg",
				"ASgEIkkKGE1TVF9CT1hfR0FDSEFfVEFMS19BUlJBWRItCgVpdGVtcxgBIAMo",
				"CzIeLnVGcmFtZXdvcmsuTVNUX0JPWF9HQUNIQV9UQUxLYgZwcm90bzM="
			}));
			MstBoxGachaTalkReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_TALK), MST_BOX_GACHA_TALK.Parser, new string[]
				{
					"Id",
					"No",
					"IsRare",
					"BeforeDetail",
					"AfterDetail",
					"BeforeFace",
					"AfterFace",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_BOX_GACHA_TALK_ARRAY), MST_BOX_GACHA_TALK_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
