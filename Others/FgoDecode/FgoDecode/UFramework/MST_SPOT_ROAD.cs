using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SPOT_ROAD : IMessage, IMessage<MST_SPOT_ROAD>, IEquatable<MST_SPOT_ROAD>, IDeepCloneable<MST_SPOT_ROAD>
	{
		public const int IdFieldNumber = 1;

		public const int WarIdFieldNumber = 2;

		public const int SrcSpotIdFieldNumber = 3;

		public const int DstSpotIdFieldNumber = 4;

		public const int TypeFieldNumber = 5;

		public const int ImageIdFieldNumber = 6;

		public const int DispCondTypeFieldNumber = 7;

		public const int DispTargetIdFieldNumber = 8;

		public const int DispTargetValueFieldNumber = 9;

		public const int DispCondType2FieldNumber = 10;

		public const int DispTargetId2FieldNumber = 11;

		public const int DispTargetValue2FieldNumber = 12;

		public const int ActiveCondTypeFieldNumber = 13;

		public const int ActiveTargetIdFieldNumber = 14;

		public const int ActiveTargetValueFieldNumber = 15;

		private static readonly MessageParser<MST_SPOT_ROAD> _parser = new MessageParser<MST_SPOT_ROAD>(() => new MST_SPOT_ROAD());

		private int id_;

		private int warId_;

		private int srcSpotId_;

		private int dstSpotId_;

		private int type_;

		private int imageId_;

		private int dispCondType_;

		private int dispTargetId_;

		private int dispTargetValue_;

		private int dispCondType2_;

		private int dispTargetId2_;

		private int dispTargetValue2_;

		private int activeCondType_;

		private int activeTargetId_;

		private int activeTargetValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SPOT_ROAD.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SPOT_ROAD> Parser => MST_SPOT_ROAD._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSpotRoadReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int WarId
		{
			get => this.warId_;
			set
			{
				this.warId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int SrcSpotId
		{
			get => this.srcSpotId_;
			set
			{
				this.srcSpotId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DstSpotId
		{
			get => this.dstSpotId_;
			set
			{
				this.dstSpotId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Type
		{
			get => this.type_;
			set
			{
				this.type_ = value;
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
		public int DispCondType2
		{
			get => this.dispCondType2_;
			set
			{
				this.dispCondType2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispTargetId2
		{
			get => this.dispTargetId2_;
			set
			{
				this.dispTargetId2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispTargetValue2
		{
			get => this.dispTargetValue2_;
			set
			{
				this.dispTargetValue2_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActiveCondType
		{
			get => this.activeCondType_;
			set
			{
				this.activeCondType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActiveTargetId
		{
			get => this.activeTargetId_;
			set
			{
				this.activeTargetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActiveTargetValue
		{
			get => this.activeTargetValue_;
			set
			{
				this.activeTargetValue_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_SPOT_ROAD()
		{
		}

		[DebuggerNonUserCode]
		public MST_SPOT_ROAD(MST_SPOT_ROAD other) : this()
		{
			this.id_ = other.id_;
			this.warId_ = other.warId_;
			this.srcSpotId_ = other.srcSpotId_;
			this.dstSpotId_ = other.dstSpotId_;
			this.type_ = other.type_;
			this.imageId_ = other.imageId_;
			this.dispCondType_ = other.dispCondType_;
			this.dispTargetId_ = other.dispTargetId_;
			this.dispTargetValue_ = other.dispTargetValue_;
			this.dispCondType2_ = other.dispCondType2_;
			this.dispTargetId2_ = other.dispTargetId2_;
			this.dispTargetValue2_ = other.dispTargetValue2_;
			this.activeCondType_ = other.activeCondType_;
			this.activeTargetId_ = other.activeTargetId_;
			this.activeTargetValue_ = other.activeTargetValue_;
		}

		[DebuggerNonUserCode]
		public MST_SPOT_ROAD Clone()
		{
			return new MST_SPOT_ROAD(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SPOT_ROAD);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SPOT_ROAD other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.WarId == other.WarId && this.SrcSpotId == other.SrcSpotId && this.DstSpotId == other.DstSpotId && this.Type == other.Type && this.ImageId == other.ImageId && this.DispCondType == other.DispCondType && this.DispTargetId == other.DispTargetId && this.DispTargetValue == other.DispTargetValue && this.DispCondType2 == other.DispCondType2 && this.DispTargetId2 == other.DispTargetId2 && this.DispTargetValue2 == other.DispTargetValue2 && this.ActiveCondType == other.ActiveCondType && this.ActiveTargetId == other.ActiveTargetId && this.ActiveTargetValue == other.ActiveTargetValue));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.WarId != 0)
			{
				num ^= this.WarId.GetHashCode();
			}
			if (this.SrcSpotId != 0)
			{
				num ^= this.SrcSpotId.GetHashCode();
			}
			if (this.DstSpotId != 0)
			{
				num ^= this.DstSpotId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
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
			if (this.DispCondType2 != 0)
			{
				num ^= this.DispCondType2.GetHashCode();
			}
			if (this.DispTargetId2 != 0)
			{
				num ^= this.DispTargetId2.GetHashCode();
			}
			if (this.DispTargetValue2 != 0)
			{
				num ^= this.DispTargetValue2.GetHashCode();
			}
			if (this.ActiveCondType != 0)
			{
				num ^= this.ActiveCondType.GetHashCode();
			}
			if (this.ActiveTargetId != 0)
			{
				num ^= this.ActiveTargetId.GetHashCode();
			}
			if (this.ActiveTargetValue != 0)
			{
				num ^= this.ActiveTargetValue.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.WarId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WarId);
			}
			if (this.SrcSpotId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SrcSpotId);
			}
			if (this.DstSpotId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DstSpotId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Type);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ImageId);
			}
			if (this.DispCondType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DispCondType);
			}
			if (this.DispTargetId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DispTargetId);
			}
			if (this.DispTargetValue != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DispTargetValue);
			}
			if (this.DispCondType2 != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DispCondType2);
			}
			if (this.DispTargetId2 != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.DispTargetId2);
			}
			if (this.DispTargetValue2 != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DispTargetValue2);
			}
			if (this.ActiveCondType != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActiveCondType);
			}
			if (this.ActiveTargetId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActiveTargetId);
			}
			if (this.ActiveTargetValue != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActiveTargetValue);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.WarId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WarId);
			}
			if (this.SrcSpotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SrcSpotId);
			}
			if (this.DstSpotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DstSpotId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
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
			if (this.DispCondType2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispCondType2);
			}
			if (this.DispTargetId2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispTargetId2);
			}
			if (this.DispTargetValue2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispTargetValue2);
			}
			if (this.ActiveCondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveCondType);
			}
			if (this.ActiveTargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveTargetId);
			}
			if (this.ActiveTargetValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveTargetValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SPOT_ROAD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.WarId != 0)
			{
				this.WarId = other.WarId;
			}
			if (other.SrcSpotId != 0)
			{
				this.SrcSpotId = other.SrcSpotId;
			}
			if (other.DstSpotId != 0)
			{
				this.DstSpotId = other.DstSpotId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
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
			if (other.DispCondType2 != 0)
			{
				this.DispCondType2 = other.DispCondType2;
			}
			if (other.DispTargetId2 != 0)
			{
				this.DispTargetId2 = other.DispTargetId2;
			}
			if (other.DispTargetValue2 != 0)
			{
				this.DispTargetValue2 = other.DispTargetValue2;
			}
			if (other.ActiveCondType != 0)
			{
				this.ActiveCondType = other.ActiveCondType;
			}
			if (other.ActiveTargetId != 0)
			{
				this.ActiveTargetId = other.ActiveTargetId;
			}
			if (other.ActiveTargetValue != 0)
			{
				this.ActiveTargetValue = other.ActiveTargetValue;
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
										if (num2 != 56u)
										{
											if (num2 != 64u)
											{
												if (num2 != 72u)
												{
													if (num2 != 80u)
													{
														if (num2 != 88u)
														{
															if (num2 != 96u)
															{
																if (num2 != 104u)
																{
																	if (num2 != 112u)
																	{
																		if (num2 != 120u)
																		{
																			input.SkipLastField();
																		}
																		else
																		{
																			this.ActiveTargetValue = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.ActiveTargetId = input.ReadInt32();
																	}
																}
																else
																{
																	this.ActiveCondType = input.ReadInt32();
																}
															}
															else
															{
																this.DispTargetValue2 = input.ReadInt32();
															}
														}
														else
														{
															this.DispTargetId2 = input.ReadInt32();
														}
													}
													else
													{
														this.DispCondType2 = input.ReadInt32();
													}
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
									this.Type = input.ReadInt32();
								}
							}
							else
							{
								this.DstSpotId = input.ReadInt32();
							}
						}
						else
						{
							this.SrcSpotId = input.ReadInt32();
						}
					}
					else
					{
						this.WarId = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}
	}
}
