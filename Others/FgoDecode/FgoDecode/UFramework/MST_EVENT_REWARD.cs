using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_REWARD : IMessage, IMessage<MST_EVENT_REWARD>, IEquatable<MST_EVENT_REWARD>, IDeepCloneable<MST_EVENT_REWARD>
	{
		public const int EventIdFieldNumber = 1;

		public const int PointFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int GiftIdFieldNumber = 4;

		public const int PresentMessageIdFieldNumber = 5;

		public const int UpdatedAtFieldNumber = 6;

		public const int CreatedAtFieldNumber = 7;

		private static readonly MessageParser<MST_EVENT_REWARD> _parser = new MessageParser<MST_EVENT_REWARD>(() => new MST_EVENT_REWARD());

		private int eventId_;

		private int point_;

		private int type_;

		private int giftId_;

		private int presentMessageId_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_REWARD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_REWARD> Parser => MST_EVENT_REWARD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventRewardReflection.Descriptor.MessageTypes[0];

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
		public int Point
		{
			get => this.point_;
			set
			{
				this.point_ = value;
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
		public int PresentMessageId
		{
			get => this.presentMessageId_;
			set
			{
				this.presentMessageId_ = value;
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
		public MST_EVENT_REWARD()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD(MST_EVENT_REWARD other) : this()
		{
			this.eventId_ = other.eventId_;
			this.point_ = other.point_;
			this.type_ = other.type_;
			this.giftId_ = other.giftId_;
			this.presentMessageId_ = other.presentMessageId_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD Clone()
		{
			return new MST_EVENT_REWARD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_REWARD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_REWARD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.Point == other.Point && this.Type == other.Type && this.GiftId == other.GiftId && this.PresentMessageId == other.PresentMessageId && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
			}
			if (this.PresentMessageId != 0)
			{
				num ^= this.PresentMessageId.GetHashCode();
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
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Point);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.GiftId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GiftId);
			}
			if (this.PresentMessageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PresentMessageId);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreatedAt);
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
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			if (this.PresentMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PresentMessageId);
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
		public void MergeFrom(MST_EVENT_REWARD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
			}
			if (other.PresentMessageId != 0)
			{
				this.PresentMessageId = other.PresentMessageId;
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
									if (num2 != 48u)
									{
										if (num2 != 56u)
										{
											input.SkipLastField();
										}
										else
										{
											this.CreatedAt = input.ReadUInt64();
										}
									}
									else
									{
										this.UpdatedAt = input.ReadUInt64();
									}
								}
								else
								{
									this.PresentMessageId = input.ReadInt32();
								}
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
						this.Point = input.ReadInt32();
					}
				}
				else
				{
					this.EventId = input.ReadInt32();
				}
			}
		}
	}
}
