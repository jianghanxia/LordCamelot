using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_FUNC : IMessage, IMessage<MST_FUNC>, IEquatable<MST_FUNC>, IDeepCloneable<MST_FUNC>
	{
		public const int IdFieldNumber = 1;

		public const int CondFieldNumber = 2;

		public const int FuncTypeFieldNumber = 3;

		public const int ValsFieldNumber = 4;

		public const int TargetTypeFieldNumber = 5;

		public const int TvalsFieldNumber = 6;

		public const int QuestTvalsFieldNumber = 7;

		public const int EffectListFieldNumber = 8;

		public const int ApplyTargetFieldNumber = 9;

		public const int PopupIconIdFieldNumber = 10;

		public const int PopupTextFieldNumber = 11;

		public const int PopupTextColorFieldNumber = 12;

		private static readonly MessageParser<MST_FUNC> _parser = new MessageParser<MST_FUNC>(() => new MST_FUNC());

		private int id_;

		private int cond_;

		private int funcType_;

		private static readonly FieldCodec<int> _repeated_vals_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> vals_ = new RepeatedField<int>();

		private int targetType_;

		private static readonly FieldCodec<int> _repeated_tvals_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> tvals_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_questTvals_codec = FieldCodec.ForInt32(58u);

		private readonly RepeatedField<int> questTvals_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_effectList_codec = FieldCodec.ForInt32(66u);

		private readonly RepeatedField<int> effectList_ = new RepeatedField<int>();

		private int applyTarget_;

		private int popupIconId_;

		private ByteString popupText_ = ByteString.Empty;

		private int popupTextColor_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_FUNC.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_FUNC> Parser => MST_FUNC._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstFuncReflection.Descriptor.MessageTypes[0];

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
		public int Cond
		{
			get => this.cond_;
			set
			{
				this.cond_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FuncType
		{
			get => this.funcType_;
			set
			{
				this.funcType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Vals => this.vals_;

		[DebuggerNonUserCode]
		public int TargetType
		{
			get => this.targetType_;
			set
			{
				this.targetType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Tvals => this.tvals_;

		[DebuggerNonUserCode]
		public RepeatedField<int> QuestTvals => this.questTvals_;

		[DebuggerNonUserCode]
		public RepeatedField<int> EffectList => this.effectList_;

		[DebuggerNonUserCode]
		public int ApplyTarget
		{
			get => this.applyTarget_;
			set
			{
				this.applyTarget_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int PopupIconId
		{
			get => this.popupIconId_;
			set
			{
				this.popupIconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString PopupText
		{
			get => this.popupText_;
			set
			{
				this.popupText_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int PopupTextColor
		{
			get => this.popupTextColor_;
			set
			{
				this.popupTextColor_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_FUNC()
		{
		}

		[DebuggerNonUserCode]
		public MST_FUNC(MST_FUNC other) : this()
		{
			this.id_ = other.id_;
			this.cond_ = other.cond_;
			this.funcType_ = other.funcType_;
			this.vals_ = other.vals_.Clone();
			this.targetType_ = other.targetType_;
			this.tvals_ = other.tvals_.Clone();
			this.questTvals_ = other.questTvals_.Clone();
			this.effectList_ = other.effectList_.Clone();
			this.applyTarget_ = other.applyTarget_;
			this.popupIconId_ = other.popupIconId_;
			this.popupText_ = other.popupText_;
			this.popupTextColor_ = other.popupTextColor_;
		}

		[DebuggerNonUserCode]
		public MST_FUNC Clone()
		{
			return new MST_FUNC(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_FUNC);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_FUNC other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Cond == other.Cond && this.FuncType == other.FuncType && this.vals_.Equals(other.vals_) && this.TargetType == other.TargetType && this.tvals_.Equals(other.tvals_) && this.questTvals_.Equals(other.questTvals_) && this.effectList_.Equals(other.effectList_) && this.ApplyTarget == other.ApplyTarget && this.PopupIconId == other.PopupIconId && !(this.PopupText != other.PopupText) && this.PopupTextColor == other.PopupTextColor));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Cond != 0)
			{
				num ^= this.Cond.GetHashCode();
			}
			if (this.FuncType != 0)
			{
				num ^= this.FuncType.GetHashCode();
			}
			num ^= this.vals_.GetHashCode();
			if (this.TargetType != 0)
			{
				num ^= this.TargetType.GetHashCode();
			}
			num ^= this.tvals_.GetHashCode();
			num ^= this.questTvals_.GetHashCode();
			num ^= this.effectList_.GetHashCode();
			if (this.ApplyTarget != 0)
			{
				num ^= this.ApplyTarget.GetHashCode();
			}
			if (this.PopupIconId != 0)
			{
				num ^= this.PopupIconId.GetHashCode();
			}
			if (this.PopupText.Length != 0)
			{
				num ^= this.PopupText.GetHashCode();
			}
			if (this.PopupTextColor != 0)
			{
				num ^= this.PopupTextColor.GetHashCode();
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
			if (this.Cond != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Cond);
			}
			if (this.FuncType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FuncType);
			}
			this.vals_.WriteTo(output, MST_FUNC._repeated_vals_codec);
			if (this.TargetType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TargetType);
			}
			this.tvals_.WriteTo(output, MST_FUNC._repeated_tvals_codec);
			this.questTvals_.WriteTo(output, MST_FUNC._repeated_questTvals_codec);
			this.effectList_.WriteTo(output, MST_FUNC._repeated_effectList_codec);
			if (this.ApplyTarget != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ApplyTarget);
			}
			if (this.PopupIconId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PopupIconId);
			}
			if (this.PopupText.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteBytes(this.PopupText);
			}
			if (this.PopupTextColor != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PopupTextColor);
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
			if (this.Cond != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cond);
			}
			if (this.FuncType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncType);
			}
			num += this.vals_.CalculateSize(MST_FUNC._repeated_vals_codec);
			if (this.TargetType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetType);
			}
			num += this.tvals_.CalculateSize(MST_FUNC._repeated_tvals_codec);
			num += this.questTvals_.CalculateSize(MST_FUNC._repeated_questTvals_codec);
			num += this.effectList_.CalculateSize(MST_FUNC._repeated_effectList_codec);
			if (this.ApplyTarget != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ApplyTarget);
			}
			if (this.PopupIconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PopupIconId);
			}
			if (this.PopupText.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.PopupText);
			}
			if (this.PopupTextColor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PopupTextColor);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_FUNC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Cond != 0)
			{
				this.Cond = other.Cond;
			}
			if (other.FuncType != 0)
			{
				this.FuncType = other.FuncType;
			}
			this.vals_.Add(other.vals_);
			if (other.TargetType != 0)
			{
				this.TargetType = other.TargetType;
			}
			this.tvals_.Add(other.tvals_);
			this.questTvals_.Add(other.questTvals_);
			this.effectList_.Add(other.effectList_);
			if (other.ApplyTarget != 0)
			{
				this.ApplyTarget = other.ApplyTarget;
			}
			if (other.PopupIconId != 0)
			{
				this.PopupIconId = other.PopupIconId;
			}
			if (other.PopupText.Length != 0)
			{
				this.PopupText = other.PopupText;
			}
			if (other.PopupTextColor != 0)
			{
				this.PopupTextColor = other.PopupTextColor;
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
                    case 0x30:
                    case 50:
                        {
                            this.tvals_.AddEntriesFrom(input, _repeated_tvals_codec);
                            continue;
                        }
                    case 0x38:
                    case 0x3a:
                        {
                            this.questTvals_.AddEntriesFrom(input, _repeated_questTvals_codec);
                            continue;
                        }
                    case 0x40:
                    case 0x42:
                        {
                            this.effectList_.AddEntriesFrom(input, _repeated_effectList_codec);
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
                            this.Cond = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.FuncType = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.TargetType = input.ReadInt32();
                            continue;
                        }
                    case 0x48:
                        {
                            this.ApplyTarget = input.ReadInt32();
                            continue;
                        }
                    case 80:
                        {
                            this.PopupIconId = input.ReadInt32();
                            continue;
                        }
                    case 90:
                        {
                            this.PopupText = input.ReadBytes();
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
                this.PopupTextColor = input.ReadInt32();
            }
        }


    }
}
