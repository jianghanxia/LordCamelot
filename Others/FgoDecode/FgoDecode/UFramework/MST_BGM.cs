using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_BGM : IMessage, IMessage<MST_BGM>, IEquatable<MST_BGM>, IDeepCloneable<MST_BGM>
	{
		public const int IdFieldNumber = 1;

		public const int FileNameFieldNumber = 2;

		private static readonly MessageParser<MST_BGM> _parser = new MessageParser<MST_BGM>(() => new MST_BGM());

		private int id_;

		private ByteString fileName_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_BGM.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_BGM> Parser => MST_BGM._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstBgmReflection.Descriptor.MessageTypes[0];

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
		public ByteString FileName
		{
			get => this.fileName_;
			set
			{
				this.fileName_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_BGM()
		{
		}

		[DebuggerNonUserCode]
		public MST_BGM(MST_BGM other) : this()
		{
			this.id_ = other.id_;
			this.fileName_ = other.fileName_;
		}

		[DebuggerNonUserCode]
		public MST_BGM Clone()
		{
			return new MST_BGM(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_BGM);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_BGM other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.FileName != other.FileName)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.FileName.Length != 0)
			{
				num ^= this.FileName.GetHashCode();
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
			if (this.FileName.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.FileName);
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
			if (this.FileName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.FileName);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_BGM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.FileName.Length != 0)
			{
				this.FileName = other.FileName;
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
						this.FileName = input.ReadBytes();
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
