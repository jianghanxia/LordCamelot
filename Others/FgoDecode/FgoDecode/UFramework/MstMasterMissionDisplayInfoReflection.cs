using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstMasterMissionDisplayInfoReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstMasterMissionDisplayInfoReflection.descriptor;

		static MstMasterMissionDisplayInfoReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"CiVtc3RfbWFzdGVyX21pc3Npb25fZGlzcGxheV9pbmZvLnByb3RvEgp1RnJh",
				"bWV3b3JrIpgBCh9NU1RfTUFTVEVSX01JU1NJT05fRElTUExBWV9JTkZPEgoK",
				"AmlkGAEgASgFEhYKDmd1aWRlX2ltYWdlX2lkGAIgASgFEhAKCHRhbGtfaWRz",
				"GAMgAygMEhkKEWd1aWRlX2xpbWl0X2NvdW50GAQgASgFEhIKCnN0YXJ0ZWRf",
				"YXQYBSABKAQSEAoIZW5kZWRfYXQYBiABKAQiYwolTVNUX01BU1RFUl9NSVNT",
				"SU9OX0RJU1BMQVlfSU5GT19BUlJBWRI6CgVpdGVtcxgBIAMoCzIrLnVGcmFt",
				"ZXdvcmsuTVNUX01BU1RFUl9NSVNTSU9OX0RJU1BMQVlfSU5GT2IGcHJvdG8z"
			}));
			MstMasterMissionDisplayInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_MASTER_MISSION_DISPLAY_INFO), MST_MASTER_MISSION_DISPLAY_INFO.Parser, new string[]
				{
					"Id",
					"GuideImageId",
					"TalkIds",
					"GuideLimitCount",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_MASTER_MISSION_DISPLAY_INFO_ARRAY), MST_MASTER_MISSION_DISPLAY_INFO_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
