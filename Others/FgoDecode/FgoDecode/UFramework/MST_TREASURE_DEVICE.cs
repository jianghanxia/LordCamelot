using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_TREASURE_DEVICE : IMessage, IMessage<MST_TREASURE_DEVICE>, IEquatable<MST_TREASURE_DEVICE>, IDeepCloneable<MST_TREASURE_DEVICE>
	{
		public const int IdFieldNumber = 1;

		public const int SeqIdFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int RubyFieldNumber = 4;

		public const int RankFieldNumber = 5;

		public const int MaxLvFieldNumber = 6;

		public const int TypeTextFieldNumber = 7;

		public const int IndividualityFieldNumber = 8;

		public const int AttackAttriFieldNumber = 9;

		public const int UpdatedAtFieldNumber = 10;

		public const int CreatedAtFieldNumber = 11;

		private static readonly MessageParser<MST_TREASURE_DEVICE> _parser = new MessageParser<MST_TREASURE_DEVICE>(() => new MST_TREASURE_DEVICE());

		private int id_;

		private int seqId_;

		private ByteString name_ = ByteString.Empty;

		private ByteString ruby_ = ByteString.Empty;

		private ByteString rank_ = ByteString.Empty;

		private int maxLv_;

		private ByteString typeText_ = ByteString.Empty;

		private static readonly FieldCodec<int> _repeated_individuality_codec = FieldCodec.ForInt32(66u);

		private readonly RepeatedField<int> individuality_ = new RepeatedField<int>();

		private int attackAttri_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_TREASURE_DEVICE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_TREASURE_DEVICE> Parser => MST_TREASURE_DEVICE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstTreasureDeviceReflection.Descriptor.MessageTypes[0];

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
		public int SeqId
		{
			get => this.seqId_;
			set
			{
				this.seqId_ = value;
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
		public ByteString Rank
		{
			get => this.rank_;
			set
			{
				this.rank_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int MaxLv
		{
			get => this.maxLv_;
			set
			{
				this.maxLv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString TypeText
		{
			get => this.typeText_;
			set
			{
				this.typeText_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Individuality => this.individuality_;

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
		public MST_TREASURE_DEVICE()
		{
		}

		[DebuggerNonUserCode]
		public MST_TREASURE_DEVICE(MST_TREASURE_DEVICE other) : this()
		{
			this.id_ = other.id_;
			this.seqId_ = other.seqId_;
			this.name_ = other.name_;
			this.ruby_ = other.ruby_;
			this.rank_ = other.rank_;
			this.maxLv_ = other.maxLv_;
			this.typeText_ = other.typeText_;
			this.individuality_ = other.individuality_.Clone();
			this.attackAttri_ = other.attackAttri_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_TREASURE_DEVICE Clone()
		{
			return new MST_TREASURE_DEVICE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_TREASURE_DEVICE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_TREASURE_DEVICE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.SeqId == other.SeqId && !(this.Name != other.Name) && !(this.Ruby != other.Ruby) && !(this.Rank != other.Rank) && this.MaxLv == other.MaxLv && !(this.TypeText != other.TypeText) && this.individuality_.Equals(other.individuality_) && this.AttackAttri == other.AttackAttri && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SeqId != 0)
			{
				num ^= this.SeqId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Ruby.Length != 0)
			{
				num ^= this.Ruby.GetHashCode();
			}
			if (this.Rank.Length != 0)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.MaxLv != 0)
			{
				num ^= this.MaxLv.GetHashCode();
			}
			if (this.TypeText.Length != 0)
			{
				num ^= this.TypeText.GetHashCode();
			}
			num ^= this.individuality_.GetHashCode();
			if (this.AttackAttri != 0)
			{
				num ^= this.AttackAttri.GetHashCode();
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
			if (this.SeqId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SeqId);
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
			if (this.Rank.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Rank);
			}
			if (this.MaxLv != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxLv);
			}
			if (this.TypeText.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.TypeText);
			}
			this.individuality_.WriteTo(output, MST_TREASURE_DEVICE._repeated_individuality_codec);
			if (this.AttackAttri != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AttackAttri);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(88);
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
			if (this.SeqId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeqId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Ruby.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Ruby);
			}
			if (this.Rank.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Rank);
			}
			if (this.MaxLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLv);
			}
			if (this.TypeText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.TypeText);
			}
			num += this.individuality_.CalculateSize(MST_TREASURE_DEVICE._repeated_individuality_codec);
			if (this.AttackAttri != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttackAttri);
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
		public void MergeFrom(MST_TREASURE_DEVICE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.SeqId != 0)
			{
				this.SeqId = other.SeqId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Ruby.Length != 0)
			{
				this.Ruby = other.Ruby;
			}
			if (other.Rank.Length != 0)
			{
				this.Rank = other.Rank;
			}
			if (other.MaxLv != 0)
			{
				this.MaxLv = other.MaxLv;
			}
			if (other.TypeText.Length != 0)
			{
				this.TypeText = other.TypeText;
			}
			this.individuality_.Add(other.individuality_);
			if (other.AttackAttri != 0)
			{
				this.AttackAttri = other.AttackAttri;
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
                            this.SeqId = input.ReadInt32();
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
                            this.Rank = input.ReadBytes();
                            continue;
                        }
                    case 0x30:
                        {
                            this.MaxLv = input.ReadInt32();
                            continue;
                        }
                    case 0x3a:
                        {
                            this.TypeText = input.ReadBytes();
                            continue;
                        }
                    case 0x48:
                        {
                            this.AttackAttri = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x58:
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
