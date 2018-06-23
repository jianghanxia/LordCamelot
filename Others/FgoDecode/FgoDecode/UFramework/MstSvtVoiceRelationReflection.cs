using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSvtVoiceRelationReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSvtVoiceRelationReflection.descriptor;

		static MstSvtVoiceRelationReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Chxtc3Rfc3Z0X3ZvaWNlX3JlbGF0aW9uLnByb3RvEgp1RnJhbWV3b3JrIlcK",
				"Fk1TVF9TVlRfVk9JQ0VfUkVMQVRJT04SDgoGc3Z0X2lkGAEgASgFEhcKD3Jl",
				"bGF0aW9uX3N2dF9pZBgCIAEoBRIUCgxhc2NlbmRfb3JkZXIYAyABKAUiUQoc",
				"TVNUX1NWVF9WT0lDRV9SRUxBVElPTl9BUlJBWRIxCgVpdGVtcxgBIAMoCzIi",
				"LnVGcmFtZXdvcmsuTVNUX1NWVF9WT0lDRV9SRUxBVElPTmIGcHJvdG8z"
			}));
			MstSvtVoiceRelationReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SVT_VOICE_RELATION), MST_SVT_VOICE_RELATION.Parser, new string[]
				{
					"SvtId",
					"RelationSvtId",
					"AscendOrder"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SVT_VOICE_RELATION_ARRAY), MST_SVT_VOICE_RELATION_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
