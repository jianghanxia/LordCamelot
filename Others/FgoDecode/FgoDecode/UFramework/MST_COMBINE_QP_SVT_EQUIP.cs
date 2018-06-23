using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_COMBINE_QP_SVT_EQUIP : IMessage, IMessage<MST_COMBINE_QP_SVT_EQUIP>, IEquatable<MST_COMBINE_QP_SVT_EQUIP>, IDeepCloneable<MST_COMBINE_QP_SVT_EQUIP>
	{
		public const int RarityFieldNumber = 1;

		public const int LvFieldNumber = 2;

		public const int QpFieldNumber = 3;

		public const int UpdatedAtFieldNumber = 4;

		public const int CreatedAtFieldNumber = 5;

		private static readonly MessageParser<MST_COMBINE_QP_SVT_EQUIP> _parser = new MessageParser<MST_COMBINE_QP_SVT_EQUIP>(() => new MST_COMBINE_QP_SVT_EQUIP());

		private int rarity_;

		private int lv_;

		private int qp_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_COMBINE_QP_SVT_EQUIP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_COMBINE_QP_SVT_EQUIP> Parser => MST_COMBINE_QP_SVT_EQUIP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCombineQpSvtEquipReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Rarity
		{
			get => this.rarity_;
			set
			{
				this.rarity_ = value;
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
		public MST_COMBINE_QP_SVT_EQUIP()
		{
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_QP_SVT_EQUIP(MST_COMBINE_QP_SVT_EQUIP other) : this()
		{
			this.rarity_ = other.rarity_;
			this.lv_ = other.lv_;
			this.qp_ = other.qp_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_QP_SVT_EQUIP Clone()
		{
			return new MST_COMBINE_QP_SVT_EQUIP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_COMBINE_QP_SVT_EQUIP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_COMBINE_QP_SVT_EQUIP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Rarity == other.Rarity && this.Lv == other.Lv && this.Qp == other.Qp && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rarity != 0)
			{
				num ^= this.Rarity.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
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
			if (this.Rarity != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Rarity);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Lv);
			}
			if (this.Qp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Qp);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Rarity != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rarity);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.Qp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Qp);
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
		public void MergeFrom(MST_COMBINE_QP_SVT_EQUIP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rarity != 0)
			{
				this.Rarity = other.Rarity;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
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
							this.Qp = input.ReadInt32();
						}
					}
					else
					{
						this.Lv = input.ReadInt32();
					}
				}
				else
				{
					this.Rarity = input.ReadInt32();
				}
			}
		}
	}
}
