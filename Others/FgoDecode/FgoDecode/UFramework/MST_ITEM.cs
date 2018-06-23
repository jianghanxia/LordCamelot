using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_ITEM : IMessage, IMessage<MST_ITEM>, IEquatable<MST_ITEM>, IDeepCloneable<MST_ITEM>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int DetailFieldNumber = 3;

		public const int ImageIdFieldNumber = 4;

		public const int BgImageIdFieldNumber = 5;

		public const int TypeFieldNumber = 6;

		public const int UnitFieldNumber = 7;

		public const int ValueFieldNumber = 8;

		public const int SellQpFieldNumber = 9;

		public const int IsSellFieldNumber = 10;

		public const int PriorityFieldNumber = 11;

		public const int DropPriorityFieldNumber = 12;

		public const int IndividualityFieldNumber = 13;

		public const int StartedAtFieldNumber = 14;

		public const int EndedAtFieldNumber = 15;

		private static readonly MessageParser<MST_ITEM> _parser = new MessageParser<MST_ITEM>(() => new MST_ITEM());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		private int imageId_;

		private int bgImageId_;

		private int type_;

		private ByteString unit_ = ByteString.Empty;

		private int value_;

		private int sellQp_;

		private int isSell_;

		private int priority_;

		private int dropPriority_;

		private static readonly FieldCodec<int> _repeated_individuality_codec = FieldCodec.ForInt32(106u);

		private readonly RepeatedField<int> individuality_ = new RepeatedField<int>();

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_ITEM.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_ITEM> Parser => MST_ITEM._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstItemReflection.Descriptor.MessageTypes[0];

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
		public ByteString Detail
		{
			get => this.detail_;
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int ImageId
		{
			get => this.imageId_;
			set
			{
				this.imageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BgImageId
		{
			get => this.bgImageId_;
			set
			{
				this.bgImageId_ = value;
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
		public ByteString Unit
		{
			get => this.unit_;
			set
			{
				this.unit_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int SellQp
		{
			get => this.sellQp_;
			set
			{
				this.sellQp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IsSell
		{
			get => this.isSell_;
			set
			{
				this.isSell_ = value;
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
		public int DropPriority
		{
			get => this.dropPriority_;
			set
			{
				this.dropPriority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Individuality => this.individuality_;

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
		public MST_ITEM()
		{
		}

		[DebuggerNonUserCode]
		public MST_ITEM(MST_ITEM other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.detail_ = other.detail_;
			this.imageId_ = other.imageId_;
			this.bgImageId_ = other.bgImageId_;
			this.type_ = other.type_;
			this.unit_ = other.unit_;
			this.value_ = other.value_;
			this.sellQp_ = other.sellQp_;
			this.isSell_ = other.isSell_;
			this.priority_ = other.priority_;
			this.dropPriority_ = other.dropPriority_;
			this.individuality_ = other.individuality_.Clone();
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_ITEM Clone()
		{
			return new MST_ITEM(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_ITEM);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_ITEM other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && !(this.Detail != other.Detail) && this.ImageId == other.ImageId && this.BgImageId == other.BgImageId && this.Type == other.Type && !(this.Unit != other.Unit) && this.Value == other.Value && this.SellQp == other.SellQp && this.IsSell == other.IsSell && this.Priority == other.Priority && this.DropPriority == other.DropPriority && this.individuality_.Equals(other.individuality_) && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
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
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.BgImageId != 0)
			{
				num ^= this.BgImageId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Unit.Length != 0)
			{
				num ^= this.Unit.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.SellQp != 0)
			{
				num ^= this.SellQp.GetHashCode();
			}
			if (this.IsSell != 0)
			{
				num ^= this.IsSell.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.DropPriority != 0)
			{
				num ^= this.DropPriority.GetHashCode();
			}
			num ^= this.individuality_.GetHashCode();
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
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Detail);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ImageId);
			}
			if (this.BgImageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BgImageId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Type);
			}
			if (this.Unit.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.Unit);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Value);
			}
			if (this.SellQp != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SellQp);
			}
			if (this.IsSell != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IsSell);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Priority);
			}
			if (this.DropPriority != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DropPriority);
			}
			this.individuality_.WriteTo(output, MST_ITEM._repeated_individuality_codec);
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(120);
				output.WriteUInt64(this.EndedAt);
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
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.BgImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgImageId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Unit.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Unit);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.SellQp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SellQp);
			}
			if (this.IsSell != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsSell);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.DropPriority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DropPriority);
			}
			num += this.individuality_.CalculateSize(MST_ITEM._repeated_individuality_codec);
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
		public void MergeFrom(MST_ITEM other)
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
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.BgImageId != 0)
			{
				this.BgImageId = other.BgImageId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Unit.Length != 0)
			{
				this.Unit = other.Unit;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.SellQp != 0)
			{
				this.SellQp = other.SellQp;
			}
			if (other.IsSell != 0)
			{
				this.IsSell = other.IsSell;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.DropPriority != 0)
			{
				this.DropPriority = other.DropPriority;
			}
			this.individuality_.Add(other.individuality_);
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
                    case 0x68:
                    case 0x6a:
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
                    case 0x12:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x1a:
                        {
                            this.Detail = input.ReadBytes();
                            continue;
                        }
                    case 0x20:
                        {
                            this.ImageId = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.BgImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 0x3a:
                        {
                            this.Unit = input.ReadBytes();
                            continue;
                        }
                    case 0x40:
                        {
                            this.Value = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.SellQp = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.IsSell = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.DropPriority = input.ReadInt32();
                            continue;
                        }
                    case 0x70:
                        {
                            this.StartedAt = input.ReadUInt64();
                            continue;
                        }
                    case 120:
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
