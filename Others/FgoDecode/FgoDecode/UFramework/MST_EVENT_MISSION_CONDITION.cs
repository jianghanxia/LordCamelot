using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_MISSION_CONDITION : IMessage, IMessage<MST_EVENT_MISSION_CONDITION>, IEquatable<MST_EVENT_MISSION_CONDITION>, IDeepCloneable<MST_EVENT_MISSION_CONDITION>
	{
		public const int MissionIdFieldNumber = 1;

		public const int MissionProgressTypeFieldNumber = 2;

		public const int IdFieldNumber = 3;

		public const int MissionTargetIdFieldNumber = 4;

		public const int CondTypeFieldNumber = 5;

		public const int TargetIdsFieldNumber = 6;

		public const int TargetNumFieldNumber = 7;

		public const int ConditionMessageFieldNumber = 8;

		public const int FlagFieldNumber = 9;

		public const int EventIdFieldNumber = 10;

		private static readonly MessageParser<MST_EVENT_MISSION_CONDITION> _parser = new MessageParser<MST_EVENT_MISSION_CONDITION>(() => new MST_EVENT_MISSION_CONDITION());

		private int missionId_;

		private int missionProgressType_;

		private int id_;

		private int missionTargetId_;

		private int condType_;

		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();

		private int targetNum_;

		private ByteString conditionMessage_ = ByteString.Empty;

		private int flag_;

		private int eventId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_MISSION_CONDITION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_MISSION_CONDITION> Parser => MST_EVENT_MISSION_CONDITION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventMissionConditionReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int MissionId
		{
			get => this.missionId_;
			set
			{
				this.missionId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MissionProgressType
		{
			get => this.missionProgressType_;
			set
			{
				this.missionProgressType_ = value;
			}
		}

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
		public int MissionTargetId
		{
			get => this.missionTargetId_;
			set
			{
				this.missionTargetId_ = value;
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
		public RepeatedField<int> TargetIds => this.targetIds_;

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
		public ByteString ConditionMessage
		{
			get => this.conditionMessage_;
			set
			{
				this.conditionMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int EventId
		{
			get => this.eventId_;
			set
			{
				this.eventId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_CONDITION()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_CONDITION(MST_EVENT_MISSION_CONDITION other) : this()
		{
			this.missionId_ = other.missionId_;
			this.missionProgressType_ = other.missionProgressType_;
			this.id_ = other.id_;
			this.missionTargetId_ = other.missionTargetId_;
			this.condType_ = other.condType_;
			this.targetIds_ = other.targetIds_.Clone();
			this.targetNum_ = other.targetNum_;
			this.conditionMessage_ = other.conditionMessage_;
			this.flag_ = other.flag_;
			this.eventId_ = other.eventId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_MISSION_CONDITION Clone()
		{
			return new MST_EVENT_MISSION_CONDITION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_MISSION_CONDITION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_MISSION_CONDITION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.MissionId == other.MissionId && this.MissionProgressType == other.MissionProgressType && this.Id == other.Id && this.MissionTargetId == other.MissionTargetId && this.CondType == other.CondType && this.targetIds_.Equals(other.targetIds_) && this.TargetNum == other.TargetNum && !(this.ConditionMessage != other.ConditionMessage) && this.Flag == other.Flag && this.EventId == other.EventId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MissionId != 0)
			{
				num ^= this.MissionId.GetHashCode();
			}
			if (this.MissionProgressType != 0)
			{
				num ^= this.MissionProgressType.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MissionTargetId != 0)
			{
				num ^= this.MissionTargetId.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			num ^= this.targetIds_.GetHashCode();
			if (this.TargetNum != 0)
			{
				num ^= this.TargetNum.GetHashCode();
			}
			if (this.ConditionMessage.Length != 0)
			{
				num ^= this.ConditionMessage.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
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
			if (this.MissionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MissionId);
			}
			if (this.MissionProgressType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MissionProgressType);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.MissionTargetId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MissionTargetId);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CondType);
			}
			this.targetIds_.WriteTo(output, MST_EVENT_MISSION_CONDITION._repeated_targetIds_codec);
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TargetNum);
			}
			if (this.ConditionMessage.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.ConditionMessage);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Flag);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EventId);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MissionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionId);
			}
			if (this.MissionProgressType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionProgressType);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MissionTargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MissionTargetId);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			num += this.targetIds_.CalculateSize(MST_EVENT_MISSION_CONDITION._repeated_targetIds_codec);
			if (this.TargetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetNum);
			}
			if (this.ConditionMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ConditionMessage);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_MISSION_CONDITION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MissionId != 0)
			{
				this.MissionId = other.MissionId;
			}
			if (other.MissionProgressType != 0)
			{
				this.MissionProgressType = other.MissionProgressType;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MissionTargetId != 0)
			{
				this.MissionTargetId = other.MissionTargetId;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			this.targetIds_.Add(other.targetIds_);
			if (other.TargetNum != 0)
			{
				this.TargetNum = other.TargetNum;
			}
			if (other.ConditionMessage.Length != 0)
			{
				this.ConditionMessage = other.ConditionMessage;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
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
                    case 0x30:
                    case 50:
                        {
                            this.targetIds_.AddEntriesFrom(input, _repeated_targetIds_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.MissionId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.MissionProgressType = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Id = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.MissionTargetId = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.CondType = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.TargetNum = input.ReadInt32();
                            continue;
                        }
                    case 0x42:
                        {
                            this.ConditionMessage = input.ReadBytes();
                            continue;
                        }
                    case 0x48:
                        {
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.EventId = input.ReadInt32();
            }
        }


    }
}
