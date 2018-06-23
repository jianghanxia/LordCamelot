using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_SCRIPT_ADD : IMessage, IMessage<MST_SVT_SCRIPT_ADD>, IEquatable<MST_SVT_SCRIPT_ADD>, IDeepCloneable<MST_SVT_SCRIPT_ADD>
	{
		public const int SvtIdFieldNumber = 1;

		public const int OffsetXEventRewardFieldNumber = 2;

		public const int OffsetYEventRewardFieldNumber = 3;

		public const int OffsetXEventShopFieldNumber = 4;

		public const int OffsetYEventShopFieldNumber = 5;

		private static readonly MessageParser<MST_SVT_SCRIPT_ADD> _parser = new MessageParser<MST_SVT_SCRIPT_ADD>(() => new MST_SVT_SCRIPT_ADD());

		private int svtId_;

		private int offsetXEventReward_;

		private int offsetYEventReward_;

		private int offsetXEventShop_;

		private int offsetYEventShop_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_SCRIPT_ADD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_SCRIPT_ADD> Parser => MST_SVT_SCRIPT_ADD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtScriptAddReflection.Descriptor.MessageTypes[0];

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
		public int OffsetXEventReward
		{
			get => this.offsetXEventReward_;
			set
			{
				this.offsetXEventReward_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetYEventReward
		{
			get => this.offsetYEventReward_;
			set
			{
				this.offsetYEventReward_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetXEventShop
		{
			get => this.offsetXEventShop_;
			set
			{
				this.offsetXEventShop_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int OffsetYEventShop
		{
			get => this.offsetYEventShop_;
			set
			{
				this.offsetYEventShop_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_SCRIPT_ADD()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_SCRIPT_ADD(MST_SVT_SCRIPT_ADD other) : this()
		{
			this.svtId_ = other.svtId_;
			this.offsetXEventReward_ = other.offsetXEventReward_;
			this.offsetYEventReward_ = other.offsetYEventReward_;
			this.offsetXEventShop_ = other.offsetXEventShop_;
			this.offsetYEventShop_ = other.offsetYEventShop_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_SCRIPT_ADD Clone()
		{
			return new MST_SVT_SCRIPT_ADD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_SCRIPT_ADD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_SCRIPT_ADD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.OffsetXEventReward == other.OffsetXEventReward && this.OffsetYEventReward == other.OffsetYEventReward && this.OffsetXEventShop == other.OffsetXEventShop && this.OffsetYEventShop == other.OffsetYEventShop));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.OffsetXEventReward != 0)
			{
				num ^= this.OffsetXEventReward.GetHashCode();
			}
			if (this.OffsetYEventReward != 0)
			{
				num ^= this.OffsetYEventReward.GetHashCode();
			}
			if (this.OffsetXEventShop != 0)
			{
				num ^= this.OffsetXEventShop.GetHashCode();
			}
			if (this.OffsetYEventShop != 0)
			{
				num ^= this.OffsetYEventShop.GetHashCode();
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
			if (this.OffsetXEventReward != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OffsetXEventReward);
			}
			if (this.OffsetYEventReward != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OffsetYEventReward);
			}
			if (this.OffsetXEventShop != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.OffsetXEventShop);
			}
			if (this.OffsetYEventShop != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.OffsetYEventShop);
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
			if (this.OffsetXEventReward != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetXEventReward);
			}
			if (this.OffsetYEventReward != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetYEventReward);
			}
			if (this.OffsetXEventShop != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetXEventShop);
			}
			if (this.OffsetYEventShop != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OffsetYEventShop);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_SCRIPT_ADD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.OffsetXEventReward != 0)
			{
				this.OffsetXEventReward = other.OffsetXEventReward;
			}
			if (other.OffsetYEventReward != 0)
			{
				this.OffsetYEventReward = other.OffsetYEventReward;
			}
			if (other.OffsetXEventShop != 0)
			{
				this.OffsetXEventShop = other.OffsetXEventShop;
			}
			if (other.OffsetYEventShop != 0)
			{
				this.OffsetYEventShop = other.OffsetYEventShop;
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
									this.OffsetYEventShop = input.ReadInt32();
								}
							}
							else
							{
								this.OffsetXEventShop = input.ReadInt32();
							}
						}
						else
						{
							this.OffsetYEventReward = input.ReadInt32();
						}
					}
					else
					{
						this.OffsetXEventReward = input.ReadInt32();
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
