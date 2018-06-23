using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CLOSED_MESSAGE : IMessage, IMessage<MST_CLOSED_MESSAGE>, IEquatable<MST_CLOSED_MESSAGE>, IDeepCloneable<MST_CLOSED_MESSAGE>
	{
		public const int IdFieldNumber = 1;

		public const int MessageFieldNumber = 2;

		private static readonly MessageParser<MST_CLOSED_MESSAGE> _parser = new MessageParser<MST_CLOSED_MESSAGE>(() => new MST_CLOSED_MESSAGE());

		private int id_;

		private ByteString message_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CLOSED_MESSAGE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CLOSED_MESSAGE> Parser => MST_CLOSED_MESSAGE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstClosedMessageReflection.Descriptor.MessageTypes[0];

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
		public MST_CLOSED_MESSAGE()
		{
		}

		[DebuggerNonUserCode]
		public MST_CLOSED_MESSAGE(MST_CLOSED_MESSAGE other) : this()
		{
			this.id_ = other.id_;
			this.message_ = other.message_;
		}

		[DebuggerNonUserCode]
		public MST_CLOSED_MESSAGE Clone()
		{
			return new MST_CLOSED_MESSAGE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CLOSED_MESSAGE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CLOSED_MESSAGE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Message != other.Message)));
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
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_CLOSED_MESSAGE other)
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
						input.SkipLastField();
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
