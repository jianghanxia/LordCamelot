using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCommandSpellReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCommandSpellReflection.descriptor;

		static MstCommandSpellReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chdtc3RfY29tbWFuZF9zcGVsbC5wcm90bxIKdUZyYW1ld29yayLVAQoRTVNU",
				"X0NPTU1BTkRfU1BFTEwSCgoCaWQYASABKAUSDAoEbmFtZRgCIAEoDBIMCgR0",
				"eXBlGAMgASgFEg8KB2NvbnN1bWUYBCABKAUSDgoGZGV0YWlsGAUgASgMEg8K",
				"B2Z1bmNfaWQYBiADKAUSDAoEdmFscxgHIAMoDBIOCgZtb3Rpb24YCCABKAUS",
				"DgoGc2NyaXB0GAkgASgMEhAKCHByaW9yaXR5GAogASgFEhIKCnVwZGF0ZWRf",
				"YXQYCyABKAQSEgoKY3JlYXRlZF9hdBgMIAEoBCJHChdNU1RfQ09NTUFORF9T",
				"UEVMTF9BUlJBWRIsCgVpdGVtcxgBIAMoCzIdLnVGcmFtZXdvcmsuTVNUX0NP",
				"TU1BTkRfU1BFTExiBnByb3RvMw=="
			}));
			MstCommandSpellReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_COMMAND_SPELL), MST_COMMAND_SPELL.Parser, new string[]
				{
					"Id",
					"Name",
					"Type",
					"Consume",
					"Detail",
					"FuncId",
					"Vals",
					"Motion",
					"Script",
					"Priority",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_COMMAND_SPELL_ARRAY), MST_COMMAND_SPELL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
