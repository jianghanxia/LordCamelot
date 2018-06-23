using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SHOP_DETAIL : IMessage, IMessage<MST_SHOP_DETAIL>, IEquatable<MST_SHOP_DETAIL>, IDeepCloneable<MST_SHOP_DETAIL>
	{
		public const int ShopIdFieldNumber = 1;

		public const int MessageFieldNumber = 2;

		public const int FrequencyTypeFieldNumber = 3;

		private static readonly MessageParser<MST_SHOP_DETAIL> _parser = new MessageParser<MST_SHOP_DETAIL>(() => new MST_SHOP_DETAIL());

		private int shopId_;

		private ByteString message_ = ByteString.Empty;

		private int frequencyType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SHOP_DETAIL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SHOP_DETAIL> Parser => MST_SHOP_DETAIL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstShopDetailReflection.Descriptor.MessageTypes[0];

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
		public ByteString Message
		{
			get => this.message_;
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int FrequencyType
		{
			get => this.frequencyType_;
			set
			{
				this.frequencyType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SHOP_DETAIL()
		{
		}

		[DebuggerNonUserCode]
		public MST_SHOP_DETAIL(MST_SHOP_DETAIL other) : this()
		{
			this.shopId_ = other.shopId_;
			this.message_ = other.message_;
			this.frequencyType_ = other.frequencyType_;
		}

		[DebuggerNonUserCode]
		public MST_SHOP_DETAIL Clone()
		{
			return new MST_SHOP_DETAIL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SHOP_DETAIL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SHOP_DETAIL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.ShopId == other.ShopId && !(this.Message != other.Message) && this.FrequencyType == other.FrequencyType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.Message.Length != 0)
			{
				num ^= this.Message.GetHashCode();
			}
			if (this.FrequencyType != 0)
			{
				num ^= this.FrequencyType.GetHashCode();
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
			if (this.Message.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Message);
			}
			if (this.FrequencyType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FrequencyType);
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
			if (this.Message.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
			}
			if (this.FrequencyType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrequencyType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SHOP_DETAIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.Message.Length != 0)
			{
				this.Message = other.Message;
			}
			if (other.FrequencyType != 0)
			{
				this.FrequencyType = other.FrequencyType;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 8u)
				{
					if (num2 != 18u)
					{
						if (num2 != 24u)
						{
							input.SkipLastField();
						}
						else
						{
							this.FrequencyType = input.ReadInt32();
						}
					}
					else
					{
						this.Message = input.ReadBytes();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}
	}
}
