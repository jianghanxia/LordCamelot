using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_WAR_BGM : IMessage, IMessage<MST_WAR_BGM>, IEquatable<MST_WAR_BGM>, IDeepCloneable<MST_WAR_BGM>
	{
		public const int WarIdFieldNumber = 1;

		public const int PriorityFieldNumber = 2;

		public const int CondTypeFieldNumber = 3;

		public const int TargetIdFieldNumber = 4;

		public const int BgmIdFieldNumber = 5;

		private static readonly MessageParser<MST_WAR_BGM> _parser = new MessageParser<MST_WAR_BGM>(() => new MST_WAR_BGM());

		private int warId_;

		private int priority_;

		private int condType_;

		private int targetId_;

		private int bgmId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_WAR_BGM.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_WAR_BGM> Parser => MST_WAR_BGM._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstWarBgmReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int WarId
		{
			get => this.warId_;
			set
			{
				this.warId_ = value;
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
		public int CondType
		{
			get => this.condType_;
			set
			{
				this.condType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TargetId
		{
			get => this.targetId_;
			set
			{
				this.targetId_ = value;
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
		public MST_WAR_BGM()
		{
		}

		[DebuggerNonUserCode]
		public MST_WAR_BGM(MST_WAR_BGM other) : this()
		{
			this.warId_ = other.warId_;
			this.priority_ = other.priority_;
			this.condType_ = other.condType_;
			this.targetId_ = other.targetId_;
			this.bgmId_ = other.bgmId_;
		}

		[DebuggerNonUserCode]
		public MST_WAR_BGM Clone()
		{
			return new MST_WAR_BGM(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_WAR_BGM);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_WAR_BGM other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.WarId == other.WarId && this.Priority == other.Priority && this.CondType == other.CondType && this.TargetId == other.TargetId && this.BgmId == other.BgmId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WarId != 0)
			{
				num ^= this.WarId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.BgmId != 0)
			{
				num ^= this.BgmId.GetHashCode();
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
			if (this.WarId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WarId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Priority);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CondType);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetId);
			}
			if (this.BgmId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BgmId);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WarId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WarId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.BgmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BgmId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_WAR_BGM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WarId != 0)
			{
				this.WarId = other.WarId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.BgmId != 0)
			{
				this.BgmId = other.BgmId;
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
									input.SkipLastField();
								}
								else
								{
									this.BgmId = input.ReadInt32();
								}
							}
							else
							{
								this.TargetId = input.ReadInt32();
							}
						}
						else
						{
							this.CondType = input.ReadInt32();
						}
					}
					else
					{
						this.Priority = input.ReadInt32();
					}
				}
				else
				{
					this.WarId = input.ReadInt32();
				}
			}
		}
	}
}
