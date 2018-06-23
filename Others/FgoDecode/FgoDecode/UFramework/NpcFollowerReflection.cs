using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class NpcFollowerReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => NpcFollowerReflection.descriptor;

		static NpcFollowerReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJucGNfZm9sbG93ZXIucHJvdG8SCnVGcmFtZXdvcmsilAEKDE5QQ19GT0xM",
				"T1dFUhIKCgJpZBgBIAEoBRIQCghxdWVzdF9pZBgCIAEoBRITCgtxdWVzdF9w",
				"aGFzZRgDIAEoBRIVCg1sZWFkZXJfc3Z0X2lkGAQgASgFEhIKCm5wY19zY3Jp",
				"cHQYBSABKAwSEgoKdXBkYXRlZF9hdBgGIAEoBBISCgpjcmVhdGVkX2F0GAcg",
				"ASgEIj0KEk5QQ19GT0xMT1dFUl9BUlJBWRInCgVpdGVtcxgBIAMoCzIYLnVG",
				"cmFtZXdvcmsuTlBDX0ZPTExPV0VSYgZwcm90bzM="
			}));
			NpcFollowerReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NPC_FOLLOWER), NPC_FOLLOWER.Parser, new string[]
				{
					"Id",
					"QuestId",
					"QuestPhase",
					"LeaderSvtId",
					"NpcScript",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(NPC_FOLLOWER_ARRAY), NPC_FOLLOWER_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
