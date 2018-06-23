using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_SKILL : IMessage, IMessage<MST_SVT_SKILL>, IEquatable<MST_SVT_SKILL>, IDeepCloneable<MST_SVT_SKILL>
	{
		public const int SvtIdFieldNumber = 1;

		public const int NumFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int SkillIdFieldNumber = 4;

		public const int CondQuestIdFieldNumber = 5;

		public const int CondLvFieldNumber = 6;

		public const int CondLimitCountFieldNumber = 7;

		public const int UpdatedAtFieldNumber = 8;

		public const int CreatedAtFieldNumber = 9;

		private static readonly MessageParser<MST_SVT_SKILL> _parser = new MessageParser<MST_SVT_SKILL>(() => new MST_SVT_SKILL());

		private int svtId_;

		private int num_;

		private int priority_;

		private int skillId_;

		private int condQuestId_;

		private int condLv_;

		private int condLimitCount_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_SKILL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_SKILL> Parser => MST_SVT_SKILL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtSkillReflection.Descriptor.MessageTypes[0];

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
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
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
		public int CondQuestId
		{
			get => this.condQuestId_;
			set
			{
				this.condQuestId_ = value;
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
		public int CondLimitCount
		{
			get => this.condLimitCount_;
			set
			{
				this.condLimitCount_ = value;
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
		public MST_SVT_SKILL()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_SKILL(MST_SVT_SKILL other) : this()
		{
			this.svtId_ = other.svtId_;
			this.num_ = other.num_;
			this.priority_ = other.priority_;
			this.skillId_ = other.skillId_;
			this.condQuestId_ = other.condQuestId_;
			this.condLv_ = other.condLv_;
			this.condLimitCount_ = other.condLimitCount_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_SKILL Clone()
		{
			return new MST_SVT_SKILL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_SKILL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_SKILL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.Num == other.Num && this.Priority == other.Priority && this.SkillId == other.SkillId && this.CondQuestId == other.CondQuestId && this.CondLv == other.CondLv && this.CondLimitCount == other.CondLimitCount && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.CondQuestId != 0)
			{
				num ^= this.CondQuestId.GetHashCode();
			}
			if (this.CondLv != 0)
			{
				num ^= this.CondLv.GetHashCode();
			}
			if (this.CondLimitCount != 0)
			{
				num ^= this.CondLimitCount.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SvtId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Priority);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillId);
			}
			if (this.CondQuestId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CondQuestId);
			}
			if (this.CondLv != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CondLv);
			}
			if (this.CondLimitCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CondLimitCount);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.CondQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestId);
			}
			if (this.CondLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondLv);
			}
			if (this.CondLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondLimitCount);
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
		public void MergeFrom(MST_SVT_SKILL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.CondQuestId != 0)
			{
				this.CondQuestId = other.CondQuestId;
			}
			if (other.CondLv != 0)
			{
				this.CondLv = other.CondLv;
			}
			if (other.CondLimitCount != 0)
			{
				this.CondLimitCount = other.CondLimitCount;
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
												if (num2 != 72u)
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
											this.CondLimitCount = input.ReadInt32();
										}
									}
									else
									{
										this.CondLv = input.ReadInt32();
									}
								}
								else
								{
									this.CondQuestId = input.ReadInt32();
								}
							}
							else
							{
								this.SkillId = input.ReadInt32();
							}
						}
						else
						{
							this.Priority = input.ReadInt32();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.SvtId = input.ReadInt32();
				}
			}
		}
	}
}
