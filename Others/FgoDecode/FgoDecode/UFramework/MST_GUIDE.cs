using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_GUIDE : IMessage, IMessage<MST_GUIDE>, IEquatable<MST_GUIDE>, IDeepCloneable<MST_GUIDE>
	{
		public const int GuideTypeFieldNumber = 1;

		public const int PriorityFieldNumber = 2;

		public const int GuideImageIdFieldNumber = 3;

		public const int GuideLimitCountFieldNumber = 4;

		public const int CondQuestIdFieldNumber = 5;

		public const int CondQuestPhaseFieldNumber = 6;

		private static readonly MessageParser<MST_GUIDE> _parser = new MessageParser<MST_GUIDE>(() => new MST_GUIDE());

		private int guideType_;

		private int priority_;

		private int guideImageId_;

		private int guideLimitCount_;

		private int condQuestId_;

		private int condQuestPhase_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_GUIDE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_GUIDE> Parser => MST_GUIDE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstGuideReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int GuideType
		{
			get => this.guideType_;
			set
			{
				this.guideType_ = value;
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
		public int GuideImageId
		{
			get => this.guideImageId_;
			set
			{
				this.guideImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GuideLimitCount
		{
			get => this.guideLimitCount_;
			set
			{
				this.guideLimitCount_ = value;
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
		public MST_GUIDE()
		{
		}

		[DebuggerNonUserCode]
		public MST_GUIDE(MST_GUIDE other) : this()
		{
			this.guideType_ = other.guideType_;
			this.priority_ = other.priority_;
			this.guideImageId_ = other.guideImageId_;
			this.guideLimitCount_ = other.guideLimitCount_;
			this.condQuestId_ = other.condQuestId_;
			this.condQuestPhase_ = other.condQuestPhase_;
		}

		[DebuggerNonUserCode]
		public MST_GUIDE Clone()
		{
			return new MST_GUIDE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_GUIDE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_GUIDE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.GuideType == other.GuideType && this.Priority == other.Priority && this.GuideImageId == other.GuideImageId && this.GuideLimitCount == other.GuideLimitCount && this.CondQuestId == other.CondQuestId && this.CondQuestPhase == other.CondQuestPhase));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GuideType != 0)
			{
				num ^= this.GuideType.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.GuideImageId != 0)
			{
				num ^= this.GuideImageId.GetHashCode();
			}
			if (this.GuideLimitCount != 0)
			{
				num ^= this.GuideLimitCount.GetHashCode();
			}
			if (this.CondQuestId != 0)
			{
				num ^= this.CondQuestId.GetHashCode();
			}
			if (this.CondQuestPhase != 0)
			{
				num ^= this.CondQuestPhase.GetHashCode();
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
			if (this.GuideType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GuideType);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Priority);
			}
			if (this.GuideImageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GuideImageId);
			}
			if (this.GuideLimitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GuideLimitCount);
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
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GuideType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideType);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.GuideImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideImageId);
			}
			if (this.GuideLimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GuideLimitCount);
			}
			if (this.CondQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestId);
			}
			if (this.CondQuestPhase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondQuestPhase);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_GUIDE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GuideType != 0)
			{
				this.GuideType = other.GuideType;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.GuideImageId != 0)
			{
				this.GuideImageId = other.GuideImageId;
			}
			if (other.GuideLimitCount != 0)
			{
				this.GuideLimitCount = other.GuideLimitCount;
			}
			if (other.CondQuestId != 0)
			{
				this.CondQuestId = other.CondQuestId;
			}
			if (other.CondQuestPhase != 0)
			{
				this.CondQuestPhase = other.CondQuestPhase;
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
										input.SkipLastField();
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
								this.GuideLimitCount = input.ReadInt32();
							}
						}
						else
						{
							this.GuideImageId = input.ReadInt32();
						}
					}
					else
					{
						this.Priority = input.ReadInt32();
					}
				}
				else
				{
					this.GuideType = input.ReadInt32();
				}
			}
		}
	}
}
