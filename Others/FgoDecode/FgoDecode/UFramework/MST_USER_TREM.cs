using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_USER_TREM : IMessage, IMessage<MST_USER_TREM>, IEquatable<MST_USER_TREM>, IDeepCloneable<MST_USER_TREM>
	{
		public const int IdFieldNumber = 1;

		public const int DetailFieldNumber = 2;

		private static readonly MessageParser<MST_USER_TREM> _parser = new MessageParser<MST_USER_TREM>(() => new MST_USER_TREM());

		private int id_;

		private ByteString detail_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_USER_TREM.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_USER_TREM> Parser => MST_USER_TREM._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstUserTremReflection.Descriptor.MessageTypes[0];

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
		public ByteString Detail
		{
			get => this.detail_;
			set
			{
				this.detail_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_USER_TREM()
		{
		}

		[DebuggerNonUserCode]
		public MST_USER_TREM(MST_USER_TREM other) : this()
		{
			this.id_ = other.id_;
			this.detail_ = other.detail_;
		}

		[DebuggerNonUserCode]
		public MST_USER_TREM Clone()
		{
			return new MST_USER_TREM(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_USER_TREM);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_USER_TREM other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Detail != other.Detail)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Detail.Length != 0)
			{
				num ^= this.Detail.GetHashCode();
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
			if (this.Detail.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Detail);
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
			if (this.Detail.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Detail);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_USER_TREM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Detail.Length != 0)
			{
				this.Detail = other.Detail;
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
						this.Detail = input.ReadBytes();
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
