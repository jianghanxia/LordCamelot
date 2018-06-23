using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_SCRIPT_RELEASE : IMessage, IMessage<MST_QUEST_SCRIPT_RELEASE>, IEquatable<MST_QUEST_SCRIPT_RELEASE>, IDeepCloneable<MST_QUEST_SCRIPT_RELEASE>
	{
		public const int ScriptIdFieldNumber = 1;

		public const int IdFieldNumber = 2;

		public const int FlagFieldNumber = 3;

		public const int CondTypeFieldNumber = 4;

		public const int TargetIdsFieldNumber = 5;

		public const int TargetNumFieldNumber = 6;

		private static readonly MessageParser<MST_QUEST_SCRIPT_RELEASE> _parser = new MessageParser<MST_QUEST_SCRIPT_RELEASE>(() => new MST_QUEST_SCRIPT_RELEASE());

		private int scriptId_;

		private int id_;

		private int flag_;

		private int condType_;

		private static readonly FieldCodec<int> _repeated_targetIds_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> targetIds_ = new RepeatedField<int>();

		private int targetNum_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_SCRIPT_RELEASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_SCRIPT_RELEASE> Parser => MST_QUEST_SCRIPT_RELEASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestScriptReleaseReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int ScriptId
		{
			get => this.scriptId_;
			set
			{
				this.scriptId_ = value;
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
		public int Flag
		{
			get => this.flag_;
			set
			{
				this.flag_ = value;
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
		public MST_QUEST_SCRIPT_RELEASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_SCRIPT_RELEASE(MST_QUEST_SCRIPT_RELEASE other) : this()
		{
			this.scriptId_ = other.scriptId_;
			this.id_ = other.id_;
			this.flag_ = other.flag_;
			this.condType_ = other.condType_;
			this.targetIds_ = other.targetIds_.Clone();
			this.targetNum_ = other.targetNum_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_SCRIPT_RELEASE Clone()
		{
			return new MST_QUEST_SCRIPT_RELEASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_SCRIPT_RELEASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_SCRIPT_RELEASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.ScriptId == other.ScriptId && this.Id == other.Id && this.Flag == other.Flag && this.CondType == other.CondType && this.targetIds_.Equals(other.targetIds_) && this.TargetNum == other.TargetNum));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScriptId != 0)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
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
			if (this.ScriptId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ScriptId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Flag);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CondType);
			}
			this.targetIds_.WriteTo(output, MST_QUEST_SCRIPT_RELEASE._repeated_targetIds_codec);
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TargetNum);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScriptId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScriptId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			num += this.targetIds_.CalculateSize(MST_QUEST_SCRIPT_RELEASE._repeated_targetIds_codec);
			if (this.TargetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetNum);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_SCRIPT_RELEASE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScriptId != 0)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
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
                    case 40:
                    case 0x2a:
                        {
                            this.targetIds_.AddEntriesFrom(input, _repeated_targetIds_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.ScriptId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.Id = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.CondType = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.TargetNum = input.ReadInt32();
            }
        }


    }
}
