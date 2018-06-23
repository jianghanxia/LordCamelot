using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_GROUP : IMessage, IMessage<MST_SVT_GROUP>, IEquatable<MST_SVT_GROUP>, IDeepCloneable<MST_SVT_GROUP>
	{
		public const int IdFieldNumber = 1;

		public const int SvtIdFieldNumber = 2;

		private static readonly MessageParser<MST_SVT_GROUP> _parser = new MessageParser<MST_SVT_GROUP>(() => new MST_SVT_GROUP());

		private int id_;

		private int svtId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_GROUP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_GROUP> Parser => MST_SVT_GROUP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtGroupReflection.Descriptor.MessageTypes[0];

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
		public int SvtId
		{
			get => this.svtId_;
			set
			{
				this.svtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_GROUP()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_GROUP(MST_SVT_GROUP other) : this()
		{
			this.id_ = other.id_;
			this.svtId_ = other.svtId_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_GROUP Clone()
		{
			return new MST_SVT_GROUP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_GROUP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_GROUP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.SvtId == other.SvtId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SvtId);
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
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_GROUP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
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
						this.SvtId = input.ReadInt32();
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
