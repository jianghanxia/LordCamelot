using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BOX_GACHA_TALK : IMessage, IMessage<MST_BOX_GACHA_TALK>, IEquatable<MST_BOX_GACHA_TALK>, IDeepCloneable<MST_BOX_GACHA_TALK>
	{
		public const int IdFieldNumber = 1;

		public const int NoFieldNumber = 2;

		public const int IsRareFieldNumber = 3;

		public const int BeforeDetailFieldNumber = 4;

		public const int AfterDetailFieldNumber = 5;

		public const int BeforeFaceFieldNumber = 6;

		public const int AfterFaceFieldNumber = 7;

		public const int UpdatedAtFieldNumber = 8;

		public const int CreatedAtFieldNumber = 9;

		private static readonly MessageParser<MST_BOX_GACHA_TALK> _parser = new MessageParser<MST_BOX_GACHA_TALK>(() => new MST_BOX_GACHA_TALK());

		private int id_;

		private int no_;

		private int isRare_;

		private ByteString beforeDetail_ = ByteString.Empty;

		private ByteString afterDetail_ = ByteString.Empty;

		private int beforeFace_;

		private int afterFace_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BOX_GACHA_TALK.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BOX_GACHA_TALK> Parser => MST_BOX_GACHA_TALK._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBoxGachaTalkReflection.Descriptor.MessageTypes[0];

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
		public int IsRare
		{
			get => this.isRare_;
			set
			{
				this.isRare_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString BeforeDetail
		{
			get => this.beforeDetail_;
			set
			{
				this.beforeDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString AfterDetail
		{
			get => this.afterDetail_;
			set
			{
				this.afterDetail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int BeforeFace
		{
			get => this.beforeFace_;
			set
			{
				this.beforeFace_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AfterFace
		{
			get => this.afterFace_;
			set
			{
				this.afterFace_ = value;
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
		public MST_BOX_GACHA_TALK()
		{
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_TALK(MST_BOX_GACHA_TALK other) : this()
		{
			this.id_ = other.id_;
			this.no_ = other.no_;
			this.isRare_ = other.isRare_;
			this.beforeDetail_ = other.beforeDetail_;
			this.afterDetail_ = other.afterDetail_;
			this.beforeFace_ = other.beforeFace_;
			this.afterFace_ = other.afterFace_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_BOX_GACHA_TALK Clone()
		{
			return new MST_BOX_GACHA_TALK(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BOX_GACHA_TALK);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BOX_GACHA_TALK other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.No == other.No && this.IsRare == other.IsRare && !(this.BeforeDetail != other.BeforeDetail) && !(this.AfterDetail != other.AfterDetail) && this.BeforeFace == other.BeforeFace && this.AfterFace == other.AfterFace && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
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
			if (this.IsRare != 0)
			{
				num ^= this.IsRare.GetHashCode();
			}
			if (this.BeforeDetail.Length != 0)
			{
				num ^= this.BeforeDetail.GetHashCode();
			}
			if (this.AfterDetail.Length != 0)
			{
				num ^= this.AfterDetail.GetHashCode();
			}
			if (this.BeforeFace != 0)
			{
				num ^= this.BeforeFace.GetHashCode();
			}
			if (this.AfterFace != 0)
			{
				num ^= this.AfterFace.GetHashCode();
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
			if (this.IsRare != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IsRare);
			}
			if (this.BeforeDetail.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteBytes(this.BeforeDetail);
			}
			if (this.AfterDetail.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteBytes(this.AfterDetail);
			}
			if (this.BeforeFace != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BeforeFace);
			}
			if (this.AfterFace != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.AfterFace);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(72);
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
			if (this.IsRare != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IsRare);
			}
			if (this.BeforeDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.BeforeDetail);
			}
			if (this.AfterDetail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.AfterDetail);
			}
			if (this.BeforeFace != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BeforeFace);
			}
			if (this.AfterFace != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterFace);
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
		public void MergeFrom(MST_BOX_GACHA_TALK other)
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
			if (other.IsRare != 0)
			{
				this.IsRare = other.IsRare;
			}
			if (other.BeforeDetail.Length != 0)
			{
				this.BeforeDetail = other.BeforeDetail;
			}
			if (other.AfterDetail.Length != 0)
			{
				this.AfterDetail = other.AfterDetail;
			}
			if (other.BeforeFace != 0)
			{
				this.BeforeFace = other.BeforeFace;
			}
			if (other.AfterFace != 0)
			{
				this.AfterFace = other.AfterFace;
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
							if (num2 != 34u)
							{
								if (num2 != 42u)
								{
									if (num2 != 48u)
									{
										if (num2 != 56u)
										{
											if (num2 != 64u)
											{
												if (num2 != 72u)
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
											this.AfterFace = input.ReadInt32();
										}
									}
									else
									{
										this.BeforeFace = input.ReadInt32();
									}
								}
								else
								{
									this.AfterDetail = input.ReadBytes();
								}
							}
							else
							{
								this.BeforeDetail = input.ReadBytes();
							}
						}
						else
						{
							this.IsRare = input.ReadInt32();
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
