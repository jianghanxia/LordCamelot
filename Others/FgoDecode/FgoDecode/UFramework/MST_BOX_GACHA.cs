using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BOX_GACHA : IMessage, IMessage<MST_BOX_GACHA>, IEquatable<MST_BOX_GACHA>, IDeepCloneable<MST_BOX_GACHA>
	{
		public const int IdFieldNumber = 1;

		public const int EventIdFieldNumber = 2;

		public const int BaseIdsFieldNumber = 3;

		public const int PickupIdsFieldNumber = 4;

		public const int TalkIdsFieldNumber = 5;

		public const int PayTypeFieldNumber = 6;

		public const int PayTargetIdFieldNumber = 7;

		public const int PayValueFieldNumber = 8;

		public const int DetailUrlFieldNumber = 9;

		public const int GuideImageIdFieldNumber = 10;

		public const int GuideLimitCountFieldNumber = 11;

		public const int PriorityFieldNumber = 12;

		public const int FlagFieldNumber = 13;

		public const int UpdatedAtFieldNumber = 14;

		public const int CreatedAtFieldNumber = 15;

		private static readonly MessageParser<MST_BOX_GACHA> _parser = new MessageParser<MST_BOX_GACHA>(() => new MST_BOX_GACHA());

		private int id_;

		private int eventId_;

		private static readonly FieldCodec<int> _repeated_baseIds_codec = FieldCodec.ForInt32(26u);

		private readonly RepeatedField<int> baseIds_ = new RepeatedField<int>();

		private int pickupIds_;

		private static readonly FieldCodec<int> _repeated_talkIds_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> talkIds_ = new RepeatedField<int>();

		private int payType_;

		private int payTargetId_;

		private int payValue_;

		private ByteString detailUrl_ = ByteString.Empty;

		private int guideImageId_;

		private int guideLimitCount_;

		private int priority_;

		private int flag_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BOX_GACHA.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BOX_GACHA> Parser => MST_BOX_GACHA._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBoxGachaReflection.Descriptor.MessageTypes[0];

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
		public int EventId
		{
			get => this.eventId_;
			set
			{
				this.eventId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> BaseIds => this.baseIds_;

		[DebuggerNonUserCode]
		public int PickupIds
		{
			get => this.pickupIds_;
			set
			{
				this.pickupIds_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> TalkIds => this.talkIds_;

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
		public int PayTargetId
		{
			get => this.payTargetId_;
			set
			{
				this.payTargetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int PayValue
		{
			get => this.payValue_;
			set
			{
				this.payValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString DetailUrl
		{
			get => this.detailUrl_;
			set
			{
				this.detailUrl_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int GuideImageId
		{
			get => this.guideImageId_;
			set
			{
				this.guideImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GuideLimitCount
		{
			get => this.guideLimitCount_;
			set
			{
				this.guideLimitCount_ = value;
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
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
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
		public MST_BOX_GACHA()
		{
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA(MST_BOX_GACHA other) : this()
		{
			this.id_ = other.id_;
			this.eventId_ = other.eventId_;
			this.baseIds_ = other.baseIds_.Clone();
			this.pickupIds_ = other.pickupIds_;
			this.talkIds_ = other.talkIds_.Clone();
			this.payType_ = other.payType_;
			this.payTargetId_ = other.payTargetId_;
			this.payValue_ = other.payValue_;
			this.detailUrl_ = other.detailUrl_;
			this.guideImageId_ = other.guideImageId_;
			this.guideLimitCount_ = other.guideLimitCount_;
			this.priority_ = other.priority_;
			this.flag_ = other.flag_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA Clone()
		{
			return new MST_BOX_GACHA(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BOX_GACHA);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BOX_GACHA other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.EventId == other.EventId && this.baseIds_.Equals(other.baseIds_) && this.PickupIds == other.PickupIds && this.talkIds_.Equals(other.talkIds_) && this.PayType == other.PayType && this.PayTargetId == other.PayTargetId && this.PayValue == other.PayValue && !(this.DetailUrl != other.DetailUrl) && this.GuideImageId == other.GuideImageId && this.GuideLimitCount == other.GuideLimitCount && this.Priority == other.Priority && this.Flag == other.Flag && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			num ^= this.baseIds_.GetHashCode();
			if (this.PickupIds != 0)
			{
				num ^= this.PickupIds.GetHashCode();
			}
			num ^= this.talkIds_.GetHashCode();
			if (this.PayType != 0)
			{
				num ^= this.PayType.GetHashCode();
			}
			if (this.PayTargetId != 0)
			{
				num ^= this.PayTargetId.GetHashCode();
			}
			if (this.PayValue != 0)
			{
				num ^= this.PayValue.GetHashCode();
			}
			if (this.DetailUrl.Length != 0)
			{
				num ^= this.DetailUrl.GetHashCode();
			}
			if (this.GuideImageId != 0)
			{
				num ^= this.GuideImageId.GetHashCode();
			}
			if (this.GuideLimitCount != 0)
			{
				num ^= this.GuideLimitCount.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
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
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			this.baseIds_.WriteTo(output, MST_BOX_GACHA._repeated_baseIds_codec);
			if (this.PickupIds != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PickupIds);
			}
			this.talkIds_.WriteTo(output, MST_BOX_GACHA._repeated_talkIds_codec);
			if (this.PayType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PayType);
			}
			if (this.PayTargetId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PayTargetId);
			}
			if (this.PayValue != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PayValue);
			}
			if (this.DetailUrl.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.DetailUrl);
			}
			if (this.GuideImageId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.GuideImageId);
			}
			if (this.GuideLimitCount != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.GuideLimitCount);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Priority);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Flag);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(120);
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
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			num += this.baseIds_.CalculateSize(MST_BOX_GACHA._repeated_baseIds_codec);
			if (this.PickupIds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PickupIds);
			}
			num += this.talkIds_.CalculateSize(MST_BOX_GACHA._repeated_talkIds_codec);
			if (this.PayType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayType);
			}
			if (this.PayTargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayTargetId);
			}
			if (this.PayValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayValue);
			}
			if (this.DetailUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.DetailUrl);
			}
			if (this.GuideImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideImageId);
			}
			if (this.GuideLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideLimitCount);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
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
		public void MergeFrom(MST_BOX_GACHA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			this.baseIds_.Add(other.baseIds_);
			if (other.PickupIds != 0)
			{
				this.PickupIds = other.PickupIds;
			}
			this.talkIds_.Add(other.talkIds_);
			if (other.PayType != 0)
			{
				this.PayType = other.PayType;
			}
			if (other.PayTargetId != 0)
			{
				this.PayTargetId = other.PayTargetId;
			}
			if (other.PayValue != 0)
			{
				this.PayValue = other.PayValue;
			}
			if (other.DetailUrl.Length != 0)
			{
				this.DetailUrl = other.DetailUrl;
			}
			if (other.GuideImageId != 0)
			{
				this.GuideImageId = other.GuideImageId;
			}
			if (other.GuideLimitCount != 0)
			{
				this.GuideLimitCount = other.GuideLimitCount;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
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
                    case 0x18:
                    case 0x1a:
                        {
                            this.baseIds_.AddEntriesFrom(input, _repeated_baseIds_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.talkIds_.AddEntriesFrom(input, _repeated_talkIds_codec);
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
                            this.EventId = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.PickupIds = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.PayType = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.PayTargetId = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.PayValue = input.ReadInt32();
                            continue;
                        }
                    case 0x4a:
                        {
                            this.DetailUrl = input.ReadBytes();
                            continue;
                        }
                    case 80:
                        {
                            this.GuideImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.GuideLimitCount = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x68:
                        {
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 0x70:
                        {
                            this.UpdatedAt = input.ReadUInt64();
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
                this.CreatedAt = input.ReadUInt64();
            }
        }


    }
}
