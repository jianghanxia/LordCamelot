using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CONSTANT : IMessage, IMessage<MST_CONSTANT>, IEquatable<MST_CONSTANT>, IDeepCloneable<MST_CONSTANT>
	{
		public const int NameFieldNumber = 1;

		public const int ValueFieldNumber = 2;

		public const int UpdatedAtFieldNumber = 3;

		public const int CreatedAtFieldNumber = 4;

		private static readonly MessageParser<MST_CONSTANT> _parser = new MessageParser<MST_CONSTANT>(() => new MST_CONSTANT());

		private ByteString name_ = ByteString.Empty;

		private int value_;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CONSTANT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CONSTANT> Parser => MST_CONSTANT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstConstantReflection.Descriptor.MessageTypes[0];

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
		public int Value
		{
			get => this.value_;
			set
			{
				this.value_ = value;
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
		public MST_CONSTANT()
		{
		}

		[DebuggerNonUserCode]
		public MST_CONSTANT(MST_CONSTANT other) : this()
		{
			this.name_ = other.name_;
			this.value_ = other.value_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_CONSTANT Clone()
		{
			return new MST_CONSTANT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CONSTANT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CONSTANT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (!(this.Name != other.Name) && this.Value == other.Value && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Name);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this.UpdatedAt != 0uL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.UpdatedAt);
			}
			if (this.CreatedAt != 0uL)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.CreatedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
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
		public void MergeFrom(MST_CONSTANT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
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
				if (num2 != 10u)
				{
					if (num2 != 16u)
					{
						if (num2 != 24u)
						{
							if (num2 != 32u)
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
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadBytes();
				}
			}
		}
	}
}
