using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_PRESENT_MESSAGE : IMessage, IMessage<MST_PRESENT_MESSAGE>, IEquatable<MST_PRESENT_MESSAGE>, IDeepCloneable<MST_PRESENT_MESSAGE>
	{
		public const int IdFieldNumber = 1;

		public const int MessageFieldNumber = 2;

		public const int UpdatedAtFieldNumber = 3;

		public const int CreatedAtFieldNumber = 4;

		private static readonly MessageParser<MST_PRESENT_MESSAGE> _parser = new MessageParser<MST_PRESENT_MESSAGE>(() => new MST_PRESENT_MESSAGE());

		private int id_;

		private ByteString message_ = ByteString.Empty;

		private ulong updatedAt_;

		private ulong createdAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_PRESENT_MESSAGE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_PRESENT_MESSAGE> Parser => MST_PRESENT_MESSAGE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstPresentMessageReflection.Descriptor.MessageTypes[0];

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
		public ByteString Message
		{
			get => this.message_;
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public MST_PRESENT_MESSAGE()
		{
		}

		[DebuggerNonUserCode]
		public MST_PRESENT_MESSAGE(MST_PRESENT_MESSAGE other) : this()
		{
			this.id_ = other.id_;
			this.message_ = other.message_;
			this.updatedAt_ = other.updatedAt_;
			this.createdAt_ = other.createdAt_;
		}

		[DebuggerNonUserCode]
		public MST_PRESENT_MESSAGE Clone()
		{
			return new MST_PRESENT_MESSAGE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_PRESENT_MESSAGE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_PRESENT_MESSAGE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Message != other.Message) && this.UpdatedAt == other.UpdatedAt && this.CreatedAt == other.CreatedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Message.Length != 0)
			{
				num ^= this.Message.GetHashCode();
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
			if (this.Message.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Message);
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
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Message.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
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
		public void MergeFrom(MST_PRESENT_MESSAGE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Message.Length != 0)
			{
				this.Message = other.Message;
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
						this.Message = input.ReadBytes();
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
