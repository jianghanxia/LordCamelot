using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_PASSIVE_SKILL : IMessage, IMessage<MST_SVT_PASSIVE_SKILL>, IEquatable<MST_SVT_PASSIVE_SKILL>, IDeepCloneable<MST_SVT_PASSIVE_SKILL>
	{
		public const int SvtIdFieldNumber = 1;

		public const int NumFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int SkillIdFieldNumber = 4;

		public const int CondQuestIdFieldNumber = 5;

		public const int CondQuestPhaseFieldNumber = 6;

		public const int CondLvFieldNumber = 7;

		public const int CondLimitCountFieldNumber = 8;

		public const int CondFriendshipRankFieldNumber = 9;

		public const int StartedAtFieldNumber = 10;

		public const int EndedAtFieldNumber = 11;

		private static readonly MessageParser<MST_SVT_PASSIVE_SKILL> _parser = new MessageParser<MST_SVT_PASSIVE_SKILL>(() => new MST_SVT_PASSIVE_SKILL());

		private int svtId_;

		private int num_;

		private int priority_;

		private int skillId_;

		private int condQuestId_;

		private int condQuestPhase_;

		private int condLv_;

		private int condLimitCount_;

		private int condFriendshipRank_;

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_PASSIVE_SKILL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_PASSIVE_SKILL> Parser => MST_SVT_PASSIVE_SKILL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtPassiveSkillReflection.Descriptor.MessageTypes[0];

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
		public int CondQuestPhase
		{
			get => this.condQuestPhase_;
			set
			{
				this.condQuestPhase_ = value;
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
		public int CondFriendshipRank
		{
			get => this.condFriendshipRank_;
			set
			{
				this.condFriendshipRank_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong StartedAt
		{
			get => this.startedAt_;
			set
			{
				this.startedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong EndedAt
		{
			get => this.endedAt_;
			set
			{
				this.endedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_PASSIVE_SKILL()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_PASSIVE_SKILL(MST_SVT_PASSIVE_SKILL other) : this()
		{
			this.svtId_ = other.svtId_;
			this.num_ = other.num_;
			this.priority_ = other.priority_;
			this.skillId_ = other.skillId_;
			this.condQuestId_ = other.condQuestId_;
			this.condQuestPhase_ = other.condQuestPhase_;
			this.condLv_ = other.condLv_;
			this.condLimitCount_ = other.condLimitCount_;
			this.condFriendshipRank_ = other.condFriendshipRank_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_PASSIVE_SKILL Clone()
		{
			return new MST_SVT_PASSIVE_SKILL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_PASSIVE_SKILL);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_PASSIVE_SKILL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.Num == other.Num && this.Priority == other.Priority && this.SkillId == other.SkillId && this.CondQuestId == other.CondQuestId && this.CondQuestPhase == other.CondQuestPhase && this.CondLv == other.CondLv && this.CondLimitCount == other.CondLimitCount && this.CondFriendshipRank == other.CondFriendshipRank && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
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
			if (this.CondQuestPhase != 0)
			{
				num ^= this.CondQuestPhase.GetHashCode();
			}
			if (this.CondLv != 0)
			{
				num ^= this.CondLv.GetHashCode();
			}
			if (this.CondLimitCount != 0)
			{
				num ^= this.CondLimitCount.GetHashCode();
			}
			if (this.CondFriendshipRank != 0)
			{
				num ^= this.CondFriendshipRank.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
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
			if (this.CondQuestPhase != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CondQuestPhase);
			}
			if (this.CondLv != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CondLv);
			}
			if (this.CondLimitCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CondLimitCount);
			}
			if (this.CondFriendshipRank != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CondFriendshipRank);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.EndedAt);
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
			if (this.CondQuestPhase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestPhase);
			}
			if (this.CondLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondLv);
			}
			if (this.CondLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondLimitCount);
			}
			if (this.CondFriendshipRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondFriendshipRank);
			}
			if (this.StartedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_PASSIVE_SKILL other)
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
			if (other.CondQuestPhase != 0)
			{
				this.CondQuestPhase = other.CondQuestPhase;
			}
			if (other.CondLv != 0)
			{
				this.CondLv = other.CondLv;
			}
			if (other.CondLimitCount != 0)
			{
				this.CondLimitCount = other.CondLimitCount;
			}
			if (other.CondFriendshipRank != 0)
			{
				this.CondFriendshipRank = other.CondFriendshipRank;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
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
													if (num2 != 80u)
													{
														if (num2 != 88u)
														{
															input.SkipLastField();
														}
														else
														{
															this.EndedAt = input.ReadUInt64();
														}
													}
													else
													{
														this.StartedAt = input.ReadUInt64();
													}
												}
												else
												{
													this.CondFriendshipRank = input.ReadInt32();
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
										this.CondQuestPhase = input.ReadInt32();
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
