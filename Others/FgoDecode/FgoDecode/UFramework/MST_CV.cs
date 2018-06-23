using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CV : IMessage, IMessage<MST_CV>, IEquatable<MST_CV>, IDeepCloneable<MST_CV>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		public const int CommentFieldNumber = 3;

		private static readonly MessageParser<MST_CV> _parser = new MessageParser<MST_CV>(() => new MST_CV());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		private ByteString comment_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CV.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CV> Parser => MST_CV._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCvReflection.Descriptor.MessageTypes[0];

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
		public ByteString Comment
		{
			get => this.comment_;
			set
			{
				this.comment_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_CV()
		{
		}

		[DebuggerNonUserCode]
		public MST_CV(MST_CV other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
			this.comment_ = other.comment_;
		}

		[DebuggerNonUserCode]
		public MST_CV Clone()
		{
			return new MST_CV(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CV);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CV other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name) && !(this.Comment != other.Comment)));
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Name);
			}
			if (this.Comment.Length != 0)
			{
				output.WriteRawTag(26);
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
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
			}
			if (this.Comment.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Comment);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_CV other)
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
						if (num2 != 26u)
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
