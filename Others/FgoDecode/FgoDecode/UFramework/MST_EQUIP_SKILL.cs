using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EQUIP_SKILL : IMessage, IMessage<MST_EQUIP_SKILL>, IEquatable<MST_EQUIP_SKILL>, IDeepCloneable<MST_EQUIP_SKILL>
	{
		public const int EquipIdFieldNumber = 1;

		public const int NumFieldNumber = 2;

		public const int SkillIdFieldNumber = 3;

		public const int CondLvFieldNumber = 4;

		public const int UpdatedAtFieldNumber = 5;

		public const int CreatedAtFieldNumber = 6;

		private static readonly MessageParser<MST_EQUIP_SKILL> _parser = new MessageParser<MST_EQUIP_SKILL>(() => new MST_EQUIP_SKILL());

		private int equipId_;

		private int num_;

		private int skillId_;

		private int condLv_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EQUIP_SKILL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EQUIP_SKILL> Parser => MST_EQUIP_SKILL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEquipSkillReflection.Descriptor.MessageTypes[0];

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
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
			}
		}

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
		public int CondLv
		{
			get => this.condLv_;
			set
			{
				this.condLv_ = value;
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
		public MST_EQUIP_SKILL()
		{
		}

		[DebuggerNonUserCode]
		public MST_EQUIP_SKILL(MST_EQUIP_SKILL other) : this()
		{
			this.equipId_ = other.equipId_;
			this.num_ = other.num_;
			this.skillId_ = other.skillId_;
			this.condLv_ = other.condLv_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EQUIP_SKILL Clone()
		{
			return new MST_EQUIP_SKILL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EQUIP_SKILL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EQUIP_SKILL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EquipId == other.EquipId && this.Num == other.Num && this.SkillId == other.SkillId && this.CondLv == other.CondLv && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EquipId != 0)
			{
				num ^= this.EquipId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.CondLv != 0)
			{
				num ^= this.CondLv.GetHashCode();
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
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			if (this.CondLv != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CondLv);
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
			if (this.EquipId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.CondLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondLv);
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
		public void MergeFrom(MST_EQUIP_SKILL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EquipId != 0)
			{
				this.EquipId = other.EquipId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.CondLv != 0)
			{
				this.CondLv = other.CondLv;
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
								this.CondLv = input.ReadInt32();
							}
						}
						else
						{
							this.SkillId = input.ReadInt32();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
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
