using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SPOT : IMessage, IMessage<MST_SPOT>, IEquatable<MST_SPOT>, IDeepCloneable<MST_SPOT>
	{
		public const int IdFieldNumber = 1;

		public const int WarIdFieldNumber = 2;

		public const int NameFieldNumber = 3;

		public const int ImageIdFieldNumber = 4;

		public const int XFieldNumber = 5;

		public const int YFieldNumber = 6;

		public const int ImageOfsXFieldNumber = 7;

		public const int ImageOfsYFieldNumber = 8;

		public const int NameOfsXFieldNumber = 9;

		public const int NameOfsYFieldNumber = 10;

		public const int QuestOfsXFieldNumber = 11;

		public const int QuestOfsYFieldNumber = 12;

		public const int DispCondType1FieldNumber = 13;

		public const int DispTargetId1FieldNumber = 14;

		public const int DispTargetValue1FieldNumber = 15;

		public const int DispCondType2FieldNumber = 16;

		public const int DispTargetId2FieldNumber = 17;

		public const int DispTargetValue2FieldNumber = 18;

		public const int ActiveCondTypeFieldNumber = 19;

		public const int ActiveTargetIdFieldNumber = 20;

		public const int ActiveTargetValueFieldNumber = 21;

		private static readonly MessageParser<MST_SPOT> _parser = new MessageParser<MST_SPOT>(() => new MST_SPOT());

		private int id_;

		private int warId_;

		private ByteString name_ = ByteString.Empty;

		private int imageId_;

		private int x_;

		private int y_;

		private int imageOfsX_;

		private int imageOfsY_;

		private int nameOfsX_;

		private int nameOfsY_;

		private int questOfsX_;

		private int questOfsY_;

		private int dispCondType1_;

		private int dispTargetId1_;

		private int dispTargetValue1_;

		private int dispCondType2_;

		private int dispTargetId2_;

		private int dispTargetValue2_;

		private int activeCondType_;

		private int activeTargetId_;

		private int activeTargetValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SPOT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SPOT> Parser => MST_SPOT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSpotReflection.Descriptor.MessageTypes[0];

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
		public ByteString Name
		{
			get => this.name_;
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
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
		public int ImageOfsX
		{
			get => this.imageOfsX_;
			set
			{
				this.imageOfsX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ImageOfsY
		{
			get => this.imageOfsY_;
			set
			{
				this.imageOfsY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int NameOfsX
		{
			get => this.nameOfsX_;
			set
			{
				this.nameOfsX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int NameOfsY
		{
			get => this.nameOfsY_;
			set
			{
				this.nameOfsY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int QuestOfsX
		{
			get => this.questOfsX_;
			set
			{
				this.questOfsX_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int QuestOfsY
		{
			get => this.questOfsY_;
			set
			{
				this.questOfsY_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispCondType1
		{
			get => this.dispCondType1_;
			set
			{
				this.dispCondType1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispTargetId1
		{
			get => this.dispTargetId1_;
			set
			{
				this.dispTargetId1_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int DispTargetValue1
		{
			get => this.dispTargetValue1_;
			set
			{
				this.dispTargetValue1_ = value;
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
		public MST_SPOT()
		{
		}

		[DebuggerNonUserCode]
		public MST_SPOT(MST_SPOT other) : this()
		{
			this.id_ = other.id_;
			this.warId_ = other.warId_;
			this.name_ = other.name_;
			this.imageId_ = other.imageId_;
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.imageOfsX_ = other.imageOfsX_;
			this.imageOfsY_ = other.imageOfsY_;
			this.nameOfsX_ = other.nameOfsX_;
			this.nameOfsY_ = other.nameOfsY_;
			this.questOfsX_ = other.questOfsX_;
			this.questOfsY_ = other.questOfsY_;
			this.dispCondType1_ = other.dispCondType1_;
			this.dispTargetId1_ = other.dispTargetId1_;
			this.dispTargetValue1_ = other.dispTargetValue1_;
			this.dispCondType2_ = other.dispCondType2_;
			this.dispTargetId2_ = other.dispTargetId2_;
			this.dispTargetValue2_ = other.dispTargetValue2_;
			this.activeCondType_ = other.activeCondType_;
			this.activeTargetId_ = other.activeTargetId_;
			this.activeTargetValue_ = other.activeTargetValue_;
		}

		[DebuggerNonUserCode]
		public MST_SPOT Clone()
		{
			return new MST_SPOT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SPOT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SPOT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.WarId == other.WarId && !(this.Name != other.Name) && this.ImageId == other.ImageId && this.X == other.X && this.Y == other.Y && this.ImageOfsX == other.ImageOfsX && this.ImageOfsY == other.ImageOfsY && this.NameOfsX == other.NameOfsX && this.NameOfsY == other.NameOfsY && this.QuestOfsX == other.QuestOfsX && this.QuestOfsY == other.QuestOfsY && this.DispCondType1 == other.DispCondType1 && this.DispTargetId1 == other.DispTargetId1 && this.DispTargetValue1 == other.DispTargetValue1 && this.DispCondType2 == other.DispCondType2 && this.DispTargetId2 == other.DispTargetId2 && this.DispTargetValue2 == other.DispTargetValue2 && this.ActiveCondType == other.ActiveCondType && this.ActiveTargetId == other.ActiveTargetId && this.ActiveTargetValue == other.ActiveTargetValue));
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
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
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
			if (this.ImageOfsX != 0)
			{
				num ^= this.ImageOfsX.GetHashCode();
			}
			if (this.ImageOfsY != 0)
			{
				num ^= this.ImageOfsY.GetHashCode();
			}
			if (this.NameOfsX != 0)
			{
				num ^= this.NameOfsX.GetHashCode();
			}
			if (this.NameOfsY != 0)
			{
				num ^= this.NameOfsY.GetHashCode();
			}
			if (this.QuestOfsX != 0)
			{
				num ^= this.QuestOfsX.GetHashCode();
			}
			if (this.QuestOfsY != 0)
			{
				num ^= this.QuestOfsY.GetHashCode();
			}
			if (this.DispCondType1 != 0)
			{
				num ^= this.DispCondType1.GetHashCode();
			}
			if (this.DispTargetId1 != 0)
			{
				num ^= this.DispTargetId1.GetHashCode();
			}
			if (this.DispTargetValue1 != 0)
			{
				num ^= this.DispTargetValue1.GetHashCode();
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
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Name);
			}
			if (this.ImageId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ImageId);
			}
			if (this.X != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Y);
			}
			if (this.ImageOfsX != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ImageOfsX);
			}
			if (this.ImageOfsY != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ImageOfsY);
			}
			if (this.NameOfsX != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.NameOfsX);
			}
			if (this.NameOfsY != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NameOfsY);
			}
			if (this.QuestOfsX != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.QuestOfsX);
			}
			if (this.QuestOfsY != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.QuestOfsY);
			}
			if (this.DispCondType1 != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DispCondType1);
			}
			if (this.DispTargetId1 != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DispTargetId1);
			}
			if (this.DispTargetValue1 != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.DispTargetValue1);
			}
			if (this.DispCondType2 != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.DispCondType2);
			}
			if (this.DispTargetId2 != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.DispTargetId2);
			}
			if (this.DispTargetValue2 != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.DispTargetValue2);
			}
			if (this.ActiveCondType != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.ActiveCondType);
			}
			if (this.ActiveTargetId != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.ActiveTargetId);
			}
			if (this.ActiveTargetValue != 0)
			{
				output.WriteRawTag(168, 1);
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
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Name);
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
			if (this.ImageOfsX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageOfsX);
			}
			if (this.ImageOfsY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ImageOfsY);
			}
			if (this.NameOfsX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NameOfsX);
			}
			if (this.NameOfsY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NameOfsY);
			}
			if (this.QuestOfsX != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestOfsX);
			}
			if (this.QuestOfsY != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestOfsY);
			}
			if (this.DispCondType1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispCondType1);
			}
			if (this.DispTargetId1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispTargetId1);
			}
			if (this.DispTargetValue1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DispTargetValue1);
			}
			if (this.DispCondType2 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DispCondType2);
			}
			if (this.DispTargetId2 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DispTargetId2);
			}
			if (this.DispTargetValue2 != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DispTargetValue2);
			}
			if (this.ActiveCondType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ActiveCondType);
			}
			if (this.ActiveTargetId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ActiveTargetId);
			}
			if (this.ActiveTargetValue != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ActiveTargetValue);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SPOT other)
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
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
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
			if (other.ImageOfsX != 0)
			{
				this.ImageOfsX = other.ImageOfsX;
			}
			if (other.ImageOfsY != 0)
			{
				this.ImageOfsY = other.ImageOfsY;
			}
			if (other.NameOfsX != 0)
			{
				this.NameOfsX = other.NameOfsX;
			}
			if (other.NameOfsY != 0)
			{
				this.NameOfsY = other.NameOfsY;
			}
			if (other.QuestOfsX != 0)
			{
				this.QuestOfsX = other.QuestOfsX;
			}
			if (other.QuestOfsY != 0)
			{
				this.QuestOfsY = other.QuestOfsY;
			}
			if (other.DispCondType1 != 0)
			{
				this.DispCondType1 = other.DispCondType1;
			}
			if (other.DispTargetId1 != 0)
			{
				this.DispTargetId1 = other.DispTargetId1;
			}
			if (other.DispTargetValue1 != 0)
			{
				this.DispTargetValue1 = other.DispTargetValue1;
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
						if (num2 != 26u)
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
																					if (num2 != 144u)
																					{
																						if (num2 != 152u)
																						{
																							if (num2 != 160u)
																							{
																								if (num2 != 168u)
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
																			this.DispTargetValue1 = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.DispTargetId1 = input.ReadInt32();
																	}
																}
																else
																{
																	this.DispCondType1 = input.ReadInt32();
																}
															}
															else
															{
																this.QuestOfsY = input.ReadInt32();
															}
														}
														else
														{
															this.QuestOfsX = input.ReadInt32();
														}
													}
													else
													{
														this.NameOfsY = input.ReadInt32();
													}
												}
												else
												{
													this.NameOfsX = input.ReadInt32();
												}
											}
											else
											{
												this.ImageOfsY = input.ReadInt32();
											}
										}
										else
										{
											this.ImageOfsX = input.ReadInt32();
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
							this.Name = input.ReadBytes();
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
