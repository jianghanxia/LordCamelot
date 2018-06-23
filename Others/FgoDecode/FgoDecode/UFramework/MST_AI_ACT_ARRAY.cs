using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_AI_ACT_ARRAY : IMessage<MST_AI_ACT_ARRAY>
	{
		public const int ItemsFieldNumber = 1;

		private static readonly MessageParser<MST_AI_ACT_ARRAY> _parser = new MessageParser<MST_AI_ACT_ARRAY>(() => new MST_AI_ACT_ARRAY());

		private static readonly FieldCodec<MST_AI_ACT> _repeated_items_codec = FieldCodec.ForMessage<MST_AI_ACT>(10u, MST_AI_ACT.Parser);


		MessageDescriptor IMessage.Descriptor => Descriptor;


		public static MessageParser<MST_AI_ACT_ARRAY> Parser => _parser;


		public static MessageDescriptor Descriptor => MstAiActReflection.Descriptor.MessageTypes[1];


		public RepeatedField<MST_AI_ACT> Items { get; } = new RepeatedField<MST_AI_ACT>();


		public MST_AI_ACT_ARRAY()
		{
		}


		public MST_AI_ACT_ARRAY(MST_AI_ACT_ARRAY other) : this()
		{
			Items = other.Items.Clone();
		}

		public MST_AI_ACT_ARRAY Clone()
		{
			return new MST_AI_ACT_ARRAY(this);
		}

		public bool Equals(MST_AI_ACT_ARRAY other)
		{
			return !ReferenceEquals(other, null) && (ReferenceEquals(other, this) || Items.Equals(other.Items));
		}


		public override int GetHashCode()
		{
			int num = 1;
			return num ^ Items.GetHashCode();
		}


		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}


		public void WriteTo(CodedOutputStream output)
		{
			Items.WriteTo(output, _repeated_items_codec);
		}


		public int CalculateSize()
		{
			int num = 0;
			return num + Items.CalculateSize(_repeated_items_codec);
		}


		public void MergeFrom(MST_AI_ACT_ARRAY other)
		{
			if (other == null)
			{
				return;
			}

			Items.Add(other.Items);
		}


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
					Items.AddEntriesFrom(input, _repeated_items_codec);
				}
			}
		}
	}
}