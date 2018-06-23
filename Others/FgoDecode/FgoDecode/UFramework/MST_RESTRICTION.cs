using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_RESTRICTION : IMessage, IMessage<MST_RESTRICTION>, IEquatable<MST_RESTRICTION>, IDeepCloneable<MST_RESTRICTION>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int TargetValsFieldNumber = 4;

		public const int RangeTypeFieldNumber = 5;

		private static readonly MessageParser<MST_RESTRICTION> _parser = new MessageParser<MST_RESTRICTION>(() => new MST_RESTRICTION());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private int type_;

		private static readonly FieldCodec<int> _repeated_targetVals_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> targetVals_ = new RepeatedField<int>();

		private int rangeType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_RESTRICTION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_RESTRICTION> Parser => MST_RESTRICTION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstRestrictionReflection.Descriptor.MessageTypes[0];

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
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public RepeatedField<int> TargetVals => this.targetVals_;

		[DebuggerNonUserCode]
		public int RangeType
		{
			get => this.rangeType_;
			set
			{
				this.rangeType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_RESTRICTION()
		{
		}

		[DebuggerNonUserCode]
		public MST_RESTRICTION(MST_RESTRICTION other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.type_ = other.type_;
			this.targetVals_ = other.targetVals_.Clone();
			this.rangeType_ = other.rangeType_;
		}

		[DebuggerNonUserCode]
		public MST_RESTRICTION Clone()
		{
			return new MST_RESTRICTION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_RESTRICTION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_RESTRICTION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && this.Type == other.Type && this.targetVals_.Equals(other.targetVals_) && this.RangeType == other.RangeType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.targetVals_.GetHashCode();
			if (this.RangeType != 0)
			{
				num ^= this.RangeType.GetHashCode();
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Name);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			this.targetVals_.WriteTo(output, MST_RESTRICTION._repeated_targetVals_codec);
			if (this.RangeType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RangeType);
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
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			num += this.targetVals_.CalculateSize(MST_RESTRICTION._repeated_targetVals_codec);
			if (this.RangeType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RangeType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_RESTRICTION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this.targetVals_.Add(other.targetVals_);
			if (other.RangeType != 0)
			{
				this.RangeType = other.RangeType;
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
                            this.targetVals_.AddEntriesFrom(input, _repeated_targetVals_codec);
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
                    case 0x12:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.RangeType = input.ReadInt32();
            }
        }


    }
}
