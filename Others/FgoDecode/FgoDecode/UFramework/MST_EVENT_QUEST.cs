using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_QUEST : IMessage, IMessage<MST_EVENT_QUEST>, IEquatable<MST_EVENT_QUEST>, IDeepCloneable<MST_EVENT_QUEST>
	{
		public const int EventIdFieldNumber = 1;

		public const int QuestIdFieldNumber = 2;

		public const int PhaseFieldNumber = 3;

		public const int UpdatedAtFieldNumber = 4;

		public const int CreatedAtFieldNumber = 5;

		private static readonly MessageParser<MST_EVENT_QUEST> _parser = new MessageParser<MST_EVENT_QUEST>(() => new MST_EVENT_QUEST());

		private int eventId_;

		private int questId_;

		private int phase_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_QUEST.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_QUEST> Parser => MST_EVENT_QUEST._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventQuestReflection.Descriptor.MessageTypes[0];

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
		public int QuestId
		{
			get => this.questId_;
			set
			{
				this.questId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Phase
		{
			get => this.phase_;
			set
			{
				this.phase_ = value;
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
		public MST_EVENT_QUEST()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_QUEST(MST_EVENT_QUEST other) : this()
		{
			this.eventId_ = other.eventId_;
			this.questId_ = other.questId_;
			this.phase_ = other.phase_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_QUEST Clone()
		{
			return new MST_EVENT_QUEST(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_QUEST);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_QUEST other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.QuestId == other.QuestId && this.Phase == other.Phase && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Phase != 0)
			{
				num ^= this.Phase.GetHashCode();
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
			if (this.QuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.QuestId);
			}
			if (this.Phase != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Phase);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(40);
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
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Phase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Phase);
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
		public void MergeFrom(MST_EVENT_QUEST other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Phase != 0)
			{
				this.Phase = other.Phase;
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
							this.Phase = input.ReadInt32();
						}
					}
					else
					{
						this.QuestId = input.ReadInt32();
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
