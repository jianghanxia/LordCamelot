using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_STONE_SHOP : IMessage, IMessage<MST_STONE_SHOP>, IEquatable<MST_STONE_SHOP>, IDeepCloneable<MST_STONE_SHOP>
	{
		public const int IdFieldNumber = 1;

		public const int EffectFieldNumber = 2;

		public const int PriceFieldNumber = 3;

		public const int OpenedAtFieldNumber = 4;

		public const int ClosedAtFieldNumber = 5;

		private static readonly MessageParser<MST_STONE_SHOP> _parser = new MessageParser<MST_STONE_SHOP>(() => new MST_STONE_SHOP());

		private int id_;

		private int effect_;

		private int price_;

		private ulong openedAt_;

		private ulong closedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_STONE_SHOP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_STONE_SHOP> Parser => MST_STONE_SHOP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstStoneShopReflection.Descriptor.MessageTypes[0];

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
		public int Effect
		{
			get => this.effect_;
			set
			{
				this.effect_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Price
		{
			get => this.price_;
			set
			{
				this.price_ = value;
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
		public MST_STONE_SHOP()
		{
		}

		[DebuggerNonUserCode]
		public MST_STONE_SHOP(MST_STONE_SHOP other) : this()
		{
			this.id_ = other.id_;
			this.effect_ = other.effect_;
			this.price_ = other.price_;
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
		}

		[DebuggerNonUserCode]
		public MST_STONE_SHOP Clone()
		{
			return new MST_STONE_SHOP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_STONE_SHOP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_STONE_SHOP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Effect == other.Effect && this.Price == other.Price && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Effect != 0)
			{
				num ^= this.Effect.GetHashCode();
			}
			if (this.Price != 0)
			{
				num ^= this.Price.GetHashCode();
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
			if (this.Effect != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Effect);
			}
			if (this.Price != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Price);
			}
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(40);
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
			if (this.Effect != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Effect);
			}
			if (this.Price != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Price);
			}
			if (this.OpenedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_STONE_SHOP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Effect != 0)
			{
				this.Effect = other.Effect;
			}
			if (other.Price != 0)
			{
				this.Price = other.Price;
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
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 8u)
				{
					if (num2 != 16u)
					{
						if (num2 != 24u)
						{
							if (num2 != 32u)
							{
								if (num2 != 40u)
								{
									input.SkipLastField();
								}
								else
								{
									this.ClosedAt = input.ReadUInt64();
								}
							}
							else
							{
								this.OpenedAt = input.ReadUInt64();
							}
						}
						else
						{
							this.Price = input.ReadInt32();
						}
					}
					else
					{
						this.Effect = input.ReadInt32();
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
