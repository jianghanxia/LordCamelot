using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_RESET : IMessage, IMessage<MST_QUEST_RESET>, IEquatable<MST_QUEST_RESET>, IDeepCloneable<MST_QUEST_RESET>
	{
		public const int QuestIdFieldNumber = 1;

		public const int ResetQuestIdsFieldNumber = 2;

		public const int StartMessageFieldNumber = 3;

		private static readonly MessageParser<MST_QUEST_RESET> _parser = new MessageParser<MST_QUEST_RESET>(() => new MST_QUEST_RESET());

		private int questId_;

		private static readonly FieldCodec<int> _repeated_resetQuestIds_codec = FieldCodec.ForInt32(18u);

		private readonly RepeatedField<int> resetQuestIds_ = new RepeatedField<int>();

		private ByteString startMessage_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_RESET.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_RESET> Parser => MST_QUEST_RESET._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestResetReflection.Descriptor.MessageTypes[0];

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
		public RepeatedField<int> ResetQuestIds => this.resetQuestIds_;

		[DebuggerNonUserCode]
		public ByteString StartMessage
		{
			get => this.startMessage_;
			set
			{
				this.startMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RESET()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RESET(MST_QUEST_RESET other) : this()
		{
			this.questId_ = other.questId_;
			this.resetQuestIds_ = other.resetQuestIds_.Clone();
			this.startMessage_ = other.startMessage_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_RESET Clone()
		{
			return new MST_QUEST_RESET(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_RESET);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_RESET other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.resetQuestIds_.Equals(other.resetQuestIds_) && !(this.StartMessage != other.StartMessage)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			num ^= this.resetQuestIds_.GetHashCode();
			if (this.StartMessage.Length != 0)
			{
				num ^= this.StartMessage.GetHashCode();
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
			this.resetQuestIds_.WriteTo(output, MST_QUEST_RESET._repeated_resetQuestIds_codec);
			if (this.StartMessage.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.StartMessage);
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
			num += this.resetQuestIds_.CalculateSize(MST_QUEST_RESET._repeated_resetQuestIds_codec);
			if (this.StartMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.StartMessage);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_RESET other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this.resetQuestIds_.Add(other.resetQuestIds_);
			if (other.StartMessage.Length != 0)
			{
				this.StartMessage = other.StartMessage;
			}
		}

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                uint num2 = num;
                switch (num2)
                {
                    case 0x10:
                    case 0x12:
                        {
                            this.resetQuestIds_.AddEntriesFrom(input, _repeated_resetQuestIds_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.QuestId = input.ReadInt32();
                            continue;
                        }
                    case 0x1a:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.StartMessage = input.ReadBytes();
            }
        }


    }
}
