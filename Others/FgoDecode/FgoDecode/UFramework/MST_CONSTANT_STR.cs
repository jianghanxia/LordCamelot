using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CONSTANT_STR : IMessage, IMessage<MST_CONSTANT_STR>, IEquatable<MST_CONSTANT_STR>, IDeepCloneable<MST_CONSTANT_STR>
	{
		public const int NameFieldNumber = 1;

		public const int ValueFieldNumber = 2;

		public const int UpdatedAtFieldNumber = 3;

		public const int CreatedAtFieldNumber = 4;

		private static readonly MessageParser<MST_CONSTANT_STR> _parser = new MessageParser<MST_CONSTANT_STR>(() => new MST_CONSTANT_STR());

		private ByteString name_ = ByteString.Empty;

		private ByteString value_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CONSTANT_STR.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CONSTANT_STR> Parser => MST_CONSTANT_STR._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstConstantStrReflection.Descriptor.MessageTypes[0];

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
		public ByteString Value
		{
			get => this.value_;
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_CONSTANT_STR()
		{
		}

		[DebuggerNonUserCode]
		public MST_CONSTANT_STR(MST_CONSTANT_STR other) : this()
		{
			this.name_ = other.name_;
			this.value_ = other.value_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_CONSTANT_STR Clone()
		{
			return new MST_CONSTANT_STR(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CONSTANT_STR);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CONSTANT_STR other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (!(this.Name != other.Name) && !(this.Value != other.Value) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Value.Length != 0)
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
			if (this.Value.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Value);
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
			if (this.Value.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Value);
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
		public void MergeFrom(MST_CONSTANT_STR other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Value.Length != 0)
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
					if (num2 != 18u)
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
						this.Value = input.ReadBytes();
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
