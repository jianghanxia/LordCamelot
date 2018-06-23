using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_CAMPAIGN : IMessage, IMessage<MST_EVENT_CAMPAIGN>, IEquatable<MST_EVENT_CAMPAIGN>, IDeepCloneable<MST_EVENT_CAMPAIGN>
	{
		public const int EventIdFieldNumber = 1;

		public const int TargetFieldNumber = 2;

		public const int Target2FieldNumber = 3;

		public const int ValueFieldNumber = 4;

		public const int CalcTypeFieldNumber = 5;

		public const int WarIdsFieldNumber = 6;

		public const int UpdatedAtFieldNumber = 7;

		public const int CreatedAtFieldNumber = 8;

		private static readonly MessageParser<MST_EVENT_CAMPAIGN> _parser = new MessageParser<MST_EVENT_CAMPAIGN>(() => new MST_EVENT_CAMPAIGN());

		private int eventId_;

		private int target_;

		private int target2_;

		private int value_;

		private int calcType_;

		private static readonly FieldCodec<int> _repeated_warIds_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> warIds_ = new RepeatedField<int>();

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_CAMPAIGN.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_CAMPAIGN> Parser => MST_EVENT_CAMPAIGN._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventCampaignReflection.Descriptor.MessageTypes[0];

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
		public int Target
		{
			get => this.target_;
			set
			{
				this.target_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Target2
		{
			get => this.target2_;
			set
			{
				this.target2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Value
		{
			get => this.value_;
			set
			{
				this.value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CalcType
		{
			get => this.calcType_;
			set
			{
				this.calcType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> WarIds => this.warIds_;

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
		public MST_EVENT_CAMPAIGN()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_CAMPAIGN(MST_EVENT_CAMPAIGN other) : this()
		{
			this.eventId_ = other.eventId_;
			this.target_ = other.target_;
			this.target2_ = other.target2_;
			this.value_ = other.value_;
			this.calcType_ = other.calcType_;
			this.warIds_ = other.warIds_.Clone();
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_CAMPAIGN Clone()
		{
			return new MST_EVENT_CAMPAIGN(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_CAMPAIGN);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_CAMPAIGN other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.Target == other.Target && this.Target2 == other.Target2 && this.Value == other.Value && this.CalcType == other.CalcType && this.warIds_.Equals(other.warIds_) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Target2 != 0)
			{
				num ^= this.Target2.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.CalcType != 0)
			{
				num ^= this.CalcType.GetHashCode();
			}
			num ^= this.warIds_.GetHashCode();
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
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Target);
			}
			if (this.Target2 != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target2);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Value);
			}
			if (this.CalcType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CalcType);
			}
			this.warIds_.WriteTo(output, MST_EVENT_CAMPAIGN._repeated_warIds_codec);
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.CreatedAt);
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
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Target2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target2);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.CalcType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CalcType);
			}
			num += this.warIds_.CalculateSize(MST_EVENT_CAMPAIGN._repeated_warIds_codec);
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
		public void MergeFrom(MST_EVENT_CAMPAIGN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Target2 != 0)
			{
				this.Target2 = other.Target2;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.CalcType != 0)
			{
				this.CalcType = other.CalcType;
			}
			this.warIds_.Add(other.warIds_);
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
                    case 0x30:
                    case 50:
                        {
                            this.warIds_.AddEntriesFrom(input, _repeated_warIds_codec);
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
                            this.Target = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Target2 = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.Value = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.CalcType = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x40:
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
