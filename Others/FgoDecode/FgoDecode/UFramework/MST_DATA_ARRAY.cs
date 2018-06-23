using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_DATA_ARRAY : IMessage<MST_DATA_ARRAY>
	{
		public const int ItemsFieldNumber = 1;

		private static readonly MessageParser<MST_DATA_ARRAY> _parser = new MessageParser<MST_DATA_ARRAY>(() => new MST_DATA_ARRAY());

		private static readonly FieldCodec<MST_DATA> _repeated_items_codec = FieldCodec.ForMessage<MST_DATA>(10u, MST_DATA.Parser);

		private readonly RepeatedField<MST_DATA> items_ = new RepeatedField<MST_DATA>();
		
		MessageDescriptor IMessage.Descriptor => Descriptor;
		
		public static MessageParser<MST_DATA_ARRAY> Parser => _parser;
		
		public static MessageDescriptor Descriptor => MstDataReflection.Descriptor.MessageTypes[1];
		
		public RepeatedField<MST_DATA> Items => items_;
		
		public MST_DATA_ARRAY()
		{
		}

		
		public MST_DATA_ARRAY(MST_DATA_ARRAY other) : this()
		{
			items_ = other.items_.Clone();
		}

		
		public MST_DATA_ARRAY Clone()
		{
			return new MST_DATA_ARRAY(this);
		}

		
		public override bool Equals(object other)
		{
			return Equals(other as MST_DATA_ARRAY);
		}

		
		public bool Equals(MST_DATA_ARRAY other)
		{
			return !ReferenceEquals(other, null) && (ReferenceEquals(other, this) || items_.Equals(other.items_));
		}

		
		public override int GetHashCode()
		{
			int num = 1;
			return num ^ items_.GetHashCode();
		}

		
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		
		public void WriteTo(CodedOutputStream output)
		{
			items_.WriteTo(output, _repeated_items_codec);
		}

		
		public int CalculateSize()
		{
			int num = 0;
			return num + items_.CalculateSize(_repeated_items_codec);
		}

		
		public void MergeFrom(MST_DATA_ARRAY other)
		{
			if (other == null)
			{
				return;
			}
			items_.Add(other.items_);
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
					items_.AddEntriesFrom(input, _repeated_items_codec);
				}
			}
		}
	}
}
