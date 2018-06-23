using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_TREASURE_DEVICE_LV : IMessage, IMessage<MST_TREASURE_DEVICE_LV>, IEquatable<MST_TREASURE_DEVICE_LV>, IDeepCloneable<MST_TREASURE_DEVICE_LV>
	{
		public const int TreaureDeviceIdFieldNumber = 1;

		public const int LvFieldNumber = 2;

		public const int GaugeCountFieldNumber = 3;

		public const int FuncIdFieldNumber = 4;

		public const int ValsFieldNumber = 5;

		public const int Vals2FieldNumber = 6;

		public const int Vals3FieldNumber = 7;

		public const int Vals4FieldNumber = 8;

		public const int Vals5FieldNumber = 9;

		public const int DetailIdFieldNumber = 10;

		public const int TdPointFieldNumber = 11;

		public const int TdPointQFieldNumber = 12;

		public const int TdPointAFieldNumber = 13;

		public const int TdPointBFieldNumber = 14;

		public const int TdPointExFieldNumber = 15;

		public const int TdPointDefFieldNumber = 16;

		public const int QpFieldNumber = 17;

		public const int UpdatedAtFieldNumber = 18;

		public const int CreatedAtFieldNumber = 19;

		private static readonly MessageParser<MST_TREASURE_DEVICE_LV> _parser = new MessageParser<MST_TREASURE_DEVICE_LV>(() => new MST_TREASURE_DEVICE_LV());

		private int treaureDeviceId_;

		private int lv_;

		private int gaugeCount_;

		private static readonly FieldCodec<int> _repeated_funcId_codec = FieldCodec.ForInt32(34u);

		private readonly RepeatedField<int> funcId_ = new RepeatedField<int>();

		private static readonly FieldCodec<ByteString> _repeated_vals_codec = FieldCodec.ForBytes(42u);

		private readonly RepeatedField<ByteString> vals_ = new RepeatedField<ByteString>();

		private static readonly FieldCodec<ByteString> _repeated_vals2_codec = FieldCodec.ForBytes(50u);

		private readonly RepeatedField<ByteString> vals2_ = new RepeatedField<ByteString>();

		private static readonly FieldCodec<ByteString> _repeated_vals3_codec = FieldCodec.ForBytes(58u);

		private readonly RepeatedField<ByteString> vals3_ = new RepeatedField<ByteString>();

		private static readonly FieldCodec<ByteString> _repeated_vals4_codec = FieldCodec.ForBytes(66u);

		private readonly RepeatedField<ByteString> vals4_ = new RepeatedField<ByteString>();

		private static readonly FieldCodec<ByteString> _repeated_vals5_codec = FieldCodec.ForBytes(74u);

		private readonly RepeatedField<ByteString> vals5_ = new RepeatedField<ByteString>();

		private int detailId_;

		private int tdPoint_;

		private int tdPointQ_;

		private int tdPointA_;

		private int tdPointB_;

		private int tdPointEx_;

		private int tdPointDef_;

		private int qp_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_TREASURE_DEVICE_LV.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_TREASURE_DEVICE_LV> Parser => MST_TREASURE_DEVICE_LV._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstTreasureDeviceLvReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int TreaureDeviceId
		{
			get => this.treaureDeviceId_;
			set
			{
				this.treaureDeviceId_ = value;
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
		public int GaugeCount
		{
			get => this.gaugeCount_;
			set
			{
				this.gaugeCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> FuncId => this.funcId_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals => this.vals_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals2 => this.vals2_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals3 => this.vals3_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals4 => this.vals4_;

		[DebuggerNonUserCode]
		public RepeatedField<ByteString> Vals5 => this.vals5_;

		[DebuggerNonUserCode]
		public int DetailId
		{
			get => this.detailId_;
			set
			{
				this.detailId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdPoint
		{
			get => this.tdPoint_;
			set
			{
				this.tdPoint_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdPointQ
		{
			get => this.tdPointQ_;
			set
			{
				this.tdPointQ_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdPointA
		{
			get => this.tdPointA_;
			set
			{
				this.tdPointA_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdPointB
		{
			get => this.tdPointB_;
			set
			{
				this.tdPointB_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdPointEx
		{
			get => this.tdPointEx_;
			set
			{
				this.tdPointEx_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TdPointDef
		{
			get => this.tdPointDef_;
			set
			{
				this.tdPointDef_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Qp
		{
			get => this.qp_;
			set
			{
				this.qp_ = value;
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
		public MST_TREASURE_DEVICE_LV()
		{
		}

		[DebuggerNonUserCode]
		public MST_TREASURE_DEVICE_LV(MST_TREASURE_DEVICE_LV other) : this()
		{
			this.treaureDeviceId_ = other.treaureDeviceId_;
			this.lv_ = other.lv_;
			this.gaugeCount_ = other.gaugeCount_;
			this.funcId_ = other.funcId_.Clone();
			this.vals_ = other.vals_.Clone();
			this.vals2_ = other.vals2_.Clone();
			this.vals3_ = other.vals3_.Clone();
			this.vals4_ = other.vals4_.Clone();
			this.vals5_ = other.vals5_.Clone();
			this.detailId_ = other.detailId_;
			this.tdPoint_ = other.tdPoint_;
			this.tdPointQ_ = other.tdPointQ_;
			this.tdPointA_ = other.tdPointA_;
			this.tdPointB_ = other.tdPointB_;
			this.tdPointEx_ = other.tdPointEx_;
			this.tdPointDef_ = other.tdPointDef_;
			this.qp_ = other.qp_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_TREASURE_DEVICE_LV Clone()
		{
			return new MST_TREASURE_DEVICE_LV(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_TREASURE_DEVICE_LV);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_TREASURE_DEVICE_LV other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.TreaureDeviceId == other.TreaureDeviceId && this.Lv == other.Lv && this.GaugeCount == other.GaugeCount && this.funcId_.Equals(other.funcId_) && this.vals_.Equals(other.vals_) && this.vals2_.Equals(other.vals2_) && this.vals3_.Equals(other.vals3_) && this.vals4_.Equals(other.vals4_) && this.vals5_.Equals(other.vals5_) && this.DetailId == other.DetailId && this.TdPoint == other.TdPoint && this.TdPointQ == other.TdPointQ && this.TdPointA == other.TdPointA && this.TdPointB == other.TdPointB && this.TdPointEx == other.TdPointEx && this.TdPointDef == other.TdPointDef && this.Qp == other.Qp && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreaureDeviceId != 0)
			{
				num ^= this.TreaureDeviceId.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.GaugeCount != 0)
			{
				num ^= this.GaugeCount.GetHashCode();
			}
			num ^= this.funcId_.GetHashCode();
			num ^= this.vals_.GetHashCode();
			num ^= this.vals2_.GetHashCode();
			num ^= this.vals3_.GetHashCode();
			num ^= this.vals4_.GetHashCode();
			num ^= this.vals5_.GetHashCode();
			if (this.DetailId != 0)
			{
				num ^= this.DetailId.GetHashCode();
			}
			if (this.TdPoint != 0)
			{
				num ^= this.TdPoint.GetHashCode();
			}
			if (this.TdPointQ != 0)
			{
				num ^= this.TdPointQ.GetHashCode();
			}
			if (this.TdPointA != 0)
			{
				num ^= this.TdPointA.GetHashCode();
			}
			if (this.TdPointB != 0)
			{
				num ^= this.TdPointB.GetHashCode();
			}
			if (this.TdPointEx != 0)
			{
				num ^= this.TdPointEx.GetHashCode();
			}
			if (this.TdPointDef != 0)
			{
				num ^= this.TdPointDef.GetHashCode();
			}
			if (this.Qp != 0)
			{
				num ^= this.Qp.GetHashCode();
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
			if (this.TreaureDeviceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreaureDeviceId);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Lv);
			}
			if (this.GaugeCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GaugeCount);
			}
			this.funcId_.WriteTo(output, MST_TREASURE_DEVICE_LV._repeated_funcId_codec);
			this.vals_.WriteTo(output, MST_TREASURE_DEVICE_LV._repeated_vals_codec);
			this.vals2_.WriteTo(output, MST_TREASURE_DEVICE_LV._repeated_vals2_codec);
			this.vals3_.WriteTo(output, MST_TREASURE_DEVICE_LV._repeated_vals3_codec);
			this.vals4_.WriteTo(output, MST_TREASURE_DEVICE_LV._repeated_vals4_codec);
			this.vals5_.WriteTo(output, MST_TREASURE_DEVICE_LV._repeated_vals5_codec);
			if (this.DetailId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DetailId);
			}
			if (this.TdPoint != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TdPoint);
			}
			if (this.TdPointQ != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TdPointQ);
			}
			if (this.TdPointA != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TdPointA);
			}
			if (this.TdPointB != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TdPointB);
			}
			if (this.TdPointEx != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TdPointEx);
			}
			if (this.TdPointDef != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.TdPointDef);
			}
			if (this.Qp != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.Qp);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(144, 1);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(152, 1);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreaureDeviceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreaureDeviceId);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.GaugeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GaugeCount);
			}
			num += this.funcId_.CalculateSize(MST_TREASURE_DEVICE_LV._repeated_funcId_codec);
			num += this.vals_.CalculateSize(MST_TREASURE_DEVICE_LV._repeated_vals_codec);
			num += this.vals2_.CalculateSize(MST_TREASURE_DEVICE_LV._repeated_vals2_codec);
			num += this.vals3_.CalculateSize(MST_TREASURE_DEVICE_LV._repeated_vals3_codec);
			num += this.vals4_.CalculateSize(MST_TREASURE_DEVICE_LV._repeated_vals4_codec);
			num += this.vals5_.CalculateSize(MST_TREASURE_DEVICE_LV._repeated_vals5_codec);
			if (this.DetailId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetailId);
			}
			if (this.TdPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdPoint);
			}
			if (this.TdPointQ != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdPointQ);
			}
			if (this.TdPointA != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdPointA);
			}
			if (this.TdPointB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdPointB);
			}
			if (this.TdPointEx != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TdPointEx);
			}
			if (this.TdPointDef != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TdPointDef);
			}
			if (this.Qp != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Qp);
			}
			if (this.UpdatedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.CreatedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_TREASURE_DEVICE_LV other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreaureDeviceId != 0)
			{
				this.TreaureDeviceId = other.TreaureDeviceId;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.GaugeCount != 0)
			{
				this.GaugeCount = other.GaugeCount;
			}
			this.funcId_.Add(other.funcId_);
			this.vals_.Add(other.vals_);
			this.vals2_.Add(other.vals2_);
			this.vals3_.Add(other.vals3_);
			this.vals4_.Add(other.vals4_);
			this.vals5_.Add(other.vals5_);
			if (other.DetailId != 0)
			{
				this.DetailId = other.DetailId;
			}
			if (other.TdPoint != 0)
			{
				this.TdPoint = other.TdPoint;
			}
			if (other.TdPointQ != 0)
			{
				this.TdPointQ = other.TdPointQ;
			}
			if (other.TdPointA != 0)
			{
				this.TdPointA = other.TdPointA;
			}
			if (other.TdPointB != 0)
			{
				this.TdPointB = other.TdPointB;
			}
			if (other.TdPointEx != 0)
			{
				this.TdPointEx = other.TdPointEx;
			}
			if (other.TdPointDef != 0)
			{
				this.TdPointDef = other.TdPointDef;
			}
			if (other.Qp != 0)
			{
				this.Qp = other.Qp;
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
                            this.TreaureDeviceId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.Lv = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.GaugeCount = input.ReadInt32();
                            continue;
                        }
                    case 0x2a:
                        {
                            this.vals_.AddEntriesFrom(input, _repeated_vals_codec);
                            continue;
                        }
                    case 50:
                        {
                            this.vals2_.AddEntriesFrom(input, _repeated_vals2_codec);
                            continue;
                        }
                    case 0x3a:
                        {
                            this.vals3_.AddEntriesFrom(input, _repeated_vals3_codec);
                            continue;
                        }
                    case 0x42:
                        {
                            this.vals4_.AddEntriesFrom(input, _repeated_vals4_codec);
                            continue;
                        }
                    case 0x4a:
                        {
                            this.vals5_.AddEntriesFrom(input, _repeated_vals5_codec);
                            continue;
                        }
                    case 80:
                        {
                            this.DetailId = input.ReadInt32();
                            continue;
                        }
                    case 0x58:
                        {
                            this.TdPoint = input.ReadInt32();
                            continue;
                        }
                    case 0x60:
                        {
                            this.TdPointQ = input.ReadInt32();
                            continue;
                        }
                    case 0x68:
                        {
                            this.TdPointA = input.ReadInt32();
                            continue;
                        }
                    case 0x70:
                        {
                            this.TdPointB = input.ReadInt32();
                            continue;
                        }
                    case 120:
                        {
                            this.TdPointEx = input.ReadInt32();
                            continue;
                        }
                    case 0x80:
                        {
                            this.TdPointDef = input.ReadInt32();
                            continue;
                        }
                    case 0x88:
                        {
                            this.Qp = input.ReadInt32();
                            continue;
                        }
                    case 0x90:
                        {
                            this.UpdatedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x98:
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
