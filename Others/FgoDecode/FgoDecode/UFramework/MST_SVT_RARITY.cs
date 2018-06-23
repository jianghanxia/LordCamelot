using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_RARITY : IMessage, IMessage<MST_SVT_RARITY>, IEquatable<MST_SVT_RARITY>, IDeepCloneable<MST_SVT_RARITY>
	{
		public const int RarityFieldNumber = 1;

		public const int HpAdjustMaxFieldNumber = 2;

		public const int AtkAdjustMaxFieldNumber = 3;

		public const int SvtAnonymousIdFieldNumber = 4;

		private static readonly MessageParser<MST_SVT_RARITY> _parser = new MessageParser<MST_SVT_RARITY>(() => new MST_SVT_RARITY());

		private int rarity_;

		private int hpAdjustMax_;

		private int atkAdjustMax_;

		private int svtAnonymousId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_RARITY.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_RARITY> Parser => MST_SVT_RARITY._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtRarityReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Rarity
		{
			get => this.rarity_;
			set
			{
				this.rarity_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HpAdjustMax
		{
			get => this.hpAdjustMax_;
			set
			{
				this.hpAdjustMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AtkAdjustMax
		{
			get => this.atkAdjustMax_;
			set
			{
				this.atkAdjustMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SvtAnonymousId
		{
			get => this.svtAnonymousId_;
			set
			{
				this.svtAnonymousId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_RARITY()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_RARITY(MST_SVT_RARITY other) : this()
		{
			this.rarity_ = other.rarity_;
			this.hpAdjustMax_ = other.hpAdjustMax_;
			this.atkAdjustMax_ = other.atkAdjustMax_;
			this.svtAnonymousId_ = other.svtAnonymousId_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_RARITY Clone()
		{
			return new MST_SVT_RARITY(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_RARITY);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_RARITY other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Rarity == other.Rarity && this.HpAdjustMax == other.HpAdjustMax && this.AtkAdjustMax == other.AtkAdjustMax && this.SvtAnonymousId == other.SvtAnonymousId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rarity != 0)
			{
				num ^= this.Rarity.GetHashCode();
			}
			if (this.HpAdjustMax != 0)
			{
				num ^= this.HpAdjustMax.GetHashCode();
			}
			if (this.AtkAdjustMax != 0)
			{
				num ^= this.AtkAdjustMax.GetHashCode();
			}
			if (this.SvtAnonymousId != 0)
			{
				num ^= this.SvtAnonymousId.GetHashCode();
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
			if (this.Rarity != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Rarity);
			}
			if (this.HpAdjustMax != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HpAdjustMax);
			}
			if (this.AtkAdjustMax != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AtkAdjustMax);
			}
			if (this.SvtAnonymousId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SvtAnonymousId);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Rarity != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rarity);
			}
			if (this.HpAdjustMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HpAdjustMax);
			}
			if (this.AtkAdjustMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtkAdjustMax);
			}
			if (this.SvtAnonymousId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SvtAnonymousId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_RARITY other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rarity != 0)
			{
				this.Rarity = other.Rarity;
			}
			if (other.HpAdjustMax != 0)
			{
				this.HpAdjustMax = other.HpAdjustMax;
			}
			if (other.AtkAdjustMax != 0)
			{
				this.AtkAdjustMax = other.AtkAdjustMax;
			}
			if (other.SvtAnonymousId != 0)
			{
				this.SvtAnonymousId = other.SvtAnonymousId;
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
							if (num2 != 32u)
							{
								input.SkipLastField();
							}
							else
							{
								this.SvtAnonymousId = input.ReadInt32();
							}
						}
						else
						{
							this.AtkAdjustMax = input.ReadInt32();
						}
					}
					else
					{
						this.HpAdjustMax = input.ReadInt32();
					}
				}
				else
				{
					this.Rarity = input.ReadInt32();
				}
			}
		}
	}
}
