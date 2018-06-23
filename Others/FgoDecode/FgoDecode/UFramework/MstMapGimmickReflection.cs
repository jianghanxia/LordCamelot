using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstMapGimmickReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstMapGimmickReflection.descriptor;

		static MstMapGimmickReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfbWFwX2dpbW1pY2sucHJvdG8SCnVGcmFtZXdvcmsi7QIKD01TVF9N",
				"QVBfR0lNTUlDSxIKCgJpZBgBIAEoBRIOCgZ3YXJfaWQYAiABKAUSEAoIaW1h",
				"Z2VfaWQYAyABKAUSCQoBeBgEIAEoBRIJCgF5GAUgASgFEhQKDGRlcHRoX29m",
				"ZnNldBgGIAEoBRINCgVzY2FsZRgHIAEoBRIWCg5kaXNwX2NvbmRfdHlwZRgI",
				"IAEoBRIWCg5kaXNwX3RhcmdldF9pZBgJIAEoBRIZChFkaXNwX3RhcmdldF92",
				"YWx1ZRgKIAEoBRIXCg9kaXNwX2NvbmRfdHlwZTIYCyABKAUSFwoPZGlzcF90",
				"YXJnZXRfaWQyGAwgASgFEhoKEmRpc3BfdGFyZ2V0X3ZhbHVlMhgNIAEoBRIY",
				"ChBhY3Rpb25fYW5pbV90aW1lGA4gASgFEhgKEGFjdGlvbl9lZmZlY3RfaWQY",
				"DyABKAUSEgoKc3RhcnRlZF9hdBgQIAEoBBIQCghlbmRlZF9hdBgRIAEoBCJD",
				"ChVNU1RfTUFQX0dJTU1JQ0tfQVJSQVkSKgoFaXRlbXMYASADKAsyGy51RnJh",
				"bWV3b3JrLk1TVF9NQVBfR0lNTUlDS2IGcHJvdG8z"
			}));
			MstMapGimmickReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_MAP_GIMMICK), MST_MAP_GIMMICK.Parser, new string[]
				{
					"Id",
					"WarId",
					"ImageId",
					"X",
					"Y",
					"DepthOffset",
					"Scale",
					"DispCondType",
					"DispTargetId",
					"DispTargetValue",
					"DispCondType2",
					"DispTargetId2",
					"DispTargetValue2",
					"ActionAnimTime",
					"ActionEffectId",
					"StartedAt",
					"EndedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_MAP_GIMMICK_ARRAY), MST_MAP_GIMMICK_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
