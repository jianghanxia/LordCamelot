using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_MESSAGE : IMessage, IMessage<MST_QUEST_MESSAGE>, IEquatable<MST_QUEST_MESSAGE>, IDeepCloneable<MST_QUEST_MESSAGE>
	{
		public const int QuestIdFieldNumber = 1;

		public const int PhaseFieldNumber = 2;

		public const int MessageFieldNumber = 3;

		public const int CondTypeFieldNumber = 4;

		public const int TargetIdFieldNumber = 5;

		public const int TargetNumFieldNumber = 6;

		public const int FrequencyTypeFieldNumber = 7;

		private static readonly MessageParser<MST_QUEST_MESSAGE> _parser = new MessageParser<MST_QUEST_MESSAGE>(() => new MST_QUEST_MESSAGE());

		private int questId_;

		private int phase_;

		private ByteString message_ = ByteString.Empty;

		private int condType_;

		private int targetId_;

		private int targetNum_;

		private int frequencyType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_MESSAGE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_MESSAGE> Parser => MST_QUEST_MESSAGE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestMessageReflection.Descriptor.MessageTypes[0];

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
		public ByteString Message
		{
			get => this.message_;
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int TargetId
		{
			get => this.targetId_;
			set
			{
				this.targetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TargetNum
		{
			get => this.targetNum_;
			set
			{
				this.targetNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FrequencyType
		{
			get => this.frequencyType_;
			set
			{
				this.frequencyType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_QUEST_MESSAGE()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_MESSAGE(MST_QUEST_MESSAGE other) : this()
		{
			this.questId_ = other.questId_;
			this.phase_ = other.phase_;
			this.message_ = other.message_;
			this.condType_ = other.condType_;
			this.targetId_ = other.targetId_;
			this.targetNum_ = other.targetNum_;
			this.frequencyType_ = other.frequencyType_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_MESSAGE Clone()
		{
			return new MST_QUEST_MESSAGE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_MESSAGE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_MESSAGE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.Phase == other.Phase && !(this.Message != other.Message) && this.CondType == other.CondType && this.TargetId == other.TargetId && this.TargetNum == other.TargetNum && this.FrequencyType == other.FrequencyType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Phase != 0)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this.Message.Length != 0)
			{
				num ^= this.Message.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.TargetNum != 0)
			{
				num ^= this.TargetNum.GetHashCode();
			}
			if (this.FrequencyType != 0)
			{
				num ^= this.FrequencyType.GetHashCode();
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
			if (this.Phase != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Phase);
			}
			if (this.Message.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Message);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CondType);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TargetId);
			}
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TargetNum);
			}
			if (this.FrequencyType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.FrequencyType);
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
			if (this.Phase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Phase);
			}
			if (this.Message.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.TargetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetNum);
			}
			if (this.FrequencyType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrequencyType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_MESSAGE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Phase != 0)
			{
				this.Phase = other.Phase;
			}
			if (other.Message.Length != 0)
			{
				this.Message = other.Message;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.TargetNum != 0)
			{
				this.TargetNum = other.TargetNum;
			}
			if (other.FrequencyType != 0)
			{
				this.FrequencyType = other.FrequencyType;
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
											this.FrequencyType = input.ReadInt32();
										}
									}
									else
									{
										this.TargetNum = input.ReadInt32();
									}
								}
								else
								{
									this.TargetId = input.ReadInt32();
								}
							}
							else
							{
								this.CondType = input.ReadInt32();
							}
						}
						else
						{
							this.Message = input.ReadBytes();
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
		}
	}
}
