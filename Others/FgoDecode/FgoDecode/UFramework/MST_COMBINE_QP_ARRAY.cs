using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_COMBINE_QP_ARRAY : IMessage, IMessage<MST_COMBINE_QP_ARRAY>, IEquatable<MST_COMBINE_QP_ARRAY>, IDeepCloneable<MST_COMBINE_QP_ARRAY>
	{
		public const int ItemsFieldNumber = 1;

		private static readonly MessageParser<MST_COMBINE_QP_ARRAY> _parser = new MessageParser<MST_COMBINE_QP_ARRAY>(() => new MST_COMBINE_QP_ARRAY());

		private static readonly FieldCodec<MST_COMBINE_QP> _repeated_items_codec = FieldCodec.ForMessage<MST_COMBINE_QP>(10u, MST_COMBINE_QP.Parser);

		private readonly RepeatedField<MST_COMBINE_QP> items_ = new RepeatedField<MST_COMBINE_QP>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_COMBINE_QP_ARRAY.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_COMBINE_QP_ARRAY> Parser => MST_COMBINE_QP_ARRAY._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstCombineQpReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		public RepeatedField<MST_COMBINE_QP> Items => this.items_;

		[DebuggerNonUserCode]
		public MST_COMBINE_QP_ARRAY()
		{
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_QP_ARRAY(MST_COMBINE_QP_ARRAY other) : this()
		{
			this.items_ = other.items_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_COMBINE_QP_ARRAY Clone()
		{
			return new MST_COMBINE_QP_ARRAY(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_COMBINE_QP_ARRAY);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_COMBINE_QP_ARRAY other)
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
			this.items_.WriteTo(output, MST_COMBINE_QP_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			return num + this.items_.CalculateSize(MST_COMBINE_QP_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_COMBINE_QP_ARRAY other)
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
					this.items_.AddEntriesFrom(input, MST_COMBINE_QP_ARRAY._repeated_items_codec);
				}
			}
		}
	}
}
