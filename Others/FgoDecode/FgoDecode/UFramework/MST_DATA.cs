using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_DATA : IMessage, IMessage<MST_DATA>, IEquatable<MST_DATA>, IDeepCloneable<MST_DATA>
	{
		public const int MstAiFieldNumber = 1;

		public const int MstAiActFieldNumber = 2;

		public const int MstAiFieldFieldNumber = 3;

		public const int MstAttriRelationFieldNumber = 4;

		public const int MstBankShopFieldNumber = 5;

		public const int MstBannerFieldNumber = 6;

		public const int MstBattleBgFieldNumber = 7;

		public const int MstBgmFieldNumber = 8;

		public const int MstBoxGachaFieldNumber = 9;

		public const int MstBoxGachaBaseFieldNumber = 10;

		public const int MstBoxGachaBaseDetailFieldNumber = 11;

		public const int MstBoxGachaTalkFieldNumber = 12;

		public const int MstBuffFieldNumber = 13;

		public const int MstCardFieldNumber = 14;

		public const int MstClassFieldNumber = 15;

		public const int MstClassRelationFieldNumber = 16;

		public const int MstClosedMessageFieldNumber = 17;

		public const int MstCombineFieldNumber = 18;

		public const int MstCombineLimitFieldNumber = 19;

		public const int MstCombineMaterialFieldNumber = 20;

		public const int MstCombineQpFieldNumber = 21;

		public const int MstCombineQpSvtEquipFieldNumber = 22;

		public const int MstCombineSkillFieldNumber = 23;

		public const int MstCommandSpellFieldNumber = 24;

		public const int MstConstantFieldNumber = 25;

		public const int MstConstantStrFieldNumber = 26;

		public const int MstCvFieldNumber = 27;

		public const int MstEffectFieldNumber = 28;

		public const int MstEquipFieldNumber = 29;

		public const int MstEquipExpFieldNumber = 30;

		public const int MstEquipImageFieldNumber = 31;

		public const int MstEquipSkillFieldNumber = 32;

		public const int MstEventFieldNumber = 33;

		public const int MstEventCampaignFieldNumber = 34;

		public const int MstEventDetailFieldNumber = 35;

		public const int MstEventFilterFieldNumber = 36;

		public const int MstEventItemDisplayFieldNumber = 37;

		public const int MstEventItemDisplayGroupFieldNumber = 38;

		public const int MstEventItemDisplayReleaseFieldNumber = 39;

		public const int MstEventLoginBonusFieldNumber = 40;

		public const int MstEventLoginCampaignFieldNumber = 41;

		public const int MstEventMissionFieldNumber = 42;

		public const int MstEventMissionActionFieldNumber = 43;

		public const int MstEventMissionConditionFieldNumber = 44;

		public const int MstEventMissionConditionDetFieldNumber = 45;

		public const int MstEventQuestFieldNumber = 46;

		public const int MstEventRewardFieldNumber = 47;

		public const int MstEventRewardBgFieldNumber = 48;

		public const int MstEventRewardSetFieldNumber = 49;

		public const int MstEventSuperBossFieldNumber = 50;

		public const int MstEventSvtFieldNumber = 51;

		public const int MstEventTutorialFieldNumber = 52;

		public const int MstFriendshipFieldNumber = 53;

		public const int MstFuncFieldNumber = 54;

		public const int MstFuncGroupFieldNumber = 55;

		public const int MstGachaFieldNumber = 56;

		public const int MstGachaAdjustFieldNumber = 57;

		public const int MstGachaBaseFieldNumber = 58;

		public const int MstGachaBonusFieldNumber = 59;

		public const int MstGameIllustrationFieldNumber = 60;

		public const int MstGiftFieldNumber = 61;

		public const int MstGuideFieldNumber = 62;

		public const int MstHeroineFieldNumber = 63;

		public const int MstIllustratorFieldNumber = 64;

		public const int MstItemFieldNumber = 65;

		public const int MstMapGimmickFieldNumber = 66;

		public const int MstMasterMissionFieldNumber = 67;

		public const int MstMasterMissionDisplayInfoFieldNumber = 68;

		public const int MstMissionFieldNumber = 69;

		public const int MstPresentMessageFieldNumber = 70;

		public const int MstQuestFieldNumber = 71;

		public const int MstQuestConsumeItemFieldNumber = 72;

		public const int MstQuestGroupFieldNumber = 73;

		public const int MstQuestMessageFieldNumber = 74;

		public const int MstQuestPhaseFieldNumber = 75;

		public const int MstQuestPhaseDetailFieldNumber = 76;

		public const int MstQuestReleaseFieldNumber = 77;

		public const int MstQuestResetFieldNumber = 78;

		public const int MstQuestRestrictionFieldNumber = 79;

		public const int MstQuestScriptFieldNumber = 80;

		public const int MstQuestScriptReleaseFieldNumber = 81;

		public const int MstRecoverFieldNumber = 82;

		public const int MstRestrictionFieldNumber = 83;

		public const int MstSetItemFieldNumber = 84;

		public const int MstShopFieldNumber = 85;

		public const int MstShopDetailFieldNumber = 86;

		public const int MstShopReleaseFieldNumber = 87;

		public const int MstShopScriptFieldNumber = 88;

		public const int MstSkillFieldNumber = 89;

		public const int MstSkillDetailFieldNumber = 90;

		public const int MstSkillLvFieldNumber = 91;

		public const int MstSpotFieldNumber = 92;

		public const int MstSpotImageFieldNumber = 93;

		public const int MstSpotRoadFieldNumber = 94;

		public const int MstStageFieldNumber = 95;

		public const int MstStoneShopFieldNumber = 96;

		public const int MstSvtFieldNumber = 97;

		public const int MstSvtCardFieldNumber = 98;

		public const int MstSvtCommentFieldNumber = 99;

		public const int MstSvtCommentAddFieldNumber = 100;

		public const int MstSvtExceedFieldNumber = 101;

		public const int MstSvtExpFieldNumber = 102;

		public const int MstSvtGroupFieldNumber = 103;

		public const int MstSvtLimitFieldNumber = 104;

		public const int MstSvtLimitAddFieldNumber = 105;

		public const int MstSvtPassiveSkillFieldNumber = 106;

		public const int MstSvtProfileFieldNumber = 107;

		public const int MstSvtRarityFieldNumber = 108;

		public const int MstSvtScriptFieldNumber = 109;

		public const int MstSvtScriptAddFieldNumber = 110;

		public const int MstSvtSkillFieldNumber = 111;

		public const int MstSvtTreasureDeviceFieldNumber = 112;

		public const int MstSvtVoiceFieldNumber = 113;

		public const int MstSvtVoiceRelationFieldNumber = 114;

		public const int MstTipsFieldNumber = 115;

		public const int MstTotalLoginFieldNumber = 116;

		public const int MstTreasureDeviceFieldNumber = 117;

		public const int MstTreasureDeviceDetailFieldNumber = 118;

		public const int MstTreasureDeviceLvFieldNumber = 119;

		public const int MstUserExpFieldNumber = 120;

		public const int MstUserTremFieldNumber = 121;

		public const int MstVoiceFieldNumber = 122;

		public const int MstVoiceReleaseFieldNumber = 123;

		public const int MstWarFieldNumber = 124;

		public const int MstWarBgmFieldNumber = 125;

		public const int NpcDeckFieldNumber = 126;

		public const int NpcFollowerFieldNumber = 127;

		public const int NpcSvtFieldNumber = 128;

		public const int NpcSvtDetailFieldNumber = 129;

		public const int NpcSvtFollowerFieldNumber = 130;

		private static readonly MessageParser<MST_DATA> _parser = new MessageParser<MST_DATA>(() => new MST_DATA());

		private ByteString mstAi_ = ByteString.Empty;

		private ByteString mstAiAct_ = ByteString.Empty;

		private ByteString mstAiField_ = ByteString.Empty;

		private ByteString mstAttriRelation_ = ByteString.Empty;

		private ByteString mstBankShop_ = ByteString.Empty;

		private ByteString mstBanner_ = ByteString.Empty;

		private ByteString mstBattleBg_ = ByteString.Empty;

		private ByteString mstBgm_ = ByteString.Empty;

		private ByteString mstBoxGacha_ = ByteString.Empty;

		private ByteString mstBoxGachaBase_ = ByteString.Empty;

		private ByteString mstBoxGachaBaseDetail_ = ByteString.Empty;

		private ByteString mstBoxGachaTalk_ = ByteString.Empty;

		private ByteString mstBuff_ = ByteString.Empty;

		private ByteString mstCard_ = ByteString.Empty;

		private ByteString mstClass_ = ByteString.Empty;

		private ByteString mstClassRelation_ = ByteString.Empty;

		private ByteString mstClosedMessage_ = ByteString.Empty;

		private ByteString mstCombine_ = ByteString.Empty;

		private ByteString mstCombineLimit_ = ByteString.Empty;

		private ByteString mstCombineMaterial_ = ByteString.Empty;

		private ByteString mstCombineQp_ = ByteString.Empty;

		private ByteString mstCombineQpSvtEquip_ = ByteString.Empty;

		private ByteString mstCombineSkill_ = ByteString.Empty;

		private ByteString mstCommandSpell_ = ByteString.Empty;

		private ByteString mstConstant_ = ByteString.Empty;

		private ByteString mstConstantStr_ = ByteString.Empty;

		private ByteString mstCv_ = ByteString.Empty;

		private ByteString mstEffect_ = ByteString.Empty;

		private ByteString mstEquip_ = ByteString.Empty;

		private ByteString mstEquipExp_ = ByteString.Empty;

		private ByteString mstEquipImage_ = ByteString.Empty;

		private ByteString mstEquipSkill_ = ByteString.Empty;

		private ByteString mstEvent_ = ByteString.Empty;

		private ByteString mstEventCampaign_ = ByteString.Empty;

		private ByteString mstEventDetail_ = ByteString.Empty;

		private ByteString mstEventFilter_ = ByteString.Empty;

		private ByteString mstEventItemDisplay_ = ByteString.Empty;

		private ByteString mstEventItemDisplayGroup_ = ByteString.Empty;

		private ByteString mstEventItemDisplayRelease_ = ByteString.Empty;

		private ByteString mstEventLoginBonus_ = ByteString.Empty;

		private ByteString mstEventLoginCampaign_ = ByteString.Empty;

		private ByteString mstEventMission_ = ByteString.Empty;

		private ByteString mstEventMissionAction_ = ByteString.Empty;

		private ByteString mstEventMissionCondition_ = ByteString.Empty;

		private ByteString mstEventMissionConditionDet_ = ByteString.Empty;

		private ByteString mstEventQuest_ = ByteString.Empty;

		private ByteString mstEventReward_ = ByteString.Empty;

		private ByteString mstEventRewardBg_ = ByteString.Empty;

		private ByteString mstEventRewardSet_ = ByteString.Empty;

		private ByteString mstEventSuperBoss_ = ByteString.Empty;

		private ByteString mstEventSvt_ = ByteString.Empty;

		private ByteString mstEventTutorial_ = ByteString.Empty;

		private ByteString mstFriendship_ = ByteString.Empty;

		private ByteString mstFunc_ = ByteString.Empty;

		private ByteString mstFuncGroup_ = ByteString.Empty;

		private ByteString mstGacha_ = ByteString.Empty;

		private ByteString mstGachaAdjust_ = ByteString.Empty;

		private ByteString mstGachaBase_ = ByteString.Empty;

		private ByteString mstGachaBonus_ = ByteString.Empty;

		private ByteString mstGameIllustration_ = ByteString.Empty;

		private ByteString mstGift_ = ByteString.Empty;

		private ByteString mstGuide_ = ByteString.Empty;

		private ByteString mstHeroine_ = ByteString.Empty;

		private ByteString mstIllustrator_ = ByteString.Empty;

		private ByteString mstItem_ = ByteString.Empty;

		private ByteString mstMapGimmick_ = ByteString.Empty;

		private ByteString mstMasterMission_ = ByteString.Empty;

		private ByteString mstMasterMissionDisplayInfo_ = ByteString.Empty;

		private ByteString mstMission_ = ByteString.Empty;

		private ByteString mstPresentMessage_ = ByteString.Empty;

		private ByteString mstQuest_ = ByteString.Empty;

		private ByteString mstQuestConsumeItem_ = ByteString.Empty;

		private ByteString mstQuestGroup_ = ByteString.Empty;

		private ByteString mstQuestMessage_ = ByteString.Empty;

		private ByteString mstQuestPhase_ = ByteString.Empty;

		private ByteString mstQuestPhaseDetail_ = ByteString.Empty;

		private ByteString mstQuestRelease_ = ByteString.Empty;

		private ByteString mstQuestReset_ = ByteString.Empty;

		private ByteString mstQuestRestriction_ = ByteString.Empty;

		private ByteString mstQuestScript_ = ByteString.Empty;

		private ByteString mstQuestScriptRelease_ = ByteString.Empty;

		private ByteString mstRecover_ = ByteString.Empty;

		private ByteString mstRestriction_ = ByteString.Empty;

		private ByteString mstSetItem_ = ByteString.Empty;

		private ByteString mstShop_ = ByteString.Empty;

		private ByteString mstShopDetail_ = ByteString.Empty;

		private ByteString mstShopRelease_ = ByteString.Empty;

		private ByteString mstShopScript_ = ByteString.Empty;

		private ByteString mstSkill_ = ByteString.Empty;

		private ByteString mstSkillDetail_ = ByteString.Empty;

		private ByteString mstSkillLv_ = ByteString.Empty;

		private ByteString mstSpot_ = ByteString.Empty;

		private ByteString mstSpotImage_ = ByteString.Empty;

		private ByteString mstSpotRoad_ = ByteString.Empty;

		private ByteString mstStage_ = ByteString.Empty;

		private ByteString mstStoneShop_ = ByteString.Empty;

		private ByteString mstSvt_ = ByteString.Empty;

		private ByteString mstSvtCard_ = ByteString.Empty;

		private ByteString mstSvtComment_ = ByteString.Empty;

		private ByteString mstSvtCommentAdd_ = ByteString.Empty;

		private ByteString mstSvtExceed_ = ByteString.Empty;

		private ByteString mstSvtExp_ = ByteString.Empty;

		private ByteString mstSvtGroup_ = ByteString.Empty;

		private ByteString mstSvtLimit_ = ByteString.Empty;

		private ByteString mstSvtLimitAdd_ = ByteString.Empty;

		private ByteString mstSvtPassiveSkill_ = ByteString.Empty;

		private ByteString mstSvtProfile_ = ByteString.Empty;

		private ByteString mstSvtRarity_ = ByteString.Empty;

		private ByteString mstSvtScript_ = ByteString.Empty;

		private ByteString mstSvtScriptAdd_ = ByteString.Empty;

		private ByteString mstSvtSkill_ = ByteString.Empty;

		private ByteString mstSvtTreasureDevice_ = ByteString.Empty;

		private ByteString mstSvtVoice_ = ByteString.Empty;

		private ByteString mstSvtVoiceRelation_ = ByteString.Empty;

		private ByteString mstTips_ = ByteString.Empty;

		private ByteString mstTotalLogin_ = ByteString.Empty;

		private ByteString mstTreasureDevice_ = ByteString.Empty;

		private ByteString mstTreasureDeviceDetail_ = ByteString.Empty;

		private ByteString mstTreasureDeviceLv_ = ByteString.Empty;

		private ByteString mstUserExp_ = ByteString.Empty;

		private ByteString mstUserTrem_ = ByteString.Empty;

		private ByteString mstVoice_ = ByteString.Empty;

		private ByteString mstVoiceRelease_ = ByteString.Empty;

		private ByteString mstWar_ = ByteString.Empty;

		private ByteString mstWarBgm_ = ByteString.Empty;

		private ByteString npcDeck_ = ByteString.Empty;

		private ByteString npcFollower_ = ByteString.Empty;

		private ByteString npcSvt_ = ByteString.Empty;

		private ByteString npcSvtDetail_ = ByteString.Empty;

		private ByteString npcSvtFollower_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_DATA.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_DATA> Parser => MST_DATA._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstDataReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public ByteString MstAi
		{
			get => this.mstAi_;
			set => this.mstAi_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstAiAct
		{
			get => this.mstAiAct_;
			set => this.mstAiAct_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstAiField
		{
			get => this.mstAiField_;
			set => this.mstAiField_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstAttriRelation
		{
			get => this.mstAttriRelation_;
			set => this.mstAttriRelation_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBankShop
		{
			get => this.mstBankShop_;
			set => this.mstBankShop_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBanner
		{
			get => this.mstBanner_;
			set => this.mstBanner_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBattleBg
		{
			get => this.mstBattleBg_;
			set => this.mstBattleBg_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBgm
		{
			get => this.mstBgm_;
			set => this.mstBgm_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBoxGacha
		{
			get => this.mstBoxGacha_;
			set => this.mstBoxGacha_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBoxGachaBase
		{
			get => this.mstBoxGachaBase_;
			set => this.mstBoxGachaBase_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBoxGachaBaseDetail
		{
			get => this.mstBoxGachaBaseDetail_;
			set => this.mstBoxGachaBaseDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBoxGachaTalk
		{
			get => this.mstBoxGachaTalk_;
			set => this.mstBoxGachaTalk_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstBuff
		{
			get => this.mstBuff_;
			set => this.mstBuff_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCard
		{
			get => this.mstCard_;
			set => this.mstCard_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstClass
		{
			get => this.mstClass_;
			set => this.mstClass_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstClassRelation
		{
			get => this.mstClassRelation_;
			set => this.mstClassRelation_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstClosedMessage
		{
			get => this.mstClosedMessage_;
			set => this.mstClosedMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCombine
		{
			get => this.mstCombine_;
			set => this.mstCombine_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCombineLimit
		{
			get => this.mstCombineLimit_;
			set => this.mstCombineLimit_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCombineMaterial
		{
			get => this.mstCombineMaterial_;
			set => this.mstCombineMaterial_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCombineQp
		{
			get => this.mstCombineQp_;
			set => this.mstCombineQp_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCombineQpSvtEquip
		{
			get => this.mstCombineQpSvtEquip_;
			set => this.mstCombineQpSvtEquip_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCombineSkill
		{
			get => this.mstCombineSkill_;
			set => this.mstCombineSkill_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCommandSpell
		{
			get => this.mstCommandSpell_;
			set => this.mstCommandSpell_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstConstant
		{
			get => this.mstConstant_;
			set => this.mstConstant_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstConstantStr
		{
			get => this.mstConstantStr_;
			set => this.mstConstantStr_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstCv
		{
			get => this.mstCv_;
			set => this.mstCv_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEffect
		{
			get => this.mstEffect_;
			set => this.mstEffect_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEquip
		{
			get => this.mstEquip_;
			set => this.mstEquip_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEquipExp
		{
			get => this.mstEquipExp_;
			set => this.mstEquipExp_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEquipImage
		{
			get => this.mstEquipImage_;
			set => this.mstEquipImage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEquipSkill
		{
			get => this.mstEquipSkill_;
			set => this.mstEquipSkill_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEvent
		{
			get => this.mstEvent_;
			set => this.mstEvent_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventCampaign
		{
			get => this.mstEventCampaign_;
			set => this.mstEventCampaign_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventDetail
		{
			get => this.mstEventDetail_;
			set => this.mstEventDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventFilter
		{
			get => this.mstEventFilter_;
			set => this.mstEventFilter_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventItemDisplay
		{
			get => this.mstEventItemDisplay_;
			set => this.mstEventItemDisplay_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventItemDisplayGroup
		{
			get => this.mstEventItemDisplayGroup_;
			set => this.mstEventItemDisplayGroup_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventItemDisplayRelease
		{
			get => this.mstEventItemDisplayRelease_;
			set => this.mstEventItemDisplayRelease_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventLoginBonus
		{
			get => this.mstEventLoginBonus_;
			set => this.mstEventLoginBonus_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventLoginCampaign
		{
			get => this.mstEventLoginCampaign_;
			set => this.mstEventLoginCampaign_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventMission
		{
			get => this.mstEventMission_;
			set => this.mstEventMission_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventMissionAction
		{
			get => this.mstEventMissionAction_;
			set => this.mstEventMissionAction_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventMissionCondition
		{
			get => this.mstEventMissionCondition_;
			set => this.mstEventMissionCondition_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventMissionConditionDet
		{
			get => this.mstEventMissionConditionDet_;
			set => this.mstEventMissionConditionDet_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventQuest
		{
			get => this.mstEventQuest_;
			set => this.mstEventQuest_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventReward
		{
			get => this.mstEventReward_;
			set => this.mstEventReward_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventRewardBg
		{
			get => this.mstEventRewardBg_;
			set => this.mstEventRewardBg_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventRewardSet
		{
			get => this.mstEventRewardSet_;
			set => this.mstEventRewardSet_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventSuperBoss
		{
			get => this.mstEventSuperBoss_;
			set => this.mstEventSuperBoss_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventSvt
		{
			get => this.mstEventSvt_;
			set => this.mstEventSvt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstEventTutorial
		{
			get => this.mstEventTutorial_;
			set => this.mstEventTutorial_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstFriendship
		{
			get => this.mstFriendship_;
			set => this.mstFriendship_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstFunc
		{
			get => this.mstFunc_;
			set => this.mstFunc_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstFuncGroup
		{
			get => this.mstFuncGroup_;
			set => this.mstFuncGroup_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGacha
		{
			get => this.mstGacha_;
			set => this.mstGacha_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGachaAdjust
		{
			get => this.mstGachaAdjust_;
			set => this.mstGachaAdjust_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGachaBase
		{
			get => this.mstGachaBase_;
			set => this.mstGachaBase_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGachaBonus
		{
			get => this.mstGachaBonus_;
			set => this.mstGachaBonus_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGameIllustration
		{
			get => this.mstGameIllustration_;
			set => this.mstGameIllustration_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGift
		{
			get => this.mstGift_;
			set => this.mstGift_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstGuide
		{
			get => this.mstGuide_;
			set => this.mstGuide_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstHeroine
		{
			get => this.mstHeroine_;
			set => this.mstHeroine_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstIllustrator
		{
			get => this.mstIllustrator_;
			set => this.mstIllustrator_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstItem
		{
			get => this.mstItem_;
			set => this.mstItem_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstMapGimmick
		{
			get => this.mstMapGimmick_;
			set => this.mstMapGimmick_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstMasterMission
		{
			get => this.mstMasterMission_;
			set => this.mstMasterMission_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstMasterMissionDisplayInfo
		{
			get => this.mstMasterMissionDisplayInfo_;
			set => this.mstMasterMissionDisplayInfo_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstMission
		{
			get => this.mstMission_;
			set => this.mstMission_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstPresentMessage
		{
			get => this.mstPresentMessage_;
			set => this.mstPresentMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuest
		{
			get => this.mstQuest_;
			set => this.mstQuest_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestConsumeItem
		{
			get => this.mstQuestConsumeItem_;
			set => this.mstQuestConsumeItem_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestGroup
		{
			get => this.mstQuestGroup_;
			set => this.mstQuestGroup_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestMessage
		{
			get => this.mstQuestMessage_;
			set => this.mstQuestMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestPhase
		{
			get => this.mstQuestPhase_;
			set => this.mstQuestPhase_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestPhaseDetail
		{
			get => this.mstQuestPhaseDetail_;
			set => this.mstQuestPhaseDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestRelease
		{
			get => this.mstQuestRelease_;
			set => this.mstQuestRelease_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestReset
		{
			get => this.mstQuestReset_;
			set => this.mstQuestReset_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestRestriction
		{
			get => this.mstQuestRestriction_;
			set => this.mstQuestRestriction_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestScript
		{
			get => this.mstQuestScript_;
			set => this.mstQuestScript_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstQuestScriptRelease
		{
			get => this.mstQuestScriptRelease_;
			set => this.mstQuestScriptRelease_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstRecover
		{
			get => this.mstRecover_;
			set => this.mstRecover_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstRestriction
		{
			get => this.mstRestriction_;
			set => this.mstRestriction_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSetItem
		{
			get => this.mstSetItem_;
			set => this.mstSetItem_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstShop
		{
			get => this.mstShop_;
			set => this.mstShop_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstShopDetail
		{
			get => this.mstShopDetail_;
			set => this.mstShopDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstShopRelease
		{
			get => this.mstShopRelease_;
			set => this.mstShopRelease_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstShopScript
		{
			get => this.mstShopScript_;
			set => this.mstShopScript_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSkill
		{
			get => this.mstSkill_;
			set => this.mstSkill_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSkillDetail
		{
			get => this.mstSkillDetail_;
			set => this.mstSkillDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSkillLv
		{
			get => this.mstSkillLv_;
			set => this.mstSkillLv_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSpot
		{
			get => this.mstSpot_;
			set => this.mstSpot_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSpotImage
		{
			get => this.mstSpotImage_;
			set => this.mstSpotImage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSpotRoad
		{
			get => this.mstSpotRoad_;
			set => this.mstSpotRoad_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstStage
		{
			get => this.mstStage_;
			set => this.mstStage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstStoneShop
		{
			get => this.mstStoneShop_;
			set => this.mstStoneShop_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvt
		{
			get => this.mstSvt_;
			set => this.mstSvt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtCard
		{
			get => this.mstSvtCard_;
			set => this.mstSvtCard_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtComment
		{
			get => this.mstSvtComment_;
			set => this.mstSvtComment_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtCommentAdd
		{
			get => this.mstSvtCommentAdd_;
			set => this.mstSvtCommentAdd_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtExceed
		{
			get => this.mstSvtExceed_;
			set => this.mstSvtExceed_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtExp
		{
			get => this.mstSvtExp_;
			set => this.mstSvtExp_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtGroup
		{
			get => this.mstSvtGroup_;
			set => this.mstSvtGroup_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtLimit
		{
			get => this.mstSvtLimit_;
			set => this.mstSvtLimit_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtLimitAdd
		{
			get => this.mstSvtLimitAdd_;
			set => this.mstSvtLimitAdd_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtPassiveSkill
		{
			get => this.mstSvtPassiveSkill_;
			set => this.mstSvtPassiveSkill_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtProfile
		{
			get => this.mstSvtProfile_;
			set => this.mstSvtProfile_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtRarity
		{
			get => this.mstSvtRarity_;
			set => this.mstSvtRarity_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtScript
		{
			get => this.mstSvtScript_;
			set => this.mstSvtScript_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtScriptAdd
		{
			get => this.mstSvtScriptAdd_;
			set => this.mstSvtScriptAdd_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtSkill
		{
			get => this.mstSvtSkill_;
			set => this.mstSvtSkill_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtTreasureDevice
		{
			get => this.mstSvtTreasureDevice_;
			set => this.mstSvtTreasureDevice_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtVoice
		{
			get => this.mstSvtVoice_;
			set => this.mstSvtVoice_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstSvtVoiceRelation
		{
			get => this.mstSvtVoiceRelation_;
			set => this.mstSvtVoiceRelation_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstTips
		{
			get => this.mstTips_;
			set => this.mstTips_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstTotalLogin
		{
			get => this.mstTotalLogin_;
			set => this.mstTotalLogin_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstTreasureDevice
		{
			get => this.mstTreasureDevice_;
			set => this.mstTreasureDevice_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstTreasureDeviceDetail
		{
			get => this.mstTreasureDeviceDetail_;
			set => this.mstTreasureDeviceDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstTreasureDeviceLv
		{
			get => this.mstTreasureDeviceLv_;
			set => this.mstTreasureDeviceLv_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstUserExp
		{
			get => this.mstUserExp_;
			set => this.mstUserExp_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstUserTrem
		{
			get => this.mstUserTrem_;
			set => this.mstUserTrem_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstVoice
		{
			get => this.mstVoice_;
			set => this.mstVoice_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstVoiceRelease
		{
			get => this.mstVoiceRelease_;
			set => this.mstVoiceRelease_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstWar
		{
			get => this.mstWar_;
			set => this.mstWar_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString MstWarBgm
		{
			get => this.mstWarBgm_;
			set => this.mstWarBgm_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString NpcDeck
		{
			get => this.npcDeck_;
			set => this.npcDeck_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString NpcFollower
		{
			get => this.npcFollower_;
			set => this.npcFollower_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString NpcSvt
		{
			get => this.npcSvt_;
			set => this.npcSvt_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString NpcSvtDetail
		{
			get => this.npcSvtDetail_;
			set => this.npcSvtDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public ByteString NpcSvtFollower
		{
			get => this.npcSvtFollower_;
			set => this.npcSvtFollower_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
		}

		[DebuggerNonUserCode]
		public MST_DATA()
		{
		}

		[DebuggerNonUserCode]
		public MST_DATA(MST_DATA other) : this()
		{
			this.mstAi_ = other.mstAi_;
			this.mstAiAct_ = other.mstAiAct_;
			this.mstAiField_ = other.mstAiField_;
			this.mstAttriRelation_ = other.mstAttriRelation_;
			this.mstBankShop_ = other.mstBankShop_;
			this.mstBanner_ = other.mstBanner_;
			this.mstBattleBg_ = other.mstBattleBg_;
			this.mstBgm_ = other.mstBgm_;
			this.mstBoxGacha_ = other.mstBoxGacha_;
			this.mstBoxGachaBase_ = other.mstBoxGachaBase_;
			this.mstBoxGachaBaseDetail_ = other.mstBoxGachaBaseDetail_;
			this.mstBoxGachaTalk_ = other.mstBoxGachaTalk_;
			this.mstBuff_ = other.mstBuff_;
			this.mstCard_ = other.mstCard_;
			this.mstClass_ = other.mstClass_;
			this.mstClassRelation_ = other.mstClassRelation_;
			this.mstClosedMessage_ = other.mstClosedMessage_;
			this.mstCombine_ = other.mstCombine_;
			this.mstCombineLimit_ = other.mstCombineLimit_;
			this.mstCombineMaterial_ = other.mstCombineMaterial_;
			this.mstCombineQp_ = other.mstCombineQp_;
			this.mstCombineQpSvtEquip_ = other.mstCombineQpSvtEquip_;
			this.mstCombineSkill_ = other.mstCombineSkill_;
			this.mstCommandSpell_ = other.mstCommandSpell_;
			this.mstConstant_ = other.mstConstant_;
			this.mstConstantStr_ = other.mstConstantStr_;
			this.mstCv_ = other.mstCv_;
			this.mstEffect_ = other.mstEffect_;
			this.mstEquip_ = other.mstEquip_;
			this.mstEquipExp_ = other.mstEquipExp_;
			this.mstEquipImage_ = other.mstEquipImage_;
			this.mstEquipSkill_ = other.mstEquipSkill_;
			this.mstEvent_ = other.mstEvent_;
			this.mstEventCampaign_ = other.mstEventCampaign_;
			this.mstEventDetail_ = other.mstEventDetail_;
			this.mstEventFilter_ = other.mstEventFilter_;
			this.mstEventItemDisplay_ = other.mstEventItemDisplay_;
			this.mstEventItemDisplayGroup_ = other.mstEventItemDisplayGroup_;
			this.mstEventItemDisplayRelease_ = other.mstEventItemDisplayRelease_;
			this.mstEventLoginBonus_ = other.mstEventLoginBonus_;
			this.mstEventLoginCampaign_ = other.mstEventLoginCampaign_;
			this.mstEventMission_ = other.mstEventMission_;
			this.mstEventMissionAction_ = other.mstEventMissionAction_;
			this.mstEventMissionCondition_ = other.mstEventMissionCondition_;
			this.mstEventMissionConditionDet_ = other.mstEventMissionConditionDet_;
			this.mstEventQuest_ = other.mstEventQuest_;
			this.mstEventReward_ = other.mstEventReward_;
			this.mstEventRewardBg_ = other.mstEventRewardBg_;
			this.mstEventRewardSet_ = other.mstEventRewardSet_;
			this.mstEventSuperBoss_ = other.mstEventSuperBoss_;
			this.mstEventSvt_ = other.mstEventSvt_;
			this.mstEventTutorial_ = other.mstEventTutorial_;
			this.mstFriendship_ = other.mstFriendship_;
			this.mstFunc_ = other.mstFunc_;
			this.mstFuncGroup_ = other.mstFuncGroup_;
			this.mstGacha_ = other.mstGacha_;
			this.mstGachaAdjust_ = other.mstGachaAdjust_;
			this.mstGachaBase_ = other.mstGachaBase_;
			this.mstGachaBonus_ = other.mstGachaBonus_;
			this.mstGameIllustration_ = other.mstGameIllustration_;
			this.mstGift_ = other.mstGift_;
			this.mstGuide_ = other.mstGuide_;
			this.mstHeroine_ = other.mstHeroine_;
			this.mstIllustrator_ = other.mstIllustrator_;
			this.mstItem_ = other.mstItem_;
			this.mstMapGimmick_ = other.mstMapGimmick_;
			this.mstMasterMission_ = other.mstMasterMission_;
			this.mstMasterMissionDisplayInfo_ = other.mstMasterMissionDisplayInfo_;
			this.mstMission_ = other.mstMission_;
			this.mstPresentMessage_ = other.mstPresentMessage_;
			this.mstQuest_ = other.mstQuest_;
			this.mstQuestConsumeItem_ = other.mstQuestConsumeItem_;
			this.mstQuestGroup_ = other.mstQuestGroup_;
			this.mstQuestMessage_ = other.mstQuestMessage_;
			this.mstQuestPhase_ = other.mstQuestPhase_;
			this.mstQuestPhaseDetail_ = other.mstQuestPhaseDetail_;
			this.mstQuestRelease_ = other.mstQuestRelease_;
			this.mstQuestReset_ = other.mstQuestReset_;
			this.mstQuestRestriction_ = other.mstQuestRestriction_;
			this.mstQuestScript_ = other.mstQuestScript_;
			this.mstQuestScriptRelease_ = other.mstQuestScriptRelease_;
			this.mstRecover_ = other.mstRecover_;
			this.mstRestriction_ = other.mstRestriction_;
			this.mstSetItem_ = other.mstSetItem_;
			this.mstShop_ = other.mstShop_;
			this.mstShopDetail_ = other.mstShopDetail_;
			this.mstShopRelease_ = other.mstShopRelease_;
			this.mstShopScript_ = other.mstShopScript_;
			this.mstSkill_ = other.mstSkill_;
			this.mstSkillDetail_ = other.mstSkillDetail_;
			this.mstSkillLv_ = other.mstSkillLv_;
			this.mstSpot_ = other.mstSpot_;
			this.mstSpotImage_ = other.mstSpotImage_;
			this.mstSpotRoad_ = other.mstSpotRoad_;
			this.mstStage_ = other.mstStage_;
			this.mstStoneShop_ = other.mstStoneShop_;
			this.mstSvt_ = other.mstSvt_;
			this.mstSvtCard_ = other.mstSvtCard_;
			this.mstSvtComment_ = other.mstSvtComment_;
			this.mstSvtCommentAdd_ = other.mstSvtCommentAdd_;
			this.mstSvtExceed_ = other.mstSvtExceed_;
			this.mstSvtExp_ = other.mstSvtExp_;
			this.mstSvtGroup_ = other.mstSvtGroup_;
			this.mstSvtLimit_ = other.mstSvtLimit_;
			this.mstSvtLimitAdd_ = other.mstSvtLimitAdd_;
			this.mstSvtPassiveSkill_ = other.mstSvtPassiveSkill_;
			this.mstSvtProfile_ = other.mstSvtProfile_;
			this.mstSvtRarity_ = other.mstSvtRarity_;
			this.mstSvtScript_ = other.mstSvtScript_;
			this.mstSvtScriptAdd_ = other.mstSvtScriptAdd_;
			this.mstSvtSkill_ = other.mstSvtSkill_;
			this.mstSvtTreasureDevice_ = other.mstSvtTreasureDevice_;
			this.mstSvtVoice_ = other.mstSvtVoice_;
			this.mstSvtVoiceRelation_ = other.mstSvtVoiceRelation_;
			this.mstTips_ = other.mstTips_;
			this.mstTotalLogin_ = other.mstTotalLogin_;
			this.mstTreasureDevice_ = other.mstTreasureDevice_;
			this.mstTreasureDeviceDetail_ = other.mstTreasureDeviceDetail_;
			this.mstTreasureDeviceLv_ = other.mstTreasureDeviceLv_;
			this.mstUserExp_ = other.mstUserExp_;
			this.mstUserTrem_ = other.mstUserTrem_;
			this.mstVoice_ = other.mstVoice_;
			this.mstVoiceRelease_ = other.mstVoiceRelease_;
			this.mstWar_ = other.mstWar_;
			this.mstWarBgm_ = other.mstWarBgm_;
			this.npcDeck_ = other.npcDeck_;
			this.npcFollower_ = other.npcFollower_;
			this.npcSvt_ = other.npcSvt_;
			this.npcSvtDetail_ = other.npcSvtDetail_;
			this.npcSvtFollower_ = other.npcSvtFollower_;
		}

		[DebuggerNonUserCode]
		public MST_DATA Clone()
		{
			return new MST_DATA(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_DATA);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_DATA other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (!(this.MstAi != other.MstAi) && !(this.MstAiAct != other.MstAiAct) && !(this.MstAiField != other.MstAiField) && !(this.MstAttriRelation != other.MstAttriRelation) && !(this.MstBankShop != other.MstBankShop) && !(this.MstBanner != other.MstBanner) && !(this.MstBattleBg != other.MstBattleBg) && !(this.MstBgm != other.MstBgm) && !(this.MstBoxGacha != other.MstBoxGacha) && !(this.MstBoxGachaBase != other.MstBoxGachaBase) && !(this.MstBoxGachaBaseDetail != other.MstBoxGachaBaseDetail) && !(this.MstBoxGachaTalk != other.MstBoxGachaTalk) && !(this.MstBuff != other.MstBuff) && !(this.MstCard != other.MstCard) && !(this.MstClass != other.MstClass) && !(this.MstClassRelation != other.MstClassRelation) && !(this.MstClosedMessage != other.MstClosedMessage) && !(this.MstCombine != other.MstCombine) && !(this.MstCombineLimit != other.MstCombineLimit) && !(this.MstCombineMaterial != other.MstCombineMaterial) && !(this.MstCombineQp != other.MstCombineQp) && !(this.MstCombineQpSvtEquip != other.MstCombineQpSvtEquip) && !(this.MstCombineSkill != other.MstCombineSkill) && !(this.MstCommandSpell != other.MstCommandSpell) && !(this.MstConstant != other.MstConstant) && !(this.MstConstantStr != other.MstConstantStr) && !(this.MstCv != other.MstCv) && !(this.MstEffect != other.MstEffect) && !(this.MstEquip != other.MstEquip) && !(this.MstEquipExp != other.MstEquipExp) && !(this.MstEquipImage != other.MstEquipImage) && !(this.MstEquipSkill != other.MstEquipSkill) && !(this.MstEvent != other.MstEvent) && !(this.MstEventCampaign != other.MstEventCampaign) && !(this.MstEventDetail != other.MstEventDetail) && !(this.MstEventFilter != other.MstEventFilter) && !(this.MstEventItemDisplay != other.MstEventItemDisplay) && !(this.MstEventItemDisplayGroup != other.MstEventItemDisplayGroup) && !(this.MstEventItemDisplayRelease != other.MstEventItemDisplayRelease) && !(this.MstEventLoginBonus != other.MstEventLoginBonus) && !(this.MstEventLoginCampaign != other.MstEventLoginCampaign) && !(this.MstEventMission != other.MstEventMission) && !(this.MstEventMissionAction != other.MstEventMissionAction) && !(this.MstEventMissionCondition != other.MstEventMissionCondition) && !(this.MstEventMissionConditionDet != other.MstEventMissionConditionDet) && !(this.MstEventQuest != other.MstEventQuest) && !(this.MstEventReward != other.MstEventReward) && !(this.MstEventRewardBg != other.MstEventRewardBg) && !(this.MstEventRewardSet != other.MstEventRewardSet) && !(this.MstEventSuperBoss != other.MstEventSuperBoss) && !(this.MstEventSvt != other.MstEventSvt) && !(this.MstEventTutorial != other.MstEventTutorial) && !(this.MstFriendship != other.MstFriendship) && !(this.MstFunc != other.MstFunc) && !(this.MstFuncGroup != other.MstFuncGroup) && !(this.MstGacha != other.MstGacha) && !(this.MstGachaAdjust != other.MstGachaAdjust) && !(this.MstGachaBase != other.MstGachaBase) && !(this.MstGachaBonus != other.MstGachaBonus) && !(this.MstGameIllustration != other.MstGameIllustration) && !(this.MstGift != other.MstGift) && !(this.MstGuide != other.MstGuide) && !(this.MstHeroine != other.MstHeroine) && !(this.MstIllustrator != other.MstIllustrator) && !(this.MstItem != other.MstItem) && !(this.MstMapGimmick != other.MstMapGimmick) && !(this.MstMasterMission != other.MstMasterMission) && !(this.MstMasterMissionDisplayInfo != other.MstMasterMissionDisplayInfo) && !(this.MstMission != other.MstMission) && !(this.MstPresentMessage != other.MstPresentMessage) && !(this.MstQuest != other.MstQuest) && !(this.MstQuestConsumeItem != other.MstQuestConsumeItem) && !(this.MstQuestGroup != other.MstQuestGroup) && !(this.MstQuestMessage != other.MstQuestMessage) && !(this.MstQuestPhase != other.MstQuestPhase) && !(this.MstQuestPhaseDetail != other.MstQuestPhaseDetail) && !(this.MstQuestRelease != other.MstQuestRelease) && !(this.MstQuestReset != other.MstQuestReset) && !(this.MstQuestRestriction != other.MstQuestRestriction) && !(this.MstQuestScript != other.MstQuestScript) && !(this.MstQuestScriptRelease != other.MstQuestScriptRelease) && !(this.MstRecover != other.MstRecover) && !(this.MstRestriction != other.MstRestriction) && !(this.MstSetItem != other.MstSetItem) && !(this.MstShop != other.MstShop) && !(this.MstShopDetail != other.MstShopDetail) && !(this.MstShopRelease != other.MstShopRelease) && !(this.MstShopScript != other.MstShopScript) && !(this.MstSkill != other.MstSkill) && !(this.MstSkillDetail != other.MstSkillDetail) && !(this.MstSkillLv != other.MstSkillLv) && !(this.MstSpot != other.MstSpot) && !(this.MstSpotImage != other.MstSpotImage) && !(this.MstSpotRoad != other.MstSpotRoad) && !(this.MstStage != other.MstStage) && !(this.MstStoneShop != other.MstStoneShop) && !(this.MstSvt != other.MstSvt) && !(this.MstSvtCard != other.MstSvtCard) && !(this.MstSvtComment != other.MstSvtComment) && !(this.MstSvtCommentAdd != other.MstSvtCommentAdd) && !(this.MstSvtExceed != other.MstSvtExceed) && !(this.MstSvtExp != other.MstSvtExp) && !(this.MstSvtGroup != other.MstSvtGroup) && !(this.MstSvtLimit != other.MstSvtLimit) && !(this.MstSvtLimitAdd != other.MstSvtLimitAdd) && !(this.MstSvtPassiveSkill != other.MstSvtPassiveSkill) && !(this.MstSvtProfile != other.MstSvtProfile) && !(this.MstSvtRarity != other.MstSvtRarity) && !(this.MstSvtScript != other.MstSvtScript) && !(this.MstSvtScriptAdd != other.MstSvtScriptAdd) && !(this.MstSvtSkill != other.MstSvtSkill) && !(this.MstSvtTreasureDevice != other.MstSvtTreasureDevice) && !(this.MstSvtVoice != other.MstSvtVoice) && !(this.MstSvtVoiceRelation != other.MstSvtVoiceRelation) && !(this.MstTips != other.MstTips) && !(this.MstTotalLogin != other.MstTotalLogin) && !(this.MstTreasureDevice != other.MstTreasureDevice) && !(this.MstTreasureDeviceDetail != other.MstTreasureDeviceDetail) && !(this.MstTreasureDeviceLv != other.MstTreasureDeviceLv) && !(this.MstUserExp != other.MstUserExp) && !(this.MstUserTrem != other.MstUserTrem) && !(this.MstVoice != other.MstVoice) && !(this.MstVoiceRelease != other.MstVoiceRelease) && !(this.MstWar != other.MstWar) && !(this.MstWarBgm != other.MstWarBgm) && !(this.NpcDeck != other.NpcDeck) && !(this.NpcFollower != other.NpcFollower) && !(this.NpcSvt != other.NpcSvt) && !(this.NpcSvtDetail != other.NpcSvtDetail) && !(this.NpcSvtFollower != other.NpcSvtFollower)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MstAi.Length != 0)
			{
				num ^= this.MstAi.GetHashCode();
			}
			if (this.MstAiAct.Length != 0)
			{
				num ^= this.MstAiAct.GetHashCode();
			}
			if (this.MstAiField.Length != 0)
			{
				num ^= this.MstAiField.GetHashCode();
			}
			if (this.MstAttriRelation.Length != 0)
			{
				num ^= this.MstAttriRelation.GetHashCode();
			}
			if (this.MstBankShop.Length != 0)
			{
				num ^= this.MstBankShop.GetHashCode();
			}
			if (this.MstBanner.Length != 0)
			{
				num ^= this.MstBanner.GetHashCode();
			}
			if (this.MstBattleBg.Length != 0)
			{
				num ^= this.MstBattleBg.GetHashCode();
			}
			if (this.MstBgm.Length != 0)
			{
				num ^= this.MstBgm.GetHashCode();
			}
			if (this.MstBoxGacha.Length != 0)
			{
				num ^= this.MstBoxGacha.GetHashCode();
			}
			if (this.MstBoxGachaBase.Length != 0)
			{
				num ^= this.MstBoxGachaBase.GetHashCode();
			}
			if (this.MstBoxGachaBaseDetail.Length != 0)
			{
				num ^= this.MstBoxGachaBaseDetail.GetHashCode();
			}
			if (this.MstBoxGachaTalk.Length != 0)
			{
				num ^= this.MstBoxGachaTalk.GetHashCode();
			}
			if (this.MstBuff.Length != 0)
			{
				num ^= this.MstBuff.GetHashCode();
			}
			if (this.MstCard.Length != 0)
			{
				num ^= this.MstCard.GetHashCode();
			}
			if (this.MstClass.Length != 0)
			{
				num ^= this.MstClass.GetHashCode();
			}
			if (this.MstClassRelation.Length != 0)
			{
				num ^= this.MstClassRelation.GetHashCode();
			}
			if (this.MstClosedMessage.Length != 0)
			{
				num ^= this.MstClosedMessage.GetHashCode();
			}
			if (this.MstCombine.Length != 0)
			{
				num ^= this.MstCombine.GetHashCode();
			}
			if (this.MstCombineLimit.Length != 0)
			{
				num ^= this.MstCombineLimit.GetHashCode();
			}
			if (this.MstCombineMaterial.Length != 0)
			{
				num ^= this.MstCombineMaterial.GetHashCode();
			}
			if (this.MstCombineQp.Length != 0)
			{
				num ^= this.MstCombineQp.GetHashCode();
			}
			if (this.MstCombineQpSvtEquip.Length != 0)
			{
				num ^= this.MstCombineQpSvtEquip.GetHashCode();
			}
			if (this.MstCombineSkill.Length != 0)
			{
				num ^= this.MstCombineSkill.GetHashCode();
			}
			if (this.MstCommandSpell.Length != 0)
			{
				num ^= this.MstCommandSpell.GetHashCode();
			}
			if (this.MstConstant.Length != 0)
			{
				num ^= this.MstConstant.GetHashCode();
			}
			if (this.MstConstantStr.Length != 0)
			{
				num ^= this.MstConstantStr.GetHashCode();
			}
			if (this.MstCv.Length != 0)
			{
				num ^= this.MstCv.GetHashCode();
			}
			if (this.MstEffect.Length != 0)
			{
				num ^= this.MstEffect.GetHashCode();
			}
			if (this.MstEquip.Length != 0)
			{
				num ^= this.MstEquip.GetHashCode();
			}
			if (this.MstEquipExp.Length != 0)
			{
				num ^= this.MstEquipExp.GetHashCode();
			}
			if (this.MstEquipImage.Length != 0)
			{
				num ^= this.MstEquipImage.GetHashCode();
			}
			if (this.MstEquipSkill.Length != 0)
			{
				num ^= this.MstEquipSkill.GetHashCode();
			}
			if (this.MstEvent.Length != 0)
			{
				num ^= this.MstEvent.GetHashCode();
			}
			if (this.MstEventCampaign.Length != 0)
			{
				num ^= this.MstEventCampaign.GetHashCode();
			}
			if (this.MstEventDetail.Length != 0)
			{
				num ^= this.MstEventDetail.GetHashCode();
			}
			if (this.MstEventFilter.Length != 0)
			{
				num ^= this.MstEventFilter.GetHashCode();
			}
			if (this.MstEventItemDisplay.Length != 0)
			{
				num ^= this.MstEventItemDisplay.GetHashCode();
			}
			if (this.MstEventItemDisplayGroup.Length != 0)
			{
				num ^= this.MstEventItemDisplayGroup.GetHashCode();
			}
			if (this.MstEventItemDisplayRelease.Length != 0)
			{
				num ^= this.MstEventItemDisplayRelease.GetHashCode();
			}
			if (this.MstEventLoginBonus.Length != 0)
			{
				num ^= this.MstEventLoginBonus.GetHashCode();
			}
			if (this.MstEventLoginCampaign.Length != 0)
			{
				num ^= this.MstEventLoginCampaign.GetHashCode();
			}
			if (this.MstEventMission.Length != 0)
			{
				num ^= this.MstEventMission.GetHashCode();
			}
			if (this.MstEventMissionAction.Length != 0)
			{
				num ^= this.MstEventMissionAction.GetHashCode();
			}
			if (this.MstEventMissionCondition.Length != 0)
			{
				num ^= this.MstEventMissionCondition.GetHashCode();
			}
			if (this.MstEventMissionConditionDet.Length != 0)
			{
				num ^= this.MstEventMissionConditionDet.GetHashCode();
			}
			if (this.MstEventQuest.Length != 0)
			{
				num ^= this.MstEventQuest.GetHashCode();
			}
			if (this.MstEventReward.Length != 0)
			{
				num ^= this.MstEventReward.GetHashCode();
			}
			if (this.MstEventRewardBg.Length != 0)
			{
				num ^= this.MstEventRewardBg.GetHashCode();
			}
			if (this.MstEventRewardSet.Length != 0)
			{
				num ^= this.MstEventRewardSet.GetHashCode();
			}
			if (this.MstEventSuperBoss.Length != 0)
			{
				num ^= this.MstEventSuperBoss.GetHashCode();
			}
			if (this.MstEventSvt.Length != 0)
			{
				num ^= this.MstEventSvt.GetHashCode();
			}
			if (this.MstEventTutorial.Length != 0)
			{
				num ^= this.MstEventTutorial.GetHashCode();
			}
			if (this.MstFriendship.Length != 0)
			{
				num ^= this.MstFriendship.GetHashCode();
			}
			if (this.MstFunc.Length != 0)
			{
				num ^= this.MstFunc.GetHashCode();
			}
			if (this.MstFuncGroup.Length != 0)
			{
				num ^= this.MstFuncGroup.GetHashCode();
			}
			if (this.MstGacha.Length != 0)
			{
				num ^= this.MstGacha.GetHashCode();
			}
			if (this.MstGachaAdjust.Length != 0)
			{
				num ^= this.MstGachaAdjust.GetHashCode();
			}
			if (this.MstGachaBase.Length != 0)
			{
				num ^= this.MstGachaBase.GetHashCode();
			}
			if (this.MstGachaBonus.Length != 0)
			{
				num ^= this.MstGachaBonus.GetHashCode();
			}
			if (this.MstGameIllustration.Length != 0)
			{
				num ^= this.MstGameIllustration.GetHashCode();
			}
			if (this.MstGift.Length != 0)
			{
				num ^= this.MstGift.GetHashCode();
			}
			if (this.MstGuide.Length != 0)
			{
				num ^= this.MstGuide.GetHashCode();
			}
			if (this.MstHeroine.Length != 0)
			{
				num ^= this.MstHeroine.GetHashCode();
			}
			if (this.MstIllustrator.Length != 0)
			{
				num ^= this.MstIllustrator.GetHashCode();
			}
			if (this.MstItem.Length != 0)
			{
				num ^= this.MstItem.GetHashCode();
			}
			if (this.MstMapGimmick.Length != 0)
			{
				num ^= this.MstMapGimmick.GetHashCode();
			}
			if (this.MstMasterMission.Length != 0)
			{
				num ^= this.MstMasterMission.GetHashCode();
			}
			if (this.MstMasterMissionDisplayInfo.Length != 0)
			{
				num ^= this.MstMasterMissionDisplayInfo.GetHashCode();
			}
			if (this.MstMission.Length != 0)
			{
				num ^= this.MstMission.GetHashCode();
			}
			if (this.MstPresentMessage.Length != 0)
			{
				num ^= this.MstPresentMessage.GetHashCode();
			}
			if (this.MstQuest.Length != 0)
			{
				num ^= this.MstQuest.GetHashCode();
			}
			if (this.MstQuestConsumeItem.Length != 0)
			{
				num ^= this.MstQuestConsumeItem.GetHashCode();
			}
			if (this.MstQuestGroup.Length != 0)
			{
				num ^= this.MstQuestGroup.GetHashCode();
			}
			if (this.MstQuestMessage.Length != 0)
			{
				num ^= this.MstQuestMessage.GetHashCode();
			}
			if (this.MstQuestPhase.Length != 0)
			{
				num ^= this.MstQuestPhase.GetHashCode();
			}
			if (this.MstQuestPhaseDetail.Length != 0)
			{
				num ^= this.MstQuestPhaseDetail.GetHashCode();
			}
			if (this.MstQuestRelease.Length != 0)
			{
				num ^= this.MstQuestRelease.GetHashCode();
			}
			if (this.MstQuestReset.Length != 0)
			{
				num ^= this.MstQuestReset.GetHashCode();
			}
			if (this.MstQuestRestriction.Length != 0)
			{
				num ^= this.MstQuestRestriction.GetHashCode();
			}
			if (this.MstQuestScript.Length != 0)
			{
				num ^= this.MstQuestScript.GetHashCode();
			}
			if (this.MstQuestScriptRelease.Length != 0)
			{
				num ^= this.MstQuestScriptRelease.GetHashCode();
			}
			if (this.MstRecover.Length != 0)
			{
				num ^= this.MstRecover.GetHashCode();
			}
			if (this.MstRestriction.Length != 0)
			{
				num ^= this.MstRestriction.GetHashCode();
			}
			if (this.MstSetItem.Length != 0)
			{
				num ^= this.MstSetItem.GetHashCode();
			}
			if (this.MstShop.Length != 0)
			{
				num ^= this.MstShop.GetHashCode();
			}
			if (this.MstShopDetail.Length != 0)
			{
				num ^= this.MstShopDetail.GetHashCode();
			}
			if (this.MstShopRelease.Length != 0)
			{
				num ^= this.MstShopRelease.GetHashCode();
			}
			if (this.MstShopScript.Length != 0)
			{
				num ^= this.MstShopScript.GetHashCode();
			}
			if (this.MstSkill.Length != 0)
			{
				num ^= this.MstSkill.GetHashCode();
			}
			if (this.MstSkillDetail.Length != 0)
			{
				num ^= this.MstSkillDetail.GetHashCode();
			}
			if (this.MstSkillLv.Length != 0)
			{
				num ^= this.MstSkillLv.GetHashCode();
			}
			if (this.MstSpot.Length != 0)
			{
				num ^= this.MstSpot.GetHashCode();
			}
			if (this.MstSpotImage.Length != 0)
			{
				num ^= this.MstSpotImage.GetHashCode();
			}
			if (this.MstSpotRoad.Length != 0)
			{
				num ^= this.MstSpotRoad.GetHashCode();
			}
			if (this.MstStage.Length != 0)
			{
				num ^= this.MstStage.GetHashCode();
			}
			if (this.MstStoneShop.Length != 0)
			{
				num ^= this.MstStoneShop.GetHashCode();
			}
			if (this.MstSvt.Length != 0)
			{
				num ^= this.MstSvt.GetHashCode();
			}
			if (this.MstSvtCard.Length != 0)
			{
				num ^= this.MstSvtCard.GetHashCode();
			}
			if (this.MstSvtComment.Length != 0)
			{
				num ^= this.MstSvtComment.GetHashCode();
			}
			if (this.MstSvtCommentAdd.Length != 0)
			{
				num ^= this.MstSvtCommentAdd.GetHashCode();
			}
			if (this.MstSvtExceed.Length != 0)
			{
				num ^= this.MstSvtExceed.GetHashCode();
			}
			if (this.MstSvtExp.Length != 0)
			{
				num ^= this.MstSvtExp.GetHashCode();
			}
			if (this.MstSvtGroup.Length != 0)
			{
				num ^= this.MstSvtGroup.GetHashCode();
			}
			if (this.MstSvtLimit.Length != 0)
			{
				num ^= this.MstSvtLimit.GetHashCode();
			}
			if (this.MstSvtLimitAdd.Length != 0)
			{
				num ^= this.MstSvtLimitAdd.GetHashCode();
			}
			if (this.MstSvtPassiveSkill.Length != 0)
			{
				num ^= this.MstSvtPassiveSkill.GetHashCode();
			}
			if (this.MstSvtProfile.Length != 0)
			{
				num ^= this.MstSvtProfile.GetHashCode();
			}
			if (this.MstSvtRarity.Length != 0)
			{
				num ^= this.MstSvtRarity.GetHashCode();
			}
			if (this.MstSvtScript.Length != 0)
			{
				num ^= this.MstSvtScript.GetHashCode();
			}
			if (this.MstSvtScriptAdd.Length != 0)
			{
				num ^= this.MstSvtScriptAdd.GetHashCode();
			}
			if (this.MstSvtSkill.Length != 0)
			{
				num ^= this.MstSvtSkill.GetHashCode();
			}
			if (this.MstSvtTreasureDevice.Length != 0)
			{
				num ^= this.MstSvtTreasureDevice.GetHashCode();
			}
			if (this.MstSvtVoice.Length != 0)
			{
				num ^= this.MstSvtVoice.GetHashCode();
			}
			if (this.MstSvtVoiceRelation.Length != 0)
			{
				num ^= this.MstSvtVoiceRelation.GetHashCode();
			}
			if (this.MstTips.Length != 0)
			{
				num ^= this.MstTips.GetHashCode();
			}
			if (this.MstTotalLogin.Length != 0)
			{
				num ^= this.MstTotalLogin.GetHashCode();
			}
			if (this.MstTreasureDevice.Length != 0)
			{
				num ^= this.MstTreasureDevice.GetHashCode();
			}
			if (this.MstTreasureDeviceDetail.Length != 0)
			{
				num ^= this.MstTreasureDeviceDetail.GetHashCode();
			}
			if (this.MstTreasureDeviceLv.Length != 0)
			{
				num ^= this.MstTreasureDeviceLv.GetHashCode();
			}
			if (this.MstUserExp.Length != 0)
			{
				num ^= this.MstUserExp.GetHashCode();
			}
			if (this.MstUserTrem.Length != 0)
			{
				num ^= this.MstUserTrem.GetHashCode();
			}
			if (this.MstVoice.Length != 0)
			{
				num ^= this.MstVoice.GetHashCode();
			}
			if (this.MstVoiceRelease.Length != 0)
			{
				num ^= this.MstVoiceRelease.GetHashCode();
			}
			if (this.MstWar.Length != 0)
			{
				num ^= this.MstWar.GetHashCode();
			}
			if (this.MstWarBgm.Length != 0)
			{
				num ^= this.MstWarBgm.GetHashCode();
			}
			if (this.NpcDeck.Length != 0)
			{
				num ^= this.NpcDeck.GetHashCode();
			}
			if (this.NpcFollower.Length != 0)
			{
				num ^= this.NpcFollower.GetHashCode();
			}
			if (this.NpcSvt.Length != 0)
			{
				num ^= this.NpcSvt.GetHashCode();
			}
			if (this.NpcSvtDetail.Length != 0)
			{
				num ^= this.NpcSvtDetail.GetHashCode();
			}
			if (this.NpcSvtFollower.Length != 0)
			{
				num ^= this.NpcSvtFollower.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (this.MstAi.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.MstAi);
			}
			if (this.MstAiAct.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.MstAiAct);
			}
			if (this.MstAiField.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.MstAiField);
			}
			if (this.MstAttriRelation.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.MstAttriRelation);
			}
			if (this.MstBankShop.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.MstBankShop);
			}
			if (this.MstBanner.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.MstBanner);
			}
			if (this.MstBattleBg.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.MstBattleBg);
			}
			if (this.MstBgm.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.MstBgm);
			}
			if (this.MstBoxGacha.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.MstBoxGacha);
			}
			if (this.MstBoxGachaBase.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.MstBoxGachaBase);
			}
			if (this.MstBoxGachaBaseDetail.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.MstBoxGachaBaseDetail);
			}
			if (this.MstBoxGachaTalk.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.MstBoxGachaTalk);
			}
			if (this.MstBuff.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteBytes(this.MstBuff);
			}
			if (this.MstCard.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteBytes(this.MstCard);
			}
			if (this.MstClass.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.MstClass);
			}
			if (this.MstClassRelation.Length != 0)
			{
				output.WriteRawTag(130, 1);
				output.WriteBytes(this.MstClassRelation);
			}
			if (this.MstClosedMessage.Length != 0)
			{
				output.WriteRawTag(138, 1);
				output.WriteBytes(this.MstClosedMessage);
			}
			if (this.MstCombine.Length != 0)
			{
				output.WriteRawTag(146, 1);
				output.WriteBytes(this.MstCombine);
			}
			if (this.MstCombineLimit.Length != 0)
			{
				output.WriteRawTag(154, 1);
				output.WriteBytes(this.MstCombineLimit);
			}
			if (this.MstCombineMaterial.Length != 0)
			{
				output.WriteRawTag(162, 1);
				output.WriteBytes(this.MstCombineMaterial);
			}
			if (this.MstCombineQp.Length != 0)
			{
				output.WriteRawTag(170, 1);
				output.WriteBytes(this.MstCombineQp);
			}
			if (this.MstCombineQpSvtEquip.Length != 0)
			{
				output.WriteRawTag(178, 1);
				output.WriteBytes(this.MstCombineQpSvtEquip);
			}
			if (this.MstCombineSkill.Length != 0)
			{
				output.WriteRawTag(186, 1);
				output.WriteBytes(this.MstCombineSkill);
			}
			if (this.MstCommandSpell.Length != 0)
			{
				output.WriteRawTag(194, 1);
				output.WriteBytes(this.MstCommandSpell);
			}
			if (this.MstConstant.Length != 0)
			{
				output.WriteRawTag(202, 1);
				output.WriteBytes(this.MstConstant);
			}
			if (this.MstConstantStr.Length != 0)
			{
				output.WriteRawTag(210, 1);
				output.WriteBytes(this.MstConstantStr);
			}
			if (this.MstCv.Length != 0)
			{
				output.WriteRawTag(218, 1);
				output.WriteBytes(this.MstCv);
			}
			if (this.MstEffect.Length != 0)
			{
				output.WriteRawTag(226, 1);
				output.WriteBytes(this.MstEffect);
			}
			if (this.MstEquip.Length != 0)
			{
				output.WriteRawTag(234, 1);
				output.WriteBytes(this.MstEquip);
			}
			if (this.MstEquipExp.Length != 0)
			{
				output.WriteRawTag(242, 1);
				output.WriteBytes(this.MstEquipExp);
			}
			if (this.MstEquipImage.Length != 0)
			{
				output.WriteRawTag(250, 1);
				output.WriteBytes(this.MstEquipImage);
			}
			if (this.MstEquipSkill.Length != 0)
			{
				output.WriteRawTag(130, 2);
				output.WriteBytes(this.MstEquipSkill);
			}
			if (this.MstEvent.Length != 0)
			{
				output.WriteRawTag(138, 2);
				output.WriteBytes(this.MstEvent);
			}
			if (this.MstEventCampaign.Length != 0)
			{
				output.WriteRawTag(146, 2);
				output.WriteBytes(this.MstEventCampaign);
			}
			if (this.MstEventDetail.Length != 0)
			{
				output.WriteRawTag(154, 2);
				output.WriteBytes(this.MstEventDetail);
			}
			if (this.MstEventFilter.Length != 0)
			{
				output.WriteRawTag(162, 2);
				output.WriteBytes(this.MstEventFilter);
			}
			if (this.MstEventItemDisplay.Length != 0)
			{
				output.WriteRawTag(170, 2);
				output.WriteBytes(this.MstEventItemDisplay);
			}
			if (this.MstEventItemDisplayGroup.Length != 0)
			{
				output.WriteRawTag(178, 2);
				output.WriteBytes(this.MstEventItemDisplayGroup);
			}
			if (this.MstEventItemDisplayRelease.Length != 0)
			{
				output.WriteRawTag(186, 2);
				output.WriteBytes(this.MstEventItemDisplayRelease);
			}
			if (this.MstEventLoginBonus.Length != 0)
			{
				output.WriteRawTag(194, 2);
				output.WriteBytes(this.MstEventLoginBonus);
			}
			if (this.MstEventLoginCampaign.Length != 0)
			{
				output.WriteRawTag(202, 2);
				output.WriteBytes(this.MstEventLoginCampaign);
			}
			if (this.MstEventMission.Length != 0)
			{
				output.WriteRawTag(210, 2);
				output.WriteBytes(this.MstEventMission);
			}
			if (this.MstEventMissionAction.Length != 0)
			{
				output.WriteRawTag(218, 2);
				output.WriteBytes(this.MstEventMissionAction);
			}
			if (this.MstEventMissionCondition.Length != 0)
			{
				output.WriteRawTag(226, 2);
				output.WriteBytes(this.MstEventMissionCondition);
			}
			if (this.MstEventMissionConditionDet.Length != 0)
			{
				output.WriteRawTag(234, 2);
				output.WriteBytes(this.MstEventMissionConditionDet);
			}
			if (this.MstEventQuest.Length != 0)
			{
				output.WriteRawTag(242, 2);
				output.WriteBytes(this.MstEventQuest);
			}
			if (this.MstEventReward.Length != 0)
			{
				output.WriteRawTag(250, 2);
				output.WriteBytes(this.MstEventReward);
			}
			if (this.MstEventRewardBg.Length != 0)
			{
				output.WriteRawTag(130, 3);
				output.WriteBytes(this.MstEventRewardBg);
			}
			if (this.MstEventRewardSet.Length != 0)
			{
				output.WriteRawTag(138, 3);
				output.WriteBytes(this.MstEventRewardSet);
			}
			if (this.MstEventSuperBoss.Length != 0)
			{
				output.WriteRawTag(146, 3);
				output.WriteBytes(this.MstEventSuperBoss);
			}
			if (this.MstEventSvt.Length != 0)
			{
				output.WriteRawTag(154, 3);
				output.WriteBytes(this.MstEventSvt);
			}
			if (this.MstEventTutorial.Length != 0)
			{
				output.WriteRawTag(162, 3);
				output.WriteBytes(this.MstEventTutorial);
			}
			if (this.MstFriendship.Length != 0)
			{
				output.WriteRawTag(170, 3);
				output.WriteBytes(this.MstFriendship);
			}
			if (this.MstFunc.Length != 0)
			{
				output.WriteRawTag(178, 3);
				output.WriteBytes(this.MstFunc);
			}
			if (this.MstFuncGroup.Length != 0)
			{
				output.WriteRawTag(186, 3);
				output.WriteBytes(this.MstFuncGroup);
			}
			if (this.MstGacha.Length != 0)
			{
				output.WriteRawTag(194, 3);
				output.WriteBytes(this.MstGacha);
			}
			if (this.MstGachaAdjust.Length != 0)
			{
				output.WriteRawTag(202, 3);
				output.WriteBytes(this.MstGachaAdjust);
			}
			if (this.MstGachaBase.Length != 0)
			{
				output.WriteRawTag(210, 3);
				output.WriteBytes(this.MstGachaBase);
			}
			if (this.MstGachaBonus.Length != 0)
			{
				output.WriteRawTag(218, 3);
				output.WriteBytes(this.MstGachaBonus);
			}
			if (this.MstGameIllustration.Length != 0)
			{
				output.WriteRawTag(226, 3);
				output.WriteBytes(this.MstGameIllustration);
			}
			if (this.MstGift.Length != 0)
			{
				output.WriteRawTag(234, 3);
				output.WriteBytes(this.MstGift);
			}
			if (this.MstGuide.Length != 0)
			{
				output.WriteRawTag(242, 3);
				output.WriteBytes(this.MstGuide);
			}
			if (this.MstHeroine.Length != 0)
			{
				output.WriteRawTag(250, 3);
				output.WriteBytes(this.MstHeroine);
			}
			if (this.MstIllustrator.Length != 0)
			{
				output.WriteRawTag(130, 4);
				output.WriteBytes(this.MstIllustrator);
			}
			if (this.MstItem.Length != 0)
			{
				output.WriteRawTag(138, 4);
				output.WriteBytes(this.MstItem);
			}
			if (this.MstMapGimmick.Length != 0)
			{
				output.WriteRawTag(146, 4);
				output.WriteBytes(this.MstMapGimmick);
			}
			if (this.MstMasterMission.Length != 0)
			{
				output.WriteRawTag(154, 4);
				output.WriteBytes(this.MstMasterMission);
			}
			if (this.MstMasterMissionDisplayInfo.Length != 0)
			{
				output.WriteRawTag(162, 4);
				output.WriteBytes(this.MstMasterMissionDisplayInfo);
			}
			if (this.MstMission.Length != 0)
			{
				output.WriteRawTag(170, 4);
				output.WriteBytes(this.MstMission);
			}
			if (this.MstPresentMessage.Length != 0)
			{
				output.WriteRawTag(178, 4);
				output.WriteBytes(this.MstPresentMessage);
			}
			if (this.MstQuest.Length != 0)
			{
				output.WriteRawTag(186, 4);
				output.WriteBytes(this.MstQuest);
			}
			if (this.MstQuestConsumeItem.Length != 0)
			{
				output.WriteRawTag(194, 4);
				output.WriteBytes(this.MstQuestConsumeItem);
			}
			if (this.MstQuestGroup.Length != 0)
			{
				output.WriteRawTag(202, 4);
				output.WriteBytes(this.MstQuestGroup);
			}
			if (this.MstQuestMessage.Length != 0)
			{
				output.WriteRawTag(210, 4);
				output.WriteBytes(this.MstQuestMessage);
			}
			if (this.MstQuestPhase.Length != 0)
			{
				output.WriteRawTag(218, 4);
				output.WriteBytes(this.MstQuestPhase);
			}
			if (this.MstQuestPhaseDetail.Length != 0)
			{
				output.WriteRawTag(226, 4);
				output.WriteBytes(this.MstQuestPhaseDetail);
			}
			if (this.MstQuestRelease.Length != 0)
			{
				output.WriteRawTag(234, 4);
				output.WriteBytes(this.MstQuestRelease);
			}
			if (this.MstQuestReset.Length != 0)
			{
				output.WriteRawTag(242, 4);
				output.WriteBytes(this.MstQuestReset);
			}
			if (this.MstQuestRestriction.Length != 0)
			{
				output.WriteRawTag(250, 4);
				output.WriteBytes(this.MstQuestRestriction);
			}
			if (this.MstQuestScript.Length != 0)
			{
				output.WriteRawTag(130, 5);
				output.WriteBytes(this.MstQuestScript);
			}
			if (this.MstQuestScriptRelease.Length != 0)
			{
				output.WriteRawTag(138, 5);
				output.WriteBytes(this.MstQuestScriptRelease);
			}
			if (this.MstRecover.Length != 0)
			{
				output.WriteRawTag(146, 5);
				output.WriteBytes(this.MstRecover);
			}
			if (this.MstRestriction.Length != 0)
			{
				output.WriteRawTag(154, 5);
				output.WriteBytes(this.MstRestriction);
			}
			if (this.MstSetItem.Length != 0)
			{
				output.WriteRawTag(162, 5);
				output.WriteBytes(this.MstSetItem);
			}
			if (this.MstShop.Length != 0)
			{
				output.WriteRawTag(170, 5);
				output.WriteBytes(this.MstShop);
			}
			if (this.MstShopDetail.Length != 0)
			{
				output.WriteRawTag(178, 5);
				output.WriteBytes(this.MstShopDetail);
			}
			if (this.MstShopRelease.Length != 0)
			{
				output.WriteRawTag(186, 5);
				output.WriteBytes(this.MstShopRelease);
			}
			if (this.MstShopScript.Length != 0)
			{
				output.WriteRawTag(194, 5);
				output.WriteBytes(this.MstShopScript);
			}
			if (this.MstSkill.Length != 0)
			{
				output.WriteRawTag(202, 5);
				output.WriteBytes(this.MstSkill);
			}
			if (this.MstSkillDetail.Length != 0)
			{
				output.WriteRawTag(210, 5);
				output.WriteBytes(this.MstSkillDetail);
			}
			if (this.MstSkillLv.Length != 0)
			{
				output.WriteRawTag(218, 5);
				output.WriteBytes(this.MstSkillLv);
			}
			if (this.MstSpot.Length != 0)
			{
				output.WriteRawTag(226, 5);
				output.WriteBytes(this.MstSpot);
			}
			if (this.MstSpotImage.Length != 0)
			{
				output.WriteRawTag(234, 5);
				output.WriteBytes(this.MstSpotImage);
			}
			if (this.MstSpotRoad.Length != 0)
			{
				output.WriteRawTag(242, 5);
				output.WriteBytes(this.MstSpotRoad);
			}
			if (this.MstStage.Length != 0)
			{
				output.WriteRawTag(250, 5);
				output.WriteBytes(this.MstStage);
			}
			if (this.MstStoneShop.Length != 0)
			{
				output.WriteRawTag(130, 6);
				output.WriteBytes(this.MstStoneShop);
			}
			if (this.MstSvt.Length != 0)
			{
				output.WriteRawTag(138, 6);
				output.WriteBytes(this.MstSvt);
			}
			if (this.MstSvtCard.Length != 0)
			{
				output.WriteRawTag(146, 6);
				output.WriteBytes(this.MstSvtCard);
			}
			if (this.MstSvtComment.Length != 0)
			{
				output.WriteRawTag(154, 6);
				output.WriteBytes(this.MstSvtComment);
			}
			if (this.MstSvtCommentAdd.Length != 0)
			{
				output.WriteRawTag(162, 6);
				output.WriteBytes(this.MstSvtCommentAdd);
			}
			if (this.MstSvtExceed.Length != 0)
			{
				output.WriteRawTag(170, 6);
				output.WriteBytes(this.MstSvtExceed);
			}
			if (this.MstSvtExp.Length != 0)
			{
				output.WriteRawTag(178, 6);
				output.WriteBytes(this.MstSvtExp);
			}
			if (this.MstSvtGroup.Length != 0)
			{
				output.WriteRawTag(186, 6);
				output.WriteBytes(this.MstSvtGroup);
			}
			if (this.MstSvtLimit.Length != 0)
			{
				output.WriteRawTag(194, 6);
				output.WriteBytes(this.MstSvtLimit);
			}
			if (this.MstSvtLimitAdd.Length != 0)
			{
				output.WriteRawTag(202, 6);
				output.WriteBytes(this.MstSvtLimitAdd);
			}
			if (this.MstSvtPassiveSkill.Length != 0)
			{
				output.WriteRawTag(210, 6);
				output.WriteBytes(this.MstSvtPassiveSkill);
			}
			if (this.MstSvtProfile.Length != 0)
			{
				output.WriteRawTag(218, 6);
				output.WriteBytes(this.MstSvtProfile);
			}
			if (this.MstSvtRarity.Length != 0)
			{
				output.WriteRawTag(226, 6);
				output.WriteBytes(this.MstSvtRarity);
			}
			if (this.MstSvtScript.Length != 0)
			{
				output.WriteRawTag(234, 6);
				output.WriteBytes(this.MstSvtScript);
			}
			if (this.MstSvtScriptAdd.Length != 0)
			{
				output.WriteRawTag(242, 6);
				output.WriteBytes(this.MstSvtScriptAdd);
			}
			if (this.MstSvtSkill.Length != 0)
			{
				output.WriteRawTag(250, 6);
				output.WriteBytes(this.MstSvtSkill);
			}
			if (this.MstSvtTreasureDevice.Length != 0)
			{
				output.WriteRawTag(130, 7);
				output.WriteBytes(this.MstSvtTreasureDevice);
			}
			if (this.MstSvtVoice.Length != 0)
			{
				output.WriteRawTag(138, 7);
				output.WriteBytes(this.MstSvtVoice);
			}
			if (this.MstSvtVoiceRelation.Length != 0)
			{
				output.WriteRawTag(146, 7);
				output.WriteBytes(this.MstSvtVoiceRelation);
			}
			if (this.MstTips.Length != 0)
			{
				output.WriteRawTag(154, 7);
				output.WriteBytes(this.MstTips);
			}
			if (this.MstTotalLogin.Length != 0)
			{
				output.WriteRawTag(162, 7);
				output.WriteBytes(this.MstTotalLogin);
			}
			if (this.MstTreasureDevice.Length != 0)
			{
				output.WriteRawTag(170, 7);
				output.WriteBytes(this.MstTreasureDevice);
			}
			if (this.MstTreasureDeviceDetail.Length != 0)
			{
				output.WriteRawTag(178, 7);
				output.WriteBytes(this.MstTreasureDeviceDetail);
			}
			if (this.MstTreasureDeviceLv.Length != 0)
			{
				output.WriteRawTag(186, 7);
				output.WriteBytes(this.MstTreasureDeviceLv);
			}
			if (this.MstUserExp.Length != 0)
			{
				output.WriteRawTag(194, 7);
				output.WriteBytes(this.MstUserExp);
			}
			if (this.MstUserTrem.Length != 0)
			{
				output.WriteRawTag(202, 7);
				output.WriteBytes(this.MstUserTrem);
			}
			if (this.MstVoice.Length != 0)
			{
				output.WriteRawTag(210, 7);
				output.WriteBytes(this.MstVoice);
			}
			if (this.MstVoiceRelease.Length != 0)
			{
				output.WriteRawTag(218, 7);
				output.WriteBytes(this.MstVoiceRelease);
			}
			if (this.MstWar.Length != 0)
			{
				output.WriteRawTag(226, 7);
				output.WriteBytes(this.MstWar);
			}
			if (this.MstWarBgm.Length != 0)
			{
				output.WriteRawTag(234, 7);
				output.WriteBytes(this.MstWarBgm);
			}
			if (this.NpcDeck.Length != 0)
			{
				output.WriteRawTag(242, 7);
				output.WriteBytes(this.NpcDeck);
			}
			if (this.NpcFollower.Length != 0)
			{
				output.WriteRawTag(250, 7);
				output.WriteBytes(this.NpcFollower);
			}
			if (this.NpcSvt.Length != 0)
			{
				output.WriteRawTag(130, 8);
				output.WriteBytes(this.NpcSvt);
			}
			if (this.NpcSvtDetail.Length != 0)
			{
				output.WriteRawTag(138, 8);
				output.WriteBytes(this.NpcSvtDetail);
			}
			if (this.NpcSvtFollower.Length != 0)
			{
				output.WriteRawTag(146, 8);
				output.WriteBytes(this.NpcSvtFollower);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MstAi.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstAi);
			}
			if (this.MstAiAct.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstAiAct);
			}
			if (this.MstAiField.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstAiField);
			}
			if (this.MstAttriRelation.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstAttriRelation);
			}
			if (this.MstBankShop.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBankShop);
			}
			if (this.MstBanner.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBanner);
			}
			if (this.MstBattleBg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBattleBg);
			}
			if (this.MstBgm.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBgm);
			}
			if (this.MstBoxGacha.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBoxGacha);
			}
			if (this.MstBoxGachaBase.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBoxGachaBase);
			}
			if (this.MstBoxGachaBaseDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBoxGachaBaseDetail);
			}
			if (this.MstBoxGachaTalk.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBoxGachaTalk);
			}
			if (this.MstBuff.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstBuff);
			}
			if (this.MstCard.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstCard);
			}
			if (this.MstClass.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.MstClass);
			}
			if (this.MstClassRelation.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstClassRelation);
			}
			if (this.MstClosedMessage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstClosedMessage);
			}
			if (this.MstCombine.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCombine);
			}
			if (this.MstCombineLimit.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCombineLimit);
			}
			if (this.MstCombineMaterial.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCombineMaterial);
			}
			if (this.MstCombineQp.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCombineQp);
			}
			if (this.MstCombineQpSvtEquip.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCombineQpSvtEquip);
			}
			if (this.MstCombineSkill.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCombineSkill);
			}
			if (this.MstCommandSpell.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCommandSpell);
			}
			if (this.MstConstant.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstConstant);
			}
			if (this.MstConstantStr.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstConstantStr);
			}
			if (this.MstCv.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstCv);
			}
			if (this.MstEffect.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEffect);
			}
			if (this.MstEquip.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEquip);
			}
			if (this.MstEquipExp.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEquipExp);
			}
			if (this.MstEquipImage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEquipImage);
			}
			if (this.MstEquipSkill.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEquipSkill);
			}
			if (this.MstEvent.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEvent);
			}
			if (this.MstEventCampaign.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventCampaign);
			}
			if (this.MstEventDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventDetail);
			}
			if (this.MstEventFilter.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventFilter);
			}
			if (this.MstEventItemDisplay.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventItemDisplay);
			}
			if (this.MstEventItemDisplayGroup.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventItemDisplayGroup);
			}
			if (this.MstEventItemDisplayRelease.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventItemDisplayRelease);
			}
			if (this.MstEventLoginBonus.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventLoginBonus);
			}
			if (this.MstEventLoginCampaign.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventLoginCampaign);
			}
			if (this.MstEventMission.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventMission);
			}
			if (this.MstEventMissionAction.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventMissionAction);
			}
			if (this.MstEventMissionCondition.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventMissionCondition);
			}
			if (this.MstEventMissionConditionDet.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventMissionConditionDet);
			}
			if (this.MstEventQuest.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventQuest);
			}
			if (this.MstEventReward.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventReward);
			}
			if (this.MstEventRewardBg.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventRewardBg);
			}
			if (this.MstEventRewardSet.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventRewardSet);
			}
			if (this.MstEventSuperBoss.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventSuperBoss);
			}
			if (this.MstEventSvt.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventSvt);
			}
			if (this.MstEventTutorial.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstEventTutorial);
			}
			if (this.MstFriendship.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstFriendship);
			}
			if (this.MstFunc.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstFunc);
			}
			if (this.MstFuncGroup.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstFuncGroup);
			}
			if (this.MstGacha.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGacha);
			}
			if (this.MstGachaAdjust.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGachaAdjust);
			}
			if (this.MstGachaBase.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGachaBase);
			}
			if (this.MstGachaBonus.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGachaBonus);
			}
			if (this.MstGameIllustration.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGameIllustration);
			}
			if (this.MstGift.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGift);
			}
			if (this.MstGuide.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstGuide);
			}
			if (this.MstHeroine.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstHeroine);
			}
			if (this.MstIllustrator.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstIllustrator);
			}
			if (this.MstItem.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstItem);
			}
			if (this.MstMapGimmick.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstMapGimmick);
			}
			if (this.MstMasterMission.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstMasterMission);
			}
			if (this.MstMasterMissionDisplayInfo.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstMasterMissionDisplayInfo);
			}
			if (this.MstMission.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstMission);
			}
			if (this.MstPresentMessage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstPresentMessage);
			}
			if (this.MstQuest.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuest);
			}
			if (this.MstQuestConsumeItem.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestConsumeItem);
			}
			if (this.MstQuestGroup.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestGroup);
			}
			if (this.MstQuestMessage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestMessage);
			}
			if (this.MstQuestPhase.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestPhase);
			}
			if (this.MstQuestPhaseDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestPhaseDetail);
			}
			if (this.MstQuestRelease.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestRelease);
			}
			if (this.MstQuestReset.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestReset);
			}
			if (this.MstQuestRestriction.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestRestriction);
			}
			if (this.MstQuestScript.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestScript);
			}
			if (this.MstQuestScriptRelease.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstQuestScriptRelease);
			}
			if (this.MstRecover.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstRecover);
			}
			if (this.MstRestriction.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstRestriction);
			}
			if (this.MstSetItem.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSetItem);
			}
			if (this.MstShop.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstShop);
			}
			if (this.MstShopDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstShopDetail);
			}
			if (this.MstShopRelease.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstShopRelease);
			}
			if (this.MstShopScript.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstShopScript);
			}
			if (this.MstSkill.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSkill);
			}
			if (this.MstSkillDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSkillDetail);
			}
			if (this.MstSkillLv.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSkillLv);
			}
			if (this.MstSpot.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSpot);
			}
			if (this.MstSpotImage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSpotImage);
			}
			if (this.MstSpotRoad.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSpotRoad);
			}
			if (this.MstStage.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstStage);
			}
			if (this.MstStoneShop.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstStoneShop);
			}
			if (this.MstSvt.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvt);
			}
			if (this.MstSvtCard.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtCard);
			}
			if (this.MstSvtComment.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtComment);
			}
			if (this.MstSvtCommentAdd.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtCommentAdd);
			}
			if (this.MstSvtExceed.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtExceed);
			}
			if (this.MstSvtExp.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtExp);
			}
			if (this.MstSvtGroup.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtGroup);
			}
			if (this.MstSvtLimit.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtLimit);
			}
			if (this.MstSvtLimitAdd.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtLimitAdd);
			}
			if (this.MstSvtPassiveSkill.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtPassiveSkill);
			}
			if (this.MstSvtProfile.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtProfile);
			}
			if (this.MstSvtRarity.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtRarity);
			}
			if (this.MstSvtScript.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtScript);
			}
			if (this.MstSvtScriptAdd.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtScriptAdd);
			}
			if (this.MstSvtSkill.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtSkill);
			}
			if (this.MstSvtTreasureDevice.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtTreasureDevice);
			}
			if (this.MstSvtVoice.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtVoice);
			}
			if (this.MstSvtVoiceRelation.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstSvtVoiceRelation);
			}
			if (this.MstTips.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstTips);
			}
			if (this.MstTotalLogin.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstTotalLogin);
			}
			if (this.MstTreasureDevice.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstTreasureDevice);
			}
			if (this.MstTreasureDeviceDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstTreasureDeviceDetail);
			}
			if (this.MstTreasureDeviceLv.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstTreasureDeviceLv);
			}
			if (this.MstUserExp.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstUserExp);
			}
			if (this.MstUserTrem.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstUserTrem);
			}
			if (this.MstVoice.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstVoice);
			}
			if (this.MstVoiceRelease.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstVoiceRelease);
			}
			if (this.MstWar.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstWar);
			}
			if (this.MstWarBgm.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.MstWarBgm);
			}
			if (this.NpcDeck.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.NpcDeck);
			}
			if (this.NpcFollower.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.NpcFollower);
			}
			if (this.NpcSvt.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.NpcSvt);
			}
			if (this.NpcSvtDetail.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.NpcSvtDetail);
			}
			if (this.NpcSvtFollower.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.NpcSvtFollower);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_DATA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MstAi.Length != 0)
			{
				this.MstAi = other.MstAi;
			}
			if (other.MstAiAct.Length != 0)
			{
				this.MstAiAct = other.MstAiAct;
			}
			if (other.MstAiField.Length != 0)
			{
				this.MstAiField = other.MstAiField;
			}
			if (other.MstAttriRelation.Length != 0)
			{
				this.MstAttriRelation = other.MstAttriRelation;
			}
			if (other.MstBankShop.Length != 0)
			{
				this.MstBankShop = other.MstBankShop;
			}
			if (other.MstBanner.Length != 0)
			{
				this.MstBanner = other.MstBanner;
			}
			if (other.MstBattleBg.Length != 0)
			{
				this.MstBattleBg = other.MstBattleBg;
			}
			if (other.MstBgm.Length != 0)
			{
				this.MstBgm = other.MstBgm;
			}
			if (other.MstBoxGacha.Length != 0)
			{
				this.MstBoxGacha = other.MstBoxGacha;
			}
			if (other.MstBoxGachaBase.Length != 0)
			{
				this.MstBoxGachaBase = other.MstBoxGachaBase;
			}
			if (other.MstBoxGachaBaseDetail.Length != 0)
			{
				this.MstBoxGachaBaseDetail = other.MstBoxGachaBaseDetail;
			}
			if (other.MstBoxGachaTalk.Length != 0)
			{
				this.MstBoxGachaTalk = other.MstBoxGachaTalk;
			}
			if (other.MstBuff.Length != 0)
			{
				this.MstBuff = other.MstBuff;
			}
			if (other.MstCard.Length != 0)
			{
				this.MstCard = other.MstCard;
			}
			if (other.MstClass.Length != 0)
			{
				this.MstClass = other.MstClass;
			}
			if (other.MstClassRelation.Length != 0)
			{
				this.MstClassRelation = other.MstClassRelation;
			}
			if (other.MstClosedMessage.Length != 0)
			{
				this.MstClosedMessage = other.MstClosedMessage;
			}
			if (other.MstCombine.Length != 0)
			{
				this.MstCombine = other.MstCombine;
			}
			if (other.MstCombineLimit.Length != 0)
			{
				this.MstCombineLimit = other.MstCombineLimit;
			}
			if (other.MstCombineMaterial.Length != 0)
			{
				this.MstCombineMaterial = other.MstCombineMaterial;
			}
			if (other.MstCombineQp.Length != 0)
			{
				this.MstCombineQp = other.MstCombineQp;
			}
			if (other.MstCombineQpSvtEquip.Length != 0)
			{
				this.MstCombineQpSvtEquip = other.MstCombineQpSvtEquip;
			}
			if (other.MstCombineSkill.Length != 0)
			{
				this.MstCombineSkill = other.MstCombineSkill;
			}
			if (other.MstCommandSpell.Length != 0)
			{
				this.MstCommandSpell = other.MstCommandSpell;
			}
			if (other.MstConstant.Length != 0)
			{
				this.MstConstant = other.MstConstant;
			}
			if (other.MstConstantStr.Length != 0)
			{
				this.MstConstantStr = other.MstConstantStr;
			}
			if (other.MstCv.Length != 0)
			{
				this.MstCv = other.MstCv;
			}
			if (other.MstEffect.Length != 0)
			{
				this.MstEffect = other.MstEffect;
			}
			if (other.MstEquip.Length != 0)
			{
				this.MstEquip = other.MstEquip;
			}
			if (other.MstEquipExp.Length != 0)
			{
				this.MstEquipExp = other.MstEquipExp;
			}
			if (other.MstEquipImage.Length != 0)
			{
				this.MstEquipImage = other.MstEquipImage;
			}
			if (other.MstEquipSkill.Length != 0)
			{
				this.MstEquipSkill = other.MstEquipSkill;
			}
			if (other.MstEvent.Length != 0)
			{
				this.MstEvent = other.MstEvent;
			}
			if (other.MstEventCampaign.Length != 0)
			{
				this.MstEventCampaign = other.MstEventCampaign;
			}
			if (other.MstEventDetail.Length != 0)
			{
				this.MstEventDetail = other.MstEventDetail;
			}
			if (other.MstEventFilter.Length != 0)
			{
				this.MstEventFilter = other.MstEventFilter;
			}
			if (other.MstEventItemDisplay.Length != 0)
			{
				this.MstEventItemDisplay = other.MstEventItemDisplay;
			}
			if (other.MstEventItemDisplayGroup.Length != 0)
			{
				this.MstEventItemDisplayGroup = other.MstEventItemDisplayGroup;
			}
			if (other.MstEventItemDisplayRelease.Length != 0)
			{
				this.MstEventItemDisplayRelease = other.MstEventItemDisplayRelease;
			}
			if (other.MstEventLoginBonus.Length != 0)
			{
				this.MstEventLoginBonus = other.MstEventLoginBonus;
			}
			if (other.MstEventLoginCampaign.Length != 0)
			{
				this.MstEventLoginCampaign = other.MstEventLoginCampaign;
			}
			if (other.MstEventMission.Length != 0)
			{
				this.MstEventMission = other.MstEventMission;
			}
			if (other.MstEventMissionAction.Length != 0)
			{
				this.MstEventMissionAction = other.MstEventMissionAction;
			}
			if (other.MstEventMissionCondition.Length != 0)
			{
				this.MstEventMissionCondition = other.MstEventMissionCondition;
			}
			if (other.MstEventMissionConditionDet.Length != 0)
			{
				this.MstEventMissionConditionDet = other.MstEventMissionConditionDet;
			}
			if (other.MstEventQuest.Length != 0)
			{
				this.MstEventQuest = other.MstEventQuest;
			}
			if (other.MstEventReward.Length != 0)
			{
				this.MstEventReward = other.MstEventReward;
			}
			if (other.MstEventRewardBg.Length != 0)
			{
				this.MstEventRewardBg = other.MstEventRewardBg;
			}
			if (other.MstEventRewardSet.Length != 0)
			{
				this.MstEventRewardSet = other.MstEventRewardSet;
			}
			if (other.MstEventSuperBoss.Length != 0)
			{
				this.MstEventSuperBoss = other.MstEventSuperBoss;
			}
			if (other.MstEventSvt.Length != 0)
			{
				this.MstEventSvt = other.MstEventSvt;
			}
			if (other.MstEventTutorial.Length != 0)
			{
				this.MstEventTutorial = other.MstEventTutorial;
			}
			if (other.MstFriendship.Length != 0)
			{
				this.MstFriendship = other.MstFriendship;
			}
			if (other.MstFunc.Length != 0)
			{
				this.MstFunc = other.MstFunc;
			}
			if (other.MstFuncGroup.Length != 0)
			{
				this.MstFuncGroup = other.MstFuncGroup;
			}
			if (other.MstGacha.Length != 0)
			{
				this.MstGacha = other.MstGacha;
			}
			if (other.MstGachaAdjust.Length != 0)
			{
				this.MstGachaAdjust = other.MstGachaAdjust;
			}
			if (other.MstGachaBase.Length != 0)
			{
				this.MstGachaBase = other.MstGachaBase;
			}
			if (other.MstGachaBonus.Length != 0)
			{
				this.MstGachaBonus = other.MstGachaBonus;
			}
			if (other.MstGameIllustration.Length != 0)
			{
				this.MstGameIllustration = other.MstGameIllustration;
			}
			if (other.MstGift.Length != 0)
			{
				this.MstGift = other.MstGift;
			}
			if (other.MstGuide.Length != 0)
			{
				this.MstGuide = other.MstGuide;
			}
			if (other.MstHeroine.Length != 0)
			{
				this.MstHeroine = other.MstHeroine;
			}
			if (other.MstIllustrator.Length != 0)
			{
				this.MstIllustrator = other.MstIllustrator;
			}
			if (other.MstItem.Length != 0)
			{
				this.MstItem = other.MstItem;
			}
			if (other.MstMapGimmick.Length != 0)
			{
				this.MstMapGimmick = other.MstMapGimmick;
			}
			if (other.MstMasterMission.Length != 0)
			{
				this.MstMasterMission = other.MstMasterMission;
			}
			if (other.MstMasterMissionDisplayInfo.Length != 0)
			{
				this.MstMasterMissionDisplayInfo = other.MstMasterMissionDisplayInfo;
			}
			if (other.MstMission.Length != 0)
			{
				this.MstMission = other.MstMission;
			}
			if (other.MstPresentMessage.Length != 0)
			{
				this.MstPresentMessage = other.MstPresentMessage;
			}
			if (other.MstQuest.Length != 0)
			{
				this.MstQuest = other.MstQuest;
			}
			if (other.MstQuestConsumeItem.Length != 0)
			{
				this.MstQuestConsumeItem = other.MstQuestConsumeItem;
			}
			if (other.MstQuestGroup.Length != 0)
			{
				this.MstQuestGroup = other.MstQuestGroup;
			}
			if (other.MstQuestMessage.Length != 0)
			{
				this.MstQuestMessage = other.MstQuestMessage;
			}
			if (other.MstQuestPhase.Length != 0)
			{
				this.MstQuestPhase = other.MstQuestPhase;
			}
			if (other.MstQuestPhaseDetail.Length != 0)
			{
				this.MstQuestPhaseDetail = other.MstQuestPhaseDetail;
			}
			if (other.MstQuestRelease.Length != 0)
			{
				this.MstQuestRelease = other.MstQuestRelease;
			}
			if (other.MstQuestReset.Length != 0)
			{
				this.MstQuestReset = other.MstQuestReset;
			}
			if (other.MstQuestRestriction.Length != 0)
			{
				this.MstQuestRestriction = other.MstQuestRestriction;
			}
			if (other.MstQuestScript.Length != 0)
			{
				this.MstQuestScript = other.MstQuestScript;
			}
			if (other.MstQuestScriptRelease.Length != 0)
			{
				this.MstQuestScriptRelease = other.MstQuestScriptRelease;
			}
			if (other.MstRecover.Length != 0)
			{
				this.MstRecover = other.MstRecover;
			}
			if (other.MstRestriction.Length != 0)
			{
				this.MstRestriction = other.MstRestriction;
			}
			if (other.MstSetItem.Length != 0)
			{
				this.MstSetItem = other.MstSetItem;
			}
			if (other.MstShop.Length != 0)
			{
				this.MstShop = other.MstShop;
			}
			if (other.MstShopDetail.Length != 0)
			{
				this.MstShopDetail = other.MstShopDetail;
			}
			if (other.MstShopRelease.Length != 0)
			{
				this.MstShopRelease = other.MstShopRelease;
			}
			if (other.MstShopScript.Length != 0)
			{
				this.MstShopScript = other.MstShopScript;
			}
			if (other.MstSkill.Length != 0)
			{
				this.MstSkill = other.MstSkill;
			}
			if (other.MstSkillDetail.Length != 0)
			{
				this.MstSkillDetail = other.MstSkillDetail;
			}
			if (other.MstSkillLv.Length != 0)
			{
				this.MstSkillLv = other.MstSkillLv;
			}
			if (other.MstSpot.Length != 0)
			{
				this.MstSpot = other.MstSpot;
			}
			if (other.MstSpotImage.Length != 0)
			{
				this.MstSpotImage = other.MstSpotImage;
			}
			if (other.MstSpotRoad.Length != 0)
			{
				this.MstSpotRoad = other.MstSpotRoad;
			}
			if (other.MstStage.Length != 0)
			{
				this.MstStage = other.MstStage;
			}
			if (other.MstStoneShop.Length != 0)
			{
				this.MstStoneShop = other.MstStoneShop;
			}
			if (other.MstSvt.Length != 0)
			{
				this.MstSvt = other.MstSvt;
			}
			if (other.MstSvtCard.Length != 0)
			{
				this.MstSvtCard = other.MstSvtCard;
			}
			if (other.MstSvtComment.Length != 0)
			{
				this.MstSvtComment = other.MstSvtComment;
			}
			if (other.MstSvtCommentAdd.Length != 0)
			{
				this.MstSvtCommentAdd = other.MstSvtCommentAdd;
			}
			if (other.MstSvtExceed.Length != 0)
			{
				this.MstSvtExceed = other.MstSvtExceed;
			}
			if (other.MstSvtExp.Length != 0)
			{
				this.MstSvtExp = other.MstSvtExp;
			}
			if (other.MstSvtGroup.Length != 0)
			{
				this.MstSvtGroup = other.MstSvtGroup;
			}
			if (other.MstSvtLimit.Length != 0)
			{
				this.MstSvtLimit = other.MstSvtLimit;
			}
			if (other.MstSvtLimitAdd.Length != 0)
			{
				this.MstSvtLimitAdd = other.MstSvtLimitAdd;
			}
			if (other.MstSvtPassiveSkill.Length != 0)
			{
				this.MstSvtPassiveSkill = other.MstSvtPassiveSkill;
			}
			if (other.MstSvtProfile.Length != 0)
			{
				this.MstSvtProfile = other.MstSvtProfile;
			}
			if (other.MstSvtRarity.Length != 0)
			{
				this.MstSvtRarity = other.MstSvtRarity;
			}
			if (other.MstSvtScript.Length != 0)
			{
				this.MstSvtScript = other.MstSvtScript;
			}
			if (other.MstSvtScriptAdd.Length != 0)
			{
				this.MstSvtScriptAdd = other.MstSvtScriptAdd;
			}
			if (other.MstSvtSkill.Length != 0)
			{
				this.MstSvtSkill = other.MstSvtSkill;
			}
			if (other.MstSvtTreasureDevice.Length != 0)
			{
				this.MstSvtTreasureDevice = other.MstSvtTreasureDevice;
			}
			if (other.MstSvtVoice.Length != 0)
			{
				this.MstSvtVoice = other.MstSvtVoice;
			}
			if (other.MstSvtVoiceRelation.Length != 0)
			{
				this.MstSvtVoiceRelation = other.MstSvtVoiceRelation;
			}
			if (other.MstTips.Length != 0)
			{
				this.MstTips = other.MstTips;
			}
			if (other.MstTotalLogin.Length != 0)
			{
				this.MstTotalLogin = other.MstTotalLogin;
			}
			if (other.MstTreasureDevice.Length != 0)
			{
				this.MstTreasureDevice = other.MstTreasureDevice;
			}
			if (other.MstTreasureDeviceDetail.Length != 0)
			{
				this.MstTreasureDeviceDetail = other.MstTreasureDeviceDetail;
			}
			if (other.MstTreasureDeviceLv.Length != 0)
			{
				this.MstTreasureDeviceLv = other.MstTreasureDeviceLv;
			}
			if (other.MstUserExp.Length != 0)
			{
				this.MstUserExp = other.MstUserExp;
			}
			if (other.MstUserTrem.Length != 0)
			{
				this.MstUserTrem = other.MstUserTrem;
			}
			if (other.MstVoice.Length != 0)
			{
				this.MstVoice = other.MstVoice;
			}
			if (other.MstVoiceRelease.Length != 0)
			{
				this.MstVoiceRelease = other.MstVoiceRelease;
			}
			if (other.MstWar.Length != 0)
			{
				this.MstWar = other.MstWar;
			}
			if (other.MstWarBgm.Length != 0)
			{
				this.MstWarBgm = other.MstWarBgm;
			}
			if (other.NpcDeck.Length != 0)
			{
				this.NpcDeck = other.NpcDeck;
			}
			if (other.NpcFollower.Length != 0)
			{
				this.NpcFollower = other.NpcFollower;
			}
			if (other.NpcSvt.Length != 0)
			{
				this.NpcSvt = other.NpcSvt;
			}
			if (other.NpcSvtDetail.Length != 0)
			{
				this.NpcSvtDetail = other.NpcSvtDetail;
			}
			if (other.NpcSvtFollower.Length != 0)
			{
				this.NpcSvtFollower = other.NpcSvtFollower;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 10u)
				{
					if (num2 != 18u)
					{
						if (num2 != 26u)
						{
							if (num2 != 34u)
							{
								if (num2 != 42u)
								{
									if (num2 != 50u)
									{
										if (num2 != 58u)
										{
											if (num2 != 66u)
											{
												if (num2 != 74u)
												{
													if (num2 != 82u)
													{
														if (num2 != 90u)
														{
															if (num2 != 98u)
															{
																if (num2 != 106u)
																{
																	if (num2 != 114u)
																	{
																		if (num2 != 122u)
																		{
																			if (num2 != 130u)
																			{
																				if (num2 != 138u)
																				{
																					if (num2 != 146u)
																					{
																						if (num2 != 154u)
																						{
																							if (num2 != 162u)
																							{
																								if (num2 != 170u)
																								{
																									if (num2 != 178u)
																									{
																										if (num2 != 186u)
																										{
																											if (num2 != 194u)
																											{
																												if (num2 != 202u)
																												{
																													if (num2 != 210u)
																													{
																														if (num2 != 218u)
																														{
																															if (num2 != 226u)
																															{
																																if (num2 != 234u)
																																{
																																	if (num2 != 242u)
																																	{
																																		if (num2 != 250u)
																																		{
																																			if (num2 != 258u)
																																			{
																																				if (num2 != 266u)
																																				{
																																					if (num2 != 274u)
																																					{
																																						if (num2 != 282u)
																																						{
																																							if (num2 != 290u)
																																							{
																																								if (num2 != 298u)
																																								{
																																									if (num2 != 306u)
																																									{
																																										if (num2 != 314u)
																																										{
																																											if (num2 != 322u)
																																											{
																																												if (num2 != 330u)
																																												{
																																													if (num2 != 338u)
																																													{
																																														if (num2 != 346u)
																																														{
																																															if (num2 != 354u)
																																															{
																																																if (num2 != 362u)
																																																{
																																																	if (num2 != 370u)
																																																	{
																																																		if (num2 != 378u)
																																																		{
																																																			if (num2 != 386u)
																																																			{
																																																				if (num2 != 394u)
																																																				{
																																																					if (num2 != 402u)
																																																					{
																																																						if (num2 != 410u)
																																																						{
																																																							if (num2 != 418u)
																																																							{
																																																								if (num2 != 426u)
																																																								{
																																																									if (num2 != 434u)
																																																									{
																																																										if (num2 != 442u)
																																																										{
																																																											if (num2 != 450u)
																																																											{
																																																												if (num2 != 458u)
																																																												{
																																																													if (num2 != 466u)
																																																													{
																																																														if (num2 != 474u)
																																																														{
																																																															if (num2 != 482u)
																																																															{
																																																																if (num2 != 490u)
																																																																{
																																																																	if (num2 != 498u)
																																																																	{
																																																																		if (num2 != 506u)
																																																																		{
																																																																			if (num2 != 514u)
																																																																			{
																																																																				if (num2 != 522u)
																																																																				{
																																																																					if (num2 != 530u)
																																																																					{
																																																																						if (num2 != 538u)
																																																																						{
																																																																							if (num2 != 546u)
																																																																							{
																																																																								if (num2 != 554u)
																																																																								{
																																																																									if (num2 != 562u)
																																																																									{
																																																																										if (num2 != 570u)
																																																																										{
																																																																											if (num2 != 578u)
																																																																											{
																																																																												if (num2 != 586u)
																																																																												{
																																																																													if (num2 != 594u)
																																																																													{
																																																																														if (num2 != 602u)
																																																																														{
																																																																															if (num2 != 610u)
																																																																															{
																																																																																if (num2 != 618u)
																																																																																{
																																																																																	if (num2 != 626u)
																																																																																	{
																																																																																		if (num2 != 634u)
																																																																																		{
																																																																																			if (num2 != 642u)
																																																																																			{
																																																																																				if (num2 != 650u)
																																																																																				{
																																																																																					if (num2 != 658u)
																																																																																					{
																																																																																						if (num2 != 666u)
																																																																																						{
																																																																																							if (num2 != 674u)
																																																																																							{
																																																																																								if (num2 != 682u)
																																																																																								{
																																																																																									if (num2 != 690u)
																																																																																									{
																																																																																										if (num2 != 698u)
																																																																																										{
																																																																																											if (num2 != 706u)
																																																																																											{
																																																																																												if (num2 != 714u)
																																																																																												{
																																																																																													if (num2 != 722u)
																																																																																													{
																																																																																														if (num2 != 730u)
																																																																																														{
																																																																																															if (num2 != 738u)
																																																																																															{
																																																																																																if (num2 != 746u)
																																																																																																{
																																																																																																	if (num2 != 754u)
																																																																																																	{
																																																																																																		if (num2 != 762u)
																																																																																																		{
																																																																																																			if (num2 != 770u)
																																																																																																			{
																																																																																																				if (num2 != 778u)
																																																																																																				{
																																																																																																					if (num2 != 786u)
																																																																																																					{
																																																																																																						if (num2 != 794u)
																																																																																																						{
																																																																																																							if (num2 != 802u)
																																																																																																							{
																																																																																																								if (num2 != 810u)
																																																																																																								{
																																																																																																									if (num2 != 818u)
																																																																																																									{
																																																																																																										if (num2 != 826u)
																																																																																																										{
																																																																																																											if (num2 != 834u)
																																																																																																											{
																																																																																																												if (num2 != 842u)
																																																																																																												{
																																																																																																													if (num2 != 850u)
																																																																																																													{
																																																																																																														if (num2 != 858u)
																																																																																																														{
																																																																																																															if (num2 != 866u)
																																																																																																															{
																																																																																																																if (num2 != 874u)
																																																																																																																{
																																																																																																																	if (num2 != 882u)
																																																																																																																	{
																																																																																																																		if (num2 != 890u)
																																																																																																																		{
																																																																																																																			if (num2 != 898u)
																																																																																																																			{
																																																																																																																				if (num2 != 906u)
																																																																																																																				{
																																																																																																																					if (num2 != 914u)
																																																																																																																					{
																																																																																																																						if (num2 != 922u)
																																																																																																																						{
																																																																																																																							if (num2 != 930u)
																																																																																																																							{
																																																																																																																								if (num2 != 938u)
																																																																																																																								{
																																																																																																																									if (num2 != 946u)
																																																																																																																									{
																																																																																																																										if (num2 != 954u)
																																																																																																																										{
																																																																																																																											if (num2 != 962u)
																																																																																																																											{
																																																																																																																												if (num2 != 970u)
																																																																																																																												{
																																																																																																																													if (num2 != 978u)
																																																																																																																													{
																																																																																																																														if (num2 != 986u)
																																																																																																																														{
																																																																																																																															if (num2 != 994u)
																																																																																																																															{
																																																																																																																																if (num2 != 1002u)
																																																																																																																																{
																																																																																																																																	if (num2 != 1010u)
																																																																																																																																	{
																																																																																																																																		if (num2 != 1018u)
																																																																																																																																		{
																																																																																																																																			if (num2 != 1026u)
																																																																																																																																			{
																																																																																																																																				if (num2 != 1034u)
																																																																																																																																				{
																																																																																																																																					if (num2 != 1042u)
																																																																																																																																					{
																																																																																																																																						input.SkipLastField();
																																																																																																																																					}
																																																																																																																																					else
																																																																																																																																					{
																																																																																																																																						this.NpcSvtFollower = input.ReadBytes();
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																				else
																																																																																																																																				{
																																																																																																																																					this.NpcSvtDetail = input.ReadBytes();
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																			else
																																																																																																																																			{
																																																																																																																																				this.NpcSvt = input.ReadBytes();
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			this.NpcFollower = input.ReadBytes();
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		this.NpcDeck = input.ReadBytes();
																																																																																																																																	}
																																																																																																																																}
																																																																																																																																else
																																																																																																																																{
																																																																																																																																	this.MstWarBgm = input.ReadBytes();
																																																																																																																																}
																																																																																																																															}
																																																																																																																															else
																																																																																																																															{
																																																																																																																																this.MstWar = input.ReadBytes();
																																																																																																																															}
																																																																																																																														}
																																																																																																																														else
																																																																																																																														{
																																																																																																																															this.MstVoiceRelease = input.ReadBytes();
																																																																																																																														}
																																																																																																																													}
																																																																																																																													else
																																																																																																																													{
																																																																																																																														this.MstVoice = input.ReadBytes();
																																																																																																																													}
																																																																																																																												}
																																																																																																																												else
																																																																																																																												{
																																																																																																																													this.MstUserTrem = input.ReadBytes();
																																																																																																																												}
																																																																																																																											}
																																																																																																																											else
																																																																																																																											{
																																																																																																																												this.MstUserExp = input.ReadBytes();
																																																																																																																											}
																																																																																																																										}
																																																																																																																										else
																																																																																																																										{
																																																																																																																											this.MstTreasureDeviceLv = input.ReadBytes();
																																																																																																																										}
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										this.MstTreasureDeviceDetail = input.ReadBytes();
																																																																																																																									}
																																																																																																																								}
																																																																																																																								else
																																																																																																																								{
																																																																																																																									this.MstTreasureDevice = input.ReadBytes();
																																																																																																																								}
																																																																																																																							}
																																																																																																																							else
																																																																																																																							{
																																																																																																																								this.MstTotalLogin = input.ReadBytes();
																																																																																																																							}
																																																																																																																						}
																																																																																																																						else
																																																																																																																						{
																																																																																																																							this.MstTips = input.ReadBytes();
																																																																																																																						}
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						this.MstSvtVoiceRelation = input.ReadBytes();
																																																																																																																					}
																																																																																																																				}
																																																																																																																				else
																																																																																																																				{
																																																																																																																					this.MstSvtVoice = input.ReadBytes();
																																																																																																																				}
																																																																																																																			}
																																																																																																																			else
																																																																																																																			{
																																																																																																																				this.MstSvtTreasureDevice = input.ReadBytes();
																																																																																																																			}
																																																																																																																		}
																																																																																																																		else
																																																																																																																		{
																																																																																																																			this.MstSvtSkill = input.ReadBytes();
																																																																																																																		}
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		this.MstSvtScriptAdd = input.ReadBytes();
																																																																																																																	}
																																																																																																																}
																																																																																																																else
																																																																																																																{
																																																																																																																	this.MstSvtScript = input.ReadBytes();
																																																																																																																}
																																																																																																															}
																																																																																																															else
																																																																																																															{
																																																																																																																this.MstSvtRarity = input.ReadBytes();
																																																																																																															}
																																																																																																														}
																																																																																																														else
																																																																																																														{
																																																																																																															this.MstSvtProfile = input.ReadBytes();
																																																																																																														}
																																																																																																													}
																																																																																																													else
																																																																																																													{
																																																																																																														this.MstSvtPassiveSkill = input.ReadBytes();
																																																																																																													}
																																																																																																												}
																																																																																																												else
																																																																																																												{
																																																																																																													this.MstSvtLimitAdd = input.ReadBytes();
																																																																																																												}
																																																																																																											}
																																																																																																											else
																																																																																																											{
																																																																																																												this.MstSvtLimit = input.ReadBytes();
																																																																																																											}
																																																																																																										}
																																																																																																										else
																																																																																																										{
																																																																																																											this.MstSvtGroup = input.ReadBytes();
																																																																																																										}
																																																																																																									}
																																																																																																									else
																																																																																																									{
																																																																																																										this.MstSvtExp = input.ReadBytes();
																																																																																																									}
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									this.MstSvtExceed = input.ReadBytes();
																																																																																																								}
																																																																																																							}
																																																																																																							else
																																																																																																							{
																																																																																																								this.MstSvtCommentAdd = input.ReadBytes();
																																																																																																							}
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							this.MstSvtComment = input.ReadBytes();
																																																																																																						}
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						this.MstSvtCard = input.ReadBytes();
																																																																																																					}
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					this.MstSvt = input.ReadBytes();
																																																																																																				}
																																																																																																			}
																																																																																																			else
																																																																																																			{
																																																																																																				this.MstStoneShop = input.ReadBytes();
																																																																																																			}
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			this.MstStage = input.ReadBytes();
																																																																																																		}
																																																																																																	}
																																																																																																	else
																																																																																																	{
																																																																																																		this.MstSpotRoad = input.ReadBytes();
																																																																																																	}
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	this.MstSpotImage = input.ReadBytes();
																																																																																																}
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																this.MstSpot = input.ReadBytes();
																																																																																															}
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															this.MstSkillLv = input.ReadBytes();
																																																																																														}
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														this.MstSkillDetail = input.ReadBytes();
																																																																																													}
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													this.MstSkill = input.ReadBytes();
																																																																																												}
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												this.MstShopScript = input.ReadBytes();
																																																																																											}
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											this.MstShopRelease = input.ReadBytes();
																																																																																										}
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										this.MstShopDetail = input.ReadBytes();
																																																																																									}
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									this.MstShop = input.ReadBytes();
																																																																																								}
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								this.MstSetItem = input.ReadBytes();
																																																																																							}
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							this.MstRestriction = input.ReadBytes();
																																																																																						}
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						this.MstRecover = input.ReadBytes();
																																																																																					}
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					this.MstQuestScriptRelease = input.ReadBytes();
																																																																																				}
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				this.MstQuestScript = input.ReadBytes();
																																																																																			}
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			this.MstQuestRestriction = input.ReadBytes();
																																																																																		}
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		this.MstQuestReset = input.ReadBytes();
																																																																																	}
																																																																																}
																																																																																else
																																																																																{
																																																																																	this.MstQuestRelease = input.ReadBytes();
																																																																																}
																																																																															}
																																																																															else
																																																																															{
																																																																																this.MstQuestPhaseDetail = input.ReadBytes();
																																																																															}
																																																																														}
																																																																														else
																																																																														{
																																																																															this.MstQuestPhase = input.ReadBytes();
																																																																														}
																																																																													}
																																																																													else
																																																																													{
																																																																														this.MstQuestMessage = input.ReadBytes();
																																																																													}
																																																																												}
																																																																												else
																																																																												{
																																																																													this.MstQuestGroup = input.ReadBytes();
																																																																												}
																																																																											}
																																																																											else
																																																																											{
																																																																												this.MstQuestConsumeItem = input.ReadBytes();
																																																																											}
																																																																										}
																																																																										else
																																																																										{
																																																																											this.MstQuest = input.ReadBytes();
																																																																										}
																																																																									}
																																																																									else
																																																																									{
																																																																										this.MstPresentMessage = input.ReadBytes();
																																																																									}
																																																																								}
																																																																								else
																																																																								{
																																																																									this.MstMission = input.ReadBytes();
																																																																								}
																																																																							}
																																																																							else
																																																																							{
																																																																								this.MstMasterMissionDisplayInfo = input.ReadBytes();
																																																																							}
																																																																						}
																																																																						else
																																																																						{
																																																																							this.MstMasterMission = input.ReadBytes();
																																																																						}
																																																																					}
																																																																					else
																																																																					{
																																																																						this.MstMapGimmick = input.ReadBytes();
																																																																					}
																																																																				}
																																																																				else
																																																																				{
																																																																					this.MstItem = input.ReadBytes();
																																																																				}
																																																																			}
																																																																			else
																																																																			{
																																																																				this.MstIllustrator = input.ReadBytes();
																																																																			}
																																																																		}
																																																																		else
																																																																		{
																																																																			this.MstHeroine = input.ReadBytes();
																																																																		}
																																																																	}
																																																																	else
																																																																	{
																																																																		this.MstGuide = input.ReadBytes();
																																																																	}
																																																																}
																																																																else
																																																																{
																																																																	this.MstGift = input.ReadBytes();
																																																																}
																																																															}
																																																															else
																																																															{
																																																																this.MstGameIllustration = input.ReadBytes();
																																																															}
																																																														}
																																																														else
																																																														{
																																																															this.MstGachaBonus = input.ReadBytes();
																																																														}
																																																													}
																																																													else
																																																													{
																																																														this.MstGachaBase = input.ReadBytes();
																																																													}
																																																												}
																																																												else
																																																												{
																																																													this.MstGachaAdjust = input.ReadBytes();
																																																												}
																																																											}
																																																											else
																																																											{
																																																												this.MstGacha = input.ReadBytes();
																																																											}
																																																										}
																																																										else
																																																										{
																																																											this.MstFuncGroup = input.ReadBytes();
																																																										}
																																																									}
																																																									else
																																																									{
																																																										this.MstFunc = input.ReadBytes();
																																																									}
																																																								}
																																																								else
																																																								{
																																																									this.MstFriendship = input.ReadBytes();
																																																								}
																																																							}
																																																							else
																																																							{
																																																								this.MstEventTutorial = input.ReadBytes();
																																																							}
																																																						}
																																																						else
																																																						{
																																																							this.MstEventSvt = input.ReadBytes();
																																																						}
																																																					}
																																																					else
																																																					{
																																																						this.MstEventSuperBoss = input.ReadBytes();
																																																					}
																																																				}
																																																				else
																																																				{
																																																					this.MstEventRewardSet = input.ReadBytes();
																																																				}
																																																			}
																																																			else
																																																			{
																																																				this.MstEventRewardBg = input.ReadBytes();
																																																			}
																																																		}
																																																		else
																																																		{
																																																			this.MstEventReward = input.ReadBytes();
																																																		}
																																																	}
																																																	else
																																																	{
																																																		this.MstEventQuest = input.ReadBytes();
																																																	}
																																																}
																																																else
																																																{
																																																	this.MstEventMissionConditionDet = input.ReadBytes();
																																																}
																																															}
																																															else
																																															{
																																																this.MstEventMissionCondition = input.ReadBytes();
																																															}
																																														}
																																														else
																																														{
																																															this.MstEventMissionAction = input.ReadBytes();
																																														}
																																													}
																																													else
																																													{
																																														this.MstEventMission = input.ReadBytes();
																																													}
																																												}
																																												else
																																												{
																																													this.MstEventLoginCampaign = input.ReadBytes();
																																												}
																																											}
																																											else
																																											{
																																												this.MstEventLoginBonus = input.ReadBytes();
																																											}
																																										}
																																										else
																																										{
																																											this.MstEventItemDisplayRelease = input.ReadBytes();
																																										}
																																									}
																																									else
																																									{
																																										this.MstEventItemDisplayGroup = input.ReadBytes();
																																									}
																																								}
																																								else
																																								{
																																									this.MstEventItemDisplay = input.ReadBytes();
																																								}
																																							}
																																							else
																																							{
																																								this.MstEventFilter = input.ReadBytes();
																																							}
																																						}
																																						else
																																						{
																																							this.MstEventDetail = input.ReadBytes();
																																						}
																																					}
																																					else
																																					{
																																						this.MstEventCampaign = input.ReadBytes();
																																					}
																																				}
																																				else
																																				{
																																					this.MstEvent = input.ReadBytes();
																																				}
																																			}
																																			else
																																			{
																																				this.MstEquipSkill = input.ReadBytes();
																																			}
																																		}
																																		else
																																		{
																																			this.MstEquipImage = input.ReadBytes();
																																		}
																																	}
																																	else
																																	{
																																		this.MstEquipExp = input.ReadBytes();
																																	}
																																}
																																else
																																{
																																	this.MstEquip = input.ReadBytes();
																																}
																															}
																															else
																															{
																																this.MstEffect = input.ReadBytes();
																															}
																														}
																														else
																														{
																															this.MstCv = input.ReadBytes();
																														}
																													}
																													else
																													{
																														this.MstConstantStr = input.ReadBytes();
																													}
																												}
																												else
																												{
																													this.MstConstant = input.ReadBytes();
																												}
																											}
																											else
																											{
																												this.MstCommandSpell = input.ReadBytes();
																											}
																										}
																										else
																										{
																											this.MstCombineSkill = input.ReadBytes();
																										}
																									}
																									else
																									{
																										this.MstCombineQpSvtEquip = input.ReadBytes();
																									}
																								}
																								else
																								{
																									this.MstCombineQp = input.ReadBytes();
																								}
																							}
																							else
																							{
																								this.MstCombineMaterial = input.ReadBytes();
																							}
																						}
																						else
																						{
																							this.MstCombineLimit = input.ReadBytes();
																						}
																					}
																					else
																					{
																						this.MstCombine = input.ReadBytes();
																					}
																				}
																				else
																				{
																					this.MstClosedMessage = input.ReadBytes();
																				}
																			}
																			else
																			{
																				this.MstClassRelation = input.ReadBytes();
																			}
																		}
																		else
																		{
																			this.MstClass = input.ReadBytes();
																		}
																	}
																	else
																	{
																		this.MstCard = input.ReadBytes();
																	}
																}
																else
																{
																	this.MstBuff = input.ReadBytes();
																}
															}
															else
															{
																this.MstBoxGachaTalk = input.ReadBytes();
															}
														}
														else
														{
															this.MstBoxGachaBaseDetail = input.ReadBytes();
														}
													}
													else
													{
														this.MstBoxGachaBase = input.ReadBytes();
													}
												}
												else
												{
													this.MstBoxGacha = input.ReadBytes();
												}
											}
											else
											{
												this.MstBgm = input.ReadBytes();
											}
										}
										else
										{
											this.MstBattleBg = input.ReadBytes();
										}
									}
									else
									{
										this.MstBanner = input.ReadBytes();
									}
								}
								else
								{
									this.MstBankShop = input.ReadBytes();
								}
							}
							else
							{
								this.MstAttriRelation = input.ReadBytes();
							}
						}
						else
						{
							this.MstAiField = input.ReadBytes();
						}
					}
					else
					{
						this.MstAiAct = input.ReadBytes();
					}
				}
				else
				{
					this.MstAi = input.ReadBytes();
				}
			}
		}
	}
}
