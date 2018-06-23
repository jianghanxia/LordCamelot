using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstEventDetailReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstEventDetailReflection.descriptor;

		static MstEventDetailReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChZtc3RfZXZlbnRfZGV0YWlsLnByb3RvEgp1RnJhbWV3b3JrIvsDChBNU1Rf",
				"RVZFTlRfREVUQUlMEhAKCGV2ZW50X2lkGAEgASgFEgwKBGZsYWcYAiABKAUS",
				"GQoRcmV3YXJkX3BhZ2VfYmdfaWQYAyABKAUSDgoGYmdtX2lkGAQgASgFEhQK",
				"DGFmdGVyX2JnbV9pZBgFIAEoBRIWCg5wb2ludF9pbWFnZV9pZBgGIAEoBRIW",
				"Cg5ndWlkZV9pbWFnZV9pZBgHIAEoBRIXCg9ndWlkZV9pbWFnZV9pZHMYCCAD",
				"KAUSGQoRZ3VpZGVfbGltaXRfY291bnQYCSABKAUSGgoSZ3VpZGVfbGltaXRf",
				"Y291bnRzGAogAygFEhUKDWNvbmRfcXVlc3RfaWQYCyABKAUSFAoMY29uZF9t",
				"ZXNzYWdlGAwgASgMEhoKEnR1dG9yaWFsX2ltYWdlX2lkcxgNIAMoDBIaChJz",
				"aG9wX2NvbmRfcXVlc3RfaWQYDiABKAUSGQoRc2hvcF9jb25kX21lc3NhZ2UY",
				"DyABKAwSHAoUc2hvcF9ndWlkZV9pbWFnZV9pZHMYECADKAUSHwoXc2hvcF9n",
				"dWlkZV9saW1pdF9jb3VudHMYESADKAUSFwoPc2hvcF9wYWdlX2JnX2lkGBIg",
				"ASgFEhMKC3Nob3BfYmdtX2lkGBMgASgFEhkKEXNob3BfYWZ0ZXJfYmdtX2lk",
				"GBQgASgFIkUKFk1TVF9FVkVOVF9ERVRBSUxfQVJSQVkSKwoFaXRlbXMYASAD",
				"KAsyHC51RnJhbWV3b3JrLk1TVF9FVkVOVF9ERVRBSUxiBnByb3RvMw=="
			}));
			MstEventDetailReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_EVENT_DETAIL), MST_EVENT_DETAIL.Parser, new string[]
				{
					"EventId",
					"Flag",
					"RewardPageBgId",
					"BgmId",
					"AfterBgmId",
					"PointImageId",
					"GuideImageId",
					"GuideImageIds",
					"GuideLimitCount",
					"GuideLimitCounts",
					"CondQuestId",
					"CondMessage",
					"TutorialImageIds",
					"ShopCondQuestId",
					"ShopCondMessage",
					"ShopGuideImageIds",
					"ShopGuideLimitCounts",
					"ShopPageBgId",
					"ShopBgmId",
					"ShopAfterBgmId"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_EVENT_DETAIL_ARRAY), MST_EVENT_DETAIL_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
