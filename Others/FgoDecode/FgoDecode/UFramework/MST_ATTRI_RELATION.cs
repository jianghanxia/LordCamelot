using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_ATTRI_RELATION : IMessage, IMessage<MST_ATTRI_RELATION>, IEquatable<MST_ATTRI_RELATION>, IDeepCloneable<MST_ATTRI_RELATION>
	{
		public const int AtkAttriFieldNumber = 1;

		public const int DefAttriFieldNumber = 2;

		public const int AttackRateFieldNumber = 3;

		private static readonly MessageParser<MST_ATTRI_RELATION> _parser = new MessageParser<MST_ATTRI_RELATION>(() => new MST_ATTRI_RELATION());

		private int atkAttri_;

		private int defAttri_;

		private int attackRate_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_ATTRI_RELATION.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_ATTRI_RELATION> Parser => MST_ATTRI_RELATION._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstAttriRelationReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int AtkAttri
		{
			get => this.atkAttri_;
			set
			{
				this.atkAttri_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DefAttri
		{
			get => this.defAttri_;
			set
			{
				this.defAttri_ = value;
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
		public MST_ATTRI_RELATION()
		{
		}

		[DebuggerNonUserCode]
		public MST_ATTRI_RELATION(MST_ATTRI_RELATION other) : this()
		{
			this.atkAttri_ = other.atkAttri_;
			this.defAttri_ = other.defAttri_;
			this.attackRate_ = other.attackRate_;
		}

		[DebuggerNonUserCode]
		public MST_ATTRI_RELATION Clone()
		{
			return new MST_ATTRI_RELATION(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_ATTRI_RELATION);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_ATTRI_RELATION other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.AtkAttri == other.AtkAttri && this.DefAttri == other.DefAttri && this.AttackRate == other.AttackRate));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AtkAttri != 0)
			{
				num ^= this.AtkAttri.GetHashCode();
			}
			if (this.DefAttri != 0)
			{
				num ^= this.DefAttri.GetHashCode();
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
			if (this.AtkAttri != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AtkAttri);
			}
			if (this.DefAttri != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DefAttri);
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
			if (this.AtkAttri != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtkAttri);
			}
			if (this.DefAttri != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DefAttri);
			}
			if (this.AttackRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttackRate);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_ATTRI_RELATION other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AtkAttri != 0)
			{
				this.AtkAttri = other.AtkAttri;
			}
			if (other.DefAttri != 0)
			{
				this.DefAttri = other.DefAttri;
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
						this.DefAttri = input.ReadInt32();
					}
				}
				else
				{
					this.AtkAttri = input.ReadInt32();
				}
			}
		}
	}
}
