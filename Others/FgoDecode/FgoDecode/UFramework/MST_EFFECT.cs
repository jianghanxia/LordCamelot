using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EFFECT : IMessage, IMessage<MST_EFFECT>, IEquatable<MST_EFFECT>, IDeepCloneable<MST_EFFECT>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int SeFieldNumber = 3;

		public const int DelayTimeFieldNumber = 4;

		public const int FolderTypeFieldNumber = 5;

		public const int NumFieldNumber = 6;

		public const int NodeNameFieldNumber = 7;

		public const int UpdatedAtFieldNumber = 8;

		public const int CreatedAtFieldNumber = 9;

		private static readonly MessageParser<MST_EFFECT> _parser = new MessageParser<MST_EFFECT>(() => new MST_EFFECT());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private ByteString se_ = ByteString.Empty;

		private int delayTime_;

		private int folderType_;

		private int num_;

		private ByteString nodeName_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EFFECT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EFFECT> Parser => MST_EFFECT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEffectReflection.Descriptor.MessageTypes[0];

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
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public ByteString Se
		{
			get => this.se_;
			set
			{
				this.se_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int DelayTime
		{
			get => this.delayTime_;
			set
			{
				this.delayTime_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FolderType
		{
			get => this.folderType_;
			set
			{
				this.folderType_ = value;
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
		public ByteString NodeName
		{
			get => this.nodeName_;
			set
			{
				this.nodeName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_EFFECT()
		{
		}

		[DebuggerNonUserCode]
		public MST_EFFECT(MST_EFFECT other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.se_ = other.se_;
			this.delayTime_ = other.delayTime_;
			this.folderType_ = other.folderType_;
			this.num_ = other.num_;
			this.nodeName_ = other.nodeName_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_EFFECT Clone()
		{
			return new MST_EFFECT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EFFECT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EFFECT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && !(this.Se != other.Se) && this.DelayTime == other.DelayTime && this.FolderType == other.FolderType && this.Num == other.Num && !(this.NodeName != other.NodeName) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Se.Length != 0)
			{
				num ^= this.Se.GetHashCode();
			}
			if (this.DelayTime != 0)
			{
				num ^= this.DelayTime.GetHashCode();
			}
			if (this.FolderType != 0)
			{
				num ^= this.FolderType.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.NodeName.Length != 0)
			{
				num ^= this.NodeName.GetHashCode();
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Name);
			}
			if (this.Se.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Se);
			}
			if (this.DelayTime != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DelayTime);
			}
			if (this.FolderType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FolderType);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Num);
			}
			if (this.NodeName.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.NodeName);
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
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Se.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Se);
			}
			if (this.DelayTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DelayTime);
			}
			if (this.FolderType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FolderType);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this.NodeName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NodeName);
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
		public void MergeFrom(MST_EFFECT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Se.Length != 0)
			{
				this.Se = other.Se;
			}
			if (other.DelayTime != 0)
			{
				this.DelayTime = other.DelayTime;
			}
			if (other.FolderType != 0)
			{
				this.FolderType = other.FolderType;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			if (other.NodeName.Length != 0)
			{
				this.NodeName = other.NodeName;
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
					if (num2 != 18u)
					{
						if (num2 != 26u)
						{
							if (num2 != 32u)
							{
								if (num2 != 40u)
								{
									if (num2 != 48u)
									{
										if (num2 != 58u)
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
											this.NodeName = input.ReadBytes();
										}
									}
									else
									{
										this.Num = input.ReadInt32();
									}
								}
								else
								{
									this.FolderType = input.ReadInt32();
								}
							}
							else
							{
								this.DelayTime = input.ReadInt32();
							}
						}
						else
						{
							this.Se = input.ReadBytes();
						}
					}
					else
					{
						this.Name = input.ReadBytes();
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
