using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstSpotRoadReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstSpotRoadReflection.descriptor;

		static MstSpotRoadReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChNtc3Rfc3BvdF9yb2FkLnByb3RvEgp1RnJhbWV3b3JrIt8CCg1NU1RfU1BP",
				"VF9ST0FEEgoKAmlkGAEgASgFEg4KBndhcl9pZBgCIAEoBRITCgtzcmNfc3Bv",
				"dF9pZBgDIAEoBRITCgtkc3Rfc3BvdF9pZBgEIAEoBRIMCgR0eXBlGAUgASgF",
				"EhAKCGltYWdlX2lkGAYgASgFEhYKDmRpc3BfY29uZF90eXBlGAcgASgFEhYK",
				"DmRpc3BfdGFyZ2V0X2lkGAggASgFEhkKEWRpc3BfdGFyZ2V0X3ZhbHVlGAkg",
				"ASgFEhcKD2Rpc3BfY29uZF90eXBlMhgKIAEoBRIXCg9kaXNwX3RhcmdldF9p",
				"ZDIYCyABKAUSGgoSZGlzcF90YXJnZXRfdmFsdWUyGAwgASgFEhgKEGFjdGl2",
				"ZV9jb25kX3R5cGUYDSABKAUSGAoQYWN0aXZlX3RhcmdldF9pZBgOIAEoBRIb",
				"ChNhY3RpdmVfdGFyZ2V0X3ZhbHVlGA8gASgFIj8KE01TVF9TUE9UX1JPQURf",
				"QVJSQVkSKAoFaXRlbXMYASADKAsyGS51RnJhbWV3b3JrLk1TVF9TUE9UX1JP",
				"QURiBnByb3RvMw=="
			}));
			MstSpotRoadReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_SPOT_ROAD), MST_SPOT_ROAD.Parser, new string[]
				{
					"Id",
					"WarId",
					"SrcSpotId",
					"DstSpotId",
					"Type",
					"ImageId",
					"DispCondType",
					"DispTargetId",
					"DispTargetValue",
					"DispCondType2",
					"DispTargetId2",
					"DispTargetValue2",
					"ActiveCondType",
					"ActiveTargetId",
					"ActiveTargetValue"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_SPOT_ROAD_ARRAY), MST_SPOT_ROAD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
