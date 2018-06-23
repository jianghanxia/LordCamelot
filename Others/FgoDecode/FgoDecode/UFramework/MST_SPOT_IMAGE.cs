using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SPOT_IMAGE : IMessage, IMessage<MST_SPOT_IMAGE>, IEquatable<MST_SPOT_IMAGE>, IDeepCloneable<MST_SPOT_IMAGE>
	{
		public const int SpotIdFieldNumber = 1;

		public const int PriorityFieldNumber = 2;

		public const int ImageIdFieldNumber = 3;

		public const int DispCondTypeFieldNumber = 4;

		public const int DispTargetIdFieldNumber = 5;

		public const int DispTargetValueFieldNumber = 6;

		private static readonly MessageParser<MST_SPOT_IMAGE> _parser = new MessageParser<MST_SPOT_IMAGE>(() => new MST_SPOT_IMAGE());

		private int spotId_;

		private int priority_;

		private int imageId_;

		private int dispCondType_;

		private int dispTargetId_;

		private int dispTargetValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SPOT_IMAGE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SPOT_IMAGE> Parser => MST_SPOT_IMAGE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSpotImageReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int SpotId
		{
			get => this.spotId_;
			set
			{
				this.spotId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ImageId
		{
			get => this.imageId_;
			set
			{
				this.imageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispCondType
		{
			get => this.dispCondType_;
			set
			{
				this.dispCondType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispTargetId
		{
			get => this.dispTargetId_;
			set
			{
				this.dispTargetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispTargetValue
		{
			get => this.dispTargetValue_;
			set
			{
				this.dispTargetValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SPOT_IMAGE()
		{
		}

		[DebuggerNonUserCode]
		public MST_SPOT_IMAGE(MST_SPOT_IMAGE other) : this()
		{
			this.spotId_ = other.spotId_;
			this.priority_ = other.priority_;
			this.imageId_ = other.imageId_;
			this.dispCondType_ = other.dispCondType_;
			this.dispTargetId_ = other.dispTargetId_;
			this.dispTargetValue_ = other.dispTargetValue_;
		}

		[DebuggerNonUserCode]
		public MST_SPOT_IMAGE Clone()
		{
			return new MST_SPOT_IMAGE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SPOT_IMAGE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SPOT_IMAGE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SpotId == other.SpotId && this.Priority == other.Priority && this.ImageId == other.ImageId && this.DispCondType == other.DispCondType && this.DispTargetId == other.DispTargetId && this.DispTargetValue == other.DispTargetValue));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SpotId != 0)
			{
				num ^= this.SpotId.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.DispCondType != 0)
			{
				num ^= this.DispCondType.GetHashCode();
			}
			if (this.DispTargetId != 0)
			{
				num ^= this.DispTargetId.GetHashCode();
			}
			if (this.DispTargetValue != 0)
			{
				num ^= this.DispTargetValue.GetHashCode();
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
			if (this.SpotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpotId);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Priority);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ImageId);
			}
			if (this.DispCondType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DispCondType);
			}
			if (this.DispTargetId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DispTargetId);
			}
			if (this.DispTargetValue != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DispTargetValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpotId);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.DispCondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispCondType);
			}
			if (this.DispTargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispTargetId);
			}
			if (this.DispTargetValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispTargetValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SPOT_IMAGE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpotId != 0)
			{
				this.SpotId = other.SpotId;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.DispCondType != 0)
			{
				this.DispCondType = other.DispCondType;
			}
			if (other.DispTargetId != 0)
			{
				this.DispTargetId = other.DispTargetId;
			}
			if (other.DispTargetValue != 0)
			{
				this.DispTargetValue = other.DispTargetValue;
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
									if (num2 != 48u)
									{
										input.SkipLastField();
									}
									else
									{
										this.DispTargetValue = input.ReadInt32();
									}
								}
								else
								{
									this.DispTargetId = input.ReadInt32();
								}
							}
							else
							{
								this.DispCondType = input.ReadInt32();
							}
						}
						else
						{
							this.ImageId = input.ReadInt32();
						}
					}
					else
					{
						this.Priority = input.ReadInt32();
					}
				}
				else
				{
					this.SpotId = input.ReadInt32();
				}
			}
		}
	}
}
