using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_DETAIL : IMessage, IMessage<MST_EVENT_DETAIL>, IEquatable<MST_EVENT_DETAIL>, IDeepCloneable<MST_EVENT_DETAIL>
	{
		public const int EventIdFieldNumber = 1;

		public const int FlagFieldNumber = 2;

		public const int RewardPageBgIdFieldNumber = 3;

		public const int BgmIdFieldNumber = 4;

		public const int AfterBgmIdFieldNumber = 5;

		public const int PointImageIdFieldNumber = 6;

		public const int GuideImageIdFieldNumber = 7;

		public const int GuideImageIdsFieldNumber = 8;

		public const int GuideLimitCountFieldNumber = 9;

		public const int GuideLimitCountsFieldNumber = 10;

		public const int CondQuestIdFieldNumber = 11;

		public const int CondMessageFieldNumber = 12;

		public const int TutorialImageIdsFieldNumber = 13;

		public const int ShopCondQuestIdFieldNumber = 14;

		public const int ShopCondMessageFieldNumber = 15;

		public const int ShopGuideImageIdsFieldNumber = 16;

		public const int ShopGuideLimitCountsFieldNumber = 17;

		public const int ShopPageBgIdFieldNumber = 18;

		public const int ShopBgmIdFieldNumber = 19;

		public const int ShopAfterBgmIdFieldNumber = 20;

		private static readonly MessageParser<MST_EVENT_DETAIL> _parser = new MessageParser<MST_EVENT_DETAIL>(() => new MST_EVENT_DETAIL());

		private int eventId_;

		private int flag_;

		private int rewardPageBgId_;

		private int bgmId_;

		private int afterBgmId_;

		private int pointImageId_;

		private int guideImageId_;

		private static readonly FieldCodec<int> _repeated_guideImageIds_codec = FieldCodec.ForInt32(66u);

		private readonly RepeatedField<int> guideImageIds_ = new RepeatedField<int>();

		private int guideLimitCount_;

		private static readonly FieldCodec<int> _repeated_guideLimitCounts_codec = FieldCodec.ForInt32(82u);

		private readonly RepeatedField<int> guideLimitCounts_ = new RepeatedField<int>();

		private int condQuestId_;

		private ByteString condMessage_ = ByteString.Empty;

		private static readonly FieldCodec<ByteString> _repeated_tutorialImageIds_codec = FieldCodec.ForBytes(106u);

		private readonly RepeatedField<ByteString> tutorialImageIds_ = new RepeatedField<ByteString>();

		private int shopCondQuestId_;

		private ByteString shopCondMessage_ = ByteString.Empty;

		private static readonly FieldCodec<int> _repeated_shopGuideImageIds_codec = FieldCodec.ForInt32(130u);

		private readonly RepeatedField<int> shopGuideImageIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_shopGuideLimitCounts_codec = FieldCodec.ForInt32(138u);

		private readonly RepeatedField<int> shopGuideLimitCounts_ = new RepeatedField<int>();

		private int shopPageBgId_;

		private int shopBgmId_;

		private int shopAfterBgmId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_DETAIL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_DETAIL> Parser => MST_EVENT_DETAIL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventDetailReflection.Descriptor.MessageTypes[0];

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
		public int RewardPageBgId
		{
			get => this.rewardPageBgId_;
			set
			{
				this.rewardPageBgId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BgmId
		{
			get => this.bgmId_;
			set
			{
				this.bgmId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AfterBgmId
		{
			get => this.afterBgmId_;
			set
			{
				this.afterBgmId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int PointImageId
		{
			get => this.pointImageId_;
			set
			{
				this.pointImageId_ = value;
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
		public RepeatedField<int> GuideImageIds => this.guideImageIds_;

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
		public RepeatedField<int> GuideLimitCounts => this.guideLimitCounts_;

		[DebuggerNonUserCode]
		public int CondQuestId
		{
			get => this.condQuestId_;
			set
			{
				this.condQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString CondMessage
		{
			get => this.condMessage_;
			set
			{
				this.condMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> TutorialImageIds => this.tutorialImageIds_;

		[DebuggerNonUserCode]
		public int ShopCondQuestId
		{
			get => this.shopCondQuestId_;
			set
			{
				this.shopCondQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString ShopCondMessage
		{
			get => this.shopCondMessage_;
			set
			{
				this.shopCondMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ShopGuideImageIds => this.shopGuideImageIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> ShopGuideLimitCounts => this.shopGuideLimitCounts_;

		[DebuggerNonUserCode]
		public int ShopPageBgId
		{
			get => this.shopPageBgId_;
			set
			{
				this.shopPageBgId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ShopBgmId
		{
			get => this.shopBgmId_;
			set
			{
				this.shopBgmId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ShopAfterBgmId
		{
			get => this.shopAfterBgmId_;
			set
			{
				this.shopAfterBgmId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_DETAIL()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_DETAIL(MST_EVENT_DETAIL other) : this()
		{
			this.eventId_ = other.eventId_;
			this.flag_ = other.flag_;
			this.rewardPageBgId_ = other.rewardPageBgId_;
			this.bgmId_ = other.bgmId_;
			this.afterBgmId_ = other.afterBgmId_;
			this.pointImageId_ = other.pointImageId_;
			this.guideImageId_ = other.guideImageId_;
			this.guideImageIds_ = other.guideImageIds_.Clone();
			this.guideLimitCount_ = other.guideLimitCount_;
			this.guideLimitCounts_ = other.guideLimitCounts_.Clone();
			this.condQuestId_ = other.condQuestId_;
			this.condMessage_ = other.condMessage_;
			this.tutorialImageIds_ = other.tutorialImageIds_.Clone();
			this.shopCondQuestId_ = other.shopCondQuestId_;
			this.shopCondMessage_ = other.shopCondMessage_;
			this.shopGuideImageIds_ = other.shopGuideImageIds_.Clone();
			this.shopGuideLimitCounts_ = other.shopGuideLimitCounts_.Clone();
			this.shopPageBgId_ = other.shopPageBgId_;
			this.shopBgmId_ = other.shopBgmId_;
			this.shopAfterBgmId_ = other.shopAfterBgmId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_DETAIL Clone()
		{
			return new MST_EVENT_DETAIL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_DETAIL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_DETAIL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.Flag == other.Flag && this.RewardPageBgId == other.RewardPageBgId && this.BgmId == other.BgmId && this.AfterBgmId == other.AfterBgmId && this.PointImageId == other.PointImageId && this.GuideImageId == other.GuideImageId && this.guideImageIds_.Equals(other.guideImageIds_) && this.GuideLimitCount == other.GuideLimitCount && this.guideLimitCounts_.Equals(other.guideLimitCounts_) && this.CondQuestId == other.CondQuestId && !(this.CondMessage != other.CondMessage) && this.tutorialImageIds_.Equals(other.tutorialImageIds_) && this.ShopCondQuestId == other.ShopCondQuestId && !(this.ShopCondMessage != other.ShopCondMessage) && this.shopGuideImageIds_.Equals(other.shopGuideImageIds_) && this.shopGuideLimitCounts_.Equals(other.shopGuideLimitCounts_) && this.ShopPageBgId == other.ShopPageBgId && this.ShopBgmId == other.ShopBgmId && this.ShopAfterBgmId == other.ShopAfterBgmId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.RewardPageBgId != 0)
			{
				num ^= this.RewardPageBgId.GetHashCode();
			}
			if (this.BgmId != 0)
			{
				num ^= this.BgmId.GetHashCode();
			}
			if (this.AfterBgmId != 0)
			{
				num ^= this.AfterBgmId.GetHashCode();
			}
			if (this.PointImageId != 0)
			{
				num ^= this.PointImageId.GetHashCode();
			}
			if (this.GuideImageId != 0)
			{
				num ^= this.GuideImageId.GetHashCode();
			}
			num ^= this.guideImageIds_.GetHashCode();
			if (this.GuideLimitCount != 0)
			{
				num ^= this.GuideLimitCount.GetHashCode();
			}
			num ^= this.guideLimitCounts_.GetHashCode();
			if (this.CondQuestId != 0)
			{
				num ^= this.CondQuestId.GetHashCode();
			}
			if (this.CondMessage.Length != 0)
			{
				num ^= this.CondMessage.GetHashCode();
			}
			num ^= this.tutorialImageIds_.GetHashCode();
			if (this.ShopCondQuestId != 0)
			{
				num ^= this.ShopCondQuestId.GetHashCode();
			}
			if (this.ShopCondMessage.Length != 0)
			{
				num ^= this.ShopCondMessage.GetHashCode();
			}
			num ^= this.shopGuideImageIds_.GetHashCode();
			num ^= this.shopGuideLimitCounts_.GetHashCode();
			if (this.ShopPageBgId != 0)
			{
				num ^= this.ShopPageBgId.GetHashCode();
			}
			if (this.ShopBgmId != 0)
			{
				num ^= this.ShopBgmId.GetHashCode();
			}
			if (this.ShopAfterBgmId != 0)
			{
				num ^= this.ShopAfterBgmId.GetHashCode();
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
			if (this.Flag != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Flag);
			}
			if (this.RewardPageBgId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardPageBgId);
			}
			if (this.BgmId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BgmId);
			}
			if (this.AfterBgmId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AfterBgmId);
			}
			if (this.PointImageId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PointImageId);
			}
			if (this.GuideImageId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GuideImageId);
			}
			this.guideImageIds_.WriteTo(output, MST_EVENT_DETAIL._repeated_guideImageIds_codec);
			if (this.GuideLimitCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GuideLimitCount);
			}
			this.guideLimitCounts_.WriteTo(output, MST_EVENT_DETAIL._repeated_guideLimitCounts_codec);
			if (this.CondQuestId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CondQuestId);
			}
			if (this.CondMessage.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.CondMessage);
			}
			this.tutorialImageIds_.WriteTo(output, MST_EVENT_DETAIL._repeated_tutorialImageIds_codec);
			if (this.ShopCondQuestId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ShopCondQuestId);
			}
			if (this.ShopCondMessage.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteBytes(this.ShopCondMessage);
			}
			this.shopGuideImageIds_.WriteTo(output, MST_EVENT_DETAIL._repeated_shopGuideImageIds_codec);
			this.shopGuideLimitCounts_.WriteTo(output, MST_EVENT_DETAIL._repeated_shopGuideLimitCounts_codec);
			if (this.ShopPageBgId != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.ShopPageBgId);
			}
			if (this.ShopBgmId != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.ShopBgmId);
			}
			if (this.ShopAfterBgmId != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.ShopAfterBgmId);
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
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.RewardPageBgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardPageBgId);
			}
			if (this.BgmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgmId);
			}
			if (this.AfterBgmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterBgmId);
			}
			if (this.PointImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PointImageId);
			}
			if (this.GuideImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideImageId);
			}
			num += this.guideImageIds_.CalculateSize(MST_EVENT_DETAIL._repeated_guideImageIds_codec);
			if (this.GuideLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideLimitCount);
			}
			num += this.guideLimitCounts_.CalculateSize(MST_EVENT_DETAIL._repeated_guideLimitCounts_codec);
			if (this.CondQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestId);
			}
			if (this.CondMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.CondMessage);
			}
			num += this.tutorialImageIds_.CalculateSize(MST_EVENT_DETAIL._repeated_tutorialImageIds_codec);
			if (this.ShopCondQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopCondQuestId);
			}
			if (this.ShopCondMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ShopCondMessage);
			}
			num += this.shopGuideImageIds_.CalculateSize(MST_EVENT_DETAIL._repeated_shopGuideImageIds_codec);
			num += this.shopGuideLimitCounts_.CalculateSize(MST_EVENT_DETAIL._repeated_shopGuideLimitCounts_codec);
			if (this.ShopPageBgId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShopPageBgId);
			}
			if (this.ShopBgmId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShopBgmId);
			}
			if (this.ShopAfterBgmId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShopAfterBgmId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_DETAIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.RewardPageBgId != 0)
			{
				this.RewardPageBgId = other.RewardPageBgId;
			}
			if (other.BgmId != 0)
			{
				this.BgmId = other.BgmId;
			}
			if (other.AfterBgmId != 0)
			{
				this.AfterBgmId = other.AfterBgmId;
			}
			if (other.PointImageId != 0)
			{
				this.PointImageId = other.PointImageId;
			}
			if (other.GuideImageId != 0)
			{
				this.GuideImageId = other.GuideImageId;
			}
			this.guideImageIds_.Add(other.guideImageIds_);
			if (other.GuideLimitCount != 0)
			{
				this.GuideLimitCount = other.GuideLimitCount;
			}
			this.guideLimitCounts_.Add(other.guideLimitCounts_);
			if (other.CondQuestId != 0)
			{
				this.CondQuestId = other.CondQuestId;
			}
			if (other.CondMessage.Length != 0)
			{
				this.CondMessage = other.CondMessage;
			}
			this.tutorialImageIds_.Add(other.tutorialImageIds_);
			if (other.ShopCondQuestId != 0)
			{
				this.ShopCondQuestId = other.ShopCondQuestId;
			}
			if (other.ShopCondMessage.Length != 0)
			{
				this.ShopCondMessage = other.ShopCondMessage;
			}
			this.shopGuideImageIds_.Add(other.shopGuideImageIds_);
			this.shopGuideLimitCounts_.Add(other.shopGuideLimitCounts_);
			if (other.ShopPageBgId != 0)
			{
				this.ShopPageBgId = other.ShopPageBgId;
			}
			if (other.ShopBgmId != 0)
			{
				this.ShopBgmId = other.ShopBgmId;
			}
			if (other.ShopAfterBgmId != 0)
			{
				this.ShopAfterBgmId = other.ShopAfterBgmId;
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
                            this.guideImageIds_.AddEntriesFrom(input, _repeated_guideImageIds_codec);
                            continue;
                        }
                    case 80:
                    case 0x52:
                        {
                            this.guideLimitCounts_.AddEntriesFrom(input, _repeated_guideLimitCounts_codec);
                            continue;
                        }
                    case 0x80:
                    case 130:
                        {
                            this.shopGuideImageIds_.AddEntriesFrom(input, _repeated_shopGuideImageIds_codec);
                            continue;
                        }
                    case 0x88:
                    case 0x8a:
                        {
                            this.shopGuideLimitCounts_.AddEntriesFrom(input, _repeated_shopGuideLimitCounts_codec);
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
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.RewardPageBgId = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.BgmId = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.AfterBgmId = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.PointImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.GuideImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.GuideLimitCount = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.CondQuestId = input.ReadInt32();
                            continue;
                        }
                    case 0x62:
                        {
                            this.CondMessage = input.ReadBytes();
                            continue;
                        }
                    case 0x6a:
                        {
                            this.tutorialImageIds_.AddEntriesFrom(input, _repeated_tutorialImageIds_codec);
                            continue;
                        }
                    case 0x70:
                        {
                            this.ShopCondQuestId = input.ReadInt32();
                            continue;
                        }
                    case 0x7a:
                        {
                            this.ShopCondMessage = input.ReadBytes();
                            continue;
                        }
                    case 0x90:
                        {
                            this.ShopPageBgId = input.ReadInt32();
                            continue;
                        }
                    case 0x98:
                        {
                            this.ShopBgmId = input.ReadInt32();
                            continue;
                        }
                    case 160:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.ShopAfterBgmId = input.ReadInt32();
            }
        }


    }
}
