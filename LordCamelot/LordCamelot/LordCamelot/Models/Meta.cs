using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LordCamelot.Helper;
using LordCamelot.Services;
using ProtoBuf;

namespace LordCamelot.Models
{
	public class MstConfig
	{
		public List<MstClass> MstClass { get; set; }
		public List<MstEquip> MstEquip { get; set; }
		public List<MstEventQuest> MstEventQuest { get; set; }
		public List<MstItem> MstItem { get; set; }
		public List<MstQuest> MstQuest { get; set; } = new List<MstQuest>();
		public List<MstQuestPhase> MstQuestPhase { get; set; }
		public List<MstQuestPhaseDetail> MstQuestPhaseDetail { get; set; }
		public List<MstSvt> MstSvt { get; set; }
		public List<MstSvtLimit> MstSvtLimit { get; set; }
		public List<MstWar> MstWar { get; set; }
		public List<MstSpot> MstSpot { get; set; }
	}

	[ProtoContract]
	public class Mst
	{
		[ProtoMember(1)]
		public MstData items { get; set; }
	}

	[ProtoContract]
	public class MstData
	{
		[ProtoMember(1)]
		public byte[] MstAi { get; set; }

		[ProtoMember(2)]
		public byte[] MstAiAct { get; set; }

		[ProtoMember(3)]
		public byte[] MstAiField { get; set; }

		[ProtoMember(4)]
		public byte[] MstAttriRelation { get; set; }

		[ProtoMember(5)]
		public byte[] MstBankShop { get; set; }

		[ProtoMember(6)]
		public byte[] MstBanner { get; set; }

		[ProtoMember(7)]
		public byte[] MstBattleBg { get; set; }

		[ProtoMember(8)]
		public byte[] MstBgm { get; set; }

		[ProtoMember(9)]
		public byte[] MstBoxGacha { get; set; }

		[ProtoMember(10)]
		public byte[] MstBoxGachaBase { get; set; }

		[ProtoMember(11)]
		public byte[] MstBoxGachaBaseDetail { get; set; }

		[ProtoMember(12)]
		public byte[] MstBoxGachaTalk { get; set; }

		[ProtoMember(13)]
		public byte[] MstBuff { get; set; }

		[ProtoMember(14)]
		public byte[] MstCard { get; set; }

		[ProtoMember(15)]
		public byte[] MstClass { get; set; }

		[ProtoMember(16)]
		public byte[] MstClassRelation { get; set; }

		[ProtoMember(17)]
		public byte[] MstClosedMessage { get; set; }

		[ProtoMember(18)]
		public byte[] MstCombine { get; set; }

		[ProtoMember(19)]
		public byte[] MstCombineLimit { get; set; }

		[ProtoMember(20)]
		public byte[] MstCombineMaterial { get; set; }

		[ProtoMember(21)]
		public byte[] MstCombineQp { get; set; }

		[ProtoMember(22)]
		public byte[] MstCombineQpSvtEquip { get; set; }

		[ProtoMember(23)]
		public byte[] MstCombineSkill { get; set; }

		[ProtoMember(24)]
		public byte[] MstCommandSpell { get; set; }

		[ProtoMember(25)]
		public byte[] MstConstant { get; set; }

		[ProtoMember(26)]
		public byte[] MstConstantStr { get; set; }

		[ProtoMember(27)]
		public byte[] MstCv { get; set; }

		[ProtoMember(28)]
		public byte[] MstEffect { get; set; }

		[ProtoMember(29)]
		public byte[] MstEquip { get; set; }

		[ProtoMember(30)]
		public byte[] MstEquipExp { get; set; }

		[ProtoMember(31)]
		public byte[] MstEquipImage { get; set; }

		[ProtoMember(32)]
		public byte[] MstEquipSkill { get; set; }

		[ProtoMember(33)]
		public byte[] MstEvent { get; set; }

		[ProtoMember(34)]
		public byte[] MstEventCampaign { get; set; }

		[ProtoMember(35)]
		public byte[] MstEventDetail { get; set; }

		[ProtoMember(36)]
		public byte[] MstEventFilter { get; set; }

		[ProtoMember(37)]
		public byte[] MstEventItemDisplay { get; set; }

		[ProtoMember(38)]
		public byte[] MstEventItemDisplayGroup { get; set; }

		[ProtoMember(39)]
		public byte[] MstEventItemDisplayRelease { get; set; }

		[ProtoMember(40)]
		public byte[] MstEventLoginBonus { get; set; }

		[ProtoMember(41)]
		public byte[] MstEventLoginCampaign { get; set; }

