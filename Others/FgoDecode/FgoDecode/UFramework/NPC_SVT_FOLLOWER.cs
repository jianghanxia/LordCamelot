using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_SVT_FOLLOWER : IMessage, IMessage<NPC_SVT_FOLLOWER>, IEquatable<NPC_SVT_FOLLOWER>, IDeepCloneable<NPC_SVT_FOLLOWER>
	{
		public const int IdFieldNumber = 1;

		public const int SvtIdFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int LvFieldNumber = 4;

		public const int LimitCountFieldNumber = 5;

		public const int HpFieldNumber = 6;

		public const int AtkFieldNumber = 7;

		public const int PassiveSkillFieldNumber = 8;

		public const int TreasureDeviceIdFieldNumber = 9;

		public const int TreasureDeviceLvFieldNumber = 10;

		public const int SkillId1FieldNumber = 11;

		public const int SkillId2FieldNumber = 12;

		public const int SkillId3FieldNumber = 13;

		public const int SkillLv1FieldNumber = 14;

		public const int SkillLv2FieldNumber = 15;

		public const int SkillLv3FieldNumber = 16;

		public const int FlagFieldNumber = 17;

		public const int UpdatedAtFieldNumber = 18;

		public const int CreatedAtFieldNumber = 19;

		private static readonly MessageParser<NPC_SVT_FOLLOWER> _parser = new MessageParser<NPC_SVT_FOLLOWER>(() => new NPC_SVT_FOLLOWER());

		private int id_;

		private int svtId_;

		private ByteString name_ = ByteString.Empty;

		private int lv_;

		private int limitCount_;

		private int hp_;

		private int atk_;

		private static readonly FieldCodec<int> _repeated_passiveSkill_codec = FieldCodec.ForInt32(66u);

		private readonly RepeatedField<int> passiveSkill_ = new RepeatedField<int>();

		private int treasureDeviceId_;

		private int treasureDeviceLv_;

		private int skillId1_;

		private int skillId2_;

		private int skillId3_;

		private int skillLv1_;

		private int skillLv2_;

		private int skillLv3_;

		private int flag_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_SVT_FOLLOWER.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_SVT_FOLLOWER> Parser => NPC_SVT_FOLLOWER._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcSvtFollowerReflection.Descriptor.MessageTypes[0];

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
		public RepeatedField<int> PassiveSkill => this.passiveSkill_;

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
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong UpdatedAt
		{
			get => this.updatedAt_;
			set
			{
				this.updatedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get => this.createdAt_;
			set
			{
				this.createdAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public NPC_SVT_FOLLOWER()
		{
		}

		[DebuggerNonUserCode]
		public NPC_SVT_FOLLOWER(NPC_SVT_FOLLOWER other) : this()
		{
			this.id_ = other.id_;
			this.svtId_ = other.svtId_;
			this.name_ = other.name_;
			this.lv_ = other.lv_;
			this.limitCount_ = other.limitCount_;
			this.hp_ = other.hp_;
			this.atk_ = other.atk_;
			this.passiveSkill_ = other.passiveSkill_.Clone();
			this.treasureDeviceId_ = other.treasureDeviceId_;
			this.treasureDeviceLv_ = other.treasureDeviceLv_;
			this.skillId1_ = other.skillId1_;
			this.skillId2_ = other.skillId2_;
			this.skillId3_ = other.skillId3_;
			this.skillLv1_ = other.skillLv1_;
			this.skillLv2_ = other.skillLv2_;
			this.skillLv3_ = other.skillLv3_;
			this.flag_ = other.flag_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public NPC_SVT_FOLLOWER Clone()
		{
			return new NPC_SVT_FOLLOWER(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_SVT_FOLLOWER);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_SVT_FOLLOWER other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.SvtId == other.SvtId && !(this.Name != other.Name) && this.Lv == other.Lv && this.LimitCount == other.LimitCount && this.Hp == other.Hp && this.Atk == other.Atk && this.passiveSkill_.Equals(other.passiveSkill_) && this.TreasureDeviceId == other.TreasureDeviceId && this.TreasureDeviceLv == other.TreasureDeviceLv && this.SkillId1 == other.SkillId1 && this.SkillId2 == other.SkillId2 && this.SkillId3 == other.SkillId3 && this.SkillLv1 == other.SkillLv1 && this.SkillLv2 == other.SkillLv2 && this.SkillLv3 == other.SkillLv3 && this.Flag == other.Flag && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
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
			num ^= this.passiveSkill_.GetHashCode();
			if (this.TreasureDeviceId != 0)
			{
				num ^= this.TreasureDeviceId.GetHashCode();
			}
			if (this.TreasureDeviceLv != 0)
			{
				num ^= this.TreasureDeviceLv.GetHashCode();
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
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.UpdatedAt != 0uL)
			{
				num ^= this.UpdatedAt.GetHashCode();
			}
			if (this.CreatedAt != 0uL)
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
			this.passiveSkill_.WriteTo(output, NPC_SVT_FOLLOWER._repeated_passiveSkill_codec);
			if (this.TreasureDeviceId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreasureDeviceId);
			}
			if (this.TreasureDeviceLv != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TreasureDeviceLv);
			}
			if (this.SkillId1 != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SkillId1);
			}
			if (this.SkillId2 != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SkillId2);
			}
			if (this.SkillId3 != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillId3);
			}
			if (this.SkillLv1 != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillLv1);
			}
			if (this.SkillLv2 != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SkillLv2);
			}
			if (this.SkillLv3 != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.SkillLv3);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.Flag);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt64(this.CreatedAt);
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
			num += this.passiveSkill_.CalculateSize(NPC_SVT_FOLLOWER._repeated_passiveSkill_codec);
			if (this.TreasureDeviceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceId);
			}
			if (this.TreasureDeviceLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceLv);
			}
			if (this.SkillId1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId1);
			}
			if (this.SkillId2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId2);
			}
			if (this.SkillId3 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId3);
			}
			if (this.SkillLv1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLv1);
			}
			if (this.SkillLv2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLv2);
			}
			if (this.SkillLv3 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SkillLv3);
			}
			if (this.Flag != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.UpdatedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(NPC_SVT_FOLLOWER other)
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
			this.passiveSkill_.Add(other.passiveSkill_);
			if (other.TreasureDeviceId != 0)
			{
				this.TreasureDeviceId = other.TreasureDeviceId;
			}
			if (other.TreasureDeviceLv != 0)
			{
				this.TreasureDeviceLv = other.TreasureDeviceLv;
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
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.UpdatedAt != 0uL)
			{
				this.UpdatedAt = other.UpdatedAt;
			}
			if (other.CreatedAt != 0uL)
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
                            this.TreasureDeviceId = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.TreasureDeviceLv = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.SkillId1 = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.SkillId2 = input.ReadInt32();
                            continue;
                        }
                    case 0x68:
                        {
                            this.SkillId3 = input.ReadInt32();
                            continue;
                        }
                    case 0x70:
                        {
                            this.SkillLv1 = input.ReadInt32();
                            continue;
                        }
                    case 120:
                        {
                            this.SkillLv2 = input.ReadInt32();
                            continue;
                        }
                    case 0x80:
                        {
                            this.SkillLv3 = input.ReadInt32();
                            continue;
                        }
                    case 0x88:
                        {
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 0x90:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x98:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.CreatedAt = input.ReadUInt64();
            }
        }


    }
}
