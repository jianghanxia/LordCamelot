using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SKILL_LV : IMessage, IMessage<MST_SKILL_LV>, IEquatable<MST_SKILL_LV>, IDeepCloneable<MST_SKILL_LV>
	{
		public const int SkillIdFieldNumber = 1;

		public const int LvFieldNumber = 2;

		public const int ChargeTurnFieldNumber = 3;

		public const int FuncIdFieldNumber = 4;

		public const int ValsFieldNumber = 5;

		public const int SkillDetailIdFieldNumber = 6;

		public const int PriorityFieldNumber = 7;

		public const int ScriptFieldNumber = 8;

		public const int UpdatedAtFieldNumber = 9;

		public const int CreatedAtFieldNumber = 10;

		private static readonly MessageParser<MST_SKILL_LV> _parser = new MessageParser<MST_SKILL_LV>(() => new MST_SKILL_LV());

		private int skillId_;

		private int lv_;

		private int chargeTurn_;

		private static readonly FieldCodec<int> _repeated_funcId_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> funcId_ = new RepeatedField<int>();

		private static readonly FieldCodec<ByteString> _repeated_vals_codec = FieldCodec.ForBytes(42u);

		private readonly RepeatedField<ByteString> vals_ = new RepeatedField<ByteString>();

		private int skillDetailId_;

		private int priority_;

		private ByteString script_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SKILL_LV.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SKILL_LV> Parser => MST_SKILL_LV._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSkillLvReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int SkillId
		{
			get => this.skillId_;
			set
			{
				this.skillId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Lv
		{
			get => this.lv_;
			set
			{
				this.lv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ChargeTurn
		{
			get => this.chargeTurn_;
			set
			{
				this.chargeTurn_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> FuncId => this.funcId_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals => this.vals_;

		[DebuggerNonUserCode]
		public int SkillDetailId
		{
			get => this.skillDetailId_;
			set
			{
				this.skillDetailId_ = value;
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
		public ByteString Script
		{
			get => this.script_;
			set
			{
				this.script_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_SKILL_LV()
		{
		}

		[DebuggerNonUserCode]
		public MST_SKILL_LV(MST_SKILL_LV other) : this()
		{
			this.skillId_ = other.skillId_;
			this.lv_ = other.lv_;
			this.chargeTurn_ = other.chargeTurn_;
			this.funcId_ = other.funcId_.Clone();
			this.vals_ = other.vals_.Clone();
			this.skillDetailId_ = other.skillDetailId_;
			this.priority_ = other.priority_;
			this.script_ = other.script_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SKILL_LV Clone()
		{
			return new MST_SKILL_LV(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SKILL_LV);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SKILL_LV other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SkillId == other.SkillId && this.Lv == other.Lv && this.ChargeTurn == other.ChargeTurn && this.funcId_.Equals(other.funcId_) && this.vals_.Equals(other.vals_) && this.SkillDetailId == other.SkillDetailId && this.Priority == other.Priority && !(this.Script != other.Script) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.ChargeTurn != 0)
			{
				num ^= this.ChargeTurn.GetHashCode();
			}
			num ^= this.funcId_.GetHashCode();
			num ^= this.vals_.GetHashCode();
			if (this.SkillDetailId != 0)
			{
				num ^= this.SkillDetailId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.Script.Length != 0)
			{
				num ^= this.Script.GetHashCode();
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
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Lv);
			}
			if (this.ChargeTurn != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ChargeTurn);
			}
			this.funcId_.WriteTo(output, MST_SKILL_LV._repeated_funcId_codec);
			this.vals_.WriteTo(output, MST_SKILL_LV._repeated_vals_codec);
			if (this.SkillDetailId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillDetailId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Priority);
			}
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.Script);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.ChargeTurn != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChargeTurn);
			}
			num += this.funcId_.CalculateSize(MST_SKILL_LV._repeated_funcId_codec);
			num += this.vals_.CalculateSize(MST_SKILL_LV._repeated_vals_codec);
			if (this.SkillDetailId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillDetailId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.Script.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Script);
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
		public void MergeFrom(MST_SKILL_LV other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.ChargeTurn != 0)
			{
				this.ChargeTurn = other.ChargeTurn;
			}
			this.funcId_.Add(other.funcId_);
			this.vals_.Add(other.vals_);
			if (other.SkillDetailId != 0)
			{
				this.SkillDetailId = other.SkillDetailId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.Script.Length != 0)
			{
				this.Script = other.Script;
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
                    case 0x20:
                    case 0x22:
                        {
                            this.funcId_.AddEntriesFrom(input, _repeated_funcId_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.SkillId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.Lv = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.ChargeTurn = input.ReadInt32();
                            continue;
                        }
                    case 0x2a:
                        {
                            this.vals_.AddEntriesFrom(input, _repeated_vals_codec);
                            continue;
                        }
                    case 0x30:
                        {
                            this.SkillDetailId = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x42:
                        {
                            this.Script = input.ReadBytes();
                            continue;
                        }
                    case 0x48:
                        {
                            this.UpdatedAt = input.ReadUInt64();
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
                this.CreatedAt = input.ReadUInt64();
            }
        }


    }
}
