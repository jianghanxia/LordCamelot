using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class NpcSvtDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => NpcSvtDetailReflection.descriptor;

		static NpcSvtDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRucGNfc3Z0X2RldGFpbC5wcm90bxIKdUZyYW1ld29yayJNCg5OUENfU1ZU",
				"X0RFVEFJTBISCgpucGNfc3Z0X2lkGAEgASgFEhQKDGVuZW15X3NjcmlwdBgC",
				"IAEoDBIRCglyb2xlX3R5cGUYAyABKAUiQQoUTlBDX1NWVF9ERVRBSUxfQVJS",
				"QVkSKQoFaXRlbXMYASADKAsyGi51RnJhbWV3b3JrLk5QQ19TVlRfREVUQUlM",
				"YgZwcm90bzM="
			}));
			NpcSvtDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NPC_SVT_DETAIL), NPC_SVT_DETAIL.Parser, new string[]
				{
					"NpcSvtId",
					"EnemyScript",
					"RoleType"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(NPC_SVT_DETAIL_ARRAY), NPC_SVT_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
