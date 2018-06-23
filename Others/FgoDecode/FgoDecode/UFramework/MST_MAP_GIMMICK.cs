using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_MAP_GIMMICK : IMessage, IMessage<MST_MAP_GIMMICK>, IEquatable<MST_MAP_GIMMICK>, IDeepCloneable<MST_MAP_GIMMICK>
	{
		public const int IdFieldNumber = 1;

		public const int WarIdFieldNumber = 2;

		public const int ImageIdFieldNumber = 3;

		public const int XFieldNumber = 4;

		public const int YFieldNumber = 5;

		public const int DepthOffsetFieldNumber = 6;

		public const int ScaleFieldNumber = 7;

		public const int DispCondTypeFieldNumber = 8;

		public const int DispTargetIdFieldNumber = 9;

		public const int DispTargetValueFieldNumber = 10;

		public const int DispCondType2FieldNumber = 11;

		public const int DispTargetId2FieldNumber = 12;

		public const int DispTargetValue2FieldNumber = 13;

		public const int ActionAnimTimeFieldNumber = 14;

		public const int ActionEffectIdFieldNumber = 15;

		public const int StartedAtFieldNumber = 16;

		public const int EndedAtFieldNumber = 17;

		private static readonly MessageParser<MST_MAP_GIMMICK> _parser = new MessageParser<MST_MAP_GIMMICK>(() => new MST_MAP_GIMMICK());

		private int id_;

		private int warId_;

		private int imageId_;

		private int x_;

		private int y_;

		private int depthOffset_;

		private int scale_;

		private int dispCondType_;

		private int dispTargetId_;

		private int dispTargetValue_;

		private int dispCondType2_;

		private int dispTargetId2_;

		private int dispTargetValue2_;

		private int actionAnimTime_;

		private int actionEffectId_;

		private ulong startedAt_;

		private ulong endedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_MAP_GIMMICK.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_MAP_GIMMICK> Parser => MST_MAP_GIMMICK._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstMapGimmickReflection.Descriptor.MessageTypes[0];

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
		public int ImageId
		{
			get => this.imageId_;
			set
			{
				this.imageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int X
		{
			get => this.x_;
			set
			{
				this.x_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Y
		{
			get => this.y_;
			set
			{
				this.y_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DepthOffset
		{
			get => this.depthOffset_;
			set
			{
				this.depthOffset_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Scale
		{
			get => this.scale_;
			set
			{
				this.scale_ = value;
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
		public int ActionAnimTime
		{
			get => this.actionAnimTime_;
			set
			{
				this.actionAnimTime_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ActionEffectId
		{
			get => this.actionEffectId_;
			set
			{
				this.actionEffectId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong StartedAt
		{
			get => this.startedAt_;
			set
			{
				this.startedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong EndedAt
		{
			get => this.endedAt_;
			set
			{
				this.endedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_MAP_GIMMICK()
		{
		}

		[DebuggerNonUserCode]
		public MST_MAP_GIMMICK(MST_MAP_GIMMICK other) : this()
		{
			this.id_ = other.id_;
			this.warId_ = other.warId_;
			this.imageId_ = other.imageId_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.depthOffset_ = other.depthOffset_;
			this.scale_ = other.scale_;
			this.dispCondType_ = other.dispCondType_;
			this.dispTargetId_ = other.dispTargetId_;
			this.dispTargetValue_ = other.dispTargetValue_;
			this.dispCondType2_ = other.dispCondType2_;
			this.dispTargetId2_ = other.dispTargetId2_;
			this.dispTargetValue2_ = other.dispTargetValue2_;
			this.actionAnimTime_ = other.actionAnimTime_;
			this.actionEffectId_ = other.actionEffectId_;
			this.startedAt_ = other.startedAt_;
			this.endedAt_ = other.endedAt_;
		}

		[DebuggerNonUserCode]
		public MST_MAP_GIMMICK Clone()
		{
			return new MST_MAP_GIMMICK(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_MAP_GIMMICK);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_MAP_GIMMICK other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.WarId == other.WarId && this.ImageId == other.ImageId && this.X == other.X && this.Y == other.Y && this.DepthOffset == other.DepthOffset && this.Scale == other.Scale && this.DispCondType == other.DispCondType && this.DispTargetId == other.DispTargetId && this.DispTargetValue == other.DispTargetValue && this.DispCondType2 == other.DispCondType2 && this.DispTargetId2 == other.DispTargetId2 && this.DispTargetValue2 == other.DispTargetValue2 && this.ActionAnimTime == other.ActionAnimTime && this.ActionEffectId == other.ActionEffectId && this.StartedAt == other.StartedAt && this.EndedAt == other.EndedAt));
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
			if (this.ImageId != 0)
			{
				num ^= this.ImageId.GetHashCode();
			}
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.DepthOffset != 0)
			{
				num ^= this.DepthOffset.GetHashCode();
			}
			if (this.Scale != 0)
			{
				num ^= this.Scale.GetHashCode();
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
			if (this.ActionAnimTime != 0)
			{
				num ^= this.ActionAnimTime.GetHashCode();
			}
			if (this.ActionEffectId != 0)
			{
				num ^= this.ActionEffectId.GetHashCode();
			}
			if (this.StartedAt != 0uL)
			{
				num ^= this.StartedAt.GetHashCode();
			}
			if (this.EndedAt != 0uL)
			{
				num ^= this.EndedAt.GetHashCode();
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
			if (this.ImageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ImageId);
			}
			if (this.X != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Y);
			}
			if (this.DepthOffset != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DepthOffset);
			}
			if (this.Scale != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Scale);
			}
			if (this.DispCondType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DispCondType);
			}
			if (this.DispTargetId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DispTargetId);
			}
			if (this.DispTargetValue != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DispTargetValue);
			}
			if (this.DispCondType2 != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.DispCondType2);
			}
			if (this.DispTargetId2 != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DispTargetId2);
			}
			if (this.DispTargetValue2 != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DispTargetValue2);
			}
			if (this.ActionAnimTime != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActionAnimTime);
			}
			if (this.ActionEffectId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActionEffectId);
			}
			if (this.StartedAt != 0uL)
			{
				output.WriteRawTag(128, 1);
				output.WriteUInt64(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt64(this.EndedAt);
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
			if (this.ImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageId);
			}
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.DepthOffset != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DepthOffset);
			}
			if (this.Scale != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Scale);
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
			if (this.ActionAnimTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionAnimTime);
			}
			if (this.ActionEffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionEffectId);
			}
			if (this.StartedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.StartedAt);
			}
			if (this.EndedAt != 0uL)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.EndedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_MAP_GIMMICK other)
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
			if (other.ImageId != 0)
			{
				this.ImageId = other.ImageId;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.DepthOffset != 0)
			{
				this.DepthOffset = other.DepthOffset;
			}
			if (other.Scale != 0)
			{
				this.Scale = other.Scale;
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
			if (other.ActionAnimTime != 0)
			{
				this.ActionAnimTime = other.ActionAnimTime;
			}
			if (other.ActionEffectId != 0)
			{
				this.ActionEffectId = other.ActionEffectId;
			}
			if (other.StartedAt != 0uL)
			{
				this.StartedAt = other.StartedAt;
			}
			if (other.EndedAt != 0uL)
			{
				this.EndedAt = other.EndedAt;
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
																			if (num2 != 128u)
																			{
																				if (num2 != 136u)
																				{
																					input.SkipLastField();
																				}
																				else
																				{
																					this.EndedAt = input.ReadUInt64();
																				}
																			}
																			else
																			{
																				this.StartedAt = input.ReadUInt64();
																			}
																		}
																		else
																		{
																			this.ActionEffectId = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.ActionAnimTime = input.ReadInt32();
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
											this.Scale = input.ReadInt32();
										}
									}
									else
									{
										this.DepthOffset = input.ReadInt32();
									}
								}
								else
								{
									this.Y = input.ReadInt32();
								}
							}
							else
							{
								this.X = input.ReadInt32();
							}
						}
						else
						{
							this.ImageId = input.ReadInt32();
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
