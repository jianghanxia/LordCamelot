using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_AI_ACT : IMessage, IMessage<MST_AI_ACT>, IEquatable<MST_AI_ACT>, IDeepCloneable<MST_AI_ACT>
	{
		public const int IdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int TargetFieldNumber = 3;

		public const int TargetIndividualityFieldNumber = 4;

		public const int SkillValsFieldNumber = 5;

		public const int UpdatedAtFieldNumber = 6;

		public const int CreatedAtFieldNumber = 7;

		private static readonly MessageParser<MST_AI_ACT> _parser = new MessageParser<MST_AI_ACT>(() => new MST_AI_ACT());

		private int id_;

		private int type_;

		private int target_;

		private static readonly FieldCodec<int> _repeated_targetIndividuality_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> targetIndividuality_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_skillVals_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> skillVals_ = new RepeatedField<int>();

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_AI_ACT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_AI_ACT> Parser => MST_AI_ACT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstAiActReflection.Descriptor.MessageTypes[0];

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
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
		public RepeatedField<int> TargetIndividuality => this.targetIndividuality_;

		[DebuggerNonUserCode]
		public RepeatedField<int> SkillVals => this.skillVals_;

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
		public MST_AI_ACT()
		{
		}

		[DebuggerNonUserCode]
		public MST_AI_ACT(MST_AI_ACT other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.target_ = other.target_;
			this.targetIndividuality_ = other.targetIndividuality_.Clone();
			this.skillVals_ = other.skillVals_.Clone();
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_AI_ACT Clone()
		{
			return new MST_AI_ACT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_AI_ACT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_AI_ACT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Type == other.Type && this.Target == other.Target && this.targetIndividuality_.Equals(other.targetIndividuality_) && this.skillVals_.Equals(other.skillVals_) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			num ^= this.targetIndividuality_.GetHashCode();
			num ^= this.skillVals_.GetHashCode();
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
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			this.targetIndividuality_.WriteTo(output, MST_AI_ACT._repeated_targetIndividuality_codec);
			this.skillVals_.WriteTo(output, MST_AI_ACT._repeated_skillVals_codec);
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(56);
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
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			num += this.targetIndividuality_.CalculateSize(MST_AI_ACT._repeated_targetIndividuality_codec);
			num += this.skillVals_.CalculateSize(MST_AI_ACT._repeated_skillVals_codec);
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
		public void MergeFrom(MST_AI_ACT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this.targetIndividuality_.Add(other.targetIndividuality_);
			this.skillVals_.Add(other.skillVals_);
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
                    case 0x20:
                    case 0x22:
                        {
                            this.targetIndividuality_.AddEntriesFrom(input, _repeated_targetIndividuality_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.skillVals_.AddEntriesFrom(input, _repeated_skillVals_codec);
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
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Target = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x38:
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
