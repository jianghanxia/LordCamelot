using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class NpcDeckReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => NpcDeckReflection.descriptor;

		static NpcDeckReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5ucGNfZGVjay5wcm90bxIKdUZyYW1ld29yayLDAQoITlBDX0RFQ0sSCgoC",
				"aWQYASABKAUSCwoDbnVtGAIgASgFEhIKCm5wY19zdnRfaWQYAyABKAUSCgoC",
				"bHYYBCABKAUSDAoEbmFtZRgFIAEoDBIKCgJocBgGIAEoBRITCgtwcm9iYWJp",
				"bGl0eRgHIAEoBRIUCgxlbmVteV9zY3JpcHQYCCABKAwSEQoJcm9sZV90eXBl",
				"GAkgASgFEhIKCnVwZGF0ZWRfYXQYCiABKAQSEgoKY3JlYXRlZF9hdBgLIAEo",
				"BCI1Cg5OUENfREVDS19BUlJBWRIjCgVpdGVtcxgBIAMoCzIULnVGcmFtZXdv",
				"cmsuTlBDX0RFQ0tiBnByb3RvMw=="
			}));
			NpcDeckReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(NPC_DECK), NPC_DECK.Parser, new string[]
				{
					"Id",
					"Num",
					"NpcSvtId",
					"Lv",
					"Name",
					"Hp",
					"Probability",
					"EnemyScript",
					"RoleType",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(NPC_DECK_ARRAY), NPC_DECK_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
