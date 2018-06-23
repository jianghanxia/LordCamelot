using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_FILTER : IMessage, IMessage<MST_EVENT_FILTER>, IEquatable<MST_EVENT_FILTER>, IDeepCloneable<MST_EVENT_FILTER>
	{
		public const int EventIdFieldNumber = 1;

		public const int OpenQuestIdFieldNumber = 2;

		public const int CloseQuestIdFieldNumber = 3;

		public const int ButtonTextFieldNumber = 4;

		private static readonly MessageParser<MST_EVENT_FILTER> _parser = new MessageParser<MST_EVENT_FILTER>(() => new MST_EVENT_FILTER());

		private int eventId_;

		private int openQuestId_;

		private int closeQuestId_;

		private ByteString buttonText_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_FILTER.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_FILTER> Parser => MST_EVENT_FILTER._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventFilterReflection.Descriptor.MessageTypes[0];

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
		public int OpenQuestId
		{
			get => this.openQuestId_;
			set
			{
				this.openQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CloseQuestId
		{
			get => this.closeQuestId_;
			set
			{
				this.closeQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString ButtonText
		{
			get => this.buttonText_;
			set
			{
				this.buttonText_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_FILTER()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_FILTER(MST_EVENT_FILTER other) : this()
		{
			this.eventId_ = other.eventId_;
			this.openQuestId_ = other.openQuestId_;
			this.closeQuestId_ = other.closeQuestId_;
			this.buttonText_ = other.buttonText_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_FILTER Clone()
		{
			return new MST_EVENT_FILTER(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_FILTER);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_FILTER other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.OpenQuestId == other.OpenQuestId && this.CloseQuestId == other.CloseQuestId && !(this.ButtonText != other.ButtonText)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.OpenQuestId != 0)
			{
				num ^= this.OpenQuestId.GetHashCode();
			}
			if (this.CloseQuestId != 0)
			{
				num ^= this.CloseQuestId.GetHashCode();
			}
			if (this.ButtonText.Length != 0)
			{
				num ^= this.ButtonText.GetHashCode();
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
			if (this.OpenQuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OpenQuestId);
			}
			if (this.CloseQuestId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CloseQuestId);
			}
			if (this.ButtonText.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.ButtonText);
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
			if (this.OpenQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpenQuestId);
			}
			if (this.CloseQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CloseQuestId);
			}
			if (this.ButtonText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ButtonText);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_FILTER other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.OpenQuestId != 0)
			{
				this.OpenQuestId = other.OpenQuestId;
			}
			if (other.CloseQuestId != 0)
			{
				this.CloseQuestId = other.CloseQuestId;
			}
			if (other.ButtonText.Length != 0)
			{
				this.ButtonText = other.ButtonText;
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
								input.SkipLastField();
							}
							else
							{
								this.ButtonText = input.ReadBytes();
							}
						}
						else
						{
							this.CloseQuestId = input.ReadInt32();
						}
					}
					else
					{
						this.OpenQuestId = input.ReadInt32();
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
