using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SHOP : IMessage, IMessage<MST_SHOP>, IEquatable<MST_SHOP>, IDeepCloneable<MST_SHOP>
	{
		public const int IdFieldNumber = 1;

		public const int BaseShopIdFieldNumber = 2;

		public const int EventIdFieldNumber = 3;

		public const int FlagFieldNumber = 4;

		public const int PriorityFieldNumber = 5;

		public const int PurchaseTypeFieldNumber = 6;

		public const int TargetIdsFieldNumber = 7;

		public const int SetNumFieldNumber = 8;

		public const int PayTypeFieldNumber = 9;

		public const int ItemIdsFieldNumber = 10;

		public const int PricesFieldNumber = 11;

		public const int LimitNumFieldNumber = 12;

		public const int NameFieldNumber = 13;

		public const int DetailFieldNumber = 14;

		public const int WarningMessageFieldNumber = 15;

		public const int ImageIdFieldNumber = 16;

		public const int BgImageIdFieldNumber = 17;

		public const int OpenedAtFieldNumber = 18;

		public const int ClosedAtFieldNumber = 19;

		private static readonly MessageParser<MST_SHOP> _parser = new MessageParser<MST_SHOP>(() => new MST_SHOP());

		private int id_;

		private int baseShopId_;

		private int eventId_;

		private int flag_;

		private int priority_;

		private int purchaseType_;

		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(58u);

		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();

		private int setNum_;

		private int payType_;

		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(82u);

		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_prices_codec = FieldCodec.ForInt32(90u);

		private readonly RepeatedField<int> prices_ = new RepeatedField<int>();

		private int limitNum_;

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		private ByteString warningMessage_ = ByteString.Empty;

		private int imageId_;

		private int bgImageId_;

		private ulong openedAt_;

		private ulong closedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SHOP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SHOP> Parser => MST_SHOP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstShopReflection.Descriptor.MessageTypes[0];

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
		public int BaseShopId
		{
			get => this.baseShopId_;
			set
			{
				this.baseShopId_ = value;
			}
		}

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
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
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
		public int PurchaseType
		{
			get => this.purchaseType_;
			set
			{
				this.purchaseType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> TargetIds => this.targetIds_;

		[DebuggerNonUserCode]
		public int SetNum
		{
			get => this.setNum_;
			set
			{
				this.setNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int PayType
		{
			get => this.payType_;
			set
			{
				this.payType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ItemIds => this.itemIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> Prices => this.prices_;

		[DebuggerNonUserCode]
		public int LimitNum
		{
			get => this.limitNum_;
			set
			{
				this.limitNum_ = value;
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
		public ByteString WarningMessage
		{
			get => this.warningMessage_;
			set
			{
				this.warningMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public ulong OpenedAt
		{
			get => this.openedAt_;
			set
			{
				this.openedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong ClosedAt
		{
			get => this.closedAt_;
			set
			{
				this.closedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SHOP()
		{
		}

		[DebuggerNonUserCode]
		public MST_SHOP(MST_SHOP other) : this()
		{
			this.id_ = other.id_;
			this.baseShopId_ = other.baseShopId_;
			this.eventId_ = other.eventId_;
			this.flag_ = other.flag_;
			this.priority_ = other.priority_;
			this.purchaseType_ = other.purchaseType_;
			this.targetIds_ = other.targetIds_.Clone();
			this.setNum_ = other.setNum_;
			this.payType_ = other.payType_;
			this.itemIds_ = other.itemIds_.Clone();
			this.prices_ = other.prices_.Clone();
			this.limitNum_ = other.limitNum_;
			this.name_ = other.name_;
			this.detail_ = other.detail_;
			this.warningMessage_ = other.warningMessage_;
			this.imageId_ = other.imageId_;
			this.bgImageId_ = other.bgImageId_;
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
		}

		[DebuggerNonUserCode]
		public MST_SHOP Clone()
		{
			return new MST_SHOP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SHOP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SHOP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.BaseShopId == other.BaseShopId && this.EventId == other.EventId && this.Flag == other.Flag && this.Priority == other.Priority && this.PurchaseType == other.PurchaseType && this.targetIds_.Equals(other.targetIds_) && this.SetNum == other.SetNum && this.PayType == other.PayType && this.itemIds_.Equals(other.itemIds_) && this.prices_.Equals(other.prices_) && this.LimitNum == other.LimitNum && !(this.Name != other.Name) && !(this.Detail != other.Detail) && !(this.WarningMessage != other.WarningMessage) && this.ImageId == other.ImageId && this.BgImageId == other.BgImageId && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BaseShopId != 0)
			{
				num ^= this.BaseShopId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.PurchaseType != 0)
			{
				num ^= this.PurchaseType.GetHashCode();
			}
			num ^= this.targetIds_.GetHashCode();
			if (this.SetNum != 0)
			{
				num ^= this.SetNum.GetHashCode();
			}
			if (this.PayType != 0)
			{
				num ^= this.PayType.GetHashCode();
			}
			num ^= this.itemIds_.GetHashCode();
			num ^= this.prices_.GetHashCode();
			if (this.LimitNum != 0)
			{
				num ^= this.LimitNum.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.WarningMessage.Length != 0)
			{
				num ^= this.WarningMessage.GetHashCode();
			}
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.BgImageId != 0)
			{
				num ^= this.BgImageId.GetHashCode();
			}
			if (this.OpenedAt != 0uL)
			{
				num ^= this.OpenedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
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
			if (this.BaseShopId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BaseShopId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EventId);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Flag);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Priority);
			}
			if (this.PurchaseType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PurchaseType);
			}
			this.targetIds_.WriteTo(output, MST_SHOP._repeated_targetIds_codec);
			if (this.SetNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SetNum);
			}
			if (this.PayType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PayType);
			}
			this.itemIds_.WriteTo(output, MST_SHOP._repeated_itemIds_codec);
			this.prices_.WriteTo(output, MST_SHOP._repeated_prices_codec);
			if (this.LimitNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LimitNum);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteBytes(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteBytes(this.Detail);
			}
			if (this.WarningMessage.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.WarningMessage);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.ImageId);
			}
			if (this.BgImageId != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.BgImageId);
			}
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt64(this.ClosedAt);
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
			if (this.BaseShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseShopId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.PurchaseType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PurchaseType);
			}
			num += this.targetIds_.CalculateSize(MST_SHOP._repeated_targetIds_codec);
			if (this.SetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SetNum);
			}
			if (this.PayType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayType);
			}
			num += this.itemIds_.CalculateSize(MST_SHOP._repeated_itemIds_codec);
			num += this.prices_.CalculateSize(MST_SHOP._repeated_prices_codec);
			if (this.LimitNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitNum);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.WarningMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.WarningMessage);
			}
			if (this.ImageId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.BgImageId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.BgImageId);
			}
			if (this.OpenedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SHOP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BaseShopId != 0)
			{
				this.BaseShopId = other.BaseShopId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.PurchaseType != 0)
			{
				this.PurchaseType = other.PurchaseType;
			}
			this.targetIds_.Add(other.targetIds_);
			if (other.SetNum != 0)
			{
				this.SetNum = other.SetNum;
			}
			if (other.PayType != 0)
			{
				this.PayType = other.PayType;
			}
			this.itemIds_.Add(other.itemIds_);
			this.prices_.Add(other.prices_);
			if (other.LimitNum != 0)
			{
				this.LimitNum = other.LimitNum;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.WarningMessage.Length != 0)
			{
				this.WarningMessage = other.WarningMessage;
			}
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.BgImageId != 0)
			{
				this.BgImageId = other.BgImageId;
			}
			if (other.OpenedAt != 0uL)
			{
				this.OpenedAt = other.OpenedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
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
                    case 0x38:
                    case 0x3a:
                        {
                            this.targetIds_.AddEntriesFrom(input, _repeated_targetIds_codec);
                            continue;
                        }
                    case 80:
                    case 0x52:
                        {
                            this.itemIds_.AddEntriesFrom(input, _repeated_itemIds_codec);
                            continue;
                        }
                    case 0x58:
                    case 90:
                        {
                            this.prices_.AddEntriesFrom(input, _repeated_prices_codec);
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
                            this.BaseShopId = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.EventId = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.PurchaseType = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.SetNum = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.PayType = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.LimitNum = input.ReadInt32();
                            continue;
                        }
                    case 0x6a:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x72:
                        {
                            this.Detail = input.ReadBytes();
                            continue;
                        }
                    case 0x7a:
                        {
                            this.WarningMessage = input.ReadBytes();
                            continue;
                        }
                    case 0x80:
                        {
                            this.ImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x88:
                        {
                            this.BgImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x90:
                        {
                            this.OpenedAt = input.ReadUInt64();
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
                this.ClosedAt = input.ReadUInt64();
            }
        }


    }
}
