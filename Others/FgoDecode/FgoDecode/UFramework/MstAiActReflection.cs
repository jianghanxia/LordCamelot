using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstAiActReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstAiActReflection.descriptor;

		static MstAiActReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChBtc3RfYWlfYWN0LnByb3RvEgp1RnJhbWV3b3JrIpABCgpNU1RfQUlfQUNU",
				"EgoKAmlkGAEgASgFEgwKBHR5cGUYAiABKAUSDgoGdGFyZ2V0GAMgASgFEhwK",
				"FHRhcmdldF9pbmRpdmlkdWFsaXR5GAQgAygFEhIKCnNraWxsX3ZhbHMYBSAD",
				"KAUSEgoKdXBkYXRlZF9hdBgGIAEoBBISCgpjcmVhdGVkX2F0GAcgASgEIjkK",
				"EE1TVF9BSV9BQ1RfQVJSQVkSJQoFaXRlbXMYASADKAsyFi51RnJhbWV3b3Jr",
				"Lk1TVF9BSV9BQ1RiBnByb3RvMw=="
			}));
			MstAiActReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_AI_ACT), MST_AI_ACT.Parser, new string[]
				{
					"Id",
					"Type",
					"Target",
					"TargetIndividuality",
					"SkillVals",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_AI_ACT_ARRAY), MST_AI_ACT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
