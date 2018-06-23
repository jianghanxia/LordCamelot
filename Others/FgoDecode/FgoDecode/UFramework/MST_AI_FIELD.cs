using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_AI_FIELD : IMessage, IMessage<MST_AI_FIELD>, IEquatable<MST_AI_FIELD>, IDeepCloneable<MST_AI_FIELD>
	{
		public const int IdFieldNumber = 1;

		public const int IdxFieldNumber = 2;

		public const int ActNumFieldNumber = 3;

		public const int TimingFieldNumber = 4;

		public const int PriorityFieldNumber = 5;

		public const int ProbabilityFieldNumber = 6;

		public const int CondFieldNumber = 7;

		public const int ValsFieldNumber = 8;

		public const int AiActIdFieldNumber = 9;

		public const int AvalsFieldNumber = 10;

		public const int InfoTextFieldNumber = 11;

		public const int UpdatedAtFieldNumber = 12;

		public const int CreatedAtFieldNumber = 13;

		private static readonly MessageParser<MST_AI_FIELD> _parser = new MessageParser<MST_AI_FIELD>(() => new MST_AI_FIELD());

		private int id_;

		private int idx_;

		private int actNum_;

		private int timing_;

		private int priority_;

		private int probability_;

		private int cond_;

		private static readonly FieldCodec<long> _repeated_vals_codec = FieldCodec.ForInt64(66u);

		private readonly RepeatedField<long> vals_ = new RepeatedField<long>();

		private int aiActId_;

		private static readonly FieldCodec<int> _repeated_avals_codec = FieldCodec.ForInt32(82u);

		private readonly RepeatedField<int> avals_ = new RepeatedField<int>();

		private ByteString infoText_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_AI_FIELD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_AI_FIELD> Parser => MST_AI_FIELD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstAiFieldReflection.Descriptor.MessageTypes[0];

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
		public int Idx
		{
			get => this.idx_;
			set
			{
				this.idx_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActNum
		{
			get => this.actNum_;
			set
			{
				this.actNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Timing
		{
			get => this.timing_;
			set
			{
				this.timing_ = value;
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
		public int Probability
		{
			get => this.probability_;
			set
			{
				this.probability_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Cond
		{
			get => this.cond_;
			set
			{
				this.cond_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> Vals => this.vals_;

		[DebuggerNonUserCode]
		public int AiActId
		{
			get => this.aiActId_;
			set
			{
				this.aiActId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Avals => this.avals_;

		[DebuggerNonUserCode]
		public ByteString InfoText
		{
			get => this.infoText_;
			set
			{
				this.infoText_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_AI_FIELD()
		{
		}

		[DebuggerNonUserCode]
		public MST_AI_FIELD(MST_AI_FIELD other) : this()
		{
			this.id_ = other.id_;
			this.idx_ = other.idx_;
			this.actNum_ = other.actNum_;
			this.timing_ = other.timing_;
			this.priority_ = other.priority_;
			this.probability_ = other.probability_;
			this.cond_ = other.cond_;
			this.vals_ = other.vals_.Clone();
			this.aiActId_ = other.aiActId_;
			this.avals_ = other.avals_.Clone();
			this.infoText_ = other.infoText_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_AI_FIELD Clone()
		{
			return new MST_AI_FIELD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_AI_FIELD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_AI_FIELD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Idx == other.Idx && this.ActNum == other.ActNum && this.Timing == other.Timing && this.Priority == other.Priority && this.Probability == other.Probability && this.Cond == other.Cond && this.vals_.Equals(other.vals_) && this.AiActId == other.AiActId && this.avals_.Equals(other.avals_) && !(this.InfoText != other.InfoText) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Idx != 0)
			{
				num ^= this.Idx.GetHashCode();
			}
			if (this.ActNum != 0)
			{
				num ^= this.ActNum.GetHashCode();
			}
			if (this.Timing != 0)
			{
				num ^= this.Timing.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.Probability != 0)
			{
				num ^= this.Probability.GetHashCode();
			}
			if (this.Cond != 0)
			{
				num ^= this.Cond.GetHashCode();
			}
			num ^= this.vals_.GetHashCode();
			if (this.AiActId != 0)
			{
				num ^= this.AiActId.GetHashCode();
			}
			num ^= this.avals_.GetHashCode();
			if (this.InfoText.Length != 0)
			{
				num ^= this.InfoText.GetHashCode();
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
			if (this.Idx != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Idx);
			}
			if (this.ActNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActNum);
			}
			if (this.Timing != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Timing);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Priority);
			}
			if (this.Probability != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Probability);
			}
			if (this.Cond != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Cond);
			}
			this.vals_.WriteTo(output, MST_AI_FIELD._repeated_vals_codec);
			if (this.AiActId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AiActId);
			}
			this.avals_.WriteTo(output, MST_AI_FIELD._repeated_avals_codec);
			if (this.InfoText.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.InfoText);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(104);
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
			if (this.Idx != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Idx);
			}
			if (this.ActNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActNum);
			}
			if (this.Timing != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Timing);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.Probability != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Probability);
			}
			if (this.Cond != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cond);
			}
			num += this.vals_.CalculateSize(MST_AI_FIELD._repeated_vals_codec);
			if (this.AiActId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AiActId);
			}
			num += this.avals_.CalculateSize(MST_AI_FIELD._repeated_avals_codec);
			if (this.InfoText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.InfoText);
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
		public void MergeFrom(MST_AI_FIELD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Idx != 0)
			{
				this.Idx = other.Idx;
			}
			if (other.ActNum != 0)
			{
				this.ActNum = other.ActNum;
			}
			if (other.Timing != 0)
			{
				this.Timing = other.Timing;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.Probability != 0)
			{
				this.Probability = other.Probability;
			}
			if (other.Cond != 0)
			{
				this.Cond = other.Cond;
			}
			this.vals_.Add(other.vals_);
			if (other.AiActId != 0)
			{
				this.AiActId = other.AiActId;
			}
			this.avals_.Add(other.avals_);
			if (other.InfoText.Length != 0)
			{
				this.InfoText = other.InfoText;
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
                            this.vals_.AddEntriesFrom(input, _repeated_vals_codec);
                            continue;
                        }
                    case 80:
                    case 0x52:
                        {
                            this.avals_.AddEntriesFrom(input, _repeated_avals_codec);
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
                            this.Idx = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.ActNum = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.Timing = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.Probability = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.Cond = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.AiActId = input.ReadInt32();
                            continue;
                        }
                    case 90:
                        {
                            this.InfoText = input.ReadBytes();
                            continue;
                        }
                    case 0x60:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x68:
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
