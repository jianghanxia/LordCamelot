using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_TREASURE_DEVICE : IMessage, IMessage<MST_SVT_TREASURE_DEVICE>, IEquatable<MST_SVT_TREASURE_DEVICE>, IDeepCloneable<MST_SVT_TREASURE_DEVICE>
	{
		public const int SvtIdFieldNumber = 1;

		public const int NumFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int ImageIndexFieldNumber = 4;

		public const int TreasureDeviceIdFieldNumber = 5;

		public const int CondQuestIdFieldNumber = 6;

		public const int CondQuestPhaseFieldNumber = 7;

		public const int CondLvFieldNumber = 8;

		public const int CondFriendshipRankFieldNumber = 9;

		public const int MotionFieldNumber = 10;

		public const int DamageFieldNumber = 11;

		public const int CardIdFieldNumber = 12;

		public const int UpdatedAtFieldNumber = 13;

		public const int CreatedAtFieldNumber = 14;

		private static readonly MessageParser<MST_SVT_TREASURE_DEVICE> _parser = new MessageParser<MST_SVT_TREASURE_DEVICE>(() => new MST_SVT_TREASURE_DEVICE());

		private int svtId_;

		private int num_;

		private int priority_;

		private int imageIndex_;

		private int treasureDeviceId_;

		private int condQuestId_;

		private int condQuestPhase_;

		private int condLv_;

		private int condFriendshipRank_;

		private int motion_;

		private static readonly FieldCodec<int> _repeated_damage_codec = FieldCodec.ForInt32(90u);

		private readonly RepeatedField<int> damage_ = new RepeatedField<int>();

		private int cardId_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_TREASURE_DEVICE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_TREASURE_DEVICE> Parser => MST_SVT_TREASURE_DEVICE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtTreasureDeviceReflection.Descriptor.MessageTypes[0];

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
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ImageIndex
		{
			get => this.imageIndex_;
			set
			{
				this.imageIndex_ = value;
			}
		}

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
		public int CondQuestId
		{
			get => this.condQuestId_;
			set
			{
				this.condQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondQuestPhase
		{
			get => this.condQuestPhase_;
			set
			{
				this.condQuestPhase_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondLv
		{
			get => this.condLv_;
			set
			{
				this.condLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondFriendshipRank
		{
			get => this.condFriendshipRank_;
			set
			{
				this.condFriendshipRank_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Motion
		{
			get => this.motion_;
			set
			{
				this.motion_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Damage => this.damage_;

		[DebuggerNonUserCode]
		public int CardId
		{
			get => this.cardId_;
			set
			{
				this.cardId_ = value;
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
		public MST_SVT_TREASURE_DEVICE()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_TREASURE_DEVICE(MST_SVT_TREASURE_DEVICE other) : this()
		{
			this.svtId_ = other.svtId_;
			this.num_ = other.num_;
			this.priority_ = other.priority_;
			this.imageIndex_ = other.imageIndex_;
			this.treasureDeviceId_ = other.treasureDeviceId_;
			this.condQuestId_ = other.condQuestId_;
			this.condQuestPhase_ = other.condQuestPhase_;
			this.condLv_ = other.condLv_;
			this.condFriendshipRank_ = other.condFriendshipRank_;
			this.motion_ = other.motion_;
			this.damage_ = other.damage_.Clone();
			this.cardId_ = other.cardId_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_TREASURE_DEVICE Clone()
		{
			return new MST_SVT_TREASURE_DEVICE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_TREASURE_DEVICE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_TREASURE_DEVICE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.Num == other.Num && this.Priority == other.Priority && this.ImageIndex == other.ImageIndex && this.TreasureDeviceId == other.TreasureDeviceId && this.CondQuestId == other.CondQuestId && this.CondQuestPhase == other.CondQuestPhase && this.CondLv == other.CondLv && this.CondFriendshipRank == other.CondFriendshipRank && this.Motion == other.Motion && this.damage_.Equals(other.damage_) && this.CardId == other.CardId && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.ImageIndex != 0)
			{
				num ^= this.ImageIndex.GetHashCode();
			}
			if (this.TreasureDeviceId != 0)
			{
				num ^= this.TreasureDeviceId.GetHashCode();
			}
			if (this.CondQuestId != 0)
			{
				num ^= this.CondQuestId.GetHashCode();
			}
			if (this.CondQuestPhase != 0)
			{
				num ^= this.CondQuestPhase.GetHashCode();
			}
			if (this.CondLv != 0)
			{
				num ^= this.CondLv.GetHashCode();
			}
			if (this.CondFriendshipRank != 0)
			{
				num ^= this.CondFriendshipRank.GetHashCode();
			}
			if (this.Motion != 0)
			{
				num ^= this.Motion.GetHashCode();
			}
			num ^= this.damage_.GetHashCode();
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SvtId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Priority);
			}
			if (this.ImageIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ImageIndex);
			}
			if (this.TreasureDeviceId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TreasureDeviceId);
			}
			if (this.CondQuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CondQuestId);
			}
			if (this.CondQuestPhase != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CondQuestPhase);
			}
			if (this.CondLv != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CondLv);
			}
			if (this.CondFriendshipRank != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CondFriendshipRank);
			}
			if (this.Motion != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Motion);
			}
			this.damage_.WriteTo(output, MST_SVT_TREASURE_DEVICE._repeated_damage_codec);
			if (this.CardId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CardId);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.ImageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageIndex);
			}
			if (this.TreasureDeviceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceId);
			}
			if (this.CondQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestId);
			}
			if (this.CondQuestPhase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestPhase);
			}
			if (this.CondLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondLv);
			}
			if (this.CondFriendshipRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondFriendshipRank);
			}
			if (this.Motion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Motion);
			}
			num += this.damage_.CalculateSize(MST_SVT_TREASURE_DEVICE._repeated_damage_codec);
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this.UpdatedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_TREASURE_DEVICE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.ImageIndex != 0)
			{
				this.ImageIndex = other.ImageIndex;
			}
			if (other.TreasureDeviceId != 0)
			{
				this.TreasureDeviceId = other.TreasureDeviceId;
			}
			if (other.CondQuestId != 0)
			{
				this.CondQuestId = other.CondQuestId;
			}
			if (other.CondQuestPhase != 0)
			{
				this.CondQuestPhase = other.CondQuestPhase;
			}
			if (other.CondLv != 0)
			{
				this.CondLv = other.CondLv;
			}
			if (other.CondFriendshipRank != 0)
			{
				this.CondFriendshipRank = other.CondFriendshipRank;
			}
			if (other.Motion != 0)
			{
				this.Motion = other.Motion;
			}
			this.damage_.Add(other.damage_);
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
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
                    case 0x58:
                    case 90:
                        {
                            this.damage_.AddEntriesFrom(input, _repeated_damage_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.SvtId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.Num = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.ImageIndex = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.TreasureDeviceId = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.CondQuestId = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.CondQuestPhase = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.CondLv = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.CondFriendshipRank = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.Motion = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.CardId = input.ReadInt32();
                            continue;
                        }
                    case 0x68:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x70:
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
