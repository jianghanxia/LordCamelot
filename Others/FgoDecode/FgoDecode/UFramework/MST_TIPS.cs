using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_TIPS : IMessage, IMessage<MST_TIPS>, IEquatable<MST_TIPS>, IDeepCloneable<MST_TIPS>
	{
		public const int IdFieldNumber = 1;

		public const int CommentFieldNumber = 2;

		private static readonly MessageParser<MST_TIPS> _parser = new MessageParser<MST_TIPS>(() => new MST_TIPS());

		private int id_;

		private ByteString comment_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_TIPS.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_TIPS> Parser => MST_TIPS._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstTipsReflection.Descriptor.MessageTypes[0];

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
		public ByteString Comment
		{
			get => this.comment_;
			set
			{
				this.comment_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_TIPS()
		{
		}

		[DebuggerNonUserCode]
		public MST_TIPS(MST_TIPS other) : this()
		{
			this.id_ = other.id_;
			this.comment_ = other.comment_;
		}

		[DebuggerNonUserCode]
		public MST_TIPS Clone()
		{
			return new MST_TIPS(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_TIPS);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_TIPS other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Comment != other.Comment)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Comment.Length != 0)
			{
				num ^= this.Comment.GetHashCode();
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
			if (this.Comment.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Comment);
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
			if (this.Comment.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Comment);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_TIPS other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Comment.Length != 0)
			{
				this.Comment = other.Comment;
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
						this.Comment = input.ReadBytes();
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
