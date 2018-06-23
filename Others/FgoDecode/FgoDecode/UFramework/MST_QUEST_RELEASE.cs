using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_RELEASE : IMessage, IMessage<MST_QUEST_RELEASE>, IEquatable<MST_QUEST_RELEASE>, IDeepCloneable<MST_QUEST_RELEASE>
	{
		public const int QuestIdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int TargetIdFieldNumber = 3;

		public const int ValueFieldNumber = 4;

		public const int OpenLimitFieldNumber = 5;

		public const int ClosedMessageIdFieldNumber = 6;

		public const int ImagePriorityFieldNumber = 7;

		private static readonly MessageParser<MST_QUEST_RELEASE> _parser = new MessageParser<MST_QUEST_RELEASE>(() => new MST_QUEST_RELEASE());

		private int questId_;

		private int type_;

		private int targetId_;

		private int value_;

		private int openLimit_;

		private int closedMessageId_;

		private int imagePriority_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_RELEASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_RELEASE> Parser => MST_QUEST_RELEASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestReleaseReflection.Descriptor.MessageTypes[0];

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TargetId
		{
			get => this.targetId_;
			set
			{
				this.targetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Value
		{
			get => this.value_;
			set
			{
				this.value_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OpenLimit
		{
			get => this.openLimit_;
			set
			{
				this.openLimit_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ClosedMessageId
		{
			get => this.closedMessageId_;
			set
			{
				this.closedMessageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ImagePriority
		{
			get => this.imagePriority_;
			set
			{
				this.imagePriority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RELEASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RELEASE(MST_QUEST_RELEASE other) : this()
		{
			this.questId_ = other.questId_;
			this.type_ = other.type_;
			this.targetId_ = other.targetId_;
			this.value_ = other.value_;
			this.openLimit_ = other.openLimit_;
			this.closedMessageId_ = other.closedMessageId_;
			this.imagePriority_ = other.imagePriority_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RELEASE Clone()
		{
			return new MST_QUEST_RELEASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_RELEASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_RELEASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.Type == other.Type && this.TargetId == other.TargetId && this.Value == other.Value && this.OpenLimit == other.OpenLimit && this.ClosedMessageId == other.ClosedMessageId && this.ImagePriority == other.ImagePriority));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.OpenLimit != 0)
			{
				num ^= this.OpenLimit.GetHashCode();
			}
			if (this.ClosedMessageId != 0)
			{
				num ^= this.ClosedMessageId.GetHashCode();
			}
			if (this.ImagePriority != 0)
			{
				num ^= this.ImagePriority.GetHashCode();
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
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetId);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Value);
			}
			if (this.OpenLimit != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.OpenLimit);
			}
			if (this.ClosedMessageId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ClosedMessageId);
			}
			if (this.ImagePriority != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ImagePriority);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.OpenLimit != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpenLimit);
			}
			if (this.ClosedMessageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClosedMessageId);
			}
			if (this.ImagePriority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImagePriority);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_RELEASE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.OpenLimit != 0)
			{
				this.OpenLimit = other.OpenLimit;
			}
			if (other.ClosedMessageId != 0)
			{
				this.ClosedMessageId = other.ClosedMessageId;
			}
			if (other.ImagePriority != 0)
			{
				this.ImagePriority = other.ImagePriority;
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
											this.ImagePriority = input.ReadInt32();
										}
									}
									else
									{
										this.ClosedMessageId = input.ReadInt32();
									}
								}
								else
								{
									this.OpenLimit = input.ReadInt32();
								}
							}
							else
							{
								this.Value = input.ReadInt32();
							}
						}
						else
						{
							this.TargetId = input.ReadInt32();
						}
					}
					else
					{
						this.Type = input.ReadInt32();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}
	}
}
