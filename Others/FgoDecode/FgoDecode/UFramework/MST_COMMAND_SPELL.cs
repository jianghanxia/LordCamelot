using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_COMMAND_SPELL : IMessage, IMessage<MST_COMMAND_SPELL>, IEquatable<MST_COMMAND_SPELL>, IDeepCloneable<MST_COMMAND_SPELL>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int ConsumeFieldNumber = 4;

		public const int DetailFieldNumber = 5;

		public const int FuncIdFieldNumber = 6;

		public const int ValsFieldNumber = 7;

		public const int MotionFieldNumber = 8;

		public const int ScriptFieldNumber = 9;

		public const int PriorityFieldNumber = 10;

		public const int UpdatedAtFieldNumber = 11;

		public const int CreatedAtFieldNumber = 12;

		private static readonly MessageParser<MST_COMMAND_SPELL> _parser = new MessageParser<MST_COMMAND_SPELL>(() => new MST_COMMAND_SPELL());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private int type_;

		private int consume_;

		private ByteString detail_ = ByteString.Empty;

		private static readonly FieldCodec<int> _repeated_funcId_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> funcId_ = new RepeatedField<int>();

		private static readonly FieldCodec<ByteString> _repeated_vals_codec = FieldCodec.ForBytes(58u);

		private readonly RepeatedField<ByteString> vals_ = new RepeatedField<ByteString>();

		private int motion_;

		private ByteString script_ = ByteString.Empty;

		private int priority_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_COMMAND_SPELL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_COMMAND_SPELL> Parser => MST_COMMAND_SPELL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCommandSpellReflection.Descriptor.MessageTypes[0];

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
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Consume
		{
			get => this.consume_;
			set
			{
				this.consume_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Detail
		{
			get => this.detail_;
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> FuncId => this.funcId_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals => this.vals_;

		[DebuggerNonUserCode]
		public int Motion
		{
			get => this.motion_;
			set
			{
				this.motion_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Script
		{
			get => this.script_;
			set
			{
				this.script_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public ulong UpdatedAt
		{
			get => this.updatedAt_;
			set
			{
				this.updatedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong CreatedAt
		{
			get => this.createdAt_;
			set
			{
				this.createdAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_COMMAND_SPELL()
		{
		}

		[DebuggerNonUserCode]
		public MST_COMMAND_SPELL(MST_COMMAND_SPELL other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.type_ = other.type_;
			this.consume_ = other.consume_;
			this.detail_ = other.detail_;
			this.funcId_ = other.funcId_.Clone();
			this.vals_ = other.vals_.Clone();
			this.motion_ = other.motion_;
			this.script_ = other.script_;
			this.priority_ = other.priority_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_COMMAND_SPELL Clone()
		{
			return new MST_COMMAND_SPELL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_COMMAND_SPELL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_COMMAND_SPELL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && this.Type == other.Type && this.Consume == other.Consume && !(this.Detail != other.Detail) && this.funcId_.Equals(other.funcId_) && this.vals_.Equals(other.vals_) && this.Motion == other.Motion && !(this.Script != other.Script) && this.Priority == other.Priority && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Consume != 0)
			{
				num ^= this.Consume.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			num ^= this.funcId_.GetHashCode();
			num ^= this.vals_.GetHashCode();
			if (this.Motion != 0)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.Script.Length != 0)
			{
				num ^= this.Script.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.UpdatedAt != 0uL)
			{
				num ^= this.UpdatedAt.GetHashCode();
			}
			if (this.CreatedAt != 0uL)
			{
				num ^= this.CreatedAt.GetHashCode();
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Name);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.Consume != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Consume);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Detail);
			}
			this.funcId_.WriteTo(output, MST_COMMAND_SPELL._repeated_funcId_codec);
			this.vals_.WriteTo(output, MST_COMMAND_SPELL._repeated_vals_codec);
			if (this.Motion != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Motion);
			}
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.Script);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Priority);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(96);
				output.WriteUInt64(this.CreatedAt);
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
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Consume != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Consume);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			num += this.funcId_.CalculateSize(MST_COMMAND_SPELL._repeated_funcId_codec);
			num += this.vals_.CalculateSize(MST_COMMAND_SPELL._repeated_vals_codec);
			if (this.Motion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Motion);
			}
			if (this.Script.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Script);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.UpdatedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_COMMAND_SPELL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Consume != 0)
			{
				this.Consume = other.Consume;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			this.funcId_.Add(other.funcId_);
			this.vals_.Add(other.vals_);
			if (other.Motion != 0)
			{
				this.Motion = other.Motion;
			}
			if (other.Script.Length != 0)
			{
				this.Script = other.Script;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.UpdatedAt != 0uL)
			{
				this.UpdatedAt = other.UpdatedAt;
			}
			if (other.CreatedAt != 0uL)
			{
				this.CreatedAt = other.CreatedAt;
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
                            this.funcId_.AddEntriesFrom(input, _repeated_funcId_codec);
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
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.Consume = input.ReadInt32();
                            continue;
                        }
                    case 0x2a:
                        {
                            this.Detail = input.ReadBytes();
                            continue;
                        }
                    case 0x3a:
                        {
                            this.vals_.AddEntriesFrom(input, _repeated_vals_codec);
                            continue;
                        }
                    case 0x40:
                        {
                            this.Motion = input.ReadInt32();
                            continue;
                        }
                    case 0x4a:
                        {
                            this.Script = input.ReadBytes();
                            continue;
                        }
                    case 80:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x60:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.CreatedAt = input.ReadUInt64();
            }
        }


    }
}
