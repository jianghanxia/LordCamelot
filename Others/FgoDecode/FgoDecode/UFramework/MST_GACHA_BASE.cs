using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_GACHA_BASE : IMessage, IMessage<MST_GACHA_BASE>, IEquatable<MST_GACHA_BASE>, IDeepCloneable<MST_GACHA_BASE>
	{
		public const int IdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int GiftIdFieldNumber = 3;

		private static readonly MessageParser<MST_GACHA_BASE> _parser = new MessageParser<MST_GACHA_BASE>(() => new MST_GACHA_BASE());

		private int id_;

		private int type_;

		private int giftId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_GACHA_BASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_GACHA_BASE> Parser => MST_GACHA_BASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstGachaBaseReflection.Descriptor.MessageTypes[0];

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
		public int GiftId
		{
			get => this.giftId_;
			set
			{
				this.giftId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_GACHA_BASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_GACHA_BASE(MST_GACHA_BASE other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.giftId_ = other.giftId_;
		}

		[DebuggerNonUserCode]
		public MST_GACHA_BASE Clone()
		{
			return new MST_GACHA_BASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_GACHA_BASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_GACHA_BASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Type == other.Type && this.GiftId == other.GiftId));
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
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
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
			if (this.GiftId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GiftId);
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
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_GACHA_BASE other)
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
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
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
					if (num2 != 16u)
					{
						if (num2 != 24u)
						{
							input.SkipLastField();
						}
						else
						{
							this.GiftId = input.ReadInt32();
						}
					}
					else
					{
						this.Type = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}
	}
}
