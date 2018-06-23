using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_CLASS_RELATION : IMessage, IMessage<MST_CLASS_RELATION>, IEquatable<MST_CLASS_RELATION>, IDeepCloneable<MST_CLASS_RELATION>
	{
		public const int AtkClassFieldNumber = 1;

		public const int DefClassFieldNumber = 2;

		public const int AttackRateFieldNumber = 3;

		private static readonly MessageParser<MST_CLASS_RELATION> _parser = new MessageParser<MST_CLASS_RELATION>(() => new MST_CLASS_RELATION());

		private int atkClass_;

		private int defClass_;

		private int attackRate_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_CLASS_RELATION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_CLASS_RELATION> Parser => MST_CLASS_RELATION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstClassRelationReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int AtkClass
		{
			get => this.atkClass_;
			set
			{
				this.atkClass_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DefClass
		{
			get => this.defClass_;
			set
			{
				this.defClass_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AttackRate
		{
			get => this.attackRate_;
			set
			{
				this.attackRate_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_CLASS_RELATION()
		{
		}

		[DebuggerNonUserCode]
		public MST_CLASS_RELATION(MST_CLASS_RELATION other) : this()
		{
			this.atkClass_ = other.atkClass_;
			this.defClass_ = other.defClass_;
			this.attackRate_ = other.attackRate_;
		}

		[DebuggerNonUserCode]
		public MST_CLASS_RELATION Clone()
		{
			return new MST_CLASS_RELATION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_CLASS_RELATION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_CLASS_RELATION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.AtkClass == other.AtkClass && this.DefClass == other.DefClass && this.AttackRate == other.AttackRate));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AtkClass != 0)
			{
				num ^= this.AtkClass.GetHashCode();
			}
			if (this.DefClass != 0)
			{
				num ^= this.DefClass.GetHashCode();
			}
			if (this.AttackRate != 0)
			{
				num ^= this.AttackRate.GetHashCode();
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
			if (this.AtkClass != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AtkClass);
			}
			if (this.DefClass != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DefClass);
			}
			if (this.AttackRate != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AttackRate);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AtkClass != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtkClass);
			}
			if (this.DefClass != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DefClass);
			}
			if (this.AttackRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttackRate);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_CLASS_RELATION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AtkClass != 0)
			{
				this.AtkClass = other.AtkClass;
			}
			if (other.DefClass != 0)
			{
				this.DefClass = other.DefClass;
			}
			if (other.AttackRate != 0)
			{
				this.AttackRate = other.AttackRate;
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
							this.AttackRate = input.ReadInt32();
						}
					}
					else
					{
						this.DefClass = input.ReadInt32();
					}
				}
				else
				{
					this.AtkClass = input.ReadInt32();
				}
			}
		}
	}
}
