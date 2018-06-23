using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_LOGIN_CAMPAIGN : IMessage, IMessage<MST_EVENT_LOGIN_CAMPAIGN>, IEquatable<MST_EVENT_LOGIN_CAMPAIGN>, IDeepCloneable<MST_EVENT_LOGIN_CAMPAIGN>
	{
		public const int EventIdFieldNumber = 1;

		public const int DayFieldNumber = 2;

		public const int GiftIdFieldNumber = 3;

		public const int PresentMessageIdFieldNumber = 4;

		private static readonly MessageParser<MST_EVENT_LOGIN_CAMPAIGN> _parser = new MessageParser<MST_EVENT_LOGIN_CAMPAIGN>(() => new MST_EVENT_LOGIN_CAMPAIGN());

		private int eventId_;

		private int day_;

		private int giftId_;

		private int presentMessageId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_LOGIN_CAMPAIGN.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_LOGIN_CAMPAIGN> Parser => MST_EVENT_LOGIN_CAMPAIGN._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventLoginCampaignReflection.Descriptor.MessageTypes[0];

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
		public int PresentMessageId
		{
			get => this.presentMessageId_;
			set
			{
				this.presentMessageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_LOGIN_CAMPAIGN()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_LOGIN_CAMPAIGN(MST_EVENT_LOGIN_CAMPAIGN other) : this()
		{
			this.eventId_ = other.eventId_;
			this.day_ = other.day_;
			this.giftId_ = other.giftId_;
			this.presentMessageId_ = other.presentMessageId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_LOGIN_CAMPAIGN Clone()
		{
			return new MST_EVENT_LOGIN_CAMPAIGN(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_LOGIN_CAMPAIGN);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_LOGIN_CAMPAIGN other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.Day == other.Day && this.GiftId == other.GiftId && this.PresentMessageId == other.PresentMessageId));
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
			if (this.PresentMessageId != 0)
			{
				output.WriteRawTag(32);
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
			if (this.PresentMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PresentMessageId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_LOGIN_CAMPAIGN other)
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
							if (num2 != 32u)
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
