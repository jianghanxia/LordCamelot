using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_LOGIN_BONUS : IMessage, IMessage<MST_EVENT_LOGIN_BONUS>, IEquatable<MST_EVENT_LOGIN_BONUS>, IDeepCloneable<MST_EVENT_LOGIN_BONUS>
	{
		public const int EventIdFieldNumber = 1;

		public const int DayFieldNumber = 2;

		public const int GiftIdFieldNumber = 3;

		public const int MessageFieldNumber = 4;

		public const int PresentMessageIdFieldNumber = 5;

		private static readonly MessageParser<MST_EVENT_LOGIN_BONUS> _parser = new MessageParser<MST_EVENT_LOGIN_BONUS>(() => new MST_EVENT_LOGIN_BONUS());

		private int eventId_;

		private int day_;

		private int giftId_;

		private ByteString message_ = ByteString.Empty;

		private int presentMessageId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_LOGIN_BONUS.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_LOGIN_BONUS> Parser => MST_EVENT_LOGIN_BONUS._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventLoginBonusReflection.Descriptor.MessageTypes[0];

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
		public int Day
		{
			get => this.day_;
			set
			{
				this.day_ = value;
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
		public ByteString Message
		{
			get => this.message_;
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_EVENT_LOGIN_BONUS()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_LOGIN_BONUS(MST_EVENT_LOGIN_BONUS other) : this()
		{
			this.eventId_ = other.eventId_;
			this.day_ = other.day_;
			this.giftId_ = other.giftId_;
			this.message_ = other.message_;
			this.presentMessageId_ = other.presentMessageId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_LOGIN_BONUS Clone()
		{
			return new MST_EVENT_LOGIN_BONUS(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_LOGIN_BONUS);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_LOGIN_BONUS other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.Day == other.Day && this.GiftId == other.GiftId && !(this.Message != other.Message) && this.PresentMessageId == other.PresentMessageId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Day != 0)
			{
				num ^= this.Day.GetHashCode();
			}
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
			}
			if (this.Message.Length != 0)
			{
				num ^= this.Message.GetHashCode();
			}
			if (this.PresentMessageId != 0)
			{
				num ^= this.PresentMessageId.GetHashCode();
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
			if (this.Day != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Day);
			}
			if (this.GiftId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GiftId);
			}
			if (this.Message.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.Message);
			}
			if (this.PresentMessageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PresentMessageId);
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
			if (this.Day != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Day);
			}
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			if (this.Message.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
			}
			if (this.PresentMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PresentMessageId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_LOGIN_BONUS other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.Day != 0)
			{
				this.Day = other.Day;
			}
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
			}
			if (other.Message.Length != 0)
			{
				this.Message = other.Message;
			}
			if (other.PresentMessageId != 0)
			{
				this.PresentMessageId = other.PresentMessageId;
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
							if (num2 != 34u)
							{
								if (num2 != 40u)
								{
									input.SkipLastField();
								}
								else
								{
									this.PresentMessageId = input.ReadInt32();
								}
							}
							else
							{
								this.Message = input.ReadBytes();
							}
						}
						else
						{
							this.GiftId = input.ReadInt32();
						}
					}
					else
					{
						this.Day = input.ReadInt32();
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
