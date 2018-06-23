using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_PROFILE : IMessage, IMessage<MST_SVT_PROFILE>, IEquatable<MST_SVT_PROFILE>, IDeepCloneable<MST_SVT_PROFILE>
	{
		public const int SvtIdFieldNumber = 1;

		public const int SvtCommentIdFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int CondTypeFieldNumber = 4;

		public const int CondValueFieldNumber = 5;

		private static readonly MessageParser<MST_SVT_PROFILE> _parser = new MessageParser<MST_SVT_PROFILE>(() => new MST_SVT_PROFILE());

		private int svtId_;

		private int svtCommentId_;

		private int priority_;

		private int condType_;

		private int condValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_PROFILE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_PROFILE> Parser => MST_SVT_PROFILE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtProfileReflection.Descriptor.MessageTypes[0];

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
		public int SvtCommentId
		{
			get => this.svtCommentId_;
			set
			{
				this.svtCommentId_ = value;
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
		public int CondValue
		{
			get => this.condValue_;
			set
			{
				this.condValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_PROFILE()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_PROFILE(MST_SVT_PROFILE other) : this()
		{
			this.svtId_ = other.svtId_;
			this.svtCommentId_ = other.svtCommentId_;
			this.priority_ = other.priority_;
			this.condType_ = other.condType_;
			this.condValue_ = other.condValue_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_PROFILE Clone()
		{
			return new MST_SVT_PROFILE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_PROFILE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_PROFILE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.SvtCommentId == other.SvtCommentId && this.Priority == other.Priority && this.CondType == other.CondType && this.CondValue == other.CondValue));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.SvtCommentId != 0)
			{
				num ^= this.SvtCommentId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.CondValue != 0)
			{
				num ^= this.CondValue.GetHashCode();
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
			if (this.SvtCommentId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SvtCommentId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Priority);
			}
			if (this.CondType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CondType);
			}
			if (this.CondValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CondValue);
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
			if (this.SvtCommentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtCommentId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.CondValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_PROFILE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.SvtCommentId != 0)
			{
				this.SvtCommentId = other.SvtCommentId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.CondValue != 0)
			{
				this.CondValue = other.CondValue;
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
									this.CondValue = input.ReadInt32();
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
						this.SvtCommentId = input.ReadInt32();
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
