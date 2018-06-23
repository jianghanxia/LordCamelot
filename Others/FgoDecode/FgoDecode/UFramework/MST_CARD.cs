using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CARD : IMessage, IMessage<MST_CARD>, IEquatable<MST_CARD>, IDeepCloneable<MST_CARD>
	{
		public const int IdFieldNumber = 1;

		public const int NumFieldNumber = 2;

		public const int AdjustAtkFieldNumber = 3;

		public const int AdjustTdGaugeFieldNumber = 4;

		public const int AdjustCriticalFieldNumber = 5;

		public const int AddAtkFieldNumber = 6;

		public const int AddTdGaugeFieldNumber = 7;

		public const int AddCriticalFieldNumber = 8;

		public const int IndividualityFieldNumber = 9;

		private static readonly MessageParser<MST_CARD> _parser = new MessageParser<MST_CARD>(() => new MST_CARD());

		private int id_;

		private int num_;

		private int adjustAtk_;

		private int adjustTdGauge_;

		private int adjustCritical_;

		private int addAtk_;

		private int addTdGauge_;

		private int addCritical_;

		private static readonly FieldCodec<int> _repeated_individuality_codec = FieldCodec.ForInt32(74u);

		private readonly RepeatedField<int> individuality_ = new RepeatedField<int>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CARD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CARD> Parser => MST_CARD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCardReflection.Descriptor.MessageTypes[0];

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
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AdjustAtk
		{
			get => this.adjustAtk_;
			set
			{
				this.adjustAtk_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AdjustTdGauge
		{
			get => this.adjustTdGauge_;
			set
			{
				this.adjustTdGauge_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AdjustCritical
		{
			get => this.adjustCritical_;
			set
			{
				this.adjustCritical_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddAtk
		{
			get => this.addAtk_;
			set
			{
				this.addAtk_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddTdGauge
		{
			get => this.addTdGauge_;
			set
			{
				this.addTdGauge_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddCritical
		{
			get => this.addCritical_;
			set
			{
				this.addCritical_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> Individuality => this.individuality_;

		[DebuggerNonUserCode]
		public MST_CARD()
		{
		}

		[DebuggerNonUserCode]
		public MST_CARD(MST_CARD other) : this()
		{
			this.id_ = other.id_;
			this.num_ = other.num_;
			this.adjustAtk_ = other.adjustAtk_;
			this.adjustTdGauge_ = other.adjustTdGauge_;
			this.adjustCritical_ = other.adjustCritical_;
			this.addAtk_ = other.addAtk_;
			this.addTdGauge_ = other.addTdGauge_;
			this.addCritical_ = other.addCritical_;
			this.individuality_ = other.individuality_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_CARD Clone()
		{
			return new MST_CARD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CARD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CARD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Num == other.Num && this.AdjustAtk == other.AdjustAtk && this.AdjustTdGauge == other.AdjustTdGauge && this.AdjustCritical == other.AdjustCritical && this.AddAtk == other.AddAtk && this.AddTdGauge == other.AddTdGauge && this.AddCritical == other.AddCritical && this.individuality_.Equals(other.individuality_)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.AdjustAtk != 0)
			{
				num ^= this.AdjustAtk.GetHashCode();
			}
			if (this.AdjustTdGauge != 0)
			{
				num ^= this.AdjustTdGauge.GetHashCode();
			}
			if (this.AdjustCritical != 0)
			{
				num ^= this.AdjustCritical.GetHashCode();
			}
			if (this.AddAtk != 0)
			{
				num ^= this.AddAtk.GetHashCode();
			}
			if (this.AddTdGauge != 0)
			{
				num ^= this.AddTdGauge.GetHashCode();
			}
			if (this.AddCritical != 0)
			{
				num ^= this.AddCritical.GetHashCode();
			}
			return num ^ this.individuality_.GetHashCode();
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
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.AdjustAtk != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AdjustAtk);
			}
			if (this.AdjustTdGauge != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AdjustTdGauge);
			}
			if (this.AdjustCritical != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AdjustCritical);
			}
			if (this.AddAtk != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.AddAtk);
			}
			if (this.AddTdGauge != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.AddTdGauge);
			}
			if (this.AddCritical != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.AddCritical);
			}
			this.individuality_.WriteTo(output, MST_CARD._repeated_individuality_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.AdjustAtk != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdjustAtk);
			}
			if (this.AdjustTdGauge != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdjustTdGauge);
			}
			if (this.AdjustCritical != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AdjustCritical);
			}
			if (this.AddAtk != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddAtk);
			}
			if (this.AddTdGauge != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddTdGauge);
			}
			if (this.AddCritical != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddCritical);
			}
			return num + this.individuality_.CalculateSize(MST_CARD._repeated_individuality_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_CARD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.AdjustAtk != 0)
			{
				this.AdjustAtk = other.AdjustAtk;
			}
			if (other.AdjustTdGauge != 0)
			{
				this.AdjustTdGauge = other.AdjustTdGauge;
			}
			if (other.AdjustCritical != 0)
			{
				this.AdjustCritical = other.AdjustCritical;
			}
			if (other.AddAtk != 0)
			{
				this.AddAtk = other.AddAtk;
			}
			if (other.AddTdGauge != 0)
			{
				this.AddTdGauge = other.AddTdGauge;
			}
			if (other.AddCritical != 0)
			{
				this.AddCritical = other.AddCritical;
			}
			this.individuality_.Add(other.individuality_);
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
                    case 0x48:
                    case 0x4a:
                        break;

                    default:
                        switch (num2)
                        {
                            case 8:
                                {
                                    this.Id = input.ReadInt32();
                                    continue;
                                }
                            case 0x10:
                                {
                                    this.Num = input.ReadInt32();
                                    continue;
                                }
                            case 0x18:
                                {
                                    this.AdjustAtk = input.ReadInt32();
                                    continue;
                                }
                            case 0x20:
                                {
                                    this.AdjustTdGauge = input.ReadInt32();
                                    continue;
                                }
                            case 40:
                                {
                                    this.AdjustCritical = input.ReadInt32();
                                    continue;
                                }
                            case 0x30:
                                {
                                    this.AddAtk = input.ReadInt32();
                                    continue;
                                }
                            case 0x38:
                                {
                                    this.AddTdGauge = input.ReadInt32();
                                    continue;
                                }
                            case 0x40:
                                {
                                    this.AddCritical = input.ReadInt32();
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
                this.individuality_.AddEntriesFrom(input, _repeated_individuality_codec);
            }
        }


    }
}