		[ProtoMember(42)]
		public byte[] MstEventMission { get; set; }

		[ProtoMember(43)]
		public byte[] MstEventMissionAction { get; set; }

		[ProtoMember(44)]
		public byte[] MstEventMissionCondition { get; set; }

		[ProtoMember(45)]
		public byte[] MstEventMissionConditionDet { get; set; }

		[ProtoMember(46)]
		public byte[] MstEventQuest { get; set; }

		[ProtoMember(47)]
		public byte[] MstEventReward { get; set; }

		[ProtoMember(48)]
		public byte[] MstEventRewardBg { get; set; }

		[ProtoMember(49)]
		public byte[] MstEventRewardSet { get; set; }

		[ProtoMember(50)]
		public byte[] MstEventSuperBoss { get; set; }

		[ProtoMember(51)]
		public byte[] MstEventSvt { get; set; }

		[ProtoMember(52)]
		public byte[] MstEventTutorial { get; set; }

		[ProtoMember(53)]
		public byte[] MstFriendship { get; set; }

		[ProtoMember(54)]
		public byte[] MstFunc { get; set; }

		[ProtoMember(55)]
		public byte[] MstFuncGroup { get; set; }

		[ProtoMember(56)]
		public byte[] MstGacha { get; set; }

		[ProtoMember(57)]
		public byte[] MstGachaAdjust { get; set; }

		[ProtoMember(58)]
		public byte[] MstGachaBase { get; set; }

		[ProtoMember(59)]
		public byte[] MstGachaBonus { get; set; }

		[ProtoMember(60)]
		public byte[] MstGameIllustration { get; set; }

		[ProtoMember(61)]
		public byte[] MstGift { get; set; }

		[ProtoMember(62)]
		public byte[] MstGuide { get; set; }

		[ProtoMember(63)]
		public byte[] MstHeroine { get; set; }

		[ProtoMember(64)]
		public byte[] MstIllustrator { get; set; }

		[ProtoMember(65)]
		public byte[] MstItem { get; set; }

		[ProtoMember(66)]
		public byte[] MstMapGimmick { get; set; }

		[ProtoMember(67)]
		public byte[] MstMasterMission { get; set; }

		[ProtoMember(68)]
		public byte[] MstMasterMissionDisplayInfo { get; set; }

		[ProtoMember(69)]
		public byte[] MstMission { get; set; }

		[ProtoMember(70)]
		public byte[] MstPresentMessage { get; set; }

		[ProtoMember(71)]
		public byte[] MstQuest { get; set; }

		[ProtoMember(72)]
		public byte[] MstQuestConsumeItem { get; set; }

		[ProtoMember(73)]
		public byte[] MstQuestGroup { get; set; }

		[ProtoMember(74)]
		public byte[] MstQuestMessage { get; set; }

		[ProtoMember(75)]
		public byte[] MstQuestPhase { get; set; }

		[ProtoMember(76)]
		public byte[] MstQuestPhaseDetail { get; set; }

		[ProtoMember(77)]
		public byte[] MstQuestRelease { get; set; }

		[ProtoMember(78)]
		public byte[] MstQuestReset { get; set; }

		[ProtoMember(79)]
		public byte[] MstQuestRestriction { get; set; }

		[ProtoMember(80)]
		public byte[] MstQuestScript { get; set; }

		[ProtoMember(81)]
		public byte[] MstQuestScriptRelease { get; set; }

		[ProtoMember(82)]
		public byte[] MstRecover { get; set; }

		[ProtoMember(83)]
		public byte[] MstRestriction { get; set; }

		[ProtoMember(84)]
		public byte[] MstSetItem { get; set; }

		[ProtoMember(85)]
		public byte[] MstShop { get; set; }

		[ProtoMember(86)]
		public byte[] MstShopDetail { get; set; }

		[ProtoMember(87)]
		public byte[] MstShopRelease { get; set; }

		[ProtoMember(88)]
		public byte[] MstShopScript { get; set; }

		[ProtoMember(89)]
		public byte[] MstSkill { get; set; }

		[ProtoMember(90)]
		public byte[] MstSkillDetail { get; set; }

		[ProtoMember(91)]
		public byte[] MstSkillLv { get; set; }

		[ProtoMember(92)]
		public byte[] MstSpot { get; set; }

		[ProtoMember(93)]
		public byte[] MstSpotImage { get; set; }

		[ProtoMember(94)]
		public byte[] MstSpotRoad { get; set; }

		[ProtoMember(95)]
		public byte[] MstStage { get; set; }

		[ProtoMember(96)]
		public byte[] MstStoneShop { get; set; }

