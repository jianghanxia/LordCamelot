using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EQUIP_IMAGE : IMessage, IMessage<MST_EQUIP_IMAGE>, IEquatable<MST_EQUIP_IMAGE>, IDeepCloneable<MST_EQUIP_IMAGE>
	{
		public const int IdFieldNumber = 1;

		public const int OffsetXFieldNumber = 2;

		public const int OffsetYFieldNumber = 3;

		public const int OffsetXMyroomFieldNumber = 4;

		public const int OffsetYMyroomFieldNumber = 5;

		public const int UpdatedAtFieldNumber = 6;

		public const int CreatedAtFieldNumber = 7;

		private static readonly MessageParser<MST_EQUIP_IMAGE> _parser = new MessageParser<MST_EQUIP_IMAGE>(() => new MST_EQUIP_IMAGE());

		private int id_;

		private int offsetX_;

		private int offsetY_;

		private int offsetXMyroom_;

		private int offsetYMyroom_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EQUIP_IMAGE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EQUIP_IMAGE> Parser => MST_EQUIP_IMAGE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEquipImageReflection.Descriptor.MessageTypes[0];

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
		public int OffsetX
		{
			get => this.offsetX_;
			set
			{
				this.offsetX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetY
		{
			get => this.offsetY_;
			set
			{
				this.offsetY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetXMyroom
		{
			get => this.offsetXMyroom_;
			set
			{
				this.offsetXMyroom_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetYMyroom
		{
			get => this.offsetYMyroom_;
			set
			{
				this.offsetYMyroom_ = value;
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
		public MST_EQUIP_IMAGE()
		{
		}

		[DebuggerNonUserCode]
		public MST_EQUIP_IMAGE(MST_EQUIP_IMAGE other) : this()
		{
			this.id_ = other.id_;
			this.offsetX_ = other.offsetX_;
			this.offsetY_ = other.offsetY_;
			this.offsetXMyroom_ = other.offsetXMyroom_;
			this.offsetYMyroom_ = other.offsetYMyroom_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EQUIP_IMAGE Clone()
		{
			return new MST_EQUIP_IMAGE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EQUIP_IMAGE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EQUIP_IMAGE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.OffsetX == other.OffsetX && this.OffsetY == other.OffsetY && this.OffsetXMyroom == other.OffsetXMyroom && this.OffsetYMyroom == other.OffsetYMyroom && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.OffsetX != 0)
			{
				num ^= this.OffsetX.GetHashCode();
			}
			if (this.OffsetY != 0)
			{
				num ^= this.OffsetY.GetHashCode();
			}
			if (this.OffsetXMyroom != 0)
			{
				num ^= this.OffsetXMyroom.GetHashCode();
			}
			if (this.OffsetYMyroom != 0)
			{
				num ^= this.OffsetYMyroom.GetHashCode();
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
			if (this.OffsetX != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OffsetX);
			}
			if (this.OffsetY != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OffsetY);
			}
			if (this.OffsetXMyroom != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OffsetXMyroom);
			}
			if (this.OffsetYMyroom != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.OffsetYMyroom);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(56);
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
			if (this.OffsetX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetX);
			}
			if (this.OffsetY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetY);
			}
			if (this.OffsetXMyroom != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetXMyroom);
			}
			if (this.OffsetYMyroom != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetYMyroom);
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
		public void MergeFrom(MST_EQUIP_IMAGE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.OffsetX != 0)
			{
				this.OffsetX = other.OffsetX;
			}
			if (other.OffsetY != 0)
			{
				this.OffsetY = other.OffsetY;
			}
			if (other.OffsetXMyroom != 0)
			{
				this.OffsetXMyroom = other.OffsetXMyroom;
			}
			if (other.OffsetYMyroom != 0)
			{
				this.OffsetYMyroom = other.OffsetYMyroom;
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
									this.OffsetYMyroom = input.ReadInt32();
								}
							}
							else
							{
								this.OffsetXMyroom = input.ReadInt32();
							}
						}
						else
						{
							this.OffsetY = input.ReadInt32();
						}
					}
					else
					{
						this.OffsetX = input.ReadInt32();
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
