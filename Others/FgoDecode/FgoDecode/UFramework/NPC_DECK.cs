using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_DECK : IMessage, IMessage<NPC_DECK>, IEquatable<NPC_DECK>, IDeepCloneable<NPC_DECK>
	{
		public const int IdFieldNumber = 1;

		public const int NumFieldNumber = 2;

		public const int NpcSvtIdFieldNumber = 3;

		public const int LvFieldNumber = 4;

		public const int NameFieldNumber = 5;

		public const int HpFieldNumber = 6;

		public const int ProbabilityFieldNumber = 7;

		public const int EnemyScriptFieldNumber = 8;

		public const int RoleTypeFieldNumber = 9;

		public const int UpdatedAtFieldNumber = 10;

		public const int CreatedAtFieldNumber = 11;

		private static readonly MessageParser<NPC_DECK> _parser = new MessageParser<NPC_DECK>(() => new NPC_DECK());

		private int id_;

		private int num_;

		private int npcSvtId_;

		private int lv_;

		private ByteString name_ = ByteString.Empty;

		private int hp_;

		private int probability_;

		private ByteString enemyScript_ = ByteString.Empty;

		private int roleType_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_DECK.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_DECK> Parser => NPC_DECK._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcDeckReflection.Descriptor.MessageTypes[0];

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
		public int NpcSvtId
		{
			get => this.npcSvtId_;
			set
			{
				this.npcSvtId_ = value;
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
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int Hp
		{
			get => this.hp_;
			set
			{
				this.hp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Probability
		{
			get => this.probability_;
			set
			{
				this.probability_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString EnemyScript
		{
			get => this.enemyScript_;
			set
			{
				this.enemyScript_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int RoleType
		{
			get => this.roleType_;
			set
			{
				this.roleType_ = value;
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
		public NPC_DECK()
		{
		}

		[DebuggerNonUserCode]
		public NPC_DECK(NPC_DECK other) : this()
		{
			this.id_ = other.id_;
			this.num_ = other.num_;
			this.npcSvtId_ = other.npcSvtId_;
			this.lv_ = other.lv_;
			this.name_ = other.name_;
			this.hp_ = other.hp_;
			this.probability_ = other.probability_;
			this.enemyScript_ = other.enemyScript_;
			this.roleType_ = other.roleType_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public NPC_DECK Clone()
		{
			return new NPC_DECK(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_DECK);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_DECK other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Num == other.Num && this.NpcSvtId == other.NpcSvtId && this.Lv == other.Lv && !(this.Name != other.Name) && this.Hp == other.Hp && this.Probability == other.Probability && !(this.EnemyScript != other.EnemyScript) && this.RoleType == other.RoleType && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
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
			if (this.NpcSvtId != 0)
			{
				num ^= this.NpcSvtId.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Hp != 0)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this.Probability != 0)
			{
				num ^= this.Probability.GetHashCode();
			}
			if (this.EnemyScript.Length != 0)
			{
				num ^= this.EnemyScript.GetHashCode();
			}
			if (this.RoleType != 0)
			{
				num ^= this.RoleType.GetHashCode();
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
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this.NpcSvtId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NpcSvtId);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Lv);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.Name);
			}
			if (this.Hp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Hp);
			}
			if (this.Probability != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Probability);
			}
			if (this.EnemyScript.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteBytes(this.EnemyScript);
			}
			if (this.RoleType != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleType);
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
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.NpcSvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcSvtId);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Hp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Hp);
			}
			if (this.Probability != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Probability);
			}
			if (this.EnemyScript.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.EnemyScript);
			}
			if (this.RoleType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleType);
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
		public void MergeFrom(NPC_DECK other)
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
			if (other.NpcSvtId != 0)
			{
				this.NpcSvtId = other.NpcSvtId;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Hp != 0)
			{
				this.Hp = other.Hp;
			}
			if (other.Probability != 0)
			{
				this.Probability = other.Probability;
			}
			if (other.EnemyScript.Length != 0)
			{
				this.EnemyScript = other.EnemyScript;
			}
			if (other.RoleType != 0)
			{
				this.RoleType = other.RoleType;
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
											if (num2 != 66u)
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
													this.RoleType = input.ReadInt32();
												}
											}
											else
											{
												this.EnemyScript = input.ReadBytes();
											}
										}
										else
										{
											this.Probability = input.ReadInt32();
										}
									}
									else
									{
										this.Hp = input.ReadInt32();
									}
								}
								else
								{
									this.Name = input.ReadBytes();
								}
							}
							else
							{
								this.Lv = input.ReadInt32();
							}
						}
						else
						{
							this.NpcSvtId = input.ReadInt32();
						}
					}
					else
					{
						this.Num = input.ReadInt32();
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