		[ProtoMember(97)]
		public byte[] MstSvt { get; set; }

		[ProtoMember(98)]
		public byte[] MstSvtCard { get; set; }

		[ProtoMember(99)]
		public byte[] MstSvtComment { get; set; }

		[ProtoMember(100)]
		public byte[] MstSvtCommentAdd { get; set; }

		[ProtoMember(101)]
		public byte[] MstSvtExceed { get; set; }

		[ProtoMember(102)]
		public byte[] MstSvtExp { get; set; }

		[ProtoMember(103)]
		public byte[] MstSvtGroup { get; set; }

		[ProtoMember(104)]
		public byte[] MstSvtLimit { get; set; }

		[ProtoMember(105)]
		public byte[] MstSvtLimitAdd { get; set; }

		[ProtoMember(106)]
		public byte[] MstSvtPassiveSkill { get; set; }

		[ProtoMember(107)]
		public byte[] MstSvtProfile { get; set; }

		[ProtoMember(108)]
		public byte[] MstSvtRarity { get; set; }

		[ProtoMember(109)]
		public byte[] MstSvtScript { get; set; }

		[ProtoMember(110)]
		public byte[] MstSvtScriptAdd { get; set; }

		[ProtoMember(111)]
		public byte[] MstSvtSkill { get; set; }

		[ProtoMember(112)]
		public byte[] MstSvtTreasureDevice { get; set; }

		[ProtoMember(113)]
		public byte[] MstSvtVoice { get; set; }

		[ProtoMember(114)]
		public byte[] MstSvtVoiceRelation { get; set; }

		[ProtoMember(115)]
		public byte[] MstTips { get; set; }

		[ProtoMember(116)]
		public byte[] MstTotalLogin { get; set; }

		[ProtoMember(117)]
		public byte[] MstTreasureDevice { get; set; }

		[ProtoMember(118)]
		public byte[] MstTreasureDeviceDetail { get; set; }

		[ProtoMember(119)]
		public byte[] MstTreasureDeviceLv { get; set; }

		[ProtoMember(120)]
		public byte[] MstUserExp { get; set; }

		[ProtoMember(121)]
		public byte[] MstUserTrem { get; set; }

		[ProtoMember(122)]
		public byte[] MstVoice { get; set; }

		[ProtoMember(123)]
		public byte[] MstVoiceRelease { get; set; }

		[ProtoMember(124)]
		public byte[] MstWar { get; set; }

		[ProtoMember(125)]
		public byte[] MstWarBgm { get; set; }

		[ProtoMember(126)]
		public byte[] NpcDeck { get; set; }

		[ProtoMember(127)]
		public byte[] NpcFollower { get; set; }

		[ProtoMember(128)]
		public byte[] NpcSvt { get; set; }

		[ProtoMember(130)]
		public byte[] NpcSvtDetail { get; set; }

		[ProtoMember(131)]
		public byte[] NpcSvtFollower { get; set; }
	}

	[ProtoContract]
	public class MstClassArray
	{
		[ProtoMember(1)]
		public List<MstClass> Items { get; set; }
	}

	[ProtoContract]
	public class MstClass
	{
		[ProtoMember(1)]
		private int Id { get; set; }

		[ProtoMember(2)]
		private int Attri { get; set; }

		[ProtoMember(3)]
		private string Name { get; set; }

		[ProtoMember(4)]
		private int AttackRate { get; set; }

		[ProtoMember(5)]
		private int ImageId { get; set; }

		[ProtoMember(6)]
		private int IconImageId { get; set; }

		[ProtoMember(7)]
		private int GroupType { get; set; }

		[ProtoMember(8)]
		private int Priority { get; set; }
	}

	[ProtoContract]
	public class MstEquipArray
	{
		[ProtoMember(1)]
		public List<MstEquip> Items { get; set; }
	}

	[ProtoContract]
	public class MstEquip
	{
		[ProtoMember(1)]
		private int Id { get; set; }

		[ProtoMember(2)]
		private string Name { get; set; }

		[ProtoMember(3)]
		private string Detail { get; set; }

		[ProtoMember(4)]
		private int CondUserLv { get; set; }

		[ProtoMember(5)]
		private int MaxLv { get; set; }

		[ProtoMember(6)]
		private int MaleImageId { get; set; }

		[ProtoMember(7)]
		private int FemaleImageId { get; set; }

		[ProtoMember(8)]
		private int ImageId { get; set; }

		[ProtoMember(9)]
		private int MaleSpellId { get; set; }

		[ProtoMember(10)]
		private int FemaleSpellId { get; set; }

		[ProtoMember(11)]
		private ulong UpdatedAt { get; set; }

