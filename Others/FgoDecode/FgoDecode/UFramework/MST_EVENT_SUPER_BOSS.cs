using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_SUPER_BOSS : IMessage, IMessage<MST_EVENT_SUPER_BOSS>, IEquatable<MST_EVENT_SUPER_BOSS>, IDeepCloneable<MST_EVENT_SUPER_BOSS>
	{
		public const int EventIdFieldNumber = 1;

		public const int IdFieldNumber = 2;

		public const int MaxHpFieldNumber = 3;

		public const int SplitQuestIdsFieldNumber = 4;

		public const int SplitHpFieldNumber = 5;

		public const int IconIdFieldNumber = 6;

		public const int BossColorFieldNumber = 7;

		public const int StartedAtFieldNumber = 8;

		public const int EndedAtFieldNumber = 9;

		private static readonly MessageParser<MST_EVENT_SUPER_BOSS> _parser = new MessageParser<MST_EVENT_SUPER_BOSS>(() => new MST_EVENT_SUPER_BOSS());

		private int eventId_;

		private int id_;

		private long maxHp_;

		private static readonly FieldCodec<int> _repeated_splitQuestIds_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> splitQuestIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<long> _repeated_splitHp_codec = FieldCodec.ForInt64(42u);

		private readonly RepeatedField<long> splitHp_ = new RepeatedField<long>();

		private int iconId_;

		private ByteString bossColor_ = ByteString.Empty;

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_SUPER_BOSS.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_SUPER_BOSS> Parser => MST_EVENT_SUPER_BOSS._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventSuperBossReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int EventId
		{
			get => this.eventId_;
			set
			{
				this.eventId_ = value;
			}
		}

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
		public long MaxHp
		{
			get => this.maxHp_;
			set
			{
				this.maxHp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> SplitQuestIds => this.splitQuestIds_;

		[DebuggerNonUserCode]
		public RepeatedField<long> SplitHp => this.splitHp_;

		[DebuggerNonUserCode]
		public int IconId
		{
			get => this.iconId_;
			set
			{
				this.iconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString BossColor
		{
			get => this.bossColor_;
			set
			{
				this.bossColor_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ulong StartedAt
		{
			get => this.startedAt_;
			set
			{
				this.startedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong EndedAt
		{
			get => this.endedAt_;
			set
			{
				this.endedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_SUPER_BOSS()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_SUPER_BOSS(MST_EVENT_SUPER_BOSS other) : this()
		{
			this.eventId_ = other.eventId_;
			this.id_ = other.id_;
			this.maxHp_ = other.maxHp_;
			this.splitQuestIds_ = other.splitQuestIds_.Clone();
			this.splitHp_ = other.splitHp_.Clone();
			this.iconId_ = other.iconId_;
			this.bossColor_ = other.bossColor_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_SUPER_BOSS Clone()
		{
			return new MST_EVENT_SUPER_BOSS(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_SUPER_BOSS);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_SUPER_BOSS other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.Id == other.Id && this.MaxHp == other.MaxHp && this.splitQuestIds_.Equals(other.splitQuestIds_) && this.splitHp_.Equals(other.splitHp_) && this.IconId == other.IconId && !(this.BossColor != other.BossColor) && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MaxHp != 0L)
			{
				num ^= this.MaxHp.GetHashCode();
			}
			num ^= this.splitQuestIds_.GetHashCode();
			num ^= this.splitHp_.GetHashCode();
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.BossColor.Length != 0)
			{
				num ^= this.BossColor.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
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
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.MaxHp != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.MaxHp);
			}
			this.splitQuestIds_.WriteTo(output, MST_EVENT_SUPER_BOSS._repeated_splitQuestIds_codec);
			this.splitHp_.WriteTo(output, MST_EVENT_SUPER_BOSS._repeated_splitHp_codec);
			if (this.IconId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IconId);
			}
			if (this.BossColor.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.BossColor);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.EndedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MaxHp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MaxHp);
			}
			num += this.splitQuestIds_.CalculateSize(MST_EVENT_SUPER_BOSS._repeated_splitQuestIds_codec);
			num += this.splitHp_.CalculateSize(MST_EVENT_SUPER_BOSS._repeated_splitHp_codec);
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.BossColor.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.BossColor);
			}
			if (this.StartedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_SUPER_BOSS other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MaxHp != 0L)
			{
				this.MaxHp = other.MaxHp;
			}
			this.splitQuestIds_.Add(other.splitQuestIds_);
			this.splitHp_.Add(other.splitHp_);
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.BossColor.Length != 0)
			{
				this.BossColor = other.BossColor;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
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
                    case 0x20:
                    case 0x22:
                        {
                            this.splitQuestIds_.AddEntriesFrom(input, _repeated_splitQuestIds_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.splitHp_.AddEntriesFrom(input, _repeated_splitHp_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.EventId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.Id = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.MaxHp = input.ReadInt64();
                            continue;
                        }
                    case 0x30:
                        {
                            this.IconId = input.ReadInt32();
                            continue;
                        }
                    case 0x3a:
                        {
                            this.BossColor = input.ReadBytes();
                            continue;
                        }
                    case 0x40:
                        {
                            this.StartedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x48:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.EndedAt = input.ReadUInt64();
            }
        }


    }
}
