using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_CONSUME_ITEM : IMessage, IMessage<MST_QUEST_CONSUME_ITEM>, IEquatable<MST_QUEST_CONSUME_ITEM>, IDeepCloneable<MST_QUEST_CONSUME_ITEM>
	{
		public const int QuestIdFieldNumber = 1;

		public const int ItemIdsFieldNumber = 2;

		public const int NumsFieldNumber = 3;

		private static readonly MessageParser<MST_QUEST_CONSUME_ITEM> _parser = new MessageParser<MST_QUEST_CONSUME_ITEM>(() => new MST_QUEST_CONSUME_ITEM());

		private int questId_;

		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(18u);

		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_nums_codec = FieldCodec.ForInt32(26u);

		private readonly RepeatedField<int> nums_ = new RepeatedField<int>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_CONSUME_ITEM.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_CONSUME_ITEM> Parser => MST_QUEST_CONSUME_ITEM._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestConsumeItemReflection.Descriptor.MessageTypes[0];

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
		public RepeatedField<int> ItemIds => this.itemIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> Nums => this.nums_;

		[DebuggerNonUserCode]
		public MST_QUEST_CONSUME_ITEM()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_CONSUME_ITEM(MST_QUEST_CONSUME_ITEM other) : this()
		{
			this.questId_ = other.questId_;
			this.itemIds_ = other.itemIds_.Clone();
			this.nums_ = other.nums_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_QUEST_CONSUME_ITEM Clone()
		{
			return new MST_QUEST_CONSUME_ITEM(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_CONSUME_ITEM);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_CONSUME_ITEM other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.itemIds_.Equals(other.itemIds_) && this.nums_.Equals(other.nums_)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			num ^= this.itemIds_.GetHashCode();
			return num ^ this.nums_.GetHashCode();
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
			this.itemIds_.WriteTo(output, MST_QUEST_CONSUME_ITEM._repeated_itemIds_codec);
			this.nums_.WriteTo(output, MST_QUEST_CONSUME_ITEM._repeated_nums_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			num += this.itemIds_.CalculateSize(MST_QUEST_CONSUME_ITEM._repeated_itemIds_codec);
			return num + this.nums_.CalculateSize(MST_QUEST_CONSUME_ITEM._repeated_nums_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_CONSUME_ITEM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this.itemIds_.Add(other.itemIds_);
			this.nums_.Add(other.nums_);
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
                            this.itemIds_.AddEntriesFrom(input, _repeated_itemIds_codec);
                            continue;
                        }
                    case 0x18:
                    case 0x1a:
                        break;

                    default:
                        {
                            if (num2 != 8)
                            {
                                input.SkipLastField();
                            }
                            else
                            {
                                this.QuestId = input.ReadInt32();
                            }
                            continue;
                        }
                }
                this.nums_.AddEntriesFrom(input, _repeated_nums_codec);
            }
        }


    }
}
