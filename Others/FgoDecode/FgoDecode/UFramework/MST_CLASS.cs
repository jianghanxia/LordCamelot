using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CLASS : IMessage, IMessage<MST_CLASS>, IEquatable<MST_CLASS>, IDeepCloneable<MST_CLASS>
	{
		public const int IdFieldNumber = 1;

		public const int AttriFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int AttackRateFieldNumber = 4;

		public const int ImageIdFieldNumber = 5;

		public const int IconImageIdFieldNumber = 6;

		public const int GroupTypeFieldNumber = 7;

		public const int PriorityFieldNumber = 8;

		private static readonly MessageParser<MST_CLASS> _parser = new MessageParser<MST_CLASS>(() => new MST_CLASS());

		private int id_;

		private int attri_;

		private ByteString name_ = ByteString.Empty;

		private int attackRate_;

		private int imageId_;

		private int iconImageId_;

		private int groupType_;

		private int priority_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CLASS.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CLASS> Parser => MST_CLASS._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstClassReflection.Descriptor.MessageTypes[0];

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
		public int Attri
		{
			get => this.attri_;
			set
			{
				this.attri_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int AttackRate
		{
			get => this.attackRate_;
			set
			{
				this.attackRate_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ImageId
		{
			get => this.imageId_;
			set
			{
				this.imageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int IconImageId
		{
			get => this.iconImageId_;
			set
			{
				this.iconImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GroupType
		{
			get => this.groupType_;
			set
			{
				this.groupType_ = value;
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
		public MST_CLASS()
		{
		}

		[DebuggerNonUserCode]
		public MST_CLASS(MST_CLASS other) : this()
		{
			this.id_ = other.id_;
			this.attri_ = other.attri_;
			this.name_ = other.name_;
			this.attackRate_ = other.attackRate_;
			this.imageId_ = other.imageId_;
			this.iconImageId_ = other.iconImageId_;
			this.groupType_ = other.groupType_;
			this.priority_ = other.priority_;
		}

		[DebuggerNonUserCode]
		public MST_CLASS Clone()
		{
			return new MST_CLASS(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CLASS);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CLASS other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Attri == other.Attri && !(this.Name != other.Name) && this.AttackRate == other.AttackRate && this.ImageId == other.ImageId && this.IconImageId == other.IconImageId && this.GroupType == other.GroupType && this.Priority == other.Priority));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Attri != 0)
			{
				num ^= this.Attri.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.AttackRate != 0)
			{
				num ^= this.AttackRate.GetHashCode();
			}
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.IconImageId != 0)
			{
				num ^= this.IconImageId.GetHashCode();
			}
			if (this.GroupType != 0)
			{
				num ^= this.GroupType.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
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
			if (this.Attri != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Attri);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.AttackRate != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AttackRate);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ImageId);
			}
			if (this.IconImageId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IconImageId);
			}
			if (this.GroupType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.GroupType);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Priority);
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
			if (this.Attri != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Attri);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.AttackRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttackRate);
			}
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.IconImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IconImageId);
			}
			if (this.GroupType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupType);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_CLASS other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Attri != 0)
			{
				this.Attri = other.Attri;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.AttackRate != 0)
			{
				this.AttackRate = other.AttackRate;
			}
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.IconImageId != 0)
			{
				this.IconImageId = other.IconImageId;
			}
			if (other.GroupType != 0)
			{
				this.GroupType = other.GroupType;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
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
						if (num2 != 26u)
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
												input.SkipLastField();
											}
											else
											{
												this.Priority = input.ReadInt32();
											}
										}
										else
										{
											this.GroupType = input.ReadInt32();
										}
									}
									else
									{
										this.IconImageId = input.ReadInt32();
									}
								}
								else
								{
									this.ImageId = input.ReadInt32();
								}
							}
							else
							{
								this.AttackRate = input.ReadInt32();
							}
						}
						else
						{
							this.Name = input.ReadBytes();
						}
					}
					else
					{
						this.Attri = input.ReadInt32();
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
