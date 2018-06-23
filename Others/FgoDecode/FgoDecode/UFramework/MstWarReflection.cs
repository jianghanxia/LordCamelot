using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstWarReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstWarReflection.descriptor;

		static MstWarReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg1tc3Rfd2FyLnByb3RvEgp1RnJhbWV3b3JrItoCCgdNU1RfV0FSEgoKAmlk",
				"GAEgASgFEgsKA2FnZRgCIAEoDBIMCgRuYW1lGAMgASgMEhEKCWxvbmdfbmFt",
				"ZRgEIAEoDBIUCgxtYXBfaW1hZ2VfaWQYBSABKAUSEwoLbWFwX2ltYWdlX3cY",
				"BiABKAUSEwoLbWFwX2ltYWdlX2gYByABKAUSFwoPaGVhZGVyX2ltYWdlX2lk",
				"GAggASgFEhAKCHByaW9yaXR5GAkgASgFEhUKDXBhcmVudF93YXJfaWQYCiAB",
				"KAUSDAoEZmxhZxgLIAEoBRIVCg1lbXB0eV9tZXNzYWdlGAwgASgMEg4KBmJn",
				"bV9pZBgNIAEoBRIRCglzY3JpcHRfaWQYDiABKAwSEAoIZXZlbnRfaWQYDyAB",
				"KAUSFQoNbGFzdF9xdWVzdF9pZBgQIAEoBRISCgpjb29yZGluYXRlGBEgAygC",
				"Eg4KBnN0YXR1cxgSIAEoBSIzCg1NU1RfV0FSX0FSUkFZEiIKBWl0ZW1zGAEg",
				"AygLMhMudUZyYW1ld29yay5NU1RfV0FSYgZwcm90bzM="
			}));
			MstWarReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_WAR), MST_WAR.Parser, new string[]
				{
					"Id",
					"Age",
					"Name",
					"LongName",
					"MapImageId",
					"MapImageW",
					"MapImageH",
					"HeaderImageId",
					"Priority",
					"ParentWarId",
					"Flag",
					"EmptyMessage",
					"BgmId",
					"ScriptId",
					"EventId",
					"LastQuestId",
					"Coordinate",
					"Status"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_WAR_ARRAY), MST_WAR_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
