using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BUFF : IMessage, IMessage<MST_BUFF>, IEquatable<MST_BUFF>, IDeepCloneable<MST_BUFF>
	{
		public const int IdFieldNumber = 1;

		public const int BuffGroupFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int ValsFieldNumber = 4;

		public const int TvalsFieldNumber = 5;

		public const int CkSelfIndvFieldNumber = 6;

		public const int CkOpIndvFieldNumber = 7;

		public const int NameFieldNumber = 8;

		public const int DetailFieldNumber = 9;

		public const int IconIdFieldNumber = 10;

		public const int MaxRateFieldNumber = 11;

		public const int ScriptFieldNumber = 12;

		public const int UpdatedAtFieldNumber = 13;

		public const int CreatedAtFieldNumber = 14;

		private static readonly MessageParser<MST_BUFF> _parser = new MessageParser<MST_BUFF>(() => new MST_BUFF());

		private int id_;

		private int buffGroup_;

		private int type_;

		private static readonly FieldCodec<int> _repeated_vals_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> vals_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_tvals_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> tvals_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_ckSelfIndv_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> ckSelfIndv_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_ckOpIndv_codec = FieldCodec.ForInt32(58u);

		private readonly RepeatedField<int> ckOpIndv_ = new RepeatedField<int>();

		private ByteString name_ = ByteString.Empty;

		private ByteString detail_ = ByteString.Empty;

		private int iconId_;

		private int maxRate_;

		private ByteString script_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BUFF.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BUFF> Parser => MST_BUFF._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBuffReflection.Descriptor.MessageTypes[0];

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
		public int BuffGroup
		{
			get => this.buffGroup_;
			set
			{
				this.buffGroup_ = value;
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
		public RepeatedField<int> Vals => this.vals_;

		[DebuggerNonUserCode]
		public RepeatedField<int> Tvals => this.tvals_;

		[DebuggerNonUserCode]
		public RepeatedField<int> CkSelfIndv => this.ckSelfIndv_;

		[DebuggerNonUserCode]
		public RepeatedField<int> CkOpIndv => this.ckOpIndv_;

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
		public ByteString Detail
		{
			get => this.detail_;
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int IconId
		{
			get => this.iconId_;
			set
			{
				this.iconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int MaxRate
		{
			get => this.maxRate_;
			set
			{
				this.maxRate_ = value;
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
		public MST_BUFF()
		{
		}

		[DebuggerNonUserCode]
		public MST_BUFF(MST_BUFF other) : this()
		{
			this.id_ = other.id_;
			this.buffGroup_ = other.buffGroup_;
			this.type_ = other.type_;
			this.vals_ = other.vals_.Clone();
			this.tvals_ = other.tvals_.Clone();
			this.ckSelfIndv_ = other.ckSelfIndv_.Clone();
			this.ckOpIndv_ = other.ckOpIndv_.Clone();
			this.name_ = other.name_;
			this.detail_ = other.detail_;
			this.iconId_ = other.iconId_;
			this.maxRate_ = other.maxRate_;
			this.script_ = other.script_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_BUFF Clone()
		{
			return new MST_BUFF(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BUFF);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BUFF other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.BuffGroup == other.BuffGroup && this.Type == other.Type && this.vals_.Equals(other.vals_) && this.tvals_.Equals(other.tvals_) && this.ckSelfIndv_.Equals(other.ckSelfIndv_) && this.ckOpIndv_.Equals(other.ckOpIndv_) && !(this.Name != other.Name) && !(this.Detail != other.Detail) && this.IconId == other.IconId && this.MaxRate == other.MaxRate && !(this.Script != other.Script) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BuffGroup != 0)
			{
				num ^= this.BuffGroup.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.vals_.GetHashCode();
			num ^= this.tvals_.GetHashCode();
			num ^= this.ckSelfIndv_.GetHashCode();
			num ^= this.ckOpIndv_.GetHashCode();
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.MaxRate != 0)
			{
				num ^= this.MaxRate.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BuffGroup != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuffGroup);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			this.vals_.WriteTo(output, MST_BUFF._repeated_vals_codec);
			this.tvals_.WriteTo(output, MST_BUFF._repeated_tvals_codec);
			this.ckSelfIndv_.WriteTo(output, MST_BUFF._repeated_ckSelfIndv_codec);
			this.ckOpIndv_.WriteTo(output, MST_BUFF._repeated_ckOpIndv_codec);
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteBytes(this.Detail);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IconId);
			}
			if (this.MaxRate != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MaxRate);
			}
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.Script);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(104);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(112);
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
			if (this.BuffGroup != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffGroup);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			num += this.vals_.CalculateSize(MST_BUFF._repeated_vals_codec);
			num += this.tvals_.CalculateSize(MST_BUFF._repeated_tvals_codec);
			num += this.ckSelfIndv_.CalculateSize(MST_BUFF._repeated_ckSelfIndv_codec);
			num += this.ckOpIndv_.CalculateSize(MST_BUFF._repeated_ckOpIndv_codec);
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.MaxRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxRate);
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
		public void MergeFrom(MST_BUFF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BuffGroup != 0)
			{
				this.BuffGroup = other.BuffGroup;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this.vals_.Add(other.vals_);
			this.tvals_.Add(other.tvals_);
			this.ckSelfIndv_.Add(other.ckSelfIndv_);
			this.ckOpIndv_.Add(other.ckOpIndv_);
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.MaxRate != 0)
			{
				this.MaxRate = other.MaxRate;
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
                            this.vals_.AddEntriesFrom(input, _repeated_vals_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.tvals_.AddEntriesFrom(input, _repeated_tvals_codec);
                            continue;
                        }
                    case 0x30:
                    case 50:
                        {
                            this.ckSelfIndv_.AddEntriesFrom(input, _repeated_ckSelfIndv_codec);
                            continue;
                        }
                    case 0x38:
                    case 0x3a:
                        {
                            this.ckOpIndv_.AddEntriesFrom(input, _repeated_ckOpIndv_codec);
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
                            this.BuffGroup = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 0x42:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x4a:
                        {
                            this.Detail = input.ReadBytes();
                            continue;
                        }
                    case 80:
                        {
                            this.IconId = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.MaxRate = input.ReadInt32();
                            continue;
                        }
                    case 0x62:
                        {
                            this.Script = input.ReadBytes();
                            continue;
                        }
                    case 0x68:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x70:
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
