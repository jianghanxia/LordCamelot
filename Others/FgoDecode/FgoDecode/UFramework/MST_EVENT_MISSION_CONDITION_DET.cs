using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_MISSION_CONDITION_DET : IMessage, IMessage<MST_EVENT_MISSION_CONDITION_DET>, IEquatable<MST_EVENT_MISSION_CONDITION_DET>, IDeepCloneable<MST_EVENT_MISSION_CONDITION_DET>
	{
		public const int IdFieldNumber = 1;

		public const int MissionCondTypeFieldNumber = 2;

		public const int LogicTypeFieldNumber = 3;

		public const int TargetIdsFieldNumber = 4;

		public const int AddTargetIdsFieldNumber = 5;

		public const int TargetQuestIndividualitiesFieldNumber = 6;

		public const int ConditionLinkTypeFieldNumber = 7;

		private static readonly MessageParser<MST_EVENT_MISSION_CONDITION_DET> _parser = new MessageParser<MST_EVENT_MISSION_CONDITION_DET>(() => new MST_EVENT_MISSION_CONDITION_DET());

		private int id_;

		private int missionCondType_;

		private int logicType_;

		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_addTargetIds_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> addTargetIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_targetQuestIndividualities_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> targetQuestIndividualities_ = new RepeatedField<int>();

		private int conditionLinkType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_MISSION_CONDITION_DET.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_MISSION_CONDITION_DET> Parser => MST_EVENT_MISSION_CONDITION_DET._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventMissionConditionDetReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MissionCondType
		{
			get => this.missionCondType_;
			set
			{
				this.missionCondType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LogicType
		{
			get => this.logicType_;
			set
			{
				this.logicType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> TargetIds => this.targetIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> AddTargetIds => this.addTargetIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> TargetQuestIndividualities => this.targetQuestIndividualities_;

		[DebuggerNonUserCode]
		public int ConditionLinkType
		{
			get => this.conditionLinkType_;
			set
			{
				this.conditionLinkType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_CONDITION_DET()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_CONDITION_DET(MST_EVENT_MISSION_CONDITION_DET other) : this()
		{
			this.id_ = other.id_;
			this.missionCondType_ = other.missionCondType_;
			this.logicType_ = other.logicType_;
			this.targetIds_ = other.targetIds_.Clone();
			this.addTargetIds_ = other.addTargetIds_.Clone();
			this.targetQuestIndividualities_ = other.targetQuestIndividualities_.Clone();
			this.conditionLinkType_ = other.conditionLinkType_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_CONDITION_DET Clone()
		{
			return new MST_EVENT_MISSION_CONDITION_DET(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_MISSION_CONDITION_DET);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_MISSION_CONDITION_DET other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.MissionCondType == other.MissionCondType && this.LogicType == other.LogicType && this.targetIds_.Equals(other.targetIds_) && this.addTargetIds_.Equals(other.addTargetIds_) && this.targetQuestIndividualities_.Equals(other.targetQuestIndividualities_) && this.ConditionLinkType == other.ConditionLinkType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MissionCondType != 0)
			{
				num ^= this.MissionCondType.GetHashCode();
			}
			if (this.LogicType != 0)
			{
				num ^= this.LogicType.GetHashCode();
			}
			num ^= this.targetIds_.GetHashCode();
			num ^= this.addTargetIds_.GetHashCode();
			num ^= this.targetQuestIndividualities_.GetHashCode();
			if (this.ConditionLinkType != 0)
			{
				num ^= this.ConditionLinkType.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.MissionCondType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MissionCondType);
			}
			if (this.LogicType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LogicType);
			}
			this.targetIds_.WriteTo(output, MST_EVENT_MISSION_CONDITION_DET._repeated_targetIds_codec);
			this.addTargetIds_.WriteTo(output, MST_EVENT_MISSION_CONDITION_DET._repeated_addTargetIds_codec);
			this.targetQuestIndividualities_.WriteTo(output, MST_EVENT_MISSION_CONDITION_DET._repeated_targetQuestIndividualities_codec);
			if (this.ConditionLinkType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ConditionLinkType);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MissionCondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionCondType);
			}
			if (this.LogicType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LogicType);
			}
			num += this.targetIds_.CalculateSize(MST_EVENT_MISSION_CONDITION_DET._repeated_targetIds_codec);
			num += this.addTargetIds_.CalculateSize(MST_EVENT_MISSION_CONDITION_DET._repeated_addTargetIds_codec);
			num += this.targetQuestIndividualities_.CalculateSize(MST_EVENT_MISSION_CONDITION_DET._repeated_targetQuestIndividualities_codec);
			if (this.ConditionLinkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionLinkType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_MISSION_CONDITION_DET other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MissionCondType != 0)
			{
				this.MissionCondType = other.MissionCondType;
			}
			if (other.LogicType != 0)
			{
				this.LogicType = other.LogicType;
			}
			this.targetIds_.Add(other.targetIds_);
			this.addTargetIds_.Add(other.addTargetIds_);
			this.targetQuestIndividualities_.Add(other.targetQuestIndividualities_);
			if (other.ConditionLinkType != 0)
			{
				this.ConditionLinkType = other.ConditionLinkType;
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
                    case 0x20:
                    case 0x22:
                        {
                            this.targetIds_.AddEntriesFrom(input, _repeated_targetIds_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.addTargetIds_.AddEntriesFrom(input, _repeated_addTargetIds_codec);
                            continue;
                        }
                    case 0x30:
                    case 50:
                        {
                            this.targetQuestIndividualities_.AddEntriesFrom(input, _repeated_targetQuestIndividualities_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.Id = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.MissionCondType = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.LogicType = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.ConditionLinkType = input.ReadInt32();
            }
        }


    }
}
