using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstFuncGroupReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstFuncGroupReflection.descriptor;

		static MstFuncGroupReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRtc3RfZnVuY19ncm91cC5wcm90bxIKdUZyYW1ld29yayKUAQoOTVNUX0ZV",
				"TkNfR1JPVVASDwoHZnVuY19pZBgBIAEoBRIQCghldmVudF9pZBgCIAEoBRIU",
				"CgxiYXNlX2Z1bmNfaWQYAyABKAUSEgoKbmFtZV90b3RhbBgEIAEoDBIMCgRu",
				"YW1lGAUgASgMEhAKCHByaW9yaXR5GAYgASgFEhUKDWlzX2Rpc3BfdmFsdWUY",
				"ByABKAUiQQoUTVNUX0ZVTkNfR1JPVVBfQVJSQVkSKQoFaXRlbXMYASADKAsy",
				"Gi51RnJhbWV3b3JrLk1TVF9GVU5DX0dST1VQYgZwcm90bzM="
			}));
			MstFuncGroupReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_FUNC_GROUP), MST_FUNC_GROUP.Parser, new string[]
				{
					"FuncId",
					"EventId",
					"BaseFuncId",
					"NameTotal",
					"Name",
					"Priority",
					"IsDispValue"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_FUNC_GROUP_ARRAY), MST_FUNC_GROUP_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
