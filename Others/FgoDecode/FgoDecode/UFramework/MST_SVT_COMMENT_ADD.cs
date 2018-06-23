using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_COMMENT_ADD : IMessage, IMessage<MST_SVT_COMMENT_ADD>, IEquatable<MST_SVT_COMMENT_ADD>, IDeepCloneable<MST_SVT_COMMENT_ADD>
	{
		public const int SvtIdFieldNumber = 1;

		public const int IdFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int CondTypeFieldNumber = 4;

		public const int CondValueFieldNumber = 5;

		public const int CondValue2FieldNumber = 6;

		private static readonly MessageParser<MST_SVT_COMMENT_ADD> _parser = new MessageParser<MST_SVT_COMMENT_ADD>(() => new MST_SVT_COMMENT_ADD());

		private int svtId_;

		private int id_;

		private int priority_;

		private int condType_;

		private int condValue_;

		private int condValue2_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_COMMENT_ADD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_COMMENT_ADD> Parser => MST_SVT_COMMENT_ADD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtCommentAddReflection.Descriptor.MessageTypes[0];

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
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
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
		public int CondValue2
		{
			get => this.condValue2_;
			set
			{
				this.condValue2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_COMMENT_ADD()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_COMMENT_ADD(MST_SVT_COMMENT_ADD other) : this()
		{
			this.svtId_ = other.svtId_;
			this.id_ = other.id_;
			this.priority_ = other.priority_;
			this.condType_ = other.condType_;
			this.condValue_ = other.condValue_;
			this.condValue2_ = other.condValue2_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_COMMENT_ADD Clone()
		{
			return new MST_SVT_COMMENT_ADD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_COMMENT_ADD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_COMMENT_ADD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.Id == other.Id && this.Priority == other.Priority && this.CondType == other.CondType && this.CondValue == other.CondValue && this.CondValue2 == other.CondValue2));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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
			if (this.CondValue2 != 0)
			{
				num ^= this.CondValue2.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
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
			if (this.CondValue2 != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CondValue2);
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
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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
			if (this.CondValue2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondValue2);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_COMMENT_ADD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
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
			if (other.CondValue2 != 0)
			{
				this.CondValue2 = other.CondValue2;
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
										this.CondValue2 = input.ReadInt32();
									}
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
						this.Id = input.ReadInt32();
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
