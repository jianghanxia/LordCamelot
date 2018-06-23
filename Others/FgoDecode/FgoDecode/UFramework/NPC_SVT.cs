using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_SVT : IMessage, IMessage<NPC_SVT>, IEquatable<NPC_SVT>, IDeepCloneable<NPC_SVT>
	{
		public const int IdFieldNumber = 1;

		public const int SvtIdFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int LvFieldNumber = 4;

		public const int LimitCountFieldNumber = 5;

		public const int HpFieldNumber = 6;

		public const int AtkFieldNumber = 7;

		public const int IndividualityFieldNumber = 8;

		public const int CriticalRateFieldNumber = 9;

		public const int StarRateFieldNumber = 10;

		public const int TdRateFieldNumber = 11;

		public const int TdAttackRateFieldNumber = 12;

		public const int DeathRateFieldNumber = 13;

		public const int DropIdsFieldNumber = 14;

		public const int TreasureDeviceIdFieldNumber = 15;

		public const int TreasureDeviceLvFieldNumber = 16;

		public const int PassiveSkillFieldNumber = 17;

		public const int AiIdFieldNumber = 18;

		public const int ChargeTurnFieldNumber = 19;

		public const int ActPriorityFieldNumber = 20;

		public const int MaxActNumFieldNumber = 21;

		public const int SkillId1FieldNumber = 22;

		public const int SkillId2FieldNumber = 23;

		public const int SkillId3FieldNumber = 24;

		public const int SkillLv1FieldNumber = 25;

		public const int SkillLv2FieldNumber = 26;

		public const int SkillLv3FieldNumber = 27;

		public const int HpGaugeTypeFieldNumber = 28;

		public const int NpcSvtTypeFieldNumber = 29;

		public const int NpcSvtClassIdFieldNumber = 30;

		public const int DisplayTypeFieldNumber = 31;

		public const int UpdatedAtFieldNumber = 32;

		public const int CreatedAtFieldNumber = 33;

		private static readonly MessageParser<NPC_SVT> _parser = new MessageParser<NPC_SVT>(() => new NPC_SVT());

		private int id_;

		private int svtId_;

		private ByteString name_ = ByteString.Empty;

		private int lv_;

		private int limitCount_;

		private int hp_;

		private int atk_;

		private static readonly FieldCodec<long> _repeated_individuality_codec = FieldCodec.ForInt64(66u);

		private readonly RepeatedField<long> individuality_ = new RepeatedField<long>();

		private int criticalRate_;

		private int starRate_;

		private int tdRate_;

		private int tdAttackRate_;

		private int deathRate_;

		private static readonly FieldCodec<long> _repeated_dropIds_codec = FieldCodec.ForInt64(114u);

		private readonly RepeatedField<long> dropIds_ = new RepeatedField<long>();

		private int treasureDeviceId_;

		private int treasureDeviceLv_;

		private static readonly FieldCodec<long> _repeated_passiveSkill_codec = FieldCodec.ForInt64(138u);

		private readonly RepeatedField<long> passiveSkill_ = new RepeatedField<long>();

		private int aiId_;

		private int chargeTurn_;

		private int actPriority_;

		private int maxActNum_;

		private int skillId1_;

		private int skillId2_;

		private int skillId3_;

		private int skillLv1_;

		private int skillLv2_;

		private int skillLv3_;

		private int hpGaugeType_;

		private int npcSvtType_;

		private int npcSvtClassId_;

		private int displayType_;

		private int updatedAt_;

		private int createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_SVT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_SVT> Parser => NPC_SVT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcSvtReflection.Descriptor.MessageTypes[0];

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
		public int SvtId
		{
			get => this.svtId_;
			set
			{
				this.svtId_ = value;
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
		public int Lv
		{
			get => this.lv_;
			set
			{
				this.lv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LimitCount
		{
			get => this.limitCount_;
			set
			{
				this.limitCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Hp
		{
			get => this.hp_;
			set
			{
				this.hp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Atk
		{
			get => this.atk_;
			set
			{
				this.atk_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> Individuality => this.individuality_;

		[DebuggerNonUserCode]
		public int CriticalRate
		{
			get => this.criticalRate_;
			set
			{
				this.criticalRate_ = value;
			}
		}

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
		public int TdRate
		{
			get => this.tdRate_;
			set
			{
				this.tdRate_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdAttackRate
		{
			get => this.tdAttackRate_;
			set
			{
				this.tdAttackRate_ = value;
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
		public RepeatedField<long> DropIds => this.dropIds_;

		[DebuggerNonUserCode]
		public int TreasureDeviceId
		{
			get => this.treasureDeviceId_;
			set
			{
				this.treasureDeviceId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TreasureDeviceLv
		{
			get => this.treasureDeviceLv_;
			set
			{
				this.treasureDeviceLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> PassiveSkill => this.passiveSkill_;

		[DebuggerNonUserCode]
		public int AiId
		{
			get => this.aiId_;
			set
			{
				this.aiId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ChargeTurn
		{
			get => this.chargeTurn_;
			set
			{
				this.chargeTurn_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActPriority
		{
			get => this.actPriority_;
			set
			{
				this.actPriority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaxActNum
		{
			get => this.maxActNum_;
			set
			{
				this.maxActNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillId1
		{
			get => this.skillId1_;
			set
			{
				this.skillId1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillId2
		{
			get => this.skillId2_;
			set
			{
				this.skillId2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillId3
		{
			get => this.skillId3_;
			set
			{
				this.skillId3_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillLv1
		{
			get => this.skillLv1_;
			set
			{
				this.skillLv1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillLv2
		{
			get => this.skillLv2_;
			set
			{
				this.skillLv2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillLv3
		{
			get => this.skillLv3_;
			set
			{
				this.skillLv3_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HpGaugeType
		{
			get => this.hpGaugeType_;
			set
			{
				this.hpGaugeType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int NpcSvtType
		{
			get => this.npcSvtType_;
			set
			{
				this.npcSvtType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int NpcSvtClassId
		{
			get => this.npcSvtClassId_;
			set
			{
				this.npcSvtClassId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DisplayType
		{
			get => this.displayType_;
			set
			{
				this.displayType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int UpdatedAt
		{
			get => this.updatedAt_;
			set
			{
				this.updatedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CreatedAt
		{
			get => this.createdAt_;
			set
			{
				this.createdAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public NPC_SVT()
		{
		}

		[DebuggerNonUserCode]
		public NPC_SVT(NPC_SVT other) : this()
		{
			this.id_ = other.id_;
			this.svtId_ = other.svtId_;
			this.name_ = other.name_;
			this.lv_ = other.lv_;
			this.limitCount_ = other.limitCount_;
			this.hp_ = other.hp_;
			this.atk_ = other.atk_;
			this.individuality_ = other.individuality_.Clone();
			this.criticalRate_ = other.criticalRate_;
			this.starRate_ = other.starRate_;
			this.tdRate_ = other.tdRate_;
			this.tdAttackRate_ = other.tdAttackRate_;
			this.deathRate_ = other.deathRate_;
			this.dropIds_ = other.dropIds_.Clone();
			this.treasureDeviceId_ = other.treasureDeviceId_;
			this.treasureDeviceLv_ = other.treasureDeviceLv_;
			this.passiveSkill_ = other.passiveSkill_.Clone();
			this.aiId_ = other.aiId_;
			this.chargeTurn_ = other.chargeTurn_;
			this.actPriority_ = other.actPriority_;
			this.maxActNum_ = other.maxActNum_;
			this.skillId1_ = other.skillId1_;
			this.skillId2_ = other.skillId2_;
			this.skillId3_ = other.skillId3_;
			this.skillLv1_ = other.skillLv1_;
			this.skillLv2_ = other.skillLv2_;
			this.skillLv3_ = other.skillLv3_;
			this.hpGaugeType_ = other.hpGaugeType_;
			this.npcSvtType_ = other.npcSvtType_;
			this.npcSvtClassId_ = other.npcSvtClassId_;
			this.displayType_ = other.displayType_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public NPC_SVT Clone()
		{
			return new NPC_SVT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_SVT);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_SVT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.SvtId == other.SvtId && !(this.Name != other.Name) && this.Lv == other.Lv && this.LimitCount == other.LimitCount && this.Hp == other.Hp && this.Atk == other.Atk && this.individuality_.Equals(other.individuality_) && this.CriticalRate == other.CriticalRate && this.StarRate == other.StarRate && this.TdRate == other.TdRate && this.TdAttackRate == other.TdAttackRate && this.DeathRate == other.DeathRate && this.dropIds_.Equals(other.dropIds_) && this.TreasureDeviceId == other.TreasureDeviceId && this.TreasureDeviceLv == other.TreasureDeviceLv && this.passiveSkill_.Equals(other.passiveSkill_) && this.AiId == other.AiId && this.ChargeTurn == other.ChargeTurn && this.ActPriority == other.ActPriority && this.MaxActNum == other.MaxActNum && this.SkillId1 == other.SkillId1 && this.SkillId2 == other.SkillId2 && this.SkillId3 == other.SkillId3 && this.SkillLv1 == other.SkillLv1 && this.SkillLv2 == other.SkillLv2 && this.SkillLv3 == other.SkillLv3 && this.HpGaugeType == other.HpGaugeType && this.NpcSvtType == other.NpcSvtType && this.NpcSvtClassId == other.NpcSvtClassId && this.DisplayType == other.DisplayType && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.Hp != 0)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this.Atk != 0)
			{
				num ^= this.Atk.GetHashCode();
			}
			num ^= this.individuality_.GetHashCode();
			if (this.CriticalRate != 0)
			{
				num ^= this.CriticalRate.GetHashCode();
			}
			if (this.StarRate != 0)
			{
				num ^= this.StarRate.GetHashCode();
			}
			if (this.TdRate != 0)
			{
				num ^= this.TdRate.GetHashCode();
			}
			if (this.TdAttackRate != 0)
			{
				num ^= this.TdAttackRate.GetHashCode();
			}
			if (this.DeathRate != 0)
			{
				num ^= this.DeathRate.GetHashCode();
			}
			num ^= this.dropIds_.GetHashCode();
			if (this.TreasureDeviceId != 0)
			{
				num ^= this.TreasureDeviceId.GetHashCode();
			}
			if (this.TreasureDeviceLv != 0)
			{
				num ^= this.TreasureDeviceLv.GetHashCode();
			}
			num ^= this.passiveSkill_.GetHashCode();
			if (this.AiId != 0)
			{
				num ^= this.AiId.GetHashCode();
			}
			if (this.ChargeTurn != 0)
			{
				num ^= this.ChargeTurn.GetHashCode();
			}
			if (this.ActPriority != 0)
			{
				num ^= this.ActPriority.GetHashCode();
			}
			if (this.MaxActNum != 0)
			{
				num ^= this.MaxActNum.GetHashCode();
			}
			if (this.SkillId1 != 0)
			{
				num ^= this.SkillId1.GetHashCode();
			}
			if (this.SkillId2 != 0)
			{
				num ^= this.SkillId2.GetHashCode();
			}
			if (this.SkillId3 != 0)
			{
				num ^= this.SkillId3.GetHashCode();
			}
			if (this.SkillLv1 != 0)
			{
				num ^= this.SkillLv1.GetHashCode();
			}
			if (this.SkillLv2 != 0)
			{
				num ^= this.SkillLv2.GetHashCode();
			}
			if (this.SkillLv3 != 0)
			{
				num ^= this.SkillLv3.GetHashCode();
			}
			if (this.HpGaugeType != 0)
			{
				num ^= this.HpGaugeType.GetHashCode();
			}
			if (this.NpcSvtType != 0)
			{
				num ^= this.NpcSvtType.GetHashCode();
			}
			if (this.NpcSvtClassId != 0)
			{
				num ^= this.NpcSvtClassId.GetHashCode();
			}
			if (this.DisplayType != 0)
			{
				num ^= this.DisplayType.GetHashCode();
			}
			if (this.UpdatedAt != 0)
			{
				num ^= this.UpdatedAt.GetHashCode();
			}
			if (this.CreatedAt != 0)
			{
				num ^= this.CreatedAt.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SvtId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Lv);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitCount);
			}
			if (this.Hp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Hp);
			}
			if (this.Atk != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Atk);
			}
			this.individuality_.WriteTo(output, NPC_SVT._repeated_individuality_codec);
			if (this.CriticalRate != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CriticalRate);
			}
			if (this.StarRate != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StarRate);
			}
			if (this.TdRate != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TdRate);
			}
			if (this.TdAttackRate != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TdAttackRate);
			}
			if (this.DeathRate != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DeathRate);
			}
			this.dropIds_.WriteTo(output, NPC_SVT._repeated_dropIds_codec);
			if (this.TreasureDeviceId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TreasureDeviceId);
			}
			if (this.TreasureDeviceLv != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.TreasureDeviceLv);
			}
			this.passiveSkill_.WriteTo(output, NPC_SVT._repeated_passiveSkill_codec);
			if (this.AiId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.AiId);
			}
			if (this.ChargeTurn != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.ChargeTurn);
			}
			if (this.ActPriority != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.ActPriority);
			}
			if (this.MaxActNum != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.MaxActNum);
			}
			if (this.SkillId1 != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.SkillId1);
			}
			if (this.SkillId2 != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.SkillId2);
			}
			if (this.SkillId3 != 0)
			{
				output.WriteRawTag(192, 1);
				output.WriteInt32(this.SkillId3);
			}
			if (this.SkillLv1 != 0)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.SkillLv1);
			}
			if (this.SkillLv2 != 0)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt32(this.SkillLv2);
			}
			if (this.SkillLv3 != 0)
			{
				output.WriteRawTag(216, 1);
				output.WriteInt32(this.SkillLv3);
			}
			if (this.HpGaugeType != 0)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt32(this.HpGaugeType);
			}
			if (this.NpcSvtType != 0)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt32(this.NpcSvtType);
			}
			if (this.NpcSvtClassId != 0)
			{
				output.WriteRawTag(240, 1);
				output.WriteInt32(this.NpcSvtClassId);
			}
			if (this.DisplayType != 0)
			{
				output.WriteRawTag(248, 1);
				output.WriteInt32(this.DisplayType);
			}
			if (this.UpdatedAt != 0)
			{
				output.WriteRawTag(128, 2);
				output.WriteInt32(this.UpdatedAt);
			}
			if (this.CreatedAt != 0)
			{
				output.WriteRawTag(136, 2);
				output.WriteInt32(this.CreatedAt);
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
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.Hp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Hp);
			}
			if (this.Atk != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Atk);
			}
			num += this.individuality_.CalculateSize(NPC_SVT._repeated_individuality_codec);
			if (this.CriticalRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CriticalRate);
			}
			if (this.StarRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StarRate);
			}
			if (this.TdRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdRate);
			}
			if (this.TdAttackRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdAttackRate);
			}
			if (this.DeathRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeathRate);
			}
			num += this.dropIds_.CalculateSize(NPC_SVT._repeated_dropIds_codec);
			if (this.TreasureDeviceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceId);
			}
			if (this.TreasureDeviceLv != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceLv);
			}
			num += this.passiveSkill_.CalculateSize(NPC_SVT._repeated_passiveSkill_codec);
			if (this.AiId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.AiId);
			}
			if (this.ChargeTurn != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ChargeTurn);
			}
			if (this.ActPriority != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ActPriority);
			}
			if (this.MaxActNum != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxActNum);
			}
			if (this.SkillId1 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillId1);
			}
			if (this.SkillId2 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillId2);
			}
			if (this.SkillId3 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillId3);
			}
			if (this.SkillLv1 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillLv1);
			}
			if (this.SkillLv2 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillLv2);
			}
			if (this.SkillLv3 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillLv3);
			}
			if (this.HpGaugeType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.HpGaugeType);
			}
			if (this.NpcSvtType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NpcSvtType);
			}
			if (this.NpcSvtClassId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.NpcSvtClassId);
			}
			if (this.DisplayType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DisplayType);
			}
			if (this.UpdatedAt != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(NPC_SVT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.Hp != 0)
			{
				this.Hp = other.Hp;
			}
			if (other.Atk != 0)
			{
				this.Atk = other.Atk;
			}
			this.individuality_.Add(other.individuality_);
			if (other.CriticalRate != 0)
			{
				this.CriticalRate = other.CriticalRate;
			}
			if (other.StarRate != 0)
			{
				this.StarRate = other.StarRate;
			}
			if (other.TdRate != 0)
			{
				this.TdRate = other.TdRate;
			}
			if (other.TdAttackRate != 0)
			{
				this.TdAttackRate = other.TdAttackRate;
			}
			if (other.DeathRate != 0)
			{
				this.DeathRate = other.DeathRate;
			}
			this.dropIds_.Add(other.dropIds_);
			if (other.TreasureDeviceId != 0)
			{
				this.TreasureDeviceId = other.TreasureDeviceId;
			}
			if (other.TreasureDeviceLv != 0)
			{
				this.TreasureDeviceLv = other.TreasureDeviceLv;
			}
			this.passiveSkill_.Add(other.passiveSkill_);
			if (other.AiId != 0)
			{
				this.AiId = other.AiId;
			}
			if (other.ChargeTurn != 0)
			{
				this.ChargeTurn = other.ChargeTurn;
			}
			if (other.ActPriority != 0)
			{
				this.ActPriority = other.ActPriority;
			}
			if (other.MaxActNum != 0)
			{
				this.MaxActNum = other.MaxActNum;
			}
			if (other.SkillId1 != 0)
			{
				this.SkillId1 = other.SkillId1;
			}
			if (other.SkillId2 != 0)
			{
				this.SkillId2 = other.SkillId2;
			}
			if (other.SkillId3 != 0)
			{
				this.SkillId3 = other.SkillId3;
			}
			if (other.SkillLv1 != 0)
			{
				this.SkillLv1 = other.SkillLv1;
			}
			if (other.SkillLv2 != 0)
			{
				this.SkillLv2 = other.SkillLv2;
			}
			if (other.SkillLv3 != 0)
			{
				this.SkillLv3 = other.SkillLv3;
			}
			if (other.HpGaugeType != 0)
			{
				this.HpGaugeType = other.HpGaugeType;
			}
			if (other.NpcSvtType != 0)
			{
				this.NpcSvtType = other.NpcSvtType;
			}
			if (other.NpcSvtClassId != 0)
			{
				this.NpcSvtClassId = other.NpcSvtClassId;
			}
			if (other.DisplayType != 0)
			{
				this.DisplayType = other.DisplayType;
			}
			if (other.UpdatedAt != 0)
			{
				this.UpdatedAt = other.UpdatedAt;
			}
			if (other.CreatedAt != 0)
			{
				this.CreatedAt = other.CreatedAt;
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
                    case 0x40:
                    case 0x42:
                        {
                            this.individuality_.AddEntriesFrom(input, _repeated_individuality_codec);
                            continue;
                        }
                    case 0x70:
                    case 0x72:
                        {
                            this.dropIds_.AddEntriesFrom(input, _repeated_dropIds_codec);
                            continue;
                        }
                    case 0x88:
                    case 0x8a:
                        {
                            this.passiveSkill_.AddEntriesFrom(input, _repeated_passiveSkill_codec);
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
                            this.SvtId = input.ReadInt32();
                            continue;
                        }
                    case 0x1a:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x20:
                        {
                            this.Lv = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.LimitCount = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.Hp = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.Atk = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.CriticalRate = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.StarRate = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.TdRate = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.TdAttackRate = input.ReadInt32();
                            continue;
                        }
                    case 0x68:
                        {
                            this.DeathRate = input.ReadInt32();
                            continue;
                        }
                    case 120:
                        {
                            this.TreasureDeviceId = input.ReadInt32();
                            continue;
                        }
                    case 0x80:
                        {
                            this.TreasureDeviceLv = input.ReadInt32();
                            continue;
                        }
                    case 0x90:
                        {
                            this.AiId = input.ReadInt32();
                            continue;
                        }
                    case 0x98:
                        {
                            this.ChargeTurn = input.ReadInt32();
                            continue;
                        }
                    case 160:
                        {
                            this.ActPriority = input.ReadInt32();
                            continue;
                        }
                    case 0xa8:
                        {
                            this.MaxActNum = input.ReadInt32();
                            continue;
                        }
                    case 0xb0:
                        {
                            this.SkillId1 = input.ReadInt32();
                            continue;
                        }
                    case 0xb8:
                        {
                            this.SkillId2 = input.ReadInt32();
                            continue;
                        }
                    case 0xc0:
                        {
                            this.SkillId3 = input.ReadInt32();
                            continue;
                        }
                    case 200:
                        {
                            this.SkillLv1 = input.ReadInt32();
                            continue;
                        }
                    case 0xd0:
                        {
                            this.SkillLv2 = input.ReadInt32();
                            continue;
                        }
                    case 0xd8:
                        {
                            this.SkillLv3 = input.ReadInt32();
                            continue;
                        }
                    case 0xe0:
                        {
                            this.HpGaugeType = input.ReadInt32();
                            continue;
                        }
                    case 0xe8:
                        {
                            this.NpcSvtType = input.ReadInt32();
                            continue;
                        }
                    case 240:
                        {
                            this.NpcSvtClassId = input.ReadInt32();
                            continue;
                        }
                    case 0xf8:
                        {
                            this.DisplayType = input.ReadInt32();
                            continue;
                        }
                    case 0x100:
                        {
                            this.UpdatedAt = input.ReadInt32();
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
                this.CreatedAt = input.ReadInt32();
            }
        }

    }
}
