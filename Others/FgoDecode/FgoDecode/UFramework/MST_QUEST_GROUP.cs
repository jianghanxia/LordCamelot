using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_GROUP : IMessage, IMessage<MST_QUEST_GROUP>, IEquatable<MST_QUEST_GROUP>, IDeepCloneable<MST_QUEST_GROUP>
	{
		public const int QuestIdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int GroupIdFieldNumber = 3;

		private static readonly MessageParser<MST_QUEST_GROUP> _parser = new MessageParser<MST_QUEST_GROUP>(() => new MST_QUEST_GROUP());

		private int questId_;

		private int type_;

		private int groupId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_GROUP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_GROUP> Parser => MST_QUEST_GROUP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestGroupReflection.Descriptor.MessageTypes[0];

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
		public int GroupId
		{
			get => this.groupId_;
			set
			{
				this.groupId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_QUEST_GROUP()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_GROUP(MST_QUEST_GROUP other) : this()
		{
			this.questId_ = other.questId_;
			this.type_ = other.type_;
			this.groupId_ = other.groupId_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_GROUP Clone()
		{
			return new MST_QUEST_GROUP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_GROUP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_GROUP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.Type == other.Type && this.GroupId == other.GroupId));
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
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
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
			if (this.GroupId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GroupId);
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
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_GROUP other)
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
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
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
							input.SkipLastField();
						}
						else
						{
							this.GroupId = input.ReadInt32();
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
