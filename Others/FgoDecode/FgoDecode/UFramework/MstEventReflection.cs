using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventReflection.descriptor;

		static MstEventReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg9tc3RfZXZlbnQucHJvdG8SCnVGcmFtZXdvcmsi6gMKCU1TVF9FVkVOVBIK",
				"CgJpZBgBIAEoBRIVCg1iYXNlX2V2ZW50X2lkGAIgASgFEgwKBHR5cGUYAyAB",
				"KAUSEQoJb3Blbl90eXBlGAQgASgFEgwKBG5hbWUYBSABKAwSDgoGZGV0YWls",
				"GAYgASgMEhgKEG5vdGljZV9iYW5uZXJfaWQYByABKAUSEQoJYmFubmVyX2lk",
				"GAggASgFEg8KB2ljb25faWQYCSABKAUSFwoPYmFubmVyX3ByaW9yaXR5GAog",
				"ASgFEhIKCm9wZW5faG91cnMYCyABKAUSFgoOaW50ZXJ2YWxfaG91cnMYDCAB",
				"KAUSEQoJbm90aWNlX2F0GA0gASgEEhIKCnN0YXJ0ZWRfYXQYDiABKAQSEAoI",
				"ZW5kZWRfYXQYDyABKAQSEwoLZmluaXNoZWRfYXQYECABKAQSGgoSbWF0ZXJp",
				"YWxfb3BlbmVkX2F0GBEgASgEEhEKCWxpbmtfdHlwZRgSIAEoBRIRCglsaW5r",
				"X2JvZHkYEyABKAwSEwoLZGV2aWNlX3R5cGUYFCABKAUSFAoMbXlyb29tX2Jn",
				"X2lkGBUgASgFEhUKDW15cm9vbV9iZ21faWQYFiABKAUSEgoKdXBkYXRlZF9h",
				"dBgXIAEoBBISCgpjcmVhdGVkX2F0GBggASgEIjcKD01TVF9FVkVOVF9BUlJB",
				"WRIkCgVpdGVtcxgBIAMoCzIVLnVGcmFtZXdvcmsuTVNUX0VWRU5UYgZwcm90",
				"bzM="
			}));
			MstEventReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT), MST_EVENT.Parser, new string[]
				{
					"Id",
					"BaseEventId",
					"Type",
					"OpenType",
					"Name",
					"Detail",
					"NoticeBannerId",
					"BannerId",
					"IconId",
					"BannerPriority",
					"OpenHours",
					"IntervalHours",
					"NoticeAt",
					"StartedAt",
					"EndedAt",
					"FinishedAt",
					"MaterialOpenedAt",
					"LinkType",
					"LinkBody",
					"DeviceType",
					"MyroomBgId",
					"MyroomBgmId",
					"UpdatedAt",
					"CreatedAt"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_ARRAY), MST_EVENT_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
