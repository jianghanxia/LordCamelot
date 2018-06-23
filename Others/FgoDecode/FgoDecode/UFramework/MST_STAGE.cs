using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_STAGE : IMessage, IMessage<MST_STAGE>, IEquatable<MST_STAGE>, IDeepCloneable<MST_STAGE>
	{
		public const int QuestIdFieldNumber = 1;

		public const int QuestPhaseFieldNumber = 2;

		public const int WaveFieldNumber = 3;

		public const int ScriptFieldNumber = 4;

		public const int NpcDeckIdsFieldNumber = 5;

		public const int EnemyInfoFieldNumber = 6;

		public const int BgmIdFieldNumber = 7;

		public const int StartEffectIdFieldNumber = 8;

		private static readonly MessageParser<MST_STAGE> _parser = new MessageParser<MST_STAGE>(() => new MST_STAGE());

		private int questId_;

		private int questPhase_;

		private int wave_;

		private ByteString script_ = ByteString.Empty;

		private static readonly FieldCodec<long> _repeated_npcDeckIds_codec = FieldCodec.ForInt64(42u);

		private readonly RepeatedField<long> npcDeckIds_ = new RepeatedField<long>();

		private int enemyInfo_;

		private int bgmId_;

		private int startEffectId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_STAGE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_STAGE> Parser => MST_STAGE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstStageReflection.Descriptor.MessageTypes[0];

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
		public int Wave
		{
			get => this.wave_;
			set
			{
				this.wave_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Script
		{
			get => this.script_;
			set
			{
				this.script_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> NpcDeckIds => this.npcDeckIds_;

		[DebuggerNonUserCode]
		public int EnemyInfo
		{
			get => this.enemyInfo_;
			set
			{
				this.enemyInfo_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BgmId
		{
			get => this.bgmId_;
			set
			{
				this.bgmId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int StartEffectId
		{
			get => this.startEffectId_;
			set
			{
				this.startEffectId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_STAGE()
		{
		}

		[DebuggerNonUserCode]
		public MST_STAGE(MST_STAGE other) : this()
		{
			this.questId_ = other.questId_;
			this.questPhase_ = other.questPhase_;
			this.wave_ = other.wave_;
			this.script_ = other.script_;
			this.npcDeckIds_ = other.npcDeckIds_.Clone();
			this.enemyInfo_ = other.enemyInfo_;
			this.bgmId_ = other.bgmId_;
			this.startEffectId_ = other.startEffectId_;
		}

		[DebuggerNonUserCode]
		public MST_STAGE Clone()
		{
			return new MST_STAGE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_STAGE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_STAGE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.QuestPhase == other.QuestPhase && this.Wave == other.Wave && !(this.Script != other.Script) && this.npcDeckIds_.Equals(other.npcDeckIds_) && this.EnemyInfo == other.EnemyInfo && this.BgmId == other.BgmId && this.StartEffectId == other.StartEffectId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.QuestPhase != 0)
			{
				num ^= this.QuestPhase.GetHashCode();
			}
			if (this.Wave != 0)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.Script.Length != 0)
			{
				num ^= this.Script.GetHashCode();
			}
			num ^= this.npcDeckIds_.GetHashCode();
			if (this.EnemyInfo != 0)
			{
				num ^= this.EnemyInfo.GetHashCode();
			}
			if (this.BgmId != 0)
			{
				num ^= this.BgmId.GetHashCode();
			}
			if (this.StartEffectId != 0)
			{
				num ^= this.StartEffectId.GetHashCode();
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
			if (this.QuestPhase != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.QuestPhase);
			}
			if (this.Wave != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Wave);
			}
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.Script);
			}
			this.npcDeckIds_.WriteTo(output, MST_STAGE._repeated_npcDeckIds_codec);
			if (this.EnemyInfo != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EnemyInfo);
			}
			if (this.BgmId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BgmId);
			}
			if (this.StartEffectId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.StartEffectId);
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
			if (this.QuestPhase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestPhase);
			}
			if (this.Wave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Wave);
			}
			if (this.Script.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Script);
			}
			num += this.npcDeckIds_.CalculateSize(MST_STAGE._repeated_npcDeckIds_codec);
			if (this.EnemyInfo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnemyInfo);
			}
			if (this.BgmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgmId);
			}
			if (this.StartEffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartEffectId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_STAGE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.QuestPhase != 0)
			{
				this.QuestPhase = other.QuestPhase;
			}
			if (other.Wave != 0)
			{
				this.Wave = other.Wave;
			}
			if (other.Script.Length != 0)
			{
				this.Script = other.Script;
			}
			this.npcDeckIds_.Add(other.npcDeckIds_);
			if (other.EnemyInfo != 0)
			{
				this.EnemyInfo = other.EnemyInfo;
			}
			if (other.BgmId != 0)
			{
				this.BgmId = other.BgmId;
			}
			if (other.StartEffectId != 0)
			{
				this.StartEffectId = other.StartEffectId;
			}
		}

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                uint num2 = num;
                switch (num2)
                {
                    case 40:
                    case 0x2a:
                        {
                            this.npcDeckIds_.AddEntriesFrom(input, _repeated_npcDeckIds_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.QuestId = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.QuestPhase = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.Wave = input.ReadInt32();
                            continue;
                        }
                    case 0x22:
                        {
                            this.Script = input.ReadBytes();
                            continue;
                        }
                    case 0x30:
                        {
                            this.EnemyInfo = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.BgmId = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.StartEffectId = input.ReadInt32();
            }
        }


    }
}
