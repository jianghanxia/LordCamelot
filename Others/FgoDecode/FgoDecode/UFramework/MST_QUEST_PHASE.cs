using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_PHASE : IMessage, IMessage<MST_QUEST_PHASE>, IEquatable<MST_QUEST_PHASE>, IDeepCloneable<MST_QUEST_PHASE>
	{
		public const int QuestIdFieldNumber = 1;

		public const int PhaseFieldNumber = 2;

		public const int IsNpcOnlyFieldNumber = 3;

		public const int BattleBgIdFieldNumber = 4;

		public const int BattleBgTypeFieldNumber = 5;

		public const int QpFieldNumber = 6;

		public const int PlayerExpFieldNumber = 7;

		public const int FriendshipExpFieldNumber = 8;

		public const int ClassIdsFieldNumber = 9;

		public const int EncountSvtIdsFieldNumber = 10;

		public const int IndividualityFieldNumber = 11;

		public const int ScriptFieldNumber = 12;

		private static readonly MessageParser<MST_QUEST_PHASE> _parser = new MessageParser<MST_QUEST_PHASE>(() => new MST_QUEST_PHASE());

		private int questId_;

		private int phase_;

		private int isNpcOnly_;

		private int battleBgId_;

		private int battleBgType_;

		private int qp_;

		private int playerExp_;

		private int friendshipExp_;

		private static readonly FieldCodec<int> _repeated_classIds_codec = FieldCodec.ForInt32(74u);

		private readonly RepeatedField<int> classIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_encountSvtIds_codec = FieldCodec.ForInt32(82u);

		private readonly RepeatedField<int> encountSvtIds_ = new RepeatedField<int>();

		private static readonly FieldCodec<int> _repeated_individuality_codec = FieldCodec.ForInt32(90u);

		private readonly RepeatedField<int> individuality_ = new RepeatedField<int>();

		private ByteString script_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_PHASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_PHASE> Parser => MST_QUEST_PHASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestPhaseReflection.Descriptor.MessageTypes[0];

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
		public int IsNpcOnly
		{
			get => this.isNpcOnly_;
			set
			{
				this.isNpcOnly_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleBgId
		{
			get => this.battleBgId_;
			set
			{
				this.battleBgId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleBgType
		{
			get => this.battleBgType_;
			set
			{
				this.battleBgType_ = value;
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
		public int PlayerExp
		{
			get => this.playerExp_;
			set
			{
				this.playerExp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FriendshipExp
		{
			get => this.friendshipExp_;
			set
			{
				this.friendshipExp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ClassIds => this.classIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> EncountSvtIds => this.encountSvtIds_;

		[DebuggerNonUserCode]
		public RepeatedField<int> Individuality => this.individuality_;

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
		public MST_QUEST_PHASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_PHASE(MST_QUEST_PHASE other) : this()
		{
			this.questId_ = other.questId_;
			this.phase_ = other.phase_;
			this.isNpcOnly_ = other.isNpcOnly_;
			this.battleBgId_ = other.battleBgId_;
			this.battleBgType_ = other.battleBgType_;
			this.qp_ = other.qp_;
			this.playerExp_ = other.playerExp_;
			this.friendshipExp_ = other.friendshipExp_;
			this.classIds_ = other.classIds_.Clone();
			this.encountSvtIds_ = other.encountSvtIds_.Clone();
			this.individuality_ = other.individuality_.Clone();
			this.script_ = other.script_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_PHASE Clone()
		{
			return new MST_QUEST_PHASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_PHASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_PHASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.QuestId == other.QuestId && this.Phase == other.Phase && this.IsNpcOnly == other.IsNpcOnly && this.BattleBgId == other.BattleBgId && this.BattleBgType == other.BattleBgType && this.Qp == other.Qp && this.PlayerExp == other.PlayerExp && this.FriendshipExp == other.FriendshipExp && this.classIds_.Equals(other.classIds_) && this.encountSvtIds_.Equals(other.encountSvtIds_) && this.individuality_.Equals(other.individuality_) && !(this.Script != other.Script)));
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
			if (this.IsNpcOnly != 0)
			{
				num ^= this.IsNpcOnly.GetHashCode();
			}
			if (this.BattleBgId != 0)
			{
				num ^= this.BattleBgId.GetHashCode();
			}
			if (this.BattleBgType != 0)
			{
				num ^= this.BattleBgType.GetHashCode();
			}
			if (this.Qp != 0)
			{
				num ^= this.Qp.GetHashCode();
			}
			if (this.PlayerExp != 0)
			{
				num ^= this.PlayerExp.GetHashCode();
			}
			if (this.FriendshipExp != 0)
			{
				num ^= this.FriendshipExp.GetHashCode();
			}
			num ^= this.classIds_.GetHashCode();
			num ^= this.encountSvtIds_.GetHashCode();
			num ^= this.individuality_.GetHashCode();
			if (this.Script.Length != 0)
			{
				num ^= this.Script.GetHashCode();
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
			if (this.IsNpcOnly != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IsNpcOnly);
			}
			if (this.BattleBgId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BattleBgId);
			}
			if (this.BattleBgType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BattleBgType);
			}
			if (this.Qp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Qp);
			}
			if (this.PlayerExp != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerExp);
			}
			if (this.FriendshipExp != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FriendshipExp);
			}
			this.classIds_.WriteTo(output, MST_QUEST_PHASE._repeated_classIds_codec);
			this.encountSvtIds_.WriteTo(output, MST_QUEST_PHASE._repeated_encountSvtIds_codec);
			this.individuality_.WriteTo(output, MST_QUEST_PHASE._repeated_individuality_codec);
			if (this.Script.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteBytes(this.Script);
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
			if (this.IsNpcOnly != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsNpcOnly);
			}
			if (this.BattleBgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleBgId);
			}
			if (this.BattleBgType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleBgType);
			}
			if (this.Qp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Qp);
			}
			if (this.PlayerExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerExp);
			}
			if (this.FriendshipExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FriendshipExp);
			}
			num += this.classIds_.CalculateSize(MST_QUEST_PHASE._repeated_classIds_codec);
			num += this.encountSvtIds_.CalculateSize(MST_QUEST_PHASE._repeated_encountSvtIds_codec);
			num += this.individuality_.CalculateSize(MST_QUEST_PHASE._repeated_individuality_codec);
			if (this.Script.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Script);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_PHASE other)
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
			if (other.IsNpcOnly != 0)
			{
				this.IsNpcOnly = other.IsNpcOnly;
			}
			if (other.BattleBgId != 0)
			{
				this.BattleBgId = other.BattleBgId;
			}
			if (other.BattleBgType != 0)
			{
				this.BattleBgType = other.BattleBgType;
			}
			if (other.Qp != 0)
			{
				this.Qp = other.Qp;
			}
			if (other.PlayerExp != 0)
			{
				this.PlayerExp = other.PlayerExp;
			}
			if (other.FriendshipExp != 0)
			{
				this.FriendshipExp = other.FriendshipExp;
			}
			this.classIds_.Add(other.classIds_);
			this.encountSvtIds_.Add(other.encountSvtIds_);
			this.individuality_.Add(other.individuality_);
			if (other.Script.Length != 0)
			{
				this.Script = other.Script;
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
                    case 0x48:
                    case 0x4a:
                        {
                            this.classIds_.AddEntriesFrom(input, _repeated_classIds_codec);
                            continue;
                        }
                    case 80:
                    case 0x52:
                        {
                            this.encountSvtIds_.AddEntriesFrom(input, _repeated_encountSvtIds_codec);
                            continue;
                        }
                    case 0x58:
                    case 90:
                        {
                            this.individuality_.AddEntriesFrom(input, _repeated_individuality_codec);
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
                            this.Phase = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.IsNpcOnly = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.BattleBgId = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.BattleBgType = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.Qp = input.ReadInt32();
                            continue;
                        }
                    case 0x38:
                        {
                            this.PlayerExp = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.FriendshipExp = input.ReadInt32();
                            continue;
                        }
                    case 0x62:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.Script = input.ReadBytes();
            }
        }



    }
}
