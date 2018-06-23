using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_RESTRICTION : IMessage, IMessage<MST_QUEST_RESTRICTION>, IEquatable<MST_QUEST_RESTRICTION>, IDeepCloneable<MST_QUEST_RESTRICTION>
	{
		public const int QuestIdFieldNumber = 1;

		public const int RestrictionIdFieldNumber = 2;

		private static readonly MessageParser<MST_QUEST_RESTRICTION> _parser = new MessageParser<MST_QUEST_RESTRICTION>(() => new MST_QUEST_RESTRICTION());

		private int questId_;

		private int restrictionId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_RESTRICTION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_RESTRICTION> Parser => MST_QUEST_RESTRICTION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestRestrictionReflection.Descriptor.MessageTypes[0];

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
		public int RestrictionId
		{
			get => this.restrictionId_;
			set
			{
				this.restrictionId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RESTRICTION()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RESTRICTION(MST_QUEST_RESTRICTION other) : this()
		{
			this.questId_ = other.questId_;
			this.restrictionId_ = other.restrictionId_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RESTRICTION Clone()
		{
			return new MST_QUEST_RESTRICTION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_RESTRICTION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_RESTRICTION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.RestrictionId == other.RestrictionId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.RestrictionId != 0)
			{
				num ^= this.RestrictionId.GetHashCode();
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
			if (this.RestrictionId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RestrictionId);
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
			if (this.RestrictionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RestrictionId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_RESTRICTION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.RestrictionId != 0)
			{
				this.RestrictionId = other.RestrictionId;
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
						input.SkipLastField();
					}
					else
					{
						this.RestrictionId = input.ReadInt32();
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
