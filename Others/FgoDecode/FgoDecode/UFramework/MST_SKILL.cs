using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SKILL : IMessage, IMessage<MST_SKILL>, IEquatable<MST_SKILL>, IDeepCloneable<MST_SKILL>
	{
		public const int IdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int RubyFieldNumber = 4;

		public const int MaxLvFieldNumber = 5;

		public const int IconIdFieldNumber = 6;

		public const int MotionFieldNumber = 7;

		public const int EffectListFieldNumber = 8;

		public const int ActIndividualityFieldNumber = 9;

		public const int ScriptFieldNumber = 10;

		public const int UpdatedAtFieldNumber = 11;

		public const int CreatedAtFieldNumber = 12;

		private static readonly MessageParser<MST_SKILL> _parser = new MessageParser<MST_SKILL>(() => new MST_SKILL());

		private int id_;

		private int type_;

		private ByteString name_ = ByteString.Empty;

		private ByteString ruby_ = ByteString.Empty;

		private int maxLv_;

		private int iconId_;

		private int motion_;

		private static readonly FieldCodec<int> _repeated_effectList_codec = FieldCodec.ForInt32(66u);

		private readonly RepeatedField<int> effectList_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_actIndividuality_codec = FieldCodec.ForInt32(74u);

		private readonly RepeatedField<int> actIndividuality_ = new RepeatedField<int>();

		private ByteString script_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SKILL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SKILL> Parser => MST_SKILL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSkillReflection.Descriptor.MessageTypes[0];

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
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
		public ByteString Ruby
		{
			get => this.ruby_;
			set
			{
				this.ruby_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int MaxLv
		{
			get => this.maxLv_;
			set
			{
				this.maxLv_ = value;
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
		public int Motion
		{
			get => this.motion_;
			set
			{
				this.motion_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> EffectList => this.effectList_;

		[DebuggerNonUserCode]
		public RepeatedField<int> ActIndividuality => this.actIndividuality_;

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
		public MST_SKILL()
		{
		}

		[DebuggerNonUserCode]
		public MST_SKILL(MST_SKILL other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.name_ = other.name_;
			this.ruby_ = other.ruby_;
			this.maxLv_ = other.maxLv_;
			this.iconId_ = other.iconId_;
			this.motion_ = other.motion_;
			this.effectList_ = other.effectList_.Clone();
			this.actIndividuality_ = other.actIndividuality_.Clone();
			this.script_ = other.script_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SKILL Clone()
		{
			return new MST_SKILL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SKILL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SKILL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Type == other.Type && !(this.Name != other.Name) && !(this.Ruby != other.Ruby) && this.MaxLv == other.MaxLv && this.IconId == other.IconId && this.Motion == other.Motion && this.effectList_.Equals(other.effectList_) && this.actIndividuality_.Equals(other.actIndividuality_) && !(this.Script != other.Script) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Ruby.Length != 0)
			{
				num ^= this.Ruby.GetHashCode();
			}
			if (this.MaxLv != 0)
			{
				num ^= this.MaxLv.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.Motion != 0)
			{
				num ^= this.Motion.GetHashCode();
			}
			num ^= this.effectList_.GetHashCode();
			num ^= this.actIndividuality_.GetHashCode();
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
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.Ruby.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.Ruby);
			}
			if (this.MaxLv != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxLv);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IconId);
			}
			if (this.Motion != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Motion);
			}
			this.effectList_.WriteTo(output, MST_SKILL._repeated_effectList_codec);
			this.actIndividuality_.WriteTo(output, MST_SKILL._repeated_actIndividuality_codec);
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.Script);
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
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Ruby.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Ruby);
			}
			if (this.MaxLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLv);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.Motion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Motion);
			}
			num += this.effectList_.CalculateSize(MST_SKILL._repeated_effectList_codec);
			num += this.actIndividuality_.CalculateSize(MST_SKILL._repeated_actIndividuality_codec);
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
		public void MergeFrom(MST_SKILL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Ruby.Length != 0)
			{
				this.Ruby = other.Ruby;
			}
			if (other.MaxLv != 0)
			{
				this.MaxLv = other.MaxLv;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.Motion != 0)
			{
				this.Motion = other.Motion;
			}
			this.effectList_.Add(other.effectList_);
			this.actIndividuality_.Add(other.actIndividuality_);
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
                    case 0x40:
                    case 0x42:
                        {
                            this.effectList_.AddEntriesFrom(input, _repeated_effectList_codec);
                            continue;
                        }
                    case 0x48:
                    case 0x4a:
                        {
                            this.actIndividuality_.AddEntriesFrom(input, _repeated_actIndividuality_codec);
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
                            this.Type = input.ReadInt32();
                            continue;
                        }
                    case 0x1a:
                        {
                            this.Name = input.ReadBytes();
                            continue;
                        }
                    case 0x22:
                        {
                            this.Ruby = input.ReadBytes();
                            continue;
                        }
                    case 40:
                        {
                            this.MaxLv = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.IconId = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.Motion = input.ReadInt32();
                            continue;
                        }
                    case 0x52:
                        {
                            this.Script = input.ReadBytes();
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
