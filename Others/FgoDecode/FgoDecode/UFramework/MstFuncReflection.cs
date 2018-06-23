using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstFuncReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstFuncReflection.descriptor;

		static MstFuncReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3RfZnVuYy5wcm90bxIKdUZyYW1ld29yayLuAQoITVNUX0ZVTkMSCgoC",
				"aWQYASABKAUSDAoEY29uZBgCIAEoBRIRCglmdW5jX3R5cGUYAyABKAUSDAoE",
				"dmFscxgEIAMoBRITCgt0YXJnZXRfdHlwZRgFIAEoBRINCgV0dmFscxgGIAMo",
				"BRITCgtxdWVzdF90dmFscxgHIAMoBRITCgtlZmZlY3RfbGlzdBgIIAMoBRIU",
				"CgxhcHBseV90YXJnZXQYCSABKAUSFQoNcG9wdXBfaWNvbl9pZBgKIAEoBRIS",
				"Cgpwb3B1cF90ZXh0GAsgASgMEhgKEHBvcHVwX3RleHRfY29sb3IYDCABKAUi",
				"NQoOTVNUX0ZVTkNfQVJSQVkSIwoFaXRlbXMYASADKAsyFC51RnJhbWV3b3Jr",
				"Lk1TVF9GVU5DYgZwcm90bzM="
			}));
			MstFuncReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_FUNC), MST_FUNC.Parser, new string[]
				{
					"Id",
					"Cond",
					"FuncType",
					"Vals",
					"TargetType",
					"Tvals",
					"QuestTvals",
					"EffectList",
					"ApplyTarget",
					"PopupIconId",
					"PopupText",
					"PopupTextColor"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_FUNC_ARRAY), MST_FUNC_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
