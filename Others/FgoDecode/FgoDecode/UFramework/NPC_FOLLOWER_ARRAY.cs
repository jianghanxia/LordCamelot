using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_FOLLOWER_ARRAY : IMessage, IMessage<NPC_FOLLOWER_ARRAY>, IEquatable<NPC_FOLLOWER_ARRAY>, IDeepCloneable<NPC_FOLLOWER_ARRAY>
	{
		public const int ItemsFieldNumber = 1;

		private static readonly MessageParser<NPC_FOLLOWER_ARRAY> _parser = new MessageParser<NPC_FOLLOWER_ARRAY>(() => new NPC_FOLLOWER_ARRAY());

		private static readonly FieldCodec<NPC_FOLLOWER> _repeated_items_codec = FieldCodec.ForMessage<NPC_FOLLOWER>(10u, NPC_FOLLOWER.Parser);

		private readonly RepeatedField<NPC_FOLLOWER> items_ = new RepeatedField<NPC_FOLLOWER>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_FOLLOWER_ARRAY.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_FOLLOWER_ARRAY> Parser => NPC_FOLLOWER_ARRAY._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcFollowerReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		public RepeatedField<NPC_FOLLOWER> Items => this.items_;

		[DebuggerNonUserCode]
		public NPC_FOLLOWER_ARRAY()
		{
		}

		[DebuggerNonUserCode]
		public NPC_FOLLOWER_ARRAY(NPC_FOLLOWER_ARRAY other) : this()
		{
			this.items_ = other.items_.Clone();
		}

		[DebuggerNonUserCode]
		public NPC_FOLLOWER_ARRAY Clone()
		{
			return new NPC_FOLLOWER_ARRAY(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_FOLLOWER_ARRAY);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_FOLLOWER_ARRAY other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || this.items_.Equals(other.items_));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			return num ^ this.items_.GetHashCode();
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			this.items_.WriteTo(output, NPC_FOLLOWER_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			return num + this.items_.CalculateSize(NPC_FOLLOWER_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(NPC_FOLLOWER_ARRAY other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
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
					input.SkipLastField();
				}
				else
				{
					this.items_.AddEntriesFrom(input, NPC_FOLLOWER_ARRAY._repeated_items_codec);
				}
			}
		}
	}
}
