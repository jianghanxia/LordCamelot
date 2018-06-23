using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_HEROINE : IMessage, IMessage<MST_HEROINE>, IEquatable<MST_HEROINE>, IDeepCloneable<MST_HEROINE>
	{
		public const int QuestIdFieldNumber = 1;

		public const int PhaseFieldNumber = 2;

		public const int SvtIdFieldNumber = 3;

		public const int FriendshipFieldNumber = 4;

		public const int FriendshipRankFieldNumber = 5;

		public const int LimitCountFieldNumber = 6;

		public const int IsDeadFieldNumber = 7;

		public const int TreasureDeviceNumFieldNumber = 8;

		public const int TreasureDeviceLvFieldNumber = 9;

		public const int UpdatedAtFieldNumber = 10;

		public const int CreatedAtFieldNumber = 11;

		private static readonly MessageParser<MST_HEROINE> _parser = new MessageParser<MST_HEROINE>(() => new MST_HEROINE());

		private int questId_;

		private int phase_;

		private int svtId_;

		private int friendship_;

		private int friendshipRank_;

		private int limitCount_;

		private int isDead_;

		private int treasureDeviceNum_;

		private int treasureDeviceLv_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_HEROINE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_HEROINE> Parser => MST_HEROINE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstHeroineReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int QuestId
		{
			get => this.questId_;
			set
			{
				this.questId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Phase
		{
			get => this.phase_;
			set
			{
				this.phase_ = value;
			}
		}

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
		public int Friendship
		{
			get => this.friendship_;
			set
			{
				this.friendship_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FriendshipRank
		{
			get => this.friendshipRank_;
			set
			{
				this.friendshipRank_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LimitCount
		{
			get => this.limitCount_;
			set
			{
				this.limitCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IsDead
		{
			get => this.isDead_;
			set
			{
				this.isDead_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TreasureDeviceNum
		{
			get => this.treasureDeviceNum_;
			set
			{
				this.treasureDeviceNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TreasureDeviceLv
		{
			get => this.treasureDeviceLv_;
			set
			{
				this.treasureDeviceLv_ = value;
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
		public MST_HEROINE()
		{
		}

		[DebuggerNonUserCode]
		public MST_HEROINE(MST_HEROINE other) : this()
		{
			this.questId_ = other.questId_;
			this.phase_ = other.phase_;
			this.svtId_ = other.svtId_;
			this.friendship_ = other.friendship_;
			this.friendshipRank_ = other.friendshipRank_;
			this.limitCount_ = other.limitCount_;
			this.isDead_ = other.isDead_;
			this.treasureDeviceNum_ = other.treasureDeviceNum_;
			this.treasureDeviceLv_ = other.treasureDeviceLv_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_HEROINE Clone()
		{
			return new MST_HEROINE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_HEROINE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_HEROINE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.Phase == other.Phase && this.SvtId == other.SvtId && this.Friendship == other.Friendship && this.FriendshipRank == other.FriendshipRank && this.LimitCount == other.LimitCount && this.IsDead == other.IsDead && this.TreasureDeviceNum == other.TreasureDeviceNum && this.TreasureDeviceLv == other.TreasureDeviceLv && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Phase != 0)
			{
				num ^= this.Phase.GetHashCode();
			}
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.Friendship != 0)
			{
				num ^= this.Friendship.GetHashCode();
			}
			if (this.FriendshipRank != 0)
			{
				num ^= this.FriendshipRank.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.IsDead != 0)
			{
				num ^= this.IsDead.GetHashCode();
			}
			if (this.TreasureDeviceNum != 0)
			{
				num ^= this.TreasureDeviceNum.GetHashCode();
			}
			if (this.TreasureDeviceLv != 0)
			{
				num ^= this.TreasureDeviceLv.GetHashCode();
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
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this.Phase != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Phase);
			}
			if (this.SvtId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SvtId);
			}
			if (this.Friendship != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Friendship);
			}
			if (this.FriendshipRank != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FriendshipRank);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LimitCount);
			}
			if (this.IsDead != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IsDead);
			}
			if (this.TreasureDeviceNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TreasureDeviceNum);
			}
			if (this.TreasureDeviceLv != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreasureDeviceLv);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(80);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Phase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Phase);
			}
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.Friendship != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Friendship);
			}
			if (this.FriendshipRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FriendshipRank);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.IsDead != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsDead);
			}
			if (this.TreasureDeviceNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceNum);
			}
			if (this.TreasureDeviceLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreasureDeviceLv);
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
		public void MergeFrom(MST_HEROINE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Phase != 0)
			{
				this.Phase = other.Phase;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.Friendship != 0)
			{
				this.Friendship = other.Friendship;
			}
			if (other.FriendshipRank != 0)
			{
				this.FriendshipRank = other.FriendshipRank;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.IsDead != 0)
			{
				this.IsDead = other.IsDead;
			}
			if (other.TreasureDeviceNum != 0)
			{
				this.TreasureDeviceNum = other.TreasureDeviceNum;
			}
			if (other.TreasureDeviceLv != 0)
			{
				this.TreasureDeviceLv = other.TreasureDeviceLv;
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
													if (num2 != 80u)
													{
														if (num2 != 88u)
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
													this.TreasureDeviceLv = input.ReadInt32();
												}
											}
											else
											{
												this.TreasureDeviceNum = input.ReadInt32();
											}
										}
										else
										{
											this.IsDead = input.ReadInt32();
										}
									}
									else
									{
										this.LimitCount = input.ReadInt32();
									}
								}
								else
								{
									this.FriendshipRank = input.ReadInt32();
								}
							}
							else
							{
								this.Friendship = input.ReadInt32();
							}
						}
						else
						{
							this.SvtId = input.ReadInt32();
						}
					}
					else
					{
						this.Phase = input.ReadInt32();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}
	}
}
