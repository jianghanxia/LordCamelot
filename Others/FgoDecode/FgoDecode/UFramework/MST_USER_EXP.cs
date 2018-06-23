using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_USER_EXP : IMessage, IMessage<MST_USER_EXP>, IEquatable<MST_USER_EXP>, IDeepCloneable<MST_USER_EXP>
	{
		public const int LvFieldNumber = 1;

		public const int ExpFieldNumber = 2;

		public const int AddActMaxFieldNumber = 3;

		public const int AddFriendMaxFieldNumber = 4;

		public const int AddCostMaxFieldNumber = 5;

		public const int GiftIdFieldNumber = 6;

		public const int CommentFieldNumber = 7;

		private static readonly MessageParser<MST_USER_EXP> _parser = new MessageParser<MST_USER_EXP>(() => new MST_USER_EXP());

		private int lv_;

		private int exp_;

		private int addActMax_;

		private int addFriendMax_;

		private int addCostMax_;

		private int giftId_;

		private ByteString comment_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_USER_EXP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_USER_EXP> Parser => MST_USER_EXP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstUserExpReflection.Descriptor.MessageTypes[0];

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
		public int Exp
		{
			get => this.exp_;
			set
			{
				this.exp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddActMax
		{
			get => this.addActMax_;
			set
			{
				this.addActMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddFriendMax
		{
			get => this.addFriendMax_;
			set
			{
				this.addFriendMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddCostMax
		{
			get => this.addCostMax_;
			set
			{
				this.addCostMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GiftId
		{
			get => this.giftId_;
			set
			{
				this.giftId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Comment
		{
			get => this.comment_;
			set
			{
				this.comment_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_USER_EXP()
		{
		}

		[DebuggerNonUserCode]
		public MST_USER_EXP(MST_USER_EXP other) : this()
		{
			this.lv_ = other.lv_;
			this.exp_ = other.exp_;
			this.addActMax_ = other.addActMax_;
			this.addFriendMax_ = other.addFriendMax_;
			this.addCostMax_ = other.addCostMax_;
			this.giftId_ = other.giftId_;
			this.comment_ = other.comment_;
		}

		[DebuggerNonUserCode]
		public MST_USER_EXP Clone()
		{
			return new MST_USER_EXP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_USER_EXP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_USER_EXP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Lv == other.Lv && this.Exp == other.Exp && this.AddActMax == other.AddActMax && this.AddFriendMax == other.AddFriendMax && this.AddCostMax == other.AddCostMax && this.GiftId == other.GiftId && !(this.Comment != other.Comment)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Lv != 0)
			{
				num ^= this.Lv.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this.AddActMax != 0)
			{
				num ^= this.AddActMax.GetHashCode();
			}
			if (this.AddFriendMax != 0)
			{
				num ^= this.AddFriendMax.GetHashCode();
			}
			if (this.AddCostMax != 0)
			{
				num ^= this.AddCostMax.GetHashCode();
			}
			if (this.GiftId != 0)
			{
				num ^= this.GiftId.GetHashCode();
			}
			if (this.Comment.Length != 0)
			{
				num ^= this.Comment.GetHashCode();
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
			if (this.Lv != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Lv);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Exp);
			}
			if (this.AddActMax != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AddActMax);
			}
			if (this.AddFriendMax != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AddFriendMax);
			}
			if (this.AddCostMax != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AddCostMax);
			}
			if (this.GiftId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GiftId);
			}
			if (this.Comment.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.Comment);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Lv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Lv);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			if (this.AddActMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddActMax);
			}
			if (this.AddFriendMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddFriendMax);
			}
			if (this.AddCostMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddCostMax);
			}
			if (this.GiftId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GiftId);
			}
			if (this.Comment.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Comment);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_USER_EXP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Lv != 0)
			{
				this.Lv = other.Lv;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			if (other.AddActMax != 0)
			{
				this.AddActMax = other.AddActMax;
			}
			if (other.AddFriendMax != 0)
			{
				this.AddFriendMax = other.AddFriendMax;
			}
			if (other.AddCostMax != 0)
			{
				this.AddCostMax = other.AddCostMax;
			}
			if (other.GiftId != 0)
			{
				this.GiftId = other.GiftId;
			}
			if (other.Comment.Length != 0)
			{
				this.Comment = other.Comment;
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
										if (num2 != 58u)
										{
											input.SkipLastField();
										}
										else
										{
											this.Comment = input.ReadBytes();
										}
									}
									else
									{
										this.GiftId = input.ReadInt32();
									}
								}
								else
								{
									this.AddCostMax = input.ReadInt32();
								}
							}
							else
							{
								this.AddFriendMax = input.ReadInt32();
							}
						}
						else
						{
							this.AddActMax = input.ReadInt32();
						}
					}
					else
					{
						this.Exp = input.ReadInt32();
					}
				}
				else
				{
					this.Lv = input.ReadInt32();
				}
			}
		}
	}
}
