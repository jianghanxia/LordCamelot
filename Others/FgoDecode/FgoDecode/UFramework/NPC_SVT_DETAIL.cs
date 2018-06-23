using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_SVT_DETAIL : IMessage, IMessage<NPC_SVT_DETAIL>, IEquatable<NPC_SVT_DETAIL>, IDeepCloneable<NPC_SVT_DETAIL>
	{
		public const int NpcSvtIdFieldNumber = 1;

		public const int EnemyScriptFieldNumber = 2;

		public const int RoleTypeFieldNumber = 3;

		private static readonly MessageParser<NPC_SVT_DETAIL> _parser = new MessageParser<NPC_SVT_DETAIL>(() => new NPC_SVT_DETAIL());

		private int npcSvtId_;

		private ByteString enemyScript_ = ByteString.Empty;

		private int roleType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_SVT_DETAIL.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_SVT_DETAIL> Parser => NPC_SVT_DETAIL._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcSvtDetailReflection.Descriptor.MessageTypes[0];

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
		public NPC_SVT_DETAIL()
		{
		}

		[DebuggerNonUserCode]
		public NPC_SVT_DETAIL(NPC_SVT_DETAIL other) : this()
		{
			this.npcSvtId_ = other.npcSvtId_;
			this.enemyScript_ = other.enemyScript_;
			this.roleType_ = other.roleType_;
		}

		[DebuggerNonUserCode]
		public NPC_SVT_DETAIL Clone()
		{
			return new NPC_SVT_DETAIL(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_SVT_DETAIL);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_SVT_DETAIL other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.NpcSvtId == other.NpcSvtId && !(this.EnemyScript != other.EnemyScript) && this.RoleType == other.RoleType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcSvtId != 0)
			{
				num ^= this.NpcSvtId.GetHashCode();
			}
			if (this.EnemyScript.Length != 0)
			{
				num ^= this.EnemyScript.GetHashCode();
			}
			if (this.RoleType != 0)
			{
				num ^= this.RoleType.GetHashCode();
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
			if (this.NpcSvtId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NpcSvtId);
			}
			if (this.EnemyScript.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.EnemyScript);
			}
			if (this.RoleType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleType);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcSvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcSvtId);
			}
			if (this.EnemyScript.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.EnemyScript);
			}
			if (this.RoleType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(NPC_SVT_DETAIL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcSvtId != 0)
			{
				this.NpcSvtId = other.NpcSvtId;
			}
			if (other.EnemyScript.Length != 0)
			{
				this.EnemyScript = other.EnemyScript;
			}
			if (other.RoleType != 0)
			{
				this.RoleType = other.RoleType;
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
					if (num2 != 18u)
					{
						if (num2 != 24u)
						{
							input.SkipLastField();
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
					this.NpcSvtId = input.ReadInt32();
				}
			}
		}
	}
}
