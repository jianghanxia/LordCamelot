using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_REWARD_BG : IMessage, IMessage<MST_EVENT_REWARD_BG>, IEquatable<MST_EVENT_REWARD_BG>, IDeepCloneable<MST_EVENT_REWARD_BG>
	{
		public const int EventIdFieldNumber = 1;

		public const int EventBgDisplayPlaceFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int CondTypeFieldNumber = 4;

		public const int CondValueFieldNumber = 5;

		public const int BgIdFieldNumber = 6;

		private static readonly MessageParser<MST_EVENT_REWARD_BG> _parser = new MessageParser<MST_EVENT_REWARD_BG>(() => new MST_EVENT_REWARD_BG());

		private int eventId_;

		private int eventBgDisplayPlace_;

		private int priority_;

		private int condType_;

		private int condValue_;

		private int bgId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_REWARD_BG.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_REWARD_BG> Parser => MST_EVENT_REWARD_BG._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventRewardBgReflection.Descriptor.MessageTypes[0];

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
		public int EventBgDisplayPlace
		{
			get => this.eventBgDisplayPlace_;
			set
			{
				this.eventBgDisplayPlace_ = value;
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
		public int BgId
		{
			get => this.bgId_;
			set
			{
				this.bgId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD_BG()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD_BG(MST_EVENT_REWARD_BG other) : this()
		{
			this.eventId_ = other.eventId_;
			this.eventBgDisplayPlace_ = other.eventBgDisplayPlace_;
			this.priority_ = other.priority_;
			this.condType_ = other.condType_;
			this.condValue_ = other.condValue_;
			this.bgId_ = other.bgId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_REWARD_BG Clone()
		{
			return new MST_EVENT_REWARD_BG(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_REWARD_BG);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_REWARD_BG other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.EventBgDisplayPlace == other.EventBgDisplayPlace && this.Priority == other.Priority && this.CondType == other.CondType && this.CondValue == other.CondValue && this.BgId == other.BgId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.EventBgDisplayPlace != 0)
			{
				num ^= this.EventBgDisplayPlace.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.CondValue != 0)
			{
				num ^= this.CondValue.GetHashCode();
			}
			if (this.BgId != 0)
			{
				num ^= this.BgId.GetHashCode();
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
			if (this.EventBgDisplayPlace != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventBgDisplayPlace);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Priority);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CondType);
			}
			if (this.CondValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CondValue);
			}
			if (this.BgId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BgId);
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
			if (this.EventBgDisplayPlace != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventBgDisplayPlace);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.CondValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue);
			}
			if (this.BgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_REWARD_BG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.EventBgDisplayPlace != 0)
			{
				this.EventBgDisplayPlace = other.EventBgDisplayPlace;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.CondValue != 0)
			{
				this.CondValue = other.CondValue;
			}
			if (other.BgId != 0)
			{
				this.BgId = other.BgId;
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
										input.SkipLastField();
									}
									else
									{
										this.BgId = input.ReadInt32();
									}
								}
								else
								{
									this.CondValue = input.ReadInt32();
								}
							}
							else
							{
								this.CondType = input.ReadInt32();
							}
						}
						else
						{
							this.Priority = input.ReadInt32();
						}
					}
					else
					{
						this.EventBgDisplayPlace = input.ReadInt32();
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
