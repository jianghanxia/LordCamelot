using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_PHASE_DETAIL : IMessage, IMessage<MST_QUEST_PHASE_DETAIL>, IEquatable<MST_QUEST_PHASE_DETAIL>, IDeepCloneable<MST_QUEST_PHASE_DETAIL>
	{
		public const int QuestIdFieldNumber = 1;

		public const int PhaseFieldNumber = 2;

		public const int SpotIdFieldNumber = 3;

		public const int ConsumeTypeFieldNumber = 4;

		public const int ActConsumeFieldNumber = 5;

		public const int FlagFieldNumber = 6;

		public const int AfterActionValsFieldNumber = 7;

		private static readonly MessageParser<MST_QUEST_PHASE_DETAIL> _parser = new MessageParser<MST_QUEST_PHASE_DETAIL>(() => new MST_QUEST_PHASE_DETAIL());

		private int questId_;

		private int phase_;

		private int spotId_;

		private int consumeType_;

		private int actConsume_;

		private int flag_;

		private static readonly FieldCodec<int> _repeated_afterActionVals_codec = FieldCodec.ForInt32(58u);

		private readonly RepeatedField<int> afterActionVals_ = new RepeatedField<int>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_PHASE_DETAIL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_PHASE_DETAIL> Parser => MST_QUEST_PHASE_DETAIL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestPhaseDetailReflection.Descriptor.MessageTypes[0];

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
		public int SpotId
		{
			get => this.spotId_;
			set
			{
				this.spotId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ConsumeType
		{
			get => this.consumeType_;
			set
			{
				this.consumeType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActConsume
		{
			get => this.actConsume_;
			set
			{
				this.actConsume_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> AfterActionVals => this.afterActionVals_;

		[DebuggerNonUserCode]
		public MST_QUEST_PHASE_DETAIL()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_PHASE_DETAIL(MST_QUEST_PHASE_DETAIL other) : this()
		{
			this.questId_ = other.questId_;
			this.phase_ = other.phase_;
			this.spotId_ = other.spotId_;
			this.consumeType_ = other.consumeType_;
			this.actConsume_ = other.actConsume_;
			this.flag_ = other.flag_;
			this.afterActionVals_ = other.afterActionVals_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_QUEST_PHASE_DETAIL Clone()
		{
			return new MST_QUEST_PHASE_DETAIL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_PHASE_DETAIL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_PHASE_DETAIL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.Phase == other.Phase && this.SpotId == other.SpotId && this.ConsumeType == other.ConsumeType && this.ActConsume == other.ActConsume && this.Flag == other.Flag && this.afterActionVals_.Equals(other.afterActionVals_)));
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
			if (this.SpotId != 0)
			{
				num ^= this.SpotId.GetHashCode();
			}
			if (this.ConsumeType != 0)
			{
				num ^= this.ConsumeType.GetHashCode();
			}
			if (this.ActConsume != 0)
			{
				num ^= this.ActConsume.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			return num ^ this.afterActionVals_.GetHashCode();
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
			if (this.SpotId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SpotId);
			}
			if (this.ConsumeType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ConsumeType);
			}
			if (this.ActConsume != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActConsume);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Flag);
			}
			this.afterActionVals_.WriteTo(output, MST_QUEST_PHASE_DETAIL._repeated_afterActionVals_codec);
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
			if (this.SpotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpotId);
			}
			if (this.ConsumeType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsumeType);
			}
			if (this.ActConsume != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActConsume);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			return num + this.afterActionVals_.CalculateSize(MST_QUEST_PHASE_DETAIL._repeated_afterActionVals_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_PHASE_DETAIL other)
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
			if (other.SpotId != 0)
			{
				this.SpotId = other.SpotId;
			}
			if (other.ConsumeType != 0)
			{
				this.ConsumeType = other.ConsumeType;
			}
			if (other.ActConsume != 0)
			{
				this.ActConsume = other.ActConsume;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			this.afterActionVals_.Add(other.afterActionVals_);
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
                    case 0x38:
                    case 0x3a:
                        break;

                    default:
                        switch (num2)
                        {
                            case 8:
                                {
                                    this.QuestId = input.ReadInt32();
                                    continue;
                                }
                            case 0x10:
                                {
                                    this.Phase = input.ReadInt32();
                                    continue;
                                }
                            case 0x18:
                                {
                                    this.SpotId = input.ReadInt32();
                                    continue;
                                }
                            case 0x20:
                                {
                                    this.ConsumeType = input.ReadInt32();
                                    continue;
                                }
                            case 40:
                                {
                                    this.ActConsume = input.ReadInt32();
                                    continue;
                                }
                            case 0x30:
                                {
                                    this.Flag = input.ReadInt32();
                                    continue;
                                }
                            default:
                                {
                                    input.SkipLastField();
                                    continue;
                                }
                        }
                        break;
                }
                this.afterActionVals_.AddEntriesFrom(input, _repeated_afterActionVals_codec);
            }
        }


    }
}
