using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BOX_GACHA_BASE : IMessage, IMessage<MST_BOX_GACHA_BASE>, IEquatable<MST_BOX_GACHA_BASE>, IDeepCloneable<MST_BOX_GACHA_BASE>
	{
		public const int IdFieldNumber = 1;

		public const int NoFieldNumber = 2;

		public const int TypeFieldNumber = 3;

		public const int TargetIdFieldNumber = 4;

		public const int IsRareFieldNumber = 5;

		public const int IconIdFieldNumber = 6;

		public const int BannerIdFieldNumber = 7;

		public const int PriorityFieldNumber = 8;

		public const int MaxNumFieldNumber = 9;

		public const int DetailFieldNumber = 10;

		public const int UpdatedAtFieldNumber = 11;

		public const int CreatedAtFieldNumber = 12;

		private static readonly MessageParser<MST_BOX_GACHA_BASE> _parser = new MessageParser<MST_BOX_GACHA_BASE>(() => new MST_BOX_GACHA_BASE());

		private int id_;

		private int no_;

		private int type_;

		private int targetId_;

		private int isRare_;

		private int iconId_;

		private int bannerId_;

		private int priority_;

		private int maxNum_;

		private ByteString detail_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BOX_GACHA_BASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BOX_GACHA_BASE> Parser => MST_BOX_GACHA_BASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBoxGachaBaseReflection.Descriptor.MessageTypes[0];

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
		public int No
		{
			get => this.no_;
			set
			{
				this.no_ = value;
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
		public int TargetId
		{
			get => this.targetId_;
			set
			{
				this.targetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IsRare
		{
			get => this.isRare_;
			set
			{
				this.isRare_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IconId
		{
			get => this.iconId_;
			set
			{
				this.iconId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int BannerId
		{
			get => this.bannerId_;
			set
			{
				this.bannerId_ = value;
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
		public int MaxNum
		{
			get => this.maxNum_;
			set
			{
				this.maxNum_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Detail
		{
			get => this.detail_;
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_BOX_GACHA_BASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_BASE(MST_BOX_GACHA_BASE other) : this()
		{
			this.id_ = other.id_;
			this.no_ = other.no_;
			this.type_ = other.type_;
			this.targetId_ = other.targetId_;
			this.isRare_ = other.isRare_;
			this.iconId_ = other.iconId_;
			this.bannerId_ = other.bannerId_;
			this.priority_ = other.priority_;
			this.maxNum_ = other.maxNum_;
			this.detail_ = other.detail_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_BASE Clone()
		{
			return new MST_BOX_GACHA_BASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BOX_GACHA_BASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BOX_GACHA_BASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.No == other.No && this.Type == other.Type && this.TargetId == other.TargetId && this.IsRare == other.IsRare && this.IconId == other.IconId && this.BannerId == other.BannerId && this.Priority == other.Priority && this.MaxNum == other.MaxNum && !(this.Detail != other.Detail) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.No != 0)
			{
				num ^= this.No.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.IsRare != 0)
			{
				num ^= this.IsRare.GetHashCode();
			}
			if (this.IconId != 0)
			{
				num ^= this.IconId.GetHashCode();
			}
			if (this.BannerId != 0)
			{
				num ^= this.BannerId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.MaxNum != 0)
			{
				num ^= this.MaxNum.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
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
			if (this.No != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.No);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TargetId);
			}
			if (this.IsRare != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IsRare);
			}
			if (this.IconId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IconId);
			}
			if (this.BannerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BannerId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Priority);
			}
			if (this.MaxNum != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MaxNum);
			}
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteBytes(this.Detail);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(88);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(96);
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
			if (this.No != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.No);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this.IsRare != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsRare);
			}
			if (this.IconId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconId);
			}
			if (this.BannerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BannerId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.MaxNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxNum);
			}
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
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
		public void MergeFrom(MST_BOX_GACHA_BASE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.No != 0)
			{
				this.No = other.No;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			if (other.IsRare != 0)
			{
				this.IsRare = other.IsRare;
			}
			if (other.IconId != 0)
			{
				this.IconId = other.IconId;
			}
			if (other.BannerId != 0)
			{
				this.BannerId = other.BannerId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.MaxNum != 0)
			{
				this.MaxNum = other.MaxNum;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
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
										if (num2 != 56u)
										{
											if (num2 != 64u)
											{
												if (num2 != 72u)
												{
													if (num2 != 82u)
													{
														if (num2 != 88u)
														{
															if (num2 != 96u)
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
														this.Detail = input.ReadBytes();
													}
												}
												else
												{
													this.MaxNum = input.ReadInt32();
												}
											}
											else
											{
												this.Priority = input.ReadInt32();
											}
										}
										else
										{
											this.BannerId = input.ReadInt32();
										}
									}
									else
									{
										this.IconId = input.ReadInt32();
									}
								}
								else
								{
									this.IsRare = input.ReadInt32();
								}
							}
							else
							{
								this.TargetId = input.ReadInt32();
							}
						}
						else
						{
							this.Type = input.ReadInt32();
						}
					}
					else
					{
						this.No = input.ReadInt32();
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
