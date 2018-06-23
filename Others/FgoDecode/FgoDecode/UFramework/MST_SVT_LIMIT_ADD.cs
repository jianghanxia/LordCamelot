using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_LIMIT_ADD : IMessage, IMessage<MST_SVT_LIMIT_ADD>, IEquatable<MST_SVT_LIMIT_ADD>, IDeepCloneable<MST_SVT_LIMIT_ADD>
	{
		public const int SvtIdFieldNumber = 1;

		public const int LimitCountFieldNumber = 2;

		public const int BattleCharaIdFieldNumber = 3;

		public const int BattleCharaLimitCountFieldNumber = 4;

		public const int BattleCharaOffsetXFieldNumber = 5;

		public const int BattleCharaOffsetYFieldNumber = 6;

		public const int SvtVoiceIdFieldNumber = 7;

		public const int VoicePrefixFieldNumber = 8;

		private static readonly MessageParser<MST_SVT_LIMIT_ADD> _parser = new MessageParser<MST_SVT_LIMIT_ADD>(() => new MST_SVT_LIMIT_ADD());

		private int svtId_;

		private int limitCount_;

		private int battleCharaId_;

		private int battleCharaLimitCount_;

		private int battleCharaOffsetX_;

		private int battleCharaOffsetY_;

		private int svtVoiceId_;

		private int voicePrefix_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_LIMIT_ADD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_LIMIT_ADD> Parser => MST_SVT_LIMIT_ADD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtLimitAddReflection.Descriptor.MessageTypes[0];

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
		public int LimitCount
		{
			get => this.limitCount_;
			set
			{
				this.limitCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleCharaId
		{
			get => this.battleCharaId_;
			set
			{
				this.battleCharaId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleCharaLimitCount
		{
			get => this.battleCharaLimitCount_;
			set
			{
				this.battleCharaLimitCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleCharaOffsetX
		{
			get => this.battleCharaOffsetX_;
			set
			{
				this.battleCharaOffsetX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BattleCharaOffsetY
		{
			get => this.battleCharaOffsetY_;
			set
			{
				this.battleCharaOffsetY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SvtVoiceId
		{
			get => this.svtVoiceId_;
			set
			{
				this.svtVoiceId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int VoicePrefix
		{
			get => this.voicePrefix_;
			set
			{
				this.voicePrefix_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_LIMIT_ADD()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_LIMIT_ADD(MST_SVT_LIMIT_ADD other) : this()
		{
			this.svtId_ = other.svtId_;
			this.limitCount_ = other.limitCount_;
			this.battleCharaId_ = other.battleCharaId_;
			this.battleCharaLimitCount_ = other.battleCharaLimitCount_;
			this.battleCharaOffsetX_ = other.battleCharaOffsetX_;
			this.battleCharaOffsetY_ = other.battleCharaOffsetY_;
			this.svtVoiceId_ = other.svtVoiceId_;
			this.voicePrefix_ = other.voicePrefix_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_LIMIT_ADD Clone()
		{
			return new MST_SVT_LIMIT_ADD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_LIMIT_ADD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_LIMIT_ADD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.LimitCount == other.LimitCount && this.BattleCharaId == other.BattleCharaId && this.BattleCharaLimitCount == other.BattleCharaLimitCount && this.BattleCharaOffsetX == other.BattleCharaOffsetX && this.BattleCharaOffsetY == other.BattleCharaOffsetY && this.SvtVoiceId == other.SvtVoiceId && this.VoicePrefix == other.VoicePrefix));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.BattleCharaId != 0)
			{
				num ^= this.BattleCharaId.GetHashCode();
			}
			if (this.BattleCharaLimitCount != 0)
			{
				num ^= this.BattleCharaLimitCount.GetHashCode();
			}
			if (this.BattleCharaOffsetX != 0)
			{
				num ^= this.BattleCharaOffsetX.GetHashCode();
			}
			if (this.BattleCharaOffsetY != 0)
			{
				num ^= this.BattleCharaOffsetY.GetHashCode();
			}
			if (this.SvtVoiceId != 0)
			{
				num ^= this.SvtVoiceId.GetHashCode();
			}
			if (this.VoicePrefix != 0)
			{
				num ^= this.VoicePrefix.GetHashCode();
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
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LimitCount);
			}
			if (this.BattleCharaId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BattleCharaId);
			}
			if (this.BattleCharaLimitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BattleCharaLimitCount);
			}
			if (this.BattleCharaOffsetX != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BattleCharaOffsetX);
			}
			if (this.BattleCharaOffsetY != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BattleCharaOffsetY);
			}
			if (this.SvtVoiceId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SvtVoiceId);
			}
			if (this.VoicePrefix != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.VoicePrefix);
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
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.BattleCharaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleCharaId);
			}
			if (this.BattleCharaLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleCharaLimitCount);
			}
			if (this.BattleCharaOffsetX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleCharaOffsetX);
			}
			if (this.BattleCharaOffsetY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleCharaOffsetY);
			}
			if (this.SvtVoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtVoiceId);
			}
			if (this.VoicePrefix != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VoicePrefix);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_LIMIT_ADD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.BattleCharaId != 0)
			{
				this.BattleCharaId = other.BattleCharaId;
			}
			if (other.BattleCharaLimitCount != 0)
			{
				this.BattleCharaLimitCount = other.BattleCharaLimitCount;
			}
			if (other.BattleCharaOffsetX != 0)
			{
				this.BattleCharaOffsetX = other.BattleCharaOffsetX;
			}
			if (other.BattleCharaOffsetY != 0)
			{
				this.BattleCharaOffsetY = other.BattleCharaOffsetY;
			}
			if (other.SvtVoiceId != 0)
			{
				this.SvtVoiceId = other.SvtVoiceId;
			}
			if (other.VoicePrefix != 0)
			{
				this.VoicePrefix = other.VoicePrefix;
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
												this.VoicePrefix = input.ReadInt32();
											}
										}
										else
										{
											this.SvtVoiceId = input.ReadInt32();
										}
									}
									else
									{
										this.BattleCharaOffsetY = input.ReadInt32();
									}
								}
								else
								{
									this.BattleCharaOffsetX = input.ReadInt32();
								}
							}
							else
							{
								this.BattleCharaLimitCount = input.ReadInt32();
							}
						}
						else
						{
							this.BattleCharaId = input.ReadInt32();
						}
					}
					else
					{
						this.LimitCount = input.ReadInt32();
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
