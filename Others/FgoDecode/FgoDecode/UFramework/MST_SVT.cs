using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT : IMessage, IMessage<MST_SVT>, IEquatable<MST_SVT>, IDeepCloneable<MST_SVT>
	{
		public const int IdFieldNumber = 1;

		public const int BaseSvtIdFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int RubyFieldNumber = 4;

		public const int BattleNameFieldNumber = 5;

		public const int ClassIdFieldNumber = 6;

		public const int TypeFieldNumber = 7;

		public const int LimitMaxFieldNumber = 8;

		public const int RewardLvFieldNumber = 9;

		public const int FriendshipIdFieldNumber = 10;

		public const int MaxFriendshipRankFieldNumber = 11;

		public const int GenderTypeFieldNumber = 12;

		public const int AttriFieldNumber = 13;

		public const int CombineSkillIdFieldNumber = 14;

		public const int CombineLimitIdFieldNumber = 15;

		public const int SellQpFieldNumber = 16;

		public const int SellManaFieldNumber = 17;

		public const int SellRarePriFieldNumber = 18;

		public const int ExpTypeFieldNumber = 19;

		public const int CombineMaterialIdFieldNumber = 20;

		public const int CardIdsFieldNumber = 21;

		public const int CostFieldNumber = 22;

		public const int BattleSizeFieldNumber = 23;

		public const int HpGaugeYFieldNumber = 24;

		public const int ClassPassiveFieldNumber = 25;

		public const int IndividualityFieldNumber = 26;

		public const int StarRateFieldNumber = 27;

		public const int DeathRateFieldNumber = 28;

		public const int AttackAttriFieldNumber = 29;

		public const int ScriptFieldNumber = 30;

		public const int IllustratorIdFieldNumber = 31;

		public const int CvIdFieldNumber = 32;

		public const int CollectionNoFieldNumber = 33;

		private static readonly MessageParser<MST_SVT> _parser = new MessageParser<MST_SVT>(() => new MST_SVT());

		private int id_;

		private int baseSvtId_;

		private ByteString name_ = ByteString.Empty;

		private ByteString ruby_ = ByteString.Empty;

		private ByteString battleName_ = ByteString.Empty;

		private int classId_;

		private int type_;

		private int limitMax_;

		private int rewardLv_;

		private int friendshipId_;

		private int maxFriendshipRank_;

		private int genderType_;

		private int attri_;

		private int combineSkillId_;

		private int combineLimitId_;

		private int sellQp_;

		private int sellMana_;

		private int sellRarePri_;

		private int expType_;

		private int combineMaterialId_;

		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(170u);

		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();

		private int cost_;

		private int battleSize_;

		private int hpGaugeY_;

		private static readonly FieldCodec<int> _repeated_classPassive_codec = FieldCodec.ForInt32(202u);

		private readonly RepeatedField<int> classPassive_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_individuality_codec = FieldCodec.ForInt32(210u);

		private readonly RepeatedField<int> individuality_ = new RepeatedField<int>();

		private int starRate_;

		private int deathRate_;

		private int attackAttri_;

		private ByteString script_ = ByteString.Empty;

		private int illustratorId_;

		private int cvId_;

		private int collectionNo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT> Parser => MST_SVT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BaseSvtId
		{
			get => this.baseSvtId_;
			set
			{
				this.baseSvtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString Ruby
		{
			get => this.ruby_;
			set
			{
				this.ruby_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString BattleName
		{
			get => this.battleName_;
			set
			{
				this.battleName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int ClassId
		{
			get => this.classId_;
			set
			{
				this.classId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LimitMax
		{
			get => this.limitMax_;
			set
			{
				this.limitMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int RewardLv
		{
			get => this.rewardLv_;
			set
			{
				this.rewardLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FriendshipId
		{
			get => this.friendshipId_;
			set
			{
				this.friendshipId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaxFriendshipRank
		{
			get => this.maxFriendshipRank_;
			set
			{
				this.maxFriendshipRank_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GenderType
		{
			get => this.genderType_;
			set
			{
				this.genderType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Attri
		{
			get => this.attri_;
			set
			{
				this.attri_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CombineSkillId
		{
			get => this.combineSkillId_;
			set
			{
				this.combineSkillId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CombineLimitId
		{
			get => this.combineLimitId_;
			set
			{
				this.combineLimitId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SellQp
		{
			get => this.sellQp_;
			set
			{
				this.sellQp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SellMana
		{
			get => this.sellMana_;
			set
			{
				this.sellMana_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SellRarePri
		{
			get => this.sellRarePri_;
			set
			{
				this.sellRarePri_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ExpType
		{
			get => this.expType_;
			set
			{
				this.expType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CombineMaterialId
		{
			get => this.combineMaterialId_;
			set
			{
				this.combineMaterialId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> CardIds => this.cardIds_;

		[DebuggerNonUserCode]
		public int Cost
		{
			get => this.cost_;
			set
			{
				this.cost_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleSize
		{
			get => this.battleSize_;
			set
			{
				this.battleSize_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HpGaugeY
		{
			get => this.hpGaugeY_;
			set
			{
				this.hpGaugeY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ClassPassive => this.classPassive_;

		[DebuggerNonUserCode]
		public RepeatedField<int> Individuality => this.individuality_;

		[DebuggerNonUserCode]
		public int StarRate
		{
			get => this.starRate_;
			set
			{
				this.starRate_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DeathRate
		{
			get => this.deathRate_;
			set
			{
				this.deathRate_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AttackAttri
		{
			get => this.attackAttri_;
			set
			{
				this.attackAttri_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Script
		{
			get => this.script_;
			set
			{
				this.script_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int IllustratorId
		{
			get => this.illustratorId_;
			set
			{
				this.illustratorId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CvId
		{
			get => this.cvId_;
			set
			{
				this.cvId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CollectionNo
		{
			get => this.collectionNo_;
			set
			{
				this.collectionNo_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT(MST_SVT other) : this()
		{
			this.id_ = other.id_;
			this.baseSvtId_ = other.baseSvtId_;
			this.name_ = other.name_;
			this.ruby_ = other.ruby_;
			this.battleName_ = other.battleName_;
			this.classId_ = other.classId_;
			this.type_ = other.type_;
			this.limitMax_ = other.limitMax_;
			this.rewardLv_ = other.rewardLv_;
			this.friendshipId_ = other.friendshipId_;
			this.maxFriendshipRank_ = other.maxFriendshipRank_;
			this.genderType_ = other.genderType_;
			this.attri_ = other.attri_;
			this.combineSkillId_ = other.combineSkillId_;
			this.combineLimitId_ = other.combineLimitId_;
			this.sellQp_ = other.sellQp_;
			this.sellMana_ = other.sellMana_;
			this.sellRarePri_ = other.sellRarePri_;
			this.expType_ = other.expType_;
			this.combineMaterialId_ = other.combineMaterialId_;
			this.cardIds_ = other.cardIds_.Clone();
			this.cost_ = other.cost_;
			this.battleSize_ = other.battleSize_;
			this.hpGaugeY_ = other.hpGaugeY_;
			this.classPassive_ = other.classPassive_.Clone();
			this.individuality_ = other.individuality_.Clone();
			this.starRate_ = other.starRate_;
			this.deathRate_ = other.deathRate_;
			this.attackAttri_ = other.attackAttri_;
			this.script_ = other.script_;
			this.illustratorId_ = other.illustratorId_;
			this.cvId_ = other.cvId_;
			this.collectionNo_ = other.collectionNo_;
		}

		[DebuggerNonUserCode]
		public MST_SVT Clone()
		{
			return new MST_SVT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.BaseSvtId == other.BaseSvtId && !(this.Name != other.Name) && !(this.Ruby != other.Ruby) && !(this.BattleName != other.BattleName) && this.ClassId == other.ClassId && this.Type == other.Type && this.LimitMax == other.LimitMax && this.RewardLv == other.RewardLv && this.FriendshipId == other.FriendshipId && this.MaxFriendshipRank == other.MaxFriendshipRank && this.GenderType == other.GenderType && this.Attri == other.Attri && this.CombineSkillId == other.CombineSkillId && this.CombineLimitId == other.CombineLimitId && this.SellQp == other.SellQp && this.SellMana == other.SellMana && this.SellRarePri == other.SellRarePri && this.ExpType == other.ExpType && this.CombineMaterialId == other.CombineMaterialId && this.cardIds_.Equals(other.cardIds_) && this.Cost == other.Cost && this.BattleSize == other.BattleSize && this.HpGaugeY == other.HpGaugeY && this.classPassive_.Equals(other.classPassive_) && this.individuality_.Equals(other.individuality_) && this.StarRate == other.StarRate && this.DeathRate == other.DeathRate && this.AttackAttri == other.AttackAttri && !(this.Script != other.Script) && this.IllustratorId == other.IllustratorId && this.CvId == other.CvId && this.CollectionNo == other.CollectionNo));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BaseSvtId != 0)
			{
				num ^= this.BaseSvtId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Ruby.Length != 0)
			{
				num ^= this.Ruby.GetHashCode();
			}
			if (this.BattleName.Length != 0)
			{
				num ^= this.BattleName.GetHashCode();
			}
			if (this.ClassId != 0)
			{
				num ^= this.ClassId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.LimitMax != 0)
			{
				num ^= this.LimitMax.GetHashCode();
			}
			if (this.RewardLv != 0)
			{
				num ^= this.RewardLv.GetHashCode();
			}
			if (this.FriendshipId != 0)
			{
				num ^= this.FriendshipId.GetHashCode();
			}
			if (this.MaxFriendshipRank != 0)
			{
				num ^= this.MaxFriendshipRank.GetHashCode();
			}
			if (this.GenderType != 0)
			{
				num ^= this.GenderType.GetHashCode();
			}
			if (this.Attri != 0)
			{
				num ^= this.Attri.GetHashCode();
			}
			if (this.CombineSkillId != 0)
			{
				num ^= this.CombineSkillId.GetHashCode();
			}
			if (this.CombineLimitId != 0)
			{
				num ^= this.CombineLimitId.GetHashCode();
			}
			if (this.SellQp != 0)
			{
				num ^= this.SellQp.GetHashCode();
			}
			if (this.SellMana != 0)
			{
				num ^= this.SellMana.GetHashCode();
			}
			if (this.SellRarePri != 0)
			{
				num ^= this.SellRarePri.GetHashCode();
			}
			if (this.ExpType != 0)
			{
				num ^= this.ExpType.GetHashCode();
			}
			if (this.CombineMaterialId != 0)
			{
				num ^= this.CombineMaterialId.GetHashCode();
			}
			num ^= this.cardIds_.GetHashCode();
			if (this.Cost != 0)
			{
				num ^= this.Cost.GetHashCode();
			}
			if (this.BattleSize != 0)
			{
				num ^= this.BattleSize.GetHashCode();
			}
			if (this.HpGaugeY != 0)
			{
				num ^= this.HpGaugeY.GetHashCode();
			}
			num ^= this.classPassive_.GetHashCode();
			num ^= this.individuality_.GetHashCode();
			if (this.StarRate != 0)
			{
				num ^= this.StarRate.GetHashCode();
			}
			if (this.DeathRate != 0)
			{
				num ^= this.DeathRate.GetHashCode();
			}
			if (this.AttackAttri != 0)
			{
				num ^= this.AttackAttri.GetHashCode();
			}
			if (this.Script.Length != 0)
			{
				num ^= this.Script.GetHashCode();
			}
			if (this.IllustratorId != 0)
			{
				num ^= this.IllustratorId.GetHashCode();
			}
			if (this.CvId != 0)
			{
				num ^= this.CvId.GetHashCode();
			}
			if (this.CollectionNo != 0)
			{
				num ^= this.CollectionNo.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BaseSvtId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BaseSvtId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.Ruby.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.Ruby);
			}
			if (this.BattleName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.BattleName);
			}
			if (this.ClassId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ClassId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Type);
			}
			if (this.LimitMax != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.LimitMax);
			}
			if (this.RewardLv != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RewardLv);
			}
			if (this.FriendshipId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.FriendshipId);
			}
			if (this.MaxFriendshipRank != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxFriendshipRank);
			}
			if (this.GenderType != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.GenderType);
			}
			if (this.Attri != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Attri);
			}
			if (this.CombineSkillId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CombineSkillId);
			}
			if (this.CombineLimitId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CombineLimitId);
			}
			if (this.SellQp != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.SellQp);
			}
			if (this.SellMana != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.SellMana);
			}
			if (this.SellRarePri != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.SellRarePri);
			}
			if (this.ExpType != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.ExpType);
			}
			if (this.CombineMaterialId != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.CombineMaterialId);
			}
			this.cardIds_.WriteTo(output, MST_SVT._repeated_cardIds_codec);
			if (this.Cost != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.Cost);
			}
			if (this.BattleSize != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.BattleSize);
			}
			if (this.HpGaugeY != 0)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.HpGaugeY);
			}
			this.classPassive_.WriteTo(output, MST_SVT._repeated_classPassive_codec);
			this.individuality_.WriteTo(output, MST_SVT._repeated_individuality_codec);
			if (this.StarRate != 0)
			{
				output.WriteRawTag(216, 1);
				output.WriteInt32(this.StarRate);
			}
			if (this.DeathRate != 0)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt32(this.DeathRate);
			}
			if (this.AttackAttri != 0)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt32(this.AttackAttri);
			}
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(242, 1);
				output.WriteBytes(this.Script);
			}
			if (this.IllustratorId != 0)
			{
				output.WriteRawTag(248, 1);
				output.WriteInt32(this.IllustratorId);
			}
			if (this.CvId != 0)
			{
				output.WriteRawTag(128, 2);
				output.WriteInt32(this.CvId);
			}
			if (this.CollectionNo != 0)
			{
				output.WriteRawTag(136, 2);
				output.WriteInt32(this.CollectionNo);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BaseSvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseSvtId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Ruby.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Ruby);
			}
			if (this.BattleName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.BattleName);
			}
			if (this.ClassId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClassId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.LimitMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitMax);
			}
			if (this.RewardLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardLv);
			}
			if (this.FriendshipId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FriendshipId);
			}
			if (this.MaxFriendshipRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFriendshipRank);
			}
			if (this.GenderType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenderType);
			}
			if (this.Attri != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Attri);
			}
			if (this.CombineSkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CombineSkillId);
			}
			if (this.CombineLimitId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CombineLimitId);
			}
			if (this.SellQp != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SellQp);
			}
			if (this.SellMana != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SellMana);
			}
			if (this.SellRarePri != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SellRarePri);
			}
			if (this.ExpType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ExpType);
			}
			if (this.CombineMaterialId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CombineMaterialId);
			}
			num += this.cardIds_.CalculateSize(MST_SVT._repeated_cardIds_codec);
			if (this.Cost != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Cost);
			}
			if (this.BattleSize != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BattleSize);
			}
			if (this.HpGaugeY != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.HpGaugeY);
			}
			num += this.classPassive_.CalculateSize(MST_SVT._repeated_classPassive_codec);
			num += this.individuality_.CalculateSize(MST_SVT._repeated_individuality_codec);
			if (this.StarRate != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.StarRate);
			}
			if (this.DeathRate != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DeathRate);
			}
			if (this.AttackAttri != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.AttackAttri);
			}
			if (this.Script.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.Script);
			}
			if (this.IllustratorId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.IllustratorId);
			}
			if (this.CvId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CvId);
			}
			if (this.CollectionNo != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CollectionNo);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BaseSvtId != 0)
			{
				this.BaseSvtId = other.BaseSvtId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Ruby.Length != 0)
			{
				this.Ruby = other.Ruby;
			}
			if (other.BattleName.Length != 0)
			{
				this.BattleName = other.BattleName;
			}
			if (other.ClassId != 0)
			{
				this.ClassId = other.ClassId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.LimitMax != 0)
			{
				this.LimitMax = other.LimitMax;
			}
			if (other.RewardLv != 0)
			{
				this.RewardLv = other.RewardLv;
			}
			if (other.FriendshipId != 0)
			{
				this.FriendshipId = other.FriendshipId;
			}
			if (other.MaxFriendshipRank != 0)
			{
				this.MaxFriendshipRank = other.MaxFriendshipRank;
			}
			if (other.GenderType != 0)
			{
				this.GenderType = other.GenderType;
			}
			if (other.Attri != 0)
			{
				this.Attri = other.Attri;
			}
			if (other.CombineSkillId != 0)
			{
				this.CombineSkillId = other.CombineSkillId;
			}
			if (other.CombineLimitId != 0)
			{
				this.CombineLimitId = other.CombineLimitId;
			}
			if (other.SellQp != 0)
			{
				this.SellQp = other.SellQp;
			}
			if (other.SellMana != 0)
			{
				this.SellMana = other.SellMana;
			}
			if (other.SellRarePri != 0)
			{
				this.SellRarePri = other.SellRarePri;
			}
			if (other.ExpType != 0)
			{
				this.ExpType = other.ExpType;
			}
			if (other.CombineMaterialId != 0)
			{
				this.CombineMaterialId = other.CombineMaterialId;
			}
			this.cardIds_.Add(other.cardIds_);
			if (other.Cost != 0)
			{
				this.Cost = other.Cost;
			}
			if (other.BattleSize != 0)
			{
				this.BattleSize = other.BattleSize;
			}
			if (other.HpGaugeY != 0)
			{
				this.HpGaugeY = other.HpGaugeY;
			}
			this.classPassive_.Add(other.classPassive_);
			this.individuality_.Add(other.individuality_);
			if (other.StarRate != 0)
			{
				this.StarRate = other.StarRate;
			}
			if (other.DeathRate != 0)
			{
				this.DeathRate = other.DeathRate;
			}
			if (other.AttackAttri != 0)
			{
				this.AttackAttri = other.AttackAttri;
			}
			if (other.Script.Length != 0)
			{
				this.Script = other.Script;
			}
			if (other.IllustratorId != 0)
			{
				this.IllustratorId = other.IllustratorId;
			}
			if (other.CvId != 0)
			{
				this.CvId = other.CvId;
			}
			if (other.CollectionNo != 0)
			{
				this.CollectionNo = other.CollectionNo;
			}
		}

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                uint num2 = num;
                switch (num2)
                {
                    case 0xa8:
                    case 170:
                        {
                            this.cardIds_.AddEntriesFrom(input, _repeated_cardIds_codec);
                            continue;
                        }
                    case 200:
                    case 0xca:
                        {
                            this.classPassive_.AddEntriesFrom(input, _repeated_classPassive_codec);
                            continue;
                        }
                    case 0xd0:
                    case 210:
                        {
                            this.individuality_.AddEntriesFrom(input, _repeated_individuality_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.Id = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.BaseSvtId = input.ReadInt32();
                            continue;
                        }
                    case 0x1a:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x22:
                        {
                            this.Ruby = input.ReadBytes();
                            continue;
                        }
                    case 0x2a:
                        {
                            this.BattleName = input.ReadBytes();
                            continue;
                        }
                    case 0x30:
                        {
                            this.ClassId = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.LimitMax = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.RewardLv = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.FriendshipId = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.MaxFriendshipRank = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.GenderType = input.ReadInt32();
                            continue;
                        }
                    case 0x68:
                        {
                            this.Attri = input.ReadInt32();
                            continue;
                        }
                    case 0x70:
                        {
                            this.CombineSkillId = input.ReadInt32();
                            continue;
                        }
                    case 120:
                        {
                            this.CombineLimitId = input.ReadInt32();
                            continue;
                        }
                    case 0x80:
                        {
                            this.SellQp = input.ReadInt32();
                            continue;
                        }
                    case 0x88:
                        {
                            this.SellMana = input.ReadInt32();
                            continue;
                        }
                    case 0x90:
                        {
                            this.SellRarePri = input.ReadInt32();
                            continue;
                        }
                    case 0x98:
                        {
                            this.ExpType = input.ReadInt32();
                            continue;
                        }
                    case 160:
                        {
                            this.CombineMaterialId = input.ReadInt32();
                            continue;
                        }
                    case 0xb0:
                        {
                            this.Cost = input.ReadInt32();
                            continue;
                        }
                    case 0xb8:
                        {
                            this.BattleSize = input.ReadInt32();
                            continue;
                        }
                    case 0xc0:
                        {
                            this.HpGaugeY = input.ReadInt32();
                            continue;
                        }
                    case 0xd8:
                        {
                            this.StarRate = input.ReadInt32();
                            continue;
                        }
                    case 0xe0:
                        {
                            this.DeathRate = input.ReadInt32();
                            continue;
                        }
                    case 0xe8:
                        {
                            this.AttackAttri = input.ReadInt32();
                            continue;
                        }
                    case 0xf2:
                        {
                            this.Script = input.ReadBytes();
                            continue;
                        }
                    case 0xf8:
                        {
                            this.IllustratorId = input.ReadInt32();
                            continue;
                        }
                    case 0x100:
                        {
                            this.CvId = input.ReadInt32();
                            continue;
                        }
                    case 0x108:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.CollectionNo = input.ReadInt32();
            }
        }


    }
}
