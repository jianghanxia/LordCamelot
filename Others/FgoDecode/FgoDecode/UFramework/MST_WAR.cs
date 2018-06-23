using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_WAR : IMessage, IMessage<MST_WAR>, IEquatable<MST_WAR>, IDeepCloneable<MST_WAR>
	{
		public const int IdFieldNumber = 1;

		public const int AgeFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int LongNameFieldNumber = 4;

		public const int MapImageIdFieldNumber = 5;

		public const int MapImageWFieldNumber = 6;

		public const int MapImageHFieldNumber = 7;

		public const int HeaderImageIdFieldNumber = 8;

		public const int PriorityFieldNumber = 9;

		public const int ParentWarIdFieldNumber = 10;

		public const int FlagFieldNumber = 11;

		public const int EmptyMessageFieldNumber = 12;

		public const int BgmIdFieldNumber = 13;

		public const int ScriptIdFieldNumber = 14;

		public const int EventIdFieldNumber = 15;

		public const int LastQuestIdFieldNumber = 16;

		public const int CoordinateFieldNumber = 17;

		public const int StatusFieldNumber = 18;

		private static readonly MessageParser<MST_WAR> _parser = new MessageParser<MST_WAR>(() => new MST_WAR());

		private int id_;

		private ByteString age_ = ByteString.Empty;

		private ByteString name_ = ByteString.Empty;

		private ByteString longName_ = ByteString.Empty;

		private int mapImageId_;

		private int mapImageW_;

		private int mapImageH_;

		private int headerImageId_;

		private int priority_;

		private int parentWarId_;

		private int flag_;

		private ByteString emptyMessage_ = ByteString.Empty;

		private int bgmId_;

		private ByteString scriptId_ = ByteString.Empty;

		private int eventId_;

		private int lastQuestId_;

		private static readonly FieldCodec<float> _repeated_coordinate_codec = FieldCodec.ForFloat(138u);

		private readonly RepeatedField<float> coordinate_ = new RepeatedField<float>();

		private int status_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_WAR.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_WAR> Parser => MST_WAR._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstWarReflection.Descriptor.MessageTypes[0];

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
		public ByteString Age
		{
			get => this.age_;
			set
			{
				this.age_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString LongName
		{
			get => this.longName_;
			set
			{
				this.longName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int MapImageId
		{
			get => this.mapImageId_;
			set
			{
				this.mapImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MapImageW
		{
			get => this.mapImageW_;
			set
			{
				this.mapImageW_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MapImageH
		{
			get => this.mapImageH_;
			set
			{
				this.mapImageH_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HeaderImageId
		{
			get => this.headerImageId_;
			set
			{
				this.headerImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ParentWarId
		{
			get => this.parentWarId_;
			set
			{
				this.parentWarId_ = value;
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
		public ByteString EmptyMessage
		{
			get => this.emptyMessage_;
			set
			{
				this.emptyMessage_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int BgmId
		{
			get => this.bgmId_;
			set
			{
				this.bgmId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString ScriptId
		{
			get => this.scriptId_;
			set
			{
				this.scriptId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int LastQuestId
		{
			get => this.lastQuestId_;
			set
			{
				this.lastQuestId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<float> Coordinate => this.coordinate_;

		[DebuggerNonUserCode]
		public int Status
		{
			get => this.status_;
			set
			{
				this.status_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_WAR()
		{
		}

		[DebuggerNonUserCode]
		public MST_WAR(MST_WAR other) : this()
		{
			this.id_ = other.id_;
			this.age_ = other.age_;
			this.name_ = other.name_;
			this.longName_ = other.longName_;
			this.mapImageId_ = other.mapImageId_;
			this.mapImageW_ = other.mapImageW_;
			this.mapImageH_ = other.mapImageH_;
			this.headerImageId_ = other.headerImageId_;
			this.priority_ = other.priority_;
			this.parentWarId_ = other.parentWarId_;
			this.flag_ = other.flag_;
			this.emptyMessage_ = other.emptyMessage_;
			this.bgmId_ = other.bgmId_;
			this.scriptId_ = other.scriptId_;
			this.eventId_ = other.eventId_;
			this.lastQuestId_ = other.lastQuestId_;
			this.coordinate_ = other.coordinate_.Clone();
			this.status_ = other.status_;
		}

		[DebuggerNonUserCode]
		public MST_WAR Clone()
		{
			return new MST_WAR(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_WAR);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_WAR other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Age != other.Age) && !(this.Name != other.Name) && !(this.LongName != other.LongName) && this.MapImageId == other.MapImageId && this.MapImageW == other.MapImageW && this.MapImageH == other.MapImageH && this.HeaderImageId == other.HeaderImageId && this.Priority == other.Priority && this.ParentWarId == other.ParentWarId && this.Flag == other.Flag && !(this.EmptyMessage != other.EmptyMessage) && this.BgmId == other.BgmId && !(this.ScriptId != other.ScriptId) && this.EventId == other.EventId && this.LastQuestId == other.LastQuestId && this.coordinate_.Equals(other.coordinate_) && this.Status == other.Status));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Age.Length != 0)
			{
				num ^= this.Age.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.LongName.Length != 0)
			{
				num ^= this.LongName.GetHashCode();
			}
			if (this.MapImageId != 0)
			{
				num ^= this.MapImageId.GetHashCode();
			}
			if (this.MapImageW != 0)
			{
				num ^= this.MapImageW.GetHashCode();
			}
			if (this.MapImageH != 0)
			{
				num ^= this.MapImageH.GetHashCode();
			}
			if (this.HeaderImageId != 0)
			{
				num ^= this.HeaderImageId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.ParentWarId != 0)
			{
				num ^= this.ParentWarId.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.EmptyMessage.Length != 0)
			{
				num ^= this.EmptyMessage.GetHashCode();
			}
			if (this.BgmId != 0)
			{
				num ^= this.BgmId.GetHashCode();
			}
			if (this.ScriptId.Length != 0)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.LastQuestId != 0)
			{
				num ^= this.LastQuestId.GetHashCode();
			}
			num ^= this.coordinate_.GetHashCode();
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
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
			if (this.Age.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Age);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.LongName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.LongName);
			}
			if (this.MapImageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MapImageId);
			}
			if (this.MapImageW != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MapImageW);
			}
			if (this.MapImageH != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MapImageH);
			}
			if (this.HeaderImageId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HeaderImageId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Priority);
			}
			if (this.ParentWarId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ParentWarId);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Flag);
			}
			if (this.EmptyMessage.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.EmptyMessage);
			}
			if (this.BgmId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.BgmId);
			}
			if (this.ScriptId.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteBytes(this.ScriptId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EventId);
			}
			if (this.LastQuestId != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.LastQuestId);
			}
			this.coordinate_.WriteTo(output, MST_WAR._repeated_coordinate_codec);
			if (this.Status != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.Status);
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
			if (this.Age.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Age);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.LongName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LongName);
			}
			if (this.MapImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapImageId);
			}
			if (this.MapImageW != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapImageW);
			}
			if (this.MapImageH != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapImageH);
			}
			if (this.HeaderImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeaderImageId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.ParentWarId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ParentWarId);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.EmptyMessage.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.EmptyMessage);
			}
			if (this.BgmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgmId);
			}
			if (this.ScriptId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.ScriptId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.LastQuestId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.LastQuestId);
			}
			num += this.coordinate_.CalculateSize(MST_WAR._repeated_coordinate_codec);
			if (this.Status != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_WAR other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Age.Length != 0)
			{
				this.Age = other.Age;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.LongName.Length != 0)
			{
				this.LongName = other.LongName;
			}
			if (other.MapImageId != 0)
			{
				this.MapImageId = other.MapImageId;
			}
			if (other.MapImageW != 0)
			{
				this.MapImageW = other.MapImageW;
			}
			if (other.MapImageH != 0)
			{
				this.MapImageH = other.MapImageH;
			}
			if (other.HeaderImageId != 0)
			{
				this.HeaderImageId = other.HeaderImageId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.ParentWarId != 0)
			{
				this.ParentWarId = other.ParentWarId;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.EmptyMessage.Length != 0)
			{
				this.EmptyMessage = other.EmptyMessage;
			}
			if (other.BgmId != 0)
			{
				this.BgmId = other.BgmId;
			}
			if (other.ScriptId.Length != 0)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.LastQuestId != 0)
			{
				this.LastQuestId = other.LastQuestId;
			}
			this.coordinate_.Add(other.coordinate_);
			if (other.Status != 0)
			{
				this.Status = other.Status;
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
                    case 0x8a:
                    case 0x8d:
                        {
                            this.coordinate_.AddEntriesFrom(input, _repeated_coordinate_codec);
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
                    case 0x12:
                        {
                            this.Age = input.ReadBytes();
                            continue;
                        }
                    case 0x1a:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x22:
                        {
                            this.LongName = input.ReadBytes();
                            continue;
                        }
                    case 40:
                        {
                            this.MapImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.MapImageW = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.MapImageH = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.HeaderImageId = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.ParentWarId = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.Flag = input.ReadInt32();
                            continue;
                        }
                    case 0x62:
                        {
                            this.EmptyMessage = input.ReadBytes();
                            continue;
                        }
                    case 0x68:
                        {
                            this.BgmId = input.ReadInt32();
                            continue;
                        }
                    case 0x72:
                        {
                            this.ScriptId = input.ReadBytes();
                            continue;
                        }
                    case 120:
                        {
                            this.EventId = input.ReadInt32();
                            continue;
                        }
                    case 0x80:
                        {
                            this.LastQuestId = input.ReadInt32();
                            continue;
                        }
                    case 0x90:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.Status = input.ReadInt32();
            }
        }


    }
}
