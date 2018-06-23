using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SET_ITEM : IMessage, IMessage<MST_SET_ITEM>, IEquatable<MST_SET_ITEM>, IDeepCloneable<MST_SET_ITEM>
	{
		public const int IdFieldNumber = 1;

		public const int PurchaseTypeFieldNumber = 2;

		public const int TargetIdFieldNumber = 3;

		public const int SetNumFieldNumber = 4;

		public const int UpdatedAtFieldNumber = 5;

		public const int CreatedAtFieldNumber = 6;

		private static readonly MessageParser<MST_SET_ITEM> _parser = new MessageParser<MST_SET_ITEM>(() => new MST_SET_ITEM());

		private int id_;

		private int purchaseType_;

		private int targetId_;

		private int setNum_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SET_ITEM.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SET_ITEM> Parser => MST_SET_ITEM._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSetItemReflection.Descriptor.MessageTypes[0];

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
		public int PurchaseType
		{
			get => this.purchaseType_;
			set
			{
				this.purchaseType_ = value;
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
		public int SetNum
		{
			get => this.setNum_;
			set
			{
				this.setNum_ = value;
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
		public MST_SET_ITEM()
		{
		}

		[DebuggerNonUserCode]
		public MST_SET_ITEM(MST_SET_ITEM other) : this()
		{
			this.id_ = other.id_;
			this.purchaseType_ = other.purchaseType_;
			this.targetId_ = other.targetId_;
			this.setNum_ = other.setNum_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_SET_ITEM Clone()
		{
			return new MST_SET_ITEM(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SET_ITEM);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SET_ITEM other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.PurchaseType == other.PurchaseType && this.TargetId == other.TargetId && this.SetNum == other.SetNum && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PurchaseType != 0)
			{
				num ^= this.PurchaseType.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.SetNum != 0)
			{
				num ^= this.SetNum.GetHashCode();
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
			if (this.PurchaseType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PurchaseType);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetId);
			}
			if (this.SetNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SetNum);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(48);
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
			if (this.PurchaseType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PurchaseType);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.SetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SetNum);
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
		public void MergeFrom(MST_SET_ITEM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.PurchaseType != 0)
			{
				this.PurchaseType = other.PurchaseType;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.SetNum != 0)
			{
				this.SetNum = other.SetNum;
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
								if (num2 != 40u)
								{
									if (num2 != 48u)
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
								this.SetNum = input.ReadInt32();
							}
						}
						else
						{
							this.TargetId = input.ReadInt32();
						}
					}
					else
					{
						this.PurchaseType = input.ReadInt32();
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
