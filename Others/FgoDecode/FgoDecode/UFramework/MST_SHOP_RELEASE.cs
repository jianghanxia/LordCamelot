using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SHOP_RELEASE : IMessage, IMessage<MST_SHOP_RELEASE>, IEquatable<MST_SHOP_RELEASE>, IDeepCloneable<MST_SHOP_RELEASE>
	{
		public const int ShopIdFieldNumber = 1;

		public const int CondTypeFieldNumber = 2;

		public const int CondValueFieldNumber = 3;

		public const int CondValuesFieldNumber = 4;

		public const int CondNumFieldNumber = 5;

		public const int IsClosedDispFieldNumber = 6;

		public const int ClosedMessageFieldNumber = 7;

		private static readonly MessageParser<MST_SHOP_RELEASE> _parser = new MessageParser<MST_SHOP_RELEASE>(() => new MST_SHOP_RELEASE());

		private int shopId_;

		private int condType_;

		private int condValue_;

		private static readonly FieldCodec<int> _repeated_condValues_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> condValues_ = new RepeatedField<int>();

		private int condNum_;

		private int isClosedDisp_;

		private ByteString closedMessage_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SHOP_RELEASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SHOP_RELEASE> Parser => MST_SHOP_RELEASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstShopReleaseReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int ShopId
		{
			get => this.shopId_;
			set
			{
				this.shopId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondType
		{
			get => this.condType_;
			set
			{
				this.condType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondValue
		{
			get => this.condValue_;
			set
			{
				this.condValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> CondValues => this.condValues_;

		[DebuggerNonUserCode]
		public int CondNum
		{
			get => this.condNum_;
			set
			{
				this.condNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IsClosedDisp
		{
			get => this.isClosedDisp_;
			set
			{
				this.isClosedDisp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString ClosedMessage
		{
			get => this.closedMessage_;
			set
			{
				this.closedMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_SHOP_RELEASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_SHOP_RELEASE(MST_SHOP_RELEASE other) : this()
		{
			this.shopId_ = other.shopId_;
			this.condType_ = other.condType_;
			this.condValue_ = other.condValue_;
			this.condValues_ = other.condValues_.Clone();
			this.condNum_ = other.condNum_;
			this.isClosedDisp_ = other.isClosedDisp_;
			this.closedMessage_ = other.closedMessage_;
		}

		[DebuggerNonUserCode]
		public MST_SHOP_RELEASE Clone()
		{
			return new MST_SHOP_RELEASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SHOP_RELEASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SHOP_RELEASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.ShopId == other.ShopId && this.CondType == other.CondType && this.CondValue == other.CondValue && this.condValues_.Equals(other.condValues_) && this.CondNum == other.CondNum && this.IsClosedDisp == other.IsClosedDisp && !(this.ClosedMessage != other.ClosedMessage)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.CondValue != 0)
			{
				num ^= this.CondValue.GetHashCode();
			}
			num ^= this.condValues_.GetHashCode();
			if (this.CondNum != 0)
			{
				num ^= this.CondNum.GetHashCode();
			}
			if (this.IsClosedDisp != 0)
			{
				num ^= this.IsClosedDisp.GetHashCode();
			}
			if (this.ClosedMessage.Length != 0)
			{
				num ^= this.ClosedMessage.GetHashCode();
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
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CondType);
			}
			if (this.CondValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CondValue);
			}
			this.condValues_.WriteTo(output, MST_SHOP_RELEASE._repeated_condValues_codec);
			if (this.CondNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CondNum);
			}
			if (this.IsClosedDisp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IsClosedDisp);
			}
			if (this.ClosedMessage.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.ClosedMessage);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.CondValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue);
			}
			num += this.condValues_.CalculateSize(MST_SHOP_RELEASE._repeated_condValues_codec);
			if (this.CondNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondNum);
			}
			if (this.IsClosedDisp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsClosedDisp);
			}
			if (this.ClosedMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ClosedMessage);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SHOP_RELEASE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.CondValue != 0)
			{
				this.CondValue = other.CondValue;
			}
			this.condValues_.Add(other.condValues_);
			if (other.CondNum != 0)
			{
				this.CondNum = other.CondNum;
			}
			if (other.IsClosedDisp != 0)
			{
				this.IsClosedDisp = other.IsClosedDisp;
			}
			if (other.ClosedMessage.Length != 0)
			{
				this.ClosedMessage = other.ClosedMessage;
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
                            this.condValues_.AddEntriesFrom(input, _repeated_condValues_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.ShopId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.CondType = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.CondValue = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.CondNum = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.IsClosedDisp = input.ReadInt32();
                            continue;
                        }
                    case 0x3a:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.ClosedMessage = input.ReadBytes();
            }
        }



    }
}
