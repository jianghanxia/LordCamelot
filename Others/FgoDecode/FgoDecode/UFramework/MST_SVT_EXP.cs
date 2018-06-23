using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_EXP : IMessage, IMessage<MST_SVT_EXP>, IEquatable<MST_SVT_EXP>, IDeepCloneable<MST_SVT_EXP>
	{
		public const int TypeFieldNumber = 1;

		public const int LvFieldNumber = 2;

		public const int ExpFieldNumber = 3;

		public const int CurveFieldNumber = 4;

		public const int UpdatedAtFieldNumber = 5;

		public const int CreatedAtFieldNumber = 6;

		private static readonly MessageParser<MST_SVT_EXP> _parser = new MessageParser<MST_SVT_EXP>(() => new MST_SVT_EXP());

		private int type_;

		private int lv_;

		private int exp_;

		private int curve_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_EXP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_EXP> Parser => MST_SVT_EXP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtExpReflection.Descriptor.MessageTypes[0];

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
		public int Lv
		{
			get => this.lv_;
			set
			{
				this.lv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Exp
		{
			get => this.exp_;
			set
			{
				this.exp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Curve
		{
			get => this.curve_;
			set
			{
				this.curve_ = value;
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
		public MST_SVT_EXP()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_EXP(MST_SVT_EXP other) : this()
		{
			this.type_ = other.type_;
			this.lv_ = other.lv_;
			this.exp_ = other.exp_;
			this.curve_ = other.curve_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_EXP Clone()
		{
			return new MST_SVT_EXP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_EXP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_EXP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Type == other.Type && this.Lv == other.Lv && this.Exp == other.Exp && this.Curve == other.Curve && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.Curve != 0)
			{
				num ^= this.Curve.GetHashCode();
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
			if (this.Type != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Type);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Lv);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Exp);
			}
			if (this.Curve != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Curve);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.Curve != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Curve);
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
		public void MergeFrom(MST_SVT_EXP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.Curve != 0)
			{
				this.Curve = other.Curve;
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
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 8u)
				{
					if (num2 != 16u)
					{
						if (num2 != 24u)
						{
							if (num2 != 32u)
							{
								if (num2 != 40u)
								{
									if (num2 != 48u)
									{
										input.SkipLastField();
									}
									else
									{
										this.CreatedAt = input.ReadUInt64();
									}
								}
								else
								{
									this.UpdatedAt = input.ReadUInt64();
								}
							}
							else
							{
								this.Curve = input.ReadInt32();
							}
						}
						else
						{
							this.Exp = input.ReadInt32();
						}
					}
					else
					{
						this.Lv = input.ReadInt32();
					}
				}
				else
				{
					this.Type = input.ReadInt32();
				}
			}
		}
	}
}
