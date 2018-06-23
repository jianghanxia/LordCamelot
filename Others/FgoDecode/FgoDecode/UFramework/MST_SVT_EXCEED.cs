using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_EXCEED : IMessage, IMessage<MST_SVT_EXCEED>, IEquatable<MST_SVT_EXCEED>, IDeepCloneable<MST_SVT_EXCEED>
	{
		public const int RarityFieldNumber = 1;

		public const int ExceedCountFieldNumber = 2;

		public const int QpFieldNumber = 3;

		public const int AddLvMaxFieldNumber = 4;

		public const int FrameTypeFieldNumber = 5;

		private static readonly MessageParser<MST_SVT_EXCEED> _parser = new MessageParser<MST_SVT_EXCEED>(() => new MST_SVT_EXCEED());

		private int rarity_;

		private int exceedCount_;

		private int qp_;

		private int addLvMax_;

		private int frameType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_EXCEED.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_EXCEED> Parser => MST_SVT_EXCEED._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtExceedReflection.Descriptor.MessageTypes[0];

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
		public int ExceedCount
		{
			get => this.exceedCount_;
			set
			{
				this.exceedCount_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Qp
		{
			get => this.qp_;
			set
			{
				this.qp_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AddLvMax
		{
			get => this.addLvMax_;
			set
			{
				this.addLvMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int FrameType
		{
			get => this.frameType_;
			set
			{
				this.frameType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_EXCEED()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_EXCEED(MST_SVT_EXCEED other) : this()
		{
			this.rarity_ = other.rarity_;
			this.exceedCount_ = other.exceedCount_;
			this.qp_ = other.qp_;
			this.addLvMax_ = other.addLvMax_;
			this.frameType_ = other.frameType_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_EXCEED Clone()
		{
			return new MST_SVT_EXCEED(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_EXCEED);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_EXCEED other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Rarity == other.Rarity && this.ExceedCount == other.ExceedCount && this.Qp == other.Qp && this.AddLvMax == other.AddLvMax && this.FrameType == other.FrameType));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rarity != 0)
			{
				num ^= this.Rarity.GetHashCode();
			}
			if (this.ExceedCount != 0)
			{
				num ^= this.ExceedCount.GetHashCode();
			}
			if (this.Qp != 0)
			{
				num ^= this.Qp.GetHashCode();
			}
			if (this.AddLvMax != 0)
			{
				num ^= this.AddLvMax.GetHashCode();
			}
			if (this.FrameType != 0)
			{
				num ^= this.FrameType.GetHashCode();
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
			if (this.ExceedCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExceedCount);
			}
			if (this.Qp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Qp);
			}
			if (this.AddLvMax != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AddLvMax);
			}
			if (this.FrameType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FrameType);
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
			if (this.ExceedCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExceedCount);
			}
			if (this.Qp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Qp);
			}
			if (this.AddLvMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddLvMax);
			}
			if (this.FrameType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FrameType);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_EXCEED other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rarity != 0)
			{
				this.Rarity = other.Rarity;
			}
			if (other.ExceedCount != 0)
			{
				this.ExceedCount = other.ExceedCount;
			}
			if (other.Qp != 0)
			{
				this.Qp = other.Qp;
			}
			if (other.AddLvMax != 0)
			{
				this.AddLvMax = other.AddLvMax;
			}
			if (other.FrameType != 0)
			{
				this.FrameType = other.FrameType;
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
								if (num2 != 40u)
								{
									input.SkipLastField();
								}
								else
								{
									this.FrameType = input.ReadInt32();
								}
							}
							else
							{
								this.AddLvMax = input.ReadInt32();
							}
						}
						else
						{
							this.Qp = input.ReadInt32();
						}
					}
					else
					{
						this.ExceedCount = input.ReadInt32();
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
