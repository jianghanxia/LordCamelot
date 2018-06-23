using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_COMBINE : IMessage, IMessage<MST_COMBINE>, IEquatable<MST_COMBINE>, IDeepCloneable<MST_COMBINE>
	{
		public const int IdFieldNumber = 1;

		public const int TypeFieldNumber = 2;

		private static readonly MessageParser<MST_COMBINE> _parser = new MessageParser<MST_COMBINE>(() => new MST_COMBINE());

		private int id_;

		private int type_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_COMBINE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_COMBINE> Parser => MST_COMBINE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCombineReflection.Descriptor.MessageTypes[0];

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
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_COMBINE()
		{
		}

		[DebuggerNonUserCode]
		public MST_COMBINE(MST_COMBINE other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
		}

		[DebuggerNonUserCode]
		public MST_COMBINE Clone()
		{
			return new MST_COMBINE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_COMBINE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_COMBINE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.Type == other.Type));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
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
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
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
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_COMBINE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
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
						input.SkipLastField();
					}
					else
					{
						this.Type = input.ReadInt32();
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
