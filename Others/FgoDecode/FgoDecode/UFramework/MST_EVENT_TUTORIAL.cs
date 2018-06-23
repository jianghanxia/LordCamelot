using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_TUTORIAL : IMessage, IMessage<MST_EVENT_TUTORIAL>, IEquatable<MST_EVENT_TUTORIAL>, IDeepCloneable<MST_EVENT_TUTORIAL>
	{
		public const int EventIdFieldNumber = 1;

		public const int FlagTypeFieldNumber = 2;

		public const int OpenTypeFieldNumber = 3;

		public const int TargetIdsFieldNumber = 4;

		public const int CondTypeFieldNumber = 5;

		public const int CondIdsFieldNumber = 6;

		public const int CondValueFieldNumber = 7;

		public const int CondValue2FieldNumber = 8;

		public const int CondValue3FieldNumber = 9;

		public const int ImageIdsFieldNumber = 10;

		public const int TextJsonFieldNumber = 11;

		private static readonly MessageParser<MST_EVENT_TUTORIAL> _parser = new MessageParser<MST_EVENT_TUTORIAL>(() => new MST_EVENT_TUTORIAL());

		private int eventId_;

		private int flagType_;

		private int openType_;

		private static readonly FieldCodec<ByteString> _repeated_targetIds_codec = FieldCodec.ForBytes(34u);

		private readonly RepeatedField<ByteString> targetIds_ = new RepeatedField<ByteString>();

		private int condType_;

		private static readonly FieldCodec<int> _repeated_condIds_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> condIds_ = new RepeatedField<int>();

		private int condValue_;

		private int condValue2_;

		private int condValue3_;

		private static readonly FieldCodec<int> _repeated_imageIds_codec = FieldCodec.ForInt32(82u);

		private readonly RepeatedField<int> imageIds_ = new RepeatedField<int>();

		private ByteString textJson_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_TUTORIAL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_TUTORIAL> Parser => MST_EVENT_TUTORIAL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventTutorialReflection.Descriptor.MessageTypes[0];

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
		public int FlagType
		{
			get => this.flagType_;
			set
			{
				this.flagType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OpenType
		{
			get => this.openType_;
			set
			{
				this.openType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> TargetIds => this.targetIds_;

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
		public RepeatedField<int> CondIds => this.condIds_;

		[DebuggerNonUserCode]
		public int CondValue
		{
			get => this.condValue_;
			set
			{
				this.condValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondValue2
		{
			get => this.condValue2_;
			set
			{
				this.condValue2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CondValue3
		{
			get => this.condValue3_;
			set
			{
				this.condValue3_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ImageIds => this.imageIds_;

		[DebuggerNonUserCode]
		public ByteString TextJson
		{
			get => this.textJson_;
			set
			{
				this.textJson_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_TUTORIAL()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_TUTORIAL(MST_EVENT_TUTORIAL other) : this()
		{
			this.eventId_ = other.eventId_;
			this.flagType_ = other.flagType_;
			this.openType_ = other.openType_;
			this.targetIds_ = other.targetIds_.Clone();
			this.condType_ = other.condType_;
			this.condIds_ = other.condIds_.Clone();
			this.condValue_ = other.condValue_;
			this.condValue2_ = other.condValue2_;
			this.condValue3_ = other.condValue3_;
			this.imageIds_ = other.imageIds_.Clone();
			this.textJson_ = other.textJson_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_TUTORIAL Clone()
		{
			return new MST_EVENT_TUTORIAL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_TUTORIAL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_TUTORIAL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.FlagType == other.FlagType && this.OpenType == other.OpenType && this.targetIds_.Equals(other.targetIds_) && this.CondType == other.CondType && this.condIds_.Equals(other.condIds_) && this.CondValue == other.CondValue && this.CondValue2 == other.CondValue2 && this.CondValue3 == other.CondValue3 && this.imageIds_.Equals(other.imageIds_) && !(this.TextJson != other.TextJson)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.FlagType != 0)
			{
				num ^= this.FlagType.GetHashCode();
			}
			if (this.OpenType != 0)
			{
				num ^= this.OpenType.GetHashCode();
			}
			num ^= this.targetIds_.GetHashCode();
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			num ^= this.condIds_.GetHashCode();
			if (this.CondValue != 0)
			{
				num ^= this.CondValue.GetHashCode();
			}
			if (this.CondValue2 != 0)
			{
				num ^= this.CondValue2.GetHashCode();
			}
			if (this.CondValue3 != 0)
			{
				num ^= this.CondValue3.GetHashCode();
			}
			num ^= this.imageIds_.GetHashCode();
			if (this.TextJson.Length != 0)
			{
				num ^= this.TextJson.GetHashCode();
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
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			if (this.FlagType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FlagType);
			}
			if (this.OpenType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OpenType);
			}
			this.targetIds_.WriteTo(output, MST_EVENT_TUTORIAL._repeated_targetIds_codec);
			if (this.CondType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CondType);
			}
			this.condIds_.WriteTo(output, MST_EVENT_TUTORIAL._repeated_condIds_codec);
			if (this.CondValue != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CondValue);
			}
			if (this.CondValue2 != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CondValue2);
			}
			if (this.CondValue3 != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CondValue3);
			}
			this.imageIds_.WriteTo(output, MST_EVENT_TUTORIAL._repeated_imageIds_codec);
			if (this.TextJson.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.TextJson);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.FlagType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlagType);
			}
			if (this.OpenType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OpenType);
			}
			num += this.targetIds_.CalculateSize(MST_EVENT_TUTORIAL._repeated_targetIds_codec);
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			num += this.condIds_.CalculateSize(MST_EVENT_TUTORIAL._repeated_condIds_codec);
			if (this.CondValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue);
			}
			if (this.CondValue2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue2);
			}
			if (this.CondValue3 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue3);
			}
			num += this.imageIds_.CalculateSize(MST_EVENT_TUTORIAL._repeated_imageIds_codec);
			if (this.TextJson.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.TextJson);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_TUTORIAL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.FlagType != 0)
			{
				this.FlagType = other.FlagType;
			}
			if (other.OpenType != 0)
			{
				this.OpenType = other.OpenType;
			}
			this.targetIds_.Add(other.targetIds_);
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			this.condIds_.Add(other.condIds_);
			if (other.CondValue != 0)
			{
				this.CondValue = other.CondValue;
			}
			if (other.CondValue2 != 0)
			{
				this.CondValue2 = other.CondValue2;
			}
			if (other.CondValue3 != 0)
			{
				this.CondValue3 = other.CondValue3;
			}
			this.imageIds_.Add(other.imageIds_);
			if (other.TextJson.Length != 0)
			{
				this.TextJson = other.TextJson;
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
                            this.condIds_.AddEntriesFrom(input, _repeated_condIds_codec);
                            continue;
                        }
                    case 80:
                    case 0x52:
                        {
                            this.imageIds_.AddEntriesFrom(input, _repeated_imageIds_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.EventId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.FlagType = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.OpenType = input.ReadInt32();
                            continue;
                        }
                    case 0x22:
                        {
                            this.targetIds_.AddEntriesFrom(input, _repeated_targetIds_codec);
                            continue;
                        }
                    case 40:
                        {
                            this.CondType = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.CondValue = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.CondValue2 = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.CondValue3 = input.ReadInt32();
                            continue;
                        }
                    case 90:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.TextJson = input.ReadBytes();
            }
        }


    }
}
