using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_COMBINE_LIMIT : IMessage, IMessage<MST_COMBINE_LIMIT>, IEquatable<MST_COMBINE_LIMIT>, IDeepCloneable<MST_COMBINE_LIMIT>
	{
		public const int IdFieldNumber = 1;

		public const int SvtLimitFieldNumber = 2;

		public const int QpFieldNumber = 3;

		public const int ItemNumsFieldNumber = 4;

		public const int ItemIdsFieldNumber = 5;

		public const int UpdatedAtFieldNumber = 6;

		public const int CreatedAtFieldNumber = 7;

		private static readonly MessageParser<MST_COMBINE_LIMIT> _parser = new MessageParser<MST_COMBINE_LIMIT>(() => new MST_COMBINE_LIMIT());

		private int id_;

		private int svtLimit_;

		private int qp_;

		private static readonly FieldCodec<int> _repeated_itemNums_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> itemNums_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_COMBINE_LIMIT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_COMBINE_LIMIT> Parser => MST_COMBINE_LIMIT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCombineLimitReflection.Descriptor.MessageTypes[0];

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
		public int SvtLimit
		{
			get => this.svtLimit_;
			set
			{
				this.svtLimit_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Qp
		{
			get => this.qp_;
			set
			{
				this.qp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ItemNums => this.itemNums_;

		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIds => this.itemIds_;

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
		public MST_COMBINE_LIMIT()
		{
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_LIMIT(MST_COMBINE_LIMIT other) : this()
		{
			this.id_ = other.id_;
			this.svtLimit_ = other.svtLimit_;
			this.qp_ = other.qp_;
			this.itemNums_ = other.itemNums_.Clone();
			this.itemIds_ = other.itemIds_.Clone();
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_LIMIT Clone()
		{
			return new MST_COMBINE_LIMIT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_COMBINE_LIMIT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_COMBINE_LIMIT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.SvtLimit == other.SvtLimit && this.Qp == other.Qp && this.itemNums_.Equals(other.itemNums_) && this.itemIds_.Equals(other.itemIds_) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SvtLimit != 0)
			{
				num ^= this.SvtLimit.GetHashCode();
			}
			if (this.Qp != 0)
			{
				num ^= this.Qp.GetHashCode();
			}
			num ^= this.itemNums_.GetHashCode();
			num ^= this.itemIds_.GetHashCode();
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
			if (this.SvtLimit != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SvtLimit);
			}
			if (this.Qp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Qp);
			}
			this.itemNums_.WriteTo(output, MST_COMBINE_LIMIT._repeated_itemNums_codec);
			this.itemIds_.WriteTo(output, MST_COMBINE_LIMIT._repeated_itemIds_codec);
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
			if (this.SvtLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtLimit);
			}
			if (this.Qp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Qp);
			}
			num += this.itemNums_.CalculateSize(MST_COMBINE_LIMIT._repeated_itemNums_codec);
			num += this.itemIds_.CalculateSize(MST_COMBINE_LIMIT._repeated_itemIds_codec);
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
		public void MergeFrom(MST_COMBINE_LIMIT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.SvtLimit != 0)
			{
				this.SvtLimit = other.SvtLimit;
			}
			if (other.Qp != 0)
			{
				this.Qp = other.Qp;
			}
			this.itemNums_.Add(other.itemNums_);
			this.itemIds_.Add(other.itemIds_);
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
                            this.itemNums_.AddEntriesFrom(input, _repeated_itemNums_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.itemIds_.AddEntriesFrom(input, _repeated_itemIds_codec);
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
                            this.SvtLimit = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Qp = input.ReadInt32();
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