		[ProtoMember(12)]
		private ulong CreatedAt { get; set; }
	}

	[ProtoContract]
	public class MstEventQuestArray
	{
		[ProtoMember(1)]
		public List<MstEventQuest> Items { get; set; }
	}

	[ProtoContract]
	public class MstEventQuest
	{
		[ProtoMember(1)]
		private int EventId { get; set; }

		[ProtoMember(2)]
		private int QuestId { get; set; }

		[ProtoMember(3)]
		private int Phase { get; set; }

		[ProtoMember(4)]
		private ulong UpdatedAt { get; set; }

		[ProtoMember(5)]
		private ulong CreatedAt { get; set; }
	}

	[ProtoContract]
	public class MstItemArray
	{
		[ProtoMember(1)]
		public List<MstItem> Items { get; set; }
	}

	[ProtoContract]
	public class MstItem
	{
		[ProtoMember(1)]
		public int Id { get; set; }

		[ProtoMember(2)]
		public string Name { get; set; }

		[ProtoMember(3)]
		public string Detail { get; set; }

		[ProtoMember(4)]
		public int ImageId { get; set; }

		[ProtoMember(5)]
		public int BgImageId { get; set; }

		[ProtoMember(6)]
		public int Type { get; set; }

		[ProtoMember(9)]
		public int SellQp { get; set; }

		[ProtoMember(11)]
		public int Priority { get; set; }

		[ProtoMember(12)]
		public int DropPriority { get; set; }
	}

	[ProtoContract]
	public class MstQuestArray
	{
		[ProtoMember(1)]
		public List<MstQuest> Items { get; set; }
	}

	[ProtoContract]
	public class MstQuest
	{
		[ProtoMember(1)]
		public int Id { get; set; }

		[ProtoMember(2)]
		public string Name { get; set; }

		[ProtoMember(4)]
		public QuestType Type { get; set; }

		[ProtoMember(5)]
		public int ConsumeType { get; set; }

		[ProtoMember(6)]
		public int ActConsume { get; set; }

		[ProtoMember(7)]
		public int ChaldeaGateCategory { get; set; }

		[ProtoMember(8)]
		public int SpotId { get; set; }

		[ProtoMember(10)]
		public int Priority { get; set; }

		[ProtoMember(20)]
		public int ChapterId { get; set; }

		[ProtoMember(27)]
		public ulong OpenedAt { get; set; }

		[ProtoIgnore]
		public DateTime OpenedTime => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(OpenedAt).ToLocalTime();

		[ProtoMember(28)]
		public ulong ClosedAt { get; set; }

		[ProtoIgnore]
		public DateTime ClosedTime => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(ClosedAt).ToLocalTime();

		[ProtoIgnore]
		public MstSpot Spot { get; set; }

		[ProtoIgnore]
		public string WarName { get; set; }
	}

	[ProtoContract]
	public class MstQuestPhaseArray
	{
		[ProtoMember(1)]
		public List<MstQuestPhase> Items { get; set; }
	}

	[ProtoContract]
	public class MstQuestPhase
	{
		[ProtoMember(1)]
		public int QuestId { get; set; }

		[ProtoMember(2)]
		public int Phase { get; set; }

		[ProtoMember(3)]
		public int IsNpcOnly { get; set; }

		[ProtoMember(4)]
		public int BattleBgId { get; set; }

		[ProtoMember(6)]
		public int Qp { get; set; }

		[ProtoMember(7)]
		public int PlayerExp { get; set; }

		[ProtoMember(8)]
		public int FriendshipExp { get; set; }

		[ProtoMember(9)]
		public List<int> ClassIds { get; set; }

		[ProtoMember(11)]
		public List<int> Individuality { get; set; }
	}

	[ProtoContract]
	public class MstSvtArray
	{
		[ProtoMember(1)]
		public List<MstSvt> Items { get; set; }
	}

	[ProtoContract]
	public class MstSvt
	{
		[ProtoMember(1)]
		public int Id { get; set; }

		[ProtoMember(2)]
		public int BaseSvtId { get; set; }

		[ProtoMember(3)]
		public string Name { get; set; }

		[ProtoMember(4)]
		public string Ruby { get; set; }

		[ProtoMember(5)]
		public string BattleName { get; set; }

		[ProtoMember(6)]
		public int ClassId { get; set; }

		[ProtoMember(7)]
		public int Type { get; set; }

		[ProtoMember(8)]
		public int LimitMax { get; set; }

		[ProtoMember(9)]
		public int RewardLv { get; set; }

		[ProtoMember(10)]
		public int FriendshipId { get; set; }

