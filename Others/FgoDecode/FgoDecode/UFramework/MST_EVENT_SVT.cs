using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_SVT : IMessage, IMessage<MST_EVENT_SVT>, IEquatable<MST_EVENT_SVT>, IDeepCloneable<MST_EVENT_SVT>
	{
		public const int EventIdFieldNumber = 1;

		public const int SvtIdFieldNumber = 2;

		public const int JoinMessageFieldNumber = 3;

		public const int GetMessageFieldNumber = 4;

		public const int LeaveMessageFieldNumber = 5;

		public const int StartedAtFieldNumber = 6;

		public const int EndedAtFieldNumber = 7;

		private static readonly MessageParser<MST_EVENT_SVT> _parser = new MessageParser<MST_EVENT_SVT>(() => new MST_EVENT_SVT());

		private int eventId_;

		private int svtId_;

		private ByteString joinMessage_ = ByteString.Empty;

		private ByteString getMessage_ = ByteString.Empty;

		private ByteString leaveMessage_ = ByteString.Empty;

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_SVT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_SVT> Parser => MST_EVENT_SVT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventSvtReflection.Descriptor.MessageTypes[0];

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
		public int SvtId
		{
			get => this.svtId_;
			set
			{
				this.svtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString JoinMessage
		{
			get => this.joinMessage_;
			set
			{
				this.joinMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString GetMessage
		{
			get => this.getMessage_;
			set
			{
				this.getMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString LeaveMessage
		{
			get => this.leaveMessage_;
			set
			{
				this.leaveMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ulong StartedAt
		{
			get => this.startedAt_;
			set
			{
				this.startedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong EndedAt
		{
			get => this.endedAt_;
			set
			{
				this.endedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_SVT()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_SVT(MST_EVENT_SVT other) : this()
		{
			this.eventId_ = other.eventId_;
			this.svtId_ = other.svtId_;
			this.joinMessage_ = other.joinMessage_;
			this.getMessage_ = other.getMessage_;
			this.leaveMessage_ = other.leaveMessage_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_SVT Clone()
		{
			return new MST_EVENT_SVT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_SVT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_SVT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.SvtId == other.SvtId && !(this.JoinMessage != other.JoinMessage) && !(this.GetMessage != other.GetMessage) && !(this.LeaveMessage != other.LeaveMessage) && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.JoinMessage.Length != 0)
			{
				num ^= this.JoinMessage.GetHashCode();
			}
			if (this.GetMessage.Length != 0)
			{
				num ^= this.GetMessage.GetHashCode();
			}
			if (this.LeaveMessage.Length != 0)
			{
				num ^= this.LeaveMessage.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SvtId);
			}
			if (this.JoinMessage.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.JoinMessage);
			}
			if (this.GetMessage.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.GetMessage);
			}
			if (this.LeaveMessage.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.LeaveMessage);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.EndedAt);
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
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.JoinMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.JoinMessage);
			}
			if (this.GetMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.GetMessage);
			}
			if (this.LeaveMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LeaveMessage);
			}
			if (this.StartedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_SVT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.JoinMessage.Length != 0)
			{
				this.JoinMessage = other.JoinMessage;
			}
			if (other.GetMessage.Length != 0)
			{
				this.GetMessage = other.GetMessage;
			}
			if (other.LeaveMessage.Length != 0)
			{
				this.LeaveMessage = other.LeaveMessage;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
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
						if (num2 != 26u)
						{
							if (num2 != 34u)
							{
								if (num2 != 42u)
								{
									if (num2 != 48u)
									{
										if (num2 != 56u)
										{
											input.SkipLastField();
										}
										else
										{
											this.EndedAt = input.ReadUInt64();
										}
									}
									else
									{
										this.StartedAt = input.ReadUInt64();
									}
								}
								else
								{
									this.LeaveMessage = input.ReadBytes();
								}
							}
							else
							{
								this.GetMessage = input.ReadBytes();
							}
						}
						else
						{
							this.JoinMessage = input.ReadBytes();
						}
					}
					else
					{
						this.SvtId = input.ReadInt32();
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
