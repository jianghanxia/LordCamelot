using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstQuestPhaseReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstQuestPhaseReflection.descriptor;

		static MstQuestPhaseReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChVtc3RfcXVlc3RfcGhhc2UucHJvdG8SCnVGcmFtZXdvcmsigAIKD01TVF9R",
				"VUVTVF9QSEFTRRIQCghxdWVzdF9pZBgBIAEoBRINCgVwaGFzZRgCIAEoBRIT",
				"Cgtpc19ucGNfb25seRgDIAEoBRIUCgxiYXR0bGVfYmdfaWQYBCABKAUSFgoO",
				"YmF0dGxlX2JnX3R5cGUYBSABKAUSCgoCcXAYBiABKAUSEgoKcGxheWVyX2V4",
				"cBgHIAEoBRIWCg5mcmllbmRzaGlwX2V4cBgIIAEoBRIRCgljbGFzc19pZHMY",
				"CSADKAUSFwoPZW5jb3VudF9zdnRfaWRzGAogAygFEhUKDWluZGl2aWR1YWxp",
				"dHkYCyADKAUSDgoGc2NyaXB0GAwgASgMIkMKFU1TVF9RVUVTVF9QSEFTRV9B",
				"UlJBWRIqCgVpdGVtcxgBIAMoCzIbLnVGcmFtZXdvcmsuTVNUX1FVRVNUX1BI",
				"QVNFYgZwcm90bzM="
			}));
			MstQuestPhaseReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_QUEST_PHASE), MST_QUEST_PHASE.Parser, new string[]
				{
					"QuestId",
					"Phase",
					"IsNpcOnly",
					"BattleBgId",
					"BattleBgType",
					"Qp",
					"PlayerExp",
					"FriendshipExp",
					"ClassIds",
					"EncountSvtIds",
					"Individuality",
					"Script"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_QUEST_PHASE_ARRAY), MST_QUEST_PHASE_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
