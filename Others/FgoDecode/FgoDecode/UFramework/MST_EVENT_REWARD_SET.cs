using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_REWARD_SET : IMessage, IMessage<MST_EVENT_REWARD_SET>, IEquatable<MST_EVENT_REWARD_SET>, IDeepCloneable<MST_EVENT_REWARD_SET>
	{
		public const int RewardSetTypeFieldNumber = 1;

		public const int EventIdFieldNumber = 2;

		public const int IdFieldNumber = 3;

		public const int IconIdFieldNumber = 4;

		public const int NameFieldNumber = 5;

		public const int DetailFieldNumber = 6;

		private static readonly MessageParser<MST_EVENT_REWARD_SET> _parser = new MessageParser<MST_EVENT_REWARD_SET>(() => new MST_EVENT_REWARD_SET());

		private int rewardSetType_;

		private int eventId_;

		private int id_;

		private int iconId_;

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_REWARD_SET.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_REWARD_SET> Parser => MST_EVENT_REWARD_SET._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventRewardSetReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int RewardSetType
		{
			get => this.rewardSetType_;
			set
			{
				this.rewardSetType_ = value;
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
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IconId
		{
			get => this.iconId_;
			set
			{
				this.iconId_ = value;
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
		public MST_EVENT_REWARD_SET()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD_SET(MST_EVENT_REWARD_SET other) : this()
		{
			this.rewardSetType_ = other.rewardSetType_;
			this.eventId_ = other.eventId_;
			this.id_ = other.id_;
			this.iconId_ = other.iconId_;
			this.name_ = other.name_;
			this.detail_ = other.detail_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD_SET Clone()
		{
			return new MST_EVENT_REWARD_SET(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_REWARD_SET);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_REWARD_SET other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.RewardSetType == other.RewardSetType && this.EventId == other.EventId && this.Id == other.Id && this.IconId == other.IconId && !(this.Name != other.Name) && !(this.Detail != other.Detail)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardSetType != 0)
			{
				num ^= this.RewardSetType.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
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
			if (this.RewardSetType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RewardSetType);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IconId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.Detail);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardSetType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardSetType);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_REWARD_SET other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardSetType != 0)
			{
				this.RewardSetType = other.RewardSetType;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
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
								if (num2 != 42u)
								{
									if (num2 != 50u)
									{
										input.SkipLastField();
									}
									else
									{
										this.Detail = input.ReadBytes();
									}
								}
								else
								{
									this.Name = input.ReadBytes();
								}
							}
							else
							{
								this.IconId = input.ReadInt32();
							}
						}
						else
						{
							this.Id = input.ReadInt32();
						}
					}
					else
					{
						this.EventId = input.ReadInt32();
					}
				}
				else
				{
					this.RewardSetType = input.ReadInt32();
				}
			}
		}
	}
}
