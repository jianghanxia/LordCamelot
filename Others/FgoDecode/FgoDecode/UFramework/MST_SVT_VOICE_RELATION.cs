using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_VOICE_RELATION : IMessage, IMessage<MST_SVT_VOICE_RELATION>, IEquatable<MST_SVT_VOICE_RELATION>, IDeepCloneable<MST_SVT_VOICE_RELATION>
	{
		public const int SvtIdFieldNumber = 1;

		public const int RelationSvtIdFieldNumber = 2;

		public const int AscendOrderFieldNumber = 3;

		private static readonly MessageParser<MST_SVT_VOICE_RELATION> _parser = new MessageParser<MST_SVT_VOICE_RELATION>(() => new MST_SVT_VOICE_RELATION());

		private int svtId_;

		private int relationSvtId_;

		private int ascendOrder_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_VOICE_RELATION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_VOICE_RELATION> Parser => MST_SVT_VOICE_RELATION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtVoiceRelationReflection.Descriptor.MessageTypes[0];

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
		public int RelationSvtId
		{
			get => this.relationSvtId_;
			set
			{
				this.relationSvtId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AscendOrder
		{
			get => this.ascendOrder_;
			set
			{
				this.ascendOrder_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_VOICE_RELATION()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_VOICE_RELATION(MST_SVT_VOICE_RELATION other) : this()
		{
			this.svtId_ = other.svtId_;
			this.relationSvtId_ = other.relationSvtId_;
			this.ascendOrder_ = other.ascendOrder_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_VOICE_RELATION Clone()
		{
			return new MST_SVT_VOICE_RELATION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_VOICE_RELATION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_VOICE_RELATION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.RelationSvtId == other.RelationSvtId && this.AscendOrder == other.AscendOrder));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.RelationSvtId != 0)
			{
				num ^= this.RelationSvtId.GetHashCode();
			}
			if (this.AscendOrder != 0)
			{
				num ^= this.AscendOrder.GetHashCode();
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
			if (this.SvtId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SvtId);
			}
			if (this.RelationSvtId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RelationSvtId);
			}
			if (this.AscendOrder != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AscendOrder);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtId);
			}
			if (this.RelationSvtId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RelationSvtId);
			}
			if (this.AscendOrder != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AscendOrder);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_VOICE_RELATION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.RelationSvtId != 0)
			{
				this.RelationSvtId = other.RelationSvtId;
			}
			if (other.AscendOrder != 0)
			{
				this.AscendOrder = other.AscendOrder;
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
						if (num2 != 24u)
						{
							input.SkipLastField();
						}
						else
						{
							this.AscendOrder = input.ReadInt32();
						}
					}
					else
					{
						this.RelationSvtId = input.ReadInt32();
					}
				}
				else
				{
					this.SvtId = input.ReadInt32();
				}
			}
		}
	}
}
