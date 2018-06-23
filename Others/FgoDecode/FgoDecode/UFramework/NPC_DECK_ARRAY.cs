using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class NPC_DECK_ARRAY : IMessage, IMessage<NPC_DECK_ARRAY>, IEquatable<NPC_DECK_ARRAY>, IDeepCloneable<NPC_DECK_ARRAY>
	{
		public const int ItemsFieldNumber = 1;

		private static readonly MessageParser<NPC_DECK_ARRAY> _parser = new MessageParser<NPC_DECK_ARRAY>(() => new NPC_DECK_ARRAY());

		private static readonly FieldCodec<NPC_DECK> _repeated_items_codec = FieldCodec.ForMessage<NPC_DECK>(10u, NPC_DECK.Parser);

		private readonly RepeatedField<NPC_DECK> items_ = new RepeatedField<NPC_DECK>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => NPC_DECK_ARRAY.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<NPC_DECK_ARRAY> Parser => NPC_DECK_ARRAY._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => NpcDeckReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		public RepeatedField<NPC_DECK> Items => this.items_;

		[DebuggerNonUserCode]
		public NPC_DECK_ARRAY()
		{
		}

		[DebuggerNonUserCode]
		public NPC_DECK_ARRAY(NPC_DECK_ARRAY other) : this()
		{
			this.items_ = other.items_.Clone();
		}

		[DebuggerNonUserCode]
		public NPC_DECK_ARRAY Clone()
		{
			return new NPC_DECK_ARRAY(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPC_DECK_ARRAY);
		}

		[DebuggerNonUserCode]
		public bool Equals(NPC_DECK_ARRAY other)
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
			this.items_.WriteTo(output, NPC_DECK_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			return num + this.items_.CalculateSize(NPC_DECK_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(NPC_DECK_ARRAY other)
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
					this.items_.AddEntriesFrom(input, NPC_DECK_ARRAY._repeated_items_codec);
				}
			}
		}
	}
}
