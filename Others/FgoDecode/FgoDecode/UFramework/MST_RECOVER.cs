using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_RECOVER : IMessage, IMessage<MST_RECOVER>, IEquatable<MST_RECOVER>, IDeepCloneable<MST_RECOVER>
	{
		public const int IdFieldNumber = 1;

		public const int TargetFieldNumber = 2;

		public const int PriorityFieldNumber = 3;

		public const int RecoverTypeFieldNumber = 4;

		public const int TargetIdFieldNumber = 5;

		public const int NumFieldNumber = 6;

		private static readonly MessageParser<MST_RECOVER> _parser = new MessageParser<MST_RECOVER>(() => new MST_RECOVER());

		private int id_;

		private int target_;

		private int priority_;

		private int recoverType_;

		private int targetId_;

		private int num_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_RECOVER.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_RECOVER> Parser => MST_RECOVER._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstRecoverReflection.Descriptor.MessageTypes[0];

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
		public int Target
		{
			get => this.target_;
			set
			{
				this.target_ = value;
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
		public int RecoverType
		{
			get => this.recoverType_;
			set
			{
				this.recoverType_ = value;
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
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_RECOVER()
		{
		}

		[DebuggerNonUserCode]
		public MST_RECOVER(MST_RECOVER other) : this()
		{
			this.id_ = other.id_;
			this.target_ = other.target_;
			this.priority_ = other.priority_;
			this.recoverType_ = other.recoverType_;
			this.targetId_ = other.targetId_;
			this.num_ = other.num_;
		}

		[DebuggerNonUserCode]
		public MST_RECOVER Clone()
		{
			return new MST_RECOVER(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_RECOVER);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_RECOVER other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Target == other.Target && this.Priority == other.Priority && this.RecoverType == other.RecoverType && this.TargetId == other.TargetId && this.Num == other.Num));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.RecoverType != 0)
			{
				num ^= this.RecoverType.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
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
			if (this.Target != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Target);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Priority);
			}
			if (this.RecoverType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RecoverType);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TargetId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Num);
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
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.RecoverType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecoverType);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_RECOVER other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.RecoverType != 0)
			{
				this.RecoverType = other.RecoverType;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
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
										this.Num = input.ReadInt32();
									}
								}
								else
								{
									this.TargetId = input.ReadInt32();
								}
							}
							else
							{
								this.RecoverType = input.ReadInt32();
							}
						}
						else
						{
							this.Priority = input.ReadInt32();
						}
					}
					else
					{
						this.Target = input.ReadInt32();
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
