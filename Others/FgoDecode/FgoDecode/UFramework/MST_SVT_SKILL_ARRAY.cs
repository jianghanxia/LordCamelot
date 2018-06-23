using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_SKILL_ARRAY : IMessage, IMessage<MST_SVT_SKILL_ARRAY>, IEquatable<MST_SVT_SKILL_ARRAY>, IDeepCloneable<MST_SVT_SKILL_ARRAY>
	{
		public const int ItemsFieldNumber = 1;

		private static readonly MessageParser<MST_SVT_SKILL_ARRAY> _parser = new MessageParser<MST_SVT_SKILL_ARRAY>(() => new MST_SVT_SKILL_ARRAY());

		private static readonly FieldCodec<MST_SVT_SKILL> _repeated_items_codec = FieldCodec.ForMessage<MST_SVT_SKILL>(10u, MST_SVT_SKILL.Parser);

		private readonly RepeatedField<MST_SVT_SKILL> items_ = new RepeatedField<MST_SVT_SKILL>();

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_SKILL_ARRAY.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_SKILL_ARRAY> Parser => MST_SVT_SKILL_ARRAY._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtSkillReflection.Descriptor.MessageTypes[1];

		[DebuggerNonUserCode]
		public RepeatedField<MST_SVT_SKILL> Items => this.items_;

		[DebuggerNonUserCode]
		public MST_SVT_SKILL_ARRAY()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_SKILL_ARRAY(MST_SVT_SKILL_ARRAY other) : this()
		{
			this.items_ = other.items_.Clone();
		}

		[DebuggerNonUserCode]
		public MST_SVT_SKILL_ARRAY Clone()
		{
			return new MST_SVT_SKILL_ARRAY(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_SKILL_ARRAY);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_SKILL_ARRAY other)
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
			this.items_.WriteTo(output, MST_SVT_SKILL_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			return num + this.items_.CalculateSize(MST_SVT_SKILL_ARRAY._repeated_items_codec);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_SKILL_ARRAY other)
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
					this.items_.AddEntriesFrom(input, MST_SVT_SKILL_ARRAY._repeated_items_codec);
				}
			}
		}
	}
}