		[ProtoMember(11)]
		public int MaxFriendshipRank { get; set; }

		[ProtoMember(12)]
		public int GenderType { get; set; }

		[ProtoMember(13)]
		public int Attri { get; set; }

		[ProtoMember(14)]
		public int CombineSkillId { get; set; }

		[ProtoMember(15)]
		public int CombineLimitId { get; set; }

		[ProtoMember(16)]
		public int SellQp { get; set; }

		[ProtoMember(17)]
		public int SellMana { get; set; }

		[ProtoMember(18)]
		public int SellRarePri { get; set; }

		[ProtoMember(19)]
		public int ExpType { get; set; }

		[ProtoMember(20)]
		public int CombineMaterialId { get; set; }

		[ProtoMember(21)]
		public List<int> CardIds { get; set; }

		[ProtoMember(22)]
		public int Cost { get; set; }

		[ProtoMember(23)]
		public int BattleSize { get; set; }

		[ProtoMember(24)]
		public int HpGaugeY { get; set; }

		[ProtoMember(25)]
		public List<int> ClassPassive { get; set; }

		[ProtoMember(26)]
		public List<int> Individuality { get; set; }

		[ProtoMember(27)]
		public int StarRate { get; set; }

		[ProtoMember(28)]
		public int DeathRate { get; set; }

		[ProtoMember(29)]
		public int AttackAttri { get; set; }

		[ProtoMember(31)]
		public int IllustratorId { get; set; }

		[ProtoMember(32)]
		public int CvId { get; set; }

		[ProtoMember(33)]
		public int CollectionNo { get; set; }
	}

	[ProtoContract]
	public class MstSvtLimitArray
	{
		[ProtoMember(1)]
		public List<MstSvtLimit> Items { get; set; }
	}

	[ProtoContract]
	public class MstSvtLimit
	{
		[ProtoMember(1)]
		public int SvtId { get; set; }

		[ProtoMember(3)]
		public int Rarity { get; set; }

		[ProtoMember(4)]
		public int LvMax { get; set; }

		[ProtoMember(5)]
		public int WeaponGroup { get; set; }

		[ProtoMember(9)]
		public int HpBase { get; set; }

		[ProtoMember(10)]
		public int HpMax { get; set; }

		[ProtoMember(11)]
		public int AtkBase { get; set; }

		[ProtoMember(12)]
		public int AtkMax { get; set; }

		[ProtoMember(13)]
		public int CriticalWeight { get; set; }

		[ProtoMember(14)]
		public int Power { get; set; }

		[ProtoMember(15)]
		public int Defense { get; set; }

		[ProtoMember(16)]
		public int Agility { get; set; }

		[ProtoMember(17)]
		public int Magic { get; set; }

		[ProtoMember(18)]
		public int Luck { get; set; }

		[ProtoMember(19)]
		public int TreasureDevice { get; set; }

		[ProtoMember(20)]
		public int Policy { get; set; }

		[ProtoMember(21)]
		public int Personality { get; set; }

		[ProtoMember(22)]
		public int Deity { get; set; }
	}

	public enum QuestType
	{
		Main = 1,
		Free,
		Friendship,
		Event = 5,
		Heroballad
	}

	[ProtoContract]
	public class MstQuestPhaseDetailArray
	{
		[ProtoMember(1)]
		public List<MstQuestPhaseDetail> Items { get; set; }
	}

	[ProtoContract]
	public class MstQuestPhaseDetail
	{
		[ProtoMember(1)]
		public int QuestId { get; set; }

		[ProtoMember(2)]
		public int Phase { get; set; }

		[ProtoMember(5)]
		public int ActConsume { get; set; }
	}

	[ProtoContract]
	public class MstWarArray
	{
		[ProtoMember(1)]
		public List<MstWar> Items { get; set; }
	}

	[ProtoContract]
	public class MstWar
	{
		[ProtoMember(1)]
		public int Id { get; set; }

		[ProtoMember(2)]
		public string Age { get; set; }

		[ProtoMember(3)]
		public string Name { get; set; }

		[ProtoMember(9)]
		public int Priority { get; set; }

		[ProtoMember(11)]
		public int Flag { get; set; }
	}

	[ProtoContract]
	public class MstSpotArray
	{
		[ProtoMember(1)]
		public List<MstSpot> Items { get; set; }
	}

	[ProtoContract]
	public class MstSpot
	{
		[ProtoMember(1)]
		public int Id { get; set; }

		[ProtoMember(2)]
		public int WarId { get; set; }

		[ProtoMember(19)]
		public int ActiveCondType { get; set; }
	}
}
