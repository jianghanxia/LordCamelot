using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_GIFT : IMessage, IMessage<MST_GIFT>, IEquatable<MST_GIFT>, IDeepCloneable<MST_GIFT>
	{
		public const int IdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		public const int ObjectIdFieldNumber = 3;

		public const int PriorityFieldNumber = 4;

		public const int NumFieldNumber = 5;

		public const int LimitCountFieldNumber = 6;

		public const int LvFieldNumber = 7;

		private static readonly MessageParser<MST_GIFT> _parser = new MessageParser<MST_GIFT>(() => new MST_GIFT());

		private int id_;

		private int type_;

		private int objectId_;

		private int priority_;

		private int num_;

		private int limitCount_;

		private int lv_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_GIFT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_GIFT> Parser => MST_GIFT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstGiftReflection.Descriptor.MessageTypes[0];

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ObjectId
		{
			get => this.objectId_;
			set
			{
				this.objectId_ = value;
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
		public int Num
		{
			get => this.num_;
			set
			{
				this.num_ = value;
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
		public int Lv
		{
			get => this.lv_;
			set
			{
				this.lv_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_GIFT()
		{
		}

		[DebuggerNonUserCode]
		public MST_GIFT(MST_GIFT other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this.objectId_ = other.objectId_;
			this.priority_ = other.priority_;
			this.num_ = other.num_;
			this.limitCount_ = other.limitCount_;
			this.lv_ = other.lv_;
		}

		[DebuggerNonUserCode]
		public MST_GIFT Clone()
		{
			return new MST_GIFT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_GIFT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_GIFT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Type == other.Type && this.ObjectId == other.ObjectId && this.Priority == other.Priority && this.Num == other.Num && this.LimitCount == other.LimitCount && this.Lv == other.Lv));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ObjectId != 0)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
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
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.ObjectId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ObjectId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Priority);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Num);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LimitCount);
			}
			if (this.Lv != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Lv);
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
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.ObjectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ObjectId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_GIFT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.ObjectId != 0)
			{
				this.ObjectId = other.ObjectId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
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
											input.SkipLastField();
										}
										else
										{
											this.Lv = input.ReadInt32();
										}
									}
									else
									{
										this.LimitCount = input.ReadInt32();
									}
								}
								else
								{
									this.Num = input.ReadInt32();
								}
							}
							else
							{
								this.Priority = input.ReadInt32();
							}
						}
						else
						{
							this.ObjectId = input.ReadInt32();
						}
					}
					else
					{
						this.Type = input.ReadInt32();
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
