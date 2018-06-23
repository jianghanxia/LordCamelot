using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_SVT_LIMIT : IMessage, IMessage<MST_SVT_LIMIT>, IEquatable<MST_SVT_LIMIT>, IDeepCloneable<MST_SVT_LIMIT>
	{
		public const int SvtIdFieldNumber = 1;

		public const int LimitCountFieldNumber = 2;

		public const int RarityFieldNumber = 3;

		public const int LvMaxFieldNumber = 4;

		public const int WeaponGroupFieldNumber = 5;

		public const int WeaponScaleFieldNumber = 6;

		public const int WeaponColorFieldNumber = 7;

		public const int EffectFolderFieldNumber = 8;

		public const int HpBaseFieldNumber = 9;

		public const int HpMaxFieldNumber = 10;

		public const int AtkBaseFieldNumber = 11;

		public const int AtkMaxFieldNumber = 12;

		public const int CriticalWeightFieldNumber = 13;

		public const int PowerFieldNumber = 14;

		public const int DefenseFieldNumber = 15;

		public const int AgilityFieldNumber = 16;

		public const int MagicFieldNumber = 17;

		public const int LuckFieldNumber = 18;

		public const int TreasureDeviceFieldNumber = 19;

		public const int PolicyFieldNumber = 20;

		public const int PersonalityFieldNumber = 21;

		public const int DeityFieldNumber = 22;

		public const int StepProbabilityFieldNumber = 23;

		public const int StrParamFieldNumber = 24;

		private static readonly MessageParser<MST_SVT_LIMIT> _parser = new MessageParser<MST_SVT_LIMIT>(() => new MST_SVT_LIMIT());

		private int svtId_;

		private int limitCount_;

		private int rarity_;

		private int lvMax_;

		private int weaponGroup_;

		private int weaponScale_;

		private ByteString weaponColor_ = ByteString.Empty;

		private int effectFolder_;

		private int hpBase_;

		private int hpMax_;

		private int atkBase_;

		private int atkMax_;

		private int criticalWeight_;

		private int power_;

		private int defense_;

		private int agility_;

		private int magic_;

		private int luck_;

		private int treasureDevice_;

		private int policy_;

		private int personality_;

		private int deity_;

		private int stepProbability_;

		private ByteString strParam_ = ByteString.Empty;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_SVT_LIMIT.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_SVT_LIMIT> Parser => MST_SVT_LIMIT._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstSvtLimitReflection.Descriptor.MessageTypes[0];

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
		public int LimitCount
		{
			get => this.limitCount_;
			set
			{
				this.limitCount_ = value;
			}
		}

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
		public int LvMax
		{
			get => this.lvMax_;
			set
			{
				this.lvMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int WeaponGroup
		{
			get => this.weaponGroup_;
			set
			{
				this.weaponGroup_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int WeaponScale
		{
			get => this.weaponScale_;
			set
			{
				this.weaponScale_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString WeaponColor
		{
			get => this.weaponColor_;
			set
			{
				this.weaponColor_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public int EffectFolder
		{
			get => this.effectFolder_;
			set
			{
				this.effectFolder_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HpBase
		{
			get => this.hpBase_;
			set
			{
				this.hpBase_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int HpMax
		{
			get => this.hpMax_;
			set
			{
				this.hpMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AtkBase
		{
			get => this.atkBase_;
			set
			{
				this.atkBase_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int AtkMax
		{
			get => this.atkMax_;
			set
			{
				this.atkMax_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int CriticalWeight
		{
			get => this.criticalWeight_;
			set
			{
				this.criticalWeight_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Power
		{
			get => this.power_;
			set
			{
				this.power_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Defense
		{
			get => this.defense_;
			set
			{
				this.defense_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Agility
		{
			get => this.agility_;
			set
			{
				this.agility_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Magic
		{
			get => this.magic_;
			set
			{
				this.magic_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Luck
		{
			get => this.luck_;
			set
			{
				this.luck_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TreasureDevice
		{
			get => this.treasureDevice_;
			set
			{
				this.treasureDevice_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Policy
		{
			get => this.policy_;
			set
			{
				this.policy_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Personality
		{
			get => this.personality_;
			set
			{
				this.personality_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int Deity
		{
			get => this.deity_;
			set
			{
				this.deity_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int StepProbability
		{
			get => this.stepProbability_;
			set
			{
				this.stepProbability_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ByteString StrParam
		{
			get => this.strParam_;
			set
			{
				this.strParam_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		[DebuggerNonUserCode]
		public MST_SVT_LIMIT()
		{
		}

		[DebuggerNonUserCode]
		public MST_SVT_LIMIT(MST_SVT_LIMIT other) : this()
		{
			this.svtId_ = other.svtId_;
			this.limitCount_ = other.limitCount_;
			this.rarity_ = other.rarity_;
			this.lvMax_ = other.lvMax_;
			this.weaponGroup_ = other.weaponGroup_;
			this.weaponScale_ = other.weaponScale_;
			this.weaponColor_ = other.weaponColor_;
			this.effectFolder_ = other.effectFolder_;
			this.hpBase_ = other.hpBase_;
			this.hpMax_ = other.hpMax_;
			this.atkBase_ = other.atkBase_;
			this.atkMax_ = other.atkMax_;
			this.criticalWeight_ = other.criticalWeight_;
			this.power_ = other.power_;
			this.defense_ = other.defense_;
			this.agility_ = other.agility_;
			this.magic_ = other.magic_;
			this.luck_ = other.luck_;
			this.treasureDevice_ = other.treasureDevice_;
			this.policy_ = other.policy_;
			this.personality_ = other.personality_;
			this.deity_ = other.deity_;
			this.stepProbability_ = other.stepProbability_;
			this.strParam_ = other.strParam_;
		}

		[DebuggerNonUserCode]
		public MST_SVT_LIMIT Clone()
		{
			return new MST_SVT_LIMIT(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_SVT_LIMIT);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_SVT_LIMIT other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.SvtId == other.SvtId && this.LimitCount == other.LimitCount && this.Rarity == other.Rarity && this.LvMax == other.LvMax && this.WeaponGroup == other.WeaponGroup && this.WeaponScale == other.WeaponScale && !(this.WeaponColor != other.WeaponColor) && this.EffectFolder == other.EffectFolder && this.HpBase == other.HpBase && this.HpMax == other.HpMax && this.AtkBase == other.AtkBase && this.AtkMax == other.AtkMax && this.CriticalWeight == other.CriticalWeight && this.Power == other.Power && this.Defense == other.Defense && this.Agility == other.Agility && this.Magic == other.Magic && this.Luck == other.Luck && this.TreasureDevice == other.TreasureDevice && this.Policy == other.Policy && this.Personality == other.Personality && this.Deity == other.Deity && this.StepProbability == other.StepProbability && !(this.StrParam != other.StrParam)));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SvtId != 0)
			{
				num ^= this.SvtId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.Rarity != 0)
			{
				num ^= this.Rarity.GetHashCode();
			}
			if (this.LvMax != 0)
			{
				num ^= this.LvMax.GetHashCode();
			}
			if (this.WeaponGroup != 0)
			{
				num ^= this.WeaponGroup.GetHashCode();
			}
			if (this.WeaponScale != 0)
			{
				num ^= this.WeaponScale.GetHashCode();
			}
			if (this.WeaponColor.Length != 0)
			{
				num ^= this.WeaponColor.GetHashCode();
			}
			if (this.EffectFolder != 0)
			{
				num ^= this.EffectFolder.GetHashCode();
			}
			if (this.HpBase != 0)
			{
				num ^= this.HpBase.GetHashCode();
			}
			if (this.HpMax != 0)
			{
				num ^= this.HpMax.GetHashCode();
			}
			if (this.AtkBase != 0)
			{
				num ^= this.AtkBase.GetHashCode();
			}
			if (this.AtkMax != 0)
			{
				num ^= this.AtkMax.GetHashCode();
			}
			if (this.CriticalWeight != 0)
			{
				num ^= this.CriticalWeight.GetHashCode();
			}
			if (this.Power != 0)
			{
				num ^= this.Power.GetHashCode();
			}
			if (this.Defense != 0)
			{
				num ^= this.Defense.GetHashCode();
			}
			if (this.Agility != 0)
			{
				num ^= this.Agility.GetHashCode();
			}
			if (this.Magic != 0)
			{
				num ^= this.Magic.GetHashCode();
			}
			if (this.Luck != 0)
			{
				num ^= this.Luck.GetHashCode();
			}
			if (this.TreasureDevice != 0)
			{
				num ^= this.TreasureDevice.GetHashCode();
			}
			if (this.Policy != 0)
			{
				num ^= this.Policy.GetHashCode();
			}
			if (this.Personality != 0)
			{
				num ^= this.Personality.GetHashCode();
			}
			if (this.Deity != 0)
			{
				num ^= this.Deity.GetHashCode();
			}
			if (this.StepProbability != 0)
			{
				num ^= this.StepProbability.GetHashCode();
			}
			if (this.StrParam.Length != 0)
			{
				num ^= this.StrParam.GetHashCode();
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
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LimitCount);
			}
			if (this.Rarity != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Rarity);
			}
			if (this.LvMax != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LvMax);
			}
			if (this.WeaponGroup != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.WeaponGroup);
			}
			if (this.WeaponScale != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.WeaponScale);
			}
			if (this.WeaponColor.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteBytes(this.WeaponColor);
			}
			if (this.EffectFolder != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EffectFolder);
			}
			if (this.HpBase != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HpBase);
			}
			if (this.HpMax != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.HpMax);
			}
			if (this.AtkBase != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.AtkBase);
			}
			if (this.AtkMax != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AtkMax);
			}
			if (this.CriticalWeight != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CriticalWeight);
			}
			if (this.Power != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Power);
			}
			if (this.Defense != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Defense);
			}
			if (this.Agility != 0)
			{
				output.WriteRawTag(128, 1);
				output.WriteInt32(this.Agility);
			}
			if (this.Magic != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.Magic);
			}
			if (this.Luck != 0)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt32(this.Luck);
			}
			if (this.TreasureDevice != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.TreasureDevice);
			}
			if (this.Policy != 0)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.Policy);
			}
			if (this.Personality != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt32(this.Personality);
			}
			if (this.Deity != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(this.Deity);
			}
			if (this.StepProbability != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.StepProbability);
			}
			if (this.StrParam.Length != 0)
			{
				output.WriteRawTag(194, 1);
				output.WriteBytes(this.StrParam);
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
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.Rarity != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rarity);
			}
			if (this.LvMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LvMax);
			}
			if (this.WeaponGroup != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponGroup);
			}
			if (this.WeaponScale != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponScale);
			}
			if (this.WeaponColor.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.WeaponColor);
			}
			if (this.EffectFolder != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectFolder);
			}
			if (this.HpBase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HpBase);
			}
			if (this.HpMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HpMax);
			}
			if (this.AtkBase != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtkBase);
			}
			if (this.AtkMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AtkMax);
			}
			if (this.CriticalWeight != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CriticalWeight);
			}
			if (this.Power != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Power);
			}
			if (this.Defense != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Defense);
			}
			if (this.Agility != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Agility);
			}
			if (this.Magic != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Magic);
			}
			if (this.Luck != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Luck);
			}
			if (this.TreasureDevice != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TreasureDevice);
			}
			if (this.Policy != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Policy);
			}
			if (this.Personality != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Personality);
			}
			if (this.Deity != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Deity);
			}
			if (this.StepProbability != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.StepProbability);
			}
			if (this.StrParam.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeBytesSize(this.StrParam);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_SVT_LIMIT other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SvtId != 0)
			{
				this.SvtId = other.SvtId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.Rarity != 0)
			{
				this.Rarity = other.Rarity;
			}
			if (other.LvMax != 0)
			{
				this.LvMax = other.LvMax;
			}
			if (other.WeaponGroup != 0)
			{
				this.WeaponGroup = other.WeaponGroup;
			}
			if (other.WeaponScale != 0)
			{
				this.WeaponScale = other.WeaponScale;
			}
			if (other.WeaponColor.Length != 0)
			{
				this.WeaponColor = other.WeaponColor;
			}
			if (other.EffectFolder != 0)
			{
				this.EffectFolder = other.EffectFolder;
			}
			if (other.HpBase != 0)
			{
				this.HpBase = other.HpBase;
			}
			if (other.HpMax != 0)
			{
				this.HpMax = other.HpMax;
			}
			if (other.AtkBase != 0)
			{
				this.AtkBase = other.AtkBase;
			}
			if (other.AtkMax != 0)
			{
				this.AtkMax = other.AtkMax;
			}
			if (other.CriticalWeight != 0)
			{
				this.CriticalWeight = other.CriticalWeight;
			}
			if (other.Power != 0)
			{
				this.Power = other.Power;
			}
			if (other.Defense != 0)
			{
				this.Defense = other.Defense;
			}
			if (other.Agility != 0)
			{
				this.Agility = other.Agility;
			}
			if (other.Magic != 0)
			{
				this.Magic = other.Magic;
			}
			if (other.Luck != 0)
			{
				this.Luck = other.Luck;
			}
			if (other.TreasureDevice != 0)
			{
				this.TreasureDevice = other.TreasureDevice;
			}
			if (other.Policy != 0)
			{
				this.Policy = other.Policy;
			}
			if (other.Personality != 0)
			{
				this.Personality = other.Personality;
			}
			if (other.Deity != 0)
			{
				this.Deity = other.Deity;
			}
			if (other.StepProbability != 0)
			{
				this.StepProbability = other.StepProbability;
			}
			if (other.StrParam.Length != 0)
			{
				this.StrParam = other.StrParam;
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
										if (num2 != 58u)
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
																									if (num2 != 176u)
																									{
																										if (num2 != 184u)
																										{
																											if (num2 != 194u)
																											{
																												input.SkipLastField();
																											}
																											else
																											{
																												this.StrParam = input.ReadBytes();
																											}
																										}
																										else
																										{
																											this.StepProbability = input.ReadInt32();
																										}
																									}
																									else
																									{
																										this.Deity = input.ReadInt32();
																									}
																								}
																								else
																								{
																									this.Personality = input.ReadInt32();
																								}
																							}
																							else
																							{
																								this.Policy = input.ReadInt32();
																							}
																						}
																						else
																						{
																							this.TreasureDevice = input.ReadInt32();
																						}
																					}
																					else
																					{
																						this.Luck = input.ReadInt32();
																					}
																				}
																				else
																				{
																					this.Magic = input.ReadInt32();
																				}
																			}
																			else
																			{
																				this.Agility = input.ReadInt32();
																			}
																		}
																		else
																		{
																			this.Defense = input.ReadInt32();
																		}
																	}
																	else
																	{
																		this.Power = input.ReadInt32();
																	}
																}
																else
																{
																	this.CriticalWeight = input.ReadInt32();
																}
															}
															else
															{
																this.AtkMax = input.ReadInt32();
															}
														}
														else
														{
															this.AtkBase = input.ReadInt32();
														}
													}
													else
													{
														this.HpMax = input.ReadInt32();
													}
												}
												else
												{
													this.HpBase = input.ReadInt32();
												}
											}
											else
											{
												this.EffectFolder = input.ReadInt32();
											}
										}
										else
										{
											this.WeaponColor = input.ReadBytes();
										}
									}
									else
									{
										this.WeaponScale = input.ReadInt32();
									}
								}
								else
								{
									this.WeaponGroup = input.ReadInt32();
								}
							}
							else
							{
								this.LvMax = input.ReadInt32();
							}
						}
						else
						{
							this.Rarity = input.ReadInt32();
						}
					}
					else
					{
						this.LimitCount = input.ReadInt32();
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
