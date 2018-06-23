using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EQUIP_EXP : IMessage, IMessage<MST_EQUIP_EXP>, IEquatable<MST_EQUIP_EXP>, IDeepCloneable<MST_EQUIP_EXP>
	{
		public const int EquipIdFieldNumber = 1;

		public const int LvFieldNumber = 2;

		public const int ExpFieldNumber = 3;

		public const int SkillLv1FieldNumber = 4;

		public const int SkillLv2FieldNumber = 5;

		public const int SkillLv3FieldNumber = 6;

		public const int UpdatedAtFieldNumber = 7;

		public const int CreatedAtFieldNumber = 8;

		private static readonly MessageParser<MST_EQUIP_EXP> _parser = new MessageParser<MST_EQUIP_EXP>(() => new MST_EQUIP_EXP());

		private int equipId_;

		private int lv_;

		private int exp_;

		private int skillLv1_;

		private int skillLv2_;

		private int skillLv3_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EQUIP_EXP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EQUIP_EXP> Parser => MST_EQUIP_EXP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEquipExpReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int EquipId
		{
			get => this.equipId_;
			set
			{
				this.equipId_ = value;
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
		public int SkillLv1
		{
			get => this.skillLv1_;
			set
			{
				this.skillLv1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillLv2
		{
			get => this.skillLv2_;
			set
			{
				this.skillLv2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SkillLv3
		{
			get => this.skillLv3_;
			set
			{
				this.skillLv3_ = value;
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
		public MST_EQUIP_EXP()
		{
		}

		[DebuggerNonUserCode]
		public MST_EQUIP_EXP(MST_EQUIP_EXP other) : this()
		{
			this.equipId_ = other.equipId_;
			this.lv_ = other.lv_;
			this.exp_ = other.exp_;
			this.skillLv1_ = other.skillLv1_;
			this.skillLv2_ = other.skillLv2_;
			this.skillLv3_ = other.skillLv3_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EQUIP_EXP Clone()
		{
			return new MST_EQUIP_EXP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EQUIP_EXP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EQUIP_EXP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EquipId == other.EquipId && this.Lv == other.Lv && this.Exp == other.Exp && this.SkillLv1 == other.SkillLv1 && this.SkillLv2 == other.SkillLv2 && this.SkillLv3 == other.SkillLv3 && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EquipId != 0)
			{
				num ^= this.EquipId.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.SkillLv1 != 0)
			{
				num ^= this.SkillLv1.GetHashCode();
			}
			if (this.SkillLv2 != 0)
			{
				num ^= this.SkillLv2.GetHashCode();
			}
			if (this.SkillLv3 != 0)
			{
				num ^= this.SkillLv3.GetHashCode();
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
			if (this.EquipId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EquipId);
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
			if (this.SkillLv1 != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillLv1);
			}
			if (this.SkillLv2 != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillLv2);
			}
			if (this.SkillLv3 != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SkillLv3);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EquipId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipId);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.SkillLv1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLv1);
			}
			if (this.SkillLv2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLv2);
			}
			if (this.SkillLv3 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillLv3);
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
		public void MergeFrom(MST_EQUIP_EXP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EquipId != 0)
			{
				this.EquipId = other.EquipId;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.SkillLv1 != 0)
			{
				this.SkillLv1 = other.SkillLv1;
			}
			if (other.SkillLv2 != 0)
			{
				this.SkillLv2 = other.SkillLv2;
			}
			if (other.SkillLv3 != 0)
			{
				this.SkillLv3 = other.SkillLv3;
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
										if (num2 != 56u)
										{
											if (num2 != 64u)
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
										this.SkillLv3 = input.ReadInt32();
									}
								}
								else
								{
									this.SkillLv2 = input.ReadInt32();
								}
							}
							else
							{
								this.SkillLv1 = input.ReadInt32();
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
					this.EquipId = input.ReadInt32();
				}
			}
		}
	}
}
