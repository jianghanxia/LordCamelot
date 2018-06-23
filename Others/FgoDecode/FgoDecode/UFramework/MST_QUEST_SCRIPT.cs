using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_QUEST_SCRIPT : IMessage, IMessage<MST_QUEST_SCRIPT>, IEquatable<MST_QUEST_SCRIPT>, IDeepCloneable<MST_QUEST_SCRIPT>
	{
		public const int IdFieldNumber = 1;

		public const int NameFieldNumber = 2;

		private static readonly MessageParser<MST_QUEST_SCRIPT> _parser = new MessageParser<MST_QUEST_SCRIPT>(() => new MST_QUEST_SCRIPT());

		private int id_;

		private ByteString name_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_QUEST_SCRIPT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_QUEST_SCRIPT> Parser => MST_QUEST_SCRIPT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstQuestScriptReflection.Descriptor.MessageTypes[0];

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
		public MST_QUEST_SCRIPT()
		{
		}

		[DebuggerNonUserCode]
		public MST_QUEST_SCRIPT(MST_QUEST_SCRIPT other) : this()
		{
			this.id_ = other.id_;
			this.name_ = other.name_;
		}

		[DebuggerNonUserCode]
		public MST_QUEST_SCRIPT Clone()
		{
			return new MST_QUEST_SCRIPT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_QUEST_SCRIPT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_QUEST_SCRIPT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && !(this.Name != other.Name)));
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
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_QUEST_SCRIPT other)
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
