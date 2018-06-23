using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_FOLLOWER : IMessage, IMessage<NPC_FOLLOWER>, IEquatable<NPC_FOLLOWER>, IDeepCloneable<NPC_FOLLOWER>
	{
		public const int IdFieldNumber = 1;

		public const int QuestIdFieldNumber = 2;

		public const int QuestPhaseFieldNumber = 3;

		public const int LeaderSvtIdFieldNumber = 4;

		public const int NpcScriptFieldNumber = 5;

		public const int UpdatedAtFieldNumber = 6;

		public const int CreatedAtFieldNumber = 7;

		private static readonly MessageParser<NPC_FOLLOWER> _parser = new MessageParser<NPC_FOLLOWER>(() => new NPC_FOLLOWER());

		private int id_;

		private int questId_;

		private int questPhase_;

		private int leaderSvtId_;

		private ByteString npcScript_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_FOLLOWER.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_FOLLOWER> Parser => NPC_FOLLOWER._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcFollowerReflection.Descriptor.MessageTypes[0];

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
		public int QuestId
		{
			get => this.questId_;
			set
			{
				this.questId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int QuestPhase
		{
			get => this.questPhase_;
			set
			{
				this.questPhase_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int LeaderSvtId
		{
			get => this.leaderSvtId_;
			set
			{
				this.leaderSvtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString NpcScript
		{
			get => this.npcScript_;
			set
			{
				this.npcScript_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public NPC_FOLLOWER()
		{
		}

		[DebuggerNonUserCode]
		public NPC_FOLLOWER(NPC_FOLLOWER other) : this()
		{
			this.id_ = other.id_;
			this.questId_ = other.questId_;
			this.questPhase_ = other.questPhase_;
			this.leaderSvtId_ = other.leaderSvtId_;
			this.npcScript_ = other.npcScript_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public NPC_FOLLOWER Clone()
		{
			return new NPC_FOLLOWER(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_FOLLOWER);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_FOLLOWER other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.QuestId == other.QuestId && this.QuestPhase == other.QuestPhase && this.LeaderSvtId == other.LeaderSvtId && !(this.NpcScript != other.NpcScript) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.QuestPhase != 0)
			{
				num ^= this.QuestPhase.GetHashCode();
			}
			if (this.LeaderSvtId != 0)
			{
				num ^= this.LeaderSvtId.GetHashCode();
			}
			if (this.NpcScript.Length != 0)
			{
				num ^= this.NpcScript.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.QuestId);
			}
			if (this.QuestPhase != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuestPhase);
			}
			if (this.LeaderSvtId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LeaderSvtId);
			}
			if (this.NpcScript.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.NpcScript);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.QuestPhase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestPhase);
			}
			if (this.LeaderSvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeaderSvtId);
			}
			if (this.NpcScript.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NpcScript);
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
		public void MergeFrom(NPC_FOLLOWER other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.QuestPhase != 0)
			{
				this.QuestPhase = other.QuestPhase;
			}
			if (other.LeaderSvtId != 0)
			{
				this.LeaderSvtId = other.LeaderSvtId;
			}
			if (other.NpcScript.Length != 0)
			{
				this.NpcScript = other.NpcScript;
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
								if (num2 != 42u)
								{
									if (num2 != 48u)
									{
										if (num2 != 56u)
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
									this.NpcScript = input.ReadBytes();
								}
							}
							else
							{
								this.LeaderSvtId = input.ReadInt32();
							}
						}
						else
						{
							this.QuestPhase = input.ReadInt32();
						}
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}
	}
}
