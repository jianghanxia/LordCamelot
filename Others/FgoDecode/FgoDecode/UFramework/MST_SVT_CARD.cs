using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_CARD : IMessage, IMessage<MST_SVT_CARD>, IEquatable<MST_SVT_CARD>, IDeepCloneable<MST_SVT_CARD>
	{
		public const int SvtIdFieldNumber = 1;

		public const int CardIdFieldNumber = 2;

		public const int MotionFieldNumber = 3;

		public const int NormalDamageFieldNumber = 4;

		public const int SingleDamageFieldNumber = 5;

		public const int TrinityDamageFieldNumber = 6;

		public const int UnisonDamageFieldNumber = 7;

		public const int GrandDamageFieldNumber = 8;

		public const int AttackTypeFieldNumber = 9;

		public const int AttackIndividualityFieldNumber = 10;

		private static readonly MessageParser<MST_SVT_CARD> _parser = new MessageParser<MST_SVT_CARD>(() => new MST_SVT_CARD());

		private int svtId_;

		private int cardId_;

		private int motion_;

		private static readonly FieldCodec<int> _repeated_normalDamage_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> normalDamage_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_singleDamage_codec = FieldCodec.ForInt32(42u);

		private readonly RepeatedField<int> singleDamage_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_trinityDamage_codec = FieldCodec.ForInt32(50u);

		private readonly RepeatedField<int> trinityDamage_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_unisonDamage_codec = FieldCodec.ForInt32(58u);

		private readonly RepeatedField<int> unisonDamage_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_grandDamage_codec = FieldCodec.ForInt32(66u);

		private readonly RepeatedField<int> grandDamage_ = new RepeatedField<int>();

		private int attackType_;

		private static readonly FieldCodec<int> _repeated_attackIndividuality_codec = FieldCodec.ForInt32(82u);

		private readonly RepeatedField<int> attackIndividuality_ = new RepeatedField<int>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_CARD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_CARD> Parser => MST_SVT_CARD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtCardReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int SvtId
		{
			get => this.svtId_;
			set
			{
				this.svtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CardId
		{
			get => this.cardId_;
			set
			{
				this.cardId_ = value;
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
		public RepeatedField<int> NormalDamage => this.normalDamage_;

		[DebuggerNonUserCode]
		public RepeatedField<int> SingleDamage => this.singleDamage_;

		[DebuggerNonUserCode]
		public RepeatedField<int> TrinityDamage => this.trinityDamage_;

		[DebuggerNonUserCode]
		public RepeatedField<int> UnisonDamage => this.unisonDamage_;

		[DebuggerNonUserCode]
		public RepeatedField<int> GrandDamage => this.grandDamage_;

		[DebuggerNonUserCode]
		public int AttackType
		{
			get => this.attackType_;
			set
			{
				this.attackType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> AttackIndividuality => this.attackIndividuality_;

		[DebuggerNonUserCode]
		public MST_SVT_CARD()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_CARD(MST_SVT_CARD other) : this()
		{
			this.svtId_ = other.svtId_;
			this.cardId_ = other.cardId_;
			this.motion_ = other.motion_;
			this.normalDamage_ = other.normalDamage_.Clone();
			this.singleDamage_ = other.singleDamage_.Clone();
			this.trinityDamage_ = other.trinityDamage_.Clone();
			this.unisonDamage_ = other.unisonDamage_.Clone();
			this.grandDamage_ = other.grandDamage_.Clone();
			this.attackType_ = other.attackType_;
			this.attackIndividuality_ = other.attackIndividuality_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_SVT_CARD Clone()
		{
			return new MST_SVT_CARD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_CARD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_CARD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.CardId == other.CardId && this.Motion == other.Motion && this.normalDamage_.Equals(other.normalDamage_) && this.singleDamage_.Equals(other.singleDamage_) && this.trinityDamage_.Equals(other.trinityDamage_) && this.unisonDamage_.Equals(other.unisonDamage_) && this.grandDamage_.Equals(other.grandDamage_) && this.AttackType == other.AttackType && this.attackIndividuality_.Equals(other.attackIndividuality_)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this.Motion != 0)
			{
				num ^= this.Motion.GetHashCode();
			}
			num ^= this.normalDamage_.GetHashCode();
			num ^= this.singleDamage_.GetHashCode();
			num ^= this.trinityDamage_.GetHashCode();
			num ^= this.unisonDamage_.GetHashCode();
			num ^= this.grandDamage_.GetHashCode();
			if (this.AttackType != 0)
			{
				num ^= this.AttackType.GetHashCode();
			}
			return num ^ this.attackIndividuality_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (this.SvtId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SvtId);
			}
			if (this.CardId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardId);
			}
			if (this.Motion != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Motion);
			}
			this.normalDamage_.WriteTo(output, MST_SVT_CARD._repeated_normalDamage_codec);
			this.singleDamage_.WriteTo(output, MST_SVT_CARD._repeated_singleDamage_codec);
			this.trinityDamage_.WriteTo(output, MST_SVT_CARD._repeated_trinityDamage_codec);
			this.unisonDamage_.WriteTo(output, MST_SVT_CARD._repeated_unisonDamage_codec);
			this.grandDamage_.WriteTo(output, MST_SVT_CARD._repeated_grandDamage_codec);
			if (this.AttackType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.AttackType);
			}
			this.attackIndividuality_.WriteTo(output, MST_SVT_CARD._repeated_attackIndividuality_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this.Motion != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Motion);
			}
			num += this.normalDamage_.CalculateSize(MST_SVT_CARD._repeated_normalDamage_codec);
			num += this.singleDamage_.CalculateSize(MST_SVT_CARD._repeated_singleDamage_codec);
			num += this.trinityDamage_.CalculateSize(MST_SVT_CARD._repeated_trinityDamage_codec);
			num += this.unisonDamage_.CalculateSize(MST_SVT_CARD._repeated_unisonDamage_codec);
			num += this.grandDamage_.CalculateSize(MST_SVT_CARD._repeated_grandDamage_codec);
			if (this.AttackType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttackType);
			}
			return num + this.attackIndividuality_.CalculateSize(MST_SVT_CARD._repeated_attackIndividuality_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_CARD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			if (other.Motion != 0)
			{
				this.Motion = other.Motion;
			}
			this.normalDamage_.Add(other.normalDamage_);
			this.singleDamage_.Add(other.singleDamage_);
			this.trinityDamage_.Add(other.trinityDamage_);
			this.unisonDamage_.Add(other.unisonDamage_);
			this.grandDamage_.Add(other.grandDamage_);
			if (other.AttackType != 0)
			{
				this.AttackType = other.AttackType;
			}
			this.attackIndividuality_.Add(other.attackIndividuality_);
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
                            this.normalDamage_.AddEntriesFrom(input, _repeated_normalDamage_codec);
                            continue;
                        }
                    case 40:
                    case 0x2a:
                        {
                            this.singleDamage_.AddEntriesFrom(input, _repeated_singleDamage_codec);
                            continue;
                        }
                    case 0x30:
                    case 50:
                        {
                            this.trinityDamage_.AddEntriesFrom(input, _repeated_trinityDamage_codec);
                            continue;
                        }
                    case 0x38:
                    case 0x3a:
                        {
                            this.unisonDamage_.AddEntriesFrom(input, _repeated_unisonDamage_codec);
                            continue;
                        }
                    case 0x40:
                    case 0x42:
                        {
                            this.grandDamage_.AddEntriesFrom(input, _repeated_grandDamage_codec);
                            continue;
                        }
                    case 80:
                    case 0x52:
                        break;

                    default:
                        switch (num2)
                        {
                            case 8:
                                {
                                    this.SvtId = input.ReadInt32();
                                    continue;
                                }
                            case 0x10:
                                {
                                    this.CardId = input.ReadInt32();
                                    continue;
                                }
                            case 0x18:
                                {
                                    this.Motion = input.ReadInt32();
                                    continue;
                                }
                            case 0x48:
                                {
                                    this.AttackType = input.ReadInt32();
                                    continue;
                                }
                            default:
                                {
                                    input.SkipLastField();
                                    continue;
                                }
                        }
                        break;
                }
                this.attackIndividuality_.AddEntriesFrom(input, _repeated_attackIndividuality_codec);
            }
        }


    }
}
